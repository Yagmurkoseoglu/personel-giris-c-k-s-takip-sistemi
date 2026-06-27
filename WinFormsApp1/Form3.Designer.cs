namespace WinFormsApp1
{
    partial class Form3
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
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label1 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            temizle = new Button();
            groupBox1 = new GroupBox();
            label2 = new Label();
            dateTimePicker2 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(21, 82);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(321, 82);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(300, 31);
            dateTimePicker1.TabIndex = 1;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 40);
            label1.Name = "label1";
            label1.Size = new Size(131, 25);
            label1.TabIndex = 2;
            label1.Text = "PERSONEL SEÇ";
            // 
            // button1
            // 
            button1.Location = new Point(643, 352);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 3;
            button1.Text = "Hesapla";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 262);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(625, 225);
            dataGridView1.TabIndex = 5;
            // 
            // temizle
            // 
            temizle.Location = new Point(643, 424);
            temizle.Name = "temizle";
            temizle.Size = new Size(112, 34);
            temizle.TabIndex = 6;
            temizle.Text = "temizle";
            temizle.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Location = new Point(37, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(668, 211);
            groupBox1.TabIndex = 7;
            groupBox1.TabStop = false;
            groupBox1.Text = "Maaş ve Mesai hesaplama ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(321, 40);
            label2.Name = "label2";
            label2.Size = new Size(98, 25);
            label2.TabIndex = 3;
            label2.Text = "AY-YIL SEÇ";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(321, 137);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(300, 31);
            dateTimePicker2.TabIndex = 4;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 548);
            Controls.Add(groupBox1);
            Controls.Add(temizle);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private Label label1;
        private Button button1;
        private DataGridView dataGridView1;
        private Button temizle;
        private GroupBox groupBox1;
        private Label label2;
        private DateTimePicker dateTimePicker2;
    }
}