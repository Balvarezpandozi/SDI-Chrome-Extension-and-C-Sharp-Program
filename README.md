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

### Project 2: C# Application

#### Specifications:

- Write a simple desktop application that has a button to call the get-selector REST API on port 3000. 
- 
- If the API is not turned on, the program should present an error message notification to suggest turning the API on. 

- If the API is on, it will wait to get the response (synchronously or asynchronously), then add the response to a list.

- If called repeatedly, we should have a list of names or whatever text is entered.

> Additionally, include code comments to clarify your code and provide installation instructions and usage guidelines for the browser extension and program.

## Architecture Overview

This repository consists of three applications: an API (get-selector-api folder), a windows form C# application (get-selector-app folder) and a 
chrome extension (get-selector-extension folder). As an overview, the C# application when it is open i contains a button that can call the API on port 3000. 
The API handles the calls by making a name request to the chrome extension. Then the chrome extension propmts a window to the user to submit a name or text information. 
The API recaives the information from the extension and sends it back to the windows form application as a response to the API call. The windows form application 
obtains the information and outputs it on a list on the main form of the app.

##Installation Instructions:
### Chrome Extension Installation:
1. Once this code is downloaded to your local computer, open up google chrome.
2. Enter the following on a new tab url: `chrome://extensions`
3. Enable developer mode by toggling button "Developer Mode"
4. Click the Load unpacked button and select the extension directory.
5. Now, the extension should appear as one option
6. After performing changes to the code, click the reload button on the extension to refresh it.
Note: The application will not work until the API is install and configured as explained in the following instructions.

### API Installation:
1. Change the path on the file "getselectorapi.reg" in the get-selector-api folder to the following:
`@="your \\ path \\SDI-Chrome-Extension-and-C-Sharp-Program\\get-selector-api\\get-selector-manifest.json:"`
2. Run the getselectorapi.reg file
3. Run the install.sh file on the top level of the directory to build both the get-selector-api and the get-selector-app
4. Change path property on the get-selector-manifest.json to the location of the executable file of the get-selector-api as follows
`"path": "your \\ path \\SDI-Chrome-Extension-and-C-Sharp-Program\\get-selector-api\\bin\\Debug\\net6.0\\get-selector-api.exe"`

### Windows Form Installation:
No further instructions. To open this application, open the executable located in -> `SDI-Chrome-Extension-and-C-Sharp-Program\get-selector-app\bin\Debug\net6.0\get-selector-api.exe`
