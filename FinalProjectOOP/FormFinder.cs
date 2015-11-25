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
    public partial class FormFinder : Form
    {
        public FormFinder()
        {
            InitializeComponent();
        }
        OpenFileDialog OFD = new OpenFileDialog();
        private void button1_Click(object sender, EventArgs e)
        {
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = OFD.FileName.ToString();
            }
        }
    }
}
