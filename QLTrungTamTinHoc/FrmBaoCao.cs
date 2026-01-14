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
    public partial class FrmBaoCao : Form
    {
        BaoCaoBLL baoCaoBLL = new BaoCaoBLL();
        public FrmBaoCao()
        {
            InitializeComponent();
        }

        private void FrmBaoCao_Load(object sender, EventArgs e)
        {
            LoadBaoCao();
        }
        private void LoadBaoCao()
        {
            BaoCaoTongHop bc = baoCaoBLL.LayBaoCaoTongHop();

            lblSoKhoaHoc.Text = "Số khóa học: " + bc.SoKhoaHoc;
            lblSoLop.Text = "Số lớp học: " + bc.SoLopHoc;
            lblSoHocVien.Text = "Số học viên: " + bc.SoHocVien;
            lblSoGiangVien.Text = "Số giảng viên: " + bc.SoGiangVien;
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            LoadBaoCao();
        }
    }
}
