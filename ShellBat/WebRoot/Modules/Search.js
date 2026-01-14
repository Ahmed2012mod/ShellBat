import * as Tools from "./Tools.js";
import * as Window from "./Window.js";
import * as Enums from "./Enums.js";

export { Search };

window.onSearchResult = onSearchResult;

function onSearchResult(queryId, result) {
    const search = window.searchWindows && window.searchWindows[queryId];
    if (search) {
        search.onResult(result);
    }
}

class Search {
    constructor(options) {
        this.type = options.type || Enums.SearchType.FindStrings;
        this.searchOptions = {};
        this.#construct();
    }

    async #construct() {
        window.searchWindows = window.searchWindows || {};
        const configuration = await dotnet.getSearchWindow(this.type);
        this.window = new Window.Window(configuration);

        this.window.addEventListener("ready", async () => {
            if (!this.window.headerElement)
                return;

            this.window.addEventListener("close", () => {
                this.#cancelSearch();
            });

            this.type = this.type;

            const container = document.createElement("div");
            container.className = "fld-search";
            this.window.element.appendChild(container);

            this.entries = document.createElement("table");
            this.entries.className = "fld-search-entries";
            container.appendChild(this.entries);
            this.entries.ondblclick = (event) => {
                const target = event.target;
                if (target && target.tagName === "TD") {
                    const row = target.parentElement;
                    const indexCell = row.cells[0];
                    const options = {
                        type: this.type,
                        parsingName: indexCell.parsingName,
                        position: this.type == Enums.SearchType.FindStrings ? row.cells[1].position : null
                    }
                    dotnet.sendEvent(Enums.WebEventType.OnSearchDoubleClicked, options);
                }
            }

            this.headerElement = document.createElement("div");
            this.headerElement.className = "fld-search-header";
            this.window.headerElement.setAttribute("tooltip", Tools.Resource(this.type == Enums.SearchType.FindStrings ? "FindStringsDescription" : "WindowsSearchDescription"));
            this.window.headerElement.classList.add("search");
            this.window.headerElement.insertBefore(this.headerElement, this.window.closeButtonElement);

            this.searchInput = document.createElement("input");
            this.searchInput.spellcheck = false;
            this.searchInput.type = "text";
            this.searchInput.className = "fld-search-input";
            this.searchInput.placeholder = Tools.Resource("SearchPlaceholder");
            this.searchInput.addEventListener("keydown", (event) => {
                if (event.key === "Enter") {
                    this.#startSearch();
                }
                else if (event.key === "Escape") {
                    this.#stopOrCancelSearch();
                }
            });

            this.headerElement.appendChild(this.searchInput);
            const clearButton = document.createElement("button");
            clearButton.className = "fld-search-input-clear";
            this.headerElement.appendChild(clearButton);

            this.clearIconElement = document.createElement("i");
            this.clearIconElement.classList.add("fa-regular");
            this.clearIconElement.classList.add("fa-circle-xmark");
            clearButton.appendChild(this.clearIconElement);

            clearButton.onclick = () => {
                this.#stopOrCancelSearch();
            };

            const searchButton = document.createElement("button");
            searchButton.className = "fld-search-input-search";
            searchButton.innerText = Tools.Resource("Search");
            searchButton.onclick = () => {
                this.#startSearch();
            };
            this.headerElement.appendChild(searchButton);

            if (this.type == Enums.SearchType.FindStrings) {
                const textFilesOnlyInput = document.createElement("input");
                textFilesOnlyInput.type = "checkbox";
                textFilesOnlyInput.setAttribute("tooltip", Tools.Resource("TextFilesOnlyDescription"));
                textFilesOnlyInput.onclick = () => {
                    this.searchOptions.textFilesOnly = textFilesOnlyInput.checked;
                    this.#startSearch();
                };

                const textFilesOnlyLabel = document.createElement("label");
                textFilesOnlyLabel.htmlFor = textFilesOnlyInput.id;
                textFilesOnlyLabel.innerHTML = Tools.Resource("TextFilesOnly");
                textFilesOnlyLabel.setAttribute("tooltip", Tools.Resource("TextFilesOnlyDescription"));

                this.headerElement.appendChild(textFilesOnlyInput);
                this.headerElement.appendChild(textFilesOnlyLabel);
            }

            const recursiveInput = document.createElement("input");
            recursiveInput.type = "checkbox";
            recursiveInput.setAttribute("tooltip", Tools.Resource("RecursiveSearch"));
            recursiveInput.onclick = () => {
                this.searchOptions.recursive = recursiveInput.checked;
                this.#startSearch();
            };

            const labelRecursive = document.createElement("label");
            labelRecursive.htmlFor = recursiveInput.id;
            labelRecursive.innerHTML = Tools.Resource("Recursive");
            labelRecursive.setAttribute("tooltip", Tools.Resource("RecursiveSearch"));

            this.headerElement.appendChild(recursiveInput);
            this.headerElement.appendChild(labelRecursive);

            this.loader = document.createElement("div");
            this.loader.className = "fld-loader";
            this.loader.style.display = "none";
            this.headerElement.appendChild(this.loader);

            this.resultText = document.createElement("div");
            this.resultText.className = "fld-search-result";
            this.headerElement.appendChild(this.resultText);
            this.searchInput.focus();
        });
    }

    #stopOrCancelSearch() {
        if (this.clearIconElement.classList.contains("fa-circle-stop")) {
            this.#stopSearch();
        }
        else {
            this.#cancelSearch();
            this.searchInput.value = "";
        }
        this.searchInput.focus();
    }

    #cancelSearch() {
        if (this.queryId) {
            dotnet.stopSearch(this.queryId);
            delete window.searchWindows[this.queryId];
        }

        this.queryId = null;
        this.entries.innerHTML = "";
        this.resultText.innerText = "";
        this.loader.style.display = "none";
        this.clearIconElement.classList.remove("fa-circle-stop");
        this.clearIconElement.classList.add("fa-circle-xmark");
    }

    #stopSearch() {
        if (this.queryId) {
            dotnet.stopSearch(this.queryId);
            delete window.searchWindows[this.queryId];
        }

        this.loader.style.display = "none";
        this.clearIconElement.classList.remove("fa-circle-stop");
        this.clearIconElement.classList.add("fa-circle-xmark");
    }

    #startSearch() {
        if (!this.searchInput || this.searchInput.value.trim().length == 0)
            return;

        this.#cancelSearch();
        this.totalEntries = 0;
        this.resultText.innerText = "";
        this.entries.innerHTML = "";
        this.queryId = self.crypto.randomUUID();
        window.searchWindows[this.queryId] = this;
        this.loader.style.display = "block";
        this.clearIconElement.classList.remove("fa-circle-xmark");
        this.clearIconElement.classList.add("fa-circle-stop");
        dotnet.startSearch(this.type, this.queryId, this.searchInput.value, this.searchOptions);
    }

    onResult(result) {
        if (result.index === -2) {
            this.resultText.innerText = result.filePath;
            return;
        }

        if (result.index === -1) {
            // last result
            this.loader.style.display = "none";
            this.resultText.innerText = Tools.Resource("SearchResultsFound", { count: this.totalEntries });
            return;
        }

        if (this.entries.rows.length == 0) {
            const header = this.entries.createTHead();
            const headerRow = header.insertRow();
            if (this.type == Enums.SearchType.FindStrings) {
                const indexHeader = headerRow.insertCell();
                indexHeader.innerText = Tools.Resource("SearchIndex");
                const positionHeader = headerRow.insertCell();
                positionHeader.innerText = Tools.Resource("FindStringsPosition");
                const pathHeader = headerRow.insertCell();
                pathHeader.innerText = Tools.Resource("SearchRelativePath");
                const textHeader = headerRow.insertCell();
                textHeader.innerText = Tools.Resource("FindStringsText");
            }
            else { // Windows search
                const indexHeader = headerRow.insertCell();
                indexHeader.innerText = Tools.Resource("SearchIndex");
                const pathHeader = headerRow.insertCell();
                pathHeader.innerText = Tools.Resource("SearchFilePath");

                const properties = result.properties;
                for (let property in properties) {
                    const propertyHeader = headerRow.insertCell();
                    propertyHeader.innerText = property;
                }
            }
            this.entries.createTBody();
        }

        const row = this.entries.tBodies[0].insertRow();
        const indexCell = row.insertCell();
        indexCell.innerText = result.index;
        indexCell.parsingName = result.parsingName;

        if (this.type == Enums.SearchType.FindStrings) {
            const positionCell = row.insertCell();
            positionCell.innerText = "0x" + result.position.toString(16).toUpperCase();
            positionCell.position = result.position;

            const pathCell = row.insertCell();
            pathCell.innerText = result.filePath;

            const textCell = row.insertCell();
            textCell.innerText = result.text;
        }
        else { // Windows search
            const pathCell = row.insertCell();
            pathCell.innerText = result.filePath;

            const properties = result.properties;
            for (let property in properties) {
                const propertyCell = row.insertCell();
                propertyCell.innerText = properties[property];
            }
        }

        this.totalEntries++;
        if (this.totalEntries % 100 == 0) {
            this.resultText.innerText = Tools.Resource("SearchResultsFound", { count: this.totalEntries });
        }
    }
}
