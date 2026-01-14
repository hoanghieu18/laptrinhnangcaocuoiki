using MySql.Data.MySqlClient;
using QLTTTH.DAL.Data;
using QLTTTH.Entities.Entities;
using System.Collections.Generic;

namespace QLTTTH.DAL.Repositories
{
    public class LopHocDAL
    {
        public List<LopHoc> GetAll()
        {
            List<LopHoc> list = new List<LopHoc>();

            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = @"
                SELECT l.MaLop, l.TenLop, l.LichHoc,
                       k.TenKhoaHoc, g.TenGV,
                       l.MaKhoaHoc, l.MaGV
                FROM LopHoc l
                JOIN KhoaHoc k ON l.MaKhoaHoc = k.MaKhoaHoc
                JOIN GiangVien g ON l.MaGV = g.MaGV";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    list.Add(new LopHoc
                    {
                        MaLop = rd.GetInt32("MaLop"),
                        TenLop = rd.GetString("TenLop"),
                        LichHoc = rd.GetString("LichHoc"),
                        TenKhoaHoc = rd.GetString("TenKhoaHoc"),
                        TenGV = rd.GetString("TenGV"),
                        MaKhoaHoc = rd.GetInt32("MaKhoaHoc"),
                        MaGV = rd.GetInt32("MaGV")
                    });
                }
            }
            return list;
        }

        public void Insert(LopHoc l)
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = @"INSERT INTO LopHoc(TenLop, MaKhoaHoc, MaGV, LichHoc)
                               VALUES(@Ten, @Khoa, @GV, @Lich)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Ten", l.TenLop);
                cmd.Parameters.AddWithValue("@Khoa", l.MaKhoaHoc);
                cmd.Parameters.AddWithValue("@GV", l.MaGV);
                cmd.Parameters.AddWithValue("@Lich", l.LichHoc);
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(LopHoc l)
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = @"UPDATE LopHoc 
                               SET TenLop=@Ten, MaKhoaHoc=@Khoa, MaGV=@GV, LichHoc=@Lich
                               WHERE MaLop=@Ma";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Ten", l.TenLop);
                cmd.Parameters.AddWithValue("@Khoa", l.MaKhoaHoc);
                cmd.Parameters.AddWithValue("@GV", l.MaGV);
                cmd.Parameters.AddWithValue("@Lich", l.LichHoc);
                cmd.Parameters.AddWithValue("@Ma", l.MaLop);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int ma)
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                MySqlCommand cmd =
                    new MySqlCommand("DELETE FROM LopHoc WHERE MaLop=@Ma", conn);
                cmd.Parameters.AddWithValue("@Ma", ma);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
