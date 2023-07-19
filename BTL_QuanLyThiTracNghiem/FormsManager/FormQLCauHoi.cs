using BTL_QuanLyThiTracNghiem.QuerysDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BTL_QuanLyThiTracNghiem.FormsManager
{
    public partial class FormQLCauHoi : Form
    {
        private DataTable m_bangCauHoi, m_bangDanhSachMonThi, m_bangDanhSachChuong;
        private int m_soIdentityHienTai;
        private RadioButton[] m_dapAn_RadioButton;

        public FormQLCauHoi()
        {
            InitializeComponent();
            m_dapAn_RadioButton = new RadioButton[4] { radiobutton_A, radiobutton_B, radiobutton_C, radiobutton_D };
            List<string> dokho = new List<string>();
            dokho.Add("(trống)");
            dokho.Add("Nhận biết");
            dokho.Add("Thông hiểu");
            dokho.Add("Vận dụng");
            dokho.Add("Vận dụng cao");
            this.comboBox_doKho.DataSource = dokho;
        }
        

        private int ViTriDapAnDaChon()
        {
            int pos = 0;
            if (this.radiobutton_A.Checked)
                pos = 1;
            if (this.radiobutton_B.Checked)
                pos = 2;
            if (radiobutton_C.Checked)
                pos = 3;
            if (radiobutton_D.Checked)
                pos = 4;
            return pos;
        }
        private string KiemTraDuLieu(string noiDung, string dapAnA, string dapAnB, string dapAnC, string dapAnD, int dapAnDung, int doKho, string maMonThi)
        {
            string loi = "";
            if (string.IsNullOrEmpty(noiDung))
                loi += "'nội dung câu hỏi'";
            if (string.IsNullOrEmpty(dapAnA))
                loi += "'đáp án A'";
            if (string.IsNullOrEmpty(dapAnB))
                loi += "'đáp án B'";
            if (string.IsNullOrEmpty(dapAnC))
                loi += "'đáp án C'";
            if (string.IsNullOrEmpty(dapAnD))
                loi += "'đáp án D'";
            if (dapAnDung == 0)
                loi += "'chưa chọn đáp án đúng'";
            if (doKho == 0)
                loi += "'chưa chọn độ khó câu hỏi'";
            if (maMonThi.Equals(""))
                loi += "'chưa chọn môn học'";
            return loi;
        }
        #region event
        private void FormLamBaiThi_Load(object sender, EventArgs e)
        {
            string query = "select vcMaMonThi,nvcTenMonThi from tblMonThi";
            m_bangDanhSachMonThi = QuerysDB.SelectDB.GetTable(query, CommandType.Text);
            this.comboBox_monThi.DataSource = m_bangDanhSachMonThi;
            comboBox_monThi.DisplayMember = "nvcTenMonThi";
            comboBox_monThi.ValueMember = "vcMaMonThi";
            DataRow r = m_bangDanhSachMonThi.NewRow();
            r["vcMaMonThi"] = "";
            r["nvcTenMonThi"] = "(trống)";
            m_bangDanhSachMonThi.Rows.InsertAt(r, 0);
            this.comboBox_monThi.SelectedValue = "";
            query = "select * from tblChuong";
            m_bangDanhSachChuong = QuerysDB.SelectDB.GetTable(query, CommandType.Text);
            this.comboBox_chuong.DataSource = m_bangDanhSachChuong;
            comboBox_chuong.DisplayMember = "nvcTenChuong";
            comboBox_chuong.ValueMember = "nvcTenChuong";
            r = m_bangDanhSachChuong.NewRow();
            r["nvcTenChuong"] = "(trống)";
            r["vcMaMonThi"] = "";
            m_bangDanhSachChuong.Rows.InsertAt(r, 0);
            this.m_bangDanhSachChuong.DefaultView.RowFilter ="[vcMaMonThi]=''";
            this.m_bangCauHoi = QuerysDB.SelectDB.GetTable("sp_khoCauHoi", CommandType.StoredProcedure);
            this.dataGridView.DataSource = m_bangCauHoi;
            this.m_soIdentityHienTai = m_bangCauHoi.Rows.Count > 0 ? (int)m_bangCauHoi.Rows[m_bangCauHoi.Rows.Count - 1]["iMaCauHoi"] : 0;
            this.comboBox_monThi.SelectedIndexChanged += new EventHandler(this.comboBox_monthi_SelectedIndexChanged);
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= dataGridView.RowCount - 1 || e.RowIndex < 0)
                return;
            DataGridViewRow row = dataGridView.Rows[e.RowIndex];
            this.textbox_noiDungCauHoi.Text = row.Cells["nvcNoiDung"].Value.ToString();
            this.textbox_A.Text = row.Cells["nvcDapAnA"].Value.ToString();
            this.textbox_B.Text = row.Cells["nvcDapAnB"].Value.ToString();
            this.textbox_C.Text = row.Cells["nvcDapAnC"].Value.ToString();
            this.textbox_D.Text = row.Cells["nvcDapAnD"].Value.ToString();
            string pathImage = row.Cells["nvcDuongDanFileAnh"].Value.ToString();
            this.textBox_duongDan.Text = pathImage;
            if (!string.IsNullOrEmpty(pathImage))
            {
                try
                {
                    this.picturebox.Image = Image.FromFile(pathImage);
                    this.openFileDialog.FileName = pathImage;
                }
                catch (ArgumentException)
                {
                    this.picturebox.Image = null;
                    this.openFileDialog.FileName = "";
                }
                catch (FileNotFoundException)
                {
                    this.picturebox.Image = null;
                    this.openFileDialog.FileName = "";
                }
            }
            else
            {
                this.picturebox.Image = null;
                this.openFileDialog.FileName = "";
            }
            m_dapAn_RadioButton[(int)row.Cells["iDapAnDung"].Value - 1].Checked = true;
            this.comboBox_doKho.SelectedIndex = (int)row.Cells["iDoKho"].Value;
            this.comboBox_monThi.SelectedValue = row.Cells["vcMaMonThi"].Value;
            this.comboBox_chuong.SelectedValue = (row.Cells["nvcTenChuong"].Value == DBNull.Value ? "(trống)" : row.Cells["nvcTenChuong"].Value);
        }
        //xử lý khi người dùng click vào nút chọn ảnh
        private void button_chonAnh_Click(object sender, EventArgs e)
        {
            if (this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                this.picturebox.Image = new Bitmap(this.openFileDialog.FileName);
                this.textBox_duongDan.Text = this.openFileDialog.FileName;
            }
        }

        private void comboBox_monthi_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.m_bangDanhSachChuong.DefaultView.RowFilter = string.Format("[vcMaMonThi]='{0}' OR [vcMaMonThi]=''", this.comboBox_monThi.SelectedValue);
            this.toolTip.SetToolTip(comboBox_monThi,this.comboBox_monThi.SelectedValue.ToString());
        }

        //Xóa câu hỏi
        private void button_xoa_Click(object sender, EventArgs e)
        {
            //còn phải giải quyết nhiều ràng buộc của bảng khi xóa
            int nSelectedRows = dataGridView.SelectedRows.Count;
            if (nSelectedRows == 0)
            {
                MessageBox.Show("bạn chưa chọn câu hỏi để xóa", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                // chưa xong
            }
        }
        private void button_lamMoi_Click(object sender, EventArgs e)
        {
            this.openFileDialog.FileName = "";
            this.picturebox.Image = null;
            this.textbox_noiDungCauHoi.Text = "";
            this.textbox_A.Text = "";
            this.textbox_B.Text = "";
            this.textbox_C.Text = "";
            this.textbox_D.Text = "";
            this.textBox_duongDan.Text = "";
            foreach (RadioButton rb in m_dapAn_RadioButton)
                rb.Checked = false;
            this.comboBox_monThi.SelectedValue = "";
            this.comboBox_doKho.SelectedIndex = 0;
            this.m_bangCauHoi.DefaultView.RowFilter = "";
        }
        private void button_xoaAnh_Click(object sender, EventArgs e)
        {
            this.openFileDialog.FileName = "";
            this.picturebox.Image = null;
            this.textBox_duongDan.Text = "";
        }
        //INSERT
        private void button_them_Click(object sender, EventArgs e)
        {
            string noiDung = this.textbox_noiDungCauHoi.Text.Trim();
            string A = this.textbox_A.Text.Trim();
            string B = this.textbox_B.Text.Trim();
            string C = this.textbox_C.Text.Trim();
            string D = this.textbox_D.Text.Trim();
            int dapAnDung = ViTriDapAnDaChon();
            int doKho = this.comboBox_doKho.SelectedIndex;
            string maMonThi = this.comboBox_monThi.SelectedValue as string;
            object chuong = ((DataRowView)this.comboBox_chuong.SelectedItem)["vcMaMonThi"].Equals("") ? DBNull.Value : this.comboBox_chuong.SelectedValue;
            object pathImage = this.openFileDialog.FileName;
            if (string.IsNullOrEmpty((string)pathImage))
                pathImage = DBNull.Value;
            string loi = KiemTraDuLieu(noiDung, A, B, C, D, dapAnDung, doKho, maMonThi);
            if (!string.IsNullOrEmpty(loi))
            {
                MessageBox.Show("bạn chưa nhập đủ dữ liệu: " + loi, "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string[] paramss =
                { "@nvcNoiDung", "@nvcDapAnA", "@nvcDapAnB", "@nvcDapAnC", "@nvcDapAnD", "@iDapAnDung", "@iDoKho", "@vcMaMonThi", "@nvcTenChuong", "@nvcDuongDanFileAnh" };
            object[] values ={noiDung,A,B,C,D,dapAnDung,doKho,maMonThi,chuong,pathImage};
            if (TransactionDB.Transaction("sp_themCauHoi", CommandType.StoredProcedure, paramss, values) > 0)
            {
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                this.m_soIdentityHienTai++;
                m_bangCauHoi.Rows.Add(m_soIdentityHienTai, values[0], values[1], values[2], values[3], values[4], values[5], values[6], values[7], values[8], values[9]);
                this.dataGridView.CurrentCell = dataGridView.Rows[dataGridView.RowCount - 2].Cells[0];
            }
            else
                MessageBox.Show("Không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
        //UPDATE
        private void button_sua_Click(object sender, EventArgs e)
        {
            int nSelectedRows = dataGridView.SelectedRows.Count;
            if (nSelectedRows == 0)
            {
                MessageBox.Show("bạn chưa chọn câu hỏi để cập nhật", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (nSelectedRows > 1)
            {
                MessageBox.Show("bạn chỉ được chọn 1 câu hỏi để cập nhật", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int maCauHoi = (int)dataGridView.SelectedRows[0].Cells["iMaCauHoi"].Value;
            string noiDung = this.textbox_noiDungCauHoi.Text.Trim();
            string A = this.textbox_A.Text.Trim();
            string B = this.textbox_B.Text.Trim();
            string C = this.textbox_C.Text.Trim();
            string D = this.textbox_D.Text.Trim();
            int dapAnDung = ViTriDapAnDaChon();
            int doKho = this.comboBox_doKho.SelectedIndex;
            string maMonThi = this.comboBox_monThi.SelectedValue as string;
            object chuong = ((DataRowView)this.comboBox_chuong.SelectedItem)["vcMaMonThi"].Equals("") ? DBNull.Value : this.comboBox_chuong.SelectedValue;
            object pathImage = this.openFileDialog.FileName;
            if (string.IsNullOrEmpty((string)pathImage))
                pathImage = DBNull.Value;
            string loi = KiemTraDuLieu(noiDung, A, B, C, D, dapAnDung, doKho, maMonThi);
            if (!string.IsNullOrEmpty(loi))
            {
                MessageBox.Show("bạn chưa nhập đủ dữ liệu: " + loi, "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string[] paramss =
                {"@iMaCauHoi", "@nvcNoiDung", "@nvcDapAnA", "@nvcDapAnB", "@nvcDapAnC", "@nvcDapAnD", "@iDapAnDung", "@iDoKho", "@vcMaMonThi", "@nvcTenChuong", "@nvcDuongDanFileAnh" };
            object[] values ={maCauHoi,noiDung,A,B,C,D,dapAnDung,doKho,maMonThi,chuong,pathImage};
            if (TransactionDB.Transaction("sp_suaCauHoi", CommandType.StoredProcedure, paramss, values) > 0)
                MessageBox.Show("Cập nhật thành công", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            else
                MessageBox.Show("Không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            DataGridViewRow dgViewRow = dataGridView.SelectedRows[0];
            DataRowView rowView = dgViewRow.DataBoundItem as DataRowView;
            DataRow row = rowView.Row;
            row["nvcNoiDung"] = values[1];
            row["nvcDapAnA"]= values[2];
            row["nvcDapAnB"]= values[3];
            row["nvcDapAnC"]= values[4];
            row["nvcDapAnD"]= values[5];
            row["iDapAnDung"] = values[6];
            row["iDoKho"]= values[7];
            row["vcMaMonThi"] = values[8];
            row["nvcTenChuong"] = values[9];
            row["nvcDuongDanFileAnh"] = pathImage == DBNull.Value ? null : pathImage;
        }

        private void button_timKiem_Click(object sender, EventArgs e)
        {
            string filter = "iMaCauHoi >0";
            string maMonThi = this.comboBox_monThi.SelectedValue.ToString();
            string chuong = this.comboBox_chuong.SelectedValue.ToString();
            int doKho = this.comboBox_doKho.SelectedIndex;
            string noiDung = this.textbox_noiDungCauHoi.Text.Trim();
            if (!maMonThi.Equals(""))
                filter += $" and vcMaMonThi ='{maMonThi}'";
            if (!chuong.Equals("(trống)"))
                filter += $" and nvcTenChuong ='{chuong}'";
            if (doKho != 0)
                filter += $" and iDoKho ={doKho}";
            if (!noiDung.Equals(""))
                filter += $" and nvcNoiDung like '%{noiDung}%'";
            this.m_bangCauHoi.DefaultView.RowFilter = filter;
        }

        private void ToolStripMenuItem_themChuong_Click(object sender, EventArgs e)
        {
            object maMonThi = this.comboBox_monThi.SelectedValue;
            if (maMonThi.Equals(""))
            {
                MessageBox.Show("bạn chưa chon môn học", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            FormInputDialog f = new FormInputDialog();
            f.ShowDialog();
            if (FormInputDialog.g_isClickClose)
                return;
            string[] paramss = { "@vcMaMonThi", "@nvcTenChuong" };
            object[] values = {maMonThi , FormInputDialog.g_stringValue };
            if (values[1].Equals(""))
            {
                MessageBox.Show("bạn chưa nhập tên chương nên dữ liệu chưa được thêm", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                TransactionDB.Transaction("sp_themChuong", CommandType.StoredProcedure, paramss, values);
            }
            catch (SqlException)
            {
                MessageBox.Show("tên đã tồn tại", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            DataRow r = m_bangDanhSachChuong.NewRow();
            r["vcMaMonThi"] = values[0];
            r["nvcTenChuong"] = values[1];
            m_bangDanhSachChuong.Rows.InsertAt(r, this.m_bangDanhSachChuong.Rows.Count);
        }
        #endregion
    }
}
