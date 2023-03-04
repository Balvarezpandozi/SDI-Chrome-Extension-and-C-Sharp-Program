const turnOnButton = document.getElementById("turn-on-off-btn");
const buttonSlider = document.getElementById("slider");
const statusLabel = document.getElementById("status-label");

const checkApiStatus = function () {
    chrome.runtime.sendMessage({ type: "check-api-status" }, function (res) {
        toggleButtonStyle(res);
    });
}

const toggleButtonStyle = function (isApiOn) {
    if (!isApiOn) {
        turnOnButton.classList.remove("on-button");
        buttonSlider.classList.remove("on-slider");
        statusLabel.classList.remove("on-status-label");
        turnOnButton.classList.add("off-button");
        buttonSlider.classList.add("off-slider");
        statusLabel.classList.add("off-status-label");
        statusLabel.textContent = "OFF";
    } else {
        turnOnButton.classList.remove("off-button");
        buttonSlider.classList.remove("off-slider");
        statusLabel.classList.remove("off-status-label");
        turnOnButton.classList.add("on-button");
        buttonSlider.classList.add("on-slider");
        statusLabel.classList.add("on-status-label");
        statusLabel.textContent = "ON";
    }
}

const connect = function () {
    chrome.runtime.sendMessage({ type: "toggle-api" }, function (res) {
        toggleButtonStyle(res);
    });
}

checkApiStatus();
turnOnButton.addEventListener('click', connect);