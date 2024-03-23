using ManHinhChinh.XuLy;
using Newtonsoft.Json.Linq;
using System.Data.SqlClient;

namespace ManHinhChinh.Service
{
    public class DangNhapService
    {

        private JObject data;
        private bool isLoggedIn;



        public bool KiemTraDangNhap(string username, string password)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    // Mở kết nối đến cơ sở dữ liệu
                    connection.Open();

                    // Truy vấn kiểm tra tài khoản và mật khẩu
                    string query = "SELECT COUNT(*) FROM TaiKhoan WHERE TenTaiKhoan = @Username AND MatKhau = @Password ";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm các tham số
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);

                        // Thực thi truy vấn
                        int count = (int)command.ExecuteScalar();

                        // Kiểm tra kết quả
                        if (count > 0)
                        {
                            // Nếu đăng nhập thành công, thực hiện cập nhật trạng thái thiết bị
                            string updateQuery = @"UPDATE ThietBi
                                           SET TinhTrang = 'Warning'
                                           WHERE DATEDIFF(day, NgayCapNhatGiaoVien, GETDATE()) >= 3 AND TinhTrang <> 'Warning';";

                            using (SqlCommand updateCommand = new SqlCommand(updateQuery, connection))
                            {
                                updateCommand.ExecuteNonQuery();
                            }
                        }

                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có
                MessageBox.Show("Error: " + ex.Message);
                return false;
            }
        }


        public bool DoiMatKhau(string username, string oldPassword, string newPassword)
        {
            using (SqlConnection connection = new SqlConnection(Connection.stringConnection"))
            {
                // Mở kết nối đến cơ sở dữ liệu
                connection.Open();

                // Truy vấn kiểm tra tài khoản và mật khẩu cũ
                string query = "SELECT COUNT(*) FROM TaiKhoan WHERE TenTaiKhoan = @Username AND MatKhau = @OldPassword";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm các tham số
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@OldPassword", oldPassword);

                    // Thực thi truy vấn
                    int count = (int)command.ExecuteScalar();

                    // Kiểm tra xem mật khẩu cũ có đúng không
                    if (count > 0)
                    {
                        // Truy vấn cập nhật mật khẩu mới
                        query = "UPDATE TaiKhoan SET MatKhau = @NewPassword WHERE TenTaiKhoan = @Username";
                        using (SqlCommand updateCommand = new SqlCommand(query, connection))
                        {
                            // Thêm các tham số
                            updateCommand.Parameters.AddWithValue("@Username", username);
                            updateCommand.Parameters.AddWithValue("@NewPassword", newPassword);

                            // Thực thi truy vấn cập nhật
                            int rowsAffected = updateCommand.ExecuteNonQuery();

                            // Kiểm tra xem có dòng nào bị ảnh hưởng không
                            return rowsAffected > 0;

                        }
                    }
                    else
                    {
                        // Mật khẩu cũ không chính xác
                        MessageBox.Show("Mật khẩu cũ bạn nhập không chính xác");
                        return false;
                    }

                }
                connection.Close();
            }
        }

        public void DangXuat()
        {
            isLoggedIn = false;
        }
    }
}
