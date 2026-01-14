using System.Collections.Generic;
using MySql.Data.MySqlClient;
using QLTTTH.DAL.Data;
using QLTTTH.Entities.Entities;

namespace QLTTTH.DAL.Repositories
{
    public class KetQuaHocTapDAL
    {
        // LOAD DANH SÁCH
        public List<KetQuaHocTap> GetAll()
        {
            List<KetQuaHocTap> list = new List<KetQuaHocTap>();

            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "SELECT * FROM KetQuaHocTap";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataReader rd = cmd.ExecuteReader();

                while (rd.Read())
                {
                    KetQuaHocTap kq = new KetQuaHocTap
                    {
                        MaHV = rd.GetInt32("MaHV"),
                        MaLop = rd.GetInt32("MaLop"),
                        DiemQT = rd.GetDecimal("DiemQT"),
                        DiemCK = rd.GetDecimal("DiemCK"),
                        KetQua = rd.GetString("KetQua")
                    };
                    list.Add(kq);
                }
            }
            return list;
        }

        // THÊM / CẬP NHẬT (UPSERT)
        public void Save(KetQuaHocTap kq)
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = @"
                INSERT INTO KetQuaHocTap(MaHV, MaLop, DiemQT, DiemCK, KetQua)
                VALUES (@MaHV, @MaLop, @DiemQT, @DiemCK, @KetQua)
                ON DUPLICATE KEY UPDATE
                    DiemQT=@DiemQT,
                    DiemCK=@DiemCK,
                    KetQua=@KetQua";

                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaHV", kq.MaHV);
                cmd.Parameters.AddWithValue("@MaLop", kq.MaLop);
                cmd.Parameters.AddWithValue("@DiemQT", kq.DiemQT);
                cmd.Parameters.AddWithValue("@DiemCK", kq.DiemCK);
                cmd.Parameters.AddWithValue("@KetQua", kq.KetQua);

                cmd.ExecuteNonQuery();
            }
        }

        // XÓA
        public void Delete(int maHV, int maLop)
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = "DELETE FROM KetQuaHocTap WHERE MaHV=@MaHV AND MaLop=@MaLop";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@MaHV", maHV);
                cmd.Parameters.AddWithValue("@MaLop", maLop);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
