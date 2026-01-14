using System.Collections.Generic;
using MySql.Data.MySqlClient;
using QLTTTH.DAL.Data;
using QLTTTH.Entities.Entities;

namespace QLTTTH.DAL.Repositories
{
    public class GiangVienDAL
    {
        public List<GiangVien> GetAll()
        {
            List<GiangVien> list = new List<GiangVien>();

            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "SELECT * FROM GiangVien";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    list.Add(new GiangVien
                    {
                        MaGV = rd.GetInt32("MaGV"),
                        TenGV = rd.GetString("TenGV"),
                        DienThoai = rd.GetString("DienThoai"),
                        Email = rd.GetString("Email")
                    });
                }
            }
            return list;
        }

        public void Insert(GiangVien gv)
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = @"INSERT INTO GiangVien(TenGV, DienThoai, Email)
                               VALUES(@Ten, @DT, @Email)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Ten", gv.TenGV);
                cmd.Parameters.AddWithValue("@DT", gv.DienThoai);
                cmd.Parameters.AddWithValue("@Email", gv.Email);
                cmd.ExecuteNonQuery();
            }
        }

        public void Update(GiangVien gv)
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = @"UPDATE GiangVien 
                               SET TenGV=@Ten, DienThoai=@DT, Email=@Email
                               WHERE MaGV=@Ma";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Ten", gv.TenGV);
                cmd.Parameters.AddWithValue("@DT", gv.DienThoai);
                cmd.Parameters.AddWithValue("@Email", gv.Email);
                cmd.Parameters.AddWithValue("@Ma", gv.MaGV);
                cmd.ExecuteNonQuery();
            }
        }

        public void Delete(int maGV)
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "DELETE FROM GiangVien WHERE MaGV=@Ma";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Ma", maGV);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
