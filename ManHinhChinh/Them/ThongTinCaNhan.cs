using Form_DangNhap_Dangky_QMK;
using ManHinhChinh.XuLy;
using System.Data.SqlClient;

namespace ManHinhChinh
{
    public partial class ThongTinCaNhan : Form
    {

        // Chuỗi kết nối đến cơ sở dữ liệu của bạn


        public ThongTinCaNhan()
        {
            InitializeComponent();
            labelTenTaiKhoan.Text = DangNhap.TenDangNhap;
            LoadData();

        }
        private bool buttonsVisible = false;
        private void LoadData()
        {
            try
            {
                string tenDangNhap = DangNhap.TenDangNhap; // Lấy tên đăng nhập từ form Đăng Nhập

                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    // Truy vấn thông tin từ bảng GiaoVien
                    string queryGiaoVien = "SELECT Ten, SDT, Email FROM GiaoVien WHERE TenTaiKhoan = @TenTaiKhoan";
                    SqlCommand commandGiaoVien = new SqlCommand(queryGiaoVien, connection);
                    commandGiaoVien.Parameters.AddWithValue("@TenTaiKhoan", tenDangNhap);
                    SqlDataReader readerGiaoVien = commandGiaoVien.ExecuteReader();

                    if (readerGiaoVien.Read())
                    {
                        labelTen.Text = readerGiaoVien["Ten"].ToString();
                        labelSDT.Text = readerGiaoVien["SDT"].ToString();
                        labelEmail.Text = readerGiaoVien["Email"].ToString();
                    }
                    readerGiaoVien.Close();

                    // Truy vấn thông tin từ bảng NhanVien
                    string queryNhanVien = "SELECT Ten, SDT, Email FROM NhanVien WHERE TenTaiKhoan = @TenTaiKhoan";
                    SqlCommand commandNhanVien = new SqlCommand(queryNhanVien, connection);
                    commandNhanVien.Parameters.AddWithValue("@TenTaiKhoan", tenDangNhap);
                    SqlDataReader readerNhanVien = commandNhanVien.ExecuteReader();

                    if (readerNhanVien.Read())
                    {
                        labelTen.Text = readerNhanVien["Ten"].ToString();
                        labelSDT.Text = readerNhanVien["SDT"].ToString();
                        labelEmail.Text = readerNhanVien["Email"].ToString();
                    }
                    readerNhanVien.Close();

                    // Truy vấn thông tin từ bảng QuanLy
                    string queryQuanLy = "SELECT Ten, SDT, Email FROM QuanLy WHERE TenTaiKhoan = @TenTaiKhoan";
                    SqlCommand commandQuanLy = new SqlCommand(queryQuanLy, connection);
                    commandQuanLy.Parameters.AddWithValue("@TenTaiKhoan", tenDangNhap);
                    SqlDataReader readerQuanLy = commandQuanLy.ExecuteReader();

                    if (readerQuanLy.Read())
                    {
                        labelTen.Text = readerQuanLy["Ten"].ToString();
                        labelSDT.Text = readerQuanLy["SDT"].ToString();
                        labelEmail.Text = readerQuanLy["Email"].ToString();
                    }
                    readerQuanLy.Close();

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBoxSDT.Text != "" || textBoxEmail.Text != "")
            {
                try
                {
                    string tenDangNhap = DangNhap.TenDangNhap; // Lấy tên đăng nhập từ form Đăng Nhập
                    string tableName = ""; // Biến lưu trữ tên bảng cần cập nhật

                    // Xác định tên bảng cần cập nhật dựa trên loại tài khoản
                    if (DangNhap.loaiTaiKhoan == "QuanLy")
                    {
                        tableName = "QuanLy";
                    }
                    else if (DangNhap.loaiTaiKhoan == "GiaoVien")
                    {
                        tableName = "GiaoVien";
                    }
                    else if (DangNhap.loaiTaiKhoan == "NhanVien")
                    {
                        tableName = "NhanVien";
                    }
                    else
                    {
                        MessageBox.Show("Invalid account type.");
                        return;
                    }

                    using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                    {
                        connection.Open();

                        // Cập nhật SDT nếu textBoxSDT có dữ liệu
                        if (textBoxSDT.Text != "")
                        {
                            string updateQuerySDT = $"UPDATE {tableName} SET SDT = @SDT WHERE TenTaiKhoan = @TenTaiKhoan";
                            SqlCommand commandSDT = new SqlCommand(updateQuerySDT, connection);
                            commandSDT.Parameters.AddWithValue("@SDT", textBoxSDT.Text);
                            commandSDT.Parameters.AddWithValue("@TenTaiKhoan", tenDangNhap);
                            commandSDT.ExecuteNonQuery();
                        }

                        // Cập nhật Email nếu textBoxEmail có dữ liệu
                        if (textBoxEmail.Text != "")
                        {
                            string updateQueryEmail = $"UPDATE {tableName} SET Email = @Email WHERE TenTaiKhoan = @TenTaiKhoan";
                            SqlCommand commandEmail = new SqlCommand(updateQueryEmail, connection);
                            commandEmail.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                            commandEmail.Parameters.AddWithValue("@TenTaiKhoan", tenDangNhap);
                            commandEmail.ExecuteNonQuery();
                        }

                        connection.Close();
                        MessageBox.Show("Cập nhập thành công");
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please enter some data to update.");
            }
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            if (!buttonsVisible)
            {
                textBoxSDT.Visible = true;
                labelSDT.Visible = false;
            }
            else
            {
                textBoxSDT.Visible = false;
                labelSDT.Visible = true;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (!buttonsVisible)
            {
                textBoxEmail.Visible = true;
                labelEmail.Visible = false;
            }
            else
            {
                textBoxEmail.Visible = false;
                labelEmail.Visible = true;
            }
        }
    }



}


