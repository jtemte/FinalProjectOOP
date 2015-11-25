using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectOOP
{
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About form = new About();
            form.ShowDialog();
        }

        private void newRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form1 form = new Form1();
            form.ShowDialog();
        }
        OpenFileDialog OFD = new OpenFileDialog();
        string address = "";
        private void button2_Click(object sender, EventArgs e)
        {
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                address = OFD.FileName.ToString();
                Form2 form = new Form2(address);
                form.ShowDialog();
            }
        }

        private void loadRequestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                address = OFD.FileName.ToString();
                Form2 form = new Form2(address);
                form.ShowDialog();
            }
        }

        private void visitWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.temteindustries.com");
        }
    }
}
