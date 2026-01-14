export { Viewer };

// note: for some reason private methods (#) are not allowed here
class Viewer {
    async update(win, element, viewer) {
        element.innerHTML = "";
        const exports = await viewer.getExports();
        if (!exports)
            return;

        const container = document.createElement("div");
        container.className = "viewer-Executable-container";
        for (let i = 0; i < exports.length; i++) {
            const div = document.createElement("div");
            div.textContent = exports[i];
            container.appendChild(div);
        }
        element.appendChild(container);
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
