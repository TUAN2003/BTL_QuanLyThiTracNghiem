namespace BTL_QuanLyThiTracNghiem.FormsManager
{
    partial class FormInputDialog
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label_note = new System.Windows.Forms.Label();
            this.button_add = new System.Windows.Forms.Button();
            this.label_input = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(142, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label_note
            // 
            this.label_note.AutoSize = true;
            this.label_note.ForeColor = System.Drawing.Color.Red;
            this.label_note.Location = new System.Drawing.Point(12, 91);
            this.label_note.Name = "label_note";
            this.label_note.Size = new System.Drawing.Size(37, 13);
            this.label_note.TabIndex = 3;
            this.label_note.Text = "*Lưu ý";
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.GreenYellow;
            this.button_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_add.Location = new System.Drawing.Point(12, 60);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 1;
            this.button_add.Text = "Thêm";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label_input
            // 
            this.label_input.AutoSize = true;
            this.label_input.ForeColor = System.Drawing.Color.Red;
            this.label_input.Location = new System.Drawing.Point(9, 18);
            this.label_input.Name = "label_input";
            this.label_input.Size = new System.Drawing.Size(31, 13);
            this.label_input.TabIndex = 2;
            this.label_input.Text = "Input";
            // 
            // FormInputDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(166, 113);
            this.Controls.Add(this.label_input);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label_note);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "FormInputDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormInputDialog";
            this.Load += new System.EventHandler(this.FormInputDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_note;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label_input;
    }
}