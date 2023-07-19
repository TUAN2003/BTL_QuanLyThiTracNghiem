using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace BTL_QuanLyThiTracNghiem.FormsManager
{
    public partial class FormCauHoiDialog : Form
    {
        private DataTable m_table;
        private FormTaoDeThi m_formParent;
        private int m_idExam;
        private RadioButton[] m_radioAnswer;
        private string m_idSubject;
        public int n;
        public DataTable Table
        {
            get => this.m_table;
            set => this.m_table = value;
        }
        public FormTaoDeThi FormParent
        {
            set => this.m_formParent = value;
            get => this.m_formParent;
        }
        public int IdExam
        {
            set => m_idExam = value;
            get { return m_idExam; }
        }
        public string IdSubject
        {
            set { m_idSubject = value; }
            get { return m_idSubject; }
        }
        public FormCauHoiDialog()
        {
            InitializeComponent();
            m_radioAnswer = new RadioButton[4] { radiobutton_A, radiobutton_B, radiobutton_C, radiobutton_D };
            List<string> dokho = new List<string>();
            dokho.Add("Nhận biết");
            dokho.Add("Thông hiểu");
            dokho.Add("Vận dụng");
            dokho.Add("Vận dụng cao");
            this.comboBox_doKho.DataSource = dokho;
        }
        private void button_clear_Click(object sender, EventArgs e)
        {
            this.openFileDialog_image.FileName = "";
            this.picturebox.Image = null;
            this.textbox_noiDungCauHoi.Text = "";
            this.textbox_A.Text = "";
            this.textbox_B.Text = "";
            this.textbox_C.Text = "";
            this.textbox_D.Text = "";
            this.textBox_duongDan.Text = "";
            this.dataGridView.DataSource = m_table;
            foreach (RadioButton rb in m_radioAnswer)
                rb.Checked = false;
        }
        //REGION EVENT
        private void FormLamBaiThi_Load(object sender, EventArgs e)
        {
            string queryMonThi = "select NameSubj from tblSubject where IdSubject='"+this.IdSubject+"'";
            this.label_monThi.Text ="Môn:"+(string)QuerysDB.SelectDB.GetAValue(queryMonThi);
            string queryChuong = string.Format("select NameChapter from tblChapter where IdSubject='{0}'", IdSubject);
            this.comboBox_chuong.DataSource = QuerysDB.SelectDB.GetTable(queryChuong, CommandType.Text);
            comboBox_chuong.DisplayMember = "NameChapter";
            comboBox_chuong.ValueMember = "NameChapter";
        }

        private void dataGridView_question_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= dataGridView.RowCount - 1 || e.RowIndex < 0)
                return;
            DataGridViewRow row = dataGridView.Rows[e.RowIndex];
            this.textbox_noiDungCauHoi.Text = row.Cells["Content"].Value.ToString();
            this.textbox_A.Text = row.Cells["AnswerA"].Value.ToString();
            this.textbox_B.Text = row.Cells["AnswerB"].Value.ToString();
            this.textbox_C.Text = row.Cells["AnswerC"].Value.ToString();
            this.textbox_D.Text = row.Cells["AnswerD"].Value.ToString();
            string path_Image = row.Cells["PathImage"].Value.ToString();
            this.textBox_duongDan.Text = path_Image;
            if (!string.IsNullOrEmpty(path_Image))
            {
                try
                {
                    this.picturebox.Image = Image.FromFile(path_Image);
                    this.openFileDialog_image.FileName = path_Image;
                }
                catch (ArgumentException)
                {
                    this.picturebox.Image = null;
                    this.openFileDialog_image.FileName = "";
                }
                catch (FileNotFoundException)
                {
                    this.picturebox.Image = null;
                    this.openFileDialog_image.FileName = "";
                }
            }
            else
            {
                this.picturebox.Image = null;
                this.openFileDialog_image.FileName = "";
            }
            m_radioAnswer[(int)row.Cells["LocationCorrect"].Value - 1].Checked = true;
            this.comboBox_doKho.SelectedIndex = (int)row.Cells["LevelOfDifficult"].Value - 1;
            this.comboBox_chuong.SelectedValue = row.Cells["NameChapter"].Value;
        }
        //INSERT
        private void button_insert_Click(object sender, EventArgs e)
        {
            int nselect = dataGridView.SelectedRows.Count;
            if (nselect > n)
            {
                MessageBox.Show("số lượng câu hỏi vượt quá số lượng câu hỏi quy định của môn thi");
                return;
            }
            DataTable table = new DataTable();
            table.Columns.Add("IdExam");
            table.Columns.Add("IdQuestion");
            for (int i=0;i<this.dataGridView.SelectedRows.Count;i++)
            {
                table.Rows.Add(this.IdExam, dataGridView.SelectedRows[i].Cells["IdQuestion"].Value);
            }
            string[] paramss = {"@tbl"};
            object[] values = {table };
            QuerysDB.TransactionDB.Transaction("sp_insertexam",CommandType.StoredProcedure,paramss,values);
            this.FormParent.IdExam = IdExam;
            MessageBox.Show("Thêm thành công");
            this.n -= table.Rows.Count;
        }

        private void dataGridView_question_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
                e.CellStyle.BackColor = Color.White;
            else
                e.CellStyle.BackColor = Color.LightGray;
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            DataView dv = m_table.AsDataView();
            dv.RowFilter = string.Format
                ("NameChapter='{0}' and LevelOfDifficult={1} and Content like '%{2}%'",
                this.comboBox_chuong.SelectedValue,
                this.comboBox_doKho.SelectedIndex + 1,
                this.textbox_noiDungCauHoi.Text);
            this.dataGridView.DataSource = dv;
        }

        private void FormCauHoiDialog_Activated(object sender, EventArgs e)
        {
            string query = string.Format
                ("select * from tblQuestion where IdSubject='{0}' and IdQuestion not in(select IdQuestion from tblExam where IdExam={1})",IdSubject, this.IdExam);
            m_table=QuerysDB.SelectDB.GetTable(query);
            this.dataGridView.DataSource = this.m_table;
        }
    }
}
