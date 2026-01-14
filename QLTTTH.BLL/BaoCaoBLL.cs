using QLTTTH.DAL.Repositories;
using QLTTTH.Entities.Entities;

namespace QLTTTH.BLL.Services
{
    public class BaoCaoBLL
    {
        BaoCaoDAL dal = new BaoCaoDAL();

        public BaoCaoTongHop LayBaoCaoTongHop()
        {
            return dal.LayBaoCaoTongHop();
        }
    }
}
