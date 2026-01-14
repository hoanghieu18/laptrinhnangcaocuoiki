using QLTTTH.BLL;
using QLTTTH.BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTrungTamTinHoc
{
    public partial class FrmGhiDanh : Form
    {
        HocVienBLL hocVienBLL = new HocVienBLL();
        LopHocBLL lopHocBLL = new LopHocBLL();
        GhiDanhBLL ghiDanhBLL = new GhiDanhBLL();
        public FrmGhiDanh()
        {
            InitializeComponent();
        }

        private void FrmGhiDanh_Load(object sender, EventArgs e)
        {
            LoadCombo();
            LoadData();
        }
        private void LoadCombo()
        {
            cboHocVien.DataSource = hocVienBLL.GetAll();
            cboHocVien.DisplayMember = "TenHV";
            cboHocVien.ValueMember = "MaHV";
            cboHocVien.SelectedIndex = -1;

            cboLopHoc.DataSource = lopHocBLL.GetAll();
            cboLopHoc.DisplayMember = "TenLop";
            cboLopHoc.ValueMember = "MaLop";
            cboLopHoc.SelectedIndex = -1;
        }
        private void LoadData()
        {
            dgvGhiDanh.DataSource = ghiDanhBLL.GetAll();
            dgvGhiDanh.ClearSelection();
        }

        private void btnGhiDanh_Click(object sender, EventArgs e)
        {
            if (cboHocVien.SelectedIndex == -1 || cboLopHoc.SelectedIndex == -1)
            {
                MessageBox.Show("Chọn học viên và lớp học");
                return;
            }

            bool ok = ghiDanhBLL.GhiDanh(
                (int)cboHocVien.SelectedValue,
                (int)cboLopHoc.SelectedValue,
                dtpNgayDangKy.Value
            );

            MessageBox.Show(ok ? "Ghi danh thành công" : "Học viên đã ghi danh lớp này");
            LoadData();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            cboHocVien.SelectedIndex = -1;
            cboLopHoc.SelectedIndex = -1;
            dtpNgayDangKy.Value = DateTime.Today;
        }
    }
}
