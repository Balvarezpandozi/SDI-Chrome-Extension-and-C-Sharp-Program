# SDI-Chrome-Extension-and-C-Sharp-Program

## Create two Visual Studio projects in one solution

Visual Studio will not compile the browser extension, but it will be used for the editor and syntax highlighting. 

### Project 1: Browser Extension

#### Specifications:
- Write a Chrome v3 manifest browser extension that hosts a REST API on port 3000 named get-selector. 
The browser extension should present a button to turn the API on and off and, in a toaster notification provide feedback that turning it on/off succeeds. 

- Also, toggle the button text and color between “API On” [Green button] and “API Off” [Red button]. 

- When the API is on, when a GET request is sent to the API get-selector, it will present an input to type in a name, then return the name via the API. 

- Bonus: make the same code work in Firefox and Chrome

#### Instructions: for Chrome Installation
1- Once this code is downloaded to your local computer, open up google chrome.
2- Enter the following on a new tab url: chrome://extensions
3- Enable developer mode by toggling button "Developer Mode"
4- Click the Load unpacked button and select the extension directory.

### Project 2: C# Application
Specifications:

- Write a simple desktop application that has a button to call the get-selector REST API on port 3000. 
- 
- If the API is not turned on, the program should present an error message notification to suggest turning the API on. 

- If the API is on, it will wait to get the response (synchronously or asynchronously), then add the response to a list.

- If called repeatedly, we should have a list of names or whatever text is entered.



> Additionally, include code comments to clarify your code and provide installation instructions and usage guidelines for the browser extension and program.
