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
    public partial class Form2 : Form
    {
        string[] info = new string[11];
        string line;
        int counter = 0;
        string address;

        string Date;
        string Time;
        string Type;
        string Fname;
        string Lname;
        string Pnum;
        string Email;
        string Problem;
        string Resolution;
        string Tech;
        string ID;

        public Form2(string add)

        {
            InitializeComponent();

            comboBox2.Items.Insert(0, "Joe Temte");
            comboBox2.Items.Insert(1, "Jessica Livingston");
            comboBox2.Items.Insert(2, "Gavin Anthony");

            address = add;
            StreamReader file = new StreamReader(add);
            while ((line = file.ReadLine()) != null)
            {
                info[counter] = line;
                counter++;
            }

            string Date = info[0];
            string Time = info[1];
            string Type = info[2];
            string Fname = info[3];
            string Lname = info[4];
            string Pnum = info[5];
            string Email = info[6];
            string Problem = info[7];
            string Resolution = info[8];
            string Tech = info[9];
            string ID = info[10];

            textBox8.Text = Date;
            textBox7.Text = Time;
            comboBox1.Text = Type;
            textBox3.Text = Fname;
            textBox4.Text = Lname;
            textBox5.Text = Pnum;
            textBox6.Text = Email;
            textBox1.Text = Problem;
            textBox2.Text = Resolution;
            comboBox2.Text = Tech;
            file.Close();
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
            int ID = 00002;

            File.WriteAllText(ID + ".txt", Date + Environment.NewLine + Time + Environment.NewLine + Type + Environment.NewLine + Fname + Environment.NewLine + Lname + Environment.NewLine + Pnum + Environment.NewLine + Email + Environment.NewLine + Problem + Environment.NewLine + Resolution + Environment.NewLine + Tech + Environment.NewLine + ID);
            this.Close();
        }
    }
}
