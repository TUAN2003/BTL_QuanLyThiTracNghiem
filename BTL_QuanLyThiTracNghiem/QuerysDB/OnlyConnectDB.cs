using System.Data.SqlClient;

namespace BTL_QuanLyThiTracNghiem.QuerysDB
{
    public sealed class OnLyConnectDB
    {
        private static SqlConnection instance;

        public static SqlConnection Instance()
        {
            if (instance == null)
                instance = new SqlConnection(Constants.ConnectionInfo._CONNECTION_STRING);
            return instance;
        }
        private OnLyConnectDB() { }
    }
}
