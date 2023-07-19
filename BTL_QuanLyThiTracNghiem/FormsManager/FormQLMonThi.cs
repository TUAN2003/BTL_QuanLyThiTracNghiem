using BTL_QuanLyThiTracNghiem.QuerysDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLyThiTracNghiem.FormsManager
{
    public partial class FormQLMonThi : Form
    {
        private DataTable m_bangMonThi;
        public FormQLMonThi()
        {
            InitializeComponent();
        }

        private void FormQLMonThi_Load(object sender, EventArgs e)
        {
            m_bangMonThi = QuerysDB.SelectDB.GetTable("select * from tblMonThi");
            this.dataGridView.DataSource = m_bangMonThi;
            m_bangMonThi.Columns["vcMaMonThi"].ColumnName = "Mã môn thi";
            m_bangMonThi.Columns["nvcTenMonThi"].ColumnName = "Tên môn thi";
            m_bangMonThi.Columns["iSoTinChi"].ColumnName = "Số tín chỉ";
            m_bangMonThi.Columns["iSoCauHoi"].ColumnName = "Số câu hỏi";
            m_bangMonThi.Columns["nvcHocKy"].ColumnName = "Học kỳ";
            m_bangMonThi.Columns["dtNgayBatDauThi"].ColumnName = "Ngày thi";
            m_bangMonThi.Columns["tThoiGianThi"].ColumnName = "Thời gian";
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            string maMonThi = this.textBox_maMonThi.Text.Trim();
            string tenMonThi = this.textBox_tenMonThi.Text.Trim();
            string hocKy = this.textBox_hocKy.Text.Trim();
            TimeSpan tsp = this.dateTimePicker_thoiGianThi.Value.TimeOfDay;
            string loi=KiemTraDuLieu(maMonThi,tenMonThi,hocKy);
            if (!loi.Equals(""))
            {
                MessageBox.Show("Chưa nhập đủ thông tin: " + loi, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string[] paramss = { "@vcMaMonThi", "@nvcTenMonThi", "@iSoTinChi", "@iSoCauHoi", "@nvcHocKy", "@dtNgayBatDauThi","@tThoiGianThi" };
            object[] values = { maMonThi,
                tenMonThi,
                this.numericUpDown_soTinChi.Value,
                this.numericUpDown_soCauHoi.Value,
                hocKy,
                this.dateTimePicker_ngayThi.Value.Date,
                new TimeSpan(tsp.Hours,tsp.Minutes,0)
            };
            try
            {
                TransactionDB.Transaction("sp_themMonThi", CommandType.StoredProcedure, paramss, values);
                MessageBox.Show("Thêm thành công","thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                m_bangMonThi.Rows.Add(values);
            }
            catch (SqlException)
            {
                MessageBox.Show("Không thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button_sua_Click(object sender, EventArgs e)
        {
            int nSelectedRows = dataGridView.SelectedRows.Count;
            if (nSelectedRows < 0 || nSelectedRows > 1)
            {
                MessageBox.Show("Chỉ được chọn một bản ghi để cập nhật", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                string oldIdSubject = this.dataGridView.SelectedRows[0].Cells["Mã môn thi"].Value as string;
                string idSubject = this.textBox_maMonThi.Text.Trim();
                if(!oldIdSubject.Equals(idSubject))
                {
                    MessageBox.Show("Không được sửa mã môn thi", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string nameSubject = this.textBox_tenMonThi.Text.Trim();
                string semester = this.textBox_hocKy.Text.Trim();
                TimeSpan tsp = this.dateTimePicker_thoiGianThi.Value.TimeOfDay;
                string error = KiemTraDuLieu(oldIdSubject,nameSubject,semester);
                if (!error.Equals(""))
                {
                    MessageBox.Show("Chưa nhập đủ thông tin: " + error, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                string[] paramss = { "@vcMaMonThi", "@nvcTenMonThi", "@iSoTinChi", "@iSoCauHoi", "@nvcHocKy", "@dtNgayBatDauThi", "@tThoiGianThi" };
                object[] values = {idSubject
                    ,nameSubject
                    ,this.numericUpDown_soTinChi.Value
                    ,this.numericUpDown_soCauHoi.Value
                    ,semester
                    ,this.dateTimePicker_ngayThi.Value.Date
                    ,new TimeSpan(tsp.Hours,tsp.Minutes,0)};
                try
                {                   
                    TransactionDB.Transaction("sp_suaMonThi", CommandType.StoredProcedure, paramss, values);
                    MessageBox.Show("Sửa thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataGridViewRow dgRowView = dataGridView.SelectedRows[0];
                    DataRow r=((DataRowView)dgRowView.DataBoundItem).Row;
                    r["Mã môn thi"] = values[0];
                    r["Tên môn thi"] = values[1];
                    r["Số tín chỉ"] = values[2];
                    r["Số câu hỏi"] = values[3];
                    r["Học kỳ"] = values[4];
                    r["Ngày thi"] = values[5];
                    r["Thời gian"] = values[6];
                }
                catch (Exception)
                {
                    MessageBox.Show("Không thành công", "thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            //chưa xong
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= dataGridView.RowCount - 1 || e.RowIndex < 0)
                return;
            DataGridViewRow r= dataGridView.SelectedRows[0];
            this.textBox_maMonThi.Text = r.Cells["Mã môn thi"].Value.ToString();
            this.textBox_tenMonThi.Text = r.Cells["Tên môn thi"].Value.ToString();
            this.textBox_hocKy.Text = r.Cells["Học kỳ"].Value.ToString();
            this.dateTimePicker_ngayThi.Value = (DateTime)r.Cells["Ngày thi"].Value;
            this.numericUpDown_soTinChi.Value = (int)r.Cells["Số tín chỉ"].Value;
            this.numericUpDown_soCauHoi.Value = (int)r.Cells["Số câu hỏi"].Value;
            TimeSpan tsp = (TimeSpan)r.Cells["Thời gian"].Value;
            DateTime dt=new DateTime(2000,01,01,tsp.Hours,tsp.Minutes,tsp.Seconds);
            this.dateTimePicker_thoiGianThi.Value = dt;
        }

        private void button_timKiem_Click(object sender, EventArgs e)
        {
            string maMonThi = this.textBox_maMonThi.Text.Trim();
            string tenMonThi = this.textBox_tenMonThi.Text.Trim();
            string hocKy = this.textBox_hocKy.Text.Trim();
            DateTime ngayThi=dateTimePicker_ngayThi.Value.Date;
            int soTinChi = (int)this.numericUpDown_soTinChi.Value;
            int soCauHoi = (int)this.numericUpDown_soCauHoi.Value;
            string filter = "1=1";
            bool[] isChecked=new bool[6] { false,false,false,false,false,false};
            foreach (int index in checkedListBox_timKiem.CheckedIndices)
                isChecked[index] = true;
            if (isChecked[0])
                filter += $" and [Mã môn thi] like '%{maMonThi}%'";
            if (isChecked[1])
                filter += $" and [Tên môn thi] like '%{tenMonThi}%'";
            if (isChecked[2])
                filter += $" and [Học kỳ] like '%{hocKy}%'";
            if (isChecked[3])
                filter += $" and [Ngày thi] = '{ngayThi}'";
            if (isChecked[4])
                filter += $" and [Số câu hỏi] = {soCauHoi}";
            if (isChecked[5])
                filter += $" and [Số tín chỉ] ={soTinChi}";
            this.m_bangMonThi.DefaultView.RowFilter = filter;
        }

        private string KiemTraDuLieu(string maMonThi,string tenMonThi,string hocKy)
        {
            string loi = "";
            if (string.IsNullOrEmpty(maMonThi))
                loi += "'mã môn thi'";
            if (string.IsNullOrEmpty(tenMonThi))
                loi += "'tên môn thi'";
            if (string.IsNullOrEmpty(hocKy))
                loi += "'năm học'";
            return loi;
        }
    }
}
