using BTL_QuanLyThiTracNghiem.Constants;
using BTL_QuanLyThiTracNghiem.Objects;
using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Media;
using System.Windows.Forms;

namespace BTL_QuanLyThiTracNghiem.FormsStudent
{
    public partial class FormLamBaiThi : Form
    {
        private DataTable m_bangCauHoi;
        private SinhVien m_sinhVien;
        private MonThi m_monThi;
        private FormLichThi m_formLichThi;
        private int m_soCauHoi;
        private int m_conTroCauHoi;
        private int m_hour, m_minute, m_second = 0;
        private int[] m_cacDapAnDaChon;
        private int m_maDeThi;

        public FormLichThi FormLichThi
        {
            set { m_formLichThi = value; }
            get { return m_formLichThi; }
        }
        public DataTable BangCauHoi
        {
            get => this.m_bangCauHoi;
            set => this.m_bangCauHoi = value;
        }
        public int MaDeThi
        {
            get => this.m_maDeThi;
            set => this.m_maDeThi = value;
        }
        public int SoCauHoi
        {
            get => this.m_soCauHoi;
            set => m_soCauHoi = value;
        }
        public SinhVien SinhVien
        {
            get => this.m_sinhVien;
            set => this.m_sinhVien = value;
        }
        public MonThi MonThi
        {
            get => this.m_monThi;
            set => this.m_monThi = value;
        }
        public int[] CacDapAnDaChon => m_cacDapAnDaChon;

        public FormLamBaiThi()
        {
            InitializeComponent();
        }

        public FormLamBaiThi(MonThi monThi, SinhVien sinhVien)
            : this()
        {
            this.m_monThi = monThi;
            this.m_sinhVien = sinhVien;
            int thoiGianLamBai = monThi.SoTinChi * Utilities._WEIGHT_MINUTE;
            this.m_hour = thoiGianLamBai / 60;
            this.m_minute = thoiGianLamBai % 60;
            this.label_tenMonThi.Text = "Môn:  " + this.m_monThi.TenMonThi;
            this.label_maSinhVien.Text = "Mã SV:  " + this.m_sinhVien.MaSinhVien;
            this.label_thoiGianLamBai.Text = "Thời gian:  " + thoiGianLamBai + " phút";
            this.label_ngaySinh.Text = "Ngày sinh:  " + this.m_sinhVien.NgaySinh.ToShortDateString();
            this.label_tenSinhVien.Text = "Họ tên:  " + this.m_sinhVien.TenSinhVien;
            this.label_gioiTinh.Text = "Giới tính:  " + this.m_sinhVien.GioiTinh;
            this.label_lop.Text = "Lớp:  " + this.m_sinhVien.LopHanhChinh;
            this.label_hocKy.Text = "Năm học:  " + this.m_monThi.HocKy;
            label_thoiGianDemNguoc.Text = string.Format("{0}:{1}:{2}", m_hour.ToString().PadLeft(2, '0'), m_minute.ToString().PadLeft(2, '0'), m_second.ToString().PadLeft(2, '0'));
        }

        private void HienThiCauHoi(int viTri)
        {
            this.groupbox_cauHoi.Text = "Câu hỏi " + (viTri + 1).ToString();
            DataRow cauHoi = m_bangCauHoi.Rows[viTri];
            this.textbox_noiDung.Text = cauHoi["nvcNoiDung"].ToString();
            this.textbox_A.Text = "  " + (string)cauHoi["nvcDapAnA"];
            this.textbox_B.Text = "  " + (string)cauHoi["nvcDapAnB"];
            this.textbox_C.Text = "  " + (string)cauHoi["nvcDapAnC"];
            this.textbox_D.Text = "  " + (string)cauHoi["nvcDapAnD"];
            if (cauHoi["nvcDuongDanFileAnh"] != DBNull.Value)
            {
                try
                {
                    this.picturebox.Image = Image.FromFile(cauHoi["nvcDuongDanFileAnh"].ToString());
                }
                catch (ArgumentException)
                {
                    this.picturebox.Image = null;
                }
                catch (FileNotFoundException)
                {
                    this.picturebox.Image = null;
                }
            }
            else
                this.picturebox.Image = null;
            KiemTraCauTraLoi(viTri);
        }

        private bool KiemTraCauTraLoi(int viTri)
        {
            int viTriDapAn = this.m_cacDapAnDaChon[viTri];
            switch (viTriDapAn)
            {
                case 1:
                    this.radiobutton_A.Checked = true;
                    break;
                case 2:
                    this.radiobutton_B.Checked = true;
                    break;
                case 3:
                    this.radiobutton_C.Checked = true;
                    break;
                case 4:
                    this.radiobutton_D.Checked = true;
                    break;
                default:
                    this.radiobutton_A.Checked = false;
                    this.radiobutton_B.Checked = false;
                    this.radiobutton_C.Checked = false;
                    this.radiobutton_D.Checked = false;
                    break;
            }
            return viTriDapAn > 0;
        }

