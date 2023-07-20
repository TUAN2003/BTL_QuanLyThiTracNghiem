using System.Data.SqlClient;

namespace BTL_QuanLyThiTracNghiem.QuerysDB
{
    public sealed class OnLyConnectDB
    {
        private static SqlConnection g_instance;

        public static SqlConnection Instance()
        {
            if (g_instance == null)
                g_instance = new SqlConnection(Constants.ConnectionInfo._CONNECTION_STRING);
            return g_instance;
        }
        private OnLyConnectDB() { }
    }
}
