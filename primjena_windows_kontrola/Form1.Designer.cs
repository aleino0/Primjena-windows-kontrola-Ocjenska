
namespace primjena_windows_kontrola
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fShow = new System.Windows.Forms.CheckBox();
            this.fProgram = new System.Windows.Forms.ComboBox();
            this.fRun = new System.Windows.Forms.Button();
            this.fRunGroup = new System.Windows.Forms.GroupBox();
            this.fControlGroup = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fClear = new System.Windows.Forms.Button();
            this.fProgramDescription = new System.Windows.Forms.RichTextBox();
            this.fProgramName = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.fRunGroup.SuspendLayout();
            this.fControlGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(350, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "&Open";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(177, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textToolStripMenuItem,
            this.fontToolStripMenuItem,
            this.optionsToolStripMenuItem1});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.textToolStripMenuItem.Text = "Text";
            this.textToolStripMenuItem.Click += new System.EventHandler(this.textToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // optionsToolStripMenuItem1
            // 
            this.optionsToolStripMenuItem1.Name = "optionsToolStripMenuItem1";
            this.optionsToolStripMenuItem1.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem1.Text = "Options";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.toolsToolStripMenuItem.Text = "View";
            // 
            // mToolStripMenuItem
            // 
            this.mToolStripMenuItem.Name = "mToolStripMenuItem";
            this.mToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.mToolStripMenuItem.Text = "Message";
            this.mToolStripMenuItem.Click += new System.EventHandler(this.mToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            // 
            // fShow
            // 
            this.fShow.AutoSize = true;
            this.fShow.Checked = true;
            this.fShow.CheckState = System.Windows.Forms.CheckState.Checked;
            this.fShow.Location = new System.Drawing.Point(36, 195);
            this.fShow.Name = "fShow";
            this.fShow.Size = new System.Drawing.Size(126, 17);
            this.fShow.TabIndex = 1;
            this.fShow.Text = "Show program action";
            this.fShow.UseVisualStyleBackColor = true;
            this.fShow.CheckedChanged += new System.EventHandler(this.fShow_CheckedChanged);
            // 
            // fProgram
            // 
            this.fProgram.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fProgram.Items.AddRange(new object[] {
            "Paint",
            "Notepad"});
            this.fProgram.Location = new System.Drawing.Point(6, 36);
            this.fProgram.Name = "fProgram";
            this.fProgram.Size = new System.Drawing.Size(121, 21);
            this.fProgram.TabIndex = 2;
            // 
            // fRun
            // 
            this.fRun.Location = new System.Drawing.Point(167, 36);
            this.fRun.Name = "fRun";
            this.fRun.Size = new System.Drawing.Size(75, 23);
            this.fRun.TabIndex = 3;
            this.fRun.Text = "Run program";
            this.fRun.UseVisualStyleBackColor = true;
            this.fRun.Click += new System.EventHandler(this.fRun_Click);
            // 
            // fRunGroup
            // 
            this.fRunGroup.Controls.Add(this.fProgram);
            this.fRunGroup.Controls.Add(this.fRun);
            this.fRunGroup.Location = new System.Drawing.Point(36, 47);
            this.fRunGroup.Name = "fRunGroup";
            this.fRunGroup.Size = new System.Drawing.Size(248, 84);
            this.fRunGroup.TabIndex = 4;
            this.fRunGroup.TabStop = false;
            this.fRunGroup.Text = "Run a program";
            // 
            // fControlGroup
            // 
            this.fControlGroup.Controls.Add(this.label2);
            this.fControlGroup.Controls.Add(this.label1);
            this.fControlGroup.Controls.Add(this.fClear);
            this.fControlGroup.Controls.Add(this.fProgramDescription);
            this.fControlGroup.Controls.Add(this.fProgramName);
            this.fControlGroup.Location = new System.Drawing.Point(36, 244);
            this.fControlGroup.Name = "fControlGroup";
            this.fControlGroup.Size = new System.Drawing.Size(248, 155);
            this.fControlGroup.TabIndex = 5;
            this.fControlGroup.TabStop = false;
            this.fControlGroup.Text = "Program control";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Program description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Program name:";
            // 
            // fClear
            // 
            this.fClear.Location = new System.Drawing.Point(156, 38);
            this.fClear.Name = "fClear";
            this.fClear.Size = new System.Drawing.Size(75, 23);
            this.fClear.TabIndex = 11;
            this.fClear.Text = "Clear";
            this.fClear.UseVisualStyleBackColor = true;
            this.fClear.Click += new System.EventHandler(this.fClear_Click);
            // 
            // fProgramDescription
            // 
            this.fProgramDescription.Location = new System.Drawing.Point(7, 84);
            this.fProgramDescription.Name = "fProgramDescription";
            this.fProgramDescription.Size = new System.Drawing.Size(120, 65);
            this.fProgramDescription.TabIndex = 10;
            this.fProgramDescription.Text = "";
            // 
            // fProgramName
            // 
            this.fProgramName.Location = new System.Drawing.Point(6, 38);
            this.fProgramName.Name = "fProgramName";
            this.fProgramName.Size = new System.Drawing.Size(121, 20);
            this.fProgramName.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 447);
            this.Controls.Add(this.fControlGroup);
            this.Controls.Add(this.fRunGroup);
            this.Controls.Add(this.fShow);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Program";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.fRunGroup.ResumeLayout(false);
            this.fControlGroup.ResumeLayout(false);
            this.fControlGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.CheckBox fShow;
        private System.Windows.Forms.ComboBox fProgram;
        private System.Windows.Forms.Button fRun;
        private System.Windows.Forms.GroupBox fRunGroup;
        private System.Windows.Forms.GroupBox fControlGroup;
        private System.Windows.Forms.Button fClear;
        private System.Windows.Forms.RichTextBox fProgramDescription;
        private System.Windows.Forms.TextBox fProgramName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mToolStripMenuItem;
    }
}

