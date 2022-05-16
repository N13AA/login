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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 prom = new Form2();
            prom.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 bits = new Form4();
            bits.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 num = new Form5();
            num.Show();

        }
    }
}
