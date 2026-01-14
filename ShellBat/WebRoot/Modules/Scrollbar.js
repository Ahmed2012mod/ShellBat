export { VerticalScrollbar };
export { HorizontalScrollbar };

class Scrollbar extends EventTarget {
    #createElements() {
        this.element = document.createElement("div");
        this.element.className = "fld-sb";
        this.element.classList.add("fld-sb-" + this._type());

        const nearButtonElement = document.createElement("div");
        nearButtonElement.className = "fld-sb-button";
        nearButtonElement.classList.add("fld-sb-button-near-" + this._type());
        this.element.appendChild(nearButtonElement);
        nearButtonElement.addEventListener("click", () => {
            this.setOffset(this.offset - this.viewport);
        });

        const thumbElement = document.createElement("div");
        thumbElement.className = "fld-sb-thumb";
        thumbElement.classList.add("fld-sb-thumb-" + this._type());
        this.element.appendChild(thumbElement);

        this.viewportElement = document.createElement("div");
        this.viewportElement.className = "fld-sb-viewport";
        this.viewportElement.classList.add("fld-sb-viewport-" + this._type());
        thumbElement.appendChild(this.viewportElement);
        this.viewportElement.addEventListener("pointerdown", (event) => {
            this.thumbX = event.clientX;
            this.thumbY = event.clientY;
            this.thumbOffset = this.offset;
            this.viewportElement.setPointerCapture(event.pointerId);
            this.viewportElement.addEventListener("pointermove", this.#thumbMove);
            this.viewportElement.addEventListener("pointerup", () => {
                this.viewportElement.releasePointerCapture(event.pointerId);
                this.viewportElement.removeEventListener("pointermove", this.#thumbMove);
            }, { once: true });
        });

        const farButtonElement = document.createElement("div");
        farButtonElement.className = "fld-sb-button";
        farButtonElement.classList.add("fld-sb-button-far-" + this._type());
        this.element.appendChild(farButtonElement);
        farButtonElement.addEventListener("click", () => {
            this.setOffset(this.offset + this.viewport);
        });

        this.parentElement.appendChild(this.element);
    }

    #onWheel(event) {
        event.preventDefault();
        const delta = Math.sign(event.deltaY);
        const stepSize = this.stepSize || this.viewport;
        this.setOffset(this.offset + delta * stepSize);
    }

    #thumbMove = (event) => {
        const deltaY = event.clientY - this.thumbY;
        const deltaX = event.clientX - this.thumbX;
        let offsetChange;
        if (this._type() === "v") {
            offsetChange = deltaY / this.sizingElement.clientHeight * this.extent;
        } else {
            offsetChange = deltaX / this.sizingElement.clientWidth * this.extent;
        }
        this.setOffset(this.thumbOffset + offsetChange);
    }

    constructor(parentElement, options) {
        super();
        this.parentElement = parentElement;
        this.options = options || {};
        this.sizingElement = this.options.sizingElement || parentElement;
        this.extent = null;
        this.viewport = null;
        this.offset = 0;
        this.size = this.options.size || 15;
        this.minSize = this.options.minSize || this.size;
        this.stepSize = this.options.stepSize;
        this.#createElements();
        this.parentElement.addEventListener("wheel", (event) => this.#onWheel(event));
    }

    update(options) {
        if (options == null)
            return;

        const oldOffset = this.offset;
        const oldExtent = this.extent || 0;
        let offsetUpdate = false;
        if (options.extent) {
            if (this.extent !== options.extent) {
                offsetUpdate = true;
                this.extent = options.extent;
            }
        }

        if (options.viewport) {
            if (this.viewport !== options.viewport) {
                offsetUpdate = true;
                this.viewport = options.viewport;
            }
        }

        if (options.offset) {
            this.setOffset(options.offset);
        }
        else if (offsetUpdate) {
            // adjust offset to keep the same relative position
            const relativePos = oldExtent ? (oldOffset / oldExtent) : 0;
            this.setOffset(relativePos * this.extent);
        }

        if (options.stepSize) {
            this.stepSize = options.stepSize;
        }

        this._setThumbSize();

        const sizePercent = (this.viewport / this.extent) * 100;
        if (sizePercent >= 100) {
            this.element.style.display = "none";
        } else {
            this.element.style.display = null;
        }
    }

    setOffset(offset) {
        offset = Math.max(0, Math.min(offset, this.extent - this.viewport));
        if (offset === this.offset)
            return;

        this.offset = offset;
        this._setOffset();

        var event = new CustomEvent("scroll", { detail: { offset: offset } });
        this.dispatchEvent(event);
    }

    _setOffset() {
    }

    _setThumbSize() {
    }

    _type() {
    }
}

class VerticalScrollbar extends Scrollbar {
    constructor(parentElement, options) {
        super(parentElement, options);
    }

    _type() {
        return "v";
    }

    _setOffset() {
        const minSize = this.minSize * this.extent / this.sizingElement.clientHeight;
        const max = (this.extent - minSize) * 100 / this.extent;
        this.viewportElement.style.top = Math.max(0, Math.min(max, (this.offset * 100 / this.extent))) + "%";
    }

    _setThumbSize() {
        const sizePercent = this.viewport * 100 / this.extent;
        this.viewportElement.style.height = sizePercent + "%";
        this.viewportElement.style.minHeight = this.size + "px";
    }
}

class HorizontalScrollbar extends Scrollbar {
    constructor(parentElement, options) {
        super(parentElement, options);
    }

    _type() {
        return "h";
    }

    _setOffset() {
        const minSize = this.minSize * this.extent / this.sizingElement.clientWidth;
        const max = (this.extent - minSize) * 100 / this.extent;
        this.viewportElement.style.left = Math.max(0, Math.min(max, (this.offset * 100 / this.extent))) + "%";
    }

    _setThumbSize() {
        const sizePercent = this.viewport * 100 / this.extent;
        this.viewportElement.style.width = sizePercent + "%";
        this.viewportElement.style.minWidth = this.size + "px";
    }
}
