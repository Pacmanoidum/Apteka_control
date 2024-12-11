namespace Apteka_control
{
    partial class UltimateCheckForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            comboBox1 = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            dataGridView1 = new DataGridView();
            MedicineTitle = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            sum = new DataGridViewTextBoxColumn();
            label5 = new Label();
            comboBox2 = new ComboBox();
            label6 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(88, 12);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(200, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 1;
            label1.Text = "Продавец";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 48);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 2;
            label2.Text = "Покупатель";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(88, 48);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(200, 23);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(294, 20);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 4;
            label3.Text = "Дата";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(294, 56);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 5;
            label4.Text = "Время";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(349, 12);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(117, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(349, 48);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(117, 23);
            textBox3.TabIndex = 7;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MedicineTitle, Amount, sum });
            dataGridView1.Location = new Point(12, 141);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(508, 165);
            dataGridView1.TabIndex = 8;
            dataGridView1.DataError += dataGridView1_DataError;
            // 
            // MedicineTitle
            // 
            MedicineTitle.HeaderText = "medicine_title";
            MedicineTitle.Name = "MedicineTitle";
            MedicineTitle.ReadOnly = true;
            MedicineTitle.Width = 140;
            // 
            // Amount
            // 
            Amount.FillWeight = 200F;
            Amount.HeaderText = "amount";
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            Amount.Width = 140;
            // 
            // sum
            // 
            sum.HeaderText = "sum";
            sum.Name = "sum";
            sum.ReadOnly = true;
            sum.Width = 140;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 101);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 9;
            label5.Text = "товар";
            // 
            // comboBox2
            // 
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(88, 93);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(100, 23);
            comboBox2.TabIndex = 10;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(216, 101);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 11;
            label6.Text = "Количество";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(294, 93);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 12;
            textBox4.KeyPress += textBox4_KeyPress;
            // 
            // button1
            // 
            button1.Location = new Point(422, 93);
            button1.Name = "button1";
            button1.Size = new Size(98, 42);
            button1.TabIndex = 13;
            button1.Text = "Добавить в чек";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button_add_tovar;
            // 
            // button2
            // 
            button2.Location = new Point(12, 312);
            button2.Name = "button2";
            button2.Size = new Size(93, 40);
            button2.TabIndex = 14;
            button2.Text = "Удалить запись";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button_delete_tovar;
            // 
            // button3
            // 
            button3.Location = new Point(116, 312);
            button3.Name = "button3";
            button3.Size = new Size(97, 40);
            button3.TabIndex = 15;
            button3.Text = "Провести и закрыть чек";
            button3.UseVisualStyleBackColor = true;
            button3.Click += Add_check_button;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(88, 48);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(200, 23);
            textBox5.TabIndex = 16;
            textBox5.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(321, 326);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 17;
            label7.Text = "Сумма чека";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(400, 323);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(100, 23);
            textBox6.TabIndex = 18;
            // 
            // UltimateCheckForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(533, 361);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label6);
            Controls.Add(comboBox2);
            Controls.Add(label5);
            Controls.Add(dataGridView1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "UltimateCheckForm";
            Text = "Чек";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox3;
        private DataGridView dataGridView1;
        private Label label5;
        private ComboBox comboBox2;
        private Label label6;
        private TextBox textBox4;
        private Button button1;
        private Button button2;
        private Button button3;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox6;
        private DataGridViewTextBoxColumn MedicineTitle;
        private DataGridViewTextBoxColumn Amount;
        private DataGridViewTextBoxColumn sum;
    }
}