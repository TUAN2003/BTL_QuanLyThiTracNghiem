using BTL_QuanLyThiTracNghiem.Constants;
using BTL_QuanLyThiTracNghiem.QuerysDB;
using System;
using System.Data.SqlClient;

namespace BTL_QuanLyThiTracNghiem.Objects
{
    public class MonThi
    {
        private string m_maMonThi;
        private string m_tenMonThi;
        private int m_soTinChi;
        private string m_hocKy;
        private int m_soLuongCau;
        public string MaMonThi { get { return m_maMonThi; } set { m_maMonThi = value; } }
        public string TenMonThi { get { return m_tenMonThi; } set { m_tenMonThi = value; } }
        public string HocKy { get { return m_hocKy; } set { m_hocKy = value; } }
        public int SoTinChi
        {
            get { return m_soTinChi; }
            set => m_soTinChi = value;
        }
        public int SoCauHoi
        {
            get => m_soLuongCau;
            set => m_soLuongCau = value;
        }
        public MonThi(string maMonThi)
            => LayVeThongTinMonThi(maMonThi);
        public void LayVeThongTinMonThi(string maMonThi)
        {
            m_maMonThi = maMonThi;
            SqlConnection cnn = OnLyConnectDB.Instance(ConnectionInfo._CONNECTION_STRING);
            string query = string.Format("select * from tblMonThi where vcMaMonThi='{0}'", maMonThi);
            using (SqlCommand cmd = new SqlCommand(query, cnn))
            {
                cmd.CommandType = System.Data.CommandType.Text;
                cnn.Open();
                using (SqlDataReader rd = cmd.ExecuteReader())
                {
                    rd.Read();
                    m_tenMonThi = rd["nvcTenMonThi"] as string;
                    m_soTinChi = (int)rd["iSoTinChi"];
                    m_soLuongCau = (int)rd["iSoTinChi"];
                    m_hocKy = rd["nvcHocKy"] as string;
                }
                cnn.Close();
            }
        }
    }
}