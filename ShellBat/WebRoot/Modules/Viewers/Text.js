import * as Tools from "../Tools.js";
import * as Scrollbar from "../Scrollbar.js";
import * as PropertyGrid from "../PropertyGrid.js";

export { Viewer };

// note: for some reason private methods (#) are not allowed here
class Viewer {
    async update(win, element, viewer) {
        this.viewer = viewer;
        this.element = element;
        element.innerHTML = "";
        this.propertiesElement = null;

        await this._loadProperties();

        this.container = document.createElement("div");
        element.appendChild(this.container);
        this.container.className = "viewer-Text-container";

        this.textContainer = document.createElement("div");
        this.textContainer.className = "viewer-Text-container-text";
        this.container.appendChild(this.textContainer);

        this.vs = new Scrollbar.VerticalScrollbar(this.container);
        this.vs.addEventListener("scroll", () => {
            this._loadText();
        });

        this._loadText();
    }

    resize() {
        this._loadText();
    }

    move() {
    }

    hide() {
    }

    show() {
    }

    dispose() {
    }

    async _loadProperties() {
        const properties = await this.viewer.getProperties();
        if (!properties)
            return;

        if (!this.propertiesElement) {
            this.pg = new PropertyGrid.PropertyGrid();
            this.pg.addEventListener("propertyChanged", async (evt) => {
                const name = evt.detail.property.name.toLowerCase();
                switch (name) {
                    case "wrap":
                        this._loadText();
                        break;

                    default:
                        const text = await this.viewer.getText(this.vs.offset, this.vs.viewport);
                        this.textContainer.innerHTML = text;
                        break;
                }
            });

            this.propertiesElement = document.createElement("div");
            this.propertiesElement.className = "viewer-Text-pg";
            this.element.appendChild(this.propertiesElement);
            await this.pg.draw(this.propertiesElement, properties);
        }
        else {
            await this.pg.update(properties);
        }
    }

    async _updateScrollbar() {
        const loaded = await this.viewer.isLoaded;
        const totalLines = await this.viewer.totalLines;
        if (totalLines == this.totalLines)
            return;

        const viewPort = Math.floor(this.container.scrollHeight / this.lineHeight);
        this.vs.update({
            viewport: viewPort,
            extent: totalLines
        });
        this.totalLines = totalLines;

        if (!loaded) {
            setTimeout(() => this._updateScrollbar(), 200);
        }
    }

    async _loadText() {
        this.totalLines = await this.viewer.totalLines;
        setTimeout(() => this._updateScrollbar(), 200);

        this.lineHeight = Tools.getLineHeight(this.textContainer);
        const viewPort = Math.floor(this.container.scrollHeight / this.lineHeight);
        this.vs.update({
            viewport: viewPort,
            extent: this.totalLines
        });

        const text = await this.viewer.getText(this.vs.offset, this.vs.viewport);
        this.textContainer.innerHTML = text;
        this._loadProperties();
    }
}
