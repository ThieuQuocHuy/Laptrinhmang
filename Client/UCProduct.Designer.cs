namespace Client
{
    partial class UCProduct
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblBienso = new Label();
            label2 = new Label();
            lblGiaHT = new Label();
            label3 = new Label();
            lblTrangthai = new Label();
            lblDemnguoc = new Label();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // lblBienso
            // 
            lblBienso.AutoSize = true;
            lblBienso.BorderStyle = BorderStyle.FixedSingle;
            lblBienso.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienso.Location = new Point(3, 37);
            lblBienso.Name = "lblBienso";
            lblBienso.Size = new Size(168, 39);
            lblBienso.TabIndex = 0;
            lblBienso.Text = "51A-123.45";
            lblBienso.Click += lblBienso_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(157, 12);
            label2.Name = "label2";
            label2.Size = new Size(126, 28);
            label2.TabIndex = 1;
            label2.Text = "Giá hiện tại:";
            label2.Click += lblBienso_Click;
            // 
            // lblGiaHT
            // 
            lblGiaHT.AutoSize = true;
            lblGiaHT.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGiaHT.ForeColor = Color.MediumSeaGreen;
            lblGiaHT.Location = new Point(279, 12);
            lblGiaHT.Name = "lblGiaHT";
            lblGiaHT.Size = new Size(180, 28);
            lblGiaHT.TabIndex = 2;
            lblGiaHT.Text = "500.000.000 VNĐ";
            lblGiaHT.Click += lblBienso_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.IndianRed;
            label3.Location = new Point(157, 52);
            label3.Name = "label3";
            label3.Size = new Size(113, 28);
            label3.TabIndex = 3;
            label3.Text = "Trạng thái:";
            label3.Click += lblBienso_Click;
            // 
            // lblTrangthai
            // 
            lblTrangthai.AutoSize = true;
            lblTrangthai.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTrangthai.ForeColor = Color.LightSeaGreen;
            lblTrangthai.Location = new Point(254, 52);
            lblTrangthai.Name = "lblTrangthai";
            lblTrangthai.Size = new Size(139, 28);
            lblTrangthai.TabIndex = 4;
            lblTrangthai.Text = "Đang đấu giá";
            lblTrangthai.Click += lblBienso_Click;
            // 
            // lblDemnguoc
            // 
            lblDemnguoc.AutoSize = true;
            lblDemnguoc.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDemnguoc.ForeColor = Color.FromArgb(255, 128, 0);
            lblDemnguoc.Location = new Point(157, 92);
            lblDemnguoc.Name = "lblDemnguoc";
            lblDemnguoc.Size = new Size(188, 28);
            lblDemnguoc.TabIndex = 5;
            lblDemnguoc.Text = "Bắt đầu sau: 12:00";
            lblDemnguoc.Click += lblBienso_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.WindowFrame;
            panel1.Location = new Point(3, -1);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(146, 127);
            panel1.TabIndex = 6;
            panel1.Click += lblBienso_Click;
            // 
            // UCProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(lblDemnguoc);
            Controls.Add(lblTrangthai);
            Controls.Add(label3);
            Controls.Add(lblGiaHT);
            Controls.Add(label2);
            Controls.Add(lblBienso);
            Controls.Add(panel1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UCProduct";
            Size = new Size(487, 129);
            Click += UCProduct_Click;
            MouseEnter += UCProduct_MouseEnter;
            MouseLeave += UCProduct_MouseLeave;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienso;
        private Label label2;
        private Label lblGiaHT;
        private Label label3;
        private Label lblTrangthai;
        private Label lblDemnguoc;
        private Panel panel1;
    }
}
