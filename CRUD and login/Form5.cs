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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }
       
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.NumerosDecimales(e);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.NumerosDecimales(e);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            validaciones.NumerosDecimales(e);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mn = new Form1();
            mn.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToDouble(textBox1.Text);
            double num2 = Convert.ToDouble(textBox2.Text);
            double num3 = Convert.ToDouble(textBox3.Text);

            if (num1 > num2 & num2 > num3)
            {
                label5.Text = Convert.ToString("el numero mayor es " + num1 + " el numero menor es " + num3 + " el numero intermedio es " + num2);
                label5.Visible = true;
            }
            else if (num2 > num1 & num1 > num3)
            {
                label5.Text = Convert.ToString("el numero mayor es " + num2 + " el numero menor es " + num3 + " el numero intermedio es " + num1);
                label5.Visible = true;
            }
            else if (num3 > num1 & num1 > num2)
            {
                label5.Text = Convert.ToString("el numero mayor es " + num3 + " el numero menor es " + num2 + " el numero intermedio es " + num1);
                label5.Visible = true;
            }
            else if (num3 > num1 & num2 > num1)
            {
                label5.Text = Convert.ToString("el numero mayor es " + num3 + " el numero menor es " + num1 + " el numero intermedio es " + num2);
                label5.Visible = true;
            }
            else if (num1 > num2 & num3 > num2)
            {
                label5.Text = Convert.ToString("el numero mayor es " + num1 + " el numero menor es " + num2 + " el numero intermedio es " + num3);
                label5.Visible = true;
            }
            else if (num2 > num1 & num1 > num3)
            {
                label5.Text = Convert.ToString("el numero mayor es " + num2 + " el numero menor es " + num3 + " el numero intermedio es " + num1);
                label5.Visible = true;
            }
        }
    }
}
