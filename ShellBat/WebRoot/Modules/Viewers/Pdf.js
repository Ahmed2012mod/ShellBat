import * as Tools from "../Tools.js";
import * as PropertyGrid from "../PropertyGrid.js";

export { Viewer };

// note: for some reason private methods (#) are not allowed here
class Viewer {
    async update(win, element, viewer) {
        this.viewer = viewer;
        this.element = element;
        this.currentPage = 0;
        this.pageCount = 0;

        if (!this.container) {
            this.container = document.createElement("div");
            this.container.className = "viewer-Pdf-container";
            element.appendChild(this.container);
        }

        await this._loadProperties();

        if (!this.img) {
            this.img = document.createElement("img");
            this.img.className = "viewer-Pdf-page";
            this.container.appendChild(this.img);
        }

        this.loaded = false;
        this._updateImage();
    }

    resize() {
        this._updateImage();
    }

    move() {
    }

    hide() {
    }

    show() {
        this._updateImage();
    }

    dispose() {
        this.container?.remove();
        this.container = null;
        this.img?.remove
        this.img = null;
        this.pg = null;
        this.propertiesElement?.remove();
        this.propertiesElement = null;
    }

    async _updateImage() {
        if (this.loaded)
            return;

        const width = this.width || Math.floor((this.container.clientWidth / 100)) * 100;
        if (!width) {
            setTimeout(() => this._updateImage(), 100);
            return;
        }

        this.width = width;

        const imageUrl = await this.viewer.getPageUrl(width, this.currentPage)
        if (!imageUrl) {
            const isPasswordProtected = await this.viewer.isPasswordProtected;
            if (isPasswordProtected) {
                this.img?.remove();
                this.img = null;

                let passwordElement = this.container.querySelector(".viewer-Pdf-protected");
                if (!passwordElement) {
                    passwordElement = document.createElement("div");
                    passwordElement.className = "viewer-Pdf-protected";
                    passwordElement.textContent = Tools.Resource("PasswordProtected");
                    this.container.appendChild(passwordElement);
                }
            }
            return;
        }

        this.img.src = imageUrl;
        this.loaded = true;
    }

    async _loadProperties() {
        const properties = await this.viewer.getProperties();
        if (!properties)
            return;

        if (!this.propertiesElement) {
            this.pg = new PropertyGrid.PropertyGrid();
            this.propertiesElement = document.createElement("div");
            this.propertiesElement.className = "viewer-Pdf-pg";
            await this.pg.draw(this.propertiesElement, properties);

            this.pageCount = await this.pg.getPropertyValue("pageCount");
            this.currentPage = await this.pg.getPropertyValue("currentPage");

            this.container.appendChild(this.propertiesElement);

            this.pg.drawControl("pdfPagePrevious", (container) => {
                const button = document.createElement("button");
                button.textContent = Tools.Resource("PreviousPage");
                button.addEventListener("click", async () => {
                    this.currentPage--;
                    this.loaded = false;
                    await this._updateImage();
                    this._loadProperties();
                });
                container.appendChild(button);

                if (this.currentPage === 0) {
                    button.disabled = true;
                }
            });

            this.pg.drawControl("pdfPageNext", (container) => {
                const button = document.createElement("button");
                button.textContent = Tools.Resource("NextPage");
                button.addEventListener("click", async () => {
                    this.currentPage++;
                    this.loaded = false;
                    await this._updateImage();
                    this._loadProperties();
                });
                container.appendChild(button);

                if (this.currentPage >= this.pageCount - 1) {
                    button.disabled = true;
                }
            });

            this.pg.drawControl("pdfSavePage", (container) => {
                const button = document.createElement("button");
                button.textContent = Tools.Resource("SavePage");
                button.addEventListener("click", async () => {
                    this.viewer.savePage();
                });
                container.appendChild(button);
            });

            this.pg.drawControl("pdfSaveAllsPages", (container) => {
                const button = document.createElement("button");
                button.textContent = Tools.Resource("SaveAllPages");
                button.addEventListener("click", async () => {
                    this.viewer.saveAllPages();
                });
                container.appendChild(button);
            });
        }
        else {
            await this.pg.update(properties);

            this.pageCount = await this.pg.getPropertyValue("pageCount");
            this.currentPage = await this.pg.getPropertyValue("currentPage");

            this.pg.drawControl("pdfPagePrevious", (container) => {
                const button = container.querySelector("button");
                button.disabled = this.currentPage === 0;
            })

            this.pg.drawControl("pdfPageNext", (container) => {
                const button = container.querySelector("button");
                button.disabled = this.currentPage >= this.pageCount - 1;
            });
        }
    }
}
