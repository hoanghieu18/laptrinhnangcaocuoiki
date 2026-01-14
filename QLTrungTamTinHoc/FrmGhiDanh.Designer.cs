namespace QLTrungTamTinHoc
{
    partial class FrmGhiDanh
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboHocVien = new System.Windows.Forms.ComboBox();
            this.cboLopHoc = new System.Windows.Forms.ComboBox();
            this.dtpNgayDangKy = new System.Windows.Forms.DateTimePicker();
            this.btnGhiDanh = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.dgvGhiDanh = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGhiDanh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Học viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lớp học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày đăng kí";
            // 
            // cboHocVien
            // 
            this.cboHocVien.FormattingEnabled = true;
            this.cboHocVien.Location = new System.Drawing.Point(181, 36);
            this.cboHocVien.Name = "cboHocVien";
            this.cboHocVien.Size = new System.Drawing.Size(206, 24);
            this.cboHocVien.TabIndex = 6;
            // 
            // cboLopHoc
            // 
            this.cboLopHoc.FormattingEnabled = true;
            this.cboLopHoc.Location = new System.Drawing.Point(181, 70);
            this.cboLopHoc.Name = "cboLopHoc";
            this.cboLopHoc.Size = new System.Drawing.Size(206, 24);
            this.cboLopHoc.TabIndex = 7;
            // 
            // dtpNgayDangKy
            // 
            this.dtpNgayDangKy.Location = new System.Drawing.Point(181, 106);
            this.dtpNgayDangKy.Name = "dtpNgayDangKy";
            this.dtpNgayDangKy.Size = new System.Drawing.Size(206, 22);
            this.dtpNgayDangKy.TabIndex = 8;
            // 
            // btnGhiDanh
            // 
            this.btnGhiDanh.Location = new System.Drawing.Point(144, 202);
            this.btnGhiDanh.Name = "btnGhiDanh";
            this.btnGhiDanh.Size = new System.Drawing.Size(100, 23);
            this.btnGhiDanh.TabIndex = 9;
            this.btnGhiDanh.Text = "Ghi danh";
            this.btnGhiDanh.UseVisualStyleBackColor = true;
            this.btnGhiDanh.Click += new System.EventHandler(this.btnGhiDanh_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(316, 202);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(89, 23);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // dgvGhiDanh
            // 
            this.dgvGhiDanh.AllowUserToAddRows = false;
            this.dgvGhiDanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGhiDanh.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvGhiDanh.Location = new System.Drawing.Point(0, 284);
            this.dgvGhiDanh.Name = "dgvGhiDanh";
            this.dgvGhiDanh.ReadOnly = true;
            this.dgvGhiDanh.RowHeadersWidth = 51;
            this.dgvGhiDanh.RowTemplate.Height = 24;
            this.dgvGhiDanh.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGhiDanh.Size = new System.Drawing.Size(800, 166);
            this.dgvGhiDanh.TabIndex = 11;
            // 
            // FrmGhiDanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvGhiDanh);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnGhiDanh);
            this.Controls.Add(this.dtpNgayDangKy);
            this.Controls.Add(this.cboLopHoc);
            this.Controls.Add(this.cboHocVien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmGhiDanh";
            this.Text = "Ghi danh học viên";
            this.Load += new System.EventHandler(this.FrmGhiDanh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGhiDanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboHocVien;
        private System.Windows.Forms.ComboBox cboLopHoc;
        private System.Windows.Forms.DateTimePicker dtpNgayDangKy;
        private System.Windows.Forms.Button btnGhiDanh;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.DataGridView dgvGhiDanh;
    }
}