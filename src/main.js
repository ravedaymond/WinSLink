const { app, BrowserWindow, ipcMain, shell } = require('electron');
const { dialog } = require('electron/main');

/* ********************* */
/* CONSTANTS AND GLOBALS */
/* ********************* */

const path = require('path');
const paths = {
    config: path.join(__dirname, '../config'),
    css: path.join(__dirname, 'css'),
    svg: path.join(__dirname, 'css/svg'),
    res: path.join(__dirname, 'res'),
    logs: path.join(__dirname, 'res/logs'),
    templates: path.join(__dirname, 'res/templates'),
}
const profile = winslinkProfile();
const settings = winslinkSettings();
const logger = winslinkLogger();


/* ********* */
/* FUNCTIONS */
/* ********* */

const winslinkProfile = () => {
    const os = require('os');
    return {
        hostname: os.hostname(),
        username: os.userInfo.username,
        homedir: os.userInfo.homedir
    };
}

const winslinkSettings = () => {
    let settings = {
        path: path.join(paths.config, 'settings.json'),
        default: path.join(paths.templates, 'settings.default.json'),
        load: {
            ok: true,
            showErr: () => { },
        }
    }
    const fs = require('fs');
    try {
        settings.winslink = JSON.parse(fs.readFileSync(settings.path)).winslink;
    } catch (err) {
        settings.load.ok = false;
        if(err.code === 'ENOENT') {
            settings.load.showErr = () => {
                return dialog.showMessageBoxSync({
                    message: 'No settings.json file found. Default settings.json will be created.',
                    type: 'warning',
                    title: 'WinSLink',
                    detail: err.message
                });
            };
            settings.winslink = JSON.parse(fs.readFileSync(settings.default)).winslink;
            fs.writeFileSync(settings.path, JSON.stringify({ winslink: settings.winslink }, null, 4));
        } else {
            settings.load.showErr = () => {
                return dialog.showMessageBoxSync({
                    message: 'Error reading settings.json file. Resolve errors or delete settings.json.',
                    type: 'error',
                    title: 'WinSLink',
                    buttons: ['OK', 'Open File', 'Delete File'],
                    defaultId: 0,
                    detail: err.message
                });
            };
        }
    }
    return settings;
}

const winslinkLogger = (log, ...args) => {
    if(!log) { return; }
    const util = require('util');
    const fs = require('fs');
    const os = require('os');
    
    args.forEach(arg => {
        log = util.format(log, arg);
    });
    console.log(log);
    const outStream = fs.createWriteStream(path.join(paths.logs, 'session.log'), { flags: 'a' });
    outStream.write(util.format(new Date().toJSON(), `${log}${os.EOL}`));
    outStream.close();
}

/* ***************** */
/* IPC MAIN HANDLERS */
/* ***************** */

function ipcAddNumbers() {
    ipcMain.handle('add-numbers', async (event, args) => {
        let result = 0;
        args.forEach(arg => {
            result += arg
        });
        return result;
    });
}

function ipcCombineThreeStrings() {
    2
    ipcMain.handle('combine-three-strings',
        async (event, string1, string2, string3) => `${string1}${string2}${string3}`);
}

function ipcReplaceIcon() {
    ipcMain.handle('replace-icon', async (event, icon) => {
        const fs = require('fs/promises');
        const data = await fs.readFile(path.join(paths.svg, icon), { encoding: 'utf8' });
        return data;
    });
}

const ipcHandlers = () => {
    ipcMain.handle('ping', () => 'pong');
    ipcReplaceIcon();
    ipcAddNumbers();
    ipcCombineThreeStrings();
}


/* ********************** */
/* DECLARE ELECTRON WINDOWS */
/* ********************** */

/* Loads web page in a new BrowserWindow instance */
function createWindow() {
    const win = new BrowserWindow({
        titleBarStyle: 'hidden',
        titleBarOverlay: {
            color: "#4F6D7A",
            symbolColor: "#EAEAEA",
            height: 39
        },
        width: 800,
        height: 600,
        webPreferences: {
            preload: path.join(__dirname, 'preload.js')
        }
    });

    /* Connect ipc main handlers. */
    ipcHandlers();

    /* Load html */
    win.loadFile(path.join(__dirname, 'index.html'));

    const contents = win.webContents;
    // console.log('contents', contents);
};


/* ****************** */
/* START ELECTRON APP */
/* ****************** */

/* 
Browser windows can only be created after the app module's
    `ready` event is fired.
Typically you listen to Node.js events by using an emitters `on` 
    function: app.on('ready').then(() => { ... }
However, Electron exposes app.whenReady() as a helper specifically 
    for the ready event to avoid subtle pitfalls with directly listening 
    to that event in particular. 
See [electron/electron#21972](https://github.com/electron/electron/pull/21972) for details.
*/
app.enableSandbox();
app.whenReady().then(() => {
    /*
    Timeout set for development debugging with VSCode.
    Ensures that no lines of code will be skipped while the 
        debugger is connecting.
    */
    setTimeout(() => {
        console.debug('Timeout for debugger connection complete.');
    }, 5000);

    if (!settings.load.ok) {
        const errResp = settings.load.showErr();
        if(errResp === 1) {
            shell.openPath(settings.path);
            app.quit();
        } else if (errResp === 2) {
            shell.trashItem(settings.path);
            app.relaunch();
            app.quit();
        }
    }

    /* Create application window. */
    createWindow();

    /*
    Open a window if none are open (macOS).
    Windows can not be created before the ready event.
    You should only listen for `activate` events after
        your app has been initialized.
    */
    app.on('activate', () => {
        if (BrowserWindow.getAllWindows().length === 0) {
            createWindow();
        }
    });
});

/* Quit the app when all windows are closed (Windows & Linux). */
app.on('window-all-closed', () => {
    if (process.platform !== 'darwin') app.quit();
});
