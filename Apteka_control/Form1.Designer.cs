namespace Apteka_control
{
    partial class Form1
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
            label2 = new Label();
            Address_button = new Button();
            Customer_button = new Button();
            Empolyee_Button = new Button();
            Medicines_button = new Button();
            Providers_button = new Button();
            Purchases_button = new Button();
            Checks_button = new Button();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            адресаToolStripMenuItem = new ToolStripMenuItem();
            покупателиToolStripMenuItem = new ToolStripMenuItem();
            сотрудникиToolStripMenuItem = new ToolStripMenuItem();
            лекарстваToolStripMenuItem1 = new ToolStripMenuItem();
            поставщикиToolStripMenuItem = new ToolStripMenuItem();
            покупкиToolStripMenuItem = new ToolStripMenuItem();
            чекиToolStripMenuItem = new ToolStripMenuItem();
            удалитьЗаписьToolStripMenuItem = new ToolStripMenuItem();
            адресаToolStripMenuItem1 = new ToolStripMenuItem();
            покупателиToolStripMenuItem1 = new ToolStripMenuItem();
            сотрудникиToolStripMenuItem1 = new ToolStripMenuItem();
            лекарстваToolStripMenuItem = new ToolStripMenuItem();
            поставщикиToolStripMenuItem1 = new ToolStripMenuItem();
            покупкиToolStripMenuItem1 = new ToolStripMenuItem();
            чекиToolStripMenuItem1 = new ToolStripMenuItem();
            label1 = new Label();
            change_button = new Button();
            delete_button = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 145);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(776, 231);
            dataGridView1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 36);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // Address_button
            // 
            Address_button.Location = new Point(12, 67);
            Address_button.Name = "Address_button";
            Address_button.Size = new Size(91, 38);
            Address_button.TabIndex = 5;
            Address_button.Text = "Адреса";
            Address_button.UseVisualStyleBackColor = true;
            Address_button.Click += Address_button_Click;
            // 
            // Customer_button
            // 
            Customer_button.Location = new Point(109, 67);
            Customer_button.Name = "Customer_button";
            Customer_button.Size = new Size(91, 38);
            Customer_button.TabIndex = 6;
            Customer_button.Text = "Покупатели";
            Customer_button.UseVisualStyleBackColor = true;
            Customer_button.Click += Customer_button_Click;
            // 
            // Empolyee_Button
            // 
            Empolyee_Button.Location = new Point(206, 67);
            Empolyee_Button.Name = "Empolyee_Button";
            Empolyee_Button.Size = new Size(91, 38);
            Empolyee_Button.TabIndex = 7;
            Empolyee_Button.Text = "Сотрудники";
            Empolyee_Button.UseVisualStyleBackColor = true;
            Empolyee_Button.Click += Empolyee_Button_Click;
            // 
            // Medicines_button
            // 
            Medicines_button.Location = new Point(303, 67);
            Medicines_button.Name = "Medicines_button";
            Medicines_button.Size = new Size(91, 38);
            Medicines_button.TabIndex = 8;
            Medicines_button.Text = "Лекарства";
            Medicines_button.UseVisualStyleBackColor = true;
            Medicines_button.Click += Medicines_button_Click;
            // 
            // Providers_button
            // 
            Providers_button.Location = new Point(400, 67);
            Providers_button.Name = "Providers_button";
            Providers_button.Size = new Size(91, 38);
            Providers_button.TabIndex = 9;
            Providers_button.Text = "Поставщики";
            Providers_button.UseVisualStyleBackColor = true;
            Providers_button.Click += Providers_button_Click;
            // 
            // Purchases_button
            // 
            Purchases_button.Location = new Point(497, 67);
            Purchases_button.Name = "Purchases_button";
            Purchases_button.Size = new Size(91, 38);
            Purchases_button.TabIndex = 10;
            Purchases_button.Text = "Покупки";
            Purchases_button.UseVisualStyleBackColor = true;
            Purchases_button.Click += Purchases_button_Click;
            // 
            // Checks_button
            // 
            Checks_button.Location = new Point(594, 67);
            Checks_button.Name = "Checks_button";
            Checks_button.Size = new Size(91, 38);
            Checks_button.TabIndex = 11;
            Checks_button.Text = "Чеки";
            Checks_button.UseVisualStyleBackColor = true;
            Checks_button.Click += Checks_button_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem3, удалитьЗаписьToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(53, 20);
            toolStripMenuItem1.Text = "Меню";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.DropDownItems.AddRange(new ToolStripItem[] { адресаToolStripMenuItem, покупателиToolStripMenuItem, сотрудникиToolStripMenuItem, лекарстваToolStripMenuItem1, поставщикиToolStripMenuItem, покупкиToolStripMenuItem, чекиToolStripMenuItem });
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(166, 22);
            toolStripMenuItem3.Text = "Добавить запись";
            // 
            // адресаToolStripMenuItem
            // 
            адресаToolStripMenuItem.Name = "адресаToolStripMenuItem";
            адресаToolStripMenuItem.Size = new Size(144, 22);
            адресаToolStripMenuItem.Text = "Адреса";
            адресаToolStripMenuItem.Click += адресаToolStripMenuItem_Click;
            // 
            // покупателиToolStripMenuItem
            // 
            покупателиToolStripMenuItem.Name = "покупателиToolStripMenuItem";
            покупателиToolStripMenuItem.Size = new Size(144, 22);
            покупателиToolStripMenuItem.Text = "Покупатели";
            покупателиToolStripMenuItem.Click += покупателиToolStripMenuItem_Click;
            // 
            // сотрудникиToolStripMenuItem
            // 
            сотрудникиToolStripMenuItem.Name = "сотрудникиToolStripMenuItem";
            сотрудникиToolStripMenuItem.Size = new Size(144, 22);
            сотрудникиToolStripMenuItem.Text = "Сотрудники";
            сотрудникиToolStripMenuItem.Click += сотрудникиToolStripMenuItem_Click;
            // 
            // лекарстваToolStripMenuItem1
            // 
            лекарстваToolStripMenuItem1.Name = "лекарстваToolStripMenuItem1";
            лекарстваToolStripMenuItem1.Size = new Size(144, 22);
            лекарстваToolStripMenuItem1.Text = "Лекарства";
            лекарстваToolStripMenuItem1.Click += лекарстваToolStripMenuItem1_Click;
            // 
            // поставщикиToolStripMenuItem
            // 
            поставщикиToolStripMenuItem.Name = "поставщикиToolStripMenuItem";
            поставщикиToolStripMenuItem.Size = new Size(144, 22);
            поставщикиToolStripMenuItem.Text = "Поставщики";
            поставщикиToolStripMenuItem.Click += поставщикиToolStripMenuItem_Click;
            // 
            // покупкиToolStripMenuItem
            // 
            покупкиToolStripMenuItem.Name = "покупкиToolStripMenuItem";
            покупкиToolStripMenuItem.Size = new Size(144, 22);
            покупкиToolStripMenuItem.Text = "Покупки";
            покупкиToolStripMenuItem.Click += покупкиToolStripMenuItem_Click;
            // 
            // чекиToolStripMenuItem
            // 
            чекиToolStripMenuItem.Name = "чекиToolStripMenuItem";
            чекиToolStripMenuItem.Size = new Size(144, 22);
            чекиToolStripMenuItem.Text = "Чеки";
            чекиToolStripMenuItem.Click += чекиToolStripMenuItem_Click;
            // 
            // удалитьЗаписьToolStripMenuItem
            // 
            удалитьЗаписьToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { адресаToolStripMenuItem1, покупателиToolStripMenuItem1, сотрудникиToolStripMenuItem1, лекарстваToolStripMenuItem, поставщикиToolStripMenuItem1, покупкиToolStripMenuItem1, чекиToolStripMenuItem1 });
            удалитьЗаписьToolStripMenuItem.Name = "удалитьЗаписьToolStripMenuItem";
            удалитьЗаписьToolStripMenuItem.Size = new Size(166, 22);
            удалитьЗаписьToolStripMenuItem.Text = "Удалить запись";
            // 
            // адресаToolStripMenuItem1
            // 
            адресаToolStripMenuItem1.Name = "адресаToolStripMenuItem1";
            адресаToolStripMenuItem1.Size = new Size(144, 22);
            адресаToolStripMenuItem1.Text = "Адреса";
            // 
            // покупателиToolStripMenuItem1
            // 
            покупателиToolStripMenuItem1.Name = "покупателиToolStripMenuItem1";
            покупателиToolStripMenuItem1.Size = new Size(144, 22);
            покупателиToolStripMenuItem1.Text = "Покупатели";
            // 
            // сотрудникиToolStripMenuItem1
            // 
            сотрудникиToolStripMenuItem1.Name = "сотрудникиToolStripMenuItem1";
            сотрудникиToolStripMenuItem1.Size = new Size(144, 22);
            сотрудникиToolStripMenuItem1.Text = "Сотрудники";
            // 
            // лекарстваToolStripMenuItem
            // 
            лекарстваToolStripMenuItem.Name = "лекарстваToolStripMenuItem";
            лекарстваToolStripMenuItem.Size = new Size(144, 22);
            лекарстваToolStripMenuItem.Text = "Лекарства";
            // 
            // поставщикиToolStripMenuItem1
            // 
            поставщикиToolStripMenuItem1.Name = "поставщикиToolStripMenuItem1";
            поставщикиToolStripMenuItem1.Size = new Size(144, 22);
            поставщикиToolStripMenuItem1.Text = "Поставщики";
            // 
            // покупкиToolStripMenuItem1
            // 
            покупкиToolStripMenuItem1.Name = "покупкиToolStripMenuItem1";
            покупкиToolStripMenuItem1.Size = new Size(144, 22);
            покупкиToolStripMenuItem1.Text = "Покупки";
            // 
            // чекиToolStripMenuItem1
            // 
            чекиToolStripMenuItem1.Name = "чекиToolStripMenuItem1";
            чекиToolStripMenuItem1.Size = new Size(144, 22);
            чекиToolStripMenuItem1.Text = "Чеки";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(535, 37);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 13;
            label1.Text = "label1";
            // 
            // change_button
            // 
            change_button.Location = new Point(12, 382);
            change_button.Name = "change_button";
            change_button.Size = new Size(121, 41);
            change_button.TabIndex = 14;
            change_button.Text = "Изменить";
            change_button.UseVisualStyleBackColor = true;
            // 
            // delete_button
            // 
            delete_button.Location = new Point(139, 382);
            delete_button.Name = "delete_button";
            delete_button.Size = new Size(117, 41);
            delete_button.TabIndex = 15;
            delete_button.Text = "Удалить";
            delete_button.UseVisualStyleBackColor = true;
            delete_button.Click += delete_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 434);
            Controls.Add(delete_button);
            Controls.Add(change_button);
            Controls.Add(label1);
            Controls.Add(Checks_button);
            Controls.Add(Purchases_button);
            Controls.Add(Providers_button);
            Controls.Add(Medicines_button);
            Controls.Add(Empolyee_Button);
            Controls.Add(Customer_button);
            Controls.Add(Address_button);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dataGridView1;
        private Label label2;
        private Button Address_button;
        private Button Customer_button;
        private Button Empolyee_Button;
        private Button Medicines_button;
        private Button Providers_button;
        private Button Purchases_button;
        private Button Checks_button;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem адресаToolStripMenuItem;
        private ToolStripMenuItem покупателиToolStripMenuItem;
        private ToolStripMenuItem сотрудникиToolStripMenuItem;
        private ToolStripMenuItem поставщикиToolStripMenuItem;
        private ToolStripMenuItem покупкиToolStripMenuItem;
        private ToolStripMenuItem чекиToolStripMenuItem;
        private ToolStripMenuItem удалитьЗаписьToolStripMenuItem;
        private ToolStripMenuItem адресаToolStripMenuItem1;
        private ToolStripMenuItem покупателиToolStripMenuItem1;
        private ToolStripMenuItem сотрудникиToolStripMenuItem1;
        private ToolStripMenuItem лекарстваToolStripMenuItem;
        private ToolStripMenuItem поставщикиToolStripMenuItem1;
        private ToolStripMenuItem покупкиToolStripMenuItem1;
        private ToolStripMenuItem чекиToolStripMenuItem1;
        private Label label1;
        private ToolStripMenuItem лекарстваToolStripMenuItem1;
        private Button change_button;
        private Button delete_button;
    }
}
