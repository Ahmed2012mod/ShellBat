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
            this.container.className = "viewer-Audio-container";
            element.appendChild(this.container);
        }

        if (!this.audioContainer) {
            this.audioContainer = document.createElement("div");
            this.audioContainer.className = "viewer-Audio-audio-container";
            this.container.appendChild(this.audioContainer);

            this.audio = document.createElement("audio");
            this.audio.className = "viewer-Audio-audio";
            this.audio.controls = true;
            this.audioContainer.appendChild(this.audio);
        }

        await this._loadProperties();

        this.audio.src = Tools.encodeFilePathForUrl(this.imageUrl);
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
        this.audioContainer = null;
        this.audio = null;
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
                        this.audio.autoplay = evt.detail.value;
                        dotnet.setInstanceSetting("AudioAutoPlay", evt.detail.value);
                        break;
                }
            });

            this.propertiesElement = document.createElement("div");
            this.propertiesElement.className = "viewer-Audio-pg";
            await this.pg.draw(this.propertiesElement, properties);
            this.container.insertBefore(this.propertiesElement, this.audioContainer);
        }
        else {
            await this.pg.update(properties);
        }

        const autoPlay = await this.pg.getPropertyValue("AutoPlay");
        this.audio.autoplay = autoPlay;
        dotnet.setInstanceSetting("AudioAutoPlay", autoPlay);
    }
}
