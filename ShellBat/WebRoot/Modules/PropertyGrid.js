import * as Tools from "./Tools.js";

export { PropertyGrid };
export { IEditor };
export { BooleanEditor };
export { StringEditor };
export { EnumEditor };
export { KeyBindingEditor };

class IEditor {
    constructor(grid) {
        this.grid = grid;
    }

    async render(cell, property) {
        const value = await this.grid.instance.getValue(property.name);
        if (property.isHtml) {
            cell.innerHTML = value || "";
        }
        else {
            cell.innerText = value || "";
        }
    }
}

class PropertyGrid extends EventTarget {
    async #initialize(wpg) {
        this.properties = [];
        const properties = await wpg.properties;
        await Promise.all(properties.map(async prop => {
            const property = {};
            property.name = await prop.key;
            property.editor = await prop.editor;
            property.categoryName = await prop.categoryName;
            property.displayName = await prop.displayName;
            property.tooltip = await prop.tooltip;
            property.hasDefault = await prop.hasDefault;
            property.defaultValue = await prop.defaultValue;
            property.isReadOnly = await prop.isReadOnly;
            property.isEnum = await prop.isEnum;
            property.isFlagsEnum = await prop.isFlagsEnum;
            property.isHidden = await prop.isHidden;
            property.isHtml = await prop.isHtml;
            property.baseClassName = await prop.baseClassName;
            property.enumValues = {};
            const enumValues = await prop.enumValues;
            if (enumValues) {
                await Promise.all(enumValues.map(async ev => {
                    property.enumValues[await ev.key] = await ev.value;
                }));
            }
            this.properties.push(property);
        }));
        this.instance = await wpg.instance;

        const options = await wpg.options;
        this.options = {};
        this.options.title = await options.title;
        this.options.isReadOnly = await options.isReadOnly;
        this.options.expandIfOneCategory = await options.expandIfOneCategory;
        this.options.propertyNamePostfix = await options.propertyNamePostfix;
        this.options.groupByCategory = await options.groupByCategory;
        this.options.defaultCategoryName = await options.defaultCategoryName;
        this.options.resourcePrefix = await options.resourcePrefix;
        this.options.baseClassName = await options.baseClassName;
        this.options.swalClassName = await options.swalClassName;
        const categories = await options.categories;
        this.options.categories = [];
        await Promise.all(categories.map(async c => {
            const category = {};
            category.name = await c.key;
            category.displayName = await c.displayName;
            category.collapsed = await c.collapsed;
            category.sortOrder = await c.sortOrder;
            this.options.categories.push(category);
        }));

        this.baseClassName = this.options.baseClassName || "pg";

