﻿namespace NhapHang
{
    partial class NhapHangView
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            button1 = new Button();
            ID = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(394, 19);
            label1.Name = "label1";
            label1.Size = new Size(202, 31);
            label1.TabIndex = 0;
            label1.Text = "PHIẾU NHẬP KHO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 90);
            label2.Name = "label2";
            label2.Size = new Size(67, 20);
            label2.TabIndex = 1;
            label2.Text = "Số phiếu";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 135);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 2;
            label3.Text = "Số HĐ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 181);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 3;
            label4.Text = "Mã Kho";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(139, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(172, 27);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(139, 128);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(172, 27);
            textBox2.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(415, 90);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 7;
            label5.Text = "Ngày";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(493, 87);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(171, 27);
            textBox4.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(415, 135);
            label6.Name = "label6";
            label6.Size = new Size(70, 20);
            label6.TabIndex = 9;
            label6.Text = "Ngày HĐ";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(493, 135);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(171, 27);
            textBox5.TabIndex = 10;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(706, 138);
            label7.Name = "label7";
            label7.Size = new Size(125, 20);
            label7.TabIndex = 11;
            label7.Text = "ĐV phát hành HĐ";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(837, 128);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(156, 27);
            textBox6.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(26, 224);
            label8.Name = "label8";
            label8.Size = new Size(146, 20);
            label8.TabIndex = 13;
            label8.Text = "Danh Sách mặt hàng";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, Column2, Column3, Column4, Column5, Column6 });
            dataGridView1.Location = new Point(66, 267);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(800, 188);
            dataGridView1.TabIndex = 14;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3" });
            comboBox1.Location = new Point(139, 181);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(172, 28);
            comboBox1.TabIndex = 15;
            // 
            // button1
            // 
            button1.Location = new Point(884, 267);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 16;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ID
            // 
            ID.DataPropertyName = "ID";
            ID.HeaderText = "Mã Hàng";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.Width = 125;
            // 
            // Column2
            // 
            Column2.DataPropertyName = "NAME";
            Column2.HeaderText = "Tên hàng";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.Width = 125;
            // 
            // Column3
            // 
            Column3.DataPropertyName = "UNIT";
            Column3.HeaderText = "ĐVT";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Số lượng";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Đơn giá";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.Width = 125;
            // 
            // Column6
            // 
            Column6.HeaderText = "Thành tiền";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.Width = 125;
            // 
            // NhapHangView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1005, 497);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(textBox6);
            Controls.Add(label7);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "NhapHangView";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox6;
        private Label label8;
        private DataGridView dataGridView1;
        private ComboBox comboBox1;
        private Button button1;
        private DataGridViewTextBoxColumn NAME;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn ID;
    }
}