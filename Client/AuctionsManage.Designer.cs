namespace Client
{
    partial class AuctionsManage
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
            splitContainer1 = new SplitContainer();
            flowLayoutPanel1 = new FlowLayoutPanel();
            mainPanel = new Panel();
            cbbStatus = new ComboBox();
            label2 = new Label();
            btnXoa = new Button();
            btnCapNhat = new Button();
            btnThem = new Button();
            dtbKetThuc = new DateTimePicker();
            label1 = new Label();
            dtbStart = new DateTimePicker();
            txtBienso = new TextBox();
            txtGiaBD = new TextBox();
            lblTieuDeDauGia = new Label();
            lblBienSoXeTieuDe = new Label();
            lblGiaHienTaiTieuDe = new Label();
            lblTGTieuDe = new Label();
            thôngTinTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            tàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            lịchSửToolStripMenuItem = new ToolStripMenuItem();
            TrangChuToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            mainPanel.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(0, 33);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(flowLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(mainPanel);
            splitContainer1.Size = new Size(914, 600);
            splitContainer1.SplitterDistance = 530;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(530, 600);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = SystemColors.WindowFrame;
            mainPanel.BorderStyle = BorderStyle.FixedSingle;
            mainPanel.Controls.Add(cbbStatus);
            mainPanel.Controls.Add(label2);
            mainPanel.Controls.Add(btnXoa);
            mainPanel.Controls.Add(btnCapNhat);
            mainPanel.Controls.Add(btnThem);
            mainPanel.Controls.Add(dtbKetThuc);
            mainPanel.Controls.Add(label1);
            mainPanel.Controls.Add(dtbStart);
            mainPanel.Controls.Add(txtBienso);
            mainPanel.Controls.Add(txtGiaBD);
            mainPanel.Controls.Add(lblTieuDeDauGia);
            mainPanel.Controls.Add(lblBienSoXeTieuDe);
            mainPanel.Controls.Add(lblGiaHienTaiTieuDe);
            mainPanel.Controls.Add(lblTGTieuDe);
            mainPanel.Location = new Point(0, 0);
            mainPanel.Margin = new Padding(3, 4, 3, 4);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(379, 630);
            mainPanel.TabIndex = 0;
            // 
            // cbbStatus
            // 
            cbbStatus.FormattingEnabled = true;
            cbbStatus.Items.AddRange(new object[] { "Active", "Completed", "Cancelled" });
            cbbStatus.Location = new Point(136, 337);
            cbbStatus.Margin = new Padding(3, 4, 3, 4);
            cbbStatus.Name = "cbbStatus";
            cbbStatus.Size = new Size(228, 28);
            cbbStatus.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(3, 340);
            label2.Name = "label2";
            label2.Size = new Size(102, 28);
            label2.TabIndex = 22;
            label2.Text = "Trạng thái:";
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.FromArgb(255, 128, 128);
            btnXoa.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnXoa.Location = new Point(279, 448);
            btnXoa.Margin = new Padding(3, 4, 3, 4);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(86, 45);
            btnXoa.TabIndex = 21;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnCapNhat
            // 
            btnCapNhat.BackColor = Color.CornflowerBlue;
            btnCapNhat.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCapNhat.Location = new Point(136, 448);
            btnCapNhat.Margin = new Padding(3, 4, 3, 4);
            btnCapNhat.Name = "btnCapNhat";
            btnCapNhat.Size = new Size(86, 47);
            btnCapNhat.TabIndex = 20;
            btnCapNhat.Text = "Cập nhật";
            btnCapNhat.UseVisualStyleBackColor = false;
            btnCapNhat.Click += btnCapNhat_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(255, 192, 128);
            btnThem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(3, 448);
            btnThem.Margin = new Padding(3, 4, 3, 4);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(86, 45);
            btnThem.TabIndex = 19;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // dtbKetThuc
            // 
            dtbKetThuc.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtbKetThuc.CustomFormat = "HH:mm:ss dd/MM/yyyy";
            dtbKetThuc.Format = DateTimePickerFormat.Custom;
            dtbKetThuc.Location = new Point(136, 280);
            dtbKetThuc.Margin = new Padding(3, 4, 3, 4);
            dtbKetThuc.Name = "dtbKetThuc";
            dtbKetThuc.Size = new Size(228, 27);
            dtbKetThuc.TabIndex = 18;
            dtbKetThuc.Value = new DateTime(2024, 11, 1, 23, 6, 15, 0);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(3, 283);
            label1.Name = "label1";
            label1.Size = new Size(88, 28);
            label1.TabIndex = 17;
            label1.Text = "Kết thúc:";
            // 
            // dtbStart
            // 
            dtbStart.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtbStart.CustomFormat = "HH:mm:ss dd/MM/yyyy";
            dtbStart.Format = DateTimePickerFormat.Custom;
            dtbStart.Location = new Point(136, 227);
            dtbStart.Margin = new Padding(3, 4, 3, 4);
            dtbStart.Name = "dtbStart";
            dtbStart.Size = new Size(228, 27);
            dtbStart.TabIndex = 16;
            dtbStart.Value = new DateTime(2024, 11, 1, 23, 6, 15, 0);
            // 
            // txtBienso
            // 
            txtBienso.BackColor = Color.White;
            txtBienso.BorderStyle = BorderStyle.FixedSingle;
            txtBienso.Font = new Font("Segoe UI", 12F);
            txtBienso.Location = new Point(136, 104);
            txtBienso.Margin = new Padding(3, 4, 3, 4);
            txtBienso.Name = "txtBienso";
            txtBienso.PlaceholderText = "Nhập biển số xe...";
            txtBienso.Size = new Size(228, 34);
            txtBienso.TabIndex = 15;
            // 
            // txtGiaBD
            // 
            txtGiaBD.BackColor = Color.White;
            txtGiaBD.BorderStyle = BorderStyle.FixedSingle;
            txtGiaBD.Font = new Font("Segoe UI", 12F);
            txtGiaBD.Location = new Point(136, 164);
            txtGiaBD.Margin = new Padding(3, 4, 3, 4);
            txtGiaBD.Name = "txtGiaBD";
            txtGiaBD.PlaceholderText = "Nhập giá tại đây...";
            txtGiaBD.Size = new Size(228, 34);
            txtGiaBD.TabIndex = 14;
            // 
            // lblTieuDeDauGia
            // 
            lblTieuDeDauGia.AutoSize = true;
            lblTieuDeDauGia.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblTieuDeDauGia.ForeColor = Color.White;
            lblTieuDeDauGia.Location = new Point(64, 35);
            lblTieuDeDauGia.Name = "lblTieuDeDauGia";
            lblTieuDeDauGia.Size = new Size(279, 37);
            lblTieuDeDauGia.TabIndex = 0;
            lblTieuDeDauGia.Text = "ĐẤU GIÁ BIỂN SỐ XE";
            // 
            // lblBienSoXeTieuDe
            // 
            lblBienSoXeTieuDe.AutoSize = true;
            lblBienSoXeTieuDe.Font = new Font("Segoe UI", 12F);
            lblBienSoXeTieuDe.ForeColor = Color.White;
            lblBienSoXeTieuDe.Location = new Point(3, 115);
            lblBienSoXeTieuDe.Name = "lblBienSoXeTieuDe";
            lblBienSoXeTieuDe.Size = new Size(108, 28);
            lblBienSoXeTieuDe.TabIndex = 1;
            lblBienSoXeTieuDe.Text = "Biển Số Xe:";
            // 
            // lblGiaHienTaiTieuDe
            // 
            lblGiaHienTaiTieuDe.AutoSize = true;
            lblGiaHienTaiTieuDe.Font = new Font("Segoe UI", 12F);
            lblGiaHienTaiTieuDe.ForeColor = Color.White;
            lblGiaHienTaiTieuDe.Location = new Point(2, 175);
            lblGiaHienTaiTieuDe.Name = "lblGiaHienTaiTieuDe";
            lblGiaHienTaiTieuDe.Size = new Size(137, 28);
            lblGiaHienTaiTieuDe.TabIndex = 3;
            lblGiaHienTaiTieuDe.Text = "Giá khởi điểm:";
            // 
            // lblTGTieuDe
            // 
            lblTGTieuDe.AutoSize = true;
            lblTGTieuDe.Font = new Font("Segoe UI", 12F);
            lblTGTieuDe.ForeColor = Color.White;
            lblTGTieuDe.Location = new Point(3, 227);
            lblTGTieuDe.Name = "lblTGTieuDe";
            lblTGTieuDe.Size = new Size(82, 28);
            lblTGTieuDe.TabIndex = 5;
            lblTGTieuDe.Text = "Bắt đầu:";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            thôngTinTàiKhoảnToolStripMenuItem.Size = new Size(217, 26);
            thôngTinTàiKhoảnToolStripMenuItem.Text = "thông tin tài khoản";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            tàiKhoảnToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { thôngTinTàiKhoảnToolStripMenuItem, logOutToolStripMenuItem });
            tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            tàiKhoảnToolStripMenuItem.Size = new Size(84, 24);
            tàiKhoảnToolStripMenuItem.Text = "tài khoản";
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(217, 26);
            logOutToolStripMenuItem.Text = "log out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click_1;
            // 
            // lịchSửToolStripMenuItem
            // 
            lịchSửToolStripMenuItem.Name = "lịchSửToolStripMenuItem";
            lịchSửToolStripMenuItem.Size = new Size(68, 24);
            lịchSửToolStripMenuItem.Text = "Lịch sử";
            // 
            // TrangChuToolStripMenuItem
            // 
            TrangChuToolStripMenuItem.Name = "TrangChuToolStripMenuItem";
            TrangChuToolStripMenuItem.Size = new Size(87, 24);
            TrangChuToolStripMenuItem.Text = "Trang chủ";
            TrangChuToolStripMenuItem.Click += TrangChuToolStripMenuItem_Click_1;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { TrangChuToolStripMenuItem, lịchSửToolStripMenuItem, tàiKhoảnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 3;
            menuStrip1.Text = "menuStrip1";
            // 
            // AuctionsManage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AuctionsManage";
            Text = "AuctionsManage";
            Load += AuctionsManage_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private SplitContainer splitContainer1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel mainPanel;
        private Label lblTieuDeDauGia;
        private Label lblBienSoXeTieuDe;
        private Label lblGiaHienTaiTieuDe;
        private Label lblTGTieuDe;
        private ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem lịchSửToolStripMenuItem;
        private ToolStripMenuItem TrangChuToolStripMenuItem;
        private MenuStrip menuStrip1;
        private DateTimePicker dtbStart;
        private TextBox txtBienso;
        private TextBox txtGiaBD;
        private Label label1;
        private Button btnXoa;
        private Button btnCapNhat;
        private Button btnThem;
        private DateTimePicker dtbKetThuc;
        private ComboBox cbbStatus;
        private Label label2;
    }
}