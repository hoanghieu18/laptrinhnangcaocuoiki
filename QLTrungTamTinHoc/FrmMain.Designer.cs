namespace QLTrungTamTinHoc
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuKhoaHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHocVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuGiangVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuLopHoc = new System.Windows.Forms.ToolStripMenuItem();
            this.ghiDanhHọcViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kếtQuảHọcTậpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýToolStripMenuItem,
            this.báoCáoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuKhoaHoc,
            this.mnuHocVien,
            this.mnuGiangVien,
            this.mnuLopHoc,
            this.ghiDanhHọcViênToolStripMenuItem,
            this.kếtQuảHọcTậpToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // mnuKhoaHoc
            // 
            this.mnuKhoaHoc.Name = "mnuKhoaHoc";
            this.mnuKhoaHoc.Size = new System.Drawing.Size(210, 26);
            this.mnuKhoaHoc.Text = "Khóa học";
            this.mnuKhoaHoc.Click += new System.EventHandler(this.khóaToolStripMenuItem_Click);
            // 
            // mnuHocVien
            // 
            this.mnuHocVien.Name = "mnuHocVien";
            this.mnuHocVien.Size = new System.Drawing.Size(210, 26);
            this.mnuHocVien.Text = "Học viên";
            this.mnuHocVien.Click += new System.EventHandler(this.mnuHocVien_Click);
            // 
            // mnuGiangVien
            // 
            this.mnuGiangVien.Name = "mnuGiangVien";
            this.mnuGiangVien.Size = new System.Drawing.Size(210, 26);
            this.mnuGiangVien.Text = "Giảng viên";
            this.mnuGiangVien.Click += new System.EventHandler(this.mnuGiangVien_Click);
            // 
            // mnuLopHoc
            // 
            this.mnuLopHoc.Name = "mnuLopHoc";
            this.mnuLopHoc.Size = new System.Drawing.Size(210, 26);
            this.mnuLopHoc.Text = "Lớp học";
            this.mnuLopHoc.Click += new System.EventHandler(this.mnuLopHoc_Click);
            // 
            // ghiDanhHọcViênToolStripMenuItem
            // 
            this.ghiDanhHọcViênToolStripMenuItem.Name = "ghiDanhHọcViênToolStripMenuItem";
            this.ghiDanhHọcViênToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.ghiDanhHọcViênToolStripMenuItem.Text = "Ghi danh học viên";
            this.ghiDanhHọcViênToolStripMenuItem.Click += new System.EventHandler(this.ghiDanhHọcViênToolStripMenuItem_Click);
            // 
            // kếtQuảHọcTậpToolStripMenuItem
            // 
            this.kếtQuảHọcTậpToolStripMenuItem.Name = "kếtQuảHọcTậpToolStripMenuItem";
            this.kếtQuảHọcTậpToolStripMenuItem.Size = new System.Drawing.Size(210, 26);
            this.kếtQuảHọcTậpToolStripMenuItem.Text = "Kết quả học tập";
            this.kếtQuảHọcTậpToolStripMenuItem.Click += new System.EventHandler(this.kếtQuảHọcTậpToolStripMenuItem_Click);
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuThongKe});
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // mnuThongKe
            // 
            this.mnuThongKe.Name = "mnuThongKe";
            this.mnuThongKe.Size = new System.Drawing.Size(224, 26);
            this.mnuThongKe.Text = "Thống kê";
            this.mnuThongKe.Click += new System.EventHandler(this.mnuThongKe_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Quản lý trung tâm tin học";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuKhoaHoc;
        private System.Windows.Forms.ToolStripMenuItem mnuHocVien;
        private System.Windows.Forms.ToolStripMenuItem mnuGiangVien;
        private System.Windows.Forms.ToolStripMenuItem mnuLopHoc;
        private System.Windows.Forms.ToolStripMenuItem ghiDanhHọcViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kếtQuảHọcTậpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuThongKe;
    }
}