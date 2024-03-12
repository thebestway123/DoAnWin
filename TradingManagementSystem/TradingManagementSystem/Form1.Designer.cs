namespace TradingManagementSystem
{
    partial class DangNhap
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.textBox_TaiKhoan = new System.Windows.Forms.TextBox();
            this.textBox_MatKhau = new System.Windows.Forms.TextBox();
            this.QuenMatKhauLabel = new System.Windows.Forms.LinkLabel();
            this.DangKyLabel = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::TradingManagementSystem.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(76, 200);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 28);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::TradingManagementSystem.Properties.Resources.download__1_;
            this.pictureBox2.Location = new System.Drawing.Point(76, 260);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 27);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // textBox_TaiKhoan
            // 
            this.textBox_TaiKhoan.Location = new System.Drawing.Point(158, 203);
            this.textBox_TaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_TaiKhoan.Name = "textBox_TaiKhoan";
            this.textBox_TaiKhoan.Size = new System.Drawing.Size(184, 23);
            this.textBox_TaiKhoan.TabIndex = 2;
            this.textBox_TaiKhoan.TextChanged += new System.EventHandler(this.TenTaiKhoan_TextChanged);
            // 
            // textBox_MatKhau
            // 
            this.textBox_MatKhau.Location = new System.Drawing.Point(158, 266);
            this.textBox_MatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_MatKhau.Name = "textBox_MatKhau";
            this.textBox_MatKhau.Size = new System.Drawing.Size(184, 23);
            this.textBox_MatKhau.TabIndex = 3;
            // 
            // QuenMatKhauLabel
            // 
            this.QuenMatKhauLabel.AutoSize = true;
            this.QuenMatKhauLabel.Location = new System.Drawing.Point(85, 330);
            this.QuenMatKhauLabel.Name = "QuenMatKhauLabel";
            this.QuenMatKhauLabel.Size = new System.Drawing.Size(95, 15);
            this.QuenMatKhauLabel.TabIndex = 4;
            this.QuenMatKhauLabel.TabStop = true;
            this.QuenMatKhauLabel.Text = "Quên Mật Khẩu?";
            this.QuenMatKhauLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.QuenMatKhauLabel_LinkClicked);
            // 
            // DangKyLabel
            // 
            this.DangKyLabel.AutoSize = true;
            this.DangKyLabel.Location = new System.Drawing.Point(319, 330);
            this.DangKyLabel.Name = "DangKyLabel";
            this.DangKyLabel.Size = new System.Drawing.Size(50, 15);
            this.DangKyLabel.TabIndex = 5;
            this.DangKyLabel.TabStop = true;
            this.DangKyLabel.Text = "Đăng Ký";
            this.DangKyLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.DangKyLabel_LinkClicked);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 358);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 22);
            this.button1.TabIndex = 6;
            this.button1.Text = "Đăng Nhập";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 430);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DangKyLabel);
            this.Controls.Add(this.QuenMatKhauLabel);
            this.Controls.Add(this.textBox_MatKhau);
            this.Controls.Add(this.textBox_TaiKhoan);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TextBox textBox_TaiKhoan;
        private TextBox textBox_MatKhau;
        private LinkLabel QuenMatKhauLabel;
        private LinkLabel DangKyLabel;
        private Button button1;
    }
}