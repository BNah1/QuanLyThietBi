

using Form_DangNhap_Dangky_QMK;
using ManHinhChinh.Service;

namespace ManHinhChinh
{
    public partial class DoiMatKhau : Form
    {

        // private DangNhapService dangNhapService = new DangNhapService();
        public DoiMatKhau()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Đóng form DoiMatKhau
            DoiMatKhau doiMatKhauForm = (DoiMatKhau)Application.OpenForms["DoiMatKhau"];
            doiMatKhauForm.Close();
        }

        private void textBox_TenTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các TextBox
            string tenTaiKhoan = DangNhap.TenDangNhap;
            string matKhauHienTai = txt_oldPassword.Text;
            string matKhauMoi = txt_newPassword.Text;
            string xacNhanMatKhau = txt_confirmPassword.Text;

            // Kiểm tra xem mật khẩu mới và xác nhận mật khẩu có khớp nhau không
            if (matKhauMoi != xacNhanMatKhau)
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp nhau.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Gọi phương thức DoiMatKhau từ đối tượng DangNhapService
            DangNhapService dangNhapService = new DangNhapService();
            bool doiMatKhauThanhCong = dangNhapService.DoiMatKhau(tenTaiKhoan, matKhauHienTai, matKhauMoi);

            // Kiểm tra kết quả từ phương thức DoiMatKhau
            if (doiMatKhauThanhCong)
            {
                MessageBox.Show("Đổi mật khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Thực hiện các hành động bổ sung sau khi đổi mật khẩu thành công
                this.Hide();

                TrangChu trangChu = new TrangChu();
                trangChu.StartPosition = FormStartPosition.CenterScreen;
                trangChu.FormClosed += (s, args) => this.Close();
                trangChu.Show();
            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại. Vui lòng kiểm tra lại thông tin đăng nhập.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
