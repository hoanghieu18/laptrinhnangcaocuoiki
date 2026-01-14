using MySql.Data.MySqlClient;
using QLTTTH.DAL.Data;
using QLTTTH.Entities.Entities;

namespace QLTTTH.DAL.Repositories
{
    public class UserDAL
    {
        public User CheckLogin(string username, string password)
        {
            using (MySqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();
                string sql = @"SELECT * FROM User 
                               WHERE TenDangNhap=@u AND MatKhau=@p";
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@u", username);
                cmd.Parameters.AddWithValue("@p", password);

                MySqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    return new User
                    {
                        MaUser = reader.GetInt32("MaUser"),
                        TenDangNhap = reader.GetString("TenDangNhap"),
                        VaiTro = reader.GetString("VaiTro")
                    };
                }
            }
            return null;
        }
    }
}
