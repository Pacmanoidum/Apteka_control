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
using System.Data.SQLite;

namespace Apteka_control
{
    public partial class FormRegistration : System.Windows.Forms.Form
    {
        private string connectionString = "Data Source=AptekaDB.db;Version=3;";
        public FormRegistration()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
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
                        Show();
                        textBox2.Clear();
                        //360ddc76a3947d1736db653ff698f51e6cade56d089be1459a6c5c6a6fd3143f1ec6fd6b157b4bb3d2d8f49421e1b9b2eaf8b820ea67b6fb67d7f293ef1712a7
                    }
                    else
                    {
                        using (SQLiteConnection con = new SQLiteConnection(connectionString))
                        {
                            string old_password;
                            string employee_id;
                            con.Open();
                            string script = $"select password from Employees where login = \"{login}\"";
                            using (SQLiteCommand com = new SQLiteCommand(script, con))
                            {
                                old_password = Convert.ToString(com.ExecuteScalar());
                            }
                            script = $"select employee_id from Employees where login = \"{login}\"";
                            using (SQLiteCommand com = new SQLiteCommand(script, con))
                            {
                                employee_id = Convert.ToString(com.ExecuteScalar());
                            }
                            if (old_password == hash_password)
                            {
                                Hide();
                                Form15 neform = new Form15(employee_id, login);
                                neform.ShowDialog();
                                Show();
                                textBox2.Clear();
                            }
                            else MessageBox.Show("Неверный логин или пароль");
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }
    }
}
