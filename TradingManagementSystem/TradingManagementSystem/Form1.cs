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

        private void button1_Click(object sender, EventArgs e)
        {
            string tentk = textBox_TenTaiKhoan.Text;
            string matkhau = textBox_MatKhau.Text;
            if (tentk.Trim() == "") { MessageBox.Show("Vui long nhap ten tai khoan"); return; }
            else if (matkhau.Trim() == "") { MessageBox.Show("Vui long nhap mat khau"); return; }
            else 
            {
                string query = "Select * from TaiKhoan where TenTaiKhoan = '"+tentk+"' and MatKhau = '"+matkhau+"'";
                if (modify.Taikhoans(query).Count != 0)
                {
                    MessageBox.Show("Đăng Nhập Thành Công");
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