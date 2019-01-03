namespace WinSLink {
    partial class form_Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_Main));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.help_type = new System.Windows.Forms.PictureBox();
            this.radio_File = new System.Windows.Forms.RadioButton();
            this.radio_Directory = new System.Windows.Forms.RadioButton();
            this.group_Link = new System.Windows.Forms.GroupBox();
            this.help_link = new System.Windows.Forms.PictureBox();
            this.text_Link_Name = new System.Windows.Forms.TextBox();
            this.label_Link = new System.Windows.Forms.Label();
            this.button_Link = new System.Windows.Forms.Button();
            this.text_Link_Path = new System.Windows.Forms.TextBox();
            this.group_Target = new System.Windows.Forms.GroupBox();
            this.help_target = new System.Windows.Forms.PictureBox();
            this.combo_Target = new System.Windows.Forms.ComboBox();
            this.label_Target = new System.Windows.Forms.Label();
            this.button_Target = new System.Windows.Forms.Button();
            this.text_Target_Path = new System.Windows.Forms.TextBox();
            this.menu_Top = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button_Create = new System.Windows.Forms.Button();
            this.tooltip_type = new System.Windows.Forms.ToolTip(this.components);
            this.tooltip_link = new System.Windows.Forms.ToolTip(this.components);
            this.tooltip_target = new System.Windows.Forms.ToolTip(this.components);
            this.help_all = new System.Windows.Forms.PictureBox();
            this.tooltip_symbolic = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.help_type)).BeginInit();
            this.group_Link.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.help_link)).BeginInit();
            this.group_Target.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.help_target)).BeginInit();
            this.menu_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.help_all)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.help_type);
            this.groupBox1.Controls.Add(this.radio_File);
            this.groupBox1.Controls.Add(this.radio_Directory);
            this.groupBox1.Location = new System.Drawing.Point(12, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(474, 67);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select the type of Symbolic Link you want to create:";
            // 
            // help_type
            // 
            this.help_type.BackgroundImage = global::WinSLink.Properties.Resources.img_help;
            this.help_type.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.help_type.Location = new System.Drawing.Point(382, 33);
            this.help_type.Name = "help_type";
            this.help_type.Size = new System.Drawing.Size(26, 26);
            this.help_type.TabIndex = 6;
            this.help_type.TabStop = false;
            this.tooltip_type.SetToolTip(this.help_type, "Select whether you would like to create a \r\nSymbolic Link for a Directory or for " +
        "a File.");
            // 
            // radio_File
            // 
            this.radio_File.AutoSize = true;
            this.radio_File.Location = new System.Drawing.Point(117, 33);
            this.radio_File.Name = "radio_File";
            this.radio_File.Size = new System.Drawing.Size(59, 24);
            this.radio_File.TabIndex = 1;
            this.radio_File.Text = "File";
            this.radio_File.UseVisualStyleBackColor = true;
            // 
            // radio_Directory
            // 
            this.radio_Directory.AutoSize = true;
            this.radio_Directory.Checked = true;
            this.radio_Directory.Location = new System.Drawing.Point(14, 33);
            this.radio_Directory.Name = "radio_Directory";
            this.radio_Directory.Size = new System.Drawing.Size(97, 24);
            this.radio_Directory.TabIndex = 0;
            this.radio_Directory.TabStop = true;
            this.radio_Directory.Text = "Directory";
            this.radio_Directory.UseVisualStyleBackColor = true;
            // 
            // group_Link
            // 
            this.group_Link.Controls.Add(this.help_link);
            this.group_Link.Controls.Add(this.text_Link_Name);
            this.group_Link.Controls.Add(this.label_Link);
            this.group_Link.Controls.Add(this.button_Link);
            this.group_Link.Controls.Add(this.text_Link_Path);
            this.group_Link.Location = new System.Drawing.Point(12, 116);
            this.group_Link.Name = "group_Link";
            this.group_Link.Padding = new System.Windows.Forms.Padding(10);
            this.group_Link.Size = new System.Drawing.Size(474, 101);
            this.group_Link.TabIndex = 1;
            this.group_Link.TabStop = false;
            this.group_Link.Text = "Link Path:";
            // 
            // help_link
            // 
            this.help_link.BackgroundImage = global::WinSLink.Properties.Resources.img_help;
            this.help_link.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.help_link.Location = new System.Drawing.Point(382, 64);
            this.help_link.Name = "help_link";
            this.help_link.Size = new System.Drawing.Size(26, 26);
            this.help_link.TabIndex = 4;
            this.help_link.TabStop = false;
            this.tooltip_link.SetToolTip(this.help_link, "Select the directory which the link will be\r\ncreated in.\r\n\r\nNext, give the link a" +
        " unique name.");
            // 
            // text_Link_Name
            // 
            this.text_Link_Name.Location = new System.Drawing.Point(161, 64);
            this.text_Link_Name.Name = "text_Link_Name";
            this.text_Link_Name.Size = new System.Drawing.Size(213, 26);
            this.text_Link_Name.TabIndex = 3;
            // 
            // label_Link
            // 
            this.label_Link.AutoSize = true;
            this.label_Link.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Link.Location = new System.Drawing.Point(14, 67);
            this.label_Link.Name = "label_Link";
            this.label_Link.Size = new System.Drawing.Size(106, 20);
            this.label_Link.TabIndex = 2;
            this.label_Link.Text = "Name of Link:";
            // 
            // button_Link
            // 
            this.button_Link.AutoSize = true;
            this.button_Link.Location = new System.Drawing.Point(380, 30);
            this.button_Link.Name = "button_Link";
            this.button_Link.Size = new System.Drawing.Size(84, 30);
            this.button_Link.TabIndex = 1;
            this.button_Link.Text = "Browse...";
            this.button_Link.UseVisualStyleBackColor = true;
            this.button_Link.Click += new System.EventHandler(this.button_Link_Click);
            // 
            // text_Link_Path
            // 
            this.text_Link_Path.Location = new System.Drawing.Point(13, 32);
            this.text_Link_Path.Name = "text_Link_Path";
            this.text_Link_Path.Size = new System.Drawing.Size(361, 26);
            this.text_Link_Path.TabIndex = 0;
            // 
            // group_Target
            // 
            this.group_Target.Controls.Add(this.help_target);
            this.group_Target.Controls.Add(this.combo_Target);
            this.group_Target.Controls.Add(this.label_Target);
            this.group_Target.Controls.Add(this.button_Target);
            this.group_Target.Controls.Add(this.text_Target_Path);
            this.group_Target.Location = new System.Drawing.Point(12, 223);
            this.group_Target.Name = "group_Target";
            this.group_Target.Padding = new System.Windows.Forms.Padding(10);
            this.group_Target.Size = new System.Drawing.Size(474, 100);
            this.group_Target.TabIndex = 2;
            this.group_Target.TabStop = false;
            this.group_Target.Text = "Target Path:";
            // 
            // help_target
            // 
            this.help_target.BackgroundImage = global::WinSLink.Properties.Resources.img_help;
            this.help_target.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.help_target.Location = new System.Drawing.Point(382, 65);
            this.help_target.Name = "help_target";
            this.help_target.Size = new System.Drawing.Size(26, 26);
            this.help_target.TabIndex = 5;
            this.help_target.TabStop = false;
            this.tooltip_target.SetToolTip(this.help_target, "Select the target directory or file of the \r\nlink.\r\n\r\nNext, select whether the li" +
        "nk is an Absolute \r\n(Hard) or Relative (Soft) link.");
            // 
            // combo_Target
            // 
            this.combo_Target.FormattingEnabled = true;
            this.combo_Target.Items.AddRange(new object[] {
            "Absolute Link (Hard Link)",
            "Relative Link (Soft Link)"});
            this.combo_Target.Location = new System.Drawing.Point(161, 64);
            this.combo_Target.Name = "combo_Target";
            this.combo_Target.Size = new System.Drawing.Size(213, 28);
            this.combo_Target.TabIndex = 3;
            // 
            // label_Target
            // 
            this.label_Target.AutoSize = true;
            this.label_Target.Location = new System.Drawing.Point(14, 67);
            this.label_Target.Name = "label_Target";
            this.label_Target.Size = new System.Drawing.Size(98, 20);
            this.label_Target.TabIndex = 2;
            this.label_Target.Text = "Type of Link:";
            // 
            // button_Target
            // 
            this.button_Target.AutoSize = true;
            this.button_Target.Location = new System.Drawing.Point(380, 30);
            this.button_Target.Name = "button_Target";
            this.button_Target.Size = new System.Drawing.Size(84, 30);
            this.button_Target.TabIndex = 1;
            this.button_Target.Text = "Browse...";
            this.button_Target.UseVisualStyleBackColor = true;
            this.button_Target.Click += new System.EventHandler(this.button_Target_Click);
            // 
            // text_Target_Path
            // 
            this.text_Target_Path.Location = new System.Drawing.Point(13, 32);
            this.text_Target_Path.Name = "text_Target_Path";
            this.text_Target_Path.Size = new System.Drawing.Size(361, 26);
            this.text_Target_Path.TabIndex = 0;
            // 
            // menu_Top
            // 
            this.menu_Top.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu_Top.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menu_Top.Location = new System.Drawing.Point(0, 0);
            this.menu_Top.Name = "menu_Top";
            this.menu_Top.Size = new System.Drawing.Size(498, 33);
            this.menu_Top.TabIndex = 3;
            this.menu_Top.Text = "menu_Top";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(123, 30);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(61, 29);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(158, 30);
            this.aboutToolStripMenuItem.Text = "About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // button_Create
            // 
            this.button_Create.AutoSize = true;
            this.button_Create.Location = new System.Drawing.Point(392, 328);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(94, 30);
            this.button_Create.TabIndex = 5;
            this.button_Create.Text = "Create";
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // tooltip_type
            // 
            this.tooltip_type.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tooltip_type.ToolTipTitle = "Link Type";
            // 
            // tooltip_link
            // 
            this.tooltip_link.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tooltip_link.ToolTipTitle = "Link";
            // 
            // tooltip_target
            // 
            this.tooltip_target.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tooltip_target.ToolTipTitle = "Target";
            // 
            // help_all
            // 
            this.help_all.BackgroundImage = global::WinSLink.Properties.Resources.img_help;
            this.help_all.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.help_all.Location = new System.Drawing.Point(12, 332);
            this.help_all.Name = "help_all";
            this.help_all.Size = new System.Drawing.Size(26, 26);
            this.help_all.TabIndex = 6;
            this.help_all.TabStop = false;
            this.tooltip_symbolic.SetToolTip(this.help_all, resources.GetString("help_all.ToolTip"));
            // 
            // tooltip_symbolic
            // 
            this.tooltip_symbolic.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.tooltip_symbolic.ToolTipTitle = "Symbolic Links";
            // 
            // form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 369);
            this.Controls.Add(this.help_all);
            this.Controls.Add(this.button_Create);
            this.Controls.Add(this.group_Target);
            this.Controls.Add(this.group_Link);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menu_Top);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu_Top;
            this.MaximizeBox = false;
            this.Name = "form_Main";
            this.Text = "WinSLink";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.help_type)).EndInit();
            this.group_Link.ResumeLayout(false);
            this.group_Link.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.help_link)).EndInit();
            this.group_Target.ResumeLayout(false);
            this.group_Target.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.help_target)).EndInit();
            this.menu_Top.ResumeLayout(false);
            this.menu_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.help_all)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radio_File;
        private System.Windows.Forms.RadioButton radio_Directory;
        private System.Windows.Forms.GroupBox group_Link;
        private System.Windows.Forms.Button button_Link;
        private System.Windows.Forms.TextBox text_Link_Path;
        private System.Windows.Forms.GroupBox group_Target;
        private System.Windows.Forms.Button button_Target;
        private System.Windows.Forms.TextBox text_Target_Path;
        private System.Windows.Forms.TextBox text_Link_Name;
        private System.Windows.Forms.Label label_Link;
        private System.Windows.Forms.Label label_Target;
        private System.Windows.Forms.MenuStrip menu_Top;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button button_Create;
        private System.Windows.Forms.ComboBox combo_Target;
        private System.Windows.Forms.PictureBox help_type;
        private System.Windows.Forms.PictureBox help_link;
        private System.Windows.Forms.PictureBox help_target;
        private System.Windows.Forms.ToolTip tooltip_type;
        private System.Windows.Forms.ToolTip tooltip_link;
        private System.Windows.Forms.ToolTip tooltip_target;
        private System.Windows.Forms.PictureBox help_all;
        private System.Windows.Forms.ToolTip tooltip_symbolic;
    }
}

