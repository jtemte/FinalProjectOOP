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
            textBox2.Text = Problem;
            textBox1.Text = Resolution;
            comboBox2.Text = Tech;
        }
            
    }
}
