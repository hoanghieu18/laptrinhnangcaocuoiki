using System.Collections.Generic;
using MySql.Data.MySqlClient;
using QLTTTH.DAL.Data;
using QLTTTH.Entities.Entities;

namespace QLTTTH.DAL.Repositories
{
    public class KhoaHocDAL
    {
        // LẤY DANH SÁCH
        public List<KhoaHoc> GetAll()
        {
            List<KhoaHoc> list = new List<KhoaHoc>();

            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "SELECT * FROM KhoaHoc";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    KhoaHoc kh = new KhoaHoc
                    {
                        MaKhoaHoc = reader.GetInt32("MaKhoaHoc"),
                        TenKhoaHoc = reader.GetString("TenKhoaHoc"),
                        HocPhi = reader.GetInt32("HocPhi"),
                        ThoiLuong = reader.GetInt32("ThoiLuong"), // ✅
                        MoTa = reader.IsDBNull(reader.GetOrdinal("MoTa"))
                               ? "" : reader.GetString("MoTa")
                    };
                    list.Add(kh);
                }
            }
            return list;
        }

        // THÊM
        public void Insert(KhoaHoc kh)
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = @"INSERT INTO KhoaHoc
                               (TenKhoaHoc, HocPhi, ThoiLuong, MoTa)
                               VALUES (@Ten, @HocPhi, @ThoiLuong, @MoTa)";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Ten", kh.TenKhoaHoc);
                cmd.Parameters.AddWithValue("@HocPhi", kh.HocPhi);
                cmd.Parameters.AddWithValue("@ThoiLuong", kh.ThoiLuong); // ✅
                cmd.Parameters.AddWithValue("@MoTa", kh.MoTa);
                cmd.ExecuteNonQuery();
            }
        }

        // SỬA
        public void Update(KhoaHoc kh)
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = @"UPDATE KhoaHoc 
                               SET TenKhoaHoc=@Ten,
                                   HocPhi=@HocPhi,
                                   ThoiLuong=@ThoiLuong,
                                   MoTa=@MoTa
                               WHERE MaKhoaHoc=@Ma";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Ten", kh.TenKhoaHoc);
                cmd.Parameters.AddWithValue("@HocPhi", kh.HocPhi);
                cmd.Parameters.AddWithValue("@ThoiLuong", kh.ThoiLuong); // ✅
                cmd.Parameters.AddWithValue("@MoTa", kh.MoTa);
                cmd.Parameters.AddWithValue("@Ma", kh.MaKhoaHoc);
                cmd.ExecuteNonQuery();
            }
        }

        // XÓA
        public void Delete(int maKhoaHoc)
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "DELETE FROM KhoaHoc WHERE MaKhoaHoc=@Ma";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Ma", maKhoaHoc);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
