window.res = JSON.parse(chrome.webview.hostObjects.sync.dotnet.getResources());

export function encodeFilePathForUrl(path) {
    return path.replace(/%/g, "%25").replace(/#/g, "%23");
}

export function getVScrollbarWidth(element) {
    if (element.scrollHeight > element.clientHeight)
        return element.offsetWidth - element.clientWidth;
    return 0;
}

export function getHScrollbarHeight(element) {
    if (element.scrollWidth > element.clientWidth)
        return element.offsetHeight - element.clientHeight;
    return 0;
}

export function getLastSegment(parsingName) {
    const lastBackslashIndex = parsingName.lastIndexOf("\\");
    if (lastBackslashIndex === -1 || lastBackslashIndex === 0)
        return "";

    return parsingName.substring(lastBackslashIndex + 1);
}

// scrollIntoView(IfNeeded) behavior is weird, we need to do it ourselves
export function scrollIntoViewIfNeeded(element, parent) {
    parent = parent || element.parentElement;
    const parentRect = parent.getBoundingClientRect();
    const elementRect = element.getBoundingClientRect();
    if (elementRect.top < parentRect.top) {
        parent.scrollTop -= parentRect.top - elementRect.top;
    }
    else if (elementRect.bottom > parentRect.bottom) {
        parent.scrollTop += elementRect.bottom - parentRect.bottom;
    }
}

export function Resource(key, props) {
    let str = res[key] || key;
    return str.replace(/\${(\w+)\}/g, function (match, expr) {
        return (props || window)[expr];
    });
}

export function runOnceOnHover(element, callback, delay) {
    var id = setTimeout(callback, delay);
    element.addEventListener("mouseleave", () => clearTimeout(id), { once: true });
}

export function getLineHeight(element) {
    if (!element)
        return 0;

    const style = getComputedStyle(element);
    const height = style.getPropertyValue("line-height");
    if (!height || height == "normal") {
        const fontSize = style.getPropertyValue("font-size");
        return parseFloat(fontSize) * 1.2;
    }

    return parseFloat(height);
}

export function rectsIntersectWithAny(rect, rects) {
    for (let i = 0; i < rects.length; i++) {
        if (rectsIntersect(rect, rects[i])) {
            return true;
        }
    }
    return false;
}

export function rectsIntersect(rect1, rect2) {
    return !(rect1.left > rect2.right ||
        rect2.left > rect1.right ||
        rect1.top > rect2.bottom ||
        rect2.top > rect1.bottom);
}

export function toggleFlags(value, flags) {
    if (value & flags) {
        value &= ~flags;
    }
    else {
        value |= flags;
    }
    return value;
}

export function toggleAttribute(element, name) {
    if (!element)
        return;

    if (element.hasAttribute(name)) {
        element.removeAttribute(name);
        return true;
    }
    else {
        element.setAttribute(name, true);
        return false;
    }
}

export function setBooleanAttribute(element, name, value, trueValue, falseValue) {
    if (!element)
        return;

    if (value) {
        element.setAttribute(name, trueValue);
    }
    else {
        element.setAttribute(name, falseValue);
    }
}

export function setOrRemoveAttribute(element, name, value) {
    if (!element)
        return;

    if (!value) {
        element.removeAttribute(name);
    }
    else {
        element.setAttribute(name, value);
    }
}

export function* makeIterator(iterable) {
    while (iterable.moveNext()) {
        yield iterable.current();
    }
}

export async function* makeIteratorAsync(iterable) {
    while (await iterable.moveNext()) {
        yield await iterable.current();
    }
}

export function sleep(ms) {
    return new Promise(resolve => setTimeout(resolve, ms));
}

export function findParent(element, tagName) {
    let current = element;
    while (current != document.body) {
        current = current.parentElement;
        if (!current)
            break;

        if (current.tagName == tagName)
            return current;
    }
    return null;
}

export function insertAfter(newElement, targetElement) {
    const parent = targetElement.parentNode;
    if (parent.lastChild === targetElement) {
        parent.appendChild(newElement, targetElement);
    } else {
        parent.insertBefore(newElement, targetElement.nextSibling);
    }
}

export function collapseElement(element) {
    const height = element.scrollHeight;
    const elementTransition = element.style.transition;
    element.style.transition = "";

    requestAnimationFrame(function () {
        element.style.height = height + "px";
        element.style.transition = elementTransition;

        requestAnimationFrame(function () {
            element.style.height = "0px";
        });
    });
}

function onTransitionEnd(event) {
    event.srcElement.removeEventListener("transitionend", onTransitionEnd);
    event.srcElement.style.height = null;
}

export function expandElement(element) {
    const height = element.scrollHeight;
    element.style.height = height + "px";
    element.addEventListener("transitionend", onTransitionEnd);
}

export function placeElementAtCursor(element, left, top, offsetX, offsetY) {
    offsetX = offsetX || 0;
    offsetY = offsetY || 0;

    // display near mouse cursor but don't go outside of window bounds
    if (left + element.offsetWidth + offsetX > window.innerWidth) {
        element.style.left = Math.max(0, left - element.offsetWidth - offsetX) + "px";
    } else {
        element.style.left = (left + offsetX) + "px";
    }

    if (top + element.offsetHeight + offsetY > window.innerHeight) {
        element.style.top = Math.max(0, top - element.offsetHeight - offsetY) + "px";
    }
    else {
        element.style.top = (top + offsetY) + "px";
    }
}

