using ManHinhChinh.XuLy;
using System.Data.SqlClient;

namespace ManHinhChinh
{
    public partial class HoTroNhanh : Form
    {
        public HoTroNhanh()
        {
            InitializeComponent();
            LoadComboBoxData();
        }

        // Phương thức để đổ dữ liệu vào ComboBox từ cơ sở dữ liệu
        private void LoadComboBoxData()
        {
            try
            {
                // Mở kết nối
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    // Truy vấn để lấy danh sách MaToaNha
                    string query = "SELECT MaToaNha FROM ToaNha";
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    // Đổ dữ liệu vào ComboBox
                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader["MaToaNha"].ToString());
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Xử lý sự kiện click vào cell trong DataGridView
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Xóa dữ liệu cũ trong DataGridView
            dataGridView1.Rows.Clear();

            try
            {
                // Lấy mã toà nhà được chọn từ ComboBox
                string maToaNha = comboBox1.SelectedItem.ToString();

                // Thực hiện truy vấn SQL để lấy thông tin từ bảng NhanVien
                string query = @"SELECT N.Ten, N.SDT, N.Email
                         FROM NhanVien N
                         INNER JOIN QuyenTruyCapNV Q ON N.TenTaiKhoan = Q.TenTaiKhoan AND Q.MaToaNha = @MaToaNha";

                // Mở kết nối
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    // Tạo và thực thi SqlCommand
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaToaNha", maToaNha);

                    // Đọc dữ liệu
                    SqlDataReader reader = command.ExecuteReader();

                    // Thêm các cột vào DataGridView nếu chưa tồn tại
                    if (dataGridView1.ColumnCount == 0)
                    {
                        dataGridView1.Columns.Add("Ten", "Tên");
                        dataGridView1.Columns.Add("SDT", "Số điện thoại");
                        dataGridView1.Columns.Add("Email", "Email");
                    }

                    // Thêm dữ liệu vào DataGridView
                    while (reader.Read())
                    {
                        dataGridView1.Rows.Add(reader["Ten"].ToString(), reader["SDT"].ToString(), reader["Email"].ToString());
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
    }
}
