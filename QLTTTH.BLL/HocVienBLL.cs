using System.Collections.Generic;
using QLTTTH.DAL.Repositories;
using QLTTTH.Entities.Entities;

namespace QLTTTH.BLL
{
    public class HocVienBLL
    {
        HocVienDAL dal = new HocVienDAL();

        public List<HocVien> GetAll() => dal.GetAll();
        public void Insert(HocVien hv) => dal.Insert(hv);
        public void Update(HocVien hv) => dal.Update(hv);
        public void Delete(int ma) => dal.Delete(ma);
    }
}
