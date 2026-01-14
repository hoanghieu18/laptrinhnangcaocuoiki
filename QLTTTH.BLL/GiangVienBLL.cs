using System.Collections.Generic;
using QLTTTH.DAL.Repositories;
using QLTTTH.Entities.Entities;

namespace QLTTTH.BLL.Services
{
    public class GiangVienBLL
    {
        GiangVienDAL dal = new GiangVienDAL();

        public List<GiangVien> GetAll()
        {
            return dal.GetAll();
        }

        public bool Insert(GiangVien gv)
        {
            if (string.IsNullOrWhiteSpace(gv.TenGV))
                return false;

            dal.Insert(gv);
            return true;
        }

        public bool Update(GiangVien gv)
        {
            if (gv.MaGV <= 0)
                return false;

            dal.Update(gv);
            return true;
        }

        public void Delete(int maGV)
        {
            dal.Delete(maGV);
        }
    }
}
