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
    public partial class FormMedicineADD : Form
    {
        private string connectionString = "Data Source=AptekaDB.db;Version=3;";

        public FormMedicineADD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    label9.Text = string.Empty;
                    label10.Text = string.Empty;
                    label11.Text = string.Empty;
                    label12.Text = string.Empty;
                    label13.Text = string.Empty;
                    label14.Text = string.Empty;
                    label15.Text = string.Empty;
                    label16.Text = string.Empty;
                    label17.Text = string.Empty;

                    con.Open();
                    string provider_id = textBox1.Text;
                    string title = textBox2.Text;
                    string type = textBox3.Text;
                    string measure = textBox4.Text;
                    string amInOne = textBox5.Text;
                    string amAvilable = textBox6.Text;
                    string price = textBox7.Text;
                    string presciption_sale = textBox8.Text;

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
                    if (presciption_sale != "да" && presciption_sale != "нет") { label16.Text = "Введите \"да\" или \"нет\""; flag = false; }
                    if (presciption_sale == "") { label16.Text = "Заполните поле"; flag = false; }
                    if (!flag) return;

                    script = $"insert into Medicines(medicine_id, provider_id, medicine_title, type, measure, amount_in_one, available_amount, price, presciption_sales)" +
                        $"values ((select coalesce(max(medicine_id), 0) + 1 from Medicines), \"{provider_id}\", \"{title}\", \"{type}\", \"{measure}\", \"{amInOne}\", \"{amAvilable}\", \"{price}\", \"{presciption_sale}\")";
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
                label17.Text = "Ошибка: " + ex.Message;
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
            label17.Text = string.Empty;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Запрет писать что угодно кроме цифр
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
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
    }
}
