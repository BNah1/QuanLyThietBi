using Form_DangNhap_Dangky_QMK;
using ManHinhChinh.XuLy;
using System.Data.SqlClient;

namespace ManHinhChinh.QuanLyThietBi
{
    public partial class ChiTietPhanMem : Form
    {
        Modify modify = new Modify();
        public static string connectionString = Connection.stringConnection;
        
        public ChiTietPhanMem()
        {
            InitializeComponent();
            LoadComboBoxData();
            
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
                    comboBox1.Items.Clear();

                    while (reader.Read())
                    {
                        comboBox1.Items.Add(reader["MaPhongHoc"].ToString());
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void ChiTietPhanMem_Load(object sender, EventArgs e)
        {
            /*
            try
            {
                dataGridView_ctpm.DataSource = modify.Table("SELECT \r\n    PhongHoc.MaPhongHoc AS 'Mã Phòng Học',\r\n    " +
                    "ThietBi.MaThietBi AS 'Mã Thiết Bị',\r\n    ThietBi.TinhTrang AS 'Tình Trạng',\r\n    " +
                    "ThietBi.NgayCapNhatNhanVien AS 'Ngày Cập Nhật Nhân Viên',\r\n    " +
                    "ThietBi.ThongBaoGiaoVien AS 'Thông Báo Giáo Viên',\r\n    " +
                    "ThietBi.NgayCapNhatGiaoVien AS 'Ngày Cập Nhật Giáo Viên',\r\n   " +
                    " PM.TenPhanMem AS 'Tên Phần Mềm'\r\nFROM \r\n    PhongHoc\r\nJOIN \r\n    " +
                    "ThietBi ON PhongHoc.MaPhongHoc = ThietBi.MaPhongHoc\r\nLEFT JOIN \r\n    " +
                    "MayTinh ON ThietBi.MaThietBi = MayTinh.MaThietBi\r\nLEFT JOIN \r\n    " +
                    "MayTinh_PhanMem ON MayTinh.MaThietBi = MayTinh_PhanMem.MaThietBi\r\nLEFT JOIN \r\n   " +
                    " PhanMem PM ON MayTinh_PhanMem.MaPhanMem = PM.MaPhanMem;");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            */
        }

        private void dataGridView_ctpm_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView_ctpm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView_ctpm.Rows[e.RowIndex];
            if (dataGridView_ctpm.Rows.Count > 1)
            {
                txt_maphong.Text = Convert.ToString(row.Cells["Mã Phòng Học"].Value);
                txt_mamt.Text = Convert.ToString(row.Cells["Mã Thiết Bị"].Value);
                cb_tinhtrang.Text = Convert.ToString(row.Cells["Tình Trạng"].Value);
                txt_thongbao.Text = Convert.ToString(row.Cells["Thông Báo Giáo Viên"].Value);
                dateTimePicker_nv.Text = Convert.ToString(row.Cells["Ngày Cập Nhật Nhân Viên"].Value);
                dateTimePicker_gv.Text = Convert.ToString(row.Cells["Ngày Cập Nhật Giáo Viên"].Value);
                txt_pmcn.Text = Convert.ToString(row.Cells["Tên Phần Mềm"].Value);
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            string thietBiQuery = "UPDATE ThietBi SET MaPhongHoc = '" + txt_maphong.Text + "', TinhTrang = N'" + cb_tinhtrang.Text + "', NgayCapNhatNhanVien = '" + dateTimePicker_nv.Value.ToString("yyyy-MM-dd") + "', ThongBaoGiaoVien = N'" + txt_thongbao.Text + "', NgayCapNhatGiaoVien = '" + dateTimePicker_gv.Value.ToString("yyyy-MM-dd") + "' WHERE MaThietBi = '" + txt_mamt.Text + "'";

            try
            {
                // Hiển thị hộp thoại xác nhận trước khi sửa
                if (MessageBox.Show("Bạn có muốn sửa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Thực hiện câu lệnh UPDATE
                    modify.Command(thietBiQuery);
                    MessageBox.Show("Sửa thành công!");

                    // Tải lại dữ liệu sau khi sửa
                    ChiTietPhanMem_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có vấn đề xảy ra
                MessageBox.Show("Lỗi sửa: " + ex.Message);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO ThietBi (MaThietBi, MaPhongHoc, TinhTrang, NgayCapNhatNhanVien, ThongBaoGiaoVien, NgayCapNhatGiaoVien) " +
                "VALUES ('" + txt_mamt.Text + "', N'" + txt_maphong.Text + "', N'" + cb_tinhtrang.Text + "', '" + dateTimePicker_nv.Value.ToString("yyyy-MM-dd") + "', N'" + txt_thongbao.Text + "', '" + dateTimePicker_gv.Value.ToString("yyyy-MM-dd") + "')";

            try
            {
                // Hiển thị hộp thoại xác nhận trước khi sửa
                if (MessageBox.Show("Bạn có muốn thêm không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Thực hiện câu lệnh UPDATE
                    modify.Command(query);
                    MessageBox.Show("Thêm thành công!");

                    // Tải lại dữ liệu sau khi sửa
                    ChiTietPhanMem_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có vấn đề xảy ra
                MessageBox.Show("Lỗi thêm: " + ex.Message);
            }

            string countID_PM = "SELECT COUNT(MaPhanMem) FROM PHANMEM";
            int count = 0;

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand command = new SqlCommand(countID_PM, connection))
                    {
                        count = (int)command.ExecuteScalar();
                        connection.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
            int newId = ++count;
            string queryPhanMem = "INSERT INTO PHANMEM (MaPhanMem, TenPhanMem) VALUES ('" + newId.ToString() + "', '" + txt_newSoft.Text + "')";
            try
            {
                modify.Command(queryPhanMem);
                MessageBox.Show("Thêm phần mềm mới thành công");
                ChiTietPhanMem_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView_ctpm.Rows.Count > 1)
            {
                // Check if any row is selected
                if (dataGridView_ctpm.SelectedRows.Count > 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dataGridView_ctpm.SelectedRows[0];

                    // Get the value from a specific cell in the selected row
                    string choose = selectedRow.Cells["Mã Thiết Bị"].Value.ToString();

                    // Confirm deletion
                    DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            // Construct the DELETE query
                            string query = "DELETE FROM ThietBi WHERE MaThietBi = '" + choose + "'";

                            // Execute the query
                            modify.Command(query);

                            // Show success message
                            MessageBox.Show("Xóa thành công!");

                            // Reload the DataGridView
                            ChiTietPhanMem_Load(sender, e);
                        }
                        catch (Exception ex)
                        {
                            // Show error message
                            MessageBox.Show("Lỗi xóa: " + ex.Message);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn một hàng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Xóa dữ liệu cũ trong DataGridView
            dataGridView_ctpm.Rows.Clear();

            try
            {
                // Lấy mã phòng học được chọn từ ComboBox
                string maPhongHoc = comboBox1.SelectedItem.ToString();

                // Thực hiện truy vấn SQL để lấy thông tin từ bảng ThietBi
                string query = @"SELECT PhongHoc.MaPhongHoc AS 'Mã Phòng Học',
                            ThietBi.MaThietBi AS 'Mã Thiết Bị',
                            ThietBi.TinhTrang AS 'Tình Trạng',
                            ThietBi.NgayCapNhatNhanVien AS 'Ngày Cập Nhật Nhân Viên',
                            ThietBi.ThongBaoGiaoVien AS 'Thông Báo Giáo Viên',
                            ThietBi.NgayCapNhatGiaoVien AS 'Ngày Cập Nhật Giáo Viên',
                            PM.TenPhanMem AS 'Tên Phần Mềm'
                     FROM PhongHoc
                     JOIN ThietBi ON PhongHoc.MaPhongHoc = ThietBi.MaPhongHoc
                     LEFT JOIN MayTinh ON ThietBi.MaThietBi = MayTinh.MaThietBi
                     LEFT JOIN MayTinh_PhanMem ON MayTinh.MaThietBi = MayTinh_PhanMem.MaThietBi
                     LEFT JOIN PhanMem PM ON MayTinh_PhanMem.MaPhanMem = PM.MaPhanMem
                     WHERE PhongHoc.MaPhongHoc = @MaPhongHoc AND ThietBi.TinhTrang <> 'Hoạt động'";

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
                    if (dataGridView_ctpm.Columns.Count == 0)
                    {
                        dataGridView_ctpm.Columns.Add("TenThietBi", "Tên Thiết Bị");
                        dataGridView_ctpm.Columns.Add("TinhTrang", "Tình Trạng");
                        dataGridView_ctpm.Columns.Add("NgayCapNhatNhanVien", "Ngày Cập Nhật Nhân Viên");
                        dataGridView_ctpm.Columns.Add("ThongBaoGiaoVien", "Thông Báo Giáo Viên");
                        dataGridView_ctpm.Columns.Add("NgayCapNhatGiaoVien", "Ngày Cập Nhật Giáo Viên");
                        dataGridView_ctpm.Columns.Add("TenPhanMem", "Tên Phần Mềm");
                    }

                    while (reader.Read())
                    {
                        string tenThietBi = reader["Mã Phòng Học"].ToString();
                        string tinhTrang = reader["Mã Thiết Bị"].ToString();
                        string ngayCapNhatNhanVien = reader["Tình Trạng"].ToString();
                        string thongBaoGiaoVien = reader["Ngày Cập Nhật Nhân Viên"].ToString();
                        string ngayCapNhatGiaoVien = reader["Thông Báo Giáo Viên"].ToString();
                        string tenPhanMem = reader["Tên Phần Mềm"].ToString();

                        dataGridView_ctpm.Rows.Add(tenThietBi, tinhTrang, ngayCapNhatNhanVien, thongBaoGiaoVien, ngayCapNhatGiaoVien, tenPhanMem);
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
