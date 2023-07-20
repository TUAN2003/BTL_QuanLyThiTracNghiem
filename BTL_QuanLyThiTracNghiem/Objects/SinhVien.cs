using BTL_QuanLyThiTracNghiem.Constants;
using BTL_QuanLyThiTracNghiem.QuerysDB;
using System;
using System.Data.SqlClient;

namespace BTL_QuanLyThiTracNghiem.Objects
{
    public class SinhVien
    {
        private string m_MaSinhVien;
        private string m_TenSinhVien;
        private string m_GioiTinh;
        private DateTime m_NgaySinh;
        private string m_LopHanhChinh;
        public string MaSinhVien { get { return m_MaSinhVien; } set { m_MaSinhVien = value; } }
        public string TenSinhVien { get { return m_TenSinhVien; } set { m_TenSinhVien = value; } }
        public string GioiTinh { get { return m_GioiTinh; } set { m_GioiTinh = value; } }
        public DateTime NgaySinh { get { return m_NgaySinh; } set { m_NgaySinh = value; } }
        public string LopHanhChinh { get { return m_LopHanhChinh; } set { m_LopHanhChinh = value; } }

        public SinhVien() { }
        public SinhVien(string maSinhVien)
            => LayVeThongTinSinhVien(maSinhVien);
        public void LayVeThongTinSinhVien(string maSinhVien)
        {
            m_MaSinhVien = maSinhVien;
            SqlConnection cnn = OnLyConnectDB.Instance();
            string query = string.Format("select * from tblSinhVien where vcMaSinhVien='{0}'", maSinhVien);
            using (SqlCommand cmd = new SqlCommand(query, cnn))
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cnn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    rd.Read();
                    m_TenSinhVien = rd["nvcTenSinhVien"] as string;
                    m_GioiTinh = rd["nvcGioiTinh"] as string;
                    m_NgaySinh = (DateTime)rd["dtNgaySinh"];
                    m_LopHanhChinh = rd["vcMaLopHanhChinh"] as string;
                }
                cnn.Close();
            }
        }
    }
}
