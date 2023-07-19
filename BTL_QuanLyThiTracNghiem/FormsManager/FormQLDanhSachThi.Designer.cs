namespace BTL_QuanLyThiTracNghiem.FormsManager
{
    partial class FormQLDanhSachThi
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
            this.dataGridView_danhSachThi = new System.Windows.Forms.DataGridView();
            this.button_them = new System.Windows.Forms.Button();
            this.textBox_maSinhVien = new System.Windows.Forms.TextBox();
            this.label_monThi = new System.Windows.Forms.Label();
            this.label_maSinhVien = new System.Windows.Forms.Label();
            this.button_timKiem = new System.Windows.Forms.Button();
            this.dataGridView_danhSachChuaThi = new System.Windows.Forms.DataGridView();
            this.button_right = new System.Windows.Forms.Button();
            this.button_left = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_monThi = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_danhSachThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_danhSachChuaThi)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_danhSachThi
            // 
            this.dataGridView_danhSachThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_danhSachThi.BackgroundColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_danhSachThi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_danhSachThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_danhSachThi.EnableHeadersVisualStyles = false;
            this.dataGridView_danhSachThi.Location = new System.Drawing.Point(12, 205);
            this.dataGridView_danhSachThi.Name = "dataGridView_danhSachThi";
            this.dataGridView_danhSachThi.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_danhSachThi.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView_danhSachThi.Size = new System.Drawing.Size(520, 559);
            this.dataGridView_danhSachThi.TabIndex = 0;
            // 
            // button_them
            // 
            this.button_them.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_them.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_them.ForeColor = System.Drawing.Color.Black;
            this.button_them.Location = new System.Drawing.Point(202, 104);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(75, 38);
            this.button_them.TabIndex = 1;
            this.button_them.Text = "Thêm";
            this.button_them.UseVisualStyleBackColor = false;
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // textBox_maSinhVien
            // 
            this.textBox_maSinhVien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_maSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_maSinhVien.ForeColor = System.Drawing.Color.Black;
            this.textBox_maSinhVien.Location = new System.Drawing.Point(96, 69);
            this.textBox_maSinhVien.MaxLength = 12;
            this.textBox_maSinhVien.Name = "textBox_maSinhVien";
            this.textBox_maSinhVien.Size = new System.Drawing.Size(181, 26);
            this.textBox_maSinhVien.TabIndex = 3;
            // 
            // label_monThi
            // 
            this.label_monThi.AutoSize = true;
            this.label_monThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_monThi.ForeColor = System.Drawing.Color.Black;
            this.label_monThi.Location = new System.Drawing.Point(33, 42);
            this.label_monThi.Name = "label_monThi";
            this.label_monThi.Size = new System.Drawing.Size(57, 18);
            this.label_monThi.TabIndex = 5;
            this.label_monThi.Text = "Môn thi";
            // 
            // label_maSinhVien
            // 
            this.label_maSinhVien.AutoSize = true;
            this.label_maSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_maSinhVien.ForeColor = System.Drawing.Color.Black;
            this.label_maSinhVien.Location = new System.Drawing.Point(11, 75);
            this.label_maSinhVien.Name = "label_maSinhVien";
            this.label_maSinhVien.Size = new System.Drawing.Size(79, 18);
            this.label_maSinhVien.TabIndex = 6;
            this.label_maSinhVien.Text = "Mã thí sinh";
            // 
            // button_timKiem
            // 
            this.button_timKiem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_timKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_timKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_timKiem.ForeColor = System.Drawing.Color.Black;
            this.button_timKiem.Location = new System.Drawing.Point(133, 104);
            this.button_timKiem.Name = "button_timKiem";
            this.button_timKiem.Size = new System.Drawing.Size(86, 38);
            this.button_timKiem.TabIndex = 11;
            this.button_timKiem.Text = "Tìm kiếm";
            this.button_timKiem.UseVisualStyleBackColor = false;
            this.button_timKiem.Click += new System.EventHandler(this.button_timKiem_Click);
            // 
            // dataGridView_danhSachChuaThi
            // 
            this.dataGridView_danhSachChuaThi.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_danhSachChuaThi.BackgroundColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_danhSachChuaThi.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_danhSachChuaThi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_danhSachChuaThi.EnableHeadersVisualStyles = false;
            this.dataGridView_danhSachChuaThi.Location = new System.Drawing.Point(683, 205);
            this.dataGridView_danhSachChuaThi.Name = "dataGridView_danhSachChuaThi";
            this.dataGridView_danhSachChuaThi.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_danhSachChuaThi.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_danhSachChuaThi.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView_danhSachChuaThi.Size = new System.Drawing.Size(306, 559);
            this.dataGridView_danhSachChuaThi.TabIndex = 13;
            // 
            // button_right
            // 
            this.button_right.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button_right.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_right.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_right.Location = new System.Drawing.Point(572, 486);
            this.button_right.Name = "button_right";
            this.button_right.Size = new System.Drawing.Size(75, 33);
            this.button_right.TabIndex = 14;
            this.button_right.Text = ">>";
            this.button_right.UseVisualStyleBackColor = false;
            this.button_right.Click += new System.EventHandler(this.button_right_Click);
            // 
            // button_left
            // 
            this.button_left.BackColor = System.Drawing.SystemColors.HighlightText;
            this.button_left.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_left.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_left.Location = new System.Drawing.Point(572, 447);
            this.button_left.Name = "button_left";
            this.button_left.Size = new System.Drawing.Size(75, 33);
            this.button_left.TabIndex = 15;
            this.button_left.Text = "<<";
            this.button_left.UseVisualStyleBackColor = false;
            this.button_left.Click += new System.EventHandler(this.button_left_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(178, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 16;
            this.label1.Text = "Bảng danh sách thi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(715, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(250, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Danh sách chưa được thi";
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.Location = new System.Drawing.Point(572, 408);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(75, 33);
            this.button_save.TabIndex = 18;
            this.button_save.Text = "Lưu";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.EnabledChanged += new System.EventHandler(this.button_save_EnabledChanged);
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_maSinhVien);
            this.groupBox1.Controls.Add(this.label_monThi);
            this.groupBox1.Controls.Add(this.comboBox_monThi);
            this.groupBox1.Controls.Add(this.textBox_maSinhVien);
            this.groupBox1.Controls.Add(this.button_them);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(289, 151);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập để thêm";
            // 
            // comboBox_monThi
            // 
            this.comboBox_monThi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_monThi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_monThi.ForeColor = System.Drawing.Color.Black;
            this.comboBox_monThi.FormattingEnabled = true;
            this.comboBox_monThi.Location = new System.Drawing.Point(96, 35);
            this.comboBox_monThi.Name = "comboBox_monThi";
            this.comboBox_monThi.Size = new System.Drawing.Size(181, 28);
            this.comboBox_monThi.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkedListBox1);
            this.groupBox2.Controls.Add(this.button_timKiem);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Red;
            this.groupBox2.Location = new System.Drawing.Point(307, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(225, 151);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Tìm kiếm";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "môn thi",
            "mã sinh viên",
            "đã thi"});
            this.checkedListBox1.Location = new System.Drawing.Point(6, 30);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(213, 67);
            this.checkedListBox1.TabIndex = 12;
            // 
            // FormQLDanhSachThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1001, 776);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_left);
            this.Controls.Add(this.button_right);
            this.Controls.Add(this.dataGridView_danhSachChuaThi);
            this.Controls.Add(this.dataGridView_danhSachThi);
            this.DoubleBuffered = true;
            this.Name = "FormQLDanhSachThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQLDanhSachThi";
            this.Load += new System.EventHandler(this.FormQLDanhSachThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_danhSachThi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_danhSachChuaThi)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_danhSachThi;
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.TextBox textBox_maSinhVien;
        private System.Windows.Forms.Label label_monThi;
        private System.Windows.Forms.Label label_maSinhVien;
        private System.Windows.Forms.Button button_timKiem;
        private System.Windows.Forms.DataGridView dataGridView_danhSachChuaThi;
        private System.Windows.Forms.Button button_right;
        private System.Windows.Forms.Button button_left;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.ComboBox comboBox_monThi;
    }
}