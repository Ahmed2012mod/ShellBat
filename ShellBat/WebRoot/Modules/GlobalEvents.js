import * as Enums from "./Enums.js";

export { GlobalEvents };

function setGlobalEvent(eventType, eventData) {
    const ge = window.GlobalEvents;
    if (ge) {
        ge.setGlobalEvent(eventType, eventData);
    }
}

class GlobalEvents extends EventTarget {
    constructor() {
        super();
    }

    setGlobalEvent(eventType, eventData) {
        var event = new CustomEvent(eventType, { detail: eventData });
        this.dispatchEvent(event);

        dotnet.sendEvent(Enums.WebEventType.SetGlobalEvent, { type: eventType, detail: eventData });
    }

    static install() {
        window.setGlobalEvent = setGlobalEvent;
        const ge = new GlobalEvents();
        window.GlobalEvents = ge;
    }
}
