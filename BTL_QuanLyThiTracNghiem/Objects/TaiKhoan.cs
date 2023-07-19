using BTL_QuanLyThiTracNghiem.Constants;
using BTL_QuanLyThiTracNghiem.QuerysDB;
using System.Data.SqlClient;
namespace BTL_QuanLyThiTracNghiem.Objects
{
    public class TaiKhoan
    {
        public string TenDangNhap;
        public string MatKhau;
        public int QuyenTruyCap;
        public string MaSinhVien;

        public bool LayVeThongTinTaiKhoan(string tenDangNhap, string matKhau)
        {
            bool ketQua;
            SqlConnection cnn = OnLyConnectDB.Instance(ConnectionInfo._CONNECTION_STRING);

            using (SqlCommand cmd = new SqlCommand("sp_dangNhap", cnn))
            {
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@vcTenDangNhap", tenDangNhap);
                cmd.Parameters.AddWithValue("@vcMatKhau", matKhau);
                cnn.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                if (ketQua = rd.Read())
                {
                    this.TenDangNhap = tenDangNhap;
                    this.MatKhau = matKhau;
                    this.QuyenTruyCap = (int)rd["iQuyenTruyCap"];
                    this.MaSinhVien = (QuyenTruyCap == 2 ? (string)rd["vcMaSinhVien"] : null);
                }
                cnn.Close();
            }
            return ketQua;
        }
    }
}
