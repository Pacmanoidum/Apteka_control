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
using System.Text;
using System.Diagnostics.Eventing.Reader;

namespace Apteka_control
{
    public partial class FormRegistration : System.Windows.Forms.Form
    {
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;
            using (SHA512 sha512hash = SHA512.Create())
            {
                byte[] bytes = sha512hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    sb.Append(bytes[i].ToString("x2"));
                }
                string hash_password = sb.ToString();
                if (login == "admin" && hash_password == "360ddc76a3947d1736db653ff698f51e6cade56d089be1459a6c5c6a6fd3143f1ec6fd6b157b4bb3d2d8f49421e1b9b2eaf8b820ea67b6fb67d7f293ef1712a7")
                {
                    Hide();
                    Form1 newform = new Form1();
                    newform.ShowDialog();
                    this.Close();
                }
                else MessageBox.Show("Неверный пароль или логин");
                //360ddc76a3947d1736db653ff698f51e6cade56d089be1459a6c5c6a6fd3143f1ec6fd6b157b4bb3d2d8f49421e1b9b2eaf8b820ea67b6fb67d7f293ef1712a7
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Form2 neform = new Form2();
            neform.ShowDialog();
            this.Close();
        }
    }
}
