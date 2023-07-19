using System.Data.SqlClient;

namespace BTL_QuanLyThiTracNghiem.QuerysDB
{
    public sealed class OnLyConnectDB
    {
        private static SqlConnection g_instance;

        public static SqlConnection Instance(string strConnect)
        {
            if (g_instance == null)
                g_instance = new SqlConnection(strConnect);
            return g_instance;
        }
        public OnLyConnectDB(string strConnect)
            =>Instance(strConnect);
    }
}
