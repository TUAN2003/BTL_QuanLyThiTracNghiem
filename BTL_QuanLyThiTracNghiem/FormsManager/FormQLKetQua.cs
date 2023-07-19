using BTL_QuanLyThiTracNghiem.FormsManager.Reporting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLyThiTracNghiem.FormsManager
{
    public partial class FormQLKetQua : Form
    {
        private bool m_kiemTraCapNhat = false;
        private DataTable m_bangKetQua = new DataTable();
        private Form m_formReportViewer;
        public bool KiemTraCapNhat
        {
            set
            {
                if (value)
                {
                    m_bangKetQua = QuerysDB.SelectDB.GetTable("select * from vw_ketQuaThi");
                    this.dataGridView.DataSource = m_bangKetQua;
                    m_kiemTraCapNhat = false;
                }
            }
            get { return m_kiemTraCapNhat; }
        }

        public FormQLKetQua()
        {
            InitializeComponent();
        }

        private void FormQLKetQua_Load(object sender, EventArgs e)
        {
            KiemTraCapNhat = true;
            DataTable t = QuerysDB.SelectDB.GetTable("select vcMaMonThi,nvcTenMonThi from tblMonThi");
            this.comboBox_monThi.DataSource = t;
            this.comboBox_monThi.DisplayMember = "nvcTenMonThi";
            this.comboBox_monThi.ValueMember = "vcMaMonThi";
            DataRow r = t.NewRow();
            r["nvcTenMonThi"] = "(trống)";
            r["vcMaMonThi"] = "";
            t.Rows.InsertAt(r, 0);
            this.comboBox_monThi.SelectedValue = "";
        }

        private void button_timKiem_Click(object sender, EventArgs e)
        {
            string filter = "[Mã SV] LIKE '%{0}%' AND [Họ tên] LIKE '%{1}%' AND [Lớp HC] LIKE '%{2}%'";
            string maMonThi = this.comboBox_monThi.SelectedValue.ToString();
            string maKetQua = this.textBox_maKetQua.Text.Trim();
            string maDe = this.textBox_maDe.Text.Trim();
            if (!maMonThi.Equals(""))
                filter += " AND [Mã môn thi]='" + maMonThi + "'";
            if (!string.IsNullOrEmpty(maKetQua))
            {
                try
                {
                    filter += " AND [Mã kết quả]=" + Convert.ToInt32(maKetQua);
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã kết quả không hợp lệ!!!\n Mã phiếu chỉ chứa số");
                    return;
                }
            }
            if (!string.IsNullOrEmpty(maDe))
            {
                try
                {
                    filter += " AND [Mã đề]=" + Convert.ToInt32(maDe);
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã đề không hợp lệ!!!\n Mã đề chỉ chứa số");
                    return;
                }
            }
            m_bangKetQua.DefaultView.RowFilter = string.Format
                (filter,
                this.textBox_maSinhVien.Text.Trim(),
                this.textBox_hoTen.Text.Trim(),
                this.textBox_lopHanhChinh.Text.Trim());
        }

        private void button_xemTatCa_Click(object sender, EventArgs e)
        {
            m_bangKetQua.DefaultView.RowFilter = "";
        }

        private void button_lamMoi_Click(object sender, EventArgs e)
        {
            KiemTraCapNhat = true;
            this.textBox_lopHanhChinh.Text = "";
            this.textBox_maDe.Text = "";
            this.textBox_maKetQua.Text = "";
            this.textBox_maSinhVien.Text = "";
            this.textBox_hoTen.Text = "";
        }

        private void button_inCR_Click(object sender, EventArgs e)
        {
            string filter = "{0} LIKE '*{1}*' AND {2} LIKE '*{3}*' AND {4} LIKE '*{5}*'";
            filter = string.Format
                (filter,
                "{vw_ketQuaThi.Mã SV}",
                this.textBox_maSinhVien.Text.Trim(),
                "{vw_ketQuaThi.Họ tên}",
                this.textBox_hoTen.Text.Trim(),
                "{vw_ketQuaThi.Lớp HC}",
                this.textBox_lopHanhChinh.Text.Trim());
            string maMonThi = this.comboBox_monThi.SelectedValue.ToString();
            string maKetQua = this.textBox_maKetQua.Text.Trim();
            string maDe = this.textBox_maDe.Text.Trim();
            if (!maMonThi.Equals(""))
                filter += " AND {vw_ketQuaThi.Mã môn thi}='" + maMonThi + "'";
            if (!string.IsNullOrEmpty(maKetQua))
            {
                try
                {
                    filter += " AND {vw_ketQuaThi.Mã kết quả}=" + Convert.ToInt32(maKetQua);
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã kết quả không hợp lệ!!!\n Mã phiếu chỉ chứa số");
                    return;
                }
            }
            if (!string.IsNullOrEmpty(maDe))
            {
                try
                {
                    filter += " AND {vw_ketQuaThi.Mã đề}=" + Convert.ToInt32(maDe);
                }
                catch (Exception)
                {
                    MessageBox.Show("Mã đề không hợp lệ!!!\n Mã đề chỉ chứa số");
                    return;
                }
            }         
            FormReportViewer f = Program.FindFormExisting("FormReportViewer") as FormReportViewer;
            if (f == null)
            {
                f = new FormReportViewer("Báo Cáo", filter);
                this.m_formReportViewer = f;
            }
            else
                f.Filter = filter;
            f.MdiParent = this.MdiParent;
            f.Show();
            f.Activate();
        }

        private void FormQLKetQua_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (m_formReportViewer != null)
                this.m_formReportViewer.Close();
        }
    }
}
