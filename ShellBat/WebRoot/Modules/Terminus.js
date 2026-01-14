import * as Tools from "./Tools.js";
import * as Window from "./Window.js";

// this funny name is to avoid confusion with xterm's Terminal
export { Terminus };

window.writeTerminal = writeTerminal;
window.writeLnTerminal = writeLnTerminal;
window.writeBytesTerminal = writeBytesTerminal;
window.pasteTerminal = pasteTerminal;
window.clearTerminal = clearTerminal;
window.inputTerminal = inputTerminal;
window.terminalProcessExited = terminalProcessExited;

function terminalProcessExited(id, text) {
    const term = window.terminals[id];
    if (term) {
        term.processExited(text);
    }
}

function inputTerminal(id, data, wasUserInput) {
    const term = window.terminals[id];
    if (term) {
        term.terminal.input(data, wasUserInput);
    }
}

function clearTerminal(id) {
    const term = window.terminals[id];
    if (term) {
        term.terminal.clear();
    }
}

function writeLnTerminal(id, data) {
    const term = window.terminals[id];
    if (term) {
        term.terminal.writeln(data);
    }
}

function writeTerminal(id, data) {
    const term = window.terminals[id];
    if (term) {
        term.terminal.write(data);
    }
}

function pasteTerminal(id, data) {
    const term = window.terminals[id];
    if (term) {
        term.terminal.paste(data);
    }
}

function writeBytesTerminal(id, data) {
    const term = window.terminals[id];
    if (term) {
        term.terminal.write(Uint8Array.fromBase64(data));
    }
}

class Terminus {
    constructor(id, key, options) {
        this.id = id;
        this.key = key;
        this.commandLine = options?.commandLine;
        this.options = options;
        this.initialize();
    }

    static close(id) {
        if (window.terminals && window.terminals[id]) {
            delete window.terminals[id];
        }
        Window.Window.close(id);
    }

    processExited(text) {
        // remove header element child nodes
        this.window.headerElement.querySelector(".fld-terminal-window-header-sync")?.remove();
        const exitMessage = document.createElement("div");
        exitMessage.className = "fld-terminal-exit-message";
        exitMessage.innerHTML = text;
        this.window.headerElement.insertBefore(exitMessage, this.window.closeButtonElement);
    }

    async #dispose() {
        Terminus.close(this.id);
        this.dotnetTerminal.dispose();
    }

    async initialize() {
        const win = await dotnet.getWindow(this.id, this.key);
        this.window = new Window.Window(win);
        this.window.commandLine = this.commandLine;
        this.window.addEventListener("ready", async () => {

            this.element = document.createElement("div");
            this.element.className = "fld-terminal";
            this.window.element.appendChild(this.element);

            this.dotnetTerminal = await dotnet.getTerminal(this.id, this.key);
            this.syncDotnetTerminal = syncDotnet.getTerminal(this.id, this.key);

            const supportsShellBatSync = await this.dotnetTerminal.supportsShellBatSync;
            const supportsTerminalSync = await this.dotnetTerminal.supportsTerminalSync;

            if (supportsShellBatSync || supportsTerminalSync) {
                const syncDiv = document.createElement("div");
                syncDiv.className = "fld-terminal-window-header-sync";

                if (supportsShellBatSync) {
                    const syncShellBat = document.createElement("input");
                    syncShellBat.type = "checkbox";
                    syncShellBat.checked = await this.dotnetTerminal.getShellBatSync();
                    syncShellBat.id = this.id + "_ShellBatSync";
                    syncShellBat.setAttribute("tooltip", Tools.Resource("SyncShellBatTooltip"));
                    syncShellBat.onclick = () => {
                        this.dotnetTerminal.setShellBatSync(syncShellBat.checked);
                    };

                    const labelShellBat = document.createElement("label");
                    labelShellBat.htmlFor = syncShellBat.id;
                    labelShellBat.innerHTML = Tools.Resource("SyncShellBat");
                    labelShellBat.setAttribute("tooltip", Tools.Resource("SyncShellBatTooltip"));

                    syncDiv.appendChild(syncShellBat);
                    syncDiv.appendChild(labelShellBat);
                }

                if (supportsTerminalSync) {
                    const syncTerm = document.createElement("input");
                    syncTerm.type = "checkbox";
                    syncTerm.checked = await this.dotnetTerminal.getTerminalSync();
                    syncTerm.id = this.id + "_termSync";
                    syncTerm.setAttribute("tooltip", Tools.Resource("SyncTerminalTooltip"));
                    syncTerm.onclick = () => {
                        this.dotnetTerminal.setTerminalSync(syncTerm.checked);
                    };

                    const labelTerm = document.createElement("label");
                    labelTerm.htmlFor = syncTerm.id;
                    labelTerm.innerHTML = Tools.Resource("SyncTerminal");
                    labelTerm.setAttribute("tooltip", Tools.Resource("SyncTerminalTooltip"));

                    syncDiv.appendChild(syncTerm);
                    syncDiv.appendChild(labelTerm);
                }

                this.window.headerElement.insertBefore(syncDiv, this.window.closeButtonElement);
            }

            const fontSize = 14;
            this.terminal = new Terminal({
                allowProposedApi: true,
                //logLevel: "debug",
                cursorStyle: "bar",
                cursorBlink: true,
                fontSize: fontSize,
                windowsMode: true,
                windowsPty: { "backend": "winpty", "buildNumber": 26100 },
                fontFamily: '"Cascadia Mono", "Lucida Console", Consolas, "Courier New", monospace'
            });

            this.terminal.attachCustomKeyEventHandler(ev => {
                // early catches
                // causes ctrl+v to work "naturally"" in the terminal
                if (ev.type === "keydown" && ev.key == "v" && ev.ctrlKey)
                    return false;

                // call into .NET to see if it wants to handle this key event
                const res = this.syncDotnetTerminal.onKeyEvent({
                    type: ev.type,
                    key: ev.key,
                    code: ev.code,
                    alt: ev.altKey,
                    ctrl: ev.ctrlKey,
                    meta: ev.metaKey,
                    shift: ev.shiftKey
                });
                //console.log(`Key event: ${ev.type} ${ev.key} (continue=${res})`);
                return res;
            });

            this.fitAddon = new FitAddon.FitAddon();
            this.terminal.loadAddon(this.fitAddon);

            const unicodeGraphemesAddon = new UnicodeGraphemesAddon.UnicodeGraphemesAddon();
            this.terminal.loadAddon(unicodeGraphemesAddon);

            this.terminal.open(this.element);
            this.window.addEventListener("resize", async () => {
                this.#resize();
            });

            this.terminal.focus();
            this.terminal.onData(e => this.dotnetTerminal.onData(e));

            window.terminals = window.terminals || {};
            window.terminals[this.id] = this;
            this.dotnetTerminal.onReady(this.commandLine);

            setTimeout(() => {
                this.#resize();

                this.window.setPosition(this.options);
            }, 100);

        }, { once: true });

        this.window.addEventListener("close", () => {
            this.#dispose();
        });
    }

    #resize() {
        const dims = this.fitAddon.proposeDimensions();
        if (!dims.cols || !dims.rows)
            return;

        this.terminal.resize(dims.cols, dims.rows);
        this.dotnetTerminal.onResize(dims.cols, dims.rows);
    }
}
