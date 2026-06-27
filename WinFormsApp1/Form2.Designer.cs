namespace WinFormsApp1
{
    partial class Form2
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
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            groupBox1 = new GroupBox();
            button2 = new Button();
            button1 = new Button();
            groupBox2 = new GroupBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(153, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 31);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(153, 101);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 31);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(153, 160);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(150, 31);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(153, 213);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(150, 31);
            textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(153, 272);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(150, 31);
            textBox5.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(416, 65);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 5;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(20, 48);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(90, 29);
            radioButton1.TabIndex = 6;
            radioButton1.TabStop = true;
            radioButton1.Text = "KADIN";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(179, 48);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(86, 29);
            radioButton2.TabIndex = 7;
            radioButton2.TabStop = true;
            radioButton2.Text = "ERKEK";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button2);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(groupBox2);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(textBox5);
            groupBox1.Location = new Point(57, 38);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(833, 400);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "Personel kayıt ekranı";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // button2
            // 
            button2.Location = new Point(651, 306);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 16;
            button2.Text = "Temizle";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(416, 306);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 15;
            button1.Text = "Kayıt";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Controls.Add(radioButton2);
            groupBox2.Location = new Point(420, 148);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(300, 119);
            groupBox2.TabIndex = 14;
            groupBox2.TabStop = false;
            groupBox2.Text = "Cinsiyet";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(332, 27);
            label7.Name = "label7";
            label7.Size = new Size(149, 25);
            label7.TabIndex = 9;
            label7.Text = "İşe başlama tarihi";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 166);
            label6.Name = "label6";
            label6.Size = new Size(68, 25);
            label6.TabIndex = 9;
            label6.Text = "Telefon";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 278);
            label5.Name = "label5";
            label5.Size = new Size(101, 25);
            label5.TabIndex = 13;
            label5.Text = "Departman";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 219);
            label4.Name = "label4";
            label4.Size = new Size(58, 25);
            label4.TabIndex = 12;
            label4.Text = "Adres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 166);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 107);
            label2.Name = "label2";
            label2.Size = new Size(57, 25);
            label2.TabIndex = 10;
            label2.Text = "TC no";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 48);
            label1.Name = "label1";
            label1.Size = new Size(92, 25);
            label1.TabIndex = 9;
            label1.Text = "Ad-Soyad";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 450);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "Form2";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private DateTimePicker dateTimePicker1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private GroupBox groupBox1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private Button button2;
        private Button button1;
        private GroupBox groupBox2;
    }
}