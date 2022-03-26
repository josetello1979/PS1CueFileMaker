namespace PS1CueFileMaker
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabMainControl = new System.Windows.Forms.TabControl();
            this.tabMain = new System.Windows.Forms.TabPage();
            this.tabError = new System.Windows.Forms.TabPage();
            this.btnCreateCueFiles = new System.Windows.Forms.Button();
            this.txtInputDirectory = new System.Windows.Forms.TextBox();
            this.txtError = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chkRecursive = new System.Windows.Forms.CheckBox();
            this.tabInfo = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabMainControl.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabError.SuspendLayout();
            this.tabInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMainControl
            // 
            this.tabMainControl.Controls.Add(this.tabMain);
            this.tabMainControl.Controls.Add(this.tabError);
            this.tabMainControl.Controls.Add(this.tabInfo);
            this.tabMainControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMainControl.Location = new System.Drawing.Point(0, 0);
            this.tabMainControl.Name = "tabMainControl";
            this.tabMainControl.SelectedIndex = 0;
            this.tabMainControl.Size = new System.Drawing.Size(800, 450);
            this.tabMainControl.TabIndex = 0;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.chkRecursive);
            this.tabMain.Controls.Add(this.label1);
            this.tabMain.Controls.Add(this.txtInputDirectory);
            this.tabMain.Controls.Add(this.btnCreateCueFiles);
            this.tabMain.Location = new System.Drawing.Point(4, 22);
            this.tabMain.Name = "tabMain";
            this.tabMain.Padding = new System.Windows.Forms.Padding(3);
            this.tabMain.Size = new System.Drawing.Size(792, 424);
            this.tabMain.TabIndex = 0;
            this.tabMain.Text = "Main";
            this.tabMain.UseVisualStyleBackColor = true;
            // 
            // tabError
            // 
            this.tabError.Controls.Add(this.txtError);
            this.tabError.Location = new System.Drawing.Point(4, 22);
            this.tabError.Name = "tabError";
            this.tabError.Padding = new System.Windows.Forms.Padding(3);
            this.tabError.Size = new System.Drawing.Size(792, 424);
            this.tabError.TabIndex = 1;
            this.tabError.Text = "Error";
            this.tabError.UseVisualStyleBackColor = true;
            // 
            // btnCreateCueFiles
            // 
            this.btnCreateCueFiles.Location = new System.Drawing.Point(648, 73);
            this.btnCreateCueFiles.Name = "btnCreateCueFiles";
            this.btnCreateCueFiles.Size = new System.Drawing.Size(136, 23);
            this.btnCreateCueFiles.TabIndex = 0;
            this.btnCreateCueFiles.Text = "Create Cue File...";
            this.btnCreateCueFiles.UseVisualStyleBackColor = true;
            this.btnCreateCueFiles.Click += new System.EventHandler(this.btnCreateCueFiles_Click);
            // 
            // txtInputDirectory
            // 
            this.txtInputDirectory.Location = new System.Drawing.Point(11, 47);
            this.txtInputDirectory.Name = "txtInputDirectory";
            this.txtInputDirectory.Size = new System.Drawing.Size(773, 20);
            this.txtInputDirectory.TabIndex = 1;
            this.txtInputDirectory.Text = "i:\\Emulador\\Emulador - PS1\\00000\\";
            // 
            // txtError
            // 
            this.txtError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtError.Location = new System.Drawing.Point(3, 3);
            this.txtError.MaxLength = 999999999;
            this.txtError.Multiline = true;
            this.txtError.Name = "txtError";
            this.txtError.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtError.Size = new System.Drawing.Size(786, 418);
            this.txtError.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Directory Path:";
            // 
            // chkRecursive
            // 
            this.chkRecursive.AutoSize = true;
            this.chkRecursive.Checked = true;
            this.chkRecursive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkRecursive.Location = new System.Drawing.Point(113, 26);
            this.chkRecursive.Name = "chkRecursive";
            this.chkRecursive.Size = new System.Drawing.Size(111, 17);
            this.chkRecursive.TabIndex = 3;
            this.chkRecursive.Text = "Recursive Search";
            this.chkRecursive.UseVisualStyleBackColor = true;
            // 
            // tabInfo
            // 
            this.tabInfo.Controls.Add(this.textBox1);
            this.tabInfo.Location = new System.Drawing.Point(4, 22);
            this.tabInfo.Name = "tabInfo";
            this.tabInfo.Size = new System.Drawing.Size(792, 424);
            this.tabInfo.TabIndex = 2;
            this.tabInfo.Text = "Info";
            this.tabInfo.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.MaxLength = 999999999;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(792, 424);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "\r\nautor:  Jose Tello\r\ndate 2022-03-26_103607\r\neduardo_tello@hotmail.com\r\neduardo." +
    "tello@gmail.com\r\n\r\nCreate .cue files for .bin files of PS1 roms\r\n \r\n";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabMainControl);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PS1CueMaker";
            this.Load += new System.EventHandler(this.Main_Load);
            this.tabMainControl.ResumeLayout(false);
            this.tabMain.ResumeLayout(false);
            this.tabMain.PerformLayout();
            this.tabError.ResumeLayout(false);
            this.tabError.PerformLayout();
            this.tabInfo.ResumeLayout(false);
            this.tabInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabMainControl;
        private System.Windows.Forms.TabPage tabMain;
        private System.Windows.Forms.TextBox txtInputDirectory;
        private System.Windows.Forms.Button btnCreateCueFiles;
        private System.Windows.Forms.TabPage tabError;
        private System.Windows.Forms.TextBox txtError;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkRecursive;
        private System.Windows.Forms.TabPage tabInfo;
        private System.Windows.Forms.TextBox textBox1;
    }
}

