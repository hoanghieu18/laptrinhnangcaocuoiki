namespace QLTrungTamTinHoc
{
    partial class FrmKetQuaHocTap
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboHocVien = new System.Windows.Forms.ComboBox();
            this.cboLopHoc = new System.Windows.Forms.ComboBox();
            this.txtDiemQT = new System.Windows.Forms.TextBox();
            this.txtDiemCK = new System.Windows.Forms.TextBox();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnMoi = new System.Windows.Forms.Button();
            this.dgvKetQua = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Học viên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lớp học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Điểm quá trình";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Điểm cuối kì";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 169);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Danh sách kết quả";
            // 
            // cboHocVien
            // 
            this.cboHocVien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboHocVien.FormattingEnabled = true;
            this.cboHocVien.Location = new System.Drawing.Point(257, 30);
            this.cboHocVien.Name = "cboHocVien";
            this.cboHocVien.Size = new System.Drawing.Size(198, 24);
            this.cboHocVien.TabIndex = 5;
            // 
            // cboLopHoc
            // 
            this.cboLopHoc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLopHoc.FormattingEnabled = true;
            this.cboLopHoc.Location = new System.Drawing.Point(257, 59);
            this.cboLopHoc.Name = "cboLopHoc";
            this.cboLopHoc.Size = new System.Drawing.Size(198, 24);
            this.cboLopHoc.TabIndex = 6;
            // 
            // txtDiemQT
            // 
            this.txtDiemQT.Location = new System.Drawing.Point(257, 94);
            this.txtDiemQT.Name = "txtDiemQT";
            this.txtDiemQT.Size = new System.Drawing.Size(198, 22);
            this.txtDiemQT.TabIndex = 7;
            // 
            // txtDiemCK
            // 
            this.txtDiemCK.Location = new System.Drawing.Point(257, 129);
            this.txtDiemCK.Name = "txtDiemCK";
            this.txtDiemCK.Size = new System.Drawing.Size(198, 22);
            this.txtDiemCK.TabIndex = 8;
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(109, 222);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 9;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(257, 222);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 10;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnMoi
            // 
            this.btnMoi.Location = new System.Drawing.Point(407, 222);
            this.btnMoi.Name = "btnMoi";
            this.btnMoi.Size = new System.Drawing.Size(75, 23);
            this.btnMoi.TabIndex = 11;
            this.btnMoi.Text = "Làm mới";
            this.btnMoi.UseVisualStyleBackColor = true;
            this.btnMoi.Click += new System.EventHandler(this.btnMoi_Click);
            // 
            // dgvKetQua
            // 
            this.dgvKetQua.AllowUserToAddRows = false;
            this.dgvKetQua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKetQua.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvKetQua.Location = new System.Drawing.Point(0, 274);
            this.dgvKetQua.Name = "dgvKetQua";
            this.dgvKetQua.ReadOnly = true;
            this.dgvKetQua.RowHeadersWidth = 51;
            this.dgvKetQua.RowTemplate.Height = 24;
            this.dgvKetQua.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKetQua.Size = new System.Drawing.Size(800, 176);
            this.dgvKetQua.TabIndex = 12;
            this.dgvKetQua.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvKetQua_CellContentClick);
            // 
            // FrmKetQuaHocTap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvKetQua);
            this.Controls.Add(this.btnMoi);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtDiemCK);
            this.Controls.Add(this.txtDiemQT);
            this.Controls.Add(this.cboLopHoc);
            this.Controls.Add(this.cboHocVien);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmKetQuaHocTap";
            this.Text = "Kết quả học tập";
            this.Load += new System.EventHandler(this.FrmKetQuaHocTap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKetQua)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboHocVien;
        private System.Windows.Forms.ComboBox cboLopHoc;
        private System.Windows.Forms.TextBox txtDiemQT;
        private System.Windows.Forms.TextBox txtDiemCK;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnMoi;
        private System.Windows.Forms.DataGridView dgvKetQua;
    }
}