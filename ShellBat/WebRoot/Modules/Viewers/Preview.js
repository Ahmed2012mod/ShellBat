import { Window } from "../Window.js";

export { Viewer };

// note: for some reason private methods (#) are not allowed here
class Viewer {
    async update(win, element, viewer) {
        element.innerHTML = "";
        this.window = win;
        this.viewer = viewer;
        win.addEventListener("bringToFront", () => this._bringToFront());
        win.addEventListener("sendToBack", () => this._sendToBack("window"));

        // when menu are shown we must freeze the preview win32 window and show a captured image instead
        this._contextMenuShown = this._contextMenuShown.bind(this);
        this._contextMenusDismissed = this._contextMenusDismissed.bind(this);
        window.GlobalEvents.addEventListener("ContextMenuShown", this._contextMenuShown);
        window.GlobalEvents.addEventListener("ContextMenusDismissed", this._contextMenusDismissed);

        this.container = document.createElement("div");
        this.container.className = "viewer-Preview-container";
        element.appendChild(this.container);

        // we need a slight delay to ensure the container is properly laid out
        setTimeout(() => this._preview(true), 100);
    }

    async _preview(show) {
        var rc = this.container.getBoundingClientRect();
        if (rc.width === 0 || rc.height === 0) {
            rc = this.lastRc || { x: 0, y: 0, width: 0, height: 0 };
        }
        else {
            this.lastRc = rc;
        }

        const entries = document.getElementById("app-entries-parent");
        const entriesRc = entries.getBoundingClientRect();

        var json = {
            x: rc.x - entriesRc.x,
            y: rc.y - entriesRc.y,
            width: rc.width,
            height: rc.height - 4, // hack: some needed adjustement so it works with all global scales
            windowHandle: window.windowHandle,
            ex: entriesRc.x,
            ey: entriesRc.y,
            ewidth: entriesRc.width,
            eheight: entriesRc.height
        };
        this.viewer.preview(JSON.stringify(json), show);
    }

    _inCapturedState() {
        return this.container.querySelector("img");
    }

    _contextMenuShown() {
        clearTimeout(this.showHideId);
        this.showHideId = setTimeout(() => this._sendToBack("context menu"), 100);
    }

    _contextMenusDismissed() {
        clearTimeout(this.showHideId);
        this.showHideId = setTimeout(() => this._bringToFront(), 100);
    }

    _bringToFront() {
        if (!Window.isTopZOrder(this.window))
            return;

        const img = this.container.querySelector("img");
        if (img) {
            img.remove();
            this._preview(true);
        }
    }

    async _sendToBack(reason) {
        if (this._inCapturedState()) // we are already showing the capture image
            return;

        const path = await this.viewer.getCaptureFilePath();
        if (path) {
            const img = document.createElement("img");
            img.src = "file:///" + path.replace(/\\/g, "/");
            this.container.appendChild(img);
            setTimeout(() => this._hide(), 100); // avoids flickering
        }
    }

    _hide() {
        this.viewer.hide();
    }

    async resize() {
        if (this._inCapturedState()) // showing the capture image, nothing to do
            return;

        this._preview(false);
    }

    async move() {
        if (this._inCapturedState()) // showing the capture image, nothing to do
            return;

        this._preview(false);
    }

    hide() {
        this._hide();
    }

    show() {
        setTimeout(() => this._preview(true), 100);
    }

    dispose() {
        window.GlobalEvents.removeEventListener("ContextMenuShown", this._contextMenuShown);
        window.GlobalEvents.removeEventListener("ContextMenusDismissed", this._contextMenusDismissed);
    }
}
