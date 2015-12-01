﻿using System;
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
        string line1;
        int counter1 = 0;
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
            ID = File.ReadAllText("ID.idx").ToString();
            StreamReader file2 = new StreamReader("Techs.mtf");
            while ((line1 = file2.ReadLine()) != null)
            {
                comboBox2.Items.Insert(counter1, line1);
                counter1++;
            }
            file2.Close();
            address = add;
            StreamReader file = new StreamReader(add);
            while ((line = file.ReadLine()) != null)
            {
                info[counter] = line;
                counter++;
            }

Date = info[0];
Time = info[1];
Type = info[2];
Fname = info[3];
Lname = info[4];
Pnum = info[5];
Email = info[6];
Problem = info[7];
Resolution = info[8];
Tech = info[9];
ID = info[10];

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
            label8.Text = "ID = " + ID;
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

            File.WriteAllText("Profiles\\" + ID + '-' + Lname + '_' + Fname + ".sps", Date + Environment.NewLine + Time + Environment.NewLine + Type + Environment.NewLine + Fname + Environment.NewLine + Lname + Environment.NewLine + Pnum + Environment.NewLine + Email + Environment.NewLine + Problem + Environment.NewLine + Resolution + Environment.NewLine + Tech + Environment.NewLine + ID);
            this.Close();
        }
    }
}
