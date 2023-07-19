using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_QuanLyThiTracNghiem.FormsManager
{
    public partial class FormInputDialog : Form
    {
        public static string g_stringValue=null;
        public static bool g_isClickClose=true;

        public Form FormParent
        {
            set;
            get;
        }
        public string IdSubject
        {
            set;
            get;
        }
        public string Note
        {
            set {
                this.label_note.Text = value;
            }
            get
            {
                return label_note.Text;
            }
        }
        public FormInputDialog()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            g_stringValue = this.textBox1.Text.Trim();
            g_isClickClose = false;
            this.Close();
        }

        private void FormInputDialog_Load(object sender, EventArgs e)
        {
            g_stringValue = "";
            g_isClickClose = true;
        }
    }
}