        private void NopBai()
        {
            this.groupbox_traLoi.Enabled = false;
            this.button_nopBai.Enabled = false;
            int demDapAnChinhXac = 0;
            for (int i = 0; i < this.SoCauHoi; i++)
                if (this.CacDapAnDaChon[i] == (int)this.BangCauHoi.Rows[i]["iDapAnDung"])
                    demDapAnChinhXac++;
            //Ghi nhận vào bảng kết quả
            string[] paramss = { "@vcMaMonThi", "@vcMaSinhVien", "@iMaDeThi", "@iSoCauDung", "@iSoCauSai" };
            object[] values = { m_monThi.MaMonThi, m_sinhVien.MaSinhVien, m_maDeThi, demDapAnChinhXac, this.SoCauHoi - demDapAnChinhXac };
            ChiTietKetQuaThi.g_MaKetQuaThi = (int)QuerysDB.SelectDB.GetAValue("sp_themKetQuaThi", CommandType.StoredProcedure, paramss, values);
            //chèn vào bảng chi tiết kết quả
            DataTable t = new DataTable();
            t.Columns.Add("iMaKetQuaThi", typeof(int));
            t.Columns.Add("iMaCauHoi", typeof(int));
            t.Columns.Add("iCauTraLoi", typeof(int));
            for (int i = 0; i < this.SoCauHoi; i++)
                t.Rows.Add(ChiTietKetQuaThi.g_MaKetQuaThi, this.BangCauHoi.Rows[i]["iMaCauHoi"], this.CacDapAnDaChon[i]);
            QuerysDB.TransactionDB.Transaction("sp_themChiTietKetQuaThi", CommandType.StoredProcedure, new string[] { "@tbl" }, new object[] { t });
        }

        private void TaoBangDanhSachCauHoi(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Button cauHoi = new Button();
                cauHoi.Size = new Size(48, 45);
                cauHoi.Text = "" + i;
                cauHoi.BackColor = Color.Gold;
                cauHoi.FlatStyle = FlatStyle.Flat;
                cauHoi.FlatAppearance.BorderSize = 2;
                cauHoi.FlatAppearance.BorderColor = Color.White;
                cauHoi.Cursor = Cursors.Hand;
                cauHoi.Click += SuKienChoNutBam_Click;
                this.flowLayoutPanel_danhSachCauHoi.Controls.Add(cauHoi);
            }
        }
        private void DanhDauCauHoiDangChon(int viTriCu, int viTriMoi)
        {
            Button cauHoiDangChon = (Button)this.flowLayoutPanel_danhSachCauHoi.Controls[viTriMoi];
            if (viTriCu == viTriMoi)
            {
                cauHoiDangChon.FlatAppearance.BorderColor = Color.Blue;
                return;
            }
            Button cauHoiCu = (Button)this.flowLayoutPanel_danhSachCauHoi.Controls[viTriCu];
            cauHoiCu.FlatAppearance.BorderColor = Color.White;
            cauHoiDangChon.FlatAppearance.BorderColor = Color.Blue;
        }

