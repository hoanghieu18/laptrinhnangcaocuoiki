namespace QLTrungTamTinHoc
{
    partial class FrmBaoCao
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpTongHop = new System.Windows.Forms.GroupBox();
            this.btnThongKe = new System.Windows.Forms.Button();
            this.lblSoGiangVien = new System.Windows.Forms.Label();
            this.lblSoHocVien = new System.Windows.Forms.Label();
            this.lblSoLop = new System.Windows.Forms.Label();
            this.lblSoKhoaHoc = new System.Windows.Forms.Label();
            this.grpTongHop.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(164, 16);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "BÁO CÁO – THỐNG KÊ";
            // 
            // grpTongHop
            // 
            this.grpTongHop.Controls.Add(this.btnThongKe);
            this.grpTongHop.Controls.Add(this.lblSoGiangVien);
            this.grpTongHop.Controls.Add(this.lblSoHocVien);
            this.grpTongHop.Controls.Add(this.lblSoLop);
            this.grpTongHop.Controls.Add(this.lblSoKhoaHoc);
            this.grpTongHop.Location = new System.Drawing.Point(3, 34);
            this.grpTongHop.Name = "grpTongHop";
            this.grpTongHop.Size = new System.Drawing.Size(800, 296);
            this.grpTongHop.TabIndex = 1;
            this.grpTongHop.TabStop = false;
            this.grpTongHop.Text = "Thống kê tổng hợp";
            // 
            // btnThongKe
            // 
            this.btnThongKe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnThongKe.Location = new System.Drawing.Point(3, 256);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(794, 37);
            this.btnThongKe.TabIndex = 4;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = true;
            this.btnThongKe.Click += new System.EventHandler(this.btnThongKe_Click);
            // 
            // lblSoGiangVien
            // 
            this.lblSoGiangVien.AutoSize = true;
            this.lblSoGiangVien.Location = new System.Drawing.Point(40, 156);
            this.lblSoGiangVien.Name = "lblSoGiangVien";
            this.lblSoGiangVien.Size = new System.Drawing.Size(92, 16);
            this.lblSoGiangVien.TabIndex = 3;
            this.lblSoGiangVien.Text = "Số giảng viên:";
            // 
            // lblSoHocVien
            // 
            this.lblSoHocVien.AutoSize = true;
            this.lblSoHocVien.Location = new System.Drawing.Point(40, 113);
            this.lblSoHocVien.Name = "lblSoHocVien";
            this.lblSoHocVien.Size = new System.Drawing.Size(80, 16);
            this.lblSoHocVien.TabIndex = 2;
            this.lblSoHocVien.Text = "Số học viên:";
            // 
            // lblSoLop
            // 
            this.lblSoLop.AutoSize = true;
            this.lblSoLop.Location = new System.Drawing.Point(40, 72);
            this.lblSoLop.Name = "lblSoLop";
            this.lblSoLop.Size = new System.Drawing.Size(74, 16);
            this.lblSoLop.TabIndex = 1;
            this.lblSoLop.Text = "Số lớp học:";
            // 
            // lblSoKhoaHoc
            // 
            this.lblSoKhoaHoc.AutoSize = true;
            this.lblSoKhoaHoc.Location = new System.Drawing.Point(40, 30);
            this.lblSoKhoaHoc.Name = "lblSoKhoaHoc";
            this.lblSoKhoaHoc.Size = new System.Drawing.Size(85, 16);
            this.lblSoKhoaHoc.TabIndex = 0;
            this.lblSoKhoaHoc.Text = "Số khóa học:";
            // 
            // FrmBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grpTongHop);
            this.Controls.Add(this.lblTitle);
            this.Name = "FrmBaoCao";
            this.Text = "BÁO CÁO THỐNG KÊ";
            this.Load += new System.EventHandler(this.FrmBaoCao_Load);
            this.grpTongHop.ResumeLayout(false);
            this.grpTongHop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpTongHop;
        private System.Windows.Forms.Label lblSoGiangVien;
        private System.Windows.Forms.Label lblSoHocVien;
        private System.Windows.Forms.Label lblSoLop;
        private System.Windows.Forms.Label lblSoKhoaHoc;
        private System.Windows.Forms.Button btnThongKe;
    }
}