namespace BTL_QuanLyThiTracNghiem.Objects
{
    public class ChiTietKetQuaThi
    {
        public static int g_MaKetQuaThi;
        private string m_MaCauHoi;
        private int m_CauTraLoi;

        public string MaCauHoi
        {
            get { return m_MaCauHoi; }
            set { m_MaCauHoi = value; }
        }
        public int CauTraLoi
        {
            get => m_CauTraLoi;
            set => m_CauTraLoi = value;
        }
    }
}
