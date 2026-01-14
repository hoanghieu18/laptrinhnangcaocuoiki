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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void khóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKhoaHoc frm = new FrmKhoaHoc();
            frm.Show();
        }

        private void mnuHocVien_Click(object sender, EventArgs e)
        {
            FrmHocVien f = new FrmHocVien();
            f.Show();
        }

        private void mnuGiangVien_Click(object sender, EventArgs e)
        {
            FrmGiangVien frm = new FrmGiangVien();
            frm.Show();
        }

        private void mnuLopHoc_Click(object sender, EventArgs e)
        {
            FrmLopHoc frm = new FrmLopHoc();
            frm.Show();
        }

        private void ghiDanhHọcViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGhiDanh frm = new FrmGhiDanh();
            frm.Show();
        }

        private void kếtQuảHọcTậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmKetQuaHocTap frm = new FrmKetQuaHocTap();
            frm.Show();
        }

        private void mnuThongKe_Click(object sender, EventArgs e)
        {
            FrmBaoCao f = new FrmBaoCao();
            f.ShowDialog();
        }
    }
}
