using BTL_QuanLyThiTracNghiem.Objects;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace BTL_QuanLyThiTracNghiem.FormsStudent
{
    public partial class FormLichThi : Form
    {
        private SinhVien m_sinhVien;
        private DataTable m_bangLichThi;
        private FormDangNhap m_formDangNhap;
        private bool m_kiemTraCapNhat = false;

        public SinhVien SinhVien
        {
            get { return m_sinhVien; }
            set { m_sinhVien = value; }
        }
        //có cập nhật dữ liệu
        public bool KiemTraCapNhat
        {
            get => m_kiemTraCapNhat;
            set
            {
                if (value)
                {
                    string[] paramss = { "@vcMaSinhVien" };
                    object[] values = { m_sinhVien.MaSinhVien };
                    m_bangLichThi = QuerysDB.SelectDB.GetTable("sp_danhSachLichThi", CommandType.StoredProcedure, paramss, values);
                    this.dataGridView.DataSource = m_bangLichThi;
                    this.dataGridView.Columns["vcMaXacNhan"].Visible = false;
                    m_kiemTraCapNhat = false;
                }
            }
        }
        public FormDangNhap FormDangNhap
        {
            set { m_formDangNhap = value; }
            get { return m_formDangNhap; }
        }
        public FormLichThi()
        {
            InitializeComponent();
        }
        public FormLichThi(SinhVien sinhVien)
            : this()
        {
            m_sinhVien = sinhVien;
        }
        private void FormLichThi_Load(object sender, EventArgs e)
        {
            this.label_title.Text = "Lịch thi của " + m_sinhVien.TenSinhVien;
            this.label_title.Location = new Point((400 - this.label_title.Width / 2), 63);
            KiemTraCapNhat = true;
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
                e.CellStyle.BackColor = Color.White;
            else
                e.CellStyle.BackColor = Color.LightGray;
        }

        private void FormLichThi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button_xacNhan_Click(object sender, EventArgs e)
        {
            if (this.m_bangLichThi.Rows.Count == 0)
            {
                MessageBox.Show("Không có môn thi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (this.dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Chưa chọn môn thi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            object code = this.dataGridView.SelectedRows[0].Cells["vcMaXacNhan"].Value;
            if (code == null)
            {
                MessageBox.Show("Môn thi không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!this.textBox_maXacNhan.Text.Equals((string)code))
            {
                MessageBox.Show("Mã xác nhận không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string maMonThi = this.dataGridView.SelectedRows[0].Cells["Mã môn thi"].Value as string;
            MonThi monThi = new MonThi(maMonThi);
            this.Hide();
            FormLamBaiThi f = new FormLamBaiThi(monThi, this.m_sinhVien);
            f.FormLichThi = this;
            f.Show();
            f.Activate();
        }

        private void ToolStripMenuItem_dangXuat_Click(object sender, EventArgs e)
        {
            this.FormClosed -= FormLichThi_FormClosed;
            m_formDangNhap.Show();
            m_formDangNhap.Activate();
            this.Close();
        }

        private void ToolStripMenuItem_lamMoi_Click(object sender, EventArgs e)
        {
            KiemTraCapNhat = true;
        }

        private void toolStripButton_dangXuat_Click(object sender, EventArgs e)
        {
            this.FormClosed -= FormLichThi_FormClosed;
            m_formDangNhap.Show();
            m_formDangNhap.Activate();
            this.Close();
        }

        private void toolStripButton_lamMoi_Click(object sender, EventArgs e)
        {
            KiemTraCapNhat = true;
        }
    }
}