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
using System.Runtime.CompilerServices;
using EnvDTE;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Xml.Linq;

namespace Apteka_control
{
    public partial class UltimateCheckForm : Form
    {
        private string connectionString = "Data Source=AptekaDB.db;Version=3;";
        private string employee_id;
        private string check_id;
        private string customer_id;
        private string data;
        private string vrema;
        private string employee_name;
        private string medicine_id;
        private string medicine_title;
        private string customer_name;

        public UltimateCheckForm(string _employee_id = null, string _check_id = null, string _customer_id = null, string _data = null, string _vrema = null, string _customer_name = null, string _employee_name = null, string _Sum = null)
        {
            InitializeComponent();
            employee_id = _employee_id;
            check_id = _check_id;
            customer_id = _customer_id;
            data = _data;
            vrema = _vrema;
            customer_name = _customer_name;
            employee_name = _employee_name;
            if (employee_name == null)
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();
                    string script = $"select CONCAT(first_name, ' ', second_name, ' ', middle_name) AS employee_name from Employees where employee_id = {employee_id}";
                    using (SQLiteCommand command = new SQLiteCommand(script, connection))
                    {
                        employee_name = Convert.ToString(command.ExecuteScalar());
                    }
                }
            }

            textBox1.Text = employee_name;
            if (check_id == null)
            {
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    string script = $"select customer_id, CONCAT(first_name, ' ', second_name, ' ', middle_name) AS customer_name from Customers";
                    SQLiteCommand command = new SQLiteCommand(script, connection);

                    try
                    {
                        connection.Open();
                        SQLiteDataReader reader = command.ExecuteReader();

                        comboBox1.Items.Clear();

                        while (reader.Read())
                        {
                            // Добавляем элемент в ComboBox
                            comboBox1.Items.Add(new { Text = reader["customer_name"].ToString(), Value = reader["customer_id"].ToString() });
                        }

                        comboBox1.DisplayMember = "Text";
                        comboBox1.ValueMember = "Value";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Произошла ошибка: " + ex.Message);
                    }
                }
                using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                {
                    string script = $"select medicine_id, medicine_title from Medicines";
                    SQLiteCommand command = new SQLiteCommand(script, connection);

                    try
                    {
                        connection.Open();
                        SQLiteDataReader reader = command.ExecuteReader();

                        comboBox2.Items.Clear();

                        while (reader.Read())
                        {
                            // Добавляем элемент в ComboBox
                            comboBox2.Items.Add(new { Text = reader["medicine_title"].ToString(), Value = reader["medicine_id"].ToString() });
                        }

                        comboBox2.DisplayMember = "Text";
                        comboBox2.ValueMember = "Value";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Произошла ошибка: " + ex.Message);
                    }
                }
                data = DateTime.Now.ToString("dd.MM.yyyy");
                vrema = DateTime.Now.ToString("HH:mm:ss");
                textBox2.Text = data;
                textBox3.Text = vrema;
            }
            else
            {
                comboBox1.Visible = false;
                textBox5.Visible = true;
                textBox5.Text = customer_name;
                textBox2.Text = data;
                textBox3.Text = vrema;
                textBox6.Text = _Sum;
                button1.Visible = false;
                button2.Visible = false;
                button3.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                comboBox2.Visible = false;
                textBox4.Visible = false;
                seePurchases();
            }
        }

        private void FillDataGridView()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    // Проверяем, является ли ячейка пустой
                    if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                    {
                        // Заменяем пустое значение на "удалено"
                        cell.Value = "<удалено>";
                    }
                }
            }
        }

        private void seePurchases()
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    dataGridView1.DataSource = null;
                    con.Open();
                    string script = $"select p.medicine_title as название_товара, p.amount as количество, p.sum as сумма from Purchases as p where p.check_id = \"{check_id}\"";
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter(script, con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.Columns.Clear();
                    dataGridView1.DataSource = dt;
                    FillDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void button_add_tovar(object sender, EventArgs e)
        {
            string amount = textBox4.Text;
            string sum;
            string presciption;
            if (medicine_id == null) { MessageBox.Show("Выберите товар"); return; }
            if (amount == "") { MessageBox.Show("Выберите количество товара"); return; }
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string script = $"SELECT (price * {amount}) as sum from Medicines m where medicine_id = \"{medicine_id}\"";
                using (SQLiteCommand command = new SQLiteCommand(script, connection))
                {
                    object result = command.ExecuteScalar();
                    sum = result.ToString();
                }
                script = $"SELECT presciption_sales from Medicines where medicine_id = \"{medicine_id}\"";
                using (SQLiteCommand command = new SQLiteCommand(script, connection))
                {
                    object result = command.ExecuteScalar();
                    presciption = result.ToString();
                    if (presciption == "да") MessageBox.Show("Проверте наличие рецепта на данный товра у покупателя");
                }
            }

            dataGridView1.Rows.Add(medicine_title, amount, sum);

            double Sum = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Пропускаем пустые строки
                if (row.IsNewRow) continue;

                Sum += Convert.ToDouble(row.Cells[2].Value);
            }
            textBox6.Text = Convert.ToString(Sum);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = (dynamic)comboBox2.SelectedItem;
            medicine_id = Convert.ToString(selectedItem.Value); // Здесь сохраняем значение Id
            medicine_title = Convert.ToString(selectedItem.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = (dynamic)comboBox1.SelectedItem;
            customer_id = Convert.ToString(selectedItem.Value); // Здесь сохраняем значение Id
            customer_name = Convert.ToString(selectedItem.Text);
        }

        private void button_delete_tovar(object sender, EventArgs e)
        {
            // Проверяем, выбрана ли строка
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Удаляем выбранные строки
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    dataGridView1.Rows.RemoveAt(row.Index);
                }

                double Sum = 0;
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    // Пропускаем пустые строки
                    if (row.IsNewRow) continue;

                    Sum += Convert.ToDouble(row.Cells[3].Value);
                }
                textBox6.Text = Convert.ToString(Sum);
            }
            else
            {
                MessageBox.Show("Пожалуйста, выберите строку для удаления.");
            }
        }

        private void Add_check_button(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    con.Open();
                    bool flag = true;
                    if (customer_id == null) { MessageBox.Show("Выберите покупателя"); flag = false; }
                    if (employee_id == null) { MessageBox.Show("Почему-то нет продавца..."); flag = false; }
                    if (dataGridView1.Rows.Count == 0) { MessageBox.Show("Добавте товар в чек"); flag = false; }
                    if (!flag) return;

                    string script = $"insert into Checks(customer_name, employee_name, sale_date, sale_time) " +
                        $"values (\"{customer_name}\", \"{employee_name}\", \"{data}\", \"{vrema}\")";
                    using (SQLiteCommand command = new SQLiteCommand(script, con))
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                    }
                    script = $"select coalesce(max(check_id), 0) from Checks";
                    using (SQLiteCommand com = new SQLiteCommand(script, con))
                    {
                        check_id = Convert.ToString(com.ExecuteScalar());
                    }

                    //Итерировать по всем строкам DataGridView
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        // Пропускаем пустые строки
                        if (row.IsNewRow) continue;
                        script = $"insert into Purchases(check_id, medicine_title, amount, sum) " +
                            $"values (\"{check_id}\", \"{row.Cells[0].Value}\", \"{row.Cells[1].Value}\", \"{row.Cells[2].Value}\")";
                        using (SQLiteCommand com = new SQLiteCommand(script, con))
                        {
                            com.ExecuteNonQuery();
                        }
                    }

                    script = $"update Checks set sum = (select (SUM(sum)) from Purchases where check_id = \"{check_id}\") where check_id = \"{check_id}\"";
                    using (SQLiteCommand command = new SQLiteCommand(script, con))
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                    }

                    //Уменьшаем товар на складе
                    script = $"update Medicines set available_amount = available_amount - (select amount from Purchases where Purchases.medicine_title = Medicines.medicine_title and Purchases.check_id = {check_id})" +
                        $" where medicine_title in (select medicine_title from Purchases where check_id = {check_id})";
                    using (SQLiteCommand command = new SQLiteCommand(script, con))
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                    }
                    MessageBox.Show("Чек оформлен!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                if (ex.Message == "constraint failed\r\nCHECK constraint failed: available_amount >= 0")
                {
                    using (SQLiteConnection con = new SQLiteConnection(connectionString))
                    {
                        con.Open();
                        var command = new SQLiteCommand($"DELETE FROM Purchases WHERE check_id = {check_id}", con);
                        command.ExecuteNonQuery();
                        command = new SQLiteCommand($"DELETE FROM Checks WHERE check_id = {check_id}", con);
                        command.ExecuteNonQuery();
                        con.Close();
                    }
                    MessageBox.Show("Недостаточно товара на складе");
                }
                else MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Запрет писать что угодно кроме цифр
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}
