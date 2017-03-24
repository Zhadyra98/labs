using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        double reval = 0;
        string per;
        bool x=false;
        double mem = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void number_click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" || x==true)
                textBox1.Clear();
            x = false;
            Button btn = sender as Button;
            if (btn.Text == ".")
            {
                if (!textBox1.Text.Contains("."))
                    textBox1.Text = textBox1.Text + btn.Text;
            }
            else         
            textBox1.Text += btn.Text;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (per == "+")
            {
                textBox1.Text = (reval + Double.Parse(textBox1.Text)).ToString();
            }
            if (per == "-")
            {
                textBox1.Text = (reval - Double.Parse(textBox1.Text)).ToString();
            }
            if (per == "*")
            {
                textBox1.Text = (reval * Double.Parse(textBox1.Text)).ToString();
            }
            if (per == "/")
            {
                textBox1.Text = (reval / Double.Parse(textBox1.Text)).ToString();
            }
            reval = Double.Parse(textBox1.Text);
            operationlabel.Text = "";
        }


        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            reval = 0;
        }
        private void oper_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (reval != 0)
            {
                button12.PerformClick();
                per = button.Text;
                operationlabel.Text = reval + "" + per;
                x = true;
            }
            else
            {
                per = button.Text;
                reval = Double.Parse(textBox1.Text);
                operationlabel.Text = reval + "" + per;
                x = true;
            }

        }
        private void div_Click(object sender, EventArgs e)
        {
            per = "1/x";
            textBox1.Text = (1 / Double.Parse(textBox1.Text)).ToString();
            reval = Double.Parse(textBox1.Text);
            operationlabel.Text = " ";
            operationlabel.Text = "1/" + textBox1.Text;
        }

        private void proc_Click(object sender, EventArgs e)
        {
            textBox1.Text = (reval * (Double.Parse(textBox1.Text) / 100)).ToString();
            reval = Double.Parse(textBox1.Text);
            operationlabel.Text = "";
        }

        private void sqrt_click(object sender, EventArgs e)
        {
            textBox1.Text = Math.Sqrt(double.Parse(textBox1.Text)).ToString();
            reval = double.Parse(textBox1.Text);
            operationlabel.Text = "sqrt(" + textBox1.Text + ")";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            double k = double.Parse(textBox1.Text)*(-1);
            textBox1.Text = k.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            double k = double.Parse(textBox1.Text) /10;
            textBox1.Text = k.ToString();
        }

        private void mem_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Text == "M-")
            {
                mem = mem - double.Parse(textBox1.Text);
            }
            if (btn.Text == "M+")
            {
                mem = mem + double.Parse(textBox1.Text);
            }
            if (btn.Text == "MR")
            {
                double m = double.Parse(textBox1.Text) + mem;
                textBox1.Text = m.ToString();
            }
            if (btn.Text == "MS")
            {
                mem = double.Parse(textBox1.Text);
                textBox1.Text = "";
            }
            if (btn.Text == "MC")
            {
                mem = 0;
                textBox1.Text = "";
            }
        }

        /* private void button1_Click(object sender, EventArgs e)
         {
             textBox1.Text += '1';
         }

         private void button2_Click(object sender, EventArgs e)
         {
             textBox1.Text += '2';
         }

         private void button3_Click(object sender, EventArgs e)
         {
             textBox1.Text += '3';
         }

         private void button4_Click(object sender, EventArgs e)
         {
             textBox1.Text += '4';
         }

         private void button5_Click(object sender, EventArgs e)
         {
             textBox1.Text += '5';
         }

         private void button6_Click(object sender, EventArgs e)
         {
             textBox1.Text += '6';
         }

         private void button7_Click(object sender, EventArgs e)
         {
             textBox1.Text += '7';
         }

         private void button8_Click(object sender, EventArgs e)
         {
             textBox1.Text += '8';
         }

         private void button9_Click(object sender, EventArgs e)
         {
             textBox1.Text += '9';
         }

         private void button10_Click(object sender, EventArgs e)
         {
             textBox1.Text += '0';
         }
         */

    }
}
