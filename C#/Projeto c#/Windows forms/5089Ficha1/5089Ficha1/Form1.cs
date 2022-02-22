using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5089Ficha1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength != 0  && textBox2.Text != "")
            {
                int n = int.Parse(textBox1.Text);
                int n2 = int.Parse(textBox2.Text);
                label3.Text = (n + n2).ToString();
            }
        }
    }
}
