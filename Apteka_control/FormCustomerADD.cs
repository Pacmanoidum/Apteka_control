using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using Microsoft.VisualStudio.Shell.Interop;

namespace Apteka_control
{
    public partial class FormCustomerADD : Form
    {
        private string connectionString = "Data Source=AptekaDB.db;Version=3;";
        public FormCustomerADD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    label11.Text = string.Empty;
                    label12.Text = string.Empty;
                    label13.Text = string.Empty;
                    label14.Text = string.Empty;
                    label15.Text = string.Empty;
                    label16.Text = string.Empty;
                    label17.Text = string.Empty;

                    con.Open();
                    string first_name = textBox2.Text;
                    string second_name = textBox3.Text;
                    string middle_name = textBox4.Text;
                    string phone_number = textBox5.Text;
                    string pas_ser = textBox6.Text;
                    string pas_num = textBox7.Text;
                    string address_id = textBox8.Text;

                    bool flag = true;
                    if (first_name == "") { label11.Text = "Заполните поле"; flag = false; }
                    if (second_name == "") { label12.Text = "Заполните поле"; flag = false; }
                    if (middle_name == "") { label13.Text = "Заполните поле"; flag = false; }
                    if (phone_number == "") { label14.Text = "Заполните поле"; flag = false; }
                    if (pas_ser == "") { label15.Text = "Заполните поле"; flag = false; }
                    if (pas_num == "") { label16.Text = "Заполните поле"; flag = false; }
                    if (address_id == "") { label17.Text = "Заполните поле"; flag = false; }
                    if (!flag) return;

                    string script = $"insert into Customers(customer_id, first_name, second_name, middle_name, phone_number, passport_series, passport_number, address_id)" +
                        $"values ((select coalesce(max(customer_id), 0) + 1 from Customers), \"{first_name}\", \"{second_name}\", \"{middle_name}\", \"{phone_number}\", \"{pas_ser}\", \"{pas_num}\", \"{address_id}\")";
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
                label9.Text = "Ошибка: " + ex.Message;
            }
        }

        private void FormCustomerADD_Load(object sender, EventArgs e)
        {
            label9.Text = string.Empty;
            label11.Text = string.Empty;
            label12.Text = string.Empty;
            label13.Text = string.Empty;
            label14.Text = string.Empty;
            label15.Text = string.Empty;
            label16.Text = string.Empty;
            label17.Text = string.Empty;
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Запрет писать что угодно кроме цифр
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Запрет писать что угодно кроме цифр
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Запрет писать что угодно кроме цифр
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Запрет писать что угодно кроме цифр
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }
    }
}
