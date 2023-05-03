using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primjena_windows_kontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fRun_Click(object sender, EventArgs e)
        {
            if (fProgram.Text == "Paint")
            {
                Process.Start("MSPaint.exe");
                fProgramName.Text = "MS paint";
                fProgramDescription.Text = "crtanje i bojanje";
            }

            if (fProgram.Text == "Notepad")
            {
                Process.Start("Notepad.exe");
                fProgramName.Text = "Notepad";
                fProgramDescription.Text = "teks editor";
            }
        }

        private void fShow_CheckedChanged(object sender, EventArgs e)
        {
            switch (fShow.Checked)
            {
                case true:
                    fControlGroup.Visible = true;
                    break;

                case false:
                    fControlGroup.Visible = false;
                    break;
            }
        }

        private void fClear_Click(object sender, EventArgs e)
        {
            fProgramName.Clear();
            fProgramDescription.Clear();    
        }

        private void mToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Odaberite neko dugme", "Obavještrenje",
                            MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Dali ste sigurni da želite zatvoriti aplikaciju", "Potvrda",
                            MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (dialog == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaText text = new FormaText();
            if (FormaText.ShowDialog(Owner) == DialogResult.OK)
            {
                fProgramName.AppendText(FormaText.f2ProgramName);
                fProgramDescription.AppendText(FormaText.f2ProgramDesc);
            }


        }
    }
}
