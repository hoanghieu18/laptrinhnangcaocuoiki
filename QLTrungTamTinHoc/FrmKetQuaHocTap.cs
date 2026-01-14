using QLTTTH.BLL;
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
    public partial class FrmKetQuaHocTap : Form
    {
        KetQuaHocTapBLL kqBLL = new KetQuaHocTapBLL();
        HocVienBLL hvBLL = new HocVienBLL();
        LopHocBLL lopBLL = new LopHocBLL();

        public FrmKetQuaHocTap()
        {
            InitializeComponent();
        }

        private void FrmKetQuaHocTap_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            cboHocVien.DataSource = hvBLL.GetAll();
            cboHocVien.DisplayMember = "TenHV";
            cboHocVien.ValueMember = "MaHV";

            cboLopHoc.DataSource = lopBLL.GetAll();
            cboLopHoc.DisplayMember = "TenLop";
            cboLopHoc.ValueMember = "MaLop";

            dgvKetQua.DataSource = kqBLL.GetAll();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            KetQuaHocTap kq = new KetQuaHocTap
            {
                MaHV = (int)cboHocVien.SelectedValue,
                MaLop = (int)cboLopHoc.SelectedValue,
                DiemQT = decimal.Parse(txtDiemQT.Text),
                DiemCK = decimal.Parse(txtDiemCK.Text)
            };

            kqBLL.Save(kq);
            LoadData();
            MessageBox.Show("Đã lưu kết quả");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            kqBLL.Delete(
        (int)cboHocVien.SelectedValue,
        (int)cboLopHoc.SelectedValue
    );
            LoadData();
        }

        private void btnMoi_Click(object sender, EventArgs e)
        {
            txtDiemQT.Clear();
            txtDiemCK.Clear();
        }

        private void dgvKetQua_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                cboHocVien.SelectedValue = dgvKetQua.Rows[e.RowIndex].Cells["MaHV"].Value;
                cboLopHoc.SelectedValue = dgvKetQua.Rows[e.RowIndex].Cells["MaLop"].Value;
                txtDiemQT.Text = dgvKetQua.Rows[e.RowIndex].Cells["DiemQT"].Value.ToString();
                txtDiemCK.Text = dgvKetQua.Rows[e.RowIndex].Cells["DiemCK"].Value.ToString();
            }
        }
    }
}
