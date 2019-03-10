using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Form2 secondForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            secondForm = new Form2(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            secondForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            secondForm.passname = textBox1.Text;
            secondForm.Show();
        }
    }
}
