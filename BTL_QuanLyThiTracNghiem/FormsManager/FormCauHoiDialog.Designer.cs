namespace BTL_QuanLyThiTracNghiem.FormsManager
{
    partial class FormCauHoiDialog
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_container = new System.Windows.Forms.Panel();
            this.button_timKiem = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label_luuY = new System.Windows.Forms.Label();
            this.button_lamMoi = new System.Windows.Forms.Button();
            this.button_them = new System.Windows.Forms.Button();
            this.panel_cauHoi = new System.Windows.Forms.Panel();
            this.groupbox_dapAn = new System.Windows.Forms.GroupBox();
            this.textbox_D = new System.Windows.Forms.TextBox();
            this.textbox_C = new System.Windows.Forms.TextBox();
            this.textbox_B = new System.Windows.Forms.TextBox();
            this.textbox_A = new System.Windows.Forms.TextBox();
            this.radiobutton_D = new System.Windows.Forms.RadioButton();
            this.radiobutton_C = new System.Windows.Forms.RadioButton();
            this.radiobutton_B = new System.Windows.Forms.RadioButton();
            this.radiobutton_A = new System.Windows.Forms.RadioButton();
            this.comboBox_doKho = new System.Windows.Forms.ComboBox();
            this.label_doKho = new System.Windows.Forms.Label();
            this.groupbox_noiDungCauHoi = new System.Windows.Forms.GroupBox();
            this.textbox_noiDungCauHoi = new System.Windows.Forms.TextBox();
            this.label_monThi = new System.Windows.Forms.Label();
            this.label_chuong = new System.Windows.Forms.Label();
            this.comboBox_chuong = new System.Windows.Forms.ComboBox();
            this.groupbox_hinhAnh = new System.Windows.Forms.GroupBox();
            this.textBox_duongDan = new System.Windows.Forms.TextBox();
            this.label_duongDan = new System.Windows.Forms.Label();
            this.picturebox = new System.Windows.Forms.PictureBox();
            this.openFileDialog_image = new System.Windows.Forms.OpenFileDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel_cauHoi.SuspendLayout();
            this.groupbox_dapAn.SuspendLayout();
            this.groupbox_noiDungCauHoi.SuspendLayout();
            this.groupbox_hinhAnh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_container
            // 
            this.panel_container.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.panel_container.Controls.Add(this.button_timKiem);
            this.panel_container.Controls.Add(this.dataGridView);
            this.panel_container.Controls.Add(this.label_luuY);
            this.panel_container.Controls.Add(this.button_lamMoi);
            this.panel_container.Controls.Add(this.button_them);
            this.panel_container.Controls.Add(this.panel_cauHoi);
            this.panel_container.Controls.Add(this.groupbox_hinhAnh);
            this.panel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_container.Location = new System.Drawing.Point(0, 0);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(1320, 920);
            this.panel_container.TabIndex = 0;
            // 
            // button_timKiem
            // 
            this.button_timKiem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_timKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_timKiem.Location = new System.Drawing.Point(1111, 478);
            this.button_timKiem.Name = "button_timKiem";
            this.button_timKiem.Size = new System.Drawing.Size(87, 41);
            this.button_timKiem.TabIndex = 16;
            this.button_timKiem.Tag = "";
            this.button_timKiem.Text = "Tìm kiếm";
            this.button_timKiem.UseVisualStyleBackColor = false;
            this.button_timKiem.Click += new System.EventHandler(this.button_search_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dataGridView.BackgroundColor = System.Drawing.Color.Beige;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(0, 564);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(1320, 356);
            this.dataGridView.TabIndex = 15;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_question_CellDoubleClick);
            this.dataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_question_CellFormatting);
            // 
            // label_luuY
            // 
            this.label_luuY.AutoSize = true;
            this.label_luuY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_luuY.ForeColor = System.Drawing.Color.Red;
            this.label_luuY.Location = new System.Drawing.Point(13, 542);
            this.label_luuY.Name = "label_luuY";
            this.label_luuY.Size = new System.Drawing.Size(212, 16);
            this.label_luuY.TabIndex = 13;
            this.label_luuY.Text = "click double để xem chi tiết câu hỏi";
            // 
            // button_lamMoi
            // 
            this.button_lamMoi.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_lamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_lamMoi.Location = new System.Drawing.Point(1018, 478);
            this.button_lamMoi.Name = "button_lamMoi";
            this.button_lamMoi.Size = new System.Drawing.Size(87, 41);
            this.button_lamMoi.TabIndex = 12;
            this.button_lamMoi.Tag = "";
            this.button_lamMoi.Text = "Làm mới";
            this.button_lamMoi.UseVisualStyleBackColor = false;
            this.button_lamMoi.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // button_them
            // 
            this.button_them.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_them.Location = new System.Drawing.Point(925, 478);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(87, 41);
            this.button_them.TabIndex = 8;
            this.button_them.Tag = "";
            this.button_them.Text = "Thêm";
            this.button_them.UseVisualStyleBackColor = false;
            this.button_them.Click += new System.EventHandler(this.button_insert_Click);
            // 
            // panel_cauHoi
            // 
            this.panel_cauHoi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_cauHoi.Controls.Add(this.groupbox_dapAn);
            this.panel_cauHoi.Controls.Add(this.comboBox_doKho);
            this.panel_cauHoi.Controls.Add(this.label_doKho);
            this.panel_cauHoi.Controls.Add(this.groupbox_noiDungCauHoi);
            this.panel_cauHoi.Controls.Add(this.label_monThi);
            this.panel_cauHoi.Controls.Add(this.label_chuong);
            this.panel_cauHoi.Controls.Add(this.comboBox_chuong);
            this.panel_cauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel_cauHoi.Location = new System.Drawing.Point(12, 12);
            this.panel_cauHoi.Name = "panel_cauHoi";
            this.panel_cauHoi.Size = new System.Drawing.Size(758, 507);
            this.panel_cauHoi.TabIndex = 4;
            // 
            // groupbox_dapAn
            // 
            this.groupbox_dapAn.Controls.Add(this.textbox_D);
            this.groupbox_dapAn.Controls.Add(this.textbox_C);
            this.groupbox_dapAn.Controls.Add(this.textbox_B);
            this.groupbox_dapAn.Controls.Add(this.textbox_A);
            this.groupbox_dapAn.Controls.Add(this.radiobutton_D);
            this.groupbox_dapAn.Controls.Add(this.radiobutton_C);
            this.groupbox_dapAn.Controls.Add(this.radiobutton_B);
            this.groupbox_dapAn.Controls.Add(this.radiobutton_A);
            this.groupbox_dapAn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox_dapAn.ForeColor = System.Drawing.Color.Red;
            this.groupbox_dapAn.Location = new System.Drawing.Point(3, 241);
            this.groupbox_dapAn.Name = "groupbox_dapAn";
            this.groupbox_dapAn.Size = new System.Drawing.Size(750, 261);
            this.groupbox_dapAn.TabIndex = 3;
            this.groupbox_dapAn.TabStop = false;
            this.groupbox_dapAn.Text = "Đáp án";
            // 
            // textbox_D
            // 
            this.textbox_D.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbox_D.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_D.Location = new System.Drawing.Point(407, 152);
            this.textbox_D.Multiline = true;
            this.textbox_D.Name = "textbox_D";
            this.textbox_D.ReadOnly = true;
            this.textbox_D.Size = new System.Drawing.Size(267, 90);
            this.textbox_D.TabIndex = 7;
            // 
            // textbox_C
            // 
            this.textbox_C.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbox_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_C.Location = new System.Drawing.Point(66, 152);
            this.textbox_C.Multiline = true;
            this.textbox_C.Name = "textbox_C";
            this.textbox_C.ReadOnly = true;
            this.textbox_C.Size = new System.Drawing.Size(267, 90);
            this.textbox_C.TabIndex = 6;
            // 
            // textbox_B
            // 
            this.textbox_B.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbox_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_B.Location = new System.Drawing.Point(407, 40);
            this.textbox_B.Multiline = true;
            this.textbox_B.Name = "textbox_B";
            this.textbox_B.ReadOnly = true;
            this.textbox_B.Size = new System.Drawing.Size(267, 86);
            this.textbox_B.TabIndex = 5;
            // 
            // textbox_A
            // 
            this.textbox_A.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textbox_A.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_A.Location = new System.Drawing.Point(66, 40);
            this.textbox_A.Margin = new System.Windows.Forms.Padding(5);
            this.textbox_A.Multiline = true;
            this.textbox_A.Name = "textbox_A";
            this.textbox_A.ReadOnly = true;
            this.textbox_A.Size = new System.Drawing.Size(267, 86);
            this.textbox_A.TabIndex = 4;
            // 
            // radiobutton_D
            // 
            this.radiobutton_D.AutoSize = true;
            this.radiobutton_D.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radiobutton_D.ForeColor = System.Drawing.SystemColors.WindowText;
            this.radiobutton_D.Location = new System.Drawing.Point(360, 152);
            this.radiobutton_D.Name = "radiobutton_D";
            this.radiobutton_D.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radiobutton_D.Size = new System.Drawing.Size(41, 28);
            this.radiobutton_D.TabIndex = 3;
            this.radiobutton_D.Text = "D";
            this.radiobutton_D.UseVisualStyleBackColor = true;
            // 
            // radiobutton_C
            // 
            this.radiobutton_C.AutoSize = true;
            this.radiobutton_C.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radiobutton_C.ForeColor = System.Drawing.SystemColors.WindowText;
            this.radiobutton_C.Location = new System.Drawing.Point(18, 152);
            this.radiobutton_C.Name = "radiobutton_C";
            this.radiobutton_C.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radiobutton_C.Size = new System.Drawing.Size(41, 28);
            this.radiobutton_C.TabIndex = 2;
            this.radiobutton_C.Text = "C";
            this.radiobutton_C.UseVisualStyleBackColor = true;
            // 
            // radiobutton_B
            // 
            this.radiobutton_B.AutoSize = true;
            this.radiobutton_B.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radiobutton_B.ForeColor = System.Drawing.SystemColors.WindowText;
            this.radiobutton_B.Location = new System.Drawing.Point(361, 43);
            this.radiobutton_B.Name = "radiobutton_B";
            this.radiobutton_B.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radiobutton_B.Size = new System.Drawing.Size(40, 28);
            this.radiobutton_B.TabIndex = 1;
            this.radiobutton_B.Text = "B";
            this.radiobutton_B.UseVisualStyleBackColor = true;
            // 
            // radiobutton_A
            // 
            this.radiobutton_A.AutoSize = true;
            this.radiobutton_A.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radiobutton_A.ForeColor = System.Drawing.SystemColors.WindowText;
            this.radiobutton_A.Location = new System.Drawing.Point(20, 42);
            this.radiobutton_A.Name = "radiobutton_A";
            this.radiobutton_A.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radiobutton_A.Size = new System.Drawing.Size(41, 28);
            this.radiobutton_A.TabIndex = 0;
            this.radiobutton_A.Text = "A";
            this.radiobutton_A.UseVisualStyleBackColor = true;
            // 
            // comboBox_doKho
            // 
            this.comboBox_doKho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_doKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_doKho.FormattingEnabled = true;
            this.comboBox_doKho.Location = new System.Drawing.Point(647, 37);
            this.comboBox_doKho.Name = "comboBox_doKho";
            this.comboBox_doKho.Size = new System.Drawing.Size(106, 24);
            this.comboBox_doKho.TabIndex = 13;
            // 
            // label_doKho
            // 
            this.label_doKho.AutoSize = true;
            this.label_doKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_doKho.ForeColor = System.Drawing.Color.Red;
            this.label_doKho.Location = new System.Drawing.Point(571, 37);
            this.label_doKho.Name = "label_doKho";
            this.label_doKho.Size = new System.Drawing.Size(70, 24);
            this.label_doKho.TabIndex = 12;
            this.label_doKho.Text = "Độ khó";
            // 
            // groupbox_noiDungCauHoi
            // 
            this.groupbox_noiDungCauHoi.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.groupbox_noiDungCauHoi.Controls.Add(this.textbox_noiDungCauHoi);
            this.groupbox_noiDungCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox_noiDungCauHoi.ForeColor = System.Drawing.Color.Red;
            this.groupbox_noiDungCauHoi.Location = new System.Drawing.Point(3, 69);
            this.groupbox_noiDungCauHoi.Name = "groupbox_noiDungCauHoi";
            this.groupbox_noiDungCauHoi.Size = new System.Drawing.Size(750, 166);
            this.groupbox_noiDungCauHoi.TabIndex = 2;
            this.groupbox_noiDungCauHoi.TabStop = false;
            this.groupbox_noiDungCauHoi.Text = "Câu hỏi";
            // 
            // textbox_noiDungCauHoi
            // 
            this.textbox_noiDungCauHoi.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textbox_noiDungCauHoi.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textbox_noiDungCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_noiDungCauHoi.Location = new System.Drawing.Point(6, 28);
            this.textbox_noiDungCauHoi.Multiline = true;
            this.textbox_noiDungCauHoi.Name = "textbox_noiDungCauHoi";
            this.textbox_noiDungCauHoi.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textbox_noiDungCauHoi.Size = new System.Drawing.Size(738, 132);
            this.textbox_noiDungCauHoi.TabIndex = 8;
            // 
            // label_monThi
            // 
            this.label_monThi.AutoSize = true;
            this.label_monThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_monThi.ForeColor = System.Drawing.Color.Red;
            this.label_monThi.Location = new System.Drawing.Point(185, 10);
            this.label_monThi.Name = "label_monThi";
            this.label_monThi.Size = new System.Drawing.Size(77, 24);
            this.label_monThi.TabIndex = 8;
            this.label_monThi.Text = "Môn thi:";
            // 
            // label_chuong
            // 
            this.label_chuong.AutoSize = true;
            this.label_chuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_chuong.ForeColor = System.Drawing.Color.Red;
            this.label_chuong.Location = new System.Drawing.Point(5, 37);
            this.label_chuong.Name = "label_chuong";
            this.label_chuong.Size = new System.Drawing.Size(78, 24);
            this.label_chuong.TabIndex = 11;
            this.label_chuong.Text = "Chương";
            // 
            // comboBox_chuong
            // 
            this.comboBox_chuong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_chuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_chuong.FormattingEnabled = true;
            this.comboBox_chuong.Location = new System.Drawing.Point(89, 37);
            this.comboBox_chuong.Name = "comboBox_chuong";
            this.comboBox_chuong.Size = new System.Drawing.Size(243, 24);
            this.comboBox_chuong.TabIndex = 10;
            // 
            // groupbox_hinhAnh
            // 
            this.groupbox_hinhAnh.Controls.Add(this.textBox_duongDan);
            this.groupbox_hinhAnh.Controls.Add(this.label_duongDan);
            this.groupbox_hinhAnh.Controls.Add(this.picturebox);
            this.groupbox_hinhAnh.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox_hinhAnh.ForeColor = System.Drawing.Color.Red;
            this.groupbox_hinhAnh.Location = new System.Drawing.Point(776, 12);
            this.groupbox_hinhAnh.Name = "groupbox_hinhAnh";
            this.groupbox_hinhAnh.Size = new System.Drawing.Size(541, 255);
            this.groupbox_hinhAnh.TabIndex = 4;
            this.groupbox_hinhAnh.TabStop = false;
            this.groupbox_hinhAnh.Text = "Hình ảnh";
            // 
            // textBox_duongDan
            // 
            this.textBox_duongDan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_duongDan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_duongDan.Location = new System.Drawing.Point(183, 150);
            this.textBox_duongDan.Multiline = true;
            this.textBox_duongDan.Name = "textBox_duongDan";
            this.textBox_duongDan.ReadOnly = true;
            this.textBox_duongDan.Size = new System.Drawing.Size(352, 86);
            this.textBox_duongDan.TabIndex = 8;
            // 
            // label_duongDan
            // 
            this.label_duongDan.AutoSize = true;
            this.label_duongDan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_duongDan.ForeColor = System.Drawing.Color.Red;
            this.label_duongDan.Location = new System.Drawing.Point(183, 125);
            this.label_duongDan.Name = "label_duongDan";
            this.label_duongDan.Size = new System.Drawing.Size(104, 24);
            this.label_duongDan.TabIndex = 14;
            this.label_duongDan.Text = "Đường dẫn";
            // 
            // picturebox
            // 
            this.picturebox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picturebox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picturebox.Location = new System.Drawing.Point(3, 25);
            this.picturebox.Name = "picturebox";
            this.picturebox.Size = new System.Drawing.Size(174, 212);
            this.picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picturebox.TabIndex = 0;
            this.picturebox.TabStop = false;
            // 
            // openFileDialog_image
            // 
            this.openFileDialog_image.Filter = "File image|*.jpg;*.jpeg;*.png;*.gif;*.tif";
            // 
            // FormCauHoiDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 920);
            this.Controls.Add(this.panel_container);
            this.Name = "FormCauHoiDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCauHoiDialog";
            this.Activated += new System.EventHandler(this.FormCauHoiDialog_Activated);
            this.Load += new System.EventHandler(this.FormLamBaiThi_Load);
            this.panel_container.ResumeLayout(false);
            this.panel_container.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel_cauHoi.ResumeLayout(false);
            this.panel_cauHoi.PerformLayout();
            this.groupbox_dapAn.ResumeLayout(false);
            this.groupbox_dapAn.PerformLayout();
            this.groupbox_noiDungCauHoi.ResumeLayout(false);
            this.groupbox_noiDungCauHoi.PerformLayout();
            this.groupbox_hinhAnh.ResumeLayout(false);
            this.groupbox_hinhAnh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_container;
        private System.Windows.Forms.GroupBox groupbox_noiDungCauHoi;
        private System.Windows.Forms.Panel panel_cauHoi;
        private System.Windows.Forms.GroupBox groupbox_dapAn;
        private System.Windows.Forms.GroupBox groupbox_hinhAnh;
        private System.Windows.Forms.PictureBox picturebox;
        private System.Windows.Forms.RadioButton radiobutton_D;
        private System.Windows.Forms.RadioButton radiobutton_C;
        private System.Windows.Forms.RadioButton radiobutton_B;
        private System.Windows.Forms.RadioButton radiobutton_A;
        private System.Windows.Forms.TextBox textbox_A;
        private System.Windows.Forms.TextBox textbox_D;
        private System.Windows.Forms.TextBox textbox_C;
        private System.Windows.Forms.TextBox textbox_B;
        private System.Windows.Forms.TextBox textbox_noiDungCauHoi;
        private System.Windows.Forms.Label label_monThi;
        private System.Windows.Forms.Label label_chuong;
        private System.Windows.Forms.ComboBox comboBox_chuong;
        private System.Windows.Forms.Label label_doKho;
        private System.Windows.Forms.ComboBox comboBox_doKho;
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.OpenFileDialog openFileDialog_image;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Label label_luuY;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox textBox_duongDan;
        private System.Windows.Forms.Label label_duongDan;
        private System.Windows.Forms.Button button_timKiem;
        private System.Windows.Forms.Button button_lamMoi;
    }
}