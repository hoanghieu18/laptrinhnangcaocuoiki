using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using QLTTTH.DAL.Data;
using QLTTTH.Entities.Entities;

namespace QLTTTH.DAL.Repositories
{
    public class HocVienDAL
    {
        // ================= LOAD DANH SÁCH =================
        public List<HocVien> GetAll()
        {
            List<HocVien> list = new List<HocVien>();

            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "SELECT * FROM HocVien";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    HocVien hv = new HocVien();

                    hv.MaHV = rd.GetInt32("MaHV");
                    hv.TenHV = rd.GetString("TenHV");

                    // FIX LỖI C# 7.3 (ÉP KIỂU RÕ RÀNG)
                    hv.NgaySinh = rd.IsDBNull(rd.GetOrdinal("NgaySinh"))
                        ? (DateTime?)null
                        : rd.GetDateTime("NgaySinh");

                    hv.DienThoai = rd.GetString("DienThoai");

                    list.Add(hv);
                }
            }
            return list;
        }

        // ================= THÊM =================
        public void Insert(HocVien hv)
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = @"INSERT INTO HocVien(TenHV, NgaySinh, DienThoai)
                               VALUES(@TenHV, @NgaySinh, @DienThoai)";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TenHV", hv.TenHV);
                cmd.Parameters.AddWithValue("@NgaySinh", hv.NgaySinh);
                cmd.Parameters.AddWithValue("@DienThoai", hv.DienThoai);

                cmd.ExecuteNonQuery();
            }
        }

        // ================= SỬA =================
        public void Update(HocVien hv)
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = @"UPDATE HocVien 
                               SET TenHV=@TenHV,
                                   NgaySinh=@NgaySinh,
                                   DienThoai=@DienThoai
                               WHERE MaHV=@MaHV";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TenHV", hv.TenHV);
                cmd.Parameters.AddWithValue("@NgaySinh", hv.NgaySinh);
                cmd.Parameters.AddWithValue("@DienThoai", hv.DienThoai);
                cmd.Parameters.AddWithValue("@MaHV", hv.MaHV);

                cmd.ExecuteNonQuery();
            }
        }

        // ================= XÓA =================
        public void Delete(int maHV)
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "DELETE FROM HocVien WHERE MaHV=@MaHV";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaHV", maHV);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
