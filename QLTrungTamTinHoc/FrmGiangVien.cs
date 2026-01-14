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
using QLTTTH.Entities.Entities;

namespace QLTrungTamTinHoc
{
    public partial class FrmGiangVien : Form
    {
        GiangVienBLL bll = new GiangVienBLL();
        int maGV = 0;
        public FrmGiangVien()
        {
            InitializeComponent();
        }
        private void ResetForm()
        {
            maGV = 0;
            txtTenGV.Text = "";
            txtDienThoai.Text = "";
            txtEmail.Text = "";
        }

        private void LoadData()
        {
            dgvGiangVien.DataSource = bll.GetAll();
            dgvGiangVien.ClearSelection();
            ResetForm();
        }

        private void FrmGiangVien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void dgvGiangVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvGiangVien.Rows[e.RowIndex];

                maGV = Convert.ToInt32(row.Cells["MaGV"].Value);
                txtTenGV.Text = row.Cells["TenGV"].Value.ToString();
                txtDienThoai.Text = row.Cells["DienThoai"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            GiangVien gv = new GiangVien
            {
                TenGV = txtTenGV.Text.Trim(),
                DienThoai = txtDienThoai.Text.Trim(),
                Email = txtEmail.Text.Trim()
            };

            if (bll.Insert(gv))
            {
                MessageBox.Show("Thêm giảng viên thành công!");
                LoadData();
            }
            else
            {
                MessageBox.Show("Tên giảng viên không được để trống!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (maGV == 0)
            {
                MessageBox.Show("Vui lòng chọn giảng viên cần sửa!");
                return;
            }

            GiangVien gv = new GiangVien
            {
                MaGV = maGV,
                TenGV = txtTenGV.Text.Trim(),
                DienThoai = txtDienThoai.Text.Trim(),
                Email = txtEmail.Text.Trim()
            };

            if (bll.Update(gv))
            {
                MessageBox.Show("Cập nhật thành công!");
                LoadData();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (maGV == 0)
            {
                MessageBox.Show("Vui lòng chọn giảng viên cần xóa!");
                return;
            }

            DialogResult dr = MessageBox.Show(
                "Bạn có chắc muốn xóa?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (dr == DialogResult.Yes)
            {
                bll.Delete(maGV);
                MessageBox.Show("Đã xóa!");
                LoadData();
            }
        }
    }
}
