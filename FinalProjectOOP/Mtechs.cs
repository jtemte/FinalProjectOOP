using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FinalProjectOOP
{
    public partial class Mtechs : Form
    {
        string line = "";
        string line1;
        int counter = 0;

        public Mtechs()
        {
            InitializeComponent();

            StreamReader file = new StreamReader("Techs.mtf");
            while ((line1 = file.ReadLine()) != null)
            {
                if (counter == 0)
                {
                    line = line1;
                }
                else
                {
                    line = line + Environment.NewLine +line1;
                }
                
                counter++;
            }
            file.Close();
            textBox1.Text = line;
        }

         

        private void button1_Click(object sender, EventArgs e)
        {
            string names = textBox1.Text;

            File.WriteAllText("Techs.mtf", names);
            this.Close();
        }

    }
}
