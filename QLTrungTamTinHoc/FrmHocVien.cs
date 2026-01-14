using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLTTTH.BLL;
using QLTTTH.Entities.Entities;



namespace QLTrungTamTinHoc
{
    public partial class FrmHocVien : Form
    {
        HocVienBLL bll = new HocVienBLL();
        public FrmHocVien()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            dgvHocVien.DataSource = bll.GetAll();
        }

        private void FrmHocVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HocVien hv = new HocVien
            {
                TenHV = txtTenHV.Text,
                NgaySinh = dtpNgaySinh.Value,
                DienThoai = txtDienThoai.Text
            };

            bll.Insert(hv);
            LoadData();
        }

        private void dgvHocVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtTenHV.Text = dgvHocVien.Rows[e.RowIndex].Cells["TenHV"].Value.ToString();
                dtpNgaySinh.Value = Convert.ToDateTime(dgvHocVien.Rows[e.RowIndex].Cells["NgaySinh"].Value);
                txtDienThoai.Text = dgvHocVien.Rows[e.RowIndex].Cells["DienThoai"].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            int ma = Convert.ToInt32(dgvHocVien.CurrentRow.Cells["MaHV"].Value);

            HocVien hv = new HocVien
            {
                MaHV = ma,
                TenHV = txtTenHV.Text,
                NgaySinh = dtpNgaySinh.Value,
                DienThoai = txtDienThoai.Text
            };

            bll.Update(hv);
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int ma = Convert.ToInt32(dgvHocVien.CurrentRow.Cells["MaHV"].Value);
            bll.Delete(ma);
            LoadData();
        }
    }
}
