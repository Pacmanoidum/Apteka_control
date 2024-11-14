namespace Apteka_control
{
    partial class FormAddressADD
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
            label3 = new Label();
            label4 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            button1 = new Button();
            labelTown = new Label();
            labelStreet = new Label();
            labelHouse = new Label();
            labelApartment = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 1;
            label1.Text = "Город";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 54);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 2;
            label2.Text = "Улица";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 83);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 3;
            label3.Text = "Дом";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 116);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 4;
            label4.Text = "Квартира";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(124, 46);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(124, 75);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 6;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(124, 108);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 7;
            textBox4.KeyPress += textBox4_KeyPress;
            // 
            // button1
            // 
            button1.Location = new Point(362, 163);
            button1.Name = "button1";
            button1.Size = new Size(121, 63);
            button1.TabIndex = 8;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelTown
            // 
            labelTown.AutoSize = true;
            labelTown.Location = new Point(277, 20);
            labelTown.Name = "labelTown";
            labelTown.Size = new Size(38, 15);
            labelTown.TabIndex = 9;
            labelTown.Text = "label5";
            // 
            // labelStreet
            // 
            labelStreet.AutoSize = true;
            labelStreet.Location = new Point(277, 54);
            labelStreet.Name = "labelStreet";
            labelStreet.Size = new Size(38, 15);
            labelStreet.TabIndex = 10;
            labelStreet.Text = "label6";
            // 
            // labelHouse
            // 
            labelHouse.AutoSize = true;
            labelHouse.Location = new Point(277, 83);
            labelHouse.Name = "labelHouse";
            labelHouse.Size = new Size(38, 15);
            labelHouse.TabIndex = 11;
            labelHouse.Text = "label7";
            // 
            // labelApartment
            // 
            labelApartment.AutoSize = true;
            labelApartment.Location = new Point(277, 116);
            labelApartment.Name = "labelApartment";
            labelApartment.Size = new Size(38, 15);
            labelApartment.TabIndex = 12;
            labelApartment.Text = "label8";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 187);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 15;
            label6.Text = "label6";
            // 
            // FormAddressADD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(496, 237);
            Controls.Add(label6);
            Controls.Add(labelApartment);
            Controls.Add(labelHouse);
            Controls.Add(labelStreet);
            Controls.Add(labelTown);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "FormAddressADD";
            Text = "FormAddressADD";
            Load += FormAddressADD_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button button1;
        private Label labelTown;
        private Label labelStreet;
        private Label labelHouse;
        private Label labelApartment;
        private Label label6;
    }
}