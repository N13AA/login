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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

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
        private void button1_Click(object sender, EventArgs e)
        {
            double Grade1 = Convert.ToDouble(textBox1.Text);
            double Grade2 = Convert.ToDouble(textBox2.Text);
            double Grade3 = Convert.ToDouble(textBox3.Text);
            double FinalGrade = Convert.ToDouble(Grade3 + Grade2 + Grade1);
            double FinalGrade2 = Convert.ToDouble(FinalGrade / 3);
            double FinalGrade3 = Convert.ToDouble(FinalGrade2 * 2);
            if (FinalGrade3 <= 9 && FinalGrade3 >= 0)
            {
                label5.Text = Convert.ToString("su nota es "+FinalGrade3+" es insuficiente.");
                label5.Visible = true;
            }
            else if (FinalGrade3 >= 10  && FinalGrade3 <= 12)
            {
                label5.Text = Convert.ToString("su nota es " + FinalGrade3 + " es regular.");
                label5.Visible = true;
            }
            else if (FinalGrade3 >= 13  && FinalGrade3 <= 15)
            {
                label5.Text = Convert.ToString("su nota es " + FinalGrade3 + " es buena.");
                label5.Visible = true;
            }
            else if (FinalGrade3 >= 16  && FinalGrade3 <= 18)
            {
                label5.Text = Convert.ToString("su nota es " + FinalGrade3 + " es muy buena.");
                label5.Visible = true;
            }
            else if (FinalGrade3 >= 19  && FinalGrade3 <= 20)
            {
                label5.Text = Convert.ToString("su nota es " + FinalGrade3 + " es excelente.");
                label5.Visible = true;
            }
            else
            {
                MessageBox.Show("Datos no validos repitalo."); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 menu = new Form1();
            menu.Show();
        }
    }
}
