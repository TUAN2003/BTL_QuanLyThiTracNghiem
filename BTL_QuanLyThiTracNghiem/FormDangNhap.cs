using BTL_QuanLyThiTracNghiem.FormsManager;
using BTL_QuanLyThiTracNghiem.FormsStudent;
using BTL_QuanLyThiTracNghiem.Objects;
using System;
using System.Data;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;

namespace BTL_QuanLyThiTracNghiem
{
    public partial class FormDangNhap : Form
    {
        internal string TenDangNhap { get => this.textBox_tenDangNhap.Text; set { this.textBox_tenDangNhap.Text = value; } }
        internal string MatKhau { get => this.textBox_matKhau.Text; set { this.textBox_matKhau.Text = value; } }
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void button_dangNhap_Click(object sender, EventArgs e)
        {
            this.DangNhap();
        }

        private bool IsEmptyUIDandPWD()
        {
            bool isEmpty = false;
            if (this.textBox_tenDangNhap.Text.Length == 0)
            {
                this.err_userempty.SetError(this.textBox_tenDangNhap, "Tên đăng nhập không được để trống");
                isEmpty = true;
            }
            else
                this.err_userempty.SetError(this.textBox_tenDangNhap, null);
            if (this.textBox_matKhau.Text.Length == 0)
            {
                this.err_pwdempty.SetError(this.textBox_matKhau, "Mật khẩu không được để trống");
                isEmpty = true;
            }
            else
                this.err_pwdempty.SetError(this.textBox_matKhau, null);
            return isEmpty;
        }

        private void label_quenMatKhau_Click(object sender, EventArgs e)
        {

        }

        private void checkBox_hienThiMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            this.textBox_matKhau.UseSystemPasswordChar = !this.checkBox_hienThiMatKhau.Checked;
        }

        private void label_dangKiTaiKhoan_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormDangKiTaiKhoan f = Program.FindFormExisting("FormDangKiTaiKhoan") as FormDangKiTaiKhoan;
            if (f == null)
                f = new FormDangKiTaiKhoan();
            f.FormDangNhap = this;
            f.Show();
            f.Activate();
        }

        private void DangNhap()
        {
            if (IsEmptyUIDandPWD())
                return;
            TaiKhoan taiKhoan = new TaiKhoan();
            if (!taiKhoan.LayVeThongTinTaiKhoan(this.textBox_tenDangNhap.Text.Trim(), this.textBox_matKhau.Text.Trim()))
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu", "Đăng nhập", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            this.Hide();
            int quyenTruyCap = taiKhoan.QuyenTruyCap;
            if (quyenTruyCap == 1)
            {
                FormQL f = new FormQL();
                f.FormDangNhap = this;
                f.Show();
                f.Activate();
            }
            else if (quyenTruyCap == 2)
            {
                SinhVien sinhVien = new SinhVien(taiKhoan.MaSinhVien);
                FormLichThi f = new FormLichThi(sinhVien);
                f.FormDangNhap = this;
                f.Show();
                f.Activate();
            }
        }

        private void textBox_matKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.DangNhap();
        }

        private void textBox_tenDangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                this.DangNhap();
        }
    }
}
