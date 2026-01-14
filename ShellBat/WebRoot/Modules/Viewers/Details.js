import * as PropertyGrid from "../PropertyGrid.js";

export { Viewer };

// note: for some reason private methods (#) are not allowed here
class Viewer {
    async update(win, element, viewer) {
        const properties = await viewer.getProperties();
        if (!properties)
            return;

        const pg = new PropertyGrid.PropertyGrid();
        element.innerHTML = "";

        this.container = document.createElement("div");
        this.container.className = "fld-pg-container";
        pg.draw(this.container, properties);
        element.appendChild(this.container);
    }

    resize() {
    }

    move() {
    }

    hide() {
    }

    show() {
    }

    dispose() {
    }
}
