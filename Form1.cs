using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.Nasledovanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<human> studlist = new List<human>();

        private void button1_Click(object sender, EventArgs e)
        { // студент
            student s1 = new student();
            s1.name = textBox1.Text;
            s1.score = Convert.ToInt32(textBox4.Text);
            studlist.Add(s1);
        }

        private void button2_Click(object sender, EventArgs e)
        { // раб
            employer e1 = new employer();
            e1.name = textBox1.Text;
            e1.sallary = Convert.ToInt32(textBox2.Text);
            e1.tax = Convert.ToInt32(textBox3.Text);
            studlist.Add(e1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            int stud = 0;
            for(int i = 0; i < studlist.Count; i++)
            {
                listBox1.Items.Add(studlist[i].GetType().Name + " " + studlist[i].name + " " + studlist[i].Money());
                if (studlist[i] is student)
                    stud++;
            }
            label5.Text = "Количество студентов: " + stud + ". Количество рабочих: " + (studlist.Count - stud);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label5.Text = "";
            human man = studlist[Convert.ToInt32(textBox5.Text)];
            //label5.Text = man.Money().ToString();
            label5.Text += "Name: " + man.name + ", type:" + man.GetType().Name + ", money: " + man.Money().ToString();
            if (man is student)
            {
                student man2 = (student) man;
                label5.Text += ", score: " + man2.score.ToString();
            }
            else 
                if(man is employer)
                {
                employer man2 = (employer)man;
                label5.Text += ", tax: " + man2.tax.ToString() + ", sallary: " + man2.sallary;
                }
        }
    }
}