        this.editors = {};
        this.editors["Boolean"] = BooleanEditor;
        this.editors["NullableBoolean"] = NullableBooleanEditor;
        this.editors["Enum"] = EnumEditor;
        this.editors["String"] = StringEditor;
        this.editors["KeyBinding"] = KeyBindingEditor;
    }

    #drawTooltip(categoryGroup) {
        const collapsed = categoryGroup.hasAttribute("collapsed");
        const tt = collapsed ? Tools.Resource("ExpandOthers", { others: categoryGroup.others }) : Tools.Resource("Collapse");
        categoryGroup.expanderCell.setAttribute("tooltip", tt);
    }

    async #getEditorInstance(property) {
        let editorName = property.editor;
        if (!editorName || !this.editors[editorName]) {
            if (property.isEnum) {
                editorName = "Enum";
            }
        }

        const editorType = this.editors[editorName] || this.editors["String"];
        return new editorType(this);
    }

    async #drawPropertyRow(property) {
        if (property.isHidden)
            return null;

        const baseClassName = (property.baseClassName || this.baseClassName);
        let propertyRow = this.propertyRows ? this.propertyRows[property.name] : null;
        if (!propertyRow) {
            propertyRow = document.createElement("div");
            propertyRow.className = baseClassName + "-property";
            const nameCell = document.createElement("div");
            nameCell.className = baseClassName + "-name";
            nameCell.innerHTML = property.displayName || property.name;

            const propertyNamePostfix = await this.options.propertyNamePostfix;
            if (propertyNamePostfix) {
                nameCell.innerHTML += propertyNamePostfix;
            }

            const tt = res[this.options.resourcePrefix + property.name] || property.tooltip;
            if (tt) {
                propertyRow.setAttribute("tooltip", tt);
            }

            propertyRow.appendChild(nameCell);

            const valueCell = document.createElement("div");
            valueCell.className = baseClassName + "-value";
            if (this.options.isReadOnly || property.isReadOnly) {
                valueCell.classList.add(baseClassName + "-value-readonly");
            }
            const editorInstance = await this.#getEditorInstance(property);
            editorInstance.render(valueCell, property);

            propertyRow.appendChild(valueCell);
            this.table.appendChild(propertyRow);

            this.propertyRows = this.propertyRows || {};
            this.propertyRows[property.name] = propertyRow;
        }
        else {
            const editorInstance = await this.#getEditorInstance(property);
            const valueCell = propertyRow.querySelector("." + baseClassName + "-value");
            valueCell.innerHTML = "";
            editorInstance.render(valueCell, property);
        }

        return propertyRow;
    }

    _raisePropertyChanged(property, value) {
        var event = new CustomEvent("propertyChanged", { detail: { property: property, value: value } });
        this.dispatchEvent(event);
    }

    async getPropertyValue(propertyName) {
        if (!propertyName)
            return null;

        return this.instance.getValue(propertyName);
    }

    async drawControl(id, controlRender, options) {
        if (!id || !controlRender)
            return null;

        let control = this.controls ? this.controls[id] : null;
        if (!control) {
            control = document.createElement("div");
            control.className = options?.className || this.baseClassName + "-property";

            const tt = options?.tooltip;
            if (tt) {
                control.setAttribute("tooltip", tt);
            }

            this.table.appendChild(control);
            controlRender(control);

            this.controls = this.controls || {};
            this.controls[id] = control;
        }
        else {
            controlRender(control);
        }
        return control;
    }

    async draw(container, wpg) {
        await this.#initialize(wpg);

        this.table = document.createElement("div");
        this.table.className = this.baseClassName + "-grid";

        const groupByCategory = await this.options.groupByCategory;
        if (groupByCategory) {
            const defaultCategoryName = this.options.defaultCategoryName || "General";
            const result = Object.groupBy(this.properties, ({ categoryName }) => categoryName || defaultCategoryName);
            const categories = Object.getOwnPropertyNames(result);
            // if at least one category has sortOrder, sort categories by sortOrder
            const hasSortOrder = this.options.categories?.some(c => c.sortOrder !== undefined);
            if (hasSortOrder) {
                categories.sort((a, b) => {
                    const categoryA = this.options.categories?.find(c => c.name.toLowerCase() == a.toLowerCase());
                    const categoryB = this.options.categories?.find(c => c.name.toLowerCase() == b.toLowerCase());
                    const sortOrderA = categoryA?.sortOrder || 0;
                    const sortOrderB = categoryB?.sortOrder || 0;
                    return sortOrderA - sortOrderB;
                });
            }

            for (let i = 0; i < categories.length; i++) {
                const category = this.options.categories?.find(c => c.name.toLowerCase() == categories[i].toLowerCase()) || { name: categories[i] };

                const categoryGroup = document.createElement("div");
                categoryGroup.className = this.baseClassName + "-category";
                Tools.setOrRemoveAttribute(categoryGroup, "collapsed", category.collapsed);
                categoryGroup.others = result[category.name].map(p => p.name).join(", ");

                const categoryHeader = document.createElement("div");
                categoryHeader.className = this.baseClassName + "-category-header";

                const categoryCell = document.createElement("div");
                categoryCell.className = this.baseClassName + "-category-value";
                categoryCell.innerText = category.displayName || category.name;
                categoryHeader.appendChild(categoryCell);

                const expanderCell = document.createElement("div");
                expanderCell.className = this.baseClassName + "-category-expander";
                categoryHeader.appendChild(expanderCell);

                categoryGroup.appendChild(categoryHeader);
                categoryGroup.expanderCell = expanderCell;
                this.#drawTooltip(categoryGroup);
                this.table.appendChild(categoryGroup);

                const categoryBody = document.createElement("div");
                categoryBody.className = this.baseClassName + "-category-body";
                if (category.collapsed && (categories.length > 1 || !this.options.expandIfOneCategory)) {
                    categoryBody.style.height = "0px";
                }
                categoryGroup.appendChild(categoryBody);

                categoryHeader.onclick = e => {
                    if (Tools.toggleAttribute(categoryGroup, "collapsed")) {
                        Tools.expandElement(categoryBody);
                    }
                    else {
                        Tools.collapseElement(categoryBody);
                    }
                    this.#drawTooltip(categoryGroup);
                };

                for (let j = 0; j < result[category.name].length; j++) {
                    const property = result[category.name][j];
                    const propertyRow = await this.#drawPropertyRow(property);
                    if (propertyRow) {
                        categoryBody.appendChild(propertyRow);
                    }
                }
            }
        }
        else {
            for (let i = 0; i < this.properties.length; i++) {
                const property = this.properties[i];
                const propertyRow = await this.#drawPropertyRow(property);
                if (propertyRow) {
                    this.table.appendChild(propertyRow);
                }
            }
        }

        container.appendChild(this.table);
    }

    async update(wpg) {
        this.instance = await wpg.instance;
        for (let i = 0; i < this.properties.length; i++) {
            const property = this.properties[i];
            await this.#drawPropertyRow(property);
        }
    }
}

class BooleanEditor extends IEditor {
    constructor(grid) {
        super(grid);
    }

    setValue(input, value) {
        if (value) {
            input.checked = true;
        }
    }

    getValue(input) {
        return input.checked;
    }

    async render(cell, property) {
        const value = await this.grid.instance.getValue(property.name);

        let input = cell.querySelector("input");
        if (!input) {
            input = document.createElement("input");
            input.type = "checkbox";
            cell.appendChild(input);
        }

        this.setValue(input, value);

        if (this.grid.options.isReadOnly || property.isReadOnly) {
            input.setAttribute("disabled", "true");
        }

        cell.onclick = async e => {
            const value = this.getValue(input);
            if (await this.grid.instance.setValue(property.name, value)) {
                this.grid._raisePropertyChanged(property, value);
            }
        };
    }
}

class NullableBooleanEditor extends BooleanEditor {
    constructor(grid) {
        super(grid);
    }

    setValue(input, value) {
        if (value === true) {
            input._ind = false;
            input.checked = true;
        }
        else if (value === false) {
            input._ind = false;
            input.checked = false;
        }
        else {
            input._ind = true;
            input.indeterminate = true;
        }

        input.onclick = () => {
            if (input._ind) {
                input._ind = false;
                input.checked = true;
            } else if (!input.checked) {
                input._ind = false;
                input.checked = false;
            } else {
                input._ind = true;
                input.indeterminate = true;
            }
        }
    }

    getValue(input) {
        if (input._ind)
            return null;

        return input.checked;
    }
}

class StringEditor extends IEditor {
    constructor(grid) {
        super(grid);
    }

    async render(cell, property) {
        if (this.grid.options.isReadOnly || property.isReadOnly) {
            super.render(cell, property);
            return;
        }

        let input = cell.querySelector("input");
        if (!input) {
            input = document.createElement("input");
            input.id = this.grid.baseClassName + "-value-string-" + property.name;
            input.name = input.id;
            input.type = "text";
            cell.appendChild(input);
        }

        const value = await this.grid.instance.getValue(property.name);
        input.value = value || "";
        input.readOnly = this.grid.options.isReadOnly || property.isReadOnly || false;
        if (input.readOnly) {
            input.setAttribute("disabled", "true");
        }

        cell.addEventListener("change", async e => {
            if (await this.grid.instance.setValue(property.name, input.value)) {
                this.grid._raisePropertyChanged(property, input.value);
            }
        });
    }
}

class EnumEditor extends IEditor {
    constructor(grid) {
        super(grid);
    }

