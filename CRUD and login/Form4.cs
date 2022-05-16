using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_and_login
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void Form4_Load(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            validaciones.SoloNumeros(e);



        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double bytes = Convert.ToDouble(textBox1.Text);
            double Total = bytes * 8;
            label2.Text = Convert.ToString(Total);

            
            label2.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double bytes = Convert.ToDouble(textBox1.Text);
            double Total = bytes /8000;
            label2.Text = Convert.ToString(Total);
            label2.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double bytes = Convert.ToDouble(textBox1.Text);
            double Total = bytes / 8000000;
            label2.Text = Convert.ToString(Total);
            label2.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double bytes = Convert.ToDouble(textBox1.Text);
            double Total = bytes / 8589934592;
            label2.Text = Convert.ToString(Total);
            label2.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            double bytes = Convert.ToDouble(textBox1.Text);
            double Total = bytes / 8796093022208;
            label2.Text = Convert.ToString(Total);
            label2.Visible = true;
        }
    }
}
