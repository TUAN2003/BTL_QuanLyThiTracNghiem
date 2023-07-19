using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLyThiTracNghiem.FormsManager
{
    public partial class FormQL : Form
    {
        private FormDangNhap m_formDangNhap;
        public FormDangNhap FormDangNhap
        {
            set { m_formDangNhap = value; }
            get { return m_formDangNhap; }
        }
        public FormQL()
        {
            InitializeComponent();
        }

        private void ToolStripMenuItem_FormQLCauHoi_Click(object sender, EventArgs e)
        {
            FormQLCauHoi f = Program.FindFormExisting("FormQLCauHoi") as FormQLCauHoi;
            if (f == null)
                f = new FormQLCauHoi();
            f.MdiParent = this;
            f.Show();
            f.Activate();
        }

        private void ToolStripMenuItem_FormQLMonThi_Click(object sender, EventArgs e)
        {
            FormQLMonThi f = Program.FindFormExisting("FormQLMonThi") as FormQLMonThi;
            if (f == null)
                f = new FormQLMonThi();
            f.MdiParent = this;
            f.Show();
            f.Activate();
        }

        private void ToolStripMenuItem_FormQLDeThi_Click(object sender, EventArgs e)
        {
            FormTaoDeThi f = Program.FindFormExisting("FormTaoDeThi") as FormTaoDeThi;
            if (f == null)
                f = new FormTaoDeThi();
            f.MdiParent = this;
            f.Show();
            f.Activate();
        }

        private void ToolStripMenuItem_FormQLDSThi_Click(object sender, EventArgs e)
        {
            FormQLDanhSachThi f = Program.FindFormExisting("FormQLDanhSachThi") as FormQLDanhSachThi;
            if (f == null)
                f = new FormQLDanhSachThi();
            f.MdiParent = this;
            f.Show();
            f.Activate();
        }

        private void FormQLChung_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ToolStripMenuItem_FormQLKetQua_Click(object sender, EventArgs e)
        {
            FormQLKetQua f = Program.FindFormExisting("FormQLKetQua") as FormQLKetQua;
            if (f == null)
                f = new FormQLKetQua();
            f.MdiParent = this;
            f.Show();
            f.Activate();
        }

        private void ToolStripMenuItem_Thoat_Click(object sender, EventArgs e)
        {
            FormClosed -= FormQLChung_FormClosed;
            m_formDangNhap.Show();
            m_formDangNhap.Activate();
            this.Close();
        }
    }
}
