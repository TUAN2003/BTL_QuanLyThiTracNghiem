namespace BTL_QuanLyThiTracNghiem.FormsManager
{
    partial class FormQLMonThi
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.dateTimePicker_ngayThi = new System.Windows.Forms.DateTimePicker();
            this.numericUpDown_soCauHoi = new System.Windows.Forms.NumericUpDown();
            this.label_maMonThi = new System.Windows.Forms.Label();
            this.textBox_maMonThi = new System.Windows.Forms.TextBox();
            this.textBox_tenMonThi = new System.Windows.Forms.TextBox();
            this.textBox_hocKy = new System.Windows.Forms.TextBox();
            this.label_tenMonThi = new System.Windows.Forms.Label();
            this.label_hocKy = new System.Windows.Forms.Label();
            this.numericUpDown_soTinChi = new System.Windows.Forms.NumericUpDown();
            this.label_ngayThi = new System.Windows.Forms.Label();
            this.label_soCauHoi = new System.Windows.Forms.Label();
            this.label_soTinChi = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_timKiem = new System.Windows.Forms.Button();
            this.groupBox_timKiem = new System.Windows.Forms.GroupBox();
            this.checkedListBox_timKiem = new System.Windows.Forms.CheckedListBox();
            this.dateTimePicker_thoiGianThi = new System.Windows.Forms.DateTimePicker();
            this.label_thoiGian = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_soCauHoi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_soTinChi)).BeginInit();
            this.groupBox_timKiem.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(0, 187);
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
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(742, 518);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            // 
            // dateTimePicker_ngayThi
            // 
            this.dateTimePicker_ngayThi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker_ngayThi.Location = new System.Drawing.Point(89, 124);
            this.dateTimePicker_ngayThi.Name = "dateTimePicker_ngayThi";
            this.dateTimePicker_ngayThi.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker_ngayThi.TabIndex = 1;
            // 
            // numericUpDown_soCauHoi
            // 
            this.numericUpDown_soCauHoi.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_soCauHoi.Location = new System.Drawing.Point(381, 20);
            this.numericUpDown_soCauHoi.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDown_soCauHoi.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDown_soCauHoi.Name = "numericUpDown_soCauHoi";
            this.numericUpDown_soCauHoi.Size = new System.Drawing.Size(78, 20);
            this.numericUpDown_soCauHoi.TabIndex = 2;
            this.numericUpDown_soCauHoi.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // label_maMonThi
            // 
            this.label_maMonThi.AutoSize = true;
            this.label_maMonThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_maMonThi.Location = new System.Drawing.Point(12, 20);
            this.label_maMonThi.Name = "label_maMonThi";
            this.label_maMonThi.Size = new System.Drawing.Size(71, 16);
            this.label_maMonThi.TabIndex = 3;
            this.label_maMonThi.Text = "Mã môn thi";
            // 
            // textBox_maMonThi
            // 
            this.textBox_maMonThi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_maMonThi.Location = new System.Drawing.Point(89, 17);
            this.textBox_maMonThi.MaxLength = 5;
            this.textBox_maMonThi.Name = "textBox_maMonThi";
            this.textBox_maMonThi.Size = new System.Drawing.Size(162, 20);
            this.textBox_maMonThi.TabIndex = 4;
            // 
            // textBox_tenMonThi
            // 
            this.textBox_tenMonThi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_tenMonThi.Location = new System.Drawing.Point(89, 52);
            this.textBox_tenMonThi.MaxLength = 50;
            this.textBox_tenMonThi.Name = "textBox_tenMonThi";
            this.textBox_tenMonThi.Size = new System.Drawing.Size(162, 20);
            this.textBox_tenMonThi.TabIndex = 5;
            // 
            // textBox_hocKy
            // 
            this.textBox_hocKy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_hocKy.Location = new System.Drawing.Point(89, 86);
            this.textBox_hocKy.MaxLength = 30;
            this.textBox_hocKy.Name = "textBox_hocKy";
            this.textBox_hocKy.Size = new System.Drawing.Size(162, 20);
            this.textBox_hocKy.TabIndex = 6;
            // 
            // label_tenMonThi
            // 
            this.label_tenMonThi.AutoSize = true;
            this.label_tenMonThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tenMonThi.Location = new System.Drawing.Point(7, 55);
            this.label_tenMonThi.Name = "label_tenMonThi";
            this.label_tenMonThi.Size = new System.Drawing.Size(76, 16);
            this.label_tenMonThi.TabIndex = 7;
            this.label_tenMonThi.Text = "Tên môn thi";
            // 
            // label_hocKy
            // 
            this.label_hocKy.AutoSize = true;
            this.label_hocKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hocKy.Location = new System.Drawing.Point(22, 89);
            this.label_hocKy.Name = "label_hocKy";
            this.label_hocKy.Size = new System.Drawing.Size(61, 16);
            this.label_hocKy.TabIndex = 8;
            this.label_hocKy.Text = "Năm học";
            // 
            // numericUpDown_soTinChi
            // 
            this.numericUpDown_soTinChi.Location = new System.Drawing.Point(381, 52);
            this.numericUpDown_soTinChi.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown_soTinChi.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown_soTinChi.Name = "numericUpDown_soTinChi";
            this.numericUpDown_soTinChi.Size = new System.Drawing.Size(78, 20);
            this.numericUpDown_soTinChi.TabIndex = 9;
            this.numericUpDown_soTinChi.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label_ngayThi
            // 
            this.label_ngayThi.AutoSize = true;
            this.label_ngayThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ngayThi.Location = new System.Drawing.Point(27, 128);
            this.label_ngayThi.Name = "label_ngayThi";
            this.label_ngayThi.Size = new System.Drawing.Size(56, 16);
            this.label_ngayThi.TabIndex = 10;
            this.label_ngayThi.Text = "Ngày thi";
            // 
            // label_soCauHoi
            // 
            this.label_soCauHoi.AutoSize = true;
            this.label_soCauHoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_soCauHoi.Location = new System.Drawing.Point(269, 21);
            this.label_soCauHoi.Name = "label_soCauHoi";
            this.label_soCauHoi.Size = new System.Drawing.Size(106, 16);
            this.label_soCauHoi.TabIndex = 11;
            this.label_soCauHoi.Text = "Số lượng câu hỏi";
            // 
            // label_soTinChi
            // 
            this.label_soTinChi.AutoSize = true;
            this.label_soTinChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_soTinChi.Location = new System.Drawing.Point(315, 52);
            this.label_soTinChi.Name = "label_soTinChi";
            this.label_soTinChi.Size = new System.Drawing.Size(60, 16);
            this.label_soTinChi.TabIndex = 12;
            this.label_soTinChi.Text = "Số tín chỉ";
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_add.Location = new System.Drawing.Point(474, 12);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(81, 34);
            this.button_add.TabIndex = 13;
            this.button_add.Text = "Thêm";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_them_Click);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_update.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_update.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_update.Location = new System.Drawing.Point(561, 12);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(81, 34);
            this.button_update.TabIndex = 14;
            this.button_update.Text = "Sửa";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_sua_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.Location = new System.Drawing.Point(648, 13);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(81, 34);
            this.button_delete.TabIndex = 15;
            this.button_delete.Text = "Xóa";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // button_timKiem
            // 
            this.button_timKiem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_timKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_timKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_timKiem.ForeColor = System.Drawing.Color.Black;
            this.button_timKiem.Location = new System.Drawing.Point(87, 80);
            this.button_timKiem.Name = "button_timKiem";
            this.button_timKiem.Size = new System.Drawing.Size(81, 40);
            this.button_timKiem.TabIndex = 16;
            this.button_timKiem.Text = "Tìm kiếm";
            this.button_timKiem.UseVisualStyleBackColor = false;
            this.button_timKiem.Click += new System.EventHandler(this.button_timKiem_Click);
            // 
            // groupBox_timKiem
            // 
            this.groupBox_timKiem.Controls.Add(this.checkedListBox_timKiem);
            this.groupBox_timKiem.Controls.Add(this.button_timKiem);
            this.groupBox_timKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_timKiem.ForeColor = System.Drawing.Color.Red;
            this.groupBox_timKiem.Location = new System.Drawing.Point(474, 55);
            this.groupBox_timKiem.Name = "groupBox_timKiem";
            this.groupBox_timKiem.Size = new System.Drawing.Size(255, 126);
            this.groupBox_timKiem.TabIndex = 17;
            this.groupBox_timKiem.TabStop = false;
            this.groupBox_timKiem.Text = "Tìm kiếm theo";
            // 
            // checkedListBox_timKiem
            // 
            this.checkedListBox_timKiem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.checkedListBox_timKiem.CheckOnClick = true;
            this.checkedListBox_timKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkedListBox_timKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox_timKiem.Items.AddRange(new object[] {
            "mã môn thi",
            "tên môn thi",
            "học kỳ",
            "ngày thi",
            "số lượng câu",
            "số tín chỉ"});
            this.checkedListBox_timKiem.Location = new System.Drawing.Point(6, 21);
            this.checkedListBox_timKiem.MultiColumn = true;
            this.checkedListBox_timKiem.Name = "checkedListBox_timKiem";
            this.checkedListBox_timKiem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.checkedListBox_timKiem.Size = new System.Drawing.Size(243, 53);
            this.checkedListBox_timKiem.TabIndex = 18;
            // 
            // dateTimePicker_thoiGianThi
            // 
            this.dateTimePicker_thoiGianThi.CustomFormat = "hh:mm tt";
            this.dateTimePicker_thoiGianThi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_thoiGianThi.Location = new System.Drawing.Point(89, 161);
            this.dateTimePicker_thoiGianThi.Name = "dateTimePicker_thoiGianThi";
            this.dateTimePicker_thoiGianThi.ShowUpDown = true;
            this.dateTimePicker_thoiGianThi.Size = new System.Drawing.Size(96, 20);
            this.dateTimePicker_thoiGianThi.TabIndex = 18;
            // 
            // label_thoiGian
            // 
            this.label_thoiGian.AutoSize = true;
            this.label_thoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_thoiGian.Location = new System.Drawing.Point(20, 165);
            this.label_thoiGian.Name = "label_thoiGian";
            this.label_thoiGian.Size = new System.Drawing.Size(63, 16);
            this.label_thoiGian.TabIndex = 19;
            this.label_thoiGian.Text = "Thời gian";
            // 
            // FormQLMonThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(742, 705);
            this.Controls.Add(this.label_thoiGian);
            this.Controls.Add(this.dateTimePicker_thoiGianThi);
            this.Controls.Add(this.groupBox_timKiem);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label_soTinChi);
            this.Controls.Add(this.label_soCauHoi);
            this.Controls.Add(this.label_ngayThi);
            this.Controls.Add(this.numericUpDown_soTinChi);
            this.Controls.Add(this.label_hocKy);
            this.Controls.Add(this.label_tenMonThi);
            this.Controls.Add(this.textBox_hocKy);
            this.Controls.Add(this.textBox_tenMonThi);
            this.Controls.Add(this.textBox_maMonThi);
            this.Controls.Add(this.label_maMonThi);
            this.Controls.Add(this.numericUpDown_soCauHoi);
            this.Controls.Add(this.dateTimePicker_ngayThi);
            this.Controls.Add(this.dataGridView);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(758, 744);
            this.Name = "FormQLMonThi";
            this.Text = "FormQLMonThi";
            this.Load += new System.EventHandler(this.FormQLMonThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_soCauHoi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_soTinChi)).EndInit();
            this.groupBox_timKiem.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DateTimePicker dateTimePicker_ngayThi;
        private System.Windows.Forms.NumericUpDown numericUpDown_soCauHoi;
        private System.Windows.Forms.Label label_maMonThi;
        private System.Windows.Forms.TextBox textBox_maMonThi;
        private System.Windows.Forms.TextBox textBox_tenMonThi;
        private System.Windows.Forms.TextBox textBox_hocKy;
        private System.Windows.Forms.Label label_tenMonThi;
        private System.Windows.Forms.Label label_hocKy;
        private System.Windows.Forms.NumericUpDown numericUpDown_soTinChi;
        private System.Windows.Forms.Label label_ngayThi;
        private System.Windows.Forms.Label label_soCauHoi;
        private System.Windows.Forms.Label label_soTinChi;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_timKiem;
        private System.Windows.Forms.GroupBox groupBox_timKiem;
        private System.Windows.Forms.CheckedListBox checkedListBox_timKiem;
        private System.Windows.Forms.DateTimePicker dateTimePicker_thoiGianThi;
        private System.Windows.Forms.Label label_thoiGian;
    }
}