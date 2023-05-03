using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OcjenskaVjezbaWindowsKontrola
{
    public partial class Text : Form
    {
        public static Text instance;
        public Text()
        {
            InitializeComponent();
            instance = this;
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            Form1.instance.textBoxPrName.Text = textBox1.Text;
            Form1.instance.richTextBoxPrDesc.Text = richTextBox1.Text;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
