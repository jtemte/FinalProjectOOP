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
    public partial class Form1 : Form
       
    {
        //private Form0 frm0;
        string line1;
        int counter1 = 0;
        int ID;

        public Form1()
        {
            InitializeComponent();
            ID = int.Parse(File.ReadAllText("ID.idx"));

            StreamReader file2 = new StreamReader("Techs.mtf");
            while ((line1 = file2.ReadLine()) != null)
            {
                comboBox2.Items.Insert(counter1, line1);
                counter1++;
            }
            file2.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string Date = textBox8.Text;
            string Time = textBox7.Text;
            string Type = comboBox1.Text;
            string Fname = textBox3.Text;
            string Lname = textBox4.Text;
            string Pnum = textBox5.Text;
            string Email = textBox6.Text;
            string Problem = textBox1.Text;
            string Resolution = textBox2.Text;
            string Tech = comboBox2.Text;
            ID++;

            File.WriteAllText("Profiles\\"+ID +'-'+Lname+'_'+Fname +".sps", Date + Environment.NewLine + Time + Environment.NewLine + Type + Environment.NewLine + Fname + Environment.NewLine + Lname + Environment.NewLine + Pnum + Environment.NewLine + Email + Environment.NewLine + Problem + Environment.NewLine + Resolution + Environment.NewLine + Tech + Environment.NewLine + ID);
            File.WriteAllText("ID.idx", ID.ToString());
            this.Close();
        }
    }
}
