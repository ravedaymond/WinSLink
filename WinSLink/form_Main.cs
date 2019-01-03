using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSLink {
    public partial class form_Main : Form {
        private char[] excluded = new char[] { '<', '>', ':', '"', '/', '\\', '|', '?', '*' };

        public form_Main() {
            InitializeComponent();
        }

        // Menu Management
        private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
            Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e) {
            Form form = new form_About();
            form.ShowDialog();
        }

        // Browse Buttons
        private void button_Link_Click(object sender, EventArgs e) {
            String path = "";
            var dialog = new System.Windows.Forms.FolderBrowserDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                path = dialog.SelectedPath;
            }
            text_Link_Path.Text = path;
        }

        private void button_Target_Click(object sender, EventArgs e) {
            String path = "";
            if (radio_Directory.Checked) {
                var dialog = new System.Windows.Forms.FolderBrowserDialog();
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    path = dialog.SelectedPath;
                }
            } else {
                var dialog = new System.Windows.Forms.OpenFileDialog();
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    path = dialog.FileName;
                }
            }
            text_Target_Path.Text = path;
        }

        /// Verify and Create Symbolic Links
        /// If verified, create
        /// else, warn user
        private void button_Create_Click(object sender, EventArgs e) {
            /// Declare and Assign Local Variables
            bool dir = radio_Directory.Checked;
            String link = text_Link_Path.Text.ToString();
            String name = text_Link_Name.Text.ToString();
            String target = text_Target_Path.Text.ToString();
            String sym = "";
            int type = combo_Target.SelectedIndex;
            // Apply correct mklink parameter based on selected options
            switch (type) {
                case 0:
                    if (dir)
                        sym = @"/J";
                    else
                        sym = @"/H";
                    break;
                case 1:
                    if (dir)
                        sym = @"/D";
                    break;
            }
            bool linkCheck = System.IO.Directory.Exists(link);
            bool targetCheck = false;
            // Set correct targetCheck based on link type
            if (dir) { targetCheck = System.IO.Directory.Exists(target); } // Check Target Path for existing Directory
            else { targetCheck = System.IO.File.Exists(target); } // Check Target Path for existing File

            /// Verification
            // Link Path
            if (!linkCheck) {
                MessageBox.Show(
                    "Link Path must target an existing Directory.",
                    "Error - Link Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_Link_Path.Focus();
                text_Link_Path.SelectAll();
                return;
            } else {
                // Remove '\' char if found at end of link path.
                if (link.LastIndexOf('\\').Equals(link.Length - 1)) {
                    link = link.Substring(0, link.LastIndexOf('\\'));
                    text_Link_Path.Text = link;
                }
            }
            // Link Name is not empty
            if (name.Equals("")) {
                MessageBox.Show(
                    "Link Name is empty.",
                    "Error - Link Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_Link_Name.Focus();
                return;
            }
            // Link Name does not contain illegal chars
            if (name.IndexOfAny(excluded) != -1) {
                String illegal = "";
                foreach (char c in excluded) {
                    illegal += $"{c} ";
                }
                MessageBox.Show(
                    "Link Name has illegal characters (" + illegal + ").",
                    "Error - Link Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_Link_Name.Focus();
                text_Link_Name.SelectAll();
                return;
            }
            // Link Name and Link Path Comparisons
            if (dir) {
                // Compare Link Name to end of Link Path for existing Directory
                String check = link.Substring(link.LastIndexOf('\\') + 1);
                if (check.ToLower().Equals(name.ToLower())) {
                    DialogResult result = MessageBox.Show(
                    "The directory targeted by the Link Path has the same name as the Link being created.\n\n" +
                     $"Continuing will create a new directory of '{name}' nested inside the target directory.\n\n" +
                     "Do you want to continue?", "Attention - Link Name", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No) {
                        text_Link_Path.Focus();
                        return;
                    }
                }
                // Check Link Name added to end of Link Path for existing Directory
                if (System.IO.Directory.Exists(link + "\\" + name)) {
                    DialogResult result = MessageBox.Show(
                        $"The directory targeted by the Link Path has an existing directory named '{name}'.\n\n" +
                        $"Continuing will create a new directory of '{name}' nested inside the existing '{name}' directory.\n\n" +
                        "Do you want to continue?",
                        "Attention - Link Name", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.No) {
                        text_Link_Name.Focus();
                        text_Link_Name.SelectAll();
                        return;
                    } else {
                        link += $@"\{name}";
                        MessageBox.Show(link);
                    }
                }
            } else {
                // Check Link Name added to end of Link Path for existing File
                if (System.IO.File.Exists(link + "\\" + name)) {
                    MessageBox.Show(
                        $"A file with the given name '{name}' already exists.\n\n" +
                        "Delete the existing file or change the link name.",
                        "Error - Link Name", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    text_Link_Name.Focus();
                    text_Link_Name.SelectAll();
                    return;
                }
            }
            // Target Path
            if (!targetCheck) {
                MessageBox.Show(
                    "Target path does not exist or is incorrect for selected link type.",
                    "Error - Target Path", MessageBoxButtons.OK, MessageBoxIcon.Error);
                text_Target_Path.Focus();
                text_Target_Path.SelectAll();
                return;
            } else {
                // Remove '\' char if found at end of target path.
                if (target.LastIndexOf('\\').Equals(target.Length - 1)) {
                    target = target.Substring(0, target.LastIndexOf('\\'));
                    text_Target_Path.Text = target;
                }
            }
            // Link Type
            if (type == -1) {
                MessageBox.Show(
                    "Select either an Absolute or Relative link type.",
                    "Error - Link Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                combo_Target.Focus();
                return;
            }

            /// Create Symbolic Link
            link = "\"" + link + $@"\{name}" + "\"";
            target = "\"" + target + "\"";
            String cmd = "";
            if (sym.Equals(""))
                cmd = $@"mklink {link} {target}";
            else
                cmd = $@"mklink {sym} {link} {target}";
            //MessageBox.Show($@"/C {cmd}");
            System.Diagnostics.Process.Start("cmd.exe", $@"/C {cmd}");

            /// Display Symbolic Link Success + Information
            DialogResult complete = MessageBox.Show(
                "Symbolic Link created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
