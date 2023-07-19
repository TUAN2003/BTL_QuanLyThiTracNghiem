using BTL_QuanLyThiTracNghiem.Constants;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLyThiTracNghiem.FormsManager.Reporting
{
    public partial class FormReportViewer : Form
    {
        private string m_fileName;
        private string m_title;
        private string m_filter;
        public object Source;
        public string FileName
        {
            set { m_fileName = value; }
            get { return m_fileName; }
        }
        public string Title
        {
            set { m_title = value; }
            get { return m_title; }
        }
        public string Filter
        {
            set => m_filter = value;
            get => m_filter;
        }
        public FormReportViewer()
        {
            InitializeComponent();
        }

        public FormReportViewer(string title, string filter)
            : this()
        {
            m_title = title;
            m_filter = filter;
        }

        private void FormReportViewer_Load(object sender, EventArgs e)
        {
            ShowReport();
        }

        private void ShowReport()
        {
            rptResult rd = new rptResult();
            rd.Load(rd.FileName);
            TableLogOnInfo tableLogOnInfo = new TableLogOnInfo();
            tableLogOnInfo.ConnectionInfo.ServerName = Constants.ConnectionInfo._SERVER_NAME;
            tableLogOnInfo.ConnectionInfo.UserID = Constants.ConnectionInfo._UID_DB;
            tableLogOnInfo.ConnectionInfo.Password = Constants.ConnectionInfo._PWD_DB;
            tableLogOnInfo.ConnectionInfo.DatabaseName = Constants.ConnectionInfo._DATABASE_NAME;
            foreach (Table item in rd.Database.Tables)
                item.ApplyLogOnInfo(tableLogOnInfo);
            rd.SummaryInfo.ReportTitle = m_title;
            rd.RecordSelectionFormula = m_filter;
            this.crystalReportViewer.ReportSource = rd;
        }
    }
}
