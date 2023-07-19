namespace BTL_QuanLyThiTracNghiem.FormsManager
{
    partial class FormTaoDeThi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_container = new System.Windows.Forms.Panel();
            this.button_deletequestion = new System.Windows.Forms.Button();
            this.label_listquestion = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox_infoexam = new System.Windows.Forms.GroupBox();
            this.label_numbersquestion = new System.Windows.Forms.Label();
            this.label_subject = new System.Windows.Forms.Label();
            this.comboBox_subject = new System.Windows.Forms.ComboBox();
            this.label_examcode = new System.Windows.Forms.Label();
            this.comboBox_examcode = new System.Windows.Forms.ComboBox();
            this.button_deleteexamcode = new System.Windows.Forms.Button();
            this.button_addquestion = new System.Windows.Forms.Button();
            this.button_addexamcode = new System.Windows.Forms.Button();
            this.panel_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox_infoexam.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_container
            // 
            this.panel_container.Controls.Add(this.button_deletequestion);
            this.panel_container.Controls.Add(this.label_listquestion);
            this.panel_container.Controls.Add(this.dataGridView);
            this.panel_container.Controls.Add(this.groupBox_infoexam);
            this.panel_container.Controls.Add(this.button_deleteexamcode);
            this.panel_container.Controls.Add(this.button_addquestion);
            this.panel_container.Controls.Add(this.button_addexamcode);
            this.panel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_container.Location = new System.Drawing.Point(0, 0);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(699, 614);
            this.panel_container.TabIndex = 0;
            // 
            // button_deletequestion
            // 
            this.button_deletequestion.BackColor = System.Drawing.Color.Red;
            this.button_deletequestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_deletequestion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_deletequestion.Location = new System.Drawing.Point(588, 81);
            this.button_deletequestion.Name = "button_deletequestion";
            this.button_deletequestion.Size = new System.Drawing.Size(84, 42);
            this.button_deletequestion.TabIndex = 9;
            this.button_deletequestion.Text = "Xóa câu hỏi";
            this.button_deletequestion.UseVisualStyleBackColor = false;
            this.button_deletequestion.Click += new System.EventHandler(this.button_deletequestion_Click);
            // 
            // label_listquestion
            // 
            this.label_listquestion.AutoSize = true;
            this.label_listquestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_listquestion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_listquestion.Location = new System.Drawing.Point(255, 206);
            this.label_listquestion.Name = "label_listquestion";
            this.label_listquestion.Size = new System.Drawing.Size(208, 25);
            this.label_listquestion.TabIndex = 4;
            this.label_listquestion.Text = "Danh sách câu hỏi";
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(0, 234);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(699, 380);
            this.dataGridView.TabIndex = 8;
            // 
            // groupBox_infoexam
            // 
            this.groupBox_infoexam.Controls.Add(this.label_numbersquestion);
            this.groupBox_infoexam.Controls.Add(this.label_subject);
            this.groupBox_infoexam.Controls.Add(this.comboBox_subject);
            this.groupBox_infoexam.Controls.Add(this.label_examcode);
            this.groupBox_infoexam.Controls.Add(this.comboBox_examcode);
            this.groupBox_infoexam.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_infoexam.ForeColor = System.Drawing.Color.Red;
            this.groupBox_infoexam.Location = new System.Drawing.Point(12, 12);
            this.groupBox_infoexam.Name = "groupBox_infoexam";
            this.groupBox_infoexam.Size = new System.Drawing.Size(441, 165);
            this.groupBox_infoexam.TabIndex = 7;
            this.groupBox_infoexam.TabStop = false;
            this.groupBox_infoexam.Text = "Thông tin đề thi";
            // 
            // label_numbersquestion
            // 
            this.label_numbersquestion.AutoSize = true;
            this.label_numbersquestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_numbersquestion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_numbersquestion.Location = new System.Drawing.Point(6, 46);
            this.label_numbersquestion.Name = "label_numbersquestion";
            this.label_numbersquestion.Size = new System.Drawing.Size(63, 20);
            this.label_numbersquestion.TabIndex = 0;
            this.label_numbersquestion.Text = "Số câu:";
            // 
            // label_subject
            // 
            this.label_subject.AutoSize = true;
            this.label_subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_subject.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_subject.Location = new System.Drawing.Point(217, 46);
            this.label_subject.Name = "label_subject";
            this.label_subject.Size = new System.Drawing.Size(61, 20);
            this.label_subject.TabIndex = 1;
            this.label_subject.Text = "Môn thi";
            // 
            // comboBox_subject
            // 
            this.comboBox_subject.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_subject.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_subject.FormattingEnabled = true;
            this.comboBox_subject.Location = new System.Drawing.Point(284, 42);
            this.comboBox_subject.Name = "comboBox_subject";
            this.comboBox_subject.Size = new System.Drawing.Size(137, 24);
            this.comboBox_subject.TabIndex = 0;
            // 
            // label_examcode
            // 
            this.label_examcode.AutoSize = true;
            this.label_examcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_examcode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_examcode.Location = new System.Drawing.Point(225, 129);
            this.label_examcode.Name = "label_examcode";
            this.label_examcode.Size = new System.Drawing.Size(53, 20);
            this.label_examcode.TabIndex = 3;
            this.label_examcode.Text = "Mã đề";
            // 
            // comboBox_examcode
            // 
            this.comboBox_examcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_examcode.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_examcode.FormattingEnabled = true;
            this.comboBox_examcode.Location = new System.Drawing.Point(284, 125);
            this.comboBox_examcode.Name = "comboBox_examcode";
            this.comboBox_examcode.Size = new System.Drawing.Size(137, 24);
            this.comboBox_examcode.TabIndex = 2;
            // 
            // button_deleteexamcode
            // 
            this.button_deleteexamcode.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_deleteexamcode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_deleteexamcode.Location = new System.Drawing.Point(486, 81);
            this.button_deleteexamcode.Name = "button_deleteexamcode";
            this.button_deleteexamcode.Size = new System.Drawing.Size(75, 42);
            this.button_deleteexamcode.TabIndex = 6;
            this.button_deleteexamcode.Text = "Xóa mã đề";
            this.button_deleteexamcode.UseVisualStyleBackColor = false;
            this.button_deleteexamcode.Click += new System.EventHandler(this.button_deleteexamcode_Click);
            // 
            // button_addquestion
            // 
            this.button_addquestion.BackColor = System.Drawing.Color.Red;
            this.button_addquestion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_addquestion.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button_addquestion.Location = new System.Drawing.Point(588, 23);
            this.button_addquestion.Name = "button_addquestion";
            this.button_addquestion.Size = new System.Drawing.Size(84, 42);
            this.button_addquestion.TabIndex = 5;
            this.button_addquestion.Text = "Thêm câu hỏi";
            this.button_addquestion.UseVisualStyleBackColor = false;
            this.button_addquestion.Click += new System.EventHandler(this.button_addquestion_Click);
            // 
            // button_addexamcode
            // 
            this.button_addexamcode.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_addexamcode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_addexamcode.Location = new System.Drawing.Point(486, 23);
            this.button_addexamcode.Name = "button_addexamcode";
            this.button_addexamcode.Size = new System.Drawing.Size(75, 42);
            this.button_addexamcode.TabIndex = 4;
            this.button_addexamcode.Text = "Thêm mã đề";
            this.button_addexamcode.UseVisualStyleBackColor = false;
            this.button_addexamcode.Click += new System.EventHandler(this.button_addexamcode_Click);
            // 
            // FormTaoDeThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 614);
            this.Controls.Add(this.panel_container);
            this.Name = "FormTaoDeThi";
            this.Text = "Form Tạo đề thi";
            this.Activated += new System.EventHandler(this.FormTaoDeThi_Activated);
            this.Load += new System.EventHandler(this.FormTaoDeThi_Load);
            this.panel_container.ResumeLayout(false);
            this.panel_container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox_infoexam.ResumeLayout(false);
            this.groupBox_infoexam.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_container;
        private System.Windows.Forms.ComboBox comboBox_subject;
        private System.Windows.Forms.Label label_subject;
        private System.Windows.Forms.ComboBox comboBox_examcode;
        private System.Windows.Forms.Label label_examcode;
        private System.Windows.Forms.Button button_addexamcode;
        private System.Windows.Forms.Button button_addquestion;
        private System.Windows.Forms.Button button_deleteexamcode;
        private System.Windows.Forms.GroupBox groupBox_infoexam;
        private System.Windows.Forms.Label label_numbersquestion;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label_listquestion;
        private System.Windows.Forms.Button button_deletequestion;
    }
}