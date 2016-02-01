using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool content = true;
        int i = 12345;
        string MyString = "Hello World";
        public int[] array = { 5, 10, 15, 20 };

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Hello World";
            //textBox1.Text = content.ToString();
            textBox2.Text = i.ToString();
            textBox3.Text = MyString;
            foreach(int array in array)
            {
                textBox4.Text +=  array + "-" ;
            }
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                button3.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= "Hello World".Length - 1)
            {
                string q = textBox1.Text;
                textBox1.Text = "Hello World".Substring(0 , q.Length + 1);
            }
            else
            {
                button3.Enabled = false;
            }

        }
    }
}
