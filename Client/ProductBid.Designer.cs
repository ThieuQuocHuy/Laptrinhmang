namespace client
{
    partial class ProductBid
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTieuDeDauGia;
        private Label lblBienSoXeTieuDe;
        private Label lblBienSo;
        private Label lblGiaHienTaiTieuDe;
        private Label lblGiaHT;
        private Label lblTGTieuDe;
        private Label lblTG;
        private TextBox txtGiaMoi;
        private Button btnDatGia;
        private Label lblLichSuDauGia;
        private Panel mainPanel;
        private CheckBox chkAutoBid;
        private TextBox txtMaxBid;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            mainPanel = new Panel();
            lvHistory = new ListView();
            lblTieuDeDauGia = new Label();
            lblBienSoXeTieuDe = new Label();
            lblBienSo = new Label();
            lblGiaHienTaiTieuDe = new Label();
            lblGiaHT = new Label();
            lblTGTieuDe = new Label();
            lblTG = new Label();
            txtGiaMoi = new TextBox();
            btnDatGia = new Button();
            lblLichSuDauGia = new Label();
            chkAutoBid = new CheckBox();
            txtMaxBid = new TextBox();
            menuStrip1 = new MenuStrip();
            TrangChuToolStripMenuItem = new ToolStripMenuItem();
            lịchSửToolStripMenuItem = new ToolStripMenuItem();
            tàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            thôngTinTàiKhoảnToolStripMenuItem = new ToolStripMenuItem();
            logOutToolStripMenuItem = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            flowLayoutPanel1 = new FlowLayoutPanel();
            mainPanel.SuspendLayout();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = SystemColors.WindowFrame;
            mainPanel.BorderStyle = BorderStyle.FixedSingle;
            mainPanel.Controls.Add(lvHistory);
            mainPanel.Controls.Add(lblTieuDeDauGia);
            mainPanel.Controls.Add(lblBienSoXeTieuDe);
            mainPanel.Controls.Add(lblBienSo);
            mainPanel.Controls.Add(lblGiaHienTaiTieuDe);
            mainPanel.Controls.Add(lblGiaHT);
            mainPanel.Controls.Add(lblTGTieuDe);
            mainPanel.Controls.Add(lblTG);
            mainPanel.Controls.Add(txtGiaMoi);
            mainPanel.Controls.Add(btnDatGia);
            mainPanel.Controls.Add(lblLichSuDauGia);
            mainPanel.Controls.Add(chkAutoBid);
            mainPanel.Controls.Add(txtMaxBid);
            mainPanel.Location = new Point(0, 0);
            mainPanel.Margin = new Padding(3, 4, 3, 4);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(379, 630);
            mainPanel.TabIndex = 0;
            // 
            // lvHistory
            // 
            lvHistory.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvHistory.GridLines = true;
            lvHistory.Location = new Point(3, 419);
            lvHistory.Margin = new Padding(3, 4, 3, 4);
            lvHistory.Name = "lvHistory";
            lvHistory.Size = new Size(370, 204);
            lvHistory.TabIndex = 10;
            lvHistory.UseCompatibleStateImageBehavior = false;
            lvHistory.View = View.Details;
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
            // lblBienSo
            // 
            lblBienSo.AutoSize = true;
            lblBienSo.BackColor = Color.White;
            lblBienSo.BorderStyle = BorderStyle.FixedSingle;
            lblBienSo.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienSo.ForeColor = Color.Black;
            lblBienSo.Location = new Point(129, 89);
            lblBienSo.Name = "lblBienSo";
            lblBienSo.Size = new Size(189, 56);
            lblBienSo.TabIndex = 2;
            lblBienSo.Text = "ABC-123";
            // 
            // lblGiaHienTaiTieuDe
            // 
            lblGiaHienTaiTieuDe.AutoSize = true;
            lblGiaHienTaiTieuDe.Font = new Font("Segoe UI", 12F);
            lblGiaHienTaiTieuDe.ForeColor = Color.White;
            lblGiaHienTaiTieuDe.Location = new Point(2, 175);
            lblGiaHienTaiTieuDe.Name = "lblGiaHienTaiTieuDe";
            lblGiaHienTaiTieuDe.Size = new Size(120, 28);
            lblGiaHienTaiTieuDe.TabIndex = 3;
            lblGiaHienTaiTieuDe.Text = "Giá Hiện Tại:";
            // 
            // lblGiaHT
            // 
            lblGiaHT.AutoSize = true;
            lblGiaHT.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblGiaHT.ForeColor = Color.White;
            lblGiaHT.Location = new Point(185, 175);
            lblGiaHT.Name = "lblGiaHT";
            lblGiaHT.Size = new Size(156, 28);
            lblGiaHT.TabIndex = 4;
            lblGiaHT.Text = "1.000.000 VND";
            // 
            // lblTGTieuDe
            // 
            lblTGTieuDe.AutoSize = true;
            lblTGTieuDe.Font = new Font("Segoe UI", 12F);
            lblTGTieuDe.ForeColor = Color.White;
            lblTGTieuDe.Location = new Point(3, 227);
            lblTGTieuDe.Name = "lblTGTieuDe";
            lblTGTieuDe.Size = new Size(168, 28);
            lblTGTieuDe.TabIndex = 5;
            lblTGTieuDe.Text = "Thời Gian Còn Lại:";
            // 
            // lblTG
            // 
            lblTG.AutoSize = true;
            lblTG.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTG.ForeColor = Color.White;
            lblTG.Location = new Point(185, 227);
            lblTG.Name = "lblTG";
            lblTG.Size = new Size(94, 28);
            lblTG.TabIndex = 6;
            lblTG.Text = "00:05:30";
            // 
            // txtGiaMoi
            // 
            txtGiaMoi.BackColor = Color.White;
            txtGiaMoi.BorderStyle = BorderStyle.FixedSingle;
            txtGiaMoi.Font = new Font("Segoe UI", 12F);
            txtGiaMoi.Location = new Point(2, 279);
            txtGiaMoi.Margin = new Padding(3, 4, 3, 4);
            txtGiaMoi.Name = "txtGiaMoi";
            txtGiaMoi.PlaceholderText = "Nhập giá tại đây...";
            txtGiaMoi.Size = new Size(228, 34);
            txtGiaMoi.TabIndex = 7;
            txtGiaMoi.KeyPress += txtGiaMoi_KeyPress;
            // 
            // btnDatGia
            // 
            btnDatGia.BackColor = Color.White;
            btnDatGia.Cursor = Cursors.Hand;
            btnDatGia.FlatAppearance.BorderSize = 0;
            btnDatGia.FlatStyle = FlatStyle.Flat;
            btnDatGia.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnDatGia.ForeColor = Color.LightSeaGreen;
            btnDatGia.Location = new Point(250, 277);
            btnDatGia.Margin = new Padding(3, 4, 3, 4);
            btnDatGia.Name = "btnDatGia";
            btnDatGia.Size = new Size(114, 40);
            btnDatGia.TabIndex = 8;
            btnDatGia.Text = "Đặt Giá";
            btnDatGia.UseVisualStyleBackColor = false;
            btnDatGia.Click += btnDatGia_Click;
            // 
            // lblLichSuDauGia
            // 
            lblLichSuDauGia.AutoSize = true;
            lblLichSuDauGia.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            lblLichSuDauGia.ForeColor = Color.White;
            lblLichSuDauGia.Location = new Point(82, 375);
            lblLichSuDauGia.Name = "lblLichSuDauGia";
            lblLichSuDauGia.Size = new Size(241, 37);
            lblLichSuDauGia.TabIndex = 9;
            lblLichSuDauGia.Text = "LỊCH SỬ ĐẤU GIÁ";
            // 
            // chkAutoBid
            // 
            chkAutoBid.AutoSize = true;
            chkAutoBid.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chkAutoBid.ForeColor = Color.White;
            chkAutoBid.Location = new Point(3, 333);
            chkAutoBid.Margin = new Padding(3, 4, 3, 4);
            chkAutoBid.Name = "chkAutoBid";
            chkAutoBid.Size = new Size(173, 32);
            chkAutoBid.TabIndex = 11;
            chkAutoBid.Text = "Đặt giá tự động";
            chkAutoBid.UseVisualStyleBackColor = true;
            chkAutoBid.CheckedChanged += chkAutoBid_CheckedChanged;
            // 
            // txtMaxBid
            // 
            txtMaxBid.BackColor = Color.White;
            txtMaxBid.BorderStyle = BorderStyle.FixedSingle;
            txtMaxBid.Enabled = false;
            txtMaxBid.Font = new Font("Segoe UI", 12F);
            txtMaxBid.Location = new Point(205, 333);
            txtMaxBid.Margin = new Padding(3, 4, 3, 4);
            txtMaxBid.Name = "txtMaxBid";
            txtMaxBid.PlaceholderText = "Giá tối đa...";
            txtMaxBid.Size = new Size(160, 34);
            txtMaxBid.TabIndex = 12;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { TrangChuToolStripMenuItem, lịchSửToolStripMenuItem, tàiKhoảnToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 3, 0, 3);
            menuStrip1.Size = new Size(914, 30);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // TrangChuToolStripMenuItem
            // 
            TrangChuToolStripMenuItem.Name = "TrangChuToolStripMenuItem";
            TrangChuToolStripMenuItem.Size = new Size(87, 24);
            TrangChuToolStripMenuItem.Text = "Trang chủ";
            TrangChuToolStripMenuItem.Click += TrangChuToolStripMenuItem_Click;
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
            tàiKhoảnToolStripMenuItem.Size = new Size(84, 24);
            tàiKhoảnToolStripMenuItem.Text = "tài khoản";
            // 
            // thôngTinTàiKhoảnToolStripMenuItem
            // 
            thôngTinTàiKhoảnToolStripMenuItem.Name = "thôngTinTàiKhoảnToolStripMenuItem";
            thôngTinTàiKhoảnToolStripMenuItem.Size = new Size(217, 26);
            thôngTinTàiKhoảnToolStripMenuItem.Text = "thông tin tài khoản";
            // 
            // logOutToolStripMenuItem
            // 
            logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            logOutToolStripMenuItem.Size = new Size(217, 26);
            logOutToolStripMenuItem.Text = "log out";
            logOutToolStripMenuItem.Click += logOutToolStripMenuItem_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(0, 36);
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
            splitContainer1.Size = new Size(914, 631);
            splitContainer1.SplitterDistance = 530;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(3, 4, 3, 4);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(530, 631);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // ProductBid
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(914, 667);
            Controls.Add(menuStrip1);
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductBid";
            Text = "Đấu Giá Biển Số Xe";
            Load += ProductBid_Load;
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem TrangChuToolStripMenuItem;
        private ToolStripMenuItem lịchSửToolStripMenuItem;
        private ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem thôngTinTàiKhoảnToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private SplitContainer splitContainer1;
        private FlowLayoutPanel flowLayoutPanel1;
        private ListView lvHistory;
    }
}
