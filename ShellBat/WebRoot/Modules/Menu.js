import * as Tools from "./Tools.js";

export { Menu };

class Menu {
    #initialize(configuration) {
        this.configuration = configuration || {};
        this.options = this.configuration.options || {};
        this.baseClassName = this.options.className;
        this.rootMenu = this.configuration.menu || {};
        this.left = this.options.left || 0;
        this.top = this.options.top || 0;
        this.id = this.options.id || 0;
    }

    #drawSubMenu(itemElement) {
        const item = itemElement.item;
        const level = item._level + 1;
        const id = this.id + "-sub-" + level + "-" + item._index;
        const name = Menu.#getMenuElementName(level);
        // already opened?
        if (document[name]?.id == id)
            return document[name];

        // remove existing submenu
        document[name]?.remove();

        const subMenuElement = document.createElement("div");
        subMenuElement.id = id;
        subMenuElement.keyboardIndex = -1;
        subMenuElement.item = item;
        subMenuElement.menu = this;
        subMenuElement.className = this.baseClassName;
        subMenuElement.classList.add(this.baseClassName + "-" + level);

        if (!item.isDisabled) {
            if (item.onclick) {
                subMenuElement.onclick = (e) => item.onclick(e, item, ...arguments);
            }
            else if (this.options.onclick) {
                subMenuElement.onclick = (e) => this.options.onclick(e, item, ...arguments);
            }
        }

        this.#drawMenuItems(subMenuElement, level + 1, item);
        document[name] = subMenuElement;
        document.menuLevels = level;
        document.body.appendChild(subMenuElement);

        const rc = itemElement.getBoundingClientRect();
        const left = rc.right - rc.height;
        const top = rc.bottom - rc.height / 2;
        Tools.placeElementAtCursor(subMenuElement, left, top, this.options.subMenuOffsetX, this.options.subMenuOffsetY);
        return subMenuElement;
    }

    #drawMenuItems(parentElement, level, menu) {
        const animationShow = this.options.animations?.show;
        if (animationShow) {
            parentElement.classList.add("animate__animated");
            parentElement.classList.add("animate__" + animationShow);
            const animationDuration = this.options.animations?.duration || ".3s";
            parentElement.style.setProperty('--animate-duration', animationDuration);
            parentElement.animationHide = this.options.animations?.hide;
        }

        let i = 0;
        for (let item of menu.items || []) {
            if (item.isHidden)
                continue;

            item._index = i++;
            item._level = level;
            const itemElement = document.createElement("div");
            itemElement.item = item;
            if (item.isSeparator) {
                itemElement.className = this.baseClassName + "-separator";
            }
            else {
                itemElement.innerHTML = item.html || "";
                itemElement.className = this.baseClassName + "-item";

                if (item.tooltip) {
                    itemElement.setAttribute("tooltip", item.tooltip);
                }

                // build sub items if any
                if (item.items && item.items.length > 0) {
                    itemElement.className = this.baseClassName + "-items";
                    if (!item.isDisabled) {
                        itemElement.onmousemove = () => {
                            Tools.runOnceOnHover(itemElement, () => {
                                this.#drawSubMenu(itemElement);
                            }, this.options.subMenuOpenDelay || 400);
                        }
                    }
                }
                else {
                    if (!item.isDisabled) {
                        itemElement.addEventListener("mousemove", Menu.#dismissSubMenu);
                    }
                }
            }

            if (!item.isDisabled) {
                if (item.onclick) {
                    itemElement.onclick = (e) => item.onclick(e, item, ...arguments);
                }
                else {
                    if (this.options.onclick) {
                        itemElement.onclick = (e) => this.options.onclick(e, item, ...arguments);
                    }
                }
            }

            if (item.className) {
                itemElement.classList.add(item.className);
            }

            if (item.isChecked) {
                itemElement.classList.add("checked");
            }

            parentElement.appendChild(itemElement);

            if (item.icon) {
                const iconElement = document.createElement("i");
                iconElement.className = this.baseClassName + "-icon";
                iconElement.classList.add(...item.icon.split(" "));
                itemElement.insertBefore(iconElement, itemElement.firstChild);

                if (!item.isDisabled) {
                    if (item.onclick) {
                        iconElement.onclick = (e) => item.onclick(e, item, ...arguments);
                    }
                    else {
                        if (this.options.onclick) {
                            iconElement.onclick = (e) => this.options.onclick(e, item, ...arguments);
                        }
                    }
                }
            }
            else if (item.iconPath) {
                const iconElement = document.createElement("img");
                iconElement.src = item.iconPath;
                itemElement.insertBefore(iconElement, itemElement.firstChild);
                if (!item.isDisabled) {
                    if (item.onclick) {
                        iconElement.onclick = (e) => item.onclick(e, item, ...arguments);
                    }
                    else {
                        if (this.options.onclick) {
                            iconElement.onclick = (e) => this.options.onclick(e, item, ...arguments);
                        }
                    }
                }
            }
        }
    }

    #drawRootMenu(options) {
        // already opened?
        if (document.rootMenuElement?.id == this.id)
            return;

        const left = options.left || 0;
        const top = options.top || 0;
        const level = options.level || 0;

        // remove existing menu
        Menu.dismissRootMenu();

        // build root menu element
        const rootMenuElement = document.createElement("div");
        rootMenuElement.menu = this;
        rootMenuElement.id = this.id;
        rootMenuElement.keyboardIndex = -1;
        rootMenuElement.className = this.baseClassName;
        rootMenuElement.classList.add(this.baseClassName + "-" + level);

        if (this.options.onclick) {
            rootMenuElement.onclick = (e) => {
                if (!e.target.item || !e.target.item.isDisabled) {
                    this.options.onclick(e, e.target.item, ...arguments);
                }
            }
        }

        // dismiss menu on click outside or on Escape key
        document.addEventListener("click", Menu.dismissRootMenu);
        document.addEventListener("keydown", Menu.dismissRootMenu);

        this.#drawMenuItems(rootMenuElement, level, this.rootMenu);

        // store root menu element in document
        document.rootMenuElement = rootMenuElement;
        document.keyboardElement = rootMenuElement;
        document.body.appendChild(rootMenuElement);

        // show menu at cursor position
        Tools.placeElementAtCursor(rootMenuElement, left, top);
        window.GlobalEvents.setGlobalEvent("ContextMenuShown");

        setTimeout(() => this.select(this.configuration.selectPath), this.options.subMenuOpenDelay || 400);
    }

    static #handleMenuKeydown(e, menuElement) {
        let itemElement;
        switch (e.code) {
            case "Return":
            case "Enter":
                itemElement = menuElement.children[menuElement.keyboardIndex];
                const item = itemElement?.item;
                if (item && !item.isDisabled && !item.isSeparator && (!item.items || item.items == 0)) {
                    itemElement.click();
                    return true;
                }
                return false;

            case "Tab":
                window.GlobalEvents.setGlobalEvent("ContextMenuNavigation", { id: document.rootMenuElement?.id, srcEvent: e });
                return false;

            case "Delete":
                itemElement = menuElement.children[menuElement.keyboardIndex];
                if (itemElement?.item?.onDelete) {
                    itemElement.item.onDelete();
                    return true;
                }
                return false;

            case "ArrowRight":
                itemElement = menuElement.children[menuElement.keyboardIndex];
                if (itemElement?.item?.items && itemElement?.item.items.length > 0) {
                    const menu = itemElement.parentElement.menu;
                    const subMenuElement = menu.#drawSubMenu(itemElement);

                    Menu.#removeKeyClass(menuElement);

                    subMenuElement.keyboardIndex = 0;
                    const firstItemElement = subMenuElement.children[subMenuElement.keyboardIndex];
                    firstItemElement.classList.add("key");
                    document.keyboardElement = subMenuElement;
                    return true;
                }
                return false;

            case "ArrowLeft":
                if (document.keyboardElement && document.keyboardElement.item) {
                    const level = document.keyboardElement.item._level;
                    Menu.#dismissSubMenus(level + 1);
                    const name = Menu.#getMenuElementName(level);
                    document.keyboardElement = document[name] || document.rootMenuElement;
                    const highlightedIndex = document.keyboardElement.keyboardIndex;

                    Menu.#removeKeyClass(document.keyboardElement);
                    if (highlightedIndex >= 0) {
                        const highlightedItemElement = document.keyboardElement.children[highlightedIndex];
                        highlightedItemElement.classList.add("key");
                    }
                    return true;
                }
                return false;
        }

        do {
            switch (e.code) {
                case "ArrowUp":
                    if (menuElement.keyboardIndex <= 0) {
                        menuElement.keyboardIndex = 0;
                    }
                    else {
                        menuElement.keyboardIndex--;
                    }
                    break;

                case "ArrowDown":
                    if (menuElement.keyboardIndex >= menuElement.children.length - 1) {
                        menuElement.keyboardIndex = menuElement.children.length - 1;
                    }
                    else {
                        menuElement.keyboardIndex++;
                    }
                    break;

                case "Home":
                    menuElement.keyboardIndex = 0;
                    break;

                case "End":
                    menuElement.keyboardIndex = menuElement.children.length - 1;
                    break;

                case "PageUp":
                    menuElement.keyboardIndex -= window.paging;
                    if (menuElement.keyboardIndex < 0) {
                        menuElement.keyboardIndex = 0;
                    }
                    break;

                case "PageDown":
                    menuElement.keyboardIndex += window.paging;
                    if (menuElement.keyboardIndex >= menuElement.children.length) {
                        menuElement.keyboardIndex = menuElement.children.length - 1;
                    }
                    break;

                default:
                    return false;
            }

            itemElement = menuElement.children[menuElement.keyboardIndex];
            const item = itemElement.item;
            if (!item.isSeparator && !item.isDisabled)
                break;
        }
        while (true);

        for (let i = 0; i < menuElement.children.length; i++) {
            const itemElement = menuElement.children[i];
            if (i === menuElement.keyboardIndex) {
                itemElement.classList.add("key");
                Tools.scrollIntoViewIfNeeded(itemElement);
            }
            else {
                itemElement.classList.remove("key");
            }
        }

        return true;
    }

    static #removeKeyClass(menuElement) {
        for (let i = 0; i < menuElement.children.length; i++) {
            const itemElement = menuElement.children[i];
            itemElement.classList.remove("key");
        }
    }

    static #getMenuElementName(level) {
        return "rootMenuElement" + level;
    }

    static #dismissSubMenu(event) {
        const item = event.target.item;
        if (item) {
            Menu.#dismissSubMenus(item._level);
        }
    }

    static #dismissSubMenus(fromLevel) {
        // remove sub levels
        const menuLevels = document.menuLevels || 0;
        for (let level = fromLevel || 0; level <= menuLevels; level++) {
            const name = Menu.#getMenuElementName(level);
            var menuElement = document[name];
            if (menuElement) {
                // remove menu with animation
                const animationHide = menuElement.animationHide;
                if (animationHide) {
                    menuElement.classList.add("animate__" + animationHide);
                    menuElement.addEventListener('animationend', () => {
                        menuElement.remove();
                    });
                }
                else {
                    menuElement.remove();
                }
            }

            delete document[name];
        }
    }

    draw(configuration) {
        this.#initialize(configuration);
        this.#drawRootMenu({ left: this.left, top: this.top });
    }

    select(path) {
        if (!path || path.length === 0)
            return;

        const menuElement = document.rootMenuElement;
        if (!menuElement)
            return;

        let currentMenuElement = menuElement;
        for (let id of path) {
            id = id.toLowerCase();
            let found = false;
            for (let i = 0; i < currentMenuElement.children.length; i++) {
                const itemElement = currentMenuElement.children[i];
                const item = itemElement.item;
                if (!item)
                    continue;

                if (item.id?.toLowerCase() === id || item.html?.toLowerCase() === id) {
                    // open submenu if any
                    if (item.items && item.items.length > 0) {
                        currentMenuElement = this.#drawSubMenu(itemElement);
                        document.keyboardElement = currentMenuElement;
                    }
                    else {
                        // highlight item
                        Menu.#removeKeyClass(currentMenuElement);
                        itemElement.classList.add("key");
                        currentMenuElement.keyboardIndex = i;
                    }
                    found = true;
                    break;
                }
            }
            if (!found)
                break;
        }
    }

    static dismissRootMenu(event) {
        if (event && event.type === "keydown" && event.key !== "Escape")
            return;

        if (event && event.srcElement && event.srcElement.item && event.srcElement.item.isDisabled)
            return;

        const rootMenuElement = document.rootMenuElement;
        if (rootMenuElement) {
            document.removeEventListener("click", Menu.dismissRootMenu);
            document.removeEventListener("keydown", Menu.dismissRootMenu);

            // remove root menu with animation
            const animationHide = rootMenuElement.animationHide;
            if (animationHide) {
                window.GlobalEvents.setGlobalEvent("ContextMenusDismissed");
                rootMenuElement.classList.add("animate__" + animationHide);
                rootMenuElement.addEventListener('animationend', () => {
                    rootMenuElement.remove();
                });
            }
            else {
                rootMenuElement.remove();
            }

            document.rootMenuElement = null;
            document.keyboardElement = null;
            Menu.#dismissSubMenus();
        }
    }

    static handleKeydown(e) {
        const menuElement = document.keyboardElement || document.rootMenuElement;
        if (!menuElement)
            return;

        Menu.#handleMenuKeydown(e, menuElement);
        return true; // a menu capture all keyboard events
    }

    static async getItems(menuItems, actionExecutor) {
        let results = [];
        for (let item of menuItems) {
            results.push(await Menu.getItem(item, actionExecutor));
        }
        return results;
    }

    static async getItem(menuItem, actionExecutor) {
        const id = await menuItem.id;
        const items = await menuItem.items;
        return {
            id: id,
            html: await menuItem.html,
            icon: await menuItem.icon,
            iconPath: await menuItem.iconPath,
            className: await menuItem.className,
            tooltip: await menuItem.tooltip,
            isSeparator: await menuItem.isSeparator,
            isChecked: await menuItem.isChecked,
            isDisabled: await menuItem.isDisabled,
            items: items ? await Menu.getItems(items, actionExecutor) : null,
            onclick: (e) => {
                actionExecutor.executeAction(id);
                e.preventDefault();
            }
        };
    }
}