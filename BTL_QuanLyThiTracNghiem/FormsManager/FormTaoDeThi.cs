using BTL_QuanLyThiTracNghiem.QuerysDB;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using aaa = BTL_QuanLyThiTracNghiem.QuerysDB.SelectDB;

namespace BTL_QuanLyThiTracNghiem.FormsManager
{
    public partial class FormTaoDeThi : Form
    {
        private DataTable m_table = new DataTable();
        private int m_idExam;
        public FormTaoDeThi()
        {
            InitializeComponent();
        }
        public int IdExam
        {
            set => m_idExam = value;
            get => m_idExam;
        }
        public DataTable Table
        {
            get { return m_table; }
            set { m_table = value; }
        }
        private void button_addquestion_Click(object sender, EventArgs e)
        {
            FormCauHoiDialog f = Program.FindFormExisting("FormCauHoiDialog") as FormCauHoiDialog;
            if (f == null)
                f = new FormCauHoiDialog();
            f.IdSubject = this.comboBox_subject.SelectedValue.ToString();
            f.IdExam = (int)this.comboBox_examcode.SelectedValue;
            f.FormParent = this;
            f.n =  (int)((DataRowView)this.comboBox_subject.SelectedItem).Row["NumberOfQuestion"]-m_table.Rows.Count;
            f.MdiParent = this.MdiParent;
            f.Show();
            f.Activate();
        }

        private void FormTaoDeThi_Load(object sender, EventArgs e)
        {
            this.comboBox_subject.DataSource = QuerysDB.SelectDB.GetTable("select * from tblSubject");
            this.comboBox_subject.DisplayMember = "NameSubj";
            this.comboBox_subject.ValueMember = "IdSubject";
            string query = string.Format("select IdExam from tblExamCode where IdSubject='{0}'", this.comboBox_subject.SelectedValue);
            this.comboBox_examcode.DataSource = QuerysDB.SelectDB.GetTable(query);
            this.comboBox_examcode.DisplayMember = "IdExam";
            this.comboBox_examcode.ValueMember = "IdExam";
            int numberquestion = (int)((DataRowView)this.comboBox_subject.SelectedItem).Row["NumberOfQuestion"];
            query = string.Format
                ("select tblQuestion.IdQuestion,Content,NameChapter,LevelOfDifficult from tblQuestion where tblQuestion.IdQuestion in (select tblExam.IdQuestion from tblExam where IdExam={0})",
                this.comboBox_examcode.SelectedValue);
            m_table = QuerysDB.SelectDB.GetTable(query);
            this.dataGridView.DataSource = m_table;
            this.label_numbersquestion.Text = "Số câu:" + this.m_table.Rows.Count + "/" + numberquestion;
            if (this.m_table.Rows.Count >= numberquestion)
                this.button_addquestion.Enabled = false;
            else
                this.button_addquestion.Enabled = true;
            this.comboBox_subject.SelectedIndexChanged += new System.EventHandler(this.comboBox_subject_SelectedIndexChanged);
            this.comboBox_examcode.SelectedValueChanged += new System.EventHandler(this.comboBox_examcode_SelectedValueChanged);
        }

        private void comboBox_subject_SelectedIndexChanged(object sender, EventArgs e)
        {
            string query = string.Format("select IdExam from tblExamCode where IdSubject='{0}'", this.comboBox_subject.SelectedValue);
            DataTable t= QuerysDB.SelectDB.GetTable(query);
            this.comboBox_examcode.DataSource = t;
            if (t.Rows.Count == 0)
            {
                this.label_numbersquestion.Text = "Số câu:";
                m_table = QuerysDB.SelectDB.GetTable(query);
                this.dataGridView.DataSource = m_table;
            }
        }

        private void button_addexamcode_Click(object sender, EventArgs e)
        {
            FormInputDialog f = Program.FindFormExisting("FormInputDialog") as FormInputDialog;
            if (f == null)
                f = new FormInputDialog();
            f.Note = "Lưu ý mã đề cần là số có 3 chữ số";
            f.ShowDialog();
            int newCode = 0;
            try
            {
                newCode = Convert.ToInt32(FormInputDialog.g_stringValue);
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Dữ liệu không hợp lệ","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }
            int check = newCode / 100;
            if(check <1 && check>9)
            {
                MessageBox.Show("Dữ liệu không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string[] paramss = {"@IdSubject", "@IdExam" };
            object[] values = {this.comboBox_subject.SelectedValue, newCode };
            try
            {
                TransactionDB.Transaction("sp_insertexamcode",CommandType.StoredProcedure,paramss,values);
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {
                MessageBox.Show("Không thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void button_deleteexamcode_Click(object sender, EventArgs e)
        {
            
        }

        private void FormTaoDeThi_Activated(object sender, EventArgs e)
        {
            this.comboBox_subject.DataSource = QuerysDB.SelectDB.GetTable("select * from tblSubject");
            this.comboBox_subject.DisplayMember = "NameSubj";
            this.comboBox_subject.ValueMember = "IdSubject";
            string query = string.Format("select IdExam from tblExamCode where IdSubject='{0}'", this.comboBox_subject.SelectedValue);
            this.comboBox_examcode.DataSource = QuerysDB.SelectDB.GetTable(query);
            this.comboBox_examcode.DisplayMember = "IdExam";
            this.comboBox_examcode.ValueMember = "IdExam";
            int numberquestion = (int)((DataRowView)this.comboBox_subject.SelectedItem).Row["NumberOfQuestion"];
            query = string.Format
                ("select tblQuestion.IdQuestion,Content,NameChapter,LevelOfDifficult from tblQuestion where tblQuestion.IdQuestion in(select tblExam.IdQuestion from tblExam where IdExam={0})",
                this.comboBox_examcode.SelectedValue);
            m_table = QuerysDB.SelectDB.GetTable(query);
            this.dataGridView.DataSource = m_table;
            this.label_numbersquestion.Text = "Số câu:" + this.m_table.Rows.Count + "/" + numberquestion;
            if (this.m_table.Rows.Count >= numberquestion)
                this.button_addquestion.Enabled = false;
            else
                this.button_addquestion.Enabled = true;
        }

        private void comboBox_examcode_SelectedValueChanged(object sender, EventArgs e)
        {
            int numberquestion = (int)((DataRowView)this.comboBox_subject.SelectedItem).Row["NumberOfQuestion"];
            string query = string.Format
                ("select tblQuestion.IdQuestion,Content,NameChapter,LevelOfDifficult from tblQuestion where tblQuestion.IdQuestion in(select tblExam.IdQuestion from tblExam where IdExam={0})",
                this.comboBox_examcode.SelectedValue);
            m_table = QuerysDB.SelectDB.GetTable(query);
            this.dataGridView.DataSource = m_table;
            this.label_numbersquestion.Text = "Số câu:" + this.m_table.Rows.Count + "/" + numberquestion;
            if (this.m_table.Rows.Count == numberquestion)
                this.button_addquestion.Enabled = false;
            else
                this.button_addquestion.Enabled = true;
        }

        private void button_deletequestion_Click(object sender, EventArgs e)
        {

        }
    }
}
