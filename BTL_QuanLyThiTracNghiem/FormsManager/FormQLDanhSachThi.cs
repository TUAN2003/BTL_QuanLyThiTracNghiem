using BTL_QuanLyThiTracNghiem.Constants;
using BTL_QuanLyThiTracNghiem.FormsManager.Reporting;
using BTL_QuanLyThiTracNghiem.QuerysDB;
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLyThiTracNghiem.FormsManager
{
    public partial class FormQLDanhSachThi : Form
    {
        private DataTable m_danhSachThi;
        private DataTable m_bangMonThi;
        private DataTable m_danhSachChuaThi;
        private DataTable m_danhSachThi_Temp;
        private DataTable m_danhSachChuaThi_Temp;

        public FormQLDanhSachThi()
        {
            InitializeComponent();
        }
        private void FormQLDanhSachThi_Load(object sender, EventArgs e)
        {
            m_danhSachThi = QuerysDB.SelectDB.GetTable("select * from tblDanhSachThi");
            this.dataGridView_danhSachThi.DataSource = m_danhSachThi;
            m_danhSachThi.Columns["vcMaMonThi"].ColumnName = "Mã môn thi";
            m_danhSachThi.Columns["vcMaSinhVien"].ColumnName = "Mã thí sinh";
            m_danhSachThi.Columns["bTrangThaiThi"].ColumnName = "Trạng thái thi";
            m_danhSachThi.Columns["vcMaXacNhan"].ColumnName = "Mã xác nhận";
            m_bangMonThi = QuerysDB.SelectDB.GetTable("select vcMaMonThi,nvcTenMonThi from tblMonThi");
            this.comboBox_monThi.DataSource = m_bangMonThi;
            this.comboBox_monThi.DisplayMember = "nvcTenMonThi";
            this.comboBox_monThi.ValueMember = "vcMaMonThi";
            DataRow r = m_bangMonThi.NewRow();
            r["vcMaMonThi"] = "";
            r["nvcTenMonThi"] = "(trống)";
            m_bangMonThi.Rows.InsertAt(r, 0);
            this.comboBox_monThi.SelectedValue = "";
            m_danhSachChuaThi = this.LoadDataFromExcel(path: @"I:\danh sach đang ki hoc.xlsx", nameSheet: "Sheet1");
            this.dataGridView_danhSachChuaThi.DataSource = m_danhSachChuaThi;
            m_danhSachThi_Temp = m_danhSachThi.Clone();
            m_danhSachChuaThi_Temp = m_danhSachChuaThi.Clone();
            this.button_save.Enabled = false;
        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            //chưa thực hiện
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            string maMonThi = this.comboBox_monThi.SelectedValue.ToString();
            string maSinhVien = this.textBox_maSinhVien.Text.Trim();
            string loi = KiemTraDuLieuNhapVao(maMonThi, maSinhVien);
            if (!loi.Equals(""))
            {
                MessageBox.Show(loi, "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            ThemSinhVienVaoDSThi(maMonThi, maSinhVien, 0);
        }

        private string RandomCodeGeneration()
        {
            string s = "";
            Random rd = new Random();
            int min = 0;
            int max = Utilities._CHARS.Length;
            for (int i = 0; i < 5; i++)
                s += Utilities._CHARS[rd.Next(min, max)];
            return s;
        }

        private void button_sua_Click(object sender, EventArgs e)
        {

        }

        private string KiemTraDuLieuNhapVao(string maMonThi, string maSinHVien)
        {
            string loi = "";
            if (maMonThi.Equals(""))
                loi += "chưa chọn mã môn thi,";
            if (maSinHVien.Equals(""))
                loi += "chưa nhập mã sinh viên";
            return loi;
        }

        private void button_timKiem_Click(object sender, EventArgs e)
        {
            string maMonThi = this.comboBox_monThi.SelectedValue.ToString();
            string maSinhVien = this.textBox_maSinhVien.Text.Trim();
            string filter = "1=1";
            if (!maMonThi.Equals(""))
                filter += $" and [Mã môn thi] = '{maMonThi}'";
            if (!maSinhVien.Equals(""))
                filter += $" and [Mã thí sinh] like '%{maSinhVien}%'";
            this.m_danhSachThi.DefaultView.RowFilter = filter;
        }
        protected DataTable LoadDataFromExcel(string path, string nameSheet)
        {
            DataTableCollection tableCollection = null;
            DataTable table = null;
            using (var stream = File.Open(path, FileMode.Open, FileAccess.Read))
            {
                using (IExcelDataReader iReader = ExcelReaderFactory.CreateReader(stream))
                {
                    DataSet result = iReader.AsDataSet(new ExcelDataSetConfiguration()
                    {
                        ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                    });
                    tableCollection = result.Tables;
                }
            }
            try
            {
                table = tableCollection[nameSheet];
            }
            catch (Exception)
            {
                throw;
            }
            return table;
        }

        private void button_left_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dataGridView_danhSachChuaThi.SelectedRows)
            {
                if (row.DataBoundItem != null)
                {
                    string maMonThi = row.Cells[0].Value.ToString();
                    string maSinhVien = row.Cells[1].Value.ToString();
                    Thread.Sleep(1);
                    ThemSinhVienVaoDSThi(typeInsert: 1, maMonThi: maMonThi, maSinhVien: maSinhVien);
                }
                dataGridView_danhSachChuaThi.Rows.Remove(row);
            }
        }

        private void button_right_Click(object sender, EventArgs e)
        {
            /*m_saveOnOff = true;
            foreach (DataGridViewRow row in dataGridView_danhSachThi.SelectedRows)
            {
                if (row.DataBoundItem != null && row)
                {
                    string maMonThi = row.Cells[0].Value.ToString();
                    string maSinhVien = row.Cells[1].Value.ToString();
                    Thread.Sleep(1);
                    ThemSinhVienVaoDSThi(typeInsert: 1, maMonThi: maMonThi, maSinhVien: maSinhVien);
                }
                dataGridView_danhSachChuaThi.Rows.Remove(row);
            }*/
        }

        /// <summary>
        /// hàm này nếu typeInsert=0 thì thêm bản ghi xuống DB còn lại chỉ thêm bản ghi vào DataTable
        /// </summary>
        /// <param name="maMonThi"></param>
        /// <param name="maSinhVien"></param>
        /// <param name="typeInsert"></param>
        private void ThemSinhVienVaoDSThi(string maMonThi, string maSinhVien, int typeInsert)
        {
            string maXacNhan = this.RandomCodeGeneration();
            if (typeInsert == 0)
            {
                string[] paramss = { "@vcMaMonThi", "@vcMaSinhVien", "@vcMaXacNhan" };
                object[] values = { maMonThi, maSinhVien, maXacNhan };
                try
                {
                    TransactionDB.Transaction("sp_themSinhVienVaoDanhSachThi", CommandType.StoredProcedure, paramss, values);
                    MessageBox.Show("Thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    m_danhSachThi.Rows.Add(values[0], values[1], false, values[2]);
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 2627)
                        MessageBox.Show($"mã sinh viên {maSinhVien} và mã môn thi {maMonThi} đã có trong danh sách", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("chưa được thêm vì có lỗi", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //DataRow 
                m_danhSachThi.Rows.Add(maMonThi, maSinhVien, false, maXacNhan);
                m_danhSachThi_Temp.Rows.Add(maMonThi, maSinhVien, false, maXacNhan);
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {

        }

        private void button_save_EnabledChanged(object sender, EventArgs e)
        {
            if (button_save.Enabled)
                this.button_save.BackColor = Color.LightSkyBlue;
            else
                this.button_save.BackColor = Color.LightGray;
        }
    }
}