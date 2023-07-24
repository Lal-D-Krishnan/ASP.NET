using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA
{
    public partial class Form1 : Form
    {
        int c = 0;
        double val = 0;
        string operation = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void Operand(object sender, EventArgs e)
        {
            if(textBox1.Text != null)
            {
                if (c == 0)
                {
                    textBox1.Clear();
                    c++;
                }
                Button bt  = (Button)sender;
                textBox1.Text = textBox1.Text + bt.Text;
            }
        }

        private void Optr(object sender, EventArgs e)
        {
            val = double.Parse(textBox1.Text);
            Button bt = (Button)sender;
            operation = bt.Text;
            c = 0;
        }


        private void Eql(object sender, EventArgs e)
        {
            switch(operation)
            {
                case "+" :
                    textBox1.Text = (val+double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (val - double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (val * double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (val / double.Parse(textBox1.Text)).ToString();
                    break;
            }
        }
        private void Clear(object sender, EventArgs e)
        {
            textBox1.Text = null;
        }
    }
}
