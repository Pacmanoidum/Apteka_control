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
        private string id;
        private string title;
        private string phone;
        private string name;
        private string surname;
        private string third_name;
        private string town;
        private string street;
        private string house;
        private string apartment;

        public FormProviderADD(string _id = null, string _title = null, string _phone = null, string _name = null, string _surname = null, 
            string _third_name = null, string _town = null, string _street = null, string _house = null, string _apartment = null)
        {
            InitializeComponent();
            textBox1.Text = _title;
            textBox2.Text = _phone;
            textBox3.Text = _name;
            textBox4.Text = _surname;
            textBox5.Text = _third_name;
            textBox6.Text = _town;
            textBox7.Text = _street;
            textBox8.Text = _house;
            textBox9.Text = _apartment;

            id = _id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label10.Text = string.Empty;
            label11.Text = string.Empty;
            label12.Text = string.Empty;
            label13.Text = string.Empty;
            label14.Text = string.Empty;
            label15.Text = string.Empty;
            label16.Text = string.Empty;
            label17.Text = string.Empty;
            label18.Text = string.Empty;

            title = textBox1.Text;
            phone = textBox2.Text;
            name = textBox3.Text;
            surname = textBox4.Text;
            third_name = textBox5.Text;
            town = textBox6.Text;
            street = textBox7.Text;
            house = textBox8.Text;
            apartment = textBox9.Text;

            bool flag = true;
            if (title == "") { label10.Text = "Заполните поле"; flag = false; }
            if (phone == "") { label11.Text = "Заполните поле"; flag = false; }
            if (name == "") { label12.Text = "Заполните поле"; flag = false; }
            if (surname == "") { label13.Text = "Заполните поле"; flag = false; }
            if (third_name == "") { label14.Text = "Заполните поле"; flag = false; }
            if (town == "") { label15.Text = "Заполните поле"; flag = false; }
            if (street == "") { label16.Text = "Заполните поле"; flag = false; }
            if (house == "") { label17.Text = "Заполните поле"; flag = false; }
            if (apartment == "") { label18.Text = "Заполните поле"; flag = false; }
            if (!flag) return;

            if (id == null)
            {
                try
                {
                    using (SQLiteConnection con = new SQLiteConnection(connectionString))
                    {
                        con.Open();
                        string script = $"insert into Providers(provider_title, phone_number, first_name, second_name, middle_name, town, street, house, apartment)" +
                            $"values (\"{title}\", \"{phone}\", \"{name}\", \"{surname}\", \"{third_name}\", \"{town}\", \"{street}\", \"{house}\", \"{apartment}\")";
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
                        string script = $"update Providers set provider_title = \"{title}\", phone_number = \"{phone}\", first_name = \"{name}\", second_name = \"{surname}\", " +
                            $"middle_name = \"{third_name}\", town = \"{town}\", street = \"{street}\", house = \"{house}\", apartment = \"{apartment}\" where provider_id = \"{id}\"";
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

        private void FormProviderADD_Load(object sender, EventArgs e)
        {
            label10.Text = string.Empty;
            label11.Text = string.Empty;
            label12.Text = string.Empty;
            label13.Text = string.Empty;
            label14.Text = string.Empty;
            label15.Text = string.Empty;
            label16.Text = string.Empty;
            label17.Text = string.Empty;
            label18.Text = string.Empty;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Запрет писать что угодно кроме цифр
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Запрет писать что угодно кроме цифр
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }
    }
}
