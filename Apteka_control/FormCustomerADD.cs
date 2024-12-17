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
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Security.Cryptography;

namespace Apteka_control
{
    public partial class FormCustomerADD : Form
    {
        private string connectionString = "Data Source=AptekaDB.db;Version=3;";
        private string customer_id;
        private string first_name;
        private string second_name;
        private string middle_name;
        private string phone_number;
        private string pas_ser;
        private string pas_num;
        private string town;
        private string street;
        private string house;
        private string apartment;
        public FormCustomerADD(string _customer_id = null, string _first_name = null, string _second_name = null,
            string _middle_name = null, string _phone_number = null, string _pas_ser = null, string _pas_num = null,
            string _town = null, string _street = null, string _house = null, string _apartment = null)
        {
            InitializeComponent();
            textBox1.Text = _first_name;
            textBox2.Text = _second_name;
            textBox3.Text = _middle_name;
            textBox4.Text = _phone_number;
            textBox5.Text = _pas_ser;
            textBox6.Text = _pas_num;
            textBox7.Text = _town;
            textBox8.Text = _street;
            textBox9.Text = _house;
            textBox10.Text = _apartment;
            customer_id = _customer_id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label11.Text = string.Empty;
            label12.Text = string.Empty;
            label13.Text = string.Empty;
            label14.Text = string.Empty;
            label15.Text = string.Empty;
            label16.Text = string.Empty;
            label17.Text = string.Empty;
            label18.Text = string.Empty;
            label19.Text = string.Empty;
            label20.Text = string.Empty;

            first_name = textBox1.Text;
            second_name = textBox2.Text;
            middle_name = textBox3.Text;
            phone_number = textBox4.Text;
            pas_ser = textBox5.Text;
            pas_num = textBox6.Text;
            town = textBox7.Text;
            street = textBox8.Text;
            house = textBox9.Text;
            apartment = textBox10.Text;

            bool flag = true;
            if (first_name == "") { label11.Text = "Заполните поле"; flag = false; }
            if (second_name == "") { label12.Text = "Заполните поле"; flag = false; }
            if (middle_name == "") { label13.Text = "Заполните поле"; flag = false; }
            if (phone_number == "") { label14.Text = "Заполните поле"; flag = false; }
            if (pas_ser == "") { label15.Text = "Заполните поле"; flag = false; }
            if (pas_num == "") { label16.Text = "Заполните поле"; flag = false; }
            if (town == "") { label17.Text = "Заполните поле"; flag = false; }
            if (street == "") { label18.Text = "Заполните поле"; flag = false; }
            if (house == "") { label19.Text = "Заполните поле"; flag = false; }
            if (apartment == "") { label20.Text = "Заполните поле"; flag = false; }
            if (!flag) return;

            if (customer_id == null)
            {
                try
                {
                    using (SQLiteConnection con = new SQLiteConnection(connectionString))
                    {
                        con.Open();
                        string script = $"insert into Customers(first_name, second_name, middle_name, phone_number, passport_series, passport_number, town, street, house, apartment)" +
                        $"values (\"{first_name}\", \"{second_name}\", \"{middle_name}\", \"{phone_number}\", \"{pas_ser}\", \"{pas_num}\", \"{town}\", \"{street}\", \"{house}\", \"{apartment}\")";
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
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    using (SQLiteConnection con = new SQLiteConnection(connectionString))
                    {
                        con.Open();
                        string script;


                        script = $"update Customers set first_name = \"{first_name}\", second_name = \"{second_name}\", middle_name = \"{middle_name}\", phone_number = \"{phone_number}\", " +
                            $"passport_series = \"{pas_ser}\", passport_number = \"{pas_num}\", town = \"{town}\", street = \"{street}\", house = \"{house}\", apartment = \"{apartment}\" where customer_id = \"{customer_id}\"";
                        using (SQLiteCommand command = new SQLiteCommand(script, con))
                        {
                            int rowsAffected = command.ExecuteNonQuery();
                        }
                        MessageBox.Show("Запись успешно обновленна");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

        private void FormCustomerADD_Load(object sender, EventArgs e)
        {
            label11.Text = string.Empty;
            label12.Text = string.Empty;
            label13.Text = string.Empty;
            label14.Text = string.Empty;
            label15.Text = string.Empty;
            label16.Text = string.Empty;
            label17.Text = string.Empty;
            label18.Text = string.Empty;
            label19.Text = string.Empty;
            label20.Text = string.Empty;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Запрет писать что угодно кроме цифр
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
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

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Запрет писать что угодно кроме цифр
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Запрет писать кавычки
            if (e.KeyChar == '"') e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Запрет писать кавычки
            if (e.KeyChar == '"') e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Запрет писать кавычки
            if (e.KeyChar == '"') e.Handled = true;
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Запрет писать кавычки
            if (e.KeyChar == '"') e.Handled = true;
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Запрет писать кавычки
            if (e.KeyChar == '"') e.Handled = true;
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Запрет писать кавычки
            if (e.KeyChar == '"') e.Handled = true;
        }
    }
}
