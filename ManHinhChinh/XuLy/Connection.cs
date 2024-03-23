using System.Data.SqlClient;

namespace ManHinhChinh.XuLy
{
    internal class Connection
    {
        public static string stringConnection = @"Data Source=DESKTOP-OA1VINS\SQLEXPRESS;Initial Catalog=QLTHIETBI;Integrated Security=True;";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
