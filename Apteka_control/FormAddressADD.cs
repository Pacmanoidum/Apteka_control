using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualStudio.OLE.Interop;

namespace Apteka_control
{
    public partial class FormAddressADD : System.Windows.Forms.Form
    {
        private string connectionString = "Data Source=AptekaDB.db;Version=3;";

        public FormAddressADD()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(connectionString))
                {
                    labelTown.Text = string.Empty;
                    labelHouse.Text = string.Empty;
                    labelStreet.Text = string.Empty;
                    labelApartment.Text = string.Empty;
                    label6.Text = string.Empty;

                    con.Open();
                    string Town = textBox1.Text;
                    string Street = textBox2.Text;
                    string House = textBox3.Text;
                    string Apartment = textBox4.Text;

                    bool flag = true;
                    if (Town == "") { labelTown.Text = "Заполните поле"; flag = false; }
                    if (Street == "") { labelStreet.Text = "Заполните поле"; flag = false; }
                    if (House == "") { labelHouse.Text = "Заполните поле"; flag = false; }
                    if (Apartment == "") { labelApartment.Text = "Заполните поле"; flag = false; }
                    if (!flag) return;

                    string script = $"insert into Addresses(address_id, town, street, house, apartment) values ((select coalesce(max(address_id), 0) + 1 from addresses), \"{Town}\", \"{Street}\", \"{House}\", {Apartment})";
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
                label6.Text = "Ошибка: " + ex.Message;
            }
        }

        private void FormAddressADD_Load(object sender, EventArgs e)
        {
            labelTown.Text = string.Empty;
            labelHouse.Text = string.Empty;
            labelStreet.Text = string.Empty;
            labelApartment.Text = string.Empty;
            label6.Text = string.Empty;
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Запрет писать что угодно кроме цифр
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled = true;
        }
    }
}
