namespace BTL_QuanLyThiTracNghiem.FormsStudent
{
    partial class FormLichThi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLichThi));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label_title = new System.Windows.Forms.Label();
            this.panel_container = new System.Windows.Forms.Panel();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripButton_dangXuat = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton_lamMoi = new System.Windows.Forms.ToolStripButton();
            this.button_xacNhan = new System.Windows.Forms.Button();
            this.label_maXacNhan = new System.Windows.Forms.Label();
            this.textBox_maXacNhan = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel_container.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label_title
            // 
            this.label_title.AutoSize = true;
            this.label_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_title.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_title.Location = new System.Drawing.Point(324, 63);
            this.label_title.Name = "label_title";
            this.label_title.Size = new System.Drawing.Size(144, 29);
            this.label_title.TabIndex = 2;
            this.label_title.Text = "Lịch thi của";
            // 
            // panel_container
            // 
            this.panel_container.BackColor = System.Drawing.SystemColors.Window;
            this.panel_container.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_container.Controls.Add(this.toolStrip);
            this.panel_container.Controls.Add(this.button_xacNhan);
            this.panel_container.Controls.Add(this.label_maXacNhan);
            this.panel_container.Controls.Add(this.textBox_maXacNhan);
            this.panel_container.Controls.Add(this.dataGridView);
            this.panel_container.Controls.Add(this.label_title);
            this.panel_container.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_container.Location = new System.Drawing.Point(0, 0);
            this.panel_container.Name = "panel_container";
            this.panel_container.Size = new System.Drawing.Size(800, 548);
            this.panel_container.TabIndex = 3;
            // 
            // toolStrip
            // 
            this.toolStrip.AutoSize = false;
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton_dangXuat,
            this.toolStripSeparator1,
            this.toolStripButton_lamMoi});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(798, 46);
            this.toolStrip.TabIndex = 12;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripButton_dangXuat
            // 
            this.toolStripButton_dangXuat.AutoSize = false;
            this.toolStripButton_dangXuat.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_dangXuat.Image")));
            this.toolStripButton_dangXuat.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripButton_dangXuat.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_dangXuat.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_dangXuat.Name = "toolStripButton_dangXuat";
            this.toolStripButton_dangXuat.Size = new System.Drawing.Size(60, 40);
            this.toolStripButton_dangXuat.Text = "Đăng xuất";
            this.toolStripButton_dangXuat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton_dangXuat.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripButton_dangXuat.Click += new System.EventHandler(this.toolStripButton_dangXuat_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 46);
            // 
            // toolStripButton_lamMoi
            // 
            this.toolStripButton_lamMoi.AutoSize = false;
            this.toolStripButton_lamMoi.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton_lamMoi.Image")));
            this.toolStripButton_lamMoi.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toolStripButton_lamMoi.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton_lamMoi.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton_lamMoi.Name = "toolStripButton_lamMoi";
            this.toolStripButton_lamMoi.Size = new System.Drawing.Size(60, 40);
            this.toolStripButton_lamMoi.Text = "Làm mới";
            this.toolStripButton_lamMoi.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton_lamMoi.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.toolStripButton_lamMoi.Click += new System.EventHandler(this.toolStripButton_lamMoi_Click);
            // 
            // button_xacNhan
            // 
            this.button_xacNhan.BackColor = System.Drawing.Color.GreenYellow;
            this.button_xacNhan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_xacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xacNhan.Location = new System.Drawing.Point(267, 118);
            this.button_xacNhan.Name = "button_xacNhan";
            this.button_xacNhan.Size = new System.Drawing.Size(75, 28);
            this.button_xacNhan.TabIndex = 9;
            this.button_xacNhan.Text = "vào thi";
            this.button_xacNhan.UseVisualStyleBackColor = false;
            this.button_xacNhan.Click += new System.EventHandler(this.button_xacNhan_Click);
            // 
            // label_maXacNhan
            // 
            this.label_maXacNhan.AutoSize = true;
            this.label_maXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_maXacNhan.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label_maXacNhan.Location = new System.Drawing.Point(11, 118);
            this.label_maXacNhan.Name = "label_maXacNhan";
            this.label_maXacNhan.Size = new System.Drawing.Size(119, 24);
            this.label_maXacNhan.TabIndex = 8;
            this.label_maXacNhan.Text = "Mã xác nhận";
            // 
            // textBox_maXacNhan
            // 
            this.textBox_maXacNhan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_maXacNhan.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_maXacNhan.Location = new System.Drawing.Point(136, 120);
            this.textBox_maXacNhan.Name = "textBox_maXacNhan";
            this.textBox_maXacNhan.Size = new System.Drawing.Size(125, 22);
            this.textBox_maXacNhan.TabIndex = 7;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeight = 40;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.EnableHeadersVisualStyles = false;
            this.dataGridView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dataGridView.Location = new System.Drawing.Point(11, 152);
            this.dataGridView.MultiSelect = false;
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.RowHeadersWidth = 30;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(776, 383);
            this.dataGridView.TabIndex = 3;
            this.dataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_CellFormatting);
            // 
            // FormLichThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 548);
            this.Controls.Add(this.panel_container);
            this.Name = "FormLichThi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLichThi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormLichThi_FormClosed);
            this.Load += new System.EventHandler(this.FormLichThi_Load);
            this.panel_container.ResumeLayout(false);
            this.panel_container.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label_title;
        private System.Windows.Forms.Panel panel_container;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label_maXacNhan;
        private System.Windows.Forms.TextBox textBox_maXacNhan;
        private System.Windows.Forms.Button button_xacNhan;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton toolStripButton_dangXuat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton_lamMoi;
    }
}