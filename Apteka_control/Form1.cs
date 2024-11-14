using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

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


        private void Address_button_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    dataGridView1.DataSource = null;
                    con.Open();
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter("select * from Addresses", con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    label1.Text = "";
                }
            }
            catch (Exception ex)
            {
                label1.Text = "������: " + ex.Message;
            }
        }

        private void Customer_button_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    dataGridView1.DataSource = null;
                    con.Open();
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter("select * from Customers", con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    label1.Text = "";
                }
            }
            catch (Exception ex)
            {
                label1.Text = "������: " + ex.Message;
            }
        }

        private void Empolyee_Button_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    dataGridView1.DataSource = null;
                    con.Open();
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter("select * from Employees", con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    label1.Text = "";
                }
            }
            catch (Exception ex)
            {
                label1.Text = "������: " + ex.Message;
            }
        }

        private void Medicines_button_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    dataGridView1.DataSource = null;
                    con.Open();
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter("select * from Medicines", con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    label1.Text = "";
                }
            }
            catch (Exception ex)
            {
                label1.Text = "������: " + ex.Message;
            }
        }

        private void Providers_button_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    dataGridView1.DataSource = null;
                    con.Open();
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter("select * from Providers", con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    label1.Text = "";
                }
            }
            catch (Exception ex)
            {
                label1.Text = "������: " + ex.Message;
            }
        }

        private void Purchases_button_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    dataGridView1.DataSource = null;
                    con.Open();
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter("select * from Purchases", con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    label1.Text = "";
                }
            }
            catch (Exception ex)
            {
                label1.Text = "������: " + ex.Message;
            }
        }

        private void Checks_button_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    dataGridView1.DataSource = null;
                    con.Open();
                    SQLiteDataAdapter adapter = new SQLiteDataAdapter("select * from Checks", con);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dataGridView1.DataSource = dt;
                    label1.Text = "";
                }
            }
            catch (Exception ex)
            {
                label1.Text = "������: " + ex.Message;
            }
        }

        private void ������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddressADD newform = new FormAddressADD();
            newform.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = string.Empty;
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCustomerADD newform = new FormCustomerADD();
            newform.ShowDialog();
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormEmployeeADD neform = new FormEmployeeADD();
            neform.ShowDialog();
        }

        private void ���������ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormMedicineADD neform = new FormMedicineADD();
            neform.ShowDialog();
        }

        private void ����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormProviderADD neform = new FormProviderADD();
            neform.ShowDialog();
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPurchasesADD neform = new FormPurchasesADD();
            neform.ShowDialog();
        }

        private void ����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCheckADD neform = new FormCheckADD();
            neform.ShowDialog();
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
                    {"address_id", "Addresses" },
                    {"check_id", "Checks" },
                    {"customer_id", "Customers" },
                    {"employee_id", "Employees" },
                    {"medicine_id", "Medicines" },
                    {"Provider_id", "Providers" }
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
                        SQLiteDataAdapter adapter = new SQLiteDataAdapter($"select * from {table_name}", con);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = dt;
                        MessageBox.Show("������ ������� �������.");
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
    }
}