import * as Tools from "./Tools.js";
import * as Enums from "./Enums.js";

export { Window };

const windowIdPrefix = "w-";
window.closeWindow = closeWindow;
window.getWindows = getWindows;

function getWindows() {
    return Array.from(document.body.querySelectorAll(".window")).map(win => {
        const window = win.window;
        const rc = window.element.getBoundingClientRect();
        return {
            id: window.id,
            parameters: window.parameters,
            commandLine: window.commandLine, // set by Terminus
            borderSnap: window.borderSnap,
            viewerId: window.tabsElement?.selectedViewerId,
            pinnedViewerId: window.pinnedViewerId,
            left: rc.left,
            top: rc.top,
            right: rc.right,
            bottom: rc.bottom,
        }
    });
}

function closeWindow() {
    const topWindow = Array.from(document.body.querySelectorAll(".window")).sort((a, b) => (parseInt(b.style.zIndex) || 0) - (parseInt(a.style.zIndex) || 0))[0];
    if (topWindow && topWindow.window) {
        topWindow.window.close();
    }
}

class Window extends EventTarget {
    constructor(window) {
        super();
        this.window = window || {};
        this.initialize();
    }

    async #construct() {
        // dispose old viewers & modules
        if (this.viewers) {
            await Promise.all(this.viewers.map(async viewer => {
                const id = await viewer.id;
                (await this.getViewerModule(id, false))?.dispose();
                await viewer.dispose();
            }));
        }

        this.id = await this.window.id;
        this.parameters = await this.window.parameters;
        this.options = await this.window.options || {};
        this.viewers = await this.window.viewers || [];
        this.borderSnap = await this.options.borderSnap;
        this.dockPadding = await this.options.dockPadding;

        // mark all viewers module as needing update
        if (this.modules) {
            for (const viewerId in this.modules) {
                const module = this.modules[viewerId];
                module._needUpdate = true;
            }
        }

        this.className = await this.options.className;
        this.title = await this.options.title;
        this.icon = await this.options.icon;
        this.styles = await this.options.styles;
    }

    #dragMove = (event) => {
        this.element.style.left = Math.min(Math.max(0, (event.clientX - this.deltaX)), window.innerWidth - this.headerElement.clientHeight) + "px"; // use header height (not width)
        this.element.style.top = Math.min(Math.max(0, (event.clientY - this.deltaY)), window.innerHeight - this.headerElement.clientHeight) + "px";

        const vsWidth = Tools.getVScrollbarWidth(document.getElementById("app-entries-parent"));
        const hsHeight = Tools.getHScrollbarHeight(document.getElementById("app-entries-parent"));

        const shiftKey = event.shiftKey;
        if (!shiftKey) {
            const tbRc = document.getElementById("app-toolbar").getBoundingClientRect();
            const stRc = document.getElementById("app-statusbar").getBoundingClientRect();
            const rightSnapEdge = window.innerWidth - this.element.offsetLeft - this.element.clientWidth - this.dockPadding;
            const bottomSnapEdge = window.innerHeight - this.element.offsetTop - this.element.clientHeight - stRc.height - this.dockPadding;
            const topSnapEdge = this.element.offsetTop - tbRc.height - this.dockPadding;
            const leftSnapEdge = this.element.offsetLeft + this.dockPadding;
            const threshold = this.dockPadding + 5;
            if (rightSnapEdge <= threshold) {
                this.element.style.left = (window.innerWidth - this.element.clientWidth - vsWidth - this.dockPadding) + "px";
                if (topSnapEdge <= threshold) {
                    this.borderSnap = Enums.BorderSnap.RightTop;
                    this.element.style.top = (tbRc.height + this.dockPadding) + "px";
                }
                else if (bottomSnapEdge <= threshold) {
                    this.borderSnap = Enums.BorderSnap.RightBottom;
                    this.element.style.top = (window.innerHeight - this.element.clientHeight - stRc.height - hsHeight - this.dockPadding) + "px";
                }
                else {
                    this.borderSnap = Enums.BorderSnap.Right;
                }
            }
            else if (leftSnapEdge <= threshold) {
                this.element.style.left = this.dockPadding + "px";
                if (topSnapEdge <= threshold) {
                    this.borderSnap = Enums.BorderSnap.LeftTop;
                    this.element.style.top = (tbRc.height + this.dockPadding) + "px";
                }
                else if (bottomSnapEdge <= threshold) {
                    this.borderSnap = Enums.BorderSnap.LeftBottom;
                    this.element.style.top = (window.innerHeight - this.element.clientHeight - stRc.height - hsHeight - this.dockPadding) + "px";
                }
                else {
                    this.borderSnap = Enums.BorderSnap.Left;
                }
            }
            else if (topSnapEdge <= threshold) {
                this.borderSnap = Enums.BorderSnap.Top;
                this.element.style.top = (tbRc.height + this.dockPadding) + "px";
            }
            else if (bottomSnapEdge <= threshold) {
                this.borderSnap = Enums.BorderSnap.Bottom;
                this.element.style.top = (window.innerHeight - this.element.clientHeight - stRc.height - hsHeight - this.dockPadding) + "px";
            }
            else {
                this.borderSnap = Enums.BorderSnap.None;
            }
        }

        window.GlobalEvents.setGlobalEvent("WindowMove");

        // determine border snap
        this.viewers.map(async viewer => {
            const id = await viewer.id;
            (await this.getViewerModule(id, false))?.move();
        });
    }

    #snap(borderSnap) {
        const vsWidth = Tools.getVScrollbarWidth(document.getElementById("app-entries-parent"));
        const hsHeight = Tools.getHScrollbarHeight(document.getElementById("app-entries-parent"));

        this.borderSnap = borderSnap;
        const parentRc = document.body.getBoundingClientRect();
        const tbRc = document.getElementById("app-toolbar").getBoundingClientRect();
        switch (borderSnap) {
            case Enums.BorderSnap.RightTop:
                this.element.style.left = (parentRc.width - this.element.clientWidth - vsWidth - this.dockPadding) + "px";
                this.element.style.top = (tbRc.bottom + this.dockPadding) + "px";
                break;

            case Enums.BorderSnap.RightBottom:
                this.element.style.left = (parentRc.width - this.element.clientWidth - vsWidth - this.dockPadding) + "px";
                this.element.style.top = (parentRc.height - this.element.clientHeight - hsHeight - tbRc.height / 2 - this.dockPadding) + "px";
                break;

            case Enums.BorderSnap.LeftTop:
                this.element.style.left = this.dockPadding + "px";
                this.element.style.top = (tbRc.bottom + this.dockPadding) + "px";
                break;

            case Enums.BorderSnap.LeftBottom:
                this.element.style.left = this.dockPadding + "px";
                this.element.style.top = (parentRc.height - this.element.clientHeight - hsHeight - tbRc.height / 2 - this.dockPadding) + "px";
                break;

            case Enums.BorderSnap.Left:
                this.element.style.left = this.dockPadding + "px";
                break;

            case Enums.BorderSnap.Top:
                this.element.style.top = (tbRc.bottom + this.dockPadding) + "px";
                break;

            case Enums.BorderSnap.Right:
                this.element.style.left = (parentRc.width - this.element.clientWidth - vsWidth - this.dockPadding) + "px";
                break;

            case Enums.BorderSnap.Bottom:
                this.element.style.top = (parentRc.height - this.element.clientHeight - hsHeight - tbRc.height / 2 - this.dockPadding) + "px";
                break;
        }
    }

    #computeZOrders() {
        const windows = Array.from(document.body.querySelectorAll(".window"));
        windows.sort((a, b) => (parseInt(a.style.zIndex) || 0) - (parseInt(b.style.zIndex) || 0));
        let index = parseInt(getComputedStyle(document.documentElement).getPropertyValue("--windows-zindex"));
        windows.forEach(window => {
            if (window != this.element) {
                window.style.zIndex = index++;
                window.window.#sendToBack();
            }
        });

        this.element.style.zIndex = index;
        this.element.window.#bringToFront();
    }

    static #skipDrag(src) {
        if (src.tagName == "BUTTON" || src.tagName == "INPUT" || src.tagName == "TEXTAREA" || src.isContentEditable)
            return true;

        const parent = src.parentElement;
        if (parent)
            return Window.#skipDrag(parent);

        return false;
    }

    async initialize() {
        await this.#construct();

        this.element = document.createElement("div");
        this.element.window = this;
        this.element.id = windowIdPrefix + this.id;
        this.element.className = this.className;
        this.element.classList.add("window");
        const resizeable = this.styles & Enums.WebWindowStyles.IsResizeable || false;
        const draggable = this.styles & Enums.WebWindowStyles.IsDraggable || false;
        if (draggable) {
            this.element.addEventListener("pointerdown", (event) => {
                this.#computeZOrders();

                const src = document.elementFromPoint(event.clientX, event.clientY);

                // drag only if pointerdown
                // * is on header
                // * not on close button
                // * if we are using resize in right bottom corner
                // * if the src item is not an input (to allow text selection)
                if (resizeable) {
                    const rect = this.element.getBoundingClientRect();
                    if (event.clientX >= rect.right - 16 && event.clientY >= rect.bottom - 16)
                        return;
                }

                const closeButton = this.headerElement?.querySelector("." + this.className + "-header-close");
                if (closeButton && closeButton.contains(src)) {
                    return;
                }

                if (Window.#skipDrag(src))
                    return;

                if (!this.headerElement.contains(src))
                    return;

                this.deltaX = event.clientX - this.element.offsetLeft;
                this.deltaY = event.clientY - this.element.offsetTop;

                this.element.setPointerCapture(event.pointerId);
                this.element.addEventListener("pointermove", this.#dragMove);
                this.element.addEventListener("pointerup", () => {
                    this.element.releasePointerCapture(event.pointerId);
                    this.element.removeEventListener("pointermove", this.#dragMove);
                }, { once: true });
            });
        }

        if (!resizeable) {
            this.element.style.resize = null;
        }

        this.#setAutoPosition();

        await this.#updateHeader();
        await this.#updateViewers();

        document.body.appendChild(this.element);

        await this.#updateSelectedViewer();
        await this.#updateSelectedViewerContent();

        await this.#updatePin();

        if (resizeable) {
            this.resizeObserver = new ResizeObserver(() => {
                this.#resize();
            });
            this.resizeObserver.observe(this.element);
        }

        this.#computeZOrders();
        var event = new CustomEvent("ready");
        this.dispatchEvent(event);
        window.GlobalEvents.setGlobalEvent("NewWindowReady");
    }

    setPosition(options) {
        this.element.style.left = options.left + "px";
        this.element.style.top = options.top + "px";
        this.element.style.width = (options.right - options.left) + "px";
        this.element.style.height = (options.bottom - options.top) + "px";
        this.borderSnap = this.borderSnap || options.borderSnap;
        this.pinnedViewerId = this.pinnedViewerId || options.pinnedViewerId;
    }

    #setAutoPosition() {
        for (const rc of this.#enumPossibleWindowPositions()) {
            this.element.style.left = rc.left + "px";
            this.element.style.top = rc.top + "px";
            this.element.style.width = rc.width + "px";
            this.element.style.height = rc.height + "px";
            this.borderSnap = rc.borderSnap;
            return; // take first
        }

        // if no position found, center the window
        const parentRc = document.body.getBoundingClientRect();
        this.element.style.left = (parentRc.width / 4) + "px";
        this.element.style.top = (parentRc.height / 4) + "px";
        this.element.style.width = (parentRc.width / 2) + "px";
        this.element.style.height = (parentRc.height / 2) + "px";
        this.borderSnap = Enums.BorderSnap.None;
    }

    *#enumPossibleWindowPositions() {
        const vsWidth = Tools.getVScrollbarWidth(document.getElementById("app-entries-parent"));
        const hsHeight = Tools.getHScrollbarHeight(document.getElementById("app-entries-parent"));

        const parentRc = document.body.getBoundingClientRect();
        const tbRc = document.getElementById("app-toolbar").getBoundingClientRect();

        // favor right side positions
        const rects = Array.from(Window.enumAll().map(win => {
            const rect = win.element.getBoundingClientRect();
            return {
                left: rect.left,
                top: rect.top,
                right: rect.right,
                bottom: rect.bottom,
                borderSnap: win.borderSnap
            };
        }));

        let rc = {
            width: (parentRc.width - vsWidth) / 2 - 2 * this.dockPadding,
            height: (parentRc.height - hsHeight) / 2 - 2 * this.dockPadding,
            borderSnap: Enums.BorderSnap.RightTop
        };
        rc.left = (parentRc.width - vsWidth) - rc.width - this.dockPadding;
        rc.top = tbRc.bottom + this.dockPadding;
        rc.right = rc.left + rc.width - vsWidth;
        rc.bottom = rc.top + rc.height - hsHeight;

        if (rects.length == 0 || !Tools.rectsIntersectWithAny(rc, rects)) {
            yield rc;
        }

        rc.borderSnap = Enums.BorderSnap.RightBottom;
        rc.top = tbRc.bottom + parentRc.height - hsHeight - rc.height - this.dockPadding;
        rc.height -= tbRc.height + tbRc.height / 2;
        rc.bottom = rc.top + rc.height - hsHeight;
        if (rects.length == 0 || !Tools.rectsIntersectWithAny(rc, rects)) {
            yield rc;
        }

        const rightTopSnap = rects.find(r => r.borderSnap == Enums.BorderSnap.RightTop);
        if (rightTopSnap) {
            rc.borderSnap = Enums.BorderSnap.RightBottom;
            rc.top = rightTopSnap.bottom + this.dockPadding;
            rc.bottom = rc.top + rc.height;
            if (!Tools.rectsIntersectWithAny(rc, rects)) {
                yield rc;
            }
        }

        const rightBottomSnap = rects.find(r => r.borderSnap == Enums.BorderSnap.RightBottom);
        if (rightBottomSnap) {
            rc.borderSnap = Enums.BorderSnap.RightTop;
            rc.top = rightBottomSnap.top - this.dockPadding - rc.height;
            rc.bottom = rc.top + rc.height;
            if (!Tools.rectsIntersectWithAny(rc, rects)) {
                yield rc;
            }
        }
    }

    #resize() {
        this.viewers.map(async viewer => {
            const id = await viewer.id;
            (await this.getViewerModule(id, false))?.resize();
        });

        var event = new CustomEvent("resize");
        this.dispatchEvent(event);

        window.GlobalEvents.setGlobalEvent("WindowResize");
    }

    #bringToFront() {
        var event = new CustomEvent("bringToFront");
        this.dispatchEvent(event);
    }

    #sendToBack() {
        var event = new CustomEvent("sendToBack");
        this.dispatchEvent(event);
    }

    #hideOtherModules(viewerId) {
        // for each tab items, hide content except selected
        this.element.querySelectorAll("." + this.className + "-tab-content").forEach((contentElement) => {
            contentElement.style.display = "none";
            const vid = contentElement.viewerId;
            if (vid != viewerId) {
                const mod = this.modules?.[vid];
                if (mod) {
                    mod.hide();
                }
            }
        });
    }

    async #ensureViewerModule(viewerId) {
        if (this.modules && this.modules[viewerId])
            return this.modules[viewerId];

        const viewer = await this.window.getViewer(viewerId);
        if (viewer == null)
            return null;

        const id = await viewer.id;
        this.modules = this.modules || {};
        if (!this.modules[id]) {
            // instantiate viewer module
            const imp = await import("./Viewers/" + id + ".js");
            if (imp) {

                // load css for viewer
                // unfortunately, this doesn't work https://github.com/WICG/construct-stylesheets/issues/119#issuecomment-588352418
                // import("../Styles/Viewers/" + id + ".css", { with: { type: "css" } });

                const cssPath = "./Viewers/../Styles/Viewers/" + id + ".css";
                let link = document.querySelector("link[href='" + cssPath + "']");
                if (!link) {
                    link = document.createElement("link");
                    link.rel = "stylesheet";
                    link.href = cssPath;
                    document.head.appendChild(link);
                }

                const cls = imp["Viewer"]; // all viewer modules must export a Viewer class
                const module = Object.create(cls.prototype);
                module._needUpdate = true;
                this.modules[id] = module;
            }
        }

        return this.modules[id]; // if null here, means module couldn't be created
    }

    async #updateSelectedViewerContent() {
        if (!this.tabsElement)
            return null;

        const selectedViewerId = this.tabsElement.selectedViewerId;
        const module = await this.#ensureViewerModule(selectedViewerId);
        if (!module)
            return null;

        this.#hideOtherModules(selectedViewerId);

        const contentId = this.element.id + "-tab-content-" + selectedViewerId;
        const viewerContents = document.getElementById(contentId);
        if (!viewerContents)
            return null;

        if (module._needUpdate) {
            const viewer = await this.window.getViewer(selectedViewerId);
            if (viewer == null)
                return null;

            await module.update(this, viewerContents, viewer);
            module._needUpdate = false;
        }
        else {
            module.show();
        }

        viewerContents.style.display = null; // reset container display to default
        return module;
    }

    async #updateHeader() {
        const hasHeader = this.title ||
            this.icon ||
            this.styles & Enums.WebWindowStyles.IsDraggable ||
            this.styles & Enums.WebWindowStyles.IsCloseable;

        if (hasHeader) {
            if (!this.headerElement) {
                this.headerElement = document.createElement("div");
                this.headerElement.className = this.className + "-header";
                this.element.appendChild(this.headerElement);
            }

            let iconElement = this.headerElement.querySelector("." + this.className + "-header-icon");
            if (this.icon) {
                if (!iconElement) {
                    iconElement = document.createElement("i");
                    this.headerElement.appendChild(iconElement);
                }

                iconElement.className = this.className + "-header-icon";
                iconElement.classList.add(...this.icon.split(" "));
            }
            else {
                if (iconElement) {
                    iconElement.remove();
                }
            }

            let titleElement = this.headerElement.querySelector("." + this.className + "-header-title");
            if (this.title) {
                if (!titleElement) {
                    titleElement = document.createElement("div");
                    titleElement.className = this.className + "-header-title";
                    this.headerElement.appendChild(titleElement);
                    this.titleElement = titleElement;
                }

                titleElement.innerHTML = this.title;
            }
            else {
                if (titleElement) {
                    titleElement.remove();
                }
            }

            let closeButtonElement = this.headerElement.querySelector("." + this.className + "-header-close");
            if (this.styles & Enums.WebWindowStyles.IsCloseable) {
                if (!closeButtonElement) {
                    closeButtonElement = document.createElement("div");
                    closeButtonElement.className = this.className + "-header-close";
                    closeButtonElement.onclick = (e) => {
                        this.close();
                    };
                    this.headerElement.appendChild(closeButtonElement);
                    this.closeButtonElement = closeButtonElement;
                }
            }
            else {
                if (closeButtonElement) {
                    closeButtonElement.remove();
                }
            }
        }
        else {
            if (this.headerElement) {
                this.headerElement.remove();
                this.headerElement = null;
            }
        }
    }

    async close() {
        var event = new CustomEvent("close");
        this.dispatchEvent(event);

        window.GlobalEvents.setGlobalEvent("WindowClose");

        this.#computeZOrders();
        this.#dispose();
        this.element.remove();
    }

    async #dispose() {
        // kinda hacky way (viewers will each do it),
        // but we want to make sure real Win32 child window are closed asap
        dotnet.sendEvent(Enums.WebEventType.DisposeChildWindows);
        this.resizeObserver?.disconnect();
        await this.#disposeViewers();
    }

    async #disposeViewers() {
        await Promise.all(this.viewers.map(async viewer => {
            const id = await viewer.id;
            (await this.getViewerModule(id, false))?.dispose();
            await viewer.dispose();
        }));
    }

    async #updatePin() {
        if (!this.tabsElement)
            return;

        let pinViewerElement = document.querySelector("." + this.className + "-pin");
        if (pinViewerElement) {
            pinViewerElement.remove();
        }
        pinViewerElement = document.createElement("div");
        pinViewerElement.className = this.className + "-pin";
        this.tabsElement.appendChild(pinViewerElement);

        let unpinViewerElement = document.querySelector("." + this.className + "-unpin");
        if (unpinViewerElement) {
            unpinViewerElement.remove();
        }
        unpinViewerElement = document.createElement("div");
        unpinViewerElement.className = this.className + "-unpin";
        this.tabsElement.appendChild(unpinViewerElement);

        pinViewerElement.onclick = () => {
            this.pinnedViewerId = this.tabsElement.selectedViewerId;
            this.#updatePinStatus(pinViewerElement, unpinViewerElement);
            window.GlobalEvents.setGlobalEvent("WindowUpdate");
        };

        unpinViewerElement.onclick = () => {
            this.pinnedViewerId = null;
            this.#updatePinStatus(pinViewerElement, unpinViewerElement);
            window.GlobalEvents.setGlobalEvent("WindowUpdate");
        }

        this.#updatePinStatus(pinViewerElement, unpinViewerElement);
    }

    #updatePinStatus(pinViewerElement, unpinViewerElement) {
        if (!this.pinnedViewerId) {
            pinViewerElement.style.display = null;
            pinViewerElement.innerHTML = Tools.Resource("PinViewer").replace(/\{0\}/, this.tabsElement.selectedViewerId);
            unpinViewerElement.style.display = "none";
        }
        else {
            unpinViewerElement.style.display = null;
            unpinViewerElement.innerHTML = Tools.Resource("UnpinViewer").replace(/\{0\}/, this.pinnedViewerId);
            if (this.tabsElement.selectedViewerId && this.pinnedViewerId && this.tabsElement.selectedViewerId?.toLowerCase() === this.pinnedViewerId?.toLowerCase()) {
                pinViewerElement.style.display = "none";
            }
            else {
                pinViewerElement.style.display = null;
                pinViewerElement.innerHTML = Tools.Resource("PinViewer").replace(/\{0\}/, this.tabsElement.selectedViewerId);
            }
        }
    }

    async #updateViewers() {
        if (this.viewers.length == 0)
            return;

        if (!this.tabsElement) {
            this.tabsElement = document.createElement("div");
            this.tabsElement.className = this.className + "-tabs";
            this.element.appendChild(this.tabsElement);
        }

        const viewersIds = await Promise.all(this.viewers.map(async viewer => {
            const viewerId = await viewer.id;
            const icon = await viewer.icon;
            const title = await viewer.title;
            const tabId = this.element.id + "-tab-" + viewerId;
            const contentId = this.element.id + "-tab-content-" + viewerId;

            let tabElement = document.getElementById(tabId);
            if (!tabElement) {
                tabElement = document.createElement("div");
                tabElement.id = tabId;
                tabElement.viewerId = viewerId;
                tabElement.className = this.className + "-tab";
                tabElement.onclick = () => {
                    this.selectViewerModule(viewerId);
                }

                this.tabsElement.appendChild(tabElement);
            }

            if (icon) {
                tabElement.innerHTML = "<i class='" + icon + "'></i>" + title;
            }
            else {
                tabElement.innerHTML = title;
            }

            let tabContentElement = document.getElementById(contentId);
            if (!tabContentElement) {
                tabContentElement = document.createElement("div");
                tabContentElement.id = contentId;
                tabContentElement.viewerId = viewerId;
                tabContentElement.className = this.className + "-tab-content";
                tabContentElement.classList.add("viewer-" + viewerId);
                tabContentElement.style.display = "none"; // hide by default
                this.element.appendChild(tabContentElement);
            }
            return viewerId;
        }));

        // remove tabs & contents that are no longer present
        let childNodes = Array.from(this.tabsElement.childNodes)
        childNodes.forEach(child => {
            if (!viewersIds.find(id => (this.element.id + "-tab-" + id) === child.id)) {
                child.remove();
            }
        });

        childNodes = Array.from(this.element.childNodes)
        childNodes.forEach(child => {
            if (child == this.tabsElement || child == this.headerElement)
                return;

            if (!viewersIds.find(id => (this.element.id + "-tab-content-" + id) === child.id)) {
                child.remove();
            }
        });
    }

    async #updateSelectedViewer() {
        if (!this.tabsElement)
            return;

        const viewersIds = await Promise.all(this.viewers.map(async v => await v.id));
        let newSelectedViewerId;
        let selectedViewerId = this.pinnedViewerId;

        if (selectedViewerId) {
            if (!viewersIds.find(id => id.toLowerCase() === selectedViewerId.toLowerCase())) {
                // special case for some "compatible"" viewers: if previously selected, and now not available, try to select the other one if available
                // ultimately, we should have a better way to define viewer compatibility (should go in .NET side))
                if (selectedViewerId.toLowerCase() === "video") {
                    newSelectedViewerId = viewersIds.find(id => id.toLowerCase() === "image");
                }
                else if (selectedViewerId.toLowerCase() === "image") {
                    newSelectedViewerId = viewersIds.find(id => id.toLowerCase() === "video");
                }
            }
            else {
                newSelectedViewerId = selectedViewerId;
            }
        }

        if (!newSelectedViewerId) {
            // try viewer with highest priority
            let highestPriority = 0;
            for (let viewer of this.viewers) {
                const id = await viewer.id;
                const priority = await viewer.priority || 0;
                if (priority > highestPriority) { // note: priority must be > 0
                    highestPriority = priority;
                    newSelectedViewerId = id;
                }
            }
        }

        newSelectedViewerId = newSelectedViewerId || this.tabsElement.firstChild?.viewerId || "General";
        await this.selectViewerModule(newSelectedViewerId);
    }

    async selectViewerModule(viewerId) {
        if (this.tabsElement.selectedViewerId) {
            const previousSelectedTabElement = document.getElementById(this.element.id + "-tab-" + this.tabsElement.selectedViewerId);
            if (previousSelectedTabElement) {
                previousSelectedTabElement.classList.remove("selected");
            }
        }

        const tabElement = document.getElementById(this.element.id + "-tab-" + viewerId);
        tabElement?.classList.add("selected");
        this.tabsElement.selectedViewerId = viewerId;
        const content = await this.#updateSelectedViewerContent();
        await this.#updatePin();
        return content;
    }

    async getViewerModule(viewerId, forceCreate) {
        if (forceCreate)
            return await this.#ensureViewerModule(viewerId);

        if (!this.modules)
            return null;

        return this.modules[viewerId];
    }

    async update(win) {
        var eq = await win.IsInstanceEqual(this.window);
        if (eq)
            return;

        this.window = win;
        await this.#construct();
        await this.#updateHeader();
        await this.#updateViewers();
        await this.#updateSelectedViewer();
        await this.#updateSelectedViewerContent();
        await this.#updatePin();
        window.GlobalEvents.setGlobalEvent("WindowUpdate");
    }

    static moveSnappedWindows() {
        for (const window of Window.enumAll()) {
            if (window.borderSnap != Enums.BorderSnap.None) {
                window.#snap(window.borderSnap);
            }
        }
    }

    static *enumAll() {
        const windows = Array.from(document.body.querySelectorAll(".window"));
        for (const window of windows) {
            yield window.window;
        }
    }

    static isTopZOrder(window) {
        const windows = Array.from(document.body.querySelectorAll(".window"));
        windows.sort((a, b) => (parseInt(a.style.zIndex) || 0) - (parseInt(b.style.zIndex) || 0));
        if (windows.length <= 1)
            return true;

        const topWindow = windows[windows.length - 1];
        return topWindow?.window === window;
    }

    static get(id) {
        const element = document.getElementById(windowIdPrefix + id);
        if (!element)
            return null;

        return element.window;
    }

    static close(id) {
        const element = document.getElementById(windowIdPrefix + id);
        if (element) {
            element.remove();
        }
    }
}