        #region EVENT
        private void FormLamBaiThi_Load(object sender, EventArgs e)
        {
            m_maDeThi = QuerysDB.SelectDB.GetRandomExamCode(m_monThi.MaMonThi);
            if (m_maDeThi == -1)
            {
                MessageBox.Show("Môn thi này chưa có đề", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.groupbox_traLoi.Enabled = false;
                this.Close();
                return;
            }
            this.label_maDeThi.Text = "Mã đề:  " + this.m_maDeThi.ToString();
            this.m_bangCauHoi = QuerysDB.SelectDB.GetTableQuestion(m_maDeThi);
            this.m_soCauHoi = m_bangCauHoi.Rows.Count;
            if (this.m_soCauHoi == 0)
            {
                MessageBox.Show("Mã đề " + this.m_maDeThi.ToString() + " chưa có câu hỏi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.groupbox_traLoi.Enabled = false;
                this.Close();
                return;
            }
            this.m_cacDapAnDaChon = new int[m_soCauHoi];
            TaoBangDanhSachCauHoi(m_soCauHoi);
            HienThiCauHoi(0);
            DanhDauCauHoiDangChon(0, 0);
            this.timer_thoiGianDemNguoc.Enabled = true;
        }

        private void FormLamBaiThi_FormClosing(object sender, FormClosingEventArgs e)
        {
            //nếu chưa nộp bài
            if (this.groupbox_traLoi.Enabled)
            {
                string thongBao = "Bạn có muốn thoát không?\nNếu thoát bài làm của bạn vẫn sẽ được ghi nhận.";
                if (MessageBox.Show(thongBao, "Xác nhận", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    NopBai();
                    m_formLichThi.KiemTraCapNhat = true;
                    m_formLichThi.Show();
                    m_formLichThi.Activate();
                }
                else
                    e.Cancel = true;
            }
            else
            {
                m_formLichThi.KiemTraCapNhat = true;
                m_formLichThi.Show();
                m_formLichThi.Activate();
            }
        }

        private void button_prev_Click(object sender, EventArgs e)
        {
            if (this.m_conTroCauHoi >= 1)
            {
                int viTriCu = this.m_conTroCauHoi;
                this.m_conTroCauHoi--;
                HienThiCauHoi(this.m_conTroCauHoi);
                DanhDauCauHoiDangChon(viTriCu, m_conTroCauHoi);
            }
        }

        private void button_next_Click(object sender, EventArgs e)
        {
            if (this.m_conTroCauHoi < this.m_soCauHoi - 1)
            {
                int viTriCu = m_conTroCauHoi;
                this.m_conTroCauHoi++;
                HienThiCauHoi(m_conTroCauHoi);
                DanhDauCauHoiDangChon(viTriCu, m_conTroCauHoi);
            }
        }

        private void button_nopBai_Click(object sender, EventArgs e)
        {
            DialogResult ketQua = MessageBox.Show
                (this, "bạn có muốn nộp bài", "xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (ketQua == DialogResult.Yes)
            {
                this.timer_thoiGianDemNguoc.Enabled = false;
                NopBai();
                MessageBox.Show(this, "nộp bài thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void radiobutton_A_Click(object sender, EventArgs e)
        {
            if (this.m_cacDapAnDaChon[m_conTroCauHoi] == 0)
                this.flowLayoutPanel_danhSachCauHoi.Controls[m_conTroCauHoi].BackColor = Color.Lime;
            this.m_cacDapAnDaChon[m_conTroCauHoi] = 1;
        }

        private void radiobutton_B_Click(object sender, EventArgs e)
        {
            if (this.m_cacDapAnDaChon[m_conTroCauHoi] == 0)
                this.flowLayoutPanel_danhSachCauHoi.Controls[m_conTroCauHoi].BackColor = Color.Lime;
            this.m_cacDapAnDaChon[m_conTroCauHoi] = 2;
        }

        private void radiobutton_C_Click(object sender, EventArgs e)
        {
            if (this.m_cacDapAnDaChon[m_conTroCauHoi] == 0)
                this.flowLayoutPanel_danhSachCauHoi.Controls[m_conTroCauHoi].BackColor = Color.Lime;
            this.m_cacDapAnDaChon[m_conTroCauHoi] = 3;
        }

        private void radiobutton_D_Click(object sender, EventArgs e)
        {
            if (this.m_cacDapAnDaChon[m_conTroCauHoi] == 0)
                this.flowLayoutPanel_danhSachCauHoi.Controls[m_conTroCauHoi].BackColor = Color.Lime;
            this.m_cacDapAnDaChon[m_conTroCauHoi] = 4;
        }

        public void SuKienChoNutBam_Click(object sender, EventArgs e)
        {
            int viTriCu = m_conTroCauHoi;
            for (int i = 0; i < m_soCauHoi; i++)
                if (this.flowLayoutPanel_danhSachCauHoi.Controls[i] == sender)
                {
                    this.m_conTroCauHoi = i;
                    break;
                }
            HienThiCauHoi(m_conTroCauHoi);
            DanhDauCauHoiDangChon(viTriCu, m_conTroCauHoi);
            this.button_nopBai.Focus();
        }

        private void timer_thoiGianDemNguoc_Tick(object sender, EventArgs e)
        {
            this.m_second--;
            if (this.m_second == -1)
            {
                this.m_second = 59;
                this.m_minute--;
            }
            if (this.m_minute == -1)
            {
                this.m_minute = 59;
                this.m_hour--;
            }
            if (this.m_hour == -1)
            {
                using (var amThanh = new SoundPlayer
                    (Utilities._PATH_SOUND_TIMEOUT))
                {
                    amThanh.Play();
                }
                this.timer_thoiGianDemNguoc.Enabled = false;
                MessageBox.Show("hết thời gian làm bài.bài làm của bạn đã được ghi nhận", "hết giờ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                NopBai();
                return;
            }
            label_thoiGianDemNguoc.Text = string.Format("{0}:{1}:{2}", m_hour.ToString().PadLeft(2, '0'), m_minute.ToString().PadLeft(2, '0'), m_second.ToString().PadLeft(2, '0'));
        }
        #endregion
    }
}