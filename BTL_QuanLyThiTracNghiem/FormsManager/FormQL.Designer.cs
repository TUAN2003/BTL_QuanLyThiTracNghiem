namespace BTL_QuanLyThiTracNghiem.FormsManager
{
    partial class FormQL
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQL));
            this.menustrip_main = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem_FormQLCauHoi = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_FormQLMonThi = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_FormQLDeThi = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_FormQLDSThi = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_FormQLKetQua = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItem_Thoat = new System.Windows.Forms.ToolStripMenuItem();
            this.menustrip_main.SuspendLayout();
            this.SuspendLayout();
            // 
            // menustrip_main
            // 
            this.menustrip_main.BackColor = System.Drawing.SystemColors.Menu;
            this.menustrip_main.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menustrip_main.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menustrip_main.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem_FormQLCauHoi,
            this.ToolStripMenuItem_FormQLMonThi,
            this.ToolStripMenuItem_FormQLDeThi,
            this.ToolStripMenuItem_FormQLDSThi,
            this.ToolStripMenuItem_FormQLKetQua,
            this.ToolStripMenuItem_Thoat});
            this.menustrip_main.Location = new System.Drawing.Point(0, 0);
            this.menustrip_main.Name = "menustrip_main";
            this.menustrip_main.Size = new System.Drawing.Size(984, 29);
            this.menustrip_main.TabIndex = 1;
            this.menustrip_main.Text = "menuStrip1";
            // 
            // ToolStripMenuItem_FormQLCauHoi
            // 
            this.ToolStripMenuItem_FormQLCauHoi.Name = "ToolStripMenuItem_FormQLCauHoi";
            this.ToolStripMenuItem_FormQLCauHoi.Size = new System.Drawing.Size(140, 25);
            this.ToolStripMenuItem_FormQLCauHoi.Text = "Quản Lý Câu Hỏi";
            this.ToolStripMenuItem_FormQLCauHoi.Click += new System.EventHandler(this.ToolStripMenuItem_FormQLCauHoi_Click);
            // 
            // ToolStripMenuItem_FormQLMonThi
            // 
            this.ToolStripMenuItem_FormQLMonThi.Name = "ToolStripMenuItem_FormQLMonThi";
            this.ToolStripMenuItem_FormQLMonThi.Size = new System.Drawing.Size(143, 25);
            this.ToolStripMenuItem_FormQLMonThi.Text = "Quản Lý Môn Thi";
            this.ToolStripMenuItem_FormQLMonThi.Click += new System.EventHandler(this.ToolStripMenuItem_FormQLMonThi_Click);
            // 
            // ToolStripMenuItem_FormQLDeThi
            // 
            this.ToolStripMenuItem_FormQLDeThi.Name = "ToolStripMenuItem_FormQLDeThi";
            this.ToolStripMenuItem_FormQLDeThi.Size = new System.Drawing.Size(129, 25);
            this.ToolStripMenuItem_FormQLDeThi.Text = "Quản Lý Đề Thi";
            this.ToolStripMenuItem_FormQLDeThi.Click += new System.EventHandler(this.ToolStripMenuItem_FormQLDeThi_Click);
            // 
            // ToolStripMenuItem_FormQLDSThi
            // 
            this.ToolStripMenuItem_FormQLDSThi.Name = "ToolStripMenuItem_FormQLDSThi";
            this.ToolStripMenuItem_FormQLDSThi.Size = new System.Drawing.Size(184, 25);
            this.ToolStripMenuItem_FormQLDSThi.Text = "Quản Lý Danh Sách Thi";
            this.ToolStripMenuItem_FormQLDSThi.Click += new System.EventHandler(this.ToolStripMenuItem_FormQLDSThi_Click);
            // 
            // ToolStripMenuItem_FormQLKetQua
            // 
            this.ToolStripMenuItem_FormQLKetQua.Name = "ToolStripMenuItem_FormQLKetQua";
            this.ToolStripMenuItem_FormQLKetQua.Size = new System.Drawing.Size(141, 25);
            this.ToolStripMenuItem_FormQLKetQua.Text = "Quản Lý Kết Quả";
            this.ToolStripMenuItem_FormQLKetQua.Click += new System.EventHandler(this.ToolStripMenuItem_FormQLKetQua_Click);
            // 
            // ToolStripMenuItem_Thoat
            // 
            this.ToolStripMenuItem_Thoat.Name = "ToolStripMenuItem_Thoat";
            this.ToolStripMenuItem_Thoat.Size = new System.Drawing.Size(95, 25);
            this.ToolStripMenuItem_Thoat.Text = "Đăng xuất";
            this.ToolStripMenuItem_Thoat.Click += new System.EventHandler(this.ToolStripMenuItem_Thoat_Click);
            // 
            // FormQL
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(984, 761);
            this.Controls.Add(this.menustrip_main);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menustrip_main;
            this.Name = "FormQL";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormQLChung";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormQLChung_FormClosed);
            this.menustrip_main.ResumeLayout(false);
            this.menustrip_main.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menustrip_main;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_FormQLCauHoi;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_FormQLMonThi;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_FormQLDeThi;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_FormQLDSThi;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_FormQLKetQua;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem_Thoat;
    }
}