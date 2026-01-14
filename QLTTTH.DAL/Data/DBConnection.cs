using MySql.Data.MySqlClient;

namespace QLTTTH.DAL.Data
{
    public class DBConnection
    {
        private static string connectionString =
            "Server=localhost;Database=qltrungtamtinhoc;Uid=root;Pwd=18102005q;";

        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
