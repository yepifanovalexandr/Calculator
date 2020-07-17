using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{

    public partial class Calculator : Form
    {
        float a;
        bool clear;
        public Calculator()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            a = 0;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    a = float.Parse(textBox1.Text);
                    if (rad)
                    {

                        textBox1.Text = Math.Sin(a).ToString();
                    }
                    else
                    {
                        textBox1.Text = Math.Sin((a / 180D) * Math.PI).ToString();
                    }
                }
                else
                {
                    label1.Text = "Введите аргумент";
                    clear = true;
                }
            }
            catch { }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    a = float.Parse(textBox1.Text);
                    if (rad)
                    {

                        textBox1.Text = Math.Tan(a).ToString();
                    }
                    else
                    {
                        textBox1.Text = Math.Tan((a / 180D) * Math.PI).ToString();
                    }
                }
                else
                {
                    label1.Text = "Введите аргумент";
                    clear = true;
                }
            }
            catch { }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            DeleteZero();

            PrintNumber("9");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DeleteZero();
            PrintNumber("0");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DeleteZero();
            PrintNumber("1");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DeleteZero();
            PrintNumber("2");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            DeleteZero();
            PrintNumber("3");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            DeleteZero();
            PrintNumber("4");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DeleteZero();
            PrintNumber("5");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DeleteZero();
            PrintNumber("6");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DeleteZero();
            PrintNumber("7");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DeleteZero();
            PrintNumber("8");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
                {
                    a = float.Parse(textBox1.Text);
                    if (rad)
                    {

                        textBox1.Text = Math.Cos(a).ToString();
                    }
                    else
                    {
                        textBox1.Text = Math.Cos((a / 180D) * Math.PI).ToString();
                    }
                }
                else
                {
                    label1.Text = "Введите аргумент";
                    clear = true;
                }
            }
            catch { }
        }
        bool rad = true;
        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                rad = !rad;
                if (rad)
                {
                    button15.Text = "rad";
                }
                else
                {
                    button15.Text = "deg";
                }
            }
            catch { }
        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            label1.Text = "";
            dot = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
            if (textBox1.Text == "")
            {
                textBox1.Text = "0";
                a = 0;
            }
        }

        void Calculate()
        {

        }
        void DeleteZero()
        {
            if (clear)
            {
                label1.Text = null;
            }
            if (textBox1.Text == "0")
            {
                textBox1.Text = "";
            }
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "0")
            {
                textBox1.Text = "-";
            }
            if (textBox1.Text.Count() > 0 && textBox1.Text != "-")
            {
                float b, res;
                a = float.Parse(textBox1.Text);
                b = a * 2;
                res = a - b;
                textBox1.Text = res.ToString();
            }
        }
        bool dot = false;
        private void button18_Click(object sender, EventArgs e)
        {
            if (!dot)
            {
                textBox1.Text = textBox1.Text + ".";
                dot = true;
            }

        }

        void PrintNumber(string digit)
        {
            if (textBox1.Text.Count() < 15)
                textBox1.Text = textBox1.Text + digit;
            clear = false;
        }
    }
}