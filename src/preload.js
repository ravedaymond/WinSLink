const { contextBridge, ipcRenderer } = require('electron');

contextBridge.exposeInMainWorld('versions', {
    electron: () => process.versions.electron,
    node: () => process.versions.node,
    // we can also expose variables, not just functions
    chrome: process.versions.chrome,
});

contextBridge.exposeInMainWorld('ipcRenderer', {
    replaceIcon: (icon) => ipcRenderer.invoke('replace-icon', icon+'.svg'),
    ping: () => ipcRenderer.invoke('ping'),
    addNumbers: (args) => ipcRenderer.invoke('add-numbers', args),
    combineThreeStrings: (string1, string2, string3) => ipcRenderer.invoke('combine-three-strings', string1, string2, string3),
});