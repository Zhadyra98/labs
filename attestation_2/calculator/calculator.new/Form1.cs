using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator.@new
{
    public partial class Form1 : Form
    {
        double fnumber = 0;
        double snumber = 0;
        string operation = "";
        double mem = 0;
        bool performed = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void Number_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            textBox1.Text += button.Text;
            performed = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void Oper_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            if (performed)
            {
                snumber = double.Parse(textBox1.Text);
                textBox1.Text = "";
                performed = false;
            }
            else
            {
                fnumber = double.Parse(textBox1.Text);
                textBox1.Text = "";
                performed = false;
            }
                     
        }
        private void button45_Click(object sender, EventArgs e)
        {
            performed = true;
            snumber = double.Parse(textBox1.Text);
            //textBox1.Text = "";
            if (operation == "+")
            {
                fnumber = fnumber + snumber;
                textBox1.Text=(fnumber + snumber).ToString();
            }
            if (operation == "-")
            {
                fnumber = fnumber - snumber;
                textBox1.Text = (fnumber - snumber).ToString();
            }
            if (operation == "*")
            {
                fnumber = fnumber * snumber;
                textBox1.Text = (fnumber * snumber).ToString();
            }
            if (operation == "/")
            { 
                fnumber = fnumber / snumber;
                textBox1.Text = (fnumber / snumber).ToString();
            }

            textBox1.Text = fnumber.ToString();
        }

        private void button39_Click(object sender, EventArgs e)
        {

        }

        private void button31_Click(object sender, EventArgs e)
        {
            fnumber = -1 * double.Parse(textBox1.Text);
            textBox1.Text = fnumber.ToString();
        }

        private void button39_Click_1(object sender, EventArgs e)
        {
            fnumber = 1 / double.Parse(textBox1.Text);
            textBox1.Text = fnumber.ToString();
        }

        private void Oper1_Click(object sender, EventArgs e)
        {
            snumber = double.Parse(textBox1.Text);
            textBox1.Text = (fnumber * (snumber / 100)).ToString();
            fnumber = double.Parse(textBox1.Text);
        }
        private void button32_Click(object sender, EventArgs e)
        {
            fnumber = Math.Sqrt(double.Parse(textBox1.Text));
            textBox1.Text = fnumber.ToString();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            snumber = 0;
            fnumber = 0;
            textBox1.Text = "";
        }
        private void button6_Click(object sender, EventArgs e)
        {
            string l = "";
            if (textBox1.Text.Contains("."))
            {
                for(int i=0; i<textBox1.Text.Length-1; i++)
                {
                    l += textBox1.Text[i];
                }
                textBox1.Text = l;
            }
            else
            {
                int k = int.Parse(textBox1.Text)/10;
                textBox1.Text = k.ToString();                
            }       

        }
        private void button29_Click(object sender, EventArgs e)
        {
            mem += double.Parse(textBox1.Text);
        }

        private void button30_Click(object sender, EventArgs e)
        {
            mem -= double.Parse(textBox1.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mem = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mem = double.Parse(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = mem.ToString();
        }
    }
}
