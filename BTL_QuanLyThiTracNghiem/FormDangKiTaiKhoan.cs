using BTL_QuanLyThiTracNghiem.QuerysDB;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_QuanLyThiTracNghiem
{
    public partial class FormDangKiTaiKhoan : Form
    {
        private FormDangNhap m_formDangNhap;
        public FormDangNhap FormDangNhap
        {
            get => m_formDangNhap;
            set { m_formDangNhap = value; }
        }
        public FormDangKiTaiKhoan()
        {
            InitializeComponent();
        }

        private void radioButton_giangVien_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox_maSinhVien.Visible = false;
            this.label_maSinhVien.Visible = false;
        }

        private void radioButton_sinhVien_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox_maSinhVien.Visible = true;
            this.label_maSinhVien.Visible = true;
        }

        private void button_dangKi_Click(object sender, EventArgs e)
        {
            string tenDangNhap = this.textBox_tenDangNhap.Text.Trim();
            string matKhau = this.textBox_matKhau.Text.Trim();
            string xacNhanMatKhau = this.textBox_xacNhanMatKhau.Text.Trim();
            string maSinhVien = this.textBox_maSinhVien.Text.Trim();
            if (!TurnOnErrorProvider(tenDangNhap, matKhau, xacNhanMatKhau, maSinhVien))
                return;
            if (radioButton_giangVien.Checked)
            {
                try
                {
                    DangKiTaiKhoan(tenDangNhap, matKhau, DBNull.Value, quyenTruyCap: 1);
                    ClearData();
                    DialogResult mess = MessageBox.Show("Đăng kí tài khoản giáo viên thành công.Quay lại màn hình đăng nhập?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    if (mess == DialogResult.Yes)
                        BackToFormDangNhap(tenDangNhap, matKhau);
                }
                catch (Exception)
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                string query =
                    string.Format("select count(vcMaSinhVien) from tblSinhVien where vcMaSinhVien COLLATE Latin1_General_CS_AS='{0}'", maSinhVien);
                int count = (int)SelectDB.GetAValue(query);
                if (count == 0)
                {
                    MessageBox.Show("Mã sinh viên không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    try
                    {
                        DangKiTaiKhoan(tenDangNhap, matKhau, maSinhVien, quyenTruyCap: 2);
                        ClearData();
                        DialogResult mess = MessageBox.Show("Đăng kí tài khoản sinh viên thành công.Quay lại màn hình đăng nhập?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (mess == DialogResult.Yes)
                            BackToFormDangNhap(tenDangNhap, matKhau);
                    }
                    catch (SqlException ex)
                    {
                        if (ex.Number == 2627)
                            MessageBox.Show("Tên tài khoản đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        else
                            MessageBox.Show("Mã sinh viên đã đăng kí tài khoản", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void DangKiTaiKhoan(string tenDangNhap, string matKhau, object maSinhVien, int quyenTruyCap)
        {
            string[] paramss = { "@vcTenDangNhap", "@vcMatKhau", "@iQuyenTruyCap", "@vcMaSinhVien" };
            object[] values = { tenDangNhap, matKhau, quyenTruyCap, maSinhVien };
            TransactionDB.Transaction("sp_dangKiTaiKhoan", CommandType.StoredProcedure, paramss, values);
        }

        private void checkBox_hienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox_matKhau.UseSystemPasswordChar = !this.checkBox_hienThiMatKhau.Checked;
            this.textBox_xacNhanMatKhau.UseSystemPasswordChar = !this.checkBox_hienThiMatKhau.Checked;
        }

        private bool TurnOnErrorProvider(string tenDangNhap, string matKhau, string xacNhanMatKhau, string maSinhVien)
        {
            bool check = true;
            if (string.IsNullOrEmpty(tenDangNhap))
            {
                this.errorProvider.SetError(this.textBox_tenDangNhap, "Chưa điền tên đăng nhập");
                check = false;
            }
            else
                this.errorProvider.SetError(this.textBox_tenDangNhap, null);
            if (string.IsNullOrEmpty(matKhau))
            {
                this.errorProvider.SetError(this.textBox_matKhau, "Chưa điền mật khẩu");
                check = false;
            }
            else
                this.errorProvider.SetError(this.textBox_matKhau, null);
            if (!xacNhanMatKhau.Equals(matKhau))
            {
                this.errorProvider.SetError(this.textBox_xacNhanMatKhau, "Không trùng khớp với mật khẩu ở trên");
                check = false;
            }
            else
                this.errorProvider.SetError(this.textBox_xacNhanMatKhau, null);
            if (this.radioButton_sinhVien.Checked)
            {
                if (string.IsNullOrEmpty(maSinhVien))
                {
                    this.errorProvider.SetError(this.textBox_maSinhVien, "Chưa điền mã sinh viên");
                    check = false;
                }
                else
                    this.errorProvider.SetError(this.textBox_maSinhVien, null);
            }
            return check;
        }

        private void ClearData()
        {
            this.textBox_tenDangNhap.Text = "";
            this.textBox_matKhau.Text = "";
            this.textBox_xacNhanMatKhau.Text = "";
            this.textBox_maSinhVien.Text = "";
        }

        private void BackToFormDangNhap(string tenDangNhap, string matKhau)
        {
            m_formDangNhap.TenDangNhap = tenDangNhap;
            m_formDangNhap.MatKhau = matKhau;
            this.Close();
        }

        private void FormDangKiTaiKhoan_FormClosed(object sender, FormClosedEventArgs e)
        {
            m_formDangNhap.Show();
        }
    }
}
