using QLTTTH.DAL.Repositories;
using QLTTTH.Entities.Entities;

namespace QLTTTH.BLL.Services
{
    public class UserBLL
    {
        UserDAL dal = new UserDAL();

        public User DangNhap(string user, string pass)
        {
            return dal.CheckLogin(user, pass);
        }
    }
}
