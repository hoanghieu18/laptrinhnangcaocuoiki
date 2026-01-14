using QLTTTH.BLL.Services;
using QLTTTH.Entities.Entities;
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
    public partial class FrmLopHoc : Form
    {
        LopHocBLL lopHocBLL = new LopHocBLL();
        KhoaHocBLL khoaHocBLL = new KhoaHocBLL();
        GiangVienBLL giangVienBLL = new GiangVienBLL();

        int maLop = 0;
        public FrmLopHoc()
        {
            InitializeComponent();
        }
        private void FrmLopHoc_Load(object sender, EventArgs e)
        {
            LoadComboBox();
            LoadData();
        }
        private void LoadComboBox()
        {
            // Khóa học
            cboKhoaHoc.DataSource = khoaHocBLL.GetAll();
            cboKhoaHoc.DisplayMember = "TenKhoaHoc";
            cboKhoaHoc.ValueMember = "MaKhoaHoc";
            cboKhoaHoc.SelectedIndex = -1;

            // Giảng viên
            cboGiangVien.DataSource = giangVienBLL.GetAll();
            cboGiangVien.DisplayMember = "TenGV";
            cboGiangVien.ValueMember = "MaGV";
            cboGiangVien.SelectedIndex = -1;
        }
        private void LoadData()
        {
            dgvLopHoc.DataSource = lopHocBLL.GetAll();
            dgvLopHoc.ClearSelection();
            ResetForm();
        }
        private void ResetForm()
        {
            maLop = 0;
            txtTenLop.Text = "";
            txtLichHoc.Text = "";
            cboKhoaHoc.SelectedIndex = -1;
            cboGiangVien.SelectedIndex = -1;
        }

        private void dgvLopHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvLopHoc.Rows[e.RowIndex];

            maLop = Convert.ToInt32(row.Cells["MaLop"].Value);
            txtTenLop.Text = row.Cells["TenLop"].Value.ToString();
            txtLichHoc.Text = row.Cells["LichHoc"].Value.ToString();

            cboKhoaHoc.SelectedValue = row.Cells["MaKhoaHoc"].Value;
            cboGiangVien.SelectedValue = row.Cells["MaGV"].Value;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            LopHoc lh = new LopHoc
            {
                TenLop = txtTenLop.Text,
                MaKhoaHoc = (int)cboKhoaHoc.SelectedValue,
                MaGV = (int)cboGiangVien.SelectedValue,
                LichHoc = txtLichHoc.Text
            };

            lopHocBLL.Insert(lh);
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (maLop == 0) return;

            LopHoc lh = new LopHoc
            {
                MaLop = maLop,
                TenLop = txtTenLop.Text,
                MaKhoaHoc = (int)cboKhoaHoc.SelectedValue,
                MaGV = (int)cboGiangVien.SelectedValue,
                LichHoc = txtLichHoc.Text
            };

            lopHocBLL.Update(lh);
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (maLop == 0) return;

            lopHocBLL.Delete(maLop);
            LoadData();
        }
    }

}
