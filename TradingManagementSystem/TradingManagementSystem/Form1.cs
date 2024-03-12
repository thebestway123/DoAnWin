namespace TradingManagementSystem

{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangKyLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dangKy = new DangKy();
            dangKy.ShowDialog();
        }

        private void QuenMatKhauLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            QuenMatKhau quenMatKhau = new QuenMatKhau();
            quenMatKhau.ShowDialog();
        }
        Modify modify = new Modify();
        private void button1_Click(object sender, EventArgs e)
        {
            string tentk = textBox_TaiKhoan.Text;
            string matkhau = textBox_MatKhau.Text;
            if (tentk.Trim() == "") { MessageBox.Show("Vui long nhap ten tai khoan"); return; }
            else if (matkhau.Trim() == "") { MessageBox.Show("Vui long nhap mat khau"); return; }
            else 
            {
                string query = "Select * from TaiKhoan where TenTaiKhoan = '"+tentk+"' and MatKhau = '"+matkhau+"'";
                if (modify.TaiKhoans(query).Count != 0)
                {
                    MessageBox.Show("Đăng Nhập Thành Công", "Thông Báo",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Tên Đăng Nhập Hoặc Mật Khẩu Không Chính Xác", "Thông Báo",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
            }

        }

        private void TenTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}