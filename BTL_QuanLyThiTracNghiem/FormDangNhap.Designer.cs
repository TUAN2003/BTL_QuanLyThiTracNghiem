namespace BTL_QuanLyThiTracNghiem
{
    partial class FormDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDangNhap));
            this.button_dangNhap = new System.Windows.Forms.Button();
            this.textBox_tenDangNhap = new System.Windows.Forms.TextBox();
            this.label_tenDangNhap = new System.Windows.Forms.Label();
            this.label_matKhau = new System.Windows.Forms.Label();
            this.textBox_matKhau = new System.Windows.Forms.TextBox();
            this.label_quenMatKhau = new System.Windows.Forms.Label();
            this.err_userempty = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_pwdempty = new System.Windows.Forms.ErrorProvider(this.components);
            this.checkBox_hienThiMatKhau = new System.Windows.Forms.CheckBox();
            this.label_dangKiTaiKhoan = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.err_userempty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_pwdempty)).BeginInit();
            this.SuspendLayout();
            // 
            // button_dangNhap
            // 
            this.button_dangNhap.BackColor = System.Drawing.Color.GreenYellow;
            this.button_dangNhap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_dangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dangNhap.Location = new System.Drawing.Point(311, 160);
            this.button_dangNhap.Name = "button_dangNhap";
            this.button_dangNhap.Size = new System.Drawing.Size(105, 41);
            this.button_dangNhap.TabIndex = 3;
            this.button_dangNhap.Text = "Đăng nhập";
            this.button_dangNhap.UseVisualStyleBackColor = false;
            this.button_dangNhap.Click += new System.EventHandler(this.button_dangNhap_Click);
            // 
            // textBox_tenDangNhap
            // 
            this.textBox_tenDangNhap.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_tenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_tenDangNhap.Location = new System.Drawing.Point(144, 31);
            this.textBox_tenDangNhap.Name = "textBox_tenDangNhap";
            this.textBox_tenDangNhap.Size = new System.Drawing.Size(272, 26);
            this.textBox_tenDangNhap.TabIndex = 0;
            this.textBox_tenDangNhap.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_tenDangNhap_KeyDown);
            // 
            // label_tenDangNhap
            // 
            this.label_tenDangNhap.AutoSize = true;
            this.label_tenDangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tenDangNhap.ForeColor = System.Drawing.Color.Black;
            this.label_tenDangNhap.Location = new System.Drawing.Point(27, 36);
            this.label_tenDangNhap.Name = "label_tenDangNhap";
            this.label_tenDangNhap.Size = new System.Drawing.Size(111, 16);
            this.label_tenDangNhap.TabIndex = 6;
            this.label_tenDangNhap.Text = "Tên đăng nhập";
            this.label_tenDangNhap.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_matKhau
            // 
            this.label_matKhau.AutoSize = true;
            this.label_matKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_matKhau.Location = new System.Drawing.Point(69, 81);
            this.label_matKhau.Name = "label_matKhau";
            this.label_matKhau.Size = new System.Drawing.Size(69, 16);
            this.label_matKhau.TabIndex = 7;
            this.label_matKhau.Text = "Mật khẩu";
            this.label_matKhau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox_matKhau
            // 
            this.textBox_matKhau.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_matKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_matKhau.Location = new System.Drawing.Point(144, 76);
            this.textBox_matKhau.Name = "textBox_matKhau";
            this.textBox_matKhau.Size = new System.Drawing.Size(272, 26);
            this.textBox_matKhau.TabIndex = 1;
            this.textBox_matKhau.UseSystemPasswordChar = true;
            this.textBox_matKhau.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_matKhau_KeyDown);
            // 
            // label_quenMatKhau
            // 
            this.label_quenMatKhau.AutoSize = true;
            this.label_quenMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_quenMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_quenMatKhau.ForeColor = System.Drawing.Color.IndianRed;
            this.label_quenMatKhau.Location = new System.Drawing.Point(27, 160);
            this.label_quenMatKhau.Name = "label_quenMatKhau";
            this.label_quenMatKhau.Size = new System.Drawing.Size(103, 16);
            this.label_quenMatKhau.TabIndex = 4;
            this.label_quenMatKhau.Text = "Quên mật khẩu?";
            this.label_quenMatKhau.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_quenMatKhau.Click += new System.EventHandler(this.label_quenMatKhau_Click);
            // 
            // err_userempty
            // 
            this.err_userempty.BlinkRate = 0;
            this.err_userempty.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.err_userempty.ContainerControl = this;
            // 
            // err_pwdempty
            // 
            this.err_pwdempty.BlinkRate = 0;
            this.err_pwdempty.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.err_pwdempty.ContainerControl = this;
            // 
            // checkBox_hienThiMatKhau
            // 
            this.checkBox_hienThiMatKhau.AutoSize = true;
            this.checkBox_hienThiMatKhau.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox_hienThiMatKhau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox_hienThiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_hienThiMatKhau.Location = new System.Drawing.Point(305, 108);
            this.checkBox_hienThiMatKhau.Name = "checkBox_hienThiMatKhau";
            this.checkBox_hienThiMatKhau.Size = new System.Drawing.Size(111, 20);
            this.checkBox_hienThiMatKhau.TabIndex = 2;
            this.checkBox_hienThiMatKhau.Text = "Hiện mật khẩu";
            this.checkBox_hienThiMatKhau.UseVisualStyleBackColor = true;
            this.checkBox_hienThiMatKhau.CheckedChanged += new System.EventHandler(this.checkBox_hienThiMatKhau_CheckedChanged);
            // 
            // label_dangKiTaiKhoan
            // 
            this.label_dangKiTaiKhoan.AutoSize = true;
            this.label_dangKiTaiKhoan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_dangKiTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dangKiTaiKhoan.ForeColor = System.Drawing.Color.IndianRed;
            this.label_dangKiTaiKhoan.Location = new System.Drawing.Point(27, 185);
            this.label_dangKiTaiKhoan.Name = "label_dangKiTaiKhoan";
            this.label_dangKiTaiKhoan.Size = new System.Drawing.Size(59, 16);
            this.label_dangKiTaiKhoan.TabIndex = 5;
            this.label_dangKiTaiKhoan.Text = "Đăng kí?";
            this.label_dangKiTaiKhoan.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label_dangKiTaiKhoan.Click += new System.EventHandler(this.label_dangKiTaiKhoan_Click);
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(447, 210);
            this.Controls.Add(this.label_dangKiTaiKhoan);
            this.Controls.Add(this.checkBox_hienThiMatKhau);
            this.Controls.Add(this.label_quenMatKhau);
            this.Controls.Add(this.textBox_matKhau);
            this.Controls.Add(this.label_matKhau);
            this.Controls.Add(this.label_tenDangNhap);
            this.Controls.Add(this.textBox_tenDangNhap);
            this.Controls.Add(this.button_dangNhap);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đăng Nhập";
            ((System.ComponentModel.ISupportInitialize)(this.err_userempty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_pwdempty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_dangNhap;
        private System.Windows.Forms.TextBox textBox_tenDangNhap;
        private System.Windows.Forms.Label label_tenDangNhap;
        private System.Windows.Forms.Label label_matKhau;
        private System.Windows.Forms.TextBox textBox_matKhau;
        private System.Windows.Forms.Label label_quenMatKhau;
        private System.Windows.Forms.ErrorProvider err_userempty;
        private System.Windows.Forms.ErrorProvider err_pwdempty;
        private System.Windows.Forms.CheckBox checkBox_hienThiMatKhau;
        private System.Windows.Forms.Label label_dangKiTaiKhoan;
    }
}