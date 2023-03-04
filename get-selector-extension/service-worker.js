let apiPort = null;

const connectApi = () => {
    port = chrome.runtime.connectNative('getselectorapi');
    port.onDisconnect.addListener(() => {
        console.log("Disconnected Native App")
        apiPort = null;
    })
    port.onMessage.addListener(function (response) {
        if (response["request"] == "getName") {
            chrome.windows.create({
                focused: true,
                height: 300,
                width: 300,
                url: './popup/nameRequestForm/nameRequestForm.html',
                type: 'popup'
            });
        }
    });
    return port;
}

const notify = (message) => {
    chrome.notifications.create('', {
        title: "Get Selector",
        message: message,
        iconUrl: "./res/icon.png",
        type: "basic"
    });
}

const toggleAPI = () => {
    if (apiPort == null) {
        apiPort = connectApi();
        notify("Get Selector API was successfuly turned on!");
        return true;
    }

    fetch("http://localhost:3000/api/kill");
    notify("Get Selector API was turned off!");
    return false;
}

const messageController = (request, _sender, sendResponse) => {
    switch (request.type) {
        case "toggle-api":
            isApiOn = toggleAPI();
            sendResponse(isApiOn);
            break;
        case "check-api-status":
            apiPort == null ? sendResponse(false) : sendResponse(true);
            break;
        case "info":
            if (apiPort != null) apiPort.postMessage(request);
            sendResponse();
        default:
            break;
    }
}

chrome.runtime.onMessage.addListener(messageController)