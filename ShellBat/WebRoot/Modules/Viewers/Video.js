import * as Tools from "../Tools.js";
import * as PropertyGrid from "../PropertyGrid.js";

export { Viewer };

// note: for some reason private methods (#) are not allowed here
class Viewer {
    async update(win, element, viewer) {
        this.viewer = viewer;

        this.imageUrl = await viewer.getPageUrl()
        if (!this.imageUrl) {
            this.container?.remove();
            this.container = null;
            return;
        }

        if (!this.container) {
            this.container = document.createElement("div");
            this.container.className = "viewer-Video-container";
            element.appendChild(this.container);
        }

        if (!this.videoContainer) {
            this.videoContainer = document.createElement("div");
            this.videoContainer.className = "viewer-Video-video-container";
            this.container.appendChild(this.videoContainer);

            this.video = document.createElement("video");
            this.video.className = "viewer-Video-video";
            this.video.controls = true;
            this.videoContainer.appendChild(this.video);
        }

        await this._loadProperties();

        this.video.src = Tools.encodeFilePathForUrl(this.imageUrl);
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
        this.videoContainer = null;
        this.video = null;
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
                    case "autoplay":
                        this.video.autoplay = evt.detail.value;
                        dotnet.setInstanceSetting("VideoAutoPlay", evt.detail.value);
                        break;
                }
            });

            this.propertiesElement = document.createElement("div");
            this.propertiesElement.className = "viewer-Video-pg";
            await this.pg.draw(this.propertiesElement, properties);
            this.container.insertBefore(this.propertiesElement, this.videoContainer);
        }
        else {
            await this.pg.update(properties);
        }

        const autoPlay = await this.pg.getPropertyValue("AutoPlay");
        this.video.autoplay = autoPlay;
        dotnet.setInstanceSetting("VideoAutoPlay", autoPlay);
    }
}
