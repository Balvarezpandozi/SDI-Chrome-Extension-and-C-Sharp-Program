const sendInputButton = document.getElementById("send-input");
const inputField = document.getElementById("input");
const feedbackMessage = document.getElementById("feedback-message");

const validateInput = () => {
    if (inputField.value == "") return false;
    return true;
}

const sendInput = () => {
    if (!validateInput()) {
        feedbackMessage.style.display = "block";
        return;
    }

    //Communicates with service worker to send the input
    chrome.runtime.sendMessage({ type: "info", name: inputField.value }, function (res) {
        window.close();
    });
}

sendInputButton.addEventListener('click', sendInput);