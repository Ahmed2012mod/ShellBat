import * as Tools from "../Tools.js";
import * as PropertyGrid from "../PropertyGrid.js";

export { Viewer };

// note: for some reason private methods (#) are not allowed here
class Viewer {
    async update(win, element, viewer) {
        this.viewer = viewer;

        // to benefit from caching, we request the image URL modulo 100
        const width = Math.floor((win.element.clientWidth / 100)) * 100;
        this.imageUrl = await viewer.getPageUrl(width)
        if (!this.imageUrl) {
            this.container?.remove();
            this.container = null;
            return;
        }

        if (!this.container) {
            this.container = document.createElement("div");
            this.container.className = "viewer-Image-container";
            element.appendChild(this.container);
        }

        if (!this.imgContainer) {
            this.imgContainer = document.createElement("div");
            this.imgContainer.className = "viewer-Image-img-container";
            this.container.appendChild(this.imgContainer);

            this.img = document.createElement("img");
            this.img.className = "viewer-Image-img";
            this.imgContainer.appendChild(this.img);
        }

        this.img.src = this.imageUrl;

        await this._loadProperties();
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
        this.container?.remove();
        this.container = null;
        this.propertiesElement = null;
        this.pg = null;
        this.imgContainer = null;
        this.img = null;
    }

    _setStyle(propertyName, propertyValue) {
        if (!this.img)
            return;

        const name = propertyName.toLowerCase();
        switch (name) {
            case "fillwidth":
                if (propertyValue) {
                    this.img.style.width = "100%";
                }
                else {
                    this.img.style.width = null;
                }

                dotnet.setInstanceSetting("ImageFillWidth", propertyValue);
                break;

            case "fillheight":
                if (propertyValue) {
                    this.img.style.height = "100%";
                }
                else {
                    this.img.style.height = null;
                }

                dotnet.setInstanceSetting("ImageFillHeight", propertyValue);
                break;
        }
    }

    async _loadProperties() {
        const properties = await this.viewer.getProperties();
        if (!properties)
            return;

        if (!this.propertiesElement) {
            this.pg = new PropertyGrid.PropertyGrid();
            this.pg.addEventListener("propertyChanged", (evt) => {
                this._setStyle(evt.detail.property.name, evt.detail.value);
            });

            this.propertiesElement = document.createElement("div");
            this.propertiesElement.className = "viewer-Image-pg";
            await this.pg.draw(this.propertiesElement, properties);
            this.container.insertBefore(this.propertiesElement, this.imgContainer);

            this.pg.drawControl("imageRefresh", (container) => {
                const button = document.createElement("button");
                button.textContent = Tools.Resource("Refresh");
                button.addEventListener("click", async () => {
                    fetch(this.imageUrl, { cache: "reload" }) // reload the image
                });
                container.appendChild(button);
            });

            this._setStyle("FillWidth", await this.pg.getPropertyValue("FillWidth"));
            this._setStyle("FillHeight", await this.pg.getPropertyValue("FillHeight"));
        }
        else {
            await this.pg.update(properties);
        }
    }
}
