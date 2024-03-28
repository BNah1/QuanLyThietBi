using ManHinhChinh;
using ManHinhChinh.Service;
using ManHinhChinh.XuLy;
using System.Data.SqlClient;
using System.Media;

namespace Form_DangNhap_Dangky_QMK
{
    public partial class DangNhap : Form
    {
        private DangNhapService dangNhapService;
        public static string TenDangNhap { get; private set; }
        public static string loaiTaiKhoan { get; private set; }

        public DangNhap()
        {
            InitializeComponent();
            dangNhapService = new DangNhapService();
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // Xử lý sự kiện khi hình ảnh được nhấn
        }
        
        private void linkLabel_QuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Khởi tạo form quenMatKhau
            QuenMatKhau quenMatKhau = new QuenMatKhau();

            // Xác định vị trí xuất hiện giữa form TrangChu
            quenMatKhau.StartPosition = FormStartPosition.Manual;
            quenMatKhau.Left = this.Left + (this.Width - quenMatKhau.Width) / 2;
            quenMatKhau.Top = this.Top + (this.Height - quenMatKhau.Height) / 2;

            // Hiển thị form quenMatKhau
            quenMatKhau.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy tên tài khoản và mật khẩu từ các điều khiển trên giao diện
                string tenTaiKhoan = txt_TenTaiKhoan.Text;
                TenDangNhap = tenTaiKhoan;
                string matKhau = txt_MatKhau.Text;

                // Kiểm tra đăng nhập
                if (dangNhapService.KiemTraDangNhap(tenTaiKhoan, matKhau))
                {


                    MessageBox.Show("Đăng nhập thành công!");
                    // Đóng form đăng nhập và mở form trang chủ
                    this.Hide();

                    if (TenDangNhap == "QL001")
                    {
                        TrangAdmin trangAdmin = new TrangAdmin();
                        trangAdmin.StartPosition = FormStartPosition.CenterScreen;
                        trangAdmin.FormClosed += (s, args) => this.Close();
                        trangAdmin.Show();
                        
                    }
                    else 
                    {
                        TrangChu trangChu = new TrangChu();
                        trangChu.StartPosition = FormStartPosition.CenterScreen;
                        trangChu.FormClosed += (s, args) => this.Close();
                        trangChu.Show();
                    }
                    
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng!");
                }
            }
            catch (ArgumentException)
            {
                SystemSounds.Exclamation.Play();
                MessageBox.Show("Tên tài khoản không hợp lệ!");
            }

            using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
            {
                // Mở kết nối đến cơ sở dữ liệu
                connection.Open();

                // Truy vấn để lấy giá trị LoaiTaiKhoan từ bảng TaiKhoan
                string query = "SELECT LoaiTaiKhoan FROM TaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Đặt giá trị của tham số @TenTaiKhoan là TenDangNhap (là TenTaiKhoan trong bảng)
                    command.Parameters.AddWithValue("@TenTaiKhoan", TenDangNhap);

                    // Thực thi truy vấn và đọc kết quả
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Đọc giá trị LoaiTaiKhoan từ kết quả truy vấn và gán cho biến loaiTaiKhoan
                            loaiTaiKhoan = reader["LoaiTaiKhoan"].ToString();
                        }
                    }
                    connection.Close();
                }

            }

        }

        private void linkLabel_DangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Xử lý sự kiện khi linkLabel Đăng ký được nhấn
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            LoadDataFromTamGhiNho();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {                }
        
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            string tenTaiKhoan = txt_TenTaiKhoan.Text;
            string deleteQuery = "DELETE FROM TamGhiNho WHERE TenTaiKhoan = '"+tenTaiKhoan+"'";

            using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(deleteQuery, connection);
                command.ExecuteNonQuery();
            }
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (radioButton1.Checked)
                {
                    string tenTaiKhoan = txt_TenTaiKhoan.Text;
                    string matKhau = txt_MatKhau.Text;
                    using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                    {
                        connection.Open(); // Mở kết nối đến cơ sở dữ liệu

                        string insertQuery = "DELETE FROM TamGhiNho ; INSERT INTO TamGhiNho (TenTaiKhoan, MatKhau) VALUES (@TenTaiKhoan, @MatKhau)";
                        SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                        insertCommand.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
                        insertCommand.Parameters.AddWithValue("@MatKhau", matKhau);
                        insertCommand.ExecuteNonQuery();

                        // Các thao tác khác trên cơ sở dữ liệu (nếu có)

                        connection.Close(); // Đóng kết nối sau khi hoàn thành
                    }
  
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi nhớ: " + ex.Message);
            }
        }

        private void LoadDataFromTamGhiNho()
        {
            using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
            {
                connection.Open();
                string selectQuery = "SELECT TOP 1 * FROM TamGhiNho"; // Lấy thông tin từ bảng TamGhiNho
                SqlCommand command = new SqlCommand(selectQuery, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    txt_TenTaiKhoan.Text = reader["TenTaiKhoan"].ToString(); // Điền dữ liệu vào txt_TenTaiKhoan
                    txt_MatKhau.Text = reader["MatKhau"].ToString(); // Điền dữ liệu vào txt_MatKhau
                }
                connection.Close();
            }
        }
        
         
    }
} 

