namespace Apteka_control
{
    partial class Form15
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Customer_button = new Button();
            Empolyee_Button = new Button();
            Medicines_button = new Button();
            Providers_button = new Button();
            Checks_button = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            button_search = new Button();
            explore_check_button = new Button();
            New_check_button = new Button();
            exit_button = new Button();
            new_customer_button = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 118);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(776, 231);
            dataGridView1.TabIndex = 2;
            dataGridView1.DataError += dataGridView1_DataError;
            // 
            // Customer_button
            // 
            Customer_button.Location = new Point(12, 40);
            Customer_button.Name = "Customer_button";
            Customer_button.Size = new Size(91, 38);
            Customer_button.TabIndex = 6;
            Customer_button.Text = "Покупатели";
            Customer_button.UseVisualStyleBackColor = true;
            Customer_button.Click += Customer_button_Click;
            // 
            // Empolyee_Button
            // 
            Empolyee_Button.Location = new Point(109, 40);
            Empolyee_Button.Name = "Empolyee_Button";
            Empolyee_Button.Size = new Size(91, 38);
            Empolyee_Button.TabIndex = 7;
            Empolyee_Button.Text = "Сотрудники";
            Empolyee_Button.UseVisualStyleBackColor = true;
            Empolyee_Button.Click += Empolyee_Button_Click;
            // 
            // Medicines_button
            // 
            Medicines_button.Location = new Point(206, 40);
            Medicines_button.Name = "Medicines_button";
            Medicines_button.Size = new Size(91, 38);
            Medicines_button.TabIndex = 8;
            Medicines_button.Text = "Лекарства";
            Medicines_button.UseVisualStyleBackColor = true;
            Medicines_button.Click += Medicines_button_Click;
            // 
            // Providers_button
            // 
            Providers_button.Location = new Point(303, 40);
            Providers_button.Name = "Providers_button";
            Providers_button.Size = new Size(91, 38);
            Providers_button.TabIndex = 9;
            Providers_button.Text = "Поставщики";
            Providers_button.UseVisualStyleBackColor = true;
            Providers_button.Click += Providers_button_Click;
            // 
            // Checks_button
            // 
            Checks_button.Location = new Point(400, 40);
            Checks_button.Name = "Checks_button";
            Checks_button.Size = new Size(91, 38);
            Checks_button.TabIndex = 11;
            Checks_button.Text = "Чеки";
            Checks_button.UseVisualStyleBackColor = true;
            Checks_button.Click += Checks_button_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 13;
            label1.Text = "label1";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(285, 23);
            textBox1.TabIndex = 16;
            // 
            // button_search
            // 
            button_search.Location = new Point(319, 84);
            button_search.Name = "button_search";
            button_search.Size = new Size(93, 23);
            button_search.TabIndex = 17;
            button_search.Text = "Найти";
            button_search.UseVisualStyleBackColor = true;
            button_search.Click += button_search_Click;
            // 
            // explore_check_button
            // 
            explore_check_button.Location = new Point(206, 354);
            explore_check_button.Name = "explore_check_button";
            explore_check_button.Size = new Size(91, 50);
            explore_check_button.TabIndex = 18;
            explore_check_button.Text = "Подробнее";
            explore_check_button.UseVisualStyleBackColor = true;
            explore_check_button.Visible = false;
            explore_check_button.Click += explore_check_button_Click;
            // 
            // New_check_button
            // 
            New_check_button.Location = new Point(12, 355);
            New_check_button.Name = "New_check_button";
            New_check_button.Size = new Size(91, 50);
            New_check_button.TabIndex = 19;
            New_check_button.Text = "Новый чек";
            New_check_button.UseVisualStyleBackColor = true;
            New_check_button.Click += New_check_button_Click;
            // 
            // exit_button
            // 
            exit_button.Location = new Point(692, 355);
            exit_button.Name = "exit_button";
            exit_button.Size = new Size(96, 50);
            exit_button.TabIndex = 20;
            exit_button.Text = "Выйти";
            exit_button.UseVisualStyleBackColor = true;
            exit_button.Click += exit_button_Click;
            // 
            // new_customer_button
            // 
            new_customer_button.Location = new Point(109, 355);
            new_customer_button.Name = "new_customer_button";
            new_customer_button.Size = new Size(91, 48);
            new_customer_button.TabIndex = 21;
            new_customer_button.Text = "Новый покупатель";
            new_customer_button.UseVisualStyleBackColor = true;
            new_customer_button.Click += new_customer_button_Click;
            // 
            // Form15
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 415);
            Controls.Add(new_customer_button);
            Controls.Add(exit_button);
            Controls.Add(New_check_button);
            Controls.Add(explore_check_button);
            Controls.Add(button_search);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(Checks_button);
            Controls.Add(Providers_button);
            Controls.Add(Medicines_button);
            Controls.Add(Empolyee_Button);
            Controls.Add(Customer_button);
            Controls.Add(dataGridView1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form15";
            Text = "Apteka Control";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Button Customer_button;
        private Button Empolyee_Button;
        private Button Medicines_button;
        private Button Providers_button;
        private Button Checks_button;
        private Label label1;
        private TextBox textBox1;
        private Button button_search;
        private Button explore_check_button;
        private Button New_check_button;
        private Button exit_button;
        private Button new_customer_button;
    }
}
