using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace CRUD_and_login
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        string key = "DonBoscoAmigo";
        public string Encriptar(string texto)
        {
            byte[] keyArray;
            byte[] Arreglo_a_Cifrar = UTF8Encoding.UTF8.GetBytes(texto);
            MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
            keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
            hashmd5.Clear();
            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            tdes.Key = keyArray;
            tdes.Mode = CipherMode.ECB;
            tdes.Padding = PaddingMode.PKCS7;
            ICryptoTransform cTransform = tdes.CreateEncryptor();

            byte[] ArrayResultado = cTransform.TransformFinalBlock(Arreglo_a_Cifrar, 0,

            Arreglo_a_Cifrar.Length);
            tdes.Clear();
            return Convert.ToBase64String(ArrayResultado, 0, ArrayResultado.Length);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string usuario, encriptada;
            if (textBox1.Text.Trim() != "" && textBox2.Text == textBox3.Text)
            {
                usuario = textBox1.Text;
                encriptada = Encriptar(textBox2.Text);
                estudiantesD.AgregarUsuario(usuario, encriptada);
            }
            else
            {
                MessageBox.Show("datos incorrectos, Por favor verificar");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
                this.Hide();
                login frm = new login(); 
                frm.Show();
            
        }
    }
}
