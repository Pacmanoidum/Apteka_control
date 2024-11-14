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

namespace Apteka_control
{
    public partial class FormEmployeeADD : Form
    {
        private string connectionString = "Data Source=AptekaDB.db;Version=3;";

        public FormEmployeeADD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    label1.Text = string.Empty;
                    label12.Text = string.Empty;
                    label13.Text = string.Empty;
                    label14.Text = string.Empty;
                    label15.Text = string.Empty;
                    label16.Text = string.Empty;
                    label17.Text = string.Empty;
                    label18.Text = string.Empty;
                    label19.Text = string.Empty;
                    label20.Text = string.Empty;
                    label21.Text = string.Empty;
                    label24.Text = string.Empty;
                    label25.Text = string.Empty;

                    con.Open();
                    string first_name = textBox2.Text;
                    string second_name = textBox3.Text;
                    string middle_name = textBox4.Text;
                    string position = textBox5.Text;
                    string pas_ser = textBox6.Text;
                    string pas_num = textBox7.Text;
                    string birth_date = textBox8.Text;
                    string hire_date = textBox9.Text;
                    string phone_number = textBox10.Text;
                    string address_id = textBox11.Text;
                    string work_schedule = textBox1.Text;
                    string salary = textBox12.Text;

                    bool flag = true;
                    if (first_name == "") { label1.Text = "Заполните поле"; flag = false; }
                    if (second_name == "") { label12.Text = "Заполните поле"; flag = false; }
                    if (middle_name == "") { label13.Text = "Заполните поле"; flag = false; }
                    if (position == "") { label14.Text = "Заполните поле"; flag = false; }
                    if (pas_ser == "") { label15.Text = "Заполните поле"; flag = false; }
                    if (pas_num == "") { label16.Text = "Заполните поле"; flag = false; }
                    if (birth_date == "") { label17.Text = "Заполните поле"; flag = false; }
                    if (hire_date == "") { label18.Text = "Заполните поле"; flag = false; }
                    if (phone_number == "") { label19.Text = "Заполните поле"; flag = false; }
                    if (address_id == "") { label20.Text = "Заполните поле"; flag = false; }
                    if (work_schedule == "") { label24.Text = "Заполните поле"; flag = false; }
                    if (salary == "") { label25.Text = "Заполните поле"; flag = false; }
                    if (!flag) return;

                    string script = $"insert into Employees(employee_id, first_name, second_name, middle_name, position, passport_series, passport_number, birth_date, hire_date, phone_number, address_id, work_schedule, salary)" +
                        $"values ((select coalesce(max(employee_id), 0) + 1 from Employees), \"{first_name}\", \"{second_name}\", \"{middle_name}\", \"{position}\", \"{pas_ser}\", \"{pas_num}\", \"{birth_date}\", \"{hire_date}\", \"{phone_number}\", \"{address_id}\", \"{work_schedule}\", \"{salary}\")";
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
                label21.Text = "Ошибка: " + ex.Message;
            }
        }

        private void FormEmployeeADD_Load(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
            label12.Text = string.Empty;
            label13.Text = string.Empty;
            label14.Text = string.Empty;
            label15.Text = string.Empty;
            label16.Text = string.Empty;
            label17.Text = string.Empty;
            label18.Text = string.Empty;
            label19.Text = string.Empty;
            label20.Text = string.Empty;
            label21.Text = string.Empty;
            label24.Text = string.Empty;
            label25.Text = string.Empty;
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

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Запрет писать что угодно кроме цифр
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void textBox11_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Запрет писать что угодно кроме цифр
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Запрет писать что угодно кроме цифр
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.') e.Handled = true;
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Запрет писать что угодно кроме цифр
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.') e.Handled = true;
        }

        private void textBox12_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Запрет писать что угодно кроме цифр
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',') e.Handled = true;
        }
    }
}