    async render(cell, property) {
        if (property.isReadOnly) {
            super.render(cell, property);
            return;
        }

        const value = await this.grid.instance.getValue(property.name);
        let select = cell.querySelector("select");
        if (!select) {
            select = document.createElement("select");
            select.id = this.grid.baseClassName + "-value-enum-" + property.name;
            cell.appendChild(select);
        }

        for (const [name, enumValue] of Object.entries(property.enumValues)) {
            let option = Array.from(select.options).find(o => o.value == enumValue);
            if (!option) {
                option = document.createElement("option");
                option.value = enumValue;
                select.add(option);
            }

            option.text = name;
            if (property.isFlagsEnum) {
                if ((value & enumValue) === enumValue) {
                    option.selected = true;
                }
            }
            else {
                if (enumValue === value) {
                    option.selected = true;
                }
            }
        }

        cell.addEventListener("change", async e => {
            if (await this.grid.instance.setValue(property.name, select.value)) {
                this.grid._raisePropertyChanged(property, select.value);
            }
        });
    }
}

class KeyBindingEditor extends IEditor {
    constructor(grid) {
        super(grid);
    }

    async render(cell, property) {
        const json = await this.grid.instance.getValue(property.name);
        const commandKey = json ? JSON.parse(json) : null;
        this.commandName = commandKey?.commandName;
        this.originalCommandText = commandKey.commandText;
        this.defaultCommandText = commandKey.defaultCommandText;

        let input = cell.querySelector("input");
        if (!input) {
            input = document.createElement("input");
            input.id = this.grid.baseClassName + "-value-keybinding-" + property.name;
            input.name = input.id;
            input.type = "text";
            cell.appendChild(input);

            input.addEventListener("input", (e) => {
                if (this.inDeadLoop) {
                    this.inDeadLoop = false;
                    input.value = this.savedInputValue;
                    return;
                }
            });

            input.addEventListener("keydown", (e) => {
                //console.log(`KeyDown: code=${e.code}, key=${e.key}, type=${e.type}, shift=${e.shiftKey}, ctrl=${e.ctrlKey}, alt=${e.altKey}, meta=${e.metaKey}`);
                if (e.key === "Dead") {
                    e.preventDefault();
                    e.stopPropagation();
                    this.inDeadLoop = true;
                    this.savedInputValue = input.value;
                    return;
                }

                if (e.key === "Delete") {
                    if (e.shiftKey) { // reset to default
                        if (input.value != this.defaultCommandText) {
                            input.value = this.defaultCommandText;
                            this.grid.instance.setValue(property.name, JSON.stringify({
                                commandName: this.commandName,
                                commandText: this.defaultCommandText,
                            }));
                        }
                    }
                    else if (input.value != this.originalCommandText) {
                        input.value = this.originalCommandText;
                        this.grid.instance.setValue(property.name, JSON.stringify({
                            commandName: this.commandName,
                            commandText: this.originalCommandText,
                        }));
                    }
                    return;
                }

                const newKeyJson = syncDotnet.validateCommandKey({
                    code: e.code, key: e.key, type: e.type, shift: e.shiftKey, ctrl: e.ctrlKey, alt: e.altKey, meta: e.metaKey,
                    commandName: this.commandName
                });
                if (!newKeyJson)
                    return;

                const newCommandKey = JSON.parse(newKeyJson);
                if (newCommandKey.preventDefault) {
                    e.preventDefault();
                    e.stopPropagation();
                }

                if (!newCommandKey.isValid) {
                    if (newCommandKey.errorText) {
                        window.showToast(newCommandKey.errorText);
                    }
                    return;
                }

                if (input.value != newCommandKey.commandText) {
                    input.value = newCommandKey.commandText;
                    newCommandKey.commandName = this.commandName;
                    this.grid.instance.setValue(property.name, JSON.stringify(newCommandKey));
                }
            });
        }

        input.value = this.originalCommandText || "";
        input.readOnly = this.grid.options.isReadOnly || property.isReadOnly || false;
        if (input.readOnly) {
            input.setAttribute("disabled", "true");
        }
    }
}


