namespace Client
{
    partial class AddAuctions
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
            mainPanel = new Panel();
            cbbStatus = new ComboBox();
            label2 = new Label();
            btnQuaylai = new Button();
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
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = SystemColors.WindowFrame;
            mainPanel.BorderStyle = BorderStyle.FixedSingle;
            mainPanel.Controls.Add(cbbStatus);
            mainPanel.Controls.Add(label2);
            mainPanel.Controls.Add(btnQuaylai);
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
            mainPanel.Location = new Point(3, 0);
            mainPanel.Margin = new Padding(3, 4, 3, 4);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(395, 597);
            mainPanel.TabIndex = 1;
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
            // btnQuaylai
            // 
            btnQuaylai.BackColor = Color.FromArgb(255, 255, 128);
            btnQuaylai.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnQuaylai.Location = new Point(207, 448);
            btnQuaylai.Margin = new Padding(3, 4, 3, 4);
            btnQuaylai.Name = "btnQuaylai";
            btnQuaylai.Size = new Size(86, 45);
            btnQuaylai.TabIndex = 21;
            btnQuaylai.Text = "Quay lại";
            btnQuaylai.UseVisualStyleBackColor = false;
            btnQuaylai.Click += btnQuaylai_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = Color.FromArgb(255, 192, 128);
            btnThem.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThem.Location = new Point(81, 448);
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
            // AddAuctions
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(403, 600);
            Controls.Add(mainPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "AddAuctions";
            Text = "Thêm đấu giá";
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private ComboBox cbbStatus;
        private Label label2;
        private Button btnQuaylai;
        private Button btnThem;
        private DateTimePicker dtbKetThuc;
        private Label label1;
        private DateTimePicker dtbStart;
        private TextBox txtBienso;
        private TextBox txtGiaBD;
        private Label lblTieuDeDauGia;
        private Label lblBienSoXeTieuDe;
        private Label lblGiaHienTaiTieuDe;
        private Label lblTGTieuDe;
    }
}