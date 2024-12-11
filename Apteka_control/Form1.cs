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

namespace Apteka_control
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        private string connectionString = "Data Source=AptekaDB.db;Version=3;";
        private string databaseFilePath = "AptekaDB.db"; // ���� � ����� ���� ������


        public Form1()
        {
            InitializeComponent();
            CheckDatabaseFile();
            CheckAvailableTables();
        }

        private void FillDataGridView()
        {
                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        // ���������, �������� �� ������ ������
                        if (cell.Value == null || string.IsNullOrWhiteSpace(cell.Value.ToString()))
                        {
                            // �������� ������ �������� �� "�������"
                            cell.Value = "<�������>";
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
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter("select customer_id, first_name as ���, second_name as �������, middle_name as ��������, phone_number as �����_��������, " +
                            "passport_series as �����_��������, passport_number as �����_��������, town as �����, street as �����, house as ���, apartment as �������� from Customers", con);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                        label1.Text = "";
                    }
                }
                else
                {
                    using (SQLiteConnection con = new SQLiteConnection(connectionString))
                    {
                        dataGridView1.DataSource = null;
                        con.Open();
                        string script = "select customer_id, first_name as ���, second_name as �������, middle_name as ��������, phone_number as �����_��������, " +
                            "passport_series as �����_��������, passport_number as �����_��������, town as �����, street as �����, house as ���, apartment as �������� from Customers where ";
                        for (int i = 0; i < columnNames.Count; i++)
                        {
                            script += $"{columnNames[i]} LIKE '%{keyword}%'";
                            if (i < columnNames.Count - 1)
                            {
                                script += " OR "; // ��������� OR ����� ���������
                            }
                        }

                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(script, con);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                        label1.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                label1.Text = "������: " + ex.Message;
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
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter("select employee_id, first_name as ���, second_name as �������, middle_name as ��������, position as ���������, " +
                            "passport_series as �����_��������, passport_number as �����_��������, birth_date as ����_��������, hire_date as ����_�����, phone_number as �����_��������, " +
                            "work_schedule as ������_������, salary as ��������, town as �����, street as �����, house as ���, apartment as ��������, login as �����, password as ������ from Employees", con);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                        label1.Text = "";
                    }
                }
                else
                {
                    using (SQLiteConnection con = new SQLiteConnection(connectionString))
                    {
                        dataGridView1.DataSource = null;
                        con.Open();
                        string script = "select employee_id, first_name as ���, second_name as �������, middle_name as ��������, position as ���������, " +
                            "passport_series as �����_��������, passport_number as �����_��������, birth_date as ����_��������, hire_date as ����_�����, phone_number as �����_��������, " +
                            "work_schedule as ������_������, salary as ��������, town as �����, street as �����, house as ���, apartment as ��������, login as �����, password as ������ from Employees where ";
                        for (int i = 0; i < columnNames.Count; i++)
                        {
                            script += $"{columnNames[i]} LIKE '%{keyword}%'";
                            if (i < columnNames.Count - 1)
                            {
                                script += " OR "; // ��������� OR ����� ���������
                            }
                        }

                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(script, con);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                        label1.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                label1.Text = "������: " + ex.Message;
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
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter("select m.medicine_id, p.provider_title as ��������_�������������, m.medicine_title as ��������_������, m.type as ���, m.measure as �������_���������, " +
                            "m.amount_in_one  ����������_�_�����, m.available_amount as ���������_����������, m.price as ����, m.presciption_sales as �����������_������� from Medicines as m left join Providers as p on m.provider_id = p.provider_id", con);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                        label1.Text = "";
                        FillDataGridView(); //��������� ������ ������
                    }
                }
                else
                {
                    columnNames[1] = "provider_title";
                    using (SQLiteConnection con = new SQLiteConnection(connectionString))
                    {
                        dataGridView1.DataSource = null;
                        con.Open();
                        string script = "select m.medicine_id, p.provider_title as ��������_�������������, m.medicine_title as ��������_������, m.type as ���, m.measure as �������_���������, " +
                            "m.amount_in_one  ����������_�_�����, m.available_amount as ���������_����������, m.price as ����, m.presciption_sales as �����������_������� from Medicines as m left join Providers as p on m.provider_id = p.provider_id where ";
                        for (int i = 0; i < columnNames.Count; i++)
                        {
                            script += $"{columnNames[i]} LIKE '%{keyword}%'";
                            if (i < columnNames.Count - 1)
                            {
                                script += " OR "; // ��������� OR ����� ���������
                            }
                        }

                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(script, con);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                        label1.Text = "";
                        FillDataGridView(); //��������� ������ ������
                    }
                }
            }
            catch (Exception ex)
            {
                label1.Text = "������: " + ex.Message;
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
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter("select provider_id, provider_title as ��������_�������������, phone_number as �����_��������, first_name as ���, second_name as �������, middle_name as ��������, " +
                            "town as �����, street as �����, house as ���, apartment as �������� from Providers", con);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                        label1.Text = "";
                    }
                }
                else
                {
                    using (SQLiteConnection con = new SQLiteConnection(connectionString))
                    {
                        dataGridView1.DataSource = null;
                        con.Open();
                        string script = "select provider_id, provider_title as ��������_�������������, phone_number as �����_��������, first_name as ���, second_name as �������, middle_name as ��������, " +
                            "town as �����, street as �����, house as ���, apartment as �������� from Providers where ";
                        for (int i = 0; i < columnNames.Count; i++)
                        {
                            script += $"{columnNames[i]} LIKE '%{keyword}%'";
                            if (i < columnNames.Count - 1)
                            {
                                script += " OR "; // ��������� OR ����� ���������
                            }
                        }

                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(script, con);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                        label1.Text = "";
                    }
                }
            }
            catch (Exception ex)
            {
                label1.Text = "������: " + ex.Message;
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
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter("SELECT c.check_id, c.customer_name as ����������, " +
                            "c.employee_name as ��������, c.sale_date as ����, c.sale_time as �����, sum as ����� " +
                            "FROM  checks c", con);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                        label1.Text = "";
                        FillDataGridView(); //��������� ������ ������
                    }
                }
                else
                {
                    columnNames[1] = "����������";
                    columnNames[2] = "��������";
                    using (SQLiteConnection con = new SQLiteConnection(connectionString))
                    {
                        dataGridView1.DataSource = null;
                        con.Open();
                        string script = "SELECT c.check_id, c.customer_name as ����������, " +
                            "c.employee_name as ��������, c.sale_date as ����, c.sale_time as �����, sum as ����� " +
                            "FROM  checks c where ";
                        for (int i = 0; i < columnNames.Count; i++)
                        {
                            script += $"{columnNames[i]} LIKE '%{keyword}%'";
                            if (i < columnNames.Count - 1)
                            {
                                script += " OR "; // ��������� OR ����� ���������
                            }
                        }

                        SQLiteDataAdapter adapter = new SQLiteDataAdapter(script, con);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = dt;
                        label1.Text = "";
                        FillDataGridView(); //��������� ������ ������
                    }
                }
            }
            catch (Exception ex)
            {
                label1.Text = "������: " + ex.Message;
            }
        }

        private void CheckAvailableTables()
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    con.Open();
                    SQLiteCommand command = new SQLiteCommand("SELECT name FROM sqlite_master WHERE type='table';", con);
                    SQLiteDataReader reader = command.ExecuteReader();

                    string tables = "������������ �������:\n";
                    while (reader.Read())
                    {
                        tables += reader["name"].ToString() + "\n";
                    }
                    reader.Close();

                    MessageBox.Show(tables, "��������� �������");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("������: " + ex.Message);
            }
        }

        private void CheckDatabaseFile()
        {
            if (File.Exists(databaseFilePath))
            {
                label2.Text = $"���������� � ���� ������: {Path.GetFileName(databaseFilePath)}";
            }
            else
            {
                label2.Text = "������: ���� ���� ������ �� ������.";
            }
        }

        private void Customer_button_Click(object sender, EventArgs e)
        {
            SeeCustomers();
            Explore_check_button.Visible = false;
            change_button.Visible = true;
            delete_button.Visible = true;
        }

        private void Empolyee_Button_Click(object sender, EventArgs e)
        {
            SeeEmployees();
            Explore_check_button.Visible = false;
            change_button.Visible = true;
            delete_button.Visible = true;
        }

        private void Medicines_button_Click(object sender, EventArgs e)
        {
            SeeMedicines();
            Explore_check_button.Visible = false;
            change_button.Visible = true;
            delete_button.Visible = false;
        }

        private void Providers_button_Click(object sender, EventArgs e)
        {
            SeeProviders();
            Explore_check_button.Visible = false;
            change_button.Visible = true;
            delete_button.Visible = true;
        }

        private void Checks_button_Click(object sender, EventArgs e)
        {
            SeeChecks();
            Explore_check_button.Visible = true;
            change_button.Visible = false;
            delete_button.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                string column_name = dataGridView1.Columns[0].HeaderText;
                var id = selectedRow.Cells[0].Value.ToString();
                //���������� ������� ��� ��������� �������� �������
                Dictionary<string, string> dict = new Dictionary<string, string>
                {
                    {"check_id", "Checks" },
                    {"customer_id", "Customers" },
                    {"employee_id", "Employees" },
                    {"medicine_id", "Medicines" },
                    {"provider_id", "Providers" }
                };
                dict.TryGetValue(column_name, out string table_name);

                DialogResult result = MessageBox.Show("�� �������?", "������� ������", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) return;

                try
                {
                    using (SQLiteConnection con = new SQLiteConnection(connectionString))
                    {
                        con.Open();
                        var command = new SQLiteCommand($"DELETE FROM {table_name} WHERE {column_name} = {id}", con);
                        command.ExecuteNonQuery();

                        // ���������� DataGridView
                        if (table_name == "Customers") SeeCustomers();
                        if (table_name == "Employees") SeeEmployees();
                        if (table_name == "Medicines") SeeMedicines();
                        if (table_name == "Providers") SeeProviders();
                        if (table_name == "Checks") SeeChecks();

                        MessageBox.Show("������ ������� �������");
                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    label1.Text = "������: " + ex.Message;
                }
            }
            else
            {
                MessageBox.Show("�������� ������ ��� ��������.");
            }
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null) return;

            string keyword = textBox1.Text;
            string column_name = dataGridView1.Columns[0].HeaderText;
            //���������� ������� ��� ��������� �������� �������
            Dictionary<string, string> dict = new Dictionary<string, string>
                {
                    {"check_id", "Checks" },
                    {"customer_id", "Customers" },
                    {"employee_id", "Employees" },
                    {"medicine_id", "Medicines" },
                    {"provider_id", "Providers" }
                };
            dict.TryGetValue(column_name, out string table_name);

            //�������� ����� ���� ��������
            List<string> columnNames = [];
            using (SQLiteConnection con = new SQLiteConnection(connectionString))
            {
                con.Open();

                // �������� ���������� � ��������
                using (SQLiteCommand command = new SQLiteCommand($"PRAGMA table_info({table_name});", con))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // ��� ������� ��������� � ������ ����
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

        private void change_button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.DataSource == null) return;

            string column_name = dataGridView1.Columns[0].HeaderText;
            //���������� ������� ��� ��������� �������� �������
            Dictionary<string, string> Formdict = new Dictionary<string, string>
                {
                    {"check_id", "CheckADD" },
                    {"customer_id", "CustomerADD" },
                    {"employee_id", "EmployeeADD" },
                    {"medicine_id", "MedicineADD" },
                    {"provider_id", "ProviderADD" }
                };
            Formdict.TryGetValue(column_name, out string form_name);

            if (form_name == "CustomerADD")
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    con.Open();
                    var selectedRow = dataGridView1.SelectedRows[0];
                    string id = selectedRow.Cells[0].Value.ToString();
                    string _first_name = selectedRow.Cells[1].Value.ToString();
                    string _second_name = selectedRow.Cells[2].Value.ToString();
                    string _middle_name = selectedRow.Cells[3].Value.ToString();
                    string _phone_number = selectedRow.Cells[4].Value.ToString();
                    string _pas_ser = selectedRow.Cells[5].Value.ToString();
                    string _pas_num = selectedRow.Cells[6].Value.ToString();
                    string _town = selectedRow.Cells[7].Value.ToString();
                    string _street = selectedRow.Cells[8].Value.ToString();
                    string _house = selectedRow.Cells[9].Value.ToString();
                    string _apartment = selectedRow.Cells[10].Value.ToString();
                    FormCustomerADD newform = new FormCustomerADD(id, _first_name, _second_name, _middle_name, _phone_number, _pas_ser,
                        _pas_num, _town, _street, _house, _apartment);
                    newform.ShowDialog();

                    SeeCustomers();
                }
            }

            if (form_name == "EmployeeADD")
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                string _id = selectedRow.Cells[0].Value.ToString();
                string _first_name = selectedRow.Cells[1].Value.ToString();
                string _second_name = selectedRow.Cells[2].Value.ToString();
                string _middle_name = selectedRow.Cells[3].Value.ToString();
                string _position = selectedRow.Cells[4].Value.ToString();
                string _pas_ser = selectedRow.Cells[5].Value.ToString();
                string _pas_num = selectedRow.Cells[6].Value.ToString();
                string _birth_date = selectedRow.Cells[7].Value.ToString();
                string _hire_date = selectedRow.Cells[8].Value.ToString();
                string _phone_number = selectedRow.Cells[9].Value.ToString();
                string _work_schedule = selectedRow.Cells[10].Value.ToString();
                string _salary = selectedRow.Cells[11].Value.ToString();
                string _town = selectedRow.Cells[12].Value.ToString();
                string _street = selectedRow.Cells[13].Value.ToString();
                string _house = selectedRow.Cells[14].Value.ToString();
                string _apartment = selectedRow.Cells[15].Value.ToString();
                string _login = selectedRow.Cells[16].Value.ToString();

                FormEmployeeADD newform = new FormEmployeeADD(_id, _first_name, _second_name, _middle_name, _position, _pas_ser,
                    _pas_num, _birth_date, _hire_date, _phone_number, _work_schedule, _salary, _town, _street, _house, _apartment, _login);
                newform.ShowDialog();

                SeeEmployees();
            }

            if (form_name == "MedicineADD")
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                string _id = selectedRow.Cells[0].Value.ToString();
                string _provider_title = selectedRow.Cells[1].Value.ToString();
                string _provider_id = null;
                try
                {
                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();
                        string script = $"SELECT provider_id FROM Providers WHERE provider_title = \"{_provider_title}\"";
                        using (SQLiteCommand command = new SQLiteCommand(script, connection))
                        {
                            // ��������� ������
                            object result = command.ExecuteScalar();
                            _provider_id = result.ToString();
                        }
                    }
                }
                catch (Exception ex)
                {
                    label1.Text = "������: " + ex.Message;
                }
                if (_provider_id == null) { _provider_id = ""; }

                string _title = selectedRow.Cells[2].Value.ToString();
                string _type = selectedRow.Cells[3].Value.ToString();
                string _measure = selectedRow.Cells[4].Value.ToString();
                string _amountone = selectedRow.Cells[5].Value.ToString();
                string _avamount = selectedRow.Cells[6].Value.ToString();
                string _price = selectedRow.Cells[7].Value.ToString();
                string _presciption_sale = selectedRow.Cells[8].Value.ToString();

                FormMedicineADD newform = new FormMedicineADD(_id, _provider_id, _title, _type,
                    _measure, _amountone, _avamount, _price, _presciption_sale);
                newform.ShowDialog();

                SeeMedicines();
            }

            if (form_name == "ProviderADD")
            {
                var selectedRow = dataGridView1.SelectedRows[0];
                string _id = selectedRow.Cells[0].Value.ToString();
                string _title = selectedRow.Cells[1].Value.ToString();
                string _phone_number = selectedRow.Cells[2].Value.ToString();
                string _name = selectedRow.Cells[3].Value.ToString();
                string _surname = selectedRow.Cells[4].Value.ToString();
                string _middle_name = selectedRow.Cells[5].Value.ToString();
                string _town = selectedRow.Cells[6].Value.ToString();
                string _street = selectedRow.Cells[7].Value.ToString();
                string _house = selectedRow.Cells[8].Value.ToString();
                string _apartment = selectedRow.Cells[9].Value.ToString();

                FormProviderADD newform = new FormProviderADD(_id, _title, _phone_number,
                    _name, _surname, _middle_name, _town, _street, _house, _apartment);
                newform.ShowDialog();

                SeeProviders();
            }
        }

        private void ����������toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormCustomerADD newform = new FormCustomerADD();
            newform.ShowDialog();
            SeeCustomers();
            Explore_check_button.Visible = false;
            change_button.Visible = true;
            delete_button.Visible = true;
        }

        private void ����������ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormEmployeeADD neform = new FormEmployeeADD();
            neform.ShowDialog();
            SeeEmployees();
            Explore_check_button.Visible = false;
            change_button.Visible = true;
            delete_button.Visible = true;
        }

        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMedicineADD neform = new FormMedicineADD();
            neform.ShowDialog();
            SeeMedicines();
            Explore_check_button.Visible = false;
            change_button.Visible = true;
            delete_button.Visible = true;
        }

        private void ����������ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormProviderADD neform = new FormProviderADD();
            neform.ShowDialog();
            SeeProviders();
            Explore_check_button.Visible = false;
            change_button.Visible = true;
            delete_button.Visible = true;
        }

        private void Explore_check_button_Click(object sender, EventArgs e)
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

        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {

        }
    }
}