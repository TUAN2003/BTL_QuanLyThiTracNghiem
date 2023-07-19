namespace BTL_QuanLyThiTracNghiem.FormsManager
{
    partial class FormQLKetQua
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_container = new System.Windows.Forms.Panel();
            this.button_lamMoi = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBoc_filter = new System.Windows.Forms.GroupBox();
            this.textBox_lopHanhChinh = new System.Windows.Forms.TextBox();
            this.textBox_maDe = new System.Windows.Forms.TextBox();
            this.label_maSinhVien = new System.Windows.Forms.Label();
            this.textBox_maSinhVien = new System.Windows.Forms.TextBox();
            this.label_maKetQua = new System.Windows.Forms.Label();
            this.textBox_maKetQua = new System.Windows.Forms.TextBox();
            this.label_hoTen = new System.Windows.Forms.Label();
            this.textBox_hoTen = new System.Windows.Forms.TextBox();
            this.label_maDe = new System.Windows.Forms.Label();
            this.label_lopHanhChinh = new System.Windows.Forms.Label();
            this.label_monThi = new System.Windows.Forms.Label();
            this.comboBox_monThi = new System.Windows.Forms.ComboBox();
            this.button_xemTatCa = new System.Windows.Forms.Button();
            this.button_inCR = new System.Windows.Forms.Button();
            this.button_timKiem = new System.Windows.Forms.Button();
            this.panel_container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBoc_filter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_container
            // 
            this.panel_container.BackColor = System.Drawing.SystemColors.Window;
            this.panel_container.Controls.Add(this.button_lamMoi);
            this.panel_container.Controls.Add(this.dataGridView);
            this.panel_container.Controls.Add(this.groupBoc_filter);
            this.panel_container.Controls.Add(this.button_xemTatCa);
            this.panel_container.Controls.Add(this.button_inCR);
            this.panel_container.Controls.Add(this.button_timKiem);
            this.panel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_container.Location = new System.Drawing.Point(0, 0);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(908, 711);
            this.panel_container.TabIndex = 0;
            // 
            // button_lamMoi
            // 
            this.button_lamMoi.BackColor = System.Drawing.Color.SkyBlue;
            this.button_lamMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_lamMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_lamMoi.Location = new System.Drawing.Point(797, 21);
            this.button_lamMoi.Name = "button_lamMoi";
            this.button_lamMoi.Size = new System.Drawing.Size(103, 43);
            this.button_lamMoi.TabIndex = 16;
            this.button_lamMoi.Text = "Làm mới";
            this.button_lamMoi.UseVisualStyleBackColor = false;
            this.button_lamMoi.Click += new System.EventHandler(this.button_lamMoi_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.Location = new System.Drawing.Point(0, 175);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView.Size = new System.Drawing.Size(908, 536);
            this.dataGridView.TabIndex = 0;
            // 
            // groupBoc_filter
            // 
            this.groupBoc_filter.Controls.Add(this.textBox_lopHanhChinh);
            this.groupBoc_filter.Controls.Add(this.textBox_maDe);
            this.groupBoc_filter.Controls.Add(this.label_maSinhVien);
            this.groupBoc_filter.Controls.Add(this.textBox_maSinhVien);
            this.groupBoc_filter.Controls.Add(this.label_maKetQua);
            this.groupBoc_filter.Controls.Add(this.textBox_maKetQua);
            this.groupBoc_filter.Controls.Add(this.label_hoTen);
            this.groupBoc_filter.Controls.Add(this.textBox_hoTen);
            this.groupBoc_filter.Controls.Add(this.label_maDe);
            this.groupBoc_filter.Controls.Add(this.label_lopHanhChinh);
            this.groupBoc_filter.Controls.Add(this.label_monThi);
            this.groupBoc_filter.Controls.Add(this.comboBox_monThi);
            this.groupBoc_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoc_filter.ForeColor = System.Drawing.Color.Red;
            this.groupBoc_filter.Location = new System.Drawing.Point(12, 12);
            this.groupBoc_filter.Name = "groupBoc_filter";
            this.groupBoc_filter.Size = new System.Drawing.Size(452, 157);
            this.groupBoc_filter.TabIndex = 12;
            this.groupBoc_filter.TabStop = false;
            this.groupBoc_filter.Text = "Lọc dữ liệu";
            // 
            // textBox_lopHanhChinh
            // 
            this.textBox_lopHanhChinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_lopHanhChinh.Location = new System.Drawing.Point(297, 77);
            this.textBox_lopHanhChinh.Name = "textBox_lopHanhChinh";
            this.textBox_lopHanhChinh.Size = new System.Drawing.Size(137, 22);
            this.textBox_lopHanhChinh.TabIndex = 16;
            // 
            // textBox_maDe
            // 
            this.textBox_maDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_maDe.Location = new System.Drawing.Point(87, 77);
            this.textBox_maDe.Name = "textBox_maDe";
            this.textBox_maDe.Size = new System.Drawing.Size(121, 22);
            this.textBox_maDe.TabIndex = 15;
            // 
            // label_maSinhVien
            // 
            this.label_maSinhVien.AutoSize = true;
            this.label_maSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_maSinhVien.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_maSinhVien.Location = new System.Drawing.Point(244, 127);
            this.label_maSinhVien.Name = "label_maSinhVien";
            this.label_maSinhVien.Size = new System.Drawing.Size(47, 16);
            this.label_maSinhVien.TabIndex = 14;
            this.label_maSinhVien.Text = "Mã SV";
            // 
            // textBox_maSinhVien
            // 
            this.textBox_maSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_maSinhVien.Location = new System.Drawing.Point(297, 121);
            this.textBox_maSinhVien.Name = "textBox_maSinhVien";
            this.textBox_maSinhVien.Size = new System.Drawing.Size(137, 22);
            this.textBox_maSinhVien.TabIndex = 13;
            // 
            // label_maKetQua
            // 
            this.label_maKetQua.AutoSize = true;
            this.label_maKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_maKetQua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_maKetQua.Location = new System.Drawing.Point(8, 127);
            this.label_maKetQua.Name = "label_maKetQua";
            this.label_maKetQua.Size = new System.Drawing.Size(73, 16);
            this.label_maKetQua.TabIndex = 12;
            this.label_maKetQua.Text = "Mã kết quả";
            // 
            // textBox_maKetQua
            // 
            this.textBox_maKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_maKetQua.Location = new System.Drawing.Point(87, 121);
            this.textBox_maKetQua.Name = "textBox_maKetQua";
            this.textBox_maKetQua.Size = new System.Drawing.Size(121, 22);
            this.textBox_maKetQua.TabIndex = 11;
            // 
            // label_hoTen
            // 
            this.label_hoTen.AutoSize = true;
            this.label_hoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_hoTen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_hoTen.Location = new System.Drawing.Point(245, 38);
            this.label_hoTen.Name = "label_hoTen";
            this.label_hoTen.Size = new System.Drawing.Size(46, 16);
            this.label_hoTen.TabIndex = 10;
            this.label_hoTen.Text = "Họ tên";
            // 
            // textBox_hoTen
            // 
            this.textBox_hoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_hoTen.Location = new System.Drawing.Point(297, 30);
            this.textBox_hoTen.Name = "textBox_hoTen";
            this.textBox_hoTen.Size = new System.Drawing.Size(137, 22);
            this.textBox_hoTen.TabIndex = 9;
            // 
            // label_maDe
            // 
            this.label_maDe.AutoSize = true;
            this.label_maDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_maDe.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_maDe.Location = new System.Drawing.Point(32, 83);
            this.label_maDe.Name = "label_maDe";
            this.label_maDe.Size = new System.Drawing.Size(45, 16);
            this.label_maDe.TabIndex = 7;
            this.label_maDe.Text = "Mã đề";
            // 
            // label_lopHanhChinh
            // 
            this.label_lopHanhChinh.AutoSize = true;
            this.label_lopHanhChinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_lopHanhChinh.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_lopHanhChinh.Location = new System.Drawing.Point(261, 83);
            this.label_lopHanhChinh.Name = "label_lopHanhChinh";
            this.label_lopHanhChinh.Size = new System.Drawing.Size(30, 16);
            this.label_lopHanhChinh.TabIndex = 5;
            this.label_lopHanhChinh.Text = "Lớp";
            // 
            // label_monThi
            // 
            this.label_monThi.AutoSize = true;
            this.label_monThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_monThi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_monThi.Location = new System.Drawing.Point(32, 38);
            this.label_monThi.Name = "label_monThi";
            this.label_monThi.Size = new System.Drawing.Size(49, 16);
            this.label_monThi.TabIndex = 4;
            this.label_monThi.Text = "Môn thi";
            // 
            // comboBox_monThi
            // 
            this.comboBox_monThi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox_monThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_monThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_monThi.FormattingEnabled = true;
            this.comboBox_monThi.Location = new System.Drawing.Point(87, 30);
            this.comboBox_monThi.Name = "comboBox_monThi";
            this.comboBox_monThi.Size = new System.Drawing.Size(121, 24);
            this.comboBox_monThi.TabIndex = 3;
            // 
            // button_xemTatCa
            // 
            this.button_xemTatCa.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_xemTatCa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_xemTatCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xemTatCa.Location = new System.Drawing.Point(579, 21);
            this.button_xemTatCa.Name = "button_xemTatCa";
            this.button_xemTatCa.Size = new System.Drawing.Size(103, 43);
            this.button_xemTatCa.TabIndex = 11;
            this.button_xemTatCa.Text = "Xem tất cả";
            this.button_xemTatCa.UseVisualStyleBackColor = false;
            this.button_xemTatCa.Click += new System.EventHandler(this.button_xemTatCa_Click);
            // 
            // button_inCR
            // 
            this.button_inCR.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_inCR.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_inCR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_inCR.Location = new System.Drawing.Point(688, 21);
            this.button_inCR.Name = "button_inCR";
            this.button_inCR.Size = new System.Drawing.Size(103, 43);
            this.button_inCR.TabIndex = 2;
            this.button_inCR.Text = "In";
            this.button_inCR.UseVisualStyleBackColor = false;
            this.button_inCR.Click += new System.EventHandler(this.button_inCR_Click);
            // 
            // button_timKiem
            // 
            this.button_timKiem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_timKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_timKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_timKiem.Location = new System.Drawing.Point(470, 21);
            this.button_timKiem.Name = "button_timKiem";
            this.button_timKiem.Size = new System.Drawing.Size(103, 43);
            this.button_timKiem.TabIndex = 1;
            this.button_timKiem.Text = "Tìm kiếm";
            this.button_timKiem.UseVisualStyleBackColor = false;
            this.button_timKiem.Click += new System.EventHandler(this.button_timKiem_Click);
            // 
            // FormQLKetQua
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 711);
            this.Controls.Add(this.panel_container);
            this.DoubleBuffered = true;
            this.Name = "FormQLKetQua";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQLKetQua";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormQLKetQua_FormClosed);
            this.Load += new System.EventHandler(this.FormQLKetQua_Load);
            this.panel_container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBoc_filter.ResumeLayout(false);
            this.groupBoc_filter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_container;
        private System.Windows.Forms.Button button_inCR;
        private System.Windows.Forms.Button button_timKiem;
        private System.Windows.Forms.ComboBox comboBox_monThi;
        private System.Windows.Forms.Label label_monThi;
        private System.Windows.Forms.Label label_lopHanhChinh;
        private System.Windows.Forms.Label label_maDe;
        private System.Windows.Forms.Label label_hoTen;
        private System.Windows.Forms.TextBox textBox_hoTen;
        private System.Windows.Forms.Button button_xemTatCa;
        private System.Windows.Forms.GroupBox groupBoc_filter;
        private System.Windows.Forms.TextBox textBox_maKetQua;
        private System.Windows.Forms.Label label_maKetQua;
        private System.Windows.Forms.Label label_maSinhVien;
        private System.Windows.Forms.TextBox textBox_maSinhVien;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox textBox_maDe;
        private System.Windows.Forms.TextBox textBox_lopHanhChinh;
        private System.Windows.Forms.Button button_lamMoi;
    }
}