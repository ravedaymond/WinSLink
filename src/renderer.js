function setElectronInfo() {
    const element = document.getElementById('electron-info')
    element.setAttribute('content', `Electron (v${versions.electron()}); Node.js (v${versions.node()}; Chrome (v${versions.chrome});`);
}

async function ping() {
    const response = await ipcRenderer.ping();
    console.log(response);
}

async function loadIcons() {
    const containers = document.getElementsByClassName('icon-button');
    for (let container of containers) {
        const icon = container.getAttribute('icon-name');
        console.debug('loadIcons', container);
        const response = await ipcRenderer.replaceIcon(icon);
        container.innerHTML = response;
    }
}

async function addNumbers(...args) {
    const response = await ipcRenderer.addNumbers(args);
    console.debug('addNumbers', response);
}

async function combineThreeStrings(string1, string2, string3) {
    const response = await ipcRenderer.combineThreeStrings(string1, string2, string3);
    console.debug('combineThreeStrings', response);
}

// ----
setElectronInfo();
loadIcons();