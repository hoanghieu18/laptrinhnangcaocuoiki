using MySql.Data.MySqlClient;
using QLTTTH.DAL.Data;
using QLTTTH.Entities.Entities;

namespace QLTTTH.DAL.Repositories
{
    public class BaoCaoDAL
    {
        public BaoCaoTongHop LayBaoCaoTongHop()
        {
            BaoCaoTongHop bc = new BaoCaoTongHop();

            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                // Khóa học
                MySqlCommand cmd1 = new MySqlCommand(
                    "SELECT COUNT(*) FROM KhoaHoc", conn);
                bc.SoKhoaHoc = int.Parse(cmd1.ExecuteScalar().ToString());

                // Lớp học
                MySqlCommand cmd2 = new MySqlCommand(
                    "SELECT COUNT(*) FROM LopHoc", conn);
                bc.SoLopHoc = int.Parse(cmd2.ExecuteScalar().ToString());

                // Học viên
                MySqlCommand cmd3 = new MySqlCommand(
                    "SELECT COUNT(*) FROM HocVien", conn);
                bc.SoHocVien = int.Parse(cmd3.ExecuteScalar().ToString());

                // Giảng viên
                MySqlCommand cmd4 = new MySqlCommand(
                    "SELECT COUNT(*) FROM GiangVien", conn);
                bc.SoGiangVien = int.Parse(cmd4.ExecuteScalar().ToString());
            }

            return bc;
        }
    }
}
