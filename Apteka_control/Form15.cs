using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.VisualBasic.Devices;
using System.Security.Cryptography;
using System.Xml.Linq;
using System.Drawing;
using static System.ComponentModel.Design.ObjectSelectorEditor;
using System.Text;
using Microsoft.VisualStudio.TextManager.Interop;

namespace Apteka_control
{
    public partial class Form15 : System.Windows.Forms.Form
    {
        private string connectionString = "Data Source=AptekaDB.db;Version=3;";
        private string employee_id;
        private string login;
        private string column_id;


        public Form15(string _employee_id, string _login)
        {
            InitializeComponent();
            label1.Text = "Выполнен вход как: " + _login;
            employee_id = _employee_id;
            login = _login;
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

        private void SeeCustomers(string keyword = null, List<string> columnNames = null)
        {
            try
            {
                if (keyword == null)
                {
                    using (SQLiteConnection con = new SQLiteConnection(connectionString))
                    {
                        dataGridView1.DataSource = null;
                        con.Open();
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter("select first_name as имя, second_name as фамилия, middle_name as отчество, phone_number as номер_телефона, " +
                            "passport_series as серия_паспорта, passport_number as номер_паспорта, town as город, street as улица, house as дом, apartment as квартира from Customers", con);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
                else
                {
                    using (SQLiteConnection con = new SQLiteConnection(connectionString))
                    {
                        dataGridView1.DataSource = null;
                        con.Open();
                        string script = "select first_name as имя, second_name as фамилия, middle_name as отчество, phone_number as номер_телефона, " +
                            "passport_series as серия_паспорта, passport_number as номер_паспорта, town as город, street as улица, house as дом, apartment as квартира from Customers where ";
                        for (int i = 0; i < columnNames.Count; i++)
                        {
                            script += $"{columnNames[i]} LIKE '%{keyword}%'";
                            if (i < columnNames.Count - 1)
                            {
                                script += " OR "; // Добавляем OR между условиями
                            }
                        }

                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(script, con);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void SeeEmployees(string keyword = null, List<string> columnNames = null)
        {
            try
            {
                if (keyword == null)
                {
                    using (SQLiteConnection con = new SQLiteConnection(connectionString))
                    {
                        dataGridView1.DataSource = null;
                        con.Open();
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter("select first_name as имя, second_name as фамилия, middle_name as отчество, position as должность, " +
                            "passport_series as серия_паспорта, passport_number as номер_паспорта, birth_date as день_рождения, hire_date as дата_найма, phone_number as номер_телефона, " +
                            "work_schedule as график_работы, salary as зарплата, town as город, street as улица, house as дом, apartment as квартира from Employees", con);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
                else
                {
                    using (SQLiteConnection con = new SQLiteConnection(connectionString))
                    {
                        dataGridView1.DataSource = null;
                        con.Open();
                        string script = "select first_name as имя, second_name as фамилия, middle_name as отчество, position as должность, " +
                            "passport_series as серия_паспорта, passport_number as номер_паспорта, birth_date as день_рождения, hire_date as дата_найма, phone_number as номер_телефона, " +
                            "work_schedule as график_работы, salary as зарплата, town as город, street as улица, house as дом, apartment as квартира from Employees where ";
                        for (int i = 0; i < columnNames.Count; i++)
                        {
                            script += $"{columnNames[i]} LIKE '%{keyword}%'";
                            if (i < columnNames.Count - 1)
                            {
                                script += " OR "; // Добавляем OR между условиями
                            }
                        }

                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(script, con);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void SeeMedicines(string keyword = null, List<string> columnNames = null)
        {
            try
            {
                if (keyword == null)
                {
                    using (SQLiteConnection con = new SQLiteConnection(connectionString))
                    {
                        dataGridView1.DataSource = null;
                        con.Open();
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter("select p.provider_title as название_производителя, m.medicine_title as название_товара, m.type as тип, m.measure as еденица_измерения, " +
                            "m.amount_in_one  количество_в_одном, m.available_amount as доступное_количество, m.price as цена, m.presciption_sales as требуемость_рецепта from Medicines as m left join Providers as p on m.provider_id = p.provider_id", con);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                        FillDataGridView(); //Заполняем пустые клетки
                    }
                }
                else
                {
                    columnNames[1] = "provider_title";
                    using (SQLiteConnection con = new SQLiteConnection(connectionString))
                    {
                        dataGridView1.DataSource = null;
                        con.Open();
                        string script = "select p.provider_title as название_производителя, m.medicine_title as название_товара, m.type as тип, m.measure as еденица_измерения, " +
                            "m.amount_in_one  количество_в_одном, m.available_amount as доступное_количество, m.price as цена, m.presciption_sales as требуемость_рецепта from Medicines as m left join Providers as p on m.provider_id = p.provider_id where ";
                        for (int i = 0; i < columnNames.Count; i++)
                        {
                            script += $"{columnNames[i]} LIKE '%{keyword}%'";
                            if (i < columnNames.Count - 1)
                            {
                                script += " OR "; // Добавляем OR между условиями
                            }
                        }

                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(script, con);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                        FillDataGridView(); //Заполняем пустые клетки 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void SeeProviders(string keyword = null, List<string> columnNames = null)
        {
            try
            {
                if (keyword == null)
                {
                    using (SQLiteConnection con = new SQLiteConnection(connectionString))
                    {
                        dataGridView1.DataSource = null;
                        con.Open();
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter("select provider_title as название_производителя, phone_number as номер_телефона, first_name as имя, second_name as фамилия, middle_name as отчество, " +
                            "town as город, street as улица, house as дом, apartment as квартира from Providers", con);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
                else
                {
                    using (SQLiteConnection con = new SQLiteConnection(connectionString))
                    {
                        dataGridView1.DataSource = null;
                        con.Open();
                        string script = "select provider_title as название_производителя, phone_number as номер_телефона, first_name as имя, second_name as фамилия, middle_name as отчество, " +
                            "town as город, street as улица, house as дом, apartment as квартира from Providers where ";
                        for (int i = 0; i < columnNames.Count; i++)
                        {
                            script += $"{columnNames[i]} LIKE '%{keyword}%'";
                            if (i < columnNames.Count - 1)
                            {
                                script += " OR "; // Добавляем OR между условиями
                            }
                        }

                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(script, con);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void SeeChecks(string keyword = null, List<string> columnNames = null)
        {
            try
            {
                if (keyword == null)
                {
                    using (SQLiteConnection con = new SQLiteConnection(connectionString))
                    {
                        dataGridView1.DataSource = null;
                        con.Open();
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT c.check_id, c.customer_name as покупатель, " +
                            "c.employee_name as продавец, c.sale_date as дата, c.sale_time as время, sum as сумма " +
                            "FROM  checks c", con);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                        FillDataGridView(); //Заполняем пустые клетки
                    }
                }
                else
                {
                    columnNames[1] = "покупатель";
                    columnNames[2] = "продавец";
                    using (SQLiteConnection con = new SQLiteConnection(connectionString))
                    {
                        dataGridView1.DataSource = null;
                        con.Open();
                        string script = "SELECT c.check_id, c.customer_name as покупатель, " +
                            "c.employee_name as продавец, c.sale_date as дата, c.sale_time as время, sum as сумма " +
                            "FROM  checks c where ";
                        for (int i = 0; i < columnNames.Count; i++)
                        {
                            script += $"{columnNames[i]} LIKE '%{keyword}%'";
                            if (i < columnNames.Count - 1)
                            {
                                script += " OR "; // Добавляем OR между условиями
                            }
                        }

                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(script, con);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                        FillDataGridView(); //Заполняем пустые клетки
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private void Customer_button_Click(object sender, EventArgs e)
        {
            SeeCustomers();
            explore_check_button.Visible = false;
            column_id = "customer_id";
        }

        private void Empolyee_Button_Click(object sender, EventArgs e)
        {
            SeeEmployees();
            explore_check_button.Visible = false;
            column_id = "employee_id";
        }

        private void Medicines_button_Click(object sender, EventArgs e)
        {
            SeeMedicines();
            explore_check_button.Visible = false;
            column_id = "medicine_id";
        }

        private void Providers_button_Click(object sender, EventArgs e)
        {
            SeeProviders();
            explore_check_button.Visible = false;
            column_id = "provider_id";
        }

        private void Checks_button_Click(object sender, EventArgs e)
        {
            SeeChecks();
            explore_check_button.Visible = true;
            column_id = "check_id";
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null) return;

            string keyword = textBox1.Text;
            //string column_name = dataGridView1.Columns[0].HeaderText;
            //Используем словарь для получения названия таблицы
            Dictionary<string, string> dict = new Dictionary<string, string>
                {
                    {"check_id", "Checks" },
                    {"customer_id", "Customers" },
                    {"employee_id", "Employees" },
                    {"medicine_id", "Medicines" },
                    {"provider_id", "Providers" }
                };
            dict.TryGetValue(column_id, out string table_name);

            //Получаем имена всех столбцов
            List<string> columnNames = [];
            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                con.Open();

                // Получаем информацию о столбцах
                using (SQLiteCommand command = new SQLiteCommand($"PRAGMA table_info({table_name});", con))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Имя столбца находится в первом поле
                            columnNames.Add(reader.GetString(1));
                        }
                    }
                }
            }

            if (table_name == "Customers") SeeCustomers(keyword, columnNames);
            if (table_name == "Employees") SeeEmployees(keyword, columnNames);
            if (table_name == "Medicines") SeeMedicines(keyword, columnNames);
            if (table_name == "Providers") SeeProviders(keyword, columnNames);
            if (table_name == "Checks") SeeChecks(keyword, columnNames);
        }

        private void New_check_button_Click(object sender, EventArgs e)
        {
            UltimateCheckForm newform = new UltimateCheckForm(employee_id);
            newform.ShowDialog();
            SeeChecks();
        }

        private void explore_check_button_Click(object sender, EventArgs e)
        {
            var selectedRow = dataGridView1.SelectedRows[0];
            string check_id = selectedRow.Cells[0].Value.ToString();
            string customer_name = selectedRow.Cells[1].Value.ToString();
            string employee_name = selectedRow.Cells[2].Value.ToString();
            string data = selectedRow.Cells[3].Value.ToString();
            string vrema = selectedRow.Cells[4].Value.ToString();
            string Sum = selectedRow.Cells[5].Value.ToString();
            string customer_id = null;
            string employee_id = null;

            UltimateCheckForm newform = new UltimateCheckForm(employee_id, check_id, customer_id, data, vrema, customer_name, employee_name, Sum);
            newform.ShowDialog();
            SeeChecks();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void new_customer_button_Click(object sender, EventArgs e)
        {
            FormCustomerADD newform = new FormCustomerADD();
            newform.ShowDialog();
            SeeCustomers();
        }

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}