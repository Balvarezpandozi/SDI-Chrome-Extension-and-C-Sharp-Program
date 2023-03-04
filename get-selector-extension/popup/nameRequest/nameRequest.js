const sendInputButton = document.getElementById("send-input");
const inputField = document.getElementById("input");

const sendInput = function () {
    chrome.runtime.sendMessage({ type: "info", name: inputField.value }, function (res) {
        window.close();
    });
}

sendInputButton.addEventListener('click', sendInput);