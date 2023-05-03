using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace OcjenskaVjezbaWindowsKontrola
{
    public partial class Form1 : Form
    {
        public static Form1 instance;
        public Form1()
        {
            InitializeComponent();
            instance = this;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                groupBox1.Visible = true;
            }
            else if(!checkBox1.Checked)
            {
                groupBox1.Visible = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Paint")
            {   
                ProcessStartInfo startInfo = new ProcessStartInfo("mspaint.exe");
                startInfo.WindowStyle = ProcessWindowStyle.Normal;
                Process.Start(startInfo); 
            }
            else if(comboBox1.Text == "Notepad")
            {
                ProcessStartInfo startInfo = new ProcessStartInfo("notepad.exe");
                startInfo.WindowStyle = ProcessWindowStyle.Normal;
                Process.Start(startInfo);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxPrName.Clear();
            richTextBoxPrDesc.Clear();
        }

        private void messageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Odaberite neko dugme", "Obavještenje", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text form = new Text();
            form.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult rez;
            rez = MessageBox.Show("Dali ste sigurni da želite zatvoriti aplikaciju?", "Potvrda", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(rez == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
