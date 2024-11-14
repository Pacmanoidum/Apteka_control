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
    public partial class FormPurchasesADD : Form
    {
        private string connectionString = "Data Source=AptekaDB.db;Version=3;";
        public FormPurchasesADD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    label4.Text = string.Empty;
                    label5.Text = string.Empty;
                    label6.Text = string.Empty;
                    label7.Text = string.Empty;

                    con.Open();
                    string chek = textBox1.Text;
                    string tovar = textBox2.Text;
                    string amount = textBox3.Text;

                    bool flag = true;
                    if (chek == "") { label4.Text = "Заполните поле"; flag = false; }
                    if (tovar == "") { label5.Text = "Заполните поле"; flag = false; }
                    if (amount == "") { label6.Text = "Заполните поле"; flag = false; }
                    if (!flag) return;

                    string script = $"insert into Purchases(check_id, medicine_id, amount)" +
                        $"values (\"{chek}\", \"{tovar}\", \"{amount}\")";
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
                label7.Text = "Ошибка: " + ex.Message;
            }
        }

        private void FormPurchasesADD_Load(object sender, EventArgs e)
        {
            label4.Text = string.Empty;
            label5.Text = string.Empty;
            label6.Text = string.Empty;
            label7.Text = string.Empty;
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
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }
    }
}
