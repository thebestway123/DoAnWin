namespace TradingManagementSystem
{
    partial class DangKy
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox_TenTaiKhoan = new System.Windows.Forms.TextBox();
            this.textBox_MatKhau = new System.Windows.Forms.TextBox();
            this.textBox_XNMatKhau = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tài Khoản:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật Khẩu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Xác Nhận Mật Khẩu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 310);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(173, 369);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 22);
            this.button1.TabIndex = 4;
            this.button1.Text = "Đăng Ký";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox_TenTaiKhoan
            // 
            this.textBox_TenTaiKhoan.Location = new System.Drawing.Point(191, 214);
            this.textBox_TenTaiKhoan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_TenTaiKhoan.Name = "textBox_TenTaiKhoan";
            this.textBox_TenTaiKhoan.Size = new System.Drawing.Size(195, 23);
            this.textBox_TenTaiKhoan.TabIndex = 5;
            // 
            // textBox_MatKhau
            // 
            this.textBox_MatKhau.Location = new System.Drawing.Point(191, 246);
            this.textBox_MatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_MatKhau.Name = "textBox_MatKhau";
            this.textBox_MatKhau.Size = new System.Drawing.Size(195, 23);
            this.textBox_MatKhau.TabIndex = 6;
            this.textBox_MatKhau.TextChanged += new System.EventHandler(this.textBox_XNMatKhau_TextChanged);
            // 
            // textBox_XNMatKhau
            // 
            this.textBox_XNMatKhau.Location = new System.Drawing.Point(191, 279);
            this.textBox_XNMatKhau.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_XNMatKhau.Name = "textBox_XNMatKhau";
            this.textBox_XNMatKhau.Size = new System.Drawing.Size(195, 23);
            this.textBox_XNMatKhau.TabIndex = 7;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(191, 317);
            this.textBox_Email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(195, 23);
            this.textBox_Email.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(201, 68);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(74, 52);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 430);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textBox_XNMatKhau);
            this.Controls.Add(this.textBox_MatKhau);
            this.Controls.Add(this.textBox_TenTaiKhoan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DangKy";
            this.Text = "DangKy";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button1;
        private TextBox textBox_TenTaiKhoan;
        private TextBox textBox_MatKhau;
        private TextBox textBox_XNMatKhau;
        private TextBox textBox_Email;
        private PictureBox pictureBox1;
    }
}