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
            Customer_button = new Button();
            Empolyee_Button = new Button();
            Medicines_button = new Button();
            Providers_button = new Button();
            Checks_button = new Button();
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            покупателиtoolStripMenuItem1 = new ToolStripMenuItem();
            сотрудникиToolStripMenuItem1 = new ToolStripMenuItem();
            лекарстваToolStripMenuItem = new ToolStripMenuItem();
            поставщикиToolStripMenuItem1 = new ToolStripMenuItem();
            label1 = new Label();
            change_button = new Button();
            delete_button = new Button();
            textBox1 = new TextBox();
            button_search = new Button();
            Explore_check_button = new Button();
            exit_button = new Button();
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
            dataGridView1.DataError += dataGridView1_DataError;
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
            // Customer_button
            // 
            Customer_button.Location = new Point(12, 67);
            Customer_button.Name = "Customer_button";
            Customer_button.Size = new Size(91, 38);
            Customer_button.TabIndex = 6;
            Customer_button.Text = "Покупатели";
            Customer_button.UseVisualStyleBackColor = true;
            Customer_button.Click += Customer_button_Click;
            // 
            // Empolyee_Button
            // 
            Empolyee_Button.Location = new Point(109, 67);
            Empolyee_Button.Name = "Empolyee_Button";
            Empolyee_Button.Size = new Size(91, 38);
            Empolyee_Button.TabIndex = 7;
            Empolyee_Button.Text = "Сотрудники";
            Empolyee_Button.UseVisualStyleBackColor = true;
            Empolyee_Button.Click += Empolyee_Button_Click;
            // 
            // Medicines_button
            // 
            Medicines_button.Location = new Point(206, 67);
            Medicines_button.Name = "Medicines_button";
            Medicines_button.Size = new Size(91, 38);
            Medicines_button.TabIndex = 8;
            Medicines_button.Text = "Лекарства";
            Medicines_button.UseVisualStyleBackColor = true;
            Medicines_button.Click += Medicines_button_Click;
            // 
            // Providers_button
            // 
            Providers_button.Location = new Point(303, 67);
            Providers_button.Name = "Providers_button";
            Providers_button.Size = new Size(91, 38);
            Providers_button.TabIndex = 9;
            Providers_button.Text = "Поставщики";
            Providers_button.UseVisualStyleBackColor = true;
            Providers_button.Click += Providers_button_Click;
            // 
            // Checks_button
            // 
            Checks_button.Location = new Point(400, 67);
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
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { покупателиtoolStripMenuItem1, сотрудникиToolStripMenuItem1, лекарстваToolStripMenuItem, поставщикиToolStripMenuItem1 });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(111, 20);
            toolStripMenuItem1.Text = "Добавить запись";
            // 
            // покупателиtoolStripMenuItem1
            // 
            покупателиtoolStripMenuItem1.Name = "покупателиtoolStripMenuItem1";
            покупателиtoolStripMenuItem1.Size = new Size(144, 22);
            покупателиtoolStripMenuItem1.Text = "Покупатели";
            покупателиtoolStripMenuItem1.Click += покупателиtoolStripMenuItem1_Click;
            // 
            // сотрудникиToolStripMenuItem1
            // 
            сотрудникиToolStripMenuItem1.Name = "сотрудникиToolStripMenuItem1";
            сотрудникиToolStripMenuItem1.Size = new Size(144, 22);
            сотрудникиToolStripMenuItem1.Text = "Сотрудники";
            сотрудникиToolStripMenuItem1.Click += сотрудникиToolStripMenuItem1_Click;
            // 
            // лекарстваToolStripMenuItem
            // 
            лекарстваToolStripMenuItem.Name = "лекарстваToolStripMenuItem";
            лекарстваToolStripMenuItem.Size = new Size(144, 22);
            лекарстваToolStripMenuItem.Text = "Лекарства";
            лекарстваToolStripMenuItem.Click += лекарстваToolStripMenuItem_Click;
            // 
            // поставщикиToolStripMenuItem1
            // 
            поставщикиToolStripMenuItem1.Name = "поставщикиToolStripMenuItem1";
            поставщикиToolStripMenuItem1.Size = new Size(144, 22);
            поставщикиToolStripMenuItem1.Text = "Поставщики";
            поставщикиToolStripMenuItem1.Click += поставщикиToolStripMenuItem1_Click;
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
            change_button.Click += change_button_Click;
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
            // textBox1
            // 
            textBox1.Location = new Point(12, 111);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(285, 23);
            textBox1.TabIndex = 16;
            // 
            // button_search
            // 
            button_search.Location = new Point(319, 111);
            button_search.Name = "button_search";
            button_search.Size = new Size(93, 23);
            button_search.TabIndex = 17;
            button_search.Text = "Найти";
            button_search.UseVisualStyleBackColor = true;
            button_search.Click += button_search_Click;
            // 
            // Explore_check_button
            // 
            Explore_check_button.Location = new Point(262, 382);
            Explore_check_button.Name = "Explore_check_button";
            Explore_check_button.Size = new Size(104, 41);
            Explore_check_button.TabIndex = 18;
            Explore_check_button.Text = "Подробнее";
            Explore_check_button.UseVisualStyleBackColor = true;
            Explore_check_button.Visible = false;
            Explore_check_button.Click += Explore_check_button_Click;
            // 
            // exit_button
            // 
            exit_button.Location = new Point(704, 382);
            exit_button.Name = "exit_button";
            exit_button.Size = new Size(84, 41);
            exit_button.TabIndex = 19;
            exit_button.Text = "Выйти";
            exit_button.UseVisualStyleBackColor = true;
            exit_button.Click += exit_button_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 434);
            Controls.Add(exit_button);
            Controls.Add(Explore_check_button);
            Controls.Add(button_search);
            Controls.Add(textBox1);
            Controls.Add(delete_button);
            Controls.Add(change_button);
            Controls.Add(label1);
            Controls.Add(Checks_button);
            Controls.Add(Providers_button);
            Controls.Add(Medicines_button);
            Controls.Add(Empolyee_Button);
            Controls.Add(Customer_button);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Apteka Control";
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
        private Button Customer_button;
        private Button Empolyee_Button;
        private Button Medicines_button;
        private Button Providers_button;
        private Button Checks_button;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem покупателиtoolStripMenuItem1;
        private Label label1;
        private Button change_button;
        private Button delete_button;
        private TextBox textBox1;
        private Button button_search;
        private ToolStripMenuItem сотрудникиToolStripMenuItem1;
        private ToolStripMenuItem лекарстваToolStripMenuItem;
        private ToolStripMenuItem поставщикиToolStripMenuItem1;
        private Button Explore_check_button;
        private Button exit_button;
    }
}
