using System;
using System.Collections.Generic;
using QLTTTH.DAL.Repositories;
using QLTTTH.Entities.Entities;

namespace QLTTTH.BLL.Services
{
    public class GhiDanhBLL
    {
        GhiDanhDAL dal = new GhiDanhDAL();

        public List<GhiDanh> GetAll()
        {
            return dal.GetAll();
        }

        public bool GhiDanh(int maHV, int maLop, DateTime ngayDK)
        {
            return dal.GhiDanh(maHV, maLop, ngayDK);
        }
    }
}
