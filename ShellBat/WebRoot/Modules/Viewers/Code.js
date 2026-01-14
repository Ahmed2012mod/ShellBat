import * as PropertyGrid from "../PropertyGrid.js";

export { Viewer };

// note: for some reason private methods (#) are not allowed here
class Viewer {
    async update(win, element, viewer) {
        this.viewer = viewer;

        if (!this.container) {
            this.container = document.createElement("div");
            this.container.className = "viewer-Code-container";
            element.appendChild(this.container);
        }

        await this._loadProperties();

        if (!this.editor) {
            const json = await viewer.getOptions();
            const options = JSON.parse(json);
            this.editor = monaco.editor.create(this.container, options);

            this._loadText();
        }
        else {
            this._loadText();
        }
    }

    resize() {
        this.editor?.layout();
    }

    move() {
    }

    hide() {
    }

    show() {
    }

    dispose() {
        this.editor?.dispose();
        this.editor = null;
        this.container?.remove();
        this.container = null;
        this.propertiesElement = null;
        this.pg = null;
    }

    async _loadProperties() {
        const properties = await this.viewer.getProperties();
        if (!properties)
            return;

        if (!this.propertiesElement) {
            this.pg = new PropertyGrid.PropertyGrid();
            this.pg.addEventListener("propertyChanged", (evt) => {
                const name = evt.detail.property.name.toLowerCase();
                switch (name) {
                    case "minimap":
                        this.editor.updateOptions({ minimap: { enabled: evt.detail.value } });
                        break;

                    case "theme":
                        monaco.editor.setTheme(evt.detail.value);
                        break;

                    case "language":
                        monaco.editor.setModelLanguage(this.editor.getModel(), evt.detail.value);
                        break;
                }
            });

            this.propertiesElement = document.createElement("div");
            this.propertiesElement.className = "viewer-Code-pg";
            await this.pg.draw(this.propertiesElement, properties);
            this.container.appendChild(this.propertiesElement);
        }
        else {
            await this.pg.update(properties);
        }
    }

    _loadText() {
        this.editor.setValue("");
        this._loadChunk();
    }

    async _loadChunk() {
        const text = await this.viewer.loadChunk();
        if (text === null) {
            this._moveEditorTo(1, 1);
            return;
        }

        let model = this.editor.getModel();
        if (model) {
            const lines = model.getLineCount();
            const col = model.getLineMaxColumn(lines);
            const range = new monaco.Range(lines, col, lines, col);
            this.editor.executeEdits("", [{ range: range, text: text }]);
            this.editor?.layout();
            setTimeout(() => this._loadChunk(), 0);
        }
    }

    _moveEditorTo(column, lineNumber) {
        if (!column) {
            if (!lineNumber)
                return;

            column = this.editor.getPosition().column;
        }

        if (!lineNumber) {
            lineNumber = this.editor.getPosition().lineNumber;
        }

        if (column == 2147483647) {
            column = this.editor.getModel().getLineLength(this.editor.getPosition().lineNumber) + 1;
        }

        if (lineNumber == 2147483647) {
            lineNumber = this.editor.getModel().getLineCount();
        }

        const position = {
            column: column,
            lineNumber: lineNumber
        };
        this.editor.setPosition(position);
        this.editor.revealPosition(position);
    }
}
