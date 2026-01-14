import * as Menu from "../Menu.js";

export { Viewer };

// note: for some reason private methods (#) are not allowed here
class Viewer {
    async update(win, element, viewer) {
        element.innerHTML = "";
        this.size = "medium";

        const container = document.createElement("div");
        container.className = "viewer-Markdown-container";
        container.style.fontSize = this.size;
        element.appendChild(container);

        const text = await viewer.getText();
        container.innerHTML = text;

        container.addEventListener("contextmenu", e => {
            const sizes = ["xx-small", "x-small", "small", "medium", "large", "x-large", "xx-large", "xxx-large"];

            const menu = new Menu.Menu();
            const configuration = {
                menu: {
                    items: sizes.map(size => {
                        return {
                            html: size == this.size ? `<div class="viewer-Markdown-menu-item checked">${size}</div>` : size,
                            onclick: () => {
                                this.size = size;
                                container.style.fontSize = size;
                            }
                        };
                    })
                },
                options: {
                    id: "viewer-Markdown-menu",
                    className: "fld-menu",
                    left: e.clientX,
                    top: e.clientY,
                    animations: {
                        duration: ".4s",
                        show: "fadeInDown",
                        hide: "fadeOutUp"
                    }
                }
            };
            menu.draw(configuration);
        });
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
