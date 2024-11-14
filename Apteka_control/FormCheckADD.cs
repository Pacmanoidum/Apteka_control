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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.SQLite;

namespace Apteka_control
{
    public partial class FormCheckADD : Form
    {
        private string connectionString = "Data Source=AptekaDB.db;Version=3;";
        public FormCheckADD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    label5.Text = string.Empty;
                    label6.Text = string.Empty;
                    label9.Text = string.Empty;

                    con.Open();
                    string pokupatel = textBox1.Text;
                    string prodavec = textBox2.Text;
                    string data = DateTime.Now.ToString("dd.MM.yyyy");
                    string vrema = DateTime.Now.ToString("HH:mm:ss");

                    bool flag = true;
                    if (pokupatel == "") { label5.Text = "Заполните поле"; flag = false; }
                    if (prodavec == "") { label6.Text = "Заполните поле"; flag = false; }
                    if (!flag) return;

                    string script = $"insert into Checks(check_id, customer_id, employee_id, sale_date, sale_time)" +
                        $"values ((select coalesce(max(check_id), 0) + 1 from Checks), \"{pokupatel}\", \"{prodavec}\", \"{data}\", \"{vrema}\")";
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

        private void FormCheckADD_Load(object sender, EventArgs e)
        {
            label5.Text = string.Empty;
            label6.Text = string.Empty;
            label9.Text = string.Empty;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Запрет писать что угодно кроме цифр
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Запрет писать что угодно кроме цифр
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Запрет писать что угодно кроме цифр
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != '.') e.Handled = true;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Запрет писать что угодно кроме цифр
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ':') e.Handled = true;
        }
    }
}
