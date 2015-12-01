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
            //OFD.InitialDirectory = ".\\Profiles\\";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                address = OFD.FileName.ToString();
                Form2 form = new Form2(address);
                form.ShowDialog();
            }
        }

        private void visitWebsiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://temteindustries.com/supsys.html");
        }

        private void manageTechnitiansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mtechs form = new Mtechs();
            form.ShowDialog();
        }

        private void documentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process firstProc = new Process();
            firstProc.StartInfo.FileName = "SupSys_User_Manual.pdf";
            firstProc.EnableRaisingEvents = true;

            firstProc.Start();
        }
    }
}
