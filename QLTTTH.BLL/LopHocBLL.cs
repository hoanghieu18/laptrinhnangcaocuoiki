using QLTTTH.DAL.Repositories;
using QLTTTH.Entities.Entities;
using System.Collections.Generic;

namespace QLTTTH.BLL.Services
{
    public class LopHocBLL
    {
        LopHocDAL dal = new LopHocDAL();

        public List<LopHoc> GetAll() => dal.GetAll();
        public void Insert(LopHoc l) => dal.Insert(l);
        public void Update(LopHoc l) => dal.Update(l);
        public void Delete(int ma) => dal.Delete(ma);
    }
}
