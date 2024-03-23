using ManHinhChinh.XuLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManHinhChinh.TaiKhoan
{
    public partial class QuyenTruyCap : Form
    {


        public QuyenTruyCap()
        {
            InitializeComponent();
            dataLoad();
            LoadComboBoxData();
        }
        private  string ConnectionString = Connection.stringConnection;

        //xử lý button
        private void button_Them_Click(object sender, EventArgs e)
        {
            try
            {
                string tenTaiKhoan = comboBoxTTK.SelectedItem.ToString();
                string maPhongHoc = comboBoxPhong.SelectedItem?.ToString();
                string maToaNha = comboBoxToaNha.SelectedItem?.ToString();
                string loaiTaiKhoan = txtLTK.Text;

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query;

                    if (loaiTaiKhoan == "NhanVien")
                    {
                        if (string.IsNullOrEmpty(maToaNha))
                        {
                            // Xử lý trường hợp chưa chọn tòa nhà
                            MessageBox.Show("Vui lòng chọn tòa nhà.");
                            return;
                        }

                        query = "INSERT INTO QuyenTruyCapNV (TenTaiKhoan, MaToaNha, LoaiTaiKhoan) VALUES (@TenTaiKhoan, @MaToaNha, @LoaiTaiKhoan)";
                    }
                    else if (loaiTaiKhoan == "GiaoVien")
                    {
                        if (string.IsNullOrEmpty(maPhongHoc))
                        {
                            // Xử lý trường hợp chưa chọn phòng học
                            MessageBox.Show("Vui lòng chọn phòng học.");
                            return;
                        }

                        query = "INSERT INTO QuyenTruyCapGV (TenTaiKhoan, MaPhongHoc, LoaiTaiKhoan) VALUES (@TenTaiKhoan, @MaPhongHoc, @LoaiTaiKhoan)";
                    }
                    else
                    {
                        // Xử lý trường hợp LoaiTaiKhoan không hợp lệ
                        MessageBox.Show("Loại tài khoản không hợp lệ.");
                        return;
                    }

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm các tham số và giá trị tương ứng
                        command.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);

                        // Kiểm tra và cung cấp giá trị cho tham số @MaToaNha hoặc @MaPhongHoc
                        if (loaiTaiKhoan == "NhanVien")
                        {
                            command.Parameters.AddWithValue("@MaToaNha", maToaNha);
                        }
                        else if (loaiTaiKhoan == "GiaoVien")
                        {
                            command.Parameters.AddWithValue("@MaPhongHoc", maPhongHoc);
                        }

                        command.Parameters.AddWithValue("@LoaiTaiKhoan", loaiTaiKhoan);

                        // Thực thi truy vấn SQL
                        command.ExecuteNonQuery();
                    }

                    MessageBox.Show("Thêm dữ liệu thành công.");
                    dataLoad();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }
        private void button_Sua_Click(object sender, EventArgs e)
        {
            try
            {
                string tenTaiKhoan = comboBoxTTK.SelectedItem?.ToString();
                string loaiTaiKhoan = txtLTK.Text;

                if (string.IsNullOrEmpty(tenTaiKhoan))
                {
                    MessageBox.Show("Vui lòng chọn tên tài khoản.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query;

                    if (loaiTaiKhoan == "NhanVien")
                    {
                        string maToaNha = comboBoxToaNha.SelectedItem?.ToString();

                        if (string.IsNullOrEmpty(maToaNha))
                        {
                            MessageBox.Show("Vui lòng chọn mã tòa nhà.");
                            return;
                        }

                        query = "UPDATE QuyenTruyCapNV SET MaToaNha = @MaToaNha WHERE TenTaiKhoan = @TenTaiKhoan";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
                            command.Parameters.AddWithValue("@MaToaNha", maToaNha);
                            command.ExecuteNonQuery();
                        }
                    }
                    else if (loaiTaiKhoan == "GiaoVien")
                    {
                        string maPhongHoc = comboBoxPhong.SelectedItem?.ToString();

                        if (string.IsNullOrEmpty(maPhongHoc))
                        {
                            MessageBox.Show("Vui lòng chọn mã phòng học.");
                            return;
                        }

                        query = "UPDATE QuyenTruyCapGV SET MaPhongHoc = @MaPhongHoc WHERE TenTaiKhoan = @TenTaiKhoan";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
                            command.Parameters.AddWithValue("@MaPhongHoc", maPhongHoc);
                            command.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Loại tài khoản không hợp lệ.");
                        return;
                    }

                    MessageBox.Show("Cập nhật dữ liệu thành công.");
                    dataLoad();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                string tenTaiKhoan = comboBoxTTK.SelectedItem?.ToString();
                string loaiTaiKhoan = txtLTK.Text;

                if (string.IsNullOrEmpty(tenTaiKhoan))
                {
                    MessageBox.Show("Vui lòng chọn tên tài khoản.");
                    return;
                }

                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();
                    string query;

                    if (loaiTaiKhoan == "NhanVien")
                    {
                        string maToaNha = comboBoxToaNha.SelectedItem?.ToString();

                        if (string.IsNullOrEmpty(maToaNha))
                        {
                            MessageBox.Show("Vui lòng chọn mã tòa nhà.");
                            return;
                        }

                        query = "DELETE FROM QuyenTruyCapNV WHERE TenTaiKhoan = @TenTaiKhoan AND MaToaNha = @MaToaNha";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
                            command.Parameters.AddWithValue("@MaToaNha", maToaNha);
                            command.ExecuteNonQuery();
                        }
                    }
                    else if (loaiTaiKhoan == "GiaoVien")
                    {
                        string maPhongHoc = comboBoxPhong.SelectedItem?.ToString();

                        if (string.IsNullOrEmpty(maPhongHoc))
                        {
                            MessageBox.Show("Vui lòng chọn mã phòng học.");
                            return;
                        }

                        query = "DELETE FROM QuyenTruyCapGV WHERE TenTaiKhoan = @TenTaiKhoan AND MaPhongHoc = @MaPhongHoc";

                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
                            command.Parameters.AddWithValue("@MaPhongHoc", maPhongHoc);
                            command.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Loại tài khoản không hợp lệ.");
                        return;
                    }

                    MessageBox.Show("Xóa dữ liệu thành công.");
                    dataLoad();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }



        private void DataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Chỉ xử lý khi người dùng nhấp vào một dòng hợp lệ
            {
                // Lấy giá trị từ ô trong dòng được chọn
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string maPhongHoc = row.Cells["MaPhongHoc"].Value?.ToString() ?? string.Empty;
                string maToaNha = row.Cells["MaToaNha"].Value?.ToString() ?? string.Empty;
                string tenTaiKhoan = row.Cells["TenTaiKhoan"].Value?.ToString() ?? string.Empty;

                // Điền giá trị vào ComboBox và TextBox tương ứng
                comboBoxPhong.SelectedItem = string.IsNullOrEmpty(maPhongHoc) ? null : maPhongHoc;
                comboBoxToaNha.SelectedItem = string.IsNullOrEmpty(maToaNha) ? null : maToaNha;
                comboBoxTTK.SelectedItem = string.IsNullOrEmpty(tenTaiKhoan) ? null : tenTaiKhoan;
            }
        }
        private void comboBoxTTK_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy giá trị được chọn từ comboBoxTTK
            string selectedTenTaiKhoan = comboBoxTTK.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedTenTaiKhoan))
            {
                try
                {
                    // Kết nối đến cơ sở dữ liệu
                    using (SqlConnection connection = new SqlConnection(@ConnectionString))
                    {
                        connection.Open();

                        // Truy vấn SQL để lấy giá trị của LoaiTaiKhoan tương ứng với TenTaiKhoan được chọn
                        string query = "SELECT LoaiTaiKhoan FROM TaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan";

                        // Tạo đối tượng SqlCommand và kết nối
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@TenTaiKhoan", selectedTenTaiKhoan);

                            // Thực hiện truy vấn và đọc dữ liệu
                            string loaiTaiKhoan = command.ExecuteScalar()?.ToString();

                            // Gán giá trị LoaiTaiKhoan vào txtLTK
                            txtLTK.Text = loaiTaiKhoan;
                        }
                    }
                }
                catch (SqlException ex)
                {
                    // Xử lý lỗi
                    Console.WriteLine("Đã xảy ra lỗi khi tải dữ liệu: " + ex.Message);
                }
            }
        }
        //Load DATA từ SQL
        private void LoadComboBoxData()
        {
            try
            {
                // Kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(ConnectionString))
                {
                    connection.Open();

                    // Truy vấn SQL để lấy danh sách MaPhongHoc từ bảng Phong
                    string queryPhong = "SELECT MaPhongHoc FROM PhongHoc";

                    // Tạo đối tượng SqlCommand và kết nối
                    using (SqlCommand commandPhong = new SqlCommand(queryPhong, connection))
                    {
                        // Đọc dữ liệu từ SqlDataReader
                        using (SqlDataReader readerPhong = commandPhong.ExecuteReader())
                        {
                            // Xóa các giá trị hiện có trong comboBoxPhong
                            comboBoxPhong.Items.Clear();

                            // Đọc từng dòng dữ liệu và thêm vào comboBoxPhong
                            while (readerPhong.Read())
                            {
                                string maPhongHoc = readerPhong.GetString(0);
                                comboBoxPhong.Items.Add(maPhongHoc);
                            }
                        }
                    }

                    // Truy vấn SQL để lấy danh sách MaToaNha từ bảng ToaNha
                    string queryToaNha = "SELECT MaToaNha FROM ToaNha";

                    // Tạo đối tượng SqlCommand và kết nối
                    using (SqlCommand commandToaNha = new SqlCommand(queryToaNha, connection))
                    {
                        // Đọc dữ liệu từ SqlDataReader
                        using (SqlDataReader readerToaNha = commandToaNha.ExecuteReader())
                        {
                            // Xóa các giá trị hiện có trong comboBoxToaNha
                            comboBoxToaNha.Items.Clear();

                            // Đọc từng dòng dữ liệu và thêm vào comboBoxToaNha
                            while (readerToaNha.Read())
                            {
                                string maToaNha = readerToaNha.GetString(0);
                                comboBoxToaNha.Items.Add(maToaNha);
                            }
                        }
                    }

                    // Truy vấn SQL để lấy danh sách TenTaiKhoan từ bảng TaiKhoan
                    string queryTaiKhoan = "SELECT TenTaiKhoan FROM TaiKhoan";

                    // Tạo đối tượng SqlCommand và kết nối
                    using (SqlCommand commandTaiKhoan = new SqlCommand(queryTaiKhoan, connection))
                    {
                        // Đọc dữ liệu từ SqlDataReader
                        using (SqlDataReader readerTaiKhoan = commandTaiKhoan.ExecuteReader())
                        {
                            // Xóa các giá trị hiện có trong comboBoxTTK
                            comboBoxTTK.Items.Clear();

                            // Đọc từng dòng dữ liệu và thêm vào comboBoxTTK
                            while (readerTaiKhoan.Read())
                            {
                                string tenTaiKhoan = readerTaiKhoan.GetString(0);
                                comboBoxTTK.Items.Add(tenTaiKhoan);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi
                Console.WriteLine("Đã xảy ra lỗi khi tải danh sách phòng và tòa nhà: " + ex.Message);
            }
        }
        private void dataLoad()
        {
            // Khởi tạo DataTable
            DataTable dataTable = new DataTable("QuyenTruyCap");

            // Thêm các cột vào DataTable
            dataTable.Columns.Add("TenTaiKhoan", typeof(string));
            dataTable.Columns.Add("MaPhongHoc", typeof(string));
            dataTable.Columns.Add("MaToaNha", typeof(string));
            dataTable.Columns.Add("LoaiTaiKhoan", typeof(string));

            // Thực hiện truy vấn SQL
            string query = @"
        SELECT QCGV.TenTaiKhoan, QCGV.MaPhongHoc, NULL AS MaToaNha, TK.LoaiTaiKhoan
        FROM QuyenTruyCapGV QCGV
        INNER JOIN TaiKhoan TK ON QCGV.TenTaiKhoan = TK.TenTaiKhoan
        UNION ALL
        SELECT QCNV.TenTaiKhoan, NULL AS MaPhongHoc, QCNV.MaToaNha, TK.LoaiTaiKhoan
        FROM QuyenTruyCapNV QCNV
        INNER JOIN TaiKhoan TK ON QCNV.TenTaiKhoan = TK.TenTaiKhoan";

            try
            {
                // Mở kết nối
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    // Tạo đối tượng SqlDataAdapter và truyền truy vấn SQL và kết nối vào
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        // Điền dữ liệu từ adapter vào DataTable
                        adapter.Fill(dataTable);
                    }
                }

                // Sử dụng DataTable để hiển thị dữ liệu lên giao diện hoặc xử lý tiếp
                // Ví dụ: gán DataTable vào DataSource của một DataGridView
                dataGridView1.DataSource = dataTable;
            }
            catch (SqlException ex)
            {
                // Xử lý lỗi
                Console.WriteLine("Đã xảy ra lỗi khi tải dữ liệu: " + ex.Message);
            }
        }


    }
}
