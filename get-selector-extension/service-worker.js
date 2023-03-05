let apiPort = null;

//Creates notifications, takes 1 parameter which is the message to show in the notification
const notify = (message) => {
    chrome.notifications.create('', {
        title: "Get Selector",
        message: message,
        iconUrl: "./res/icon.png",
        type: "basic"
    });
}

//Creates pop up to request a name
const createNameRequestPopUp = (response) => {
    if (response["request"] == "getName") {
        chrome.windows.create({
            focused: true,
            height: 300,
            width: 300,
            url: './popup/nameRequestForm/nameRequestForm.html',
            type: 'popup'
        });
    }
}

//Sets the Native messaging between extension and API
const connectApi = () => {
    port = chrome.runtime.connectNative('getselectorapi');
    port.onDisconnect.addListener(() => {
        apiPort = null;
    })
    port.onMessage.addListener(createNameRequestPopUp);
    return port;
}


//Turns API ON/OFF
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

//Manages communication between service worker and popups
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
            break;
        default:
            break;
    }
}

chrome.runtime.onMessage.addListener(messageController)