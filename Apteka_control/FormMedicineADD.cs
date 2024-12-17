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
using Microsoft.VisualStudio.CommandBars;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Apteka_control
{
    public partial class FormMedicineADD : Form
    {
        private string connectionString = "Data Source=AptekaDB.db;Version=3;";
        private string id;
        private string provider_id;
        private string title;
        private string type;
        private string measure;
        private string amInOne;
        private string amAvilable;
        private string price;
        private string presciption_sale;

        public FormMedicineADD(string _id = null, string _provider_id = null, string _title = null, string _type = null, string _measure = null,
            string _amountone = null, string _avamount = null, string _price = null, string _presciption_sale = null)
        {
            InitializeComponent();

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                string script = $"select provider_id, provider_title from Providers";
                SQLiteCommand command = new SQLiteCommand(script, connection);

                try
                {
                    connection.Open();
                    SQLiteDataReader reader = command.ExecuteReader();

                    comboBox2.Items.Clear();

                    while (reader.Read())
                    {
                        // Добавляем элемент в ComboBox
                        comboBox2.Items.Add(new { Text = reader["provider_title"].ToString(), Value = reader["provider_id"].ToString() });
                    }

                    comboBox2.DisplayMember = "Text";
                    comboBox2.ValueMember = "Value";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка: " + ex.Message);
                }
            }

            id = _id;
            provider_id = _provider_id;
            comboBox2.SelectedItem = comboBox2.Items.Cast<dynamic>().FirstOrDefault(item => (item.Value == provider_id));

            textBox2.Text = _title;
            textBox3.Text = _type;
            textBox4.Text = _measure;
            textBox5.Text = _amountone;
            textBox6.Text = _avamount;
            textBox7.Text = _price;
            comboBox1.Text = _presciption_sale;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label9.Text = string.Empty;
            label10.Text = string.Empty;
            label11.Text = string.Empty;
            label12.Text = string.Empty;
            label13.Text = string.Empty;
            label14.Text = string.Empty;
            label15.Text = string.Empty;
            label16.Text = string.Empty;

            title = textBox2.Text;
            type = textBox3.Text;
            measure = textBox4.Text;
            amInOne = textBox5.Text;
            amAvilable = textBox6.Text;
            price = textBox7.Text;
            presciption_sale = comboBox1.Text;

            if (id == null)
            {
                try
                {
                    using (SQLiteConnection con = new SQLiteConnection(connectionString))
                    {
                        con.Open();
                        bool flag = true;
                        if (provider_id == null) { label9.Text = "Заполните поле"; flag = false; }
                        if (title == "") { label10.Text = "Заполните поле"; flag = false; }
                        if (type == "") { label11.Text = "Заполните поле"; flag = false; }
                        if (measure == "") { label12.Text = "Заполните поле"; flag = false; }
                        if (amInOne == "") { label13.Text = "Заполните поле"; flag = false; }
                        if (amAvilable == "") { label14.Text = "Заполните поле"; flag = false; }
                        if (price == "") { label15.Text = "Заполните поле"; flag = false; }
                        if (presciption_sale == "") { label16.Text = "Заполните поле"; flag = false; }
                        if (!flag) return;

                        string script = $"insert into Medicines(provider_id, medicine_title, type, measure, amount_in_one, available_amount, price, presciption_sales)" +
                            $"values (\"{provider_id}\", \"{title}\", \"{type}\", \"{measure}\", \"{amInOne}\", \"{amAvilable}\", \"{price}\", \"{presciption_sale}\")";
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
                        bool flag = true;
                        if (provider_id == "") { label9.Text = "Заполните поле"; return; }
                        string script = $"select count(*) from Providers where provider_id = {provider_id}";
                        using (SQLiteCommand command = new SQLiteCommand(script, con))
                        {
                            int count = Convert.ToInt32(command.ExecuteScalar());
                            if (count == 0) { label9.Text = "В бд нет данного поставщика"; flag = false; }
                        }
                        if (title == "") { label10.Text = "Заполните поле"; flag = false; }
                        if (type == "") { label11.Text = "Заполните поле"; flag = false; }
                        if (measure == "") { label12.Text = "Заполните поле"; flag = false; }
                        if (amInOne == "") { label13.Text = "Заполните поле"; flag = false; }
                        if (amAvilable == "") { label14.Text = "Заполните поле"; flag = false; }
                        if (price == "") { label15.Text = "Заполните поле"; flag = false; }
                        if (presciption_sale == "") { label16.Text = "Заполните поле"; flag = false; }
                        if (!flag) return;

                        script = $"update Medicines set provider_id = \"{provider_id}\", medicine_title = \"{title}\", type = \"{type}\", measure = \"{measure}\", " +
                            $"amount_in_one = \"{amInOne}\", available_amount = \"{amAvilable}\", price = \"{price}\", presciption_sales = \"{presciption_sale}\" where medicine_id = \"{id}\"";
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

        private void FormMedicineADD_Load(object sender, EventArgs e)
        {
            label9.Text = string.Empty;
            label10.Text = string.Empty;
            label11.Text = string.Empty;
            label12.Text = string.Empty;
            label13.Text = string.Empty;
            label14.Text = string.Empty;
            label15.Text = string.Empty;
            label16.Text = string.Empty;
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',') e.Handled = true;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedItem != null)
            {
                // Получаем значение (Id) выбранного элемента
                var selectedItem = (dynamic)comboBox2.SelectedItem;
                provider_id = Convert.ToString(selectedItem.Value); // Здесь сохраняем значение Id
            }
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

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Запрет писать кавычки
            if (e.KeyChar == '"') e.Handled = true;
        }
    }
}
