using System.Collections.Generic;
using QLTTTH.DAL.Repositories;
using QLTTTH.Entities.Entities;

namespace QLTTTH.BLL.Services
{
    public class KetQuaHocTapBLL
    {
        KetQuaHocTapDAL dal = new KetQuaHocTapDAL();

        public List<KetQuaHocTap> GetAll()
        {
            return dal.GetAll();
        }

        public void Save(KetQuaHocTap kq)
        {
            // TÍNH KẾT QUẢ
            decimal diemTB = (kq.DiemQT + kq.DiemCK) / 2;
            kq.KetQua = diemTB >= 5 ? "Đạt" : "Không đạt";

            dal.Save(kq);
        }

        public void Delete(int maHV, int maLop)
        {
            dal.Delete(maHV, maLop);
        }
    }
}
