
namespace primjena_windows_kontrola
{
    partial class FormaText
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.f2ProgramName = new System.Windows.Forms.TextBox();
            this.f2ProgramDesc = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Program name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Program description:";
            // 
            // f2ProgramName
            // 
            this.f2ProgramName.Location = new System.Drawing.Point(129, 21);
            this.f2ProgramName.Name = "f2ProgramName";
            this.f2ProgramName.Size = new System.Drawing.Size(100, 20);
            this.f2ProgramName.TabIndex = 2;
            // 
            // f2ProgramDesc
            // 
            this.f2ProgramDesc.Location = new System.Drawing.Point(129, 81);
            this.f2ProgramDesc.Name = "f2ProgramDesc";
            this.f2ProgramDesc.Size = new System.Drawing.Size(180, 83);
            this.f2ProgramDesc.TabIndex = 3;
            this.f2ProgramDesc.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(233, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // FormaText
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 260);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.f2ProgramDesc);
            this.Controls.Add(this.f2ProgramName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormaText";
            this.Text = "FormaText";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox f2ProgramName;
        private System.Windows.Forms.RichTextBox f2ProgramDesc;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}