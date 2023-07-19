using System;
using System.Data;
using System.Data.SqlClient;
using BTL_QuanLyThiTracNghiem.Constants;

namespace BTL_QuanLyThiTracNghiem.QuerysDB
{
    public static class SelectDB
    {
        public static DataTable GetTable
            (string query, CommandType cmdType = CommandType.Text, string[] listParam = null, object[] values = null)
        {
            DataTable table = new DataTable();
            SqlConnection cnn = OnLyConnectDB.Instance(ConnectionInfo._CONNECTION_STRING);
            using (SqlCommand cmd = new SqlCommand(query, cnn))
            {
                cmd.CommandType = cmdType;
                using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                {
                    if (listParam != null)
                    {
                        for (int i = 0; i < values.Length; i++)
                            cmd.Parameters.AddWithValue(listParam[i], values[i]);
                    }
                    sda.Fill(table);
                }
            }
            return table;
        }

        public static int GetRandomExamCode(string maMonThi)
        {
            DataTable dataTable = GetTable("sp_danhSachMaDeTheoMonThi", CommandType.StoredProcedure, new string[] { "@vcMaMonThi" }, new object[] { maMonThi });
            int rowCount = dataTable.Rows.Count;
            if (rowCount <= 0)
                return -1;
            int index = new Random().Next(0, rowCount);
            return (int)dataTable.Rows[index]["iMaDeThi"];
        }

        public static DataTable GetTableQuestion(int maDeThi)
        {
            DataTable dtable = new DataTable();
            if (maDeThi == -1)
                return null;
            SqlConnection cnn = OnLyConnectDB.Instance(ConnectionInfo._CONNECTION_STRING);

            using (SqlDataAdapter sda = new SqlDataAdapter("sp_danhSachCauHoiTheoMaDeThi", cnn))
            {
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                sda.SelectCommand.Parameters.AddWithValue("@iMaDeThi", maDeThi);
                sda.Fill(dtable);
            }

            dtable.DefaultView.Sort = "iDoKho ASC";
            return dtable;
        }
        public static object GetAValue
            (string query, CommandType cmdtype = CommandType.Text, string[] listParam = null, object[] values = null)
        {
            object value = null;
            SqlConnection cnn = OnLyConnectDB.Instance(ConnectionInfo._CONNECTION_STRING);

            using (SqlCommand cmd = new SqlCommand(query, cnn))
            {
                cmd.CommandType = cmdtype;
                if (listParam != null)
                {
                    for (int i = 0; i < values.Length; i++)
                        cmd.Parameters.AddWithValue(listParam[i], values[i]);
                }
                cnn.Open();
                value = cmd.ExecuteScalar();
                cnn.Close();
            }

            return value;
        }
    }
}
