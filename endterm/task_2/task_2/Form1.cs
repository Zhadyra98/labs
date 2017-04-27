using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string k = textBox2.Text;
            if(textBox1.Text=="" || textBox2.Text == "")
            {
                MessageBox.Show("Your password or username is empty");
            }
            if (k.Length < 8)
            {
                MessageBox.Show("You entered password with less than 8 character");
            }
            else if (textBox1.Text=="admin"&& textBox2.Text == "password123!")
            {
                MessageBox.Show("Correct!!!");
            }
        }
    }
}
