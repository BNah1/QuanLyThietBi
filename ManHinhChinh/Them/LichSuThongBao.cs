using Form_DangNhap_Dangky_QMK;
using ManHinhChinh.XuLy;
using System.Data.SqlClient;

namespace ManHinhChinh
{
    public partial class LichSuThongBao : Form
    {

        // Chuỗi kết nối đến cơ sở dữ liệu của bạn
        private string connectionString = Connection.stringConnection;

        public LichSuThongBao()
        {
            InitializeComponent();
            LoadComboBoxData();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void LoadComboBoxData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query;
                    // Kiểm tra loại tài khoản để xây dựng câu truy vấn phù hợp
                    if (DangNhap.loaiTaiKhoan == "NhanVien")
                    {
                        // Truy vấn để lấy danh sách MaPhongHoc dựa trên quyền truy cập của Nhân viên
                        query = @"SELECT DISTINCT PhongHoc.MaPhongHoc, PhongHoc.TenPhongHoc
                                    FROM PhongHoc
                                    JOIN Tang ON PhongHoc.MaTang = Tang.MaTang
                                    JOIN ToaNha ON Tang.MaToaNha = ToaNha.MaToaNha
                                    JOIN QuyenTruyCapNV ON ToaNha.MaToaNha = QuyenTruyCapNV.MaToaNha
                                    WHERE QuyenTruyCapNV.TenTaiKhoan = @TenDangNhap;";
                    }
                    else if (DangNhap.loaiTaiKhoan == "GiaoVien")
                    {
                        // Truy vấn để lấy danh sách MaPhongHoc dựa trên quyền truy cập của Giáo viên
                        query = @"SELECT DISTINCT PhongHoc.MaPhongHoc, PhongHoc.TenPhongHoc
                                FROM PhongHoc
                                JOIN QuyenTruyCapGV ON PhongHoc.MaPhongHoc = QuyenTruyCapGV.MaPhongHoc
                                WHERE QuyenTruyCapGV.TenTaiKhoan = @TenDangNhap;";
                    }
                    else
                    {
                        query = "SELECT MaPhongHoc FROM PhongHoc";
                    }

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TenDangNhap", DangNhap.TenDangNhap);
                    SqlDataReader reader = command.ExecuteReader();

                    // Xóa các mục cũ trong ComboBox trước khi thêm mới
                    comboBox2.Items.Clear();

                    while (reader.Read())
                    {
                        comboBox2.Items.Add(reader["MaPhongHoc"].ToString());
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Xóa dữ liệu cũ trong DataGridView
            dataGridView1.Rows.Clear();

            try
            {
                // Lấy mã phòng học được chọn từ ComboBox
                string maPhongHoc = comboBox2.SelectedItem.ToString();

                // Thực hiện truy vấn SQL để lấy thông tin từ bảng ThietBi
                string query = @"SELECT MaThietBi, TenThietBi, TinhTrang, NgayCapNhatNhanVien, ThongBaoGiaoVien, NgayCapNhatGiaoVien
                         FROM ThietBi
                         WHERE MaPhongHoc = @MaPhongHoc AND TinhTrang <> N'Hoạt động'";

                // Mở kết nối
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Tạo và thực thi SqlCommand
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaPhongHoc", maPhongHoc);

                    // Đọc dữ liệu và hiển thị trên DataGridView
                    SqlDataReader reader = command.ExecuteReader();

                    // Kiểm tra và thêm các cột vào DataGridView nếu cần
                    if (dataGridView1.Columns.Count == 0)
                    {
                        dataGridView1.Columns.Add("TenThietBi", "Tên Thiết Bị");
                        dataGridView1.Columns.Add("TinhTrang", "Tình Trạng");
                        dataGridView1.Columns.Add("NgayCapNhatNhanVien", "Ngày Cập Nhật Nhân Viên");
                        dataGridView1.Columns.Add("ThongBaoGiaoVien", "Thông Báo Giáo Viên");
                        dataGridView1.Columns.Add("NgayCapNhatGiaoVien", "Ngày Cập Nhật Giáo Viên");
                    }

                    while (reader.Read())
                    {
                        string tenThietBi = reader["TenThietBi"].ToString();
                        string tinhTrang = reader["TinhTrang"].ToString();
                        string ngayCapNhatNhanVien = reader["NgayCapNhatNhanVien"].ToString();
                        string thongBaoGiaoVien = reader["ThongBaoGiaoVien"].ToString();
                        string ngayCapNhatGiaoVien = reader["NgayCapNhatGiaoVien"].ToString();

                        int rowIndex = dataGridView1.Rows.Add(tenThietBi, tinhTrang, ngayCapNhatNhanVien, thongBaoGiaoVien, ngayCapNhatGiaoVien);
                        // Kiểm tra nếu cột "Tình Trạng" có giá trị là "Warning", thì đổi màu văn bản của ô đó thành màu đỏ
                        if (tinhTrang == "Warning")
                        {
                            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells["TinhTrang"].Style.ForeColor = Color.Red;
                        }

                        // Kiểm tra nếu tình trạng là "Warning", thay đổi màu nền của hàng đó
                        if (tinhTrang == "Warning")
                        {
                            dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = Color.Red;
                            dataGridView1.Rows[rowIndex].DefaultCellStyle.ForeColor = Color.White;
                        }
                    }

                    // Đóng kết nối
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LichSuYeuCau_Load(object sender, EventArgs e)
        {

        }
    }
}
