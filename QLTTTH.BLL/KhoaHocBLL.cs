using System.Collections.Generic;
using QLTTTH.DAL.Repositories;
using QLTTTH.Entities.Entities;

namespace QLTTTH.BLL.Services
{
    public class KhoaHocBLL
    {
        KhoaHocDAL dal = new KhoaHocDAL();

        public List<KhoaHoc> GetAll()
        {
            return dal.GetAll();
        }

        public bool Insert(KhoaHoc kh)
        {
            if (!Validate(kh)) return false;
            dal.Insert(kh);
            return true;
        }

        public bool Update(KhoaHoc kh)
        {
            if (kh.MaKhoaHoc <= 0) return false;
            if (!Validate(kh)) return false;
            dal.Update(kh);
            return true;
        }

        public bool Delete(int ma)
        {
            if (ma <= 0) return false;
            dal.Delete(ma);
            return true;
        }

        public List<KhoaHoc> Search(string keyword)
        {
            var list = dal.GetAll();
            if (string.IsNullOrWhiteSpace(keyword)) return list;

            keyword = keyword.ToLower();
            return list.FindAll(k => k.TenKhoaHoc.ToLower().Contains(keyword));
        }

        private bool Validate(KhoaHoc kh)
        {
            if (string.IsNullOrWhiteSpace(kh.TenKhoaHoc)) return false;
            if (kh.HocPhi <= 0) return false;
            if (kh.ThoiLuong <= 0) return false; // ✅
            return true;
        }
    }
}
