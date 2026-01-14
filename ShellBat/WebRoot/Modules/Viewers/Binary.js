import * as Tools from "../Tools.js";
import * as Scrollbar from "../Scrollbar.js";
import * as PropertyGrid from "../PropertyGrid.js";

export { Viewer };

// note: for some reason private methods (#) are not allowed here
class Viewer {
    async update(win, element, viewer) {
        this.viewer = viewer;
        this.element = element;

        if (!this.container) {
            this.container = document.createElement("div");
            this.container.className = "viewer-Binary-container";
            element.appendChild(this.container);
        }

        await this._loadProperties();

        if (!this.preContainer) {
            this.preContainer = document.createElement("div");
            this.preContainer.className = "viewer-Binary-pre-container";
            this.container.appendChild(this.preContainer);
        }

        if (!this.pre) {
            this.pre = document.createElement("pre");
            this.preContainer.appendChild(this.pre);
        }

        if (!this.vs) {
            this.vs = new Scrollbar.VerticalScrollbar(this.preContainer);
            this._computeScrollbarHeight();
            this.vs.addEventListener("scroll", () => {
                this._loadText();
            });
        }

        this._loadText();
    }

    async goToPosition(position) {
        if (!this.vs)
            return;

        const bytesPerRow = await this.viewer.bytesPerRow;
        const offset = Math.floor(position / bytesPerRow);
        setTimeout(() => {
            this.vs.setOffset(offset);
        }, 100);
    }

    setOptions(options) {
        if (options.position) {
            this.goToPosition(options.position);
        }
    }

    resize() {
        this._computeScrollbarHeight();
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

    _computeScrollbarHeight() {
        // for some reason, pre container gets one extra line height (independently from totalLines + 1 below)
        // bit of a hack: reduce the height by one line
        if (this.pre && this.vs.element) {
            const lineHeight = Tools.getLineHeight(this.pre);
            this.vs.element.style.height = (this.container.clientHeight - lineHeight) + "px";
        }
    }

    async _loadProperties() {
        const properties = await this.viewer.getProperties();
        if (!properties)
            return;

        if (!this.propertiesElement) {
            this.pg = new PropertyGrid.PropertyGrid();
            this.pg.addEventListener("propertyChanged", () => {
                this._loadText();
            });

            this.propertiesElement = document.createElement("div");
            this.propertiesElement.className = "viewer-Binary-pg";
            await this.pg.draw(this.propertiesElement, properties);
            this.container.appendChild(this.propertiesElement);
        }
        else {
            await this.pg.update(properties);
        }
    }

    async _updateScrolbar() {
        if (!this.vs)
            return;

        const totalLines = await this.viewer.totalLines;
        const lineHeight = Tools.getLineHeight(this.pre);
        const viewPortLines = this.element.clientHeight / lineHeight;
        this.vs.update({
            viewport: viewPortLines,
            extent: totalLines + 1 // add one extra line to ensure we see the last one
        });
    }

    async _loadText() {
        if (!this.vs)
            return;

        await this._updateScrolbar();
        const text = await this.viewer.getText(this.vs.offset, this.vs.viewport);
        this.pre.innerHTML = text;
    }
}
