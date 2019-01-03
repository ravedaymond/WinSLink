namespace WinSLink {
    partial class form_About {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form_About));
            this.table_about = new System.Windows.Forms.TableLayoutPanel();
            this.button_about = new System.Windows.Forms.Button();
            this.label_about_link = new System.Windows.Forms.LinkLabel();
            this.label_about_title = new System.Windows.Forms.Label();
            this.label_about_description = new System.Windows.Forms.Label();
            this.table_about.SuspendLayout();
            this.SuspendLayout();
            // 
            // table_about
            // 
            this.table_about.ColumnCount = 1;
            this.table_about.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table_about.Controls.Add(this.button_about, 0, 3);
            this.table_about.Controls.Add(this.label_about_link, 0, 1);
            this.table_about.Controls.Add(this.label_about_title, 0, 0);
            this.table_about.Controls.Add(this.label_about_description, 0, 2);
            this.table_about.Location = new System.Drawing.Point(17, 17);
            this.table_about.Name = "table_about";
            this.table_about.RowCount = 4;
            this.table_about.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table_about.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table_about.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.table_about.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.table_about.Size = new System.Drawing.Size(264, 160);
            this.table_about.TabIndex = 1;
            // 
            // button_about
            // 
            this.button_about.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_about.AutoSize = true;
            this.button_about.Location = new System.Drawing.Point(94, 131);
            this.button_about.Name = "button_about";
            this.button_about.Size = new System.Drawing.Size(75, 26);
            this.button_about.TabIndex = 0;
            this.button_about.Text = "Close";
            this.button_about.UseVisualStyleBackColor = true;
            this.button_about.Click += new System.EventHandler(this.button_about_Click);
            // 
            // label_about_link
            // 
            this.label_about_link.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label_about_link.AutoSize = true;
            this.label_about_link.Location = new System.Drawing.Point(6, 32);
            this.label_about_link.Name = "label_about_link";
            this.label_about_link.Size = new System.Drawing.Size(251, 32);
            this.label_about_link.TabIndex = 3;
            this.label_about_link.TabStop = true;
            this.label_about_link.Text = "Copyright (c) 2019 Dave Raymond";
            this.label_about_link.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_about_link.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.label_about_link_LinkClicked);
            // 
            // label_about_title
            // 
            this.label_about_title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label_about_title.AutoSize = true;
            this.label_about_title.Location = new System.Drawing.Point(59, 0);
            this.label_about_title.Name = "label_about_title";
            this.label_about_title.Size = new System.Drawing.Size(146, 32);
            this.label_about_title.TabIndex = 4;
            this.label_about_title.Text = "WinSLink // Version";
            this.label_about_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_about_description
            // 
            this.label_about_description.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label_about_description.AutoSize = true;
            this.label_about_description.Location = new System.Drawing.Point(28, 64);
            this.label_about_description.Name = "label_about_description";
            this.label_about_description.Size = new System.Drawing.Size(207, 64);
            this.label_about_description.TabIndex = 5;
            this.label_about_description.Text = "WinSLink is a tool to create Symbolic Links on Windows.";
            this.label_about_description.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // form_About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 184);
            this.Controls.Add(this.table_about);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "form_About";
            this.Padding = new System.Windows.Forms.Padding(14);
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About";
            this.table_about.ResumeLayout(false);
            this.table_about.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TableLayoutPanel table_about;
        private System.Windows.Forms.LinkLabel label_about_link;
        private System.Windows.Forms.Label label_about_title;
        private System.Windows.Forms.Label label_about_description;
        private System.Windows.Forms.Button button_about;
    }
}