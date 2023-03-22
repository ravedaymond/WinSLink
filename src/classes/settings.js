class Settings {
    load = {
        ok: true,
        msg: "",
        err: undefined
    }
    profile = {
        hostname: "",
        username: "",
        homedir: "",
    }
    preferences = {
        theme: "winslink",
    }

    constructor(path) {
        this.setProfile();
        this.setVersion();
        path = path + 'settings.json';
        const fs = require('fs');
        try {
            const data = JSON.parse(fs.readFileSync(path));
            this.setPreferences(data.preferences);
        } catch (err) {
            this.load.ok = false;
            console.log(err.code);
            if (err.code === 'ENOENT') {
                fs.writeFileSync(path, JSON.stringify({ winslink: this }, null, 4));
                return;
            }
            this.load.err = err;
        }
    }

    getVersion() {
        return this.version;
    }

    setVersion() {
        this.version = app.version;
    }

    getProfile() {
        return this.profile;
    }

    setProfile() {
        const os = require('os');
        this.profile.hostname = os.hostname();
        this.profile.username = os.userInfo.username;
        this.profile.homedir = os.userInfo.homedir;
    }

    getPreferences() {
        return this.preferences;
    }

    setPreferences(preferences) {
        this.preferences = preferences;
    }
};