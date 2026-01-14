using QLTTTH.BLL;
using QLTTTH.BLL.Services;
using QLTTTH.Entities;
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
    public partial class FrmKhoaHoc : Form
    {
        KhoaHocBLL bll = new KhoaHocBLL();

        public FrmKhoaHoc()
        {
            InitializeComponent();
        }

        private void FrmKhoaHoc_Load(object sender, EventArgs e)
        {
            dgvKhoaHoc.DataSource = bll.GetAll();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            KhoaHoc kh = new KhoaHoc
            {
                TenKhoaHoc = txtTenKH.Text,
                HocPhi = int.Parse(txtHocPhi.Text),
                ThoiLuong = int.Parse(txtThoiLuong.Text), // ✅
                MoTa = txtMoTa.Text
            };

            if (bll.Insert(kh))
            {
                MessageBox.Show("Thêm thành công");
                dgvKhoaHoc.DataSource = bll.GetAll();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            KhoaHoc kh = new KhoaHoc
            {
                MaKhoaHoc = int.Parse(txtMaKH.Text),
                TenKhoaHoc = txtTenKH.Text,
                HocPhi = int.Parse(txtHocPhi.Text),
                ThoiLuong = int.Parse(txtThoiLuong.Text), // ✅
                MoTa = txtMoTa.Text
            };

            if (bll.Update(kh))
            {
                MessageBox.Show("Cập nhật thành công");
                dgvKhoaHoc.DataSource = bll.GetAll();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int ma = int.Parse(txtMaKH.Text);

            if (bll.Delete(ma))
            {
                MessageBox.Show("Xóa thành công");
                dgvKhoaHoc.DataSource = bll.GetAll();
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }
        }

        private void dgvKhoaHoc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = dgvKhoaHoc.Rows[e.RowIndex];
                txtMaKH.Text = row.Cells["MaKhoaHoc"].Value.ToString();
                txtTenKH.Text = row.Cells["TenKhoaHoc"].Value.ToString();
                txtHocPhi.Text = row.Cells["HocPhi"].Value.ToString();
                txtThoiLuong.Text = row.Cells["ThoiLuong"].Value.ToString(); // ✅
                txtMoTa.Text = row.Cells["MoTa"].Value.ToString();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dgvKhoaHoc.DataSource = bll.Search(txtTenKH.Text);
        }
    }
}
