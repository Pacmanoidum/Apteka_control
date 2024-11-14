using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;

namespace Apteka_control
{
    public partial class FormProviderADD : Form
    {
        private string connectionString = "Data Source=AptekaDB.db;Version=3;";

        public FormProviderADD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    label7.Text = string.Empty;
                    label8.Text = string.Empty;
                    label9.Text = string.Empty;
                    label10.Text = string.Empty;
                    label11.Text = string.Empty;
                    label12.Text = string.Empty;
                    label13.Text = string.Empty;

                    con.Open();
                    string title = textBox1.Text;
                    string phone = textBox2.Text;
                    string address_id = textBox3.Text;
                    string name = textBox4.Text;
                    string surname = textBox5.Text;
                    string third_name = textBox6.Text;

                    bool flag = true;
                    if (title == "") { label7.Text = "Заполните поле"; flag = false; }
                    if (phone == "") { label8.Text = "Заполните поле"; flag = false; }
                    if (address_id == "") { label9.Text = "Заполните поле"; flag = false; }
                    if (name == "") { label10.Text = "Заполните поле"; flag = false; }
                    if (surname == "") { label11.Text = "Заполните поле"; flag = false; }
                    if (third_name == "") { label12.Text = "Заполните поле"; flag = false; }
                    if (!flag) return;

                    string script = $"insert into Providers(provider_id, provider_title, phone_number, address_id, first_name, second_name, middle_name)" +
                        $"values ((select coalesce(max(provider_id), 0) + 1 from Providers), \"{title}\", \"{phone}\", \"{address_id}\", \"{name}\", \"{surname}\", \"{third_name}\")";
                    using (SQLiteCommand command = new SQLiteCommand(script, con))
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Запись успешно добавлена");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                label13.Text = "Ошибка: " + ex.Message;
            }
        }

        private void FormProviderADD_Load(object sender, EventArgs e)
        {
            label7.Text = string.Empty;
            label8.Text = string.Empty;
            label9.Text = string.Empty;
            label10.Text = string.Empty;
            label11.Text = string.Empty;
            label12.Text = string.Empty;
            label13.Text = string.Empty;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Запрет писать что угодно кроме цифр
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Запрет писать что угодно кроме цифр
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }
    }
}
