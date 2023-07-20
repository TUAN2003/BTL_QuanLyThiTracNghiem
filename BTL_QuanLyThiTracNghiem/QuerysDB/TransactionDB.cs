using BTL_QuanLyThiTracNghiem.Constants;
using System.Data.SqlClient;
using System.Data;

namespace BTL_QuanLyThiTracNghiem.QuerysDB
{
    public static class TransactionDB
    {
        public static int Transaction
            (string query, CommandType cmdtype = CommandType.Text, string[] listparam = null, object[] values = null)
        {
            int res = 0;
            SqlConnection cnn = OnLyConnectDB.Instance();
            using (SqlCommand cmd = new SqlCommand(query, cnn))
            {
                cmd.CommandType = cmdtype;
                if (listparam != null)
                {
                    for (int i = 0; i < values.Length; i++)
                        cmd.Parameters.AddWithValue(listparam[i], values[i]);
                }
                cnn.Open();
                res = cmd.ExecuteNonQuery();
                cnn.Close();
            }
            return res;
        }
    }
}
