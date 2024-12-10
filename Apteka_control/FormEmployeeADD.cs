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
using Microsoft.VisualBasic.Devices;
using System.Security.Cryptography;

namespace Apteka_control
{
    public partial class FormEmployeeADD : Form
    {
        private string connectionString = "Data Source=AptekaDB.db;Version=3;";
        private string id;
        private string first_name;
        private string second_name;
        private string middle_name;
        private string position;
        private string pas_ser;
        private string pas_num;
        private string birth_date;
        private string hire_date;
        private string phone_number;
        private string work_schedule;
        private string salary;
        private string town;
        private string street;
        private string house;
        private string apartment;
        private string login;
        private string password;


        public FormEmployeeADD(string _id = null, string _first_name = null, string _second_name = null, string _middle_name = null, string _position = null, string _pas_ser = null,
                    string _pas_num = null, string _birth_date = null, string _hire_date = null, string _phone_number = null, string _work_schedule = null, string _salary = null,
                    string _town = null, string _street = null, string _house = null, string _apartment = null, string _login = null)
        {
            InitializeComponent();
            textBox1.Text = _first_name;
            textBox2.Text = _second_name;
            textBox3.Text = _middle_name;
            textBox4.Text = _position;
            textBox5.Text = _pas_ser;
            textBox6.Text = _pas_num;
            textBox7.Text = _birth_date;
            textBox8.Text = _hire_date;
            textBox9.Text = _phone_number;
            textBox10.Text = _work_schedule;
            textBox11.Text = _salary;
            textBox12.Text = _town;
            textBox13.Text = _street;
            textBox14.Text = _house;
            textBox15.Text = _apartment;
            textBox16.Text = _login;

            id = _id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label16.Text = string.Empty;
            label17.Text = string.Empty;
            label18.Text = string.Empty;
            label19.Text = string.Empty;
            label20.Text = string.Empty;
            label21.Text = string.Empty;
            label22.Text = string.Empty;
            label23.Text = string.Empty;
            label24.Text = string.Empty;
            label25.Text = string.Empty;
            label26.Text = string.Empty;
            label27.Text = string.Empty;
            label28.Text = string.Empty;
            label29.Text = string.Empty;
            label30.Text = string.Empty;
            label32.Text = string.Empty;
            label34.Text = string.Empty;

            first_name = textBox1.Text;
            second_name = textBox2.Text;
            middle_name = textBox3.Text;
            position = textBox4.Text;
            pas_ser = textBox5.Text;
            pas_num = textBox6.Text;
            birth_date = textBox7.Text;
            hire_date = textBox8.Text;
            phone_number = textBox9.Text;
            work_schedule = textBox10.Text;
            salary = textBox11.Text;
            town = textBox12.Text;
            street = textBox13.Text;
            house = textBox14.Text;
            apartment = textBox15.Text;
            login = textBox16.Text;
            password = textBox17.Text;

            bool flag = true;
            if (first_name == "") { label16.Text = "Заполните поле"; flag = false; }
            if (second_name == "") { label17.Text = "Заполните поле"; flag = false; }
            if (middle_name == "") { label18.Text = "Заполните поле"; flag = false; }
            if (position == "") { label19.Text = "Заполните поле"; flag = false; }
            if (pas_ser == "") { label20.Text = "Заполните поле"; flag = false; }
            if (pas_num == "") { label21.Text = "Заполните поле"; flag = false; }
            if (birth_date == "") { label22.Text = "Заполните поле"; flag = false; }
            if (hire_date == "") { label23.Text = "Заполните поле"; flag = false; }
            if (phone_number == "") { label24.Text = "Заполните поле"; flag = false; }
            if (work_schedule == "") { label25.Text = "Заполните поле"; flag = false; }
            if (salary == "") { label26.Text = "Заполните поле"; flag = false; }
            if (town == "") { label27.Text = "Заполните поле"; flag = false; }
            if (street == "") { label28.Text = "Заполните поле"; flag = false; }
            if (house == "") { label29.Text = "Заполните поле"; flag = false; }
            if (apartment == "") { label30.Text = "Заполните поле"; flag = false; }
            if (login == "") { label32.Text = "Заполните поле"; flag = false; }
            if (!flag) return;

            if (id == null)
            {
                if (password == "") { label34.Text = "Заполните поле"; return; }
                string hash_password;
                using (SHA512 sha512hash = SHA512.Create())
                {
                    byte[] bytes = sha512hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                    StringBuilder sb = new StringBuilder();
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        sb.Append(bytes[i].ToString("x2"));
                    }
                    hash_password = sb.ToString();
                }
                    try
                {
                    using (SQLiteConnection con = new SQLiteConnection(connectionString))
                    {
                        con.Open();
                        string script = $"insert into Employees(first_name, second_name, middle_name, position, passport_series, passport_number, birth_date, hire_date, phone_number, work_schedule, salary, town, street, house, apartment, login, password)" +
                            $"values (\"{first_name}\", \"{second_name}\", \"{middle_name}\", \"{position}\", \"{pas_ser}\", \"{pas_num}\", \"{birth_date}\", \"{hire_date}\", \"{phone_number}\", \"{work_schedule}\", \"{salary}\", \"{town}\", \"{street}\", \"{house}\", \"{apartment}\", \"{login}\", \"{hash_password}\")";
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
                    if (password == "")
                    {
                        using (SQLiteConnection con = new SQLiteConnection(connectionString))
                        {
                            con.Open();
                            string script = $"update Employees set first_name = \"{first_name}\", second_name = \"{second_name}\", middle_name = \"{middle_name}\", position = \"{position}\", " +
                                $"passport_series = \"{pas_ser}\", passport_number = \"{pas_num}\", birth_date = \"{birth_date}\", hire_date = \"{hire_date}\", phone_number = \"{phone_number}\", " +
                                $"work_schedule = \"{work_schedule}\", salary = \"{salary}\", town = \"{town}\", street = \"{street}\", house = \"{house}\", apartment = \"{apartment}\", login = \"{login}\" where employee_id = \"{id}\"";
                            using (SQLiteCommand command = new SQLiteCommand(script, con))
                            {
                                int rowsAffected = command.ExecuteNonQuery();
                            }
                            MessageBox.Show("Запись успешно обновленна");
                            this.Close();
                        }
                    }
                    else
                    {
                        using (SQLiteConnection con = new SQLiteConnection(connectionString))
                        {
                            string hash_password;
                            using (SHA512 sha512hash = SHA512.Create())
                            {
                                byte[] bytes = sha512hash.ComputeHash(Encoding.UTF8.GetBytes(password));
                                StringBuilder sb = new StringBuilder();
                                for (int i = 0; i < bytes.Length; i++)
                                {
                                    sb.Append(bytes[i].ToString("x2"));
                                }
                                hash_password = sb.ToString();
                            }
                            con.Open();
                            string script = $"update Employees set first_name = \"{first_name}\", second_name = \"{second_name}\", middle_name = \"{middle_name}\", position = \"{position}\", " +
                                $"passport_series = \"{pas_ser}\", passport_number = \"{pas_num}\", birth_date = \"{birth_date}\", hire_date = \"{hire_date}\", phone_number = \"{phone_number}\", " +
                                $"work_schedule = \"{work_schedule}\", salary = \"{salary}\", town = \"{town}\", street = \"{street}\", house = \"{house}\", apartment = \"{apartment}\", login = \"{login}\", password = \"{hash_password}\" where employee_id = \"{id}\"";
                            using (SQLiteCommand command = new SQLiteCommand(script, con))
                            {
                                int rowsAffected = command.ExecuteNonQuery();
                            }
                            MessageBox.Show("Запись успешно обновленна");
                            this.Close();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка: " + ex.Message);
                }
            }
        }

        private void FormEmployeeADD_Load(object sender, EventArgs e)
        {
            label16.Text = string.Empty;
            label17.Text = string.Empty;
            label18.Text = string.Empty;
            label19.Text = string.Empty;
            label20.Text = string.Empty;
            label21.Text = string.Empty;
            label22.Text = string.Empty;
            label23.Text = string.Empty;
            label24.Text = string.Empty;
            label25.Text = string.Empty;
            label26.Text = string.Empty;
            label27.Text = string.Empty;
            label28.Text = string.Empty;
            label29.Text = string.Empty;
            label30.Text = string.Empty;
            label32.Text = string.Empty;
            label34.Text = string.Empty;
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
            // Запрет писать что угодно кроме цифр и точки
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.') e.Handled = true;
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Запрет писать что угодно кроме цифр и точки
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.') e.Handled = true;
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Запрет писать что угодно кроме цифр
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Запрет писать что угодно кроме цифр и точек
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.') e.Handled = true;
        }

        private void textBox15_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Запрет писать что угодно кроме цифр
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }
    }
}
