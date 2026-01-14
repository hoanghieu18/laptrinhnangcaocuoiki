using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using QLTTTH.DAL.Data;
using QLTTTH.Entities.Entities;

namespace QLTTTH.DAL.Repositories
{
    public class GhiDanhDAL
    {
        public List<GhiDanh> GetAll()
        {
            List<GhiDanh> list = new List<GhiDanh>();

            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = @"
                SELECT g.MaHV, h.TenHV, g.MaLop, l.TenLop, g.NgayDangKy
                FROM GhiDanh g
                JOIN HocVien h ON g.MaHV = h.MaHV
                JOIN LopHoc l ON g.MaLop = l.MaLop";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    list.Add(new GhiDanh
                    {
                        MaHV = rd.GetInt32("MaHV"),
                        TenHV = rd.GetString("TenHV"),
                        MaLop = rd.GetInt32("MaLop"),
                        TenLop = rd.GetString("TenLop"),
                        NgayDangKy = rd.GetDateTime("NgayDangKy")
                    });
                }
            }
            return list;
        }

        public bool GhiDanh(int maHV, int maLop, DateTime ngayDK)
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                MySqlTransaction tran = conn.BeginTransaction();

                try
                {
                    string check = "SELECT COUNT(*) FROM GhiDanh WHERE MaHV=@hv AND MaLop=@lop";
                    MySqlCommand cmdCheck = new MySqlCommand(check, conn, tran);
                    cmdCheck.Parameters.AddWithValue("@hv", maHV);
                    cmdCheck.Parameters.AddWithValue("@lop", maLop);

                    if (Convert.ToInt32(cmdCheck.ExecuteScalar()) > 0)
                    {
                        tran.Rollback();
                        return false;
                    }

                    string insert = @"INSERT INTO GhiDanh(MaHV, MaLop, NgayDangKy)
                                      VALUES(@hv,@lop,@ngay)";
                    MySqlCommand cmd = new MySqlCommand(insert, conn, tran);
                    cmd.Parameters.AddWithValue("@hv", maHV);
                    cmd.Parameters.AddWithValue("@lop", maLop);
                    cmd.Parameters.AddWithValue("@ngay", ngayDK);
                    cmd.ExecuteNonQuery();

                    tran.Commit();
                    return true;
                }
                catch
                {
                    tran.Rollback();
                    throw;
                }
            }
        }
    }
}
