namespace BTL_QuanLyThiTracNghiem
{
    partial class FormDangKiTaiKhoan
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
            this.textBox_tenDangNhap = new System.Windows.Forms.TextBox();
            this.textBox_matKhau = new System.Windows.Forms.TextBox();
            this.button_dangKi = new System.Windows.Forms.Button();
            this.panel_container = new System.Windows.Forms.Panel();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.checkBox_hienThiMatKhau = new System.Windows.Forms.CheckBox();
            this.label_maSinhVien = new System.Windows.Forms.Label();
            this.textBox_maSinhVien = new System.Windows.Forms.TextBox();
            this.label_xacNhanMatKhau = new System.Windows.Forms.Label();
            this.label_matKhau = new System.Windows.Forms.Label();
            this.label_tenDangNhap = new System.Windows.Forms.Label();
            this.textBox_xacNhanMatKhau = new System.Windows.Forms.TextBox();
            this.radioButton_sinhVien = new System.Windows.Forms.RadioButton();
            this.radioButton_giangVien = new System.Windows.Forms.RadioButton();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel_container.SuspendLayout();
            this.groupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_tenDangNhap
            // 
            this.textBox_tenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_tenDangNhap.Location = new System.Drawing.Point(198, 28);
            this.textBox_tenDangNhap.MaxLength = 30;
            this.textBox_tenDangNhap.Name = "textBox_tenDangNhap";
            this.textBox_tenDangNhap.Size = new System.Drawing.Size(177, 22);
            this.textBox_tenDangNhap.TabIndex = 0;
            // 
            // textBox_matKhau
            // 
            this.textBox_matKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_matKhau.Location = new System.Drawing.Point(198, 68);
            this.textBox_matKhau.MaxLength = 20;
            this.textBox_matKhau.Name = "textBox_matKhau";
            this.textBox_matKhau.Size = new System.Drawing.Size(177, 22);
            this.textBox_matKhau.TabIndex = 1;
            this.textBox_matKhau.UseSystemPasswordChar = true;
            // 
            // button_dangKi
            // 
            this.button_dangKi.BackColor = System.Drawing.Color.GreenYellow;
            this.button_dangKi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_dangKi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dangKi.Location = new System.Drawing.Point(267, 266);
            this.button_dangKi.Name = "button_dangKi";
            this.button_dangKi.Size = new System.Drawing.Size(112, 53);
            this.button_dangKi.TabIndex = 2;
            this.button_dangKi.Text = "Đăng kí";
            this.button_dangKi.UseVisualStyleBackColor = false;
            this.button_dangKi.Click += new System.EventHandler(this.button_dangKi_Click);
            // 
            // panel_container
            // 
            this.panel_container.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel_container.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_container.Controls.Add(this.groupBox);
            this.panel_container.Controls.Add(this.radioButton_sinhVien);
            this.panel_container.Controls.Add(this.radioButton_giangVien);
            this.panel_container.Controls.Add(this.button_dangKi);
            this.panel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_container.Location = new System.Drawing.Point(0, 0);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(652, 331);
            this.panel_container.TabIndex = 3;
            // 
            // groupBox
            // 
            this.groupBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox.Controls.Add(this.checkBox_hienThiMatKhau);
            this.groupBox.Controls.Add(this.label_maSinhVien);
            this.groupBox.Controls.Add(this.textBox_maSinhVien);
            this.groupBox.Controls.Add(this.label_xacNhanMatKhau);
            this.groupBox.Controls.Add(this.label_matKhau);
            this.groupBox.Controls.Add(this.label_tenDangNhap);
            this.groupBox.Controls.Add(this.textBox_xacNhanMatKhau);
            this.groupBox.Controls.Add(this.textBox_tenDangNhap);
            this.groupBox.Controls.Add(this.textBox_matKhau);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.ForeColor = System.Drawing.Color.Red;
            this.groupBox.Location = new System.Drawing.Point(84, 56);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(479, 204);
            this.groupBox.TabIndex = 11;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Nhập thông tin";
            // 
            // checkBox_hienThiMatKhau
            // 
            this.checkBox_hienThiMatKhau.AutoSize = true;
            this.checkBox_hienThiMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_hienThiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_hienThiMatKhau.Location = new System.Drawing.Point(419, 70);
            this.checkBox_hienThiMatKhau.Name = "checkBox_hienThiMatKhau";
            this.checkBox_hienThiMatKhau.Size = new System.Drawing.Size(54, 20);
            this.checkBox_hienThiMatKhau.TabIndex = 11;
            this.checkBox_hienThiMatKhau.Text = "Hiện";
            this.checkBox_hienThiMatKhau.UseVisualStyleBackColor = true;
            this.checkBox_hienThiMatKhau.CheckedChanged += new System.EventHandler(this.checkBox_hienThiMatKhau_CheckedChanged);
            // 
            // label_maSinhVien
            // 
            this.label_maSinhVien.AutoSize = true;
            this.label_maSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_maSinhVien.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_maSinhVien.Location = new System.Drawing.Point(101, 158);
            this.label_maSinhVien.Name = "label_maSinhVien";
            this.label_maSinhVien.Size = new System.Drawing.Size(90, 18);
            this.label_maSinhVien.TabIndex = 10;
            this.label_maSinhVien.Text = "Mã sinh viên";
            // 
            // textBox_maSinhVien
            // 
            this.textBox_maSinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_maSinhVien.Location = new System.Drawing.Point(197, 154);
            this.textBox_maSinhVien.MaxLength = 12;
            this.textBox_maSinhVien.Name = "textBox_maSinhVien";
            this.textBox_maSinhVien.Size = new System.Drawing.Size(177, 22);
            this.textBox_maSinhVien.TabIndex = 9;
            // 
            // label_xacNhanMatKhau
            // 
            this.label_xacNhanMatKhau.AutoSize = true;
            this.label_xacNhanMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_xacNhanMatKhau.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_xacNhanMatKhau.Location = new System.Drawing.Point(60, 116);
            this.label_xacNhanMatKhau.Name = "label_xacNhanMatKhau";
            this.label_xacNhanMatKhau.Size = new System.Drawing.Size(131, 18);
            this.label_xacNhanMatKhau.TabIndex = 6;
            this.label_xacNhanMatKhau.Text = "Xác nhật mật khẩu";
            // 
            // label_matKhau
            // 
            this.label_matKhau.AutoSize = true;
            this.label_matKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_matKhau.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_matKhau.Location = new System.Drawing.Point(122, 72);
            this.label_matKhau.Name = "label_matKhau";
            this.label_matKhau.Size = new System.Drawing.Size(69, 18);
            this.label_matKhau.TabIndex = 5;
            this.label_matKhau.Text = "Mật khẩu";
            // 
            // label_tenDangNhap
            // 
            this.label_tenDangNhap.AutoSize = true;
            this.label_tenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tenDangNhap.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_tenDangNhap.Location = new System.Drawing.Point(86, 32);
            this.label_tenDangNhap.Name = "label_tenDangNhap";
            this.label_tenDangNhap.Size = new System.Drawing.Size(105, 18);
            this.label_tenDangNhap.TabIndex = 4;
            this.label_tenDangNhap.Text = "Tên đăng nhập";
            // 
            // textBox_xacNhanMatKhau
            // 
            this.textBox_xacNhanMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_xacNhanMatKhau.Location = new System.Drawing.Point(198, 112);
            this.textBox_xacNhanMatKhau.MaxLength = 20;
            this.textBox_xacNhanMatKhau.Name = "textBox_xacNhanMatKhau";
            this.textBox_xacNhanMatKhau.Size = new System.Drawing.Size(177, 22);
            this.textBox_xacNhanMatKhau.TabIndex = 3;
            this.textBox_xacNhanMatKhau.UseSystemPasswordChar = true;
            // 
            // radioButton_sinhVien
            // 
            this.radioButton_sinhVien.AutoSize = true;
            this.radioButton_sinhVien.Checked = true;
            this.radioButton_sinhVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_sinhVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_sinhVien.Location = new System.Drawing.Point(337, 12);
            this.radioButton_sinhVien.Name = "radioButton_sinhVien";
            this.radioButton_sinhVien.Size = new System.Drawing.Size(100, 24);
            this.radioButton_sinhVien.TabIndex = 8;
            this.radioButton_sinhVien.TabStop = true;
            this.radioButton_sinhVien.Text = "Sinh viên";
            this.radioButton_sinhVien.UseVisualStyleBackColor = true;
            this.radioButton_sinhVien.CheckedChanged += new System.EventHandler(this.radioButton_sinhVien_CheckedChanged);
            // 
            // radioButton_giangVien
            // 
            this.radioButton_giangVien.AutoSize = true;
            this.radioButton_giangVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.radioButton_giangVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_giangVien.Location = new System.Drawing.Point(198, 12);
            this.radioButton_giangVien.Name = "radioButton_giangVien";
            this.radioButton_giangVien.Size = new System.Drawing.Size(112, 24);
            this.radioButton_giangVien.TabIndex = 7;
            this.radioButton_giangVien.TabStop = true;
            this.radioButton_giangVien.Text = "Giảng viên";
            this.radioButton_giangVien.UseVisualStyleBackColor = true;
            this.radioButton_giangVien.CheckedChanged += new System.EventHandler(this.radioButton_giangVien_CheckedChanged);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkRate = 0;
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // FormDangKiTaiKhoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 331);
            this.Controls.Add(this.panel_container);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormDangKiTaiKhoan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDangKiTaiKhoan_FormClosed);
            this.panel_container.ResumeLayout(false);
            this.panel_container.PerformLayout();
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_tenDangNhap;
        private System.Windows.Forms.TextBox textBox_matKhau;
        private System.Windows.Forms.Button button_dangKi;
        private System.Windows.Forms.Panel panel_container;
        private System.Windows.Forms.TextBox textBox_xacNhanMatKhau;
        private System.Windows.Forms.Label label_xacNhanMatKhau;
        private System.Windows.Forms.Label label_matKhau;
        private System.Windows.Forms.Label label_tenDangNhap;
        private System.Windows.Forms.RadioButton radioButton_sinhVien;
        private System.Windows.Forms.RadioButton radioButton_giangVien;
        private System.Windows.Forms.TextBox textBox_maSinhVien;
        private System.Windows.Forms.Label label_maSinhVien;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.CheckBox checkBox_hienThiMatKhau;
    }
}