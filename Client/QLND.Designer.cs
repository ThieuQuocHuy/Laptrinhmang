﻿namespace Client
{
    partial class QLND
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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            menuStrip1 = new MenuStrip();
            trangChủToolStripMenuItem = new ToolStripMenuItem();
            lịchSửToolStripMenuItem = new ToolStripMenuItem();
            tàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            thôngTinTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            panel2 = new Panel();
            txtSex = new TextBox();
            buton_xem = new Button();
            button2 = new Button();
            button1 = new Button();
            txtPhone = new TextBox();
            label8 = new Label();
            label7 = new Label();
            txtName = new TextBox();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            txtId = new TextBox();
            label3 = new Label();
            textBox7 = new TextBox();
            dtgvEmployee = new DataGridView();
            ColId = new DataGridViewTextBoxColumn();
            ColName = new DataGridViewTextBoxColumn();
            colAddress = new DataGridViewTextBoxColumn();
            colBirthday = new DataGridViewTextBoxColumn();
            colSex = new DataGridViewTextBoxColumn();
            colPhone = new DataGridViewTextBoxColumn();
            label9 = new Label();
            mySqlCommand1 = new MySqlConnector.MySqlCommand();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menuStrip1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dtgvEmployee).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.WindowFrame;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 36);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(774, 185);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(454, 68);
            label2.Name = "label2";
            label2.Size = new Size(83, 28);
            label2.TabIndex = 2;
            label2.Text = "Nhóm 7";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(337, 25);
            label1.Name = "label1";
            label1.Size = new Size(315, 41);
            label1.TabIndex = 1;
            label1.Text = "Quản Lý Người Dùng";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.quanlykhachhang;
            pictureBox1.Location = new Point(29, 25);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 120);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { trangChủToolStripMenuItem, lịchSửToolStripMenuItem, tàiKhoảnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(853, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // trangChủToolStripMenuItem
            // 
            trangChủToolStripMenuItem.Name = "trangChủToolStripMenuItem";
            trangChủToolStripMenuItem.Size = new Size(87, 24);
            trangChủToolStripMenuItem.Text = "Trang chủ";
            trangChủToolStripMenuItem.Click += trangChủToolStripMenuItem_Click;
            // 
            // lịchSửToolStripMenuItem
            // 
            lịchSửToolStripMenuItem.Name = "lịchSửToolStripMenuItem";
            lịchSửToolStripMenuItem.Size = new Size(68, 24);
            lịchSửToolStripMenuItem.Text = "Lịch sử";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinTàiKhoảnToolStripMenuItem, logOutToolStripMenuItem });
            tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            tàiKhoảnToolStripMenuItem.Size = new Size(85, 24);
            tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            thôngTinTàiKhoảnToolStripMenuItem.Size = new Size(220, 26);
            thôngTinTàiKhoảnToolStripMenuItem.Text = "Thông tin tài khoản";
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(220, 26);
            logOutToolStripMenuItem.Text = "Log out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.AppWorkspace;
            panel2.Controls.Add(txtSex);
            panel2.Controls.Add(buton_xem);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(txtPhone);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(txtName);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(txtId);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(0, 208);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(774, 235);
            panel2.TabIndex = 2;
            // 
            // txtSex
            // 
            txtSex.Location = new Point(482, 43);
            txtSex.Margin = new Padding(3, 4, 3, 4);
            txtSex.Name = "txtSex";
            txtSex.Size = new Size(158, 27);
            txtSex.TabIndex = 17;
            // 
            // buton_xem
            // 
            buton_xem.BackColor = SystemColors.ControlDark;
            buton_xem.Location = new Point(408, 167);
            buton_xem.Margin = new Padding(3, 4, 3, 4);
            buton_xem.Name = "buton_xem";
            buton_xem.Size = new Size(86, 43);
            buton_xem.TabIndex = 16;
            buton_xem.Text = "Xem";
            buton_xem.UseVisualStyleBackColor = false;
            buton_xem.Click += buton_xem_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDark;
            button2.Location = new Point(655, 167);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(91, 43);
            button2.TabIndex = 14;
            button2.Text = "Xóa";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.Location = new Point(533, 167);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 43);
            button1.TabIndex = 13;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(482, 104);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(158, 27);
            txtPhone.TabIndex = 12;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(369, 107);
            label8.Name = "label8";
            label8.Size = new Size(116, 23);
            label8.TabIndex = 8;
            label8.Text = "Số điện thoại";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(369, 43);
            label7.Name = "label7";
            label7.Size = new Size(80, 23);
            label7.TabIndex = 7;
            label7.Text = "Giới tính";
            // 
            // txtName
            // 
            txtName.Location = new Point(113, 99);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(172, 27);
            txtName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(29, 105);
            label4.Name = "label4";
            label4.Size = new Size(87, 23);
            label4.TabIndex = 3;
            label4.Text = "Họ và tên";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.kinh_lup;
            pictureBox2.Location = new Point(671, 64);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(63, 44);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // txtId
            // 
            txtId.Cursor = Cursors.IBeam;
            txtId.Location = new Point(113, 40);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(172, 27);
            txtId.TabIndex = 1;
            txtId.TextChanged += textBox1_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(29, 37);
            label3.Name = "label3";
            label3.Size = new Size(33, 28);
            label3.TabIndex = 0;
            label3.Text = "ID";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(3, 491);
            textBox7.Margin = new Padding(3, 4, 3, 4);
            textBox7.Multiline = true;
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(770, 219);
            textBox7.TabIndex = 3;
            // 
            // dtgvEmployee
            // 
            dtgvEmployee.BackgroundColor = SystemColors.ButtonHighlight;
            dtgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvEmployee.Columns.AddRange(new DataGridViewColumn[] { ColId, ColName, colAddress, colBirthday, colSex, colPhone });
            dtgvEmployee.Location = new Point(3, 491);
            dtgvEmployee.Margin = new Padding(3, 4, 3, 4);
            dtgvEmployee.Name = "dtgvEmployee";
            dtgvEmployee.ReadOnly = true;
            dtgvEmployee.RowHeadersWidth = 51;
            dtgvEmployee.Size = new Size(770, 220);
            dtgvEmployee.TabIndex = 4;
            dtgvEmployee.CellClick += dtgvEmployee_CellClick;
            dtgvEmployee.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ColId
            // 
            ColId.DataPropertyName = "Id";
            ColId.HeaderText = "ID";
            ColId.MinimumWidth = 6;
            ColId.Name = "ColId";
            ColId.ReadOnly = true;
            ColId.Width = 125;
            // 
            // ColName
            // 
            ColName.DataPropertyName = "Name";
            ColName.HeaderText = "Họ và tên";
            ColName.MinimumWidth = 6;
            ColName.Name = "ColName";
            ColName.ReadOnly = true;
            ColName.Width = 125;
            // 
            // colAddress
            // 
            colAddress.DataPropertyName = "Address";
            colAddress.HeaderText = "Địa chỉ";
            colAddress.MinimumWidth = 6;
            colAddress.Name = "colAddress";
            colAddress.ReadOnly = true;
            colAddress.Width = 125;
            // 
            // colBirthday
            // 
            colBirthday.DataPropertyName = "Birthday";
            colBirthday.HeaderText = "Mgày sinh";
            colBirthday.MinimumWidth = 6;
            colBirthday.Name = "colBirthday";
            colBirthday.ReadOnly = true;
            colBirthday.Width = 125;
            // 
            // colSex
            // 
            colSex.DataPropertyName = "Sex";
            colSex.HeaderText = "Giới tính";
            colSex.MinimumWidth = 6;
            colSex.Name = "colSex";
            colSex.ReadOnly = true;
            colSex.Width = 125;
            // 
            // colPhone
            // 
            colPhone.DataPropertyName = "Phone";
            colPhone.HeaderText = "SĐT";
            colPhone.MinimumWidth = 6;
            colPhone.Name = "colPhone";
            colPhone.ReadOnly = true;
            colPhone.Width = 125;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(249, 447);
            label9.Name = "label9";
            label9.Size = new Size(369, 37);
            label9.TabIndex = 5;
            label9.Text = "DANH SÁCH NGƯỜI DÙNG ";
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CommandTimeout = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.Transaction = null;
            mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // QLND
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 708);
            Controls.Add(label9);
            Controls.Add(dtgvEmployee);
            Controls.Add(textBox7);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "QLND";
            Text = "QLKH";
            Load += QLND_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dtgvEmployee).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem trangChủToolStripMenuItem;
        private ToolStripMenuItem lịchSửToolStripMenuItem;
        private ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem trợGiúpToolStripMenuItem;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private TextBox txtId;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
        private Label label7;
        private TextBox txtName;
        private TextBox textBox7;
        private Button button1;
        private Button button2;
        private DataGridView dtgvEmployee;
        private Label label9;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private TextBox txtPhone;
        private Label label8;
        private Button button3;
        private Button buton_xem;
        private TextBox txtSex;
        private DataGridViewTextBoxColumn ColId;
        private DataGridViewTextBoxColumn ColName;
        private DataGridViewTextBoxColumn colAddress;
        private DataGridViewTextBoxColumn colBirthday;
        private DataGridViewTextBoxColumn colSex;
        private DataGridViewTextBoxColumn colPhone;
    }
}






























