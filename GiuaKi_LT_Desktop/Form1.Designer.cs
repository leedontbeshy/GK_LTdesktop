namespace GiuaKi_LT_Desktop
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
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            MaSo_label = new Label();
            HoTen_label = new Label();
            NgaySinh_Label = new Label();
            label4 = new Label();
            Them_BT = new Button();
            Luu_BT = new Button();
            Thoat_BT = new Button();
            dataGridView1 = new DataGridView();
            MaSo = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            NgaySinh = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(139, 23);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(595, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(139, 73);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(595, 23);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(139, 123);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(595, 23);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(139, 168);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(595, 23);
            textBox4.TabIndex = 3;
            // 
            // MaSo_label
            // 
            MaSo_label.AutoSize = true;
            MaSo_label.Location = new Point(43, 23);
            MaSo_label.Name = "MaSo_label";
            MaSo_label.Size = new Size(39, 15);
            MaSo_label.TabIndex = 4;
            MaSo_label.Text = "Mã số";
            MaSo_label.Click += label1_Click;
            // 
            // HoTen_label
            // 
            HoTen_label.AutoSize = true;
            HoTen_label.Location = new Point(43, 73);
            HoTen_label.Name = "HoTen_label";
            HoTen_label.Size = new Size(43, 15);
            HoTen_label.TabIndex = 5;
            HoTen_label.Text = "Họ tên";
            HoTen_label.Click += HoTen_label_Click;
            // 
            // NgaySinh_Label
            // 
            NgaySinh_Label.AutoSize = true;
            NgaySinh_Label.Location = new Point(43, 123);
            NgaySinh_Label.Name = "NgaySinh_Label";
            NgaySinh_Label.Size = new Size(60, 15);
            NgaySinh_Label.TabIndex = 6;
            NgaySinh_Label.Text = "Ngày sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(43, 168);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 7;
            label4.Text = "Email";
            // 
            // Them_BT
            // 
            Them_BT.Location = new Point(277, 215);
            Them_BT.Name = "Them_BT";
            Them_BT.Size = new Size(75, 23);
            Them_BT.TabIndex = 8;
            Them_BT.Text = "Thêm";
            Them_BT.UseVisualStyleBackColor = true;
            Them_BT.Click += button1_Click;
            // 
            // Luu_BT
            // 
            Luu_BT.Location = new Point(358, 215);
            Luu_BT.Name = "Luu_BT";
            Luu_BT.Size = new Size(75, 23);
            Luu_BT.TabIndex = 9;
            Luu_BT.Text = "Lưu";
            Luu_BT.UseVisualStyleBackColor = true;
            // 
            // Thoat_BT
            // 
            Thoat_BT.Location = new Point(439, 215);
            Thoat_BT.Name = "Thoat_BT";
            Thoat_BT.Size = new Size(75, 23);
            Thoat_BT.TabIndex = 10;
            Thoat_BT.Text = "Thoát";
            Thoat_BT.UseVisualStyleBackColor = true;
            Thoat_BT.Click += button1_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaSo, HoTen, NgaySinh, Email });
            dataGridView1.Location = new Point(25, 254);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(744, 150);
            dataGridView1.TabIndex = 11;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // MaSo
            // 
            MaSo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MaSo.HeaderText = "Mã số";
            MaSo.Name = "MaSo";
            // 
            // HoTen
            // 
            HoTen.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            HoTen.HeaderText = "Họ tên";
            HoTen.Name = "HoTen";
            // 
            // NgaySinh
            // 
            NgaySinh.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NgaySinh.HeaderText = "Ngày sinh";
            NgaySinh.Name = "NgaySinh";
            // 
            // Email
            // 
            Email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Email.HeaderText = "email";
            Email.Name = "Email";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 417);
            Controls.Add(dataGridView1);
            Controls.Add(Thoat_BT);
            Controls.Add(Luu_BT);
            Controls.Add(Them_BT);
            Controls.Add(label4);
            Controls.Add(NgaySinh_Label);
            Controls.Add(HoTen_label);
            Controls.Add(MaSo_label);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label MaSo_label;
        private Label HoTen_label;
        private Label NgaySinh_Label;
        private Label label4;
        private Button Them_BT;
        private Button Luu_BT;
        private Button Thoat_BT;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn MaSo;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn NgaySinh;
        private DataGridViewTextBoxColumn Email;
    }
}

