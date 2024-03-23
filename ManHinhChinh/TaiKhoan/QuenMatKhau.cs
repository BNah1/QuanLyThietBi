using System.Net;
using System.Net.Mail;

namespace ManHinhChinh
{
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string taiKhoanEmail = txt_email.Text;
            string soDienThoai = txt_phone.Text;

            // Kiểm tra xem tài khoản hoặc email có tồn tại trong hệ thống không
            if (KiemTraTaiKhoanEmail(taiKhoanEmail))
            {
                // Gửi email chứa mật khẩu mới
                string matKhauMoi = TaoMatKhauMoi();
                GuiEmail(taiKhoanEmail, matKhauMoi);
                MessageBox.Show("Mật khẩu mới đã được gửi đến email của bạn.");
            }
            else
            {
                MessageBox.Show("Tên tài khoản hoặc email không tồn tại!");
            }


        }

        // Hàm kiểm tra tài khoản hoặc email có tồn tại trong hệ thống không
        private bool KiemTraTaiKhoanEmail(string taiKhoanEmail)
        {
            // Thực hiện kiểm tra tài khoản hoặc email trong hệ thống
            // Return true nếu tồn tại, ngược lại return false
            return true;
        }

        // Hàm tạo mật khẩu mới
        private string TaoMatKhauMoi()
        {
            // Thực hiện tạo mật khẩu mới
            // Return mật khẩu mới được tạo
            return "MatKhauMoi123";
        }

        // Hàm gửi email chứa mật khẩu mới
        private void GuiEmail(string email, string matKhauMoi)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.example.com");

                mail.From = new MailAddress("huuhuy1801@gmail.com");
                mail.To.Add(email);
                mail.Subject = "Mật khẩu mới";
                mail.Body = $"Mật khẩu mới của bạn là: {matKhauMoi}";

                SmtpServer.Port = 587;
                SmtpServer.Credentials = new NetworkCredential("huuhuy1801@gmail.com", "Ttttt");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi gửi email: {ex.Message}");
            }
        }
    }
}
