    using Form_DangNhap_Dangky_QMK;
    using ManHinhChinh.XuLy;
    using System.Data.SqlClient;
    using System.Windows.Forms;
    using System.Timers;
    using Timer = System.Windows.Forms.Timer;
    using static System.Windows.Forms.VisualStyles.VisualStyleElement;

    namespace WinFormsApp1
    {
    public partial class ChiTietThietBi_Form : Form
    {
        private Timer timer;
        public static string connectionString = Connection.stringConnection;
        public ChiTietThietBi_Form()
        {

            InitializeComponent();
            LoadComboBoxData();
            this.Activated += new EventHandler(ChiTietThietBi_Form_Activated);
            if (DangNhap.loaiTaiKhoan == "GiaoVien")
            {
                txt_matb.ReadOnly = true;
                txt_tentb.ReadOnly = true;
                txt_maphong.ReadOnly = true;

            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        Modify modify = new Modify();
        QuanLyThietBi quanLy;

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.ForeColor = Color.Black;
            try
            {
                LoadComboBoxData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi" + ex.Message);
            }
            DeleteTextBoxes();
        }

        private void cb_id_SelectedIndexChanged(object sender, EventArgs e)
        {


        }


        private bool CheckTextBox()
        {
            if (string.IsNullOrWhiteSpace(txt_tentb.Text) || string.IsNullOrWhiteSpace(txt_maphong.Text) || string.IsNullOrWhiteSpace(cb_tinhtrang.Text))
            {
                MessageBox.Show("Mời bạn nhập đầy đủ thông tin");
                return false;
            }
            return true;
        }


        private void LoadComboBoxData()
        {
            try
            {
                // Mở kết nối
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    // Kiểm tra loại tài khoản để xây dựng câu truy vấn phù hợp
                    string query;
                    if (DangNhap.loaiTaiKhoan == "NhanVien")
                    {
                        // Truy vấn để lấy danh sách MaPhongHoc dựa trên quyền truy cập của Nhân viên
                        query = @"SELECT DISTINCT PhongHoc.MaPhongHoc, PhongHoc.TenPhongHoc
                        FROM PhongHoc
                        JOIN Tang ON PhongHoc.MaTang = Tang.MaTang
                        JOIN ToaNha ON Tang.MaToaNha = ToaNha.MaToaNha
                        JOIN QuyenTruyCapNV ON ToaNha.MaToaNha = QuyenTruyCapNV.MaToaNha
                        WHERE QuyenTruyCapNV.TenTaiKhoan = @TenDangNhap;";
                        this.dateTimePicker_gv.Enabled = false;
                    }
                    else if (DangNhap.loaiTaiKhoan == "GiaoVien")
                    {
                        // Truy vấn để lấy danh sách MaPhongHoc dựa trên quyền truy cập của Giáo viên
                        query = @"SELECT DISTINCT PhongHoc.MaPhongHoc, PhongHoc.TenPhongHoc
                        FROM PhongHoc
                        JOIN QuyenTruyCapGV ON PhongHoc.MaPhongHoc = QuyenTruyCapGV.MaPhongHoc
                        WHERE QuyenTruyCapGV.TenTaiKhoan = @TenDangNhap;";
                        this.dateTimePicker_nv.Enabled = false;
                    }
                    else
                    {
                        query = "SELECT MaPhongHoc FROM PhongHoc";
                    }

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TenDangNhap", DangNhap.TenDangNhap);
                    SqlDataReader reader = command.ExecuteReader();

                    // Xóa danh sách mục ComboBox trước khi thêm dữ liệu
                    cb_idphong.Items.Clear();

                    // Đổ dữ liệu vào ComboBox
                    while (reader.Read())
                    {
                        cb_idphong.Items.Add(reader["MaPhongHoc"].ToString());
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

        private void DeleteTextBoxes()
        {
            txt_matb.Text = "";
            txt_tentb.Text = "";
            txt_maphong.Text = "";
            txt_thongbao.Text = "";
            cb_tinhtrang.SelectedIndex = -1;
        }

        private void GetValuesTextBoxes()
        {
            string maThietBi = txt_matb.Text;
            string tenThietBi = txt_tentb.Text;
            string maPhongHoc = cb_idphong.Text;
            string tinhTrang = cb_tinhtrang.Text;
            DateTime ngayCapNhatNhanVien = dateTimePicker_nv.Value;
            string formatNgayNV = ngayCapNhatNhanVien.ToString("yyyy-MM-dd");
            string thongBao = txt_thongbao.Text;
            DateTime ngayCapNhatGiaoVien = dateTimePicker_gv.Value;
            string formatNgayGV = ngayCapNhatGiaoVien.ToString("yyyy-MM-dd");
            quanLy = new QuanLyThietBi(maThietBi, tenThietBi, maPhongHoc, tinhTrang, formatNgayNV, thongBao, formatNgayGV);

        }




        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                // Lấy giá trị từ ô trong dòng được chọn
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string maThietBi = row.Cells["MaThietBi"].Value?.ToString() ?? string.Empty;
                string tenThietBi = row.Cells["TenThietBi"].Value?.ToString() ?? string.Empty;
                string maPhongHoc = row.Cells["MaPhongHoc"].Value?.ToString() ?? string.Empty;
                string tinhTrang = row.Cells["TinhTrang"].Value?.ToString() ?? string.Empty;
                string thongBao = row.Cells["ThongBaoGiaoVien"].Value?.ToString() ?? string.Empty;
                string ngayCapNhatNV = row.Cells["NgayCapNhatNhanVien"].Value?.ToString() ?? string.Empty;
                string ngayCapNhatGV = row.Cells["NgayCapNhatGiaoVien"].Value?.ToString() ?? string.Empty;

                // Điền giá trị vào các điều khiển tương ứng
                txt_matb.Text = maThietBi;
                txt_tentb.Text = tenThietBi;
                cb_idphong.Text = maPhongHoc;
                cb_tinhtrang.SelectedItem = tinhTrang;
                txt_thongbao.Text = thongBao;
                dateTimePicker_nv.Text = ngayCapNhatNV;
                dateTimePicker_gv.Text = ngayCapNhatGV;
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            GetValuesTextBoxes();
            // Tạo câu lệnh UPDATE
            string query = "UPDATE ThietBi SET TenThietBi = N'" + quanLy.TenThietBi + "', MaPhongHoc = '" + quanLy.MaPhongHoc + "', TinhTrang = N'" + quanLy.TinhTrang + "', NgayCapNhatNhanVien = '" + quanLy.NgayCapNhatNV + "', ThongBaoGiaoVien = N'" + quanLy.ThongBao + "', NgayCapNhatGiaoVien = '" + quanLy.NgayCapNhatGV + "' WHERE MaThietBi = '" + quanLy.MaThietBi + "'";

            try
            {
                // Hiển thị hộp thoại xác nhận trước khi sửa
                if (MessageBox.Show("Bạn có muốn sửa không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Thực hiện câu lệnh UPDATE
                    modify.Command(query);
                    MessageBox.Show("Sửa thành công!");
                    // Xóa tất cả các hàng dữ liệu hiện có trong DataGridView
                    dataGridView1.Rows.Clear();

                    // Lấy giá trị được chọn từ text
                    string maPhongHoc = txt_maphong.Text;

                    // Xóa tất cả các hàng dữ liệu hiện có trong DataGridView
                    dataGridView1.Rows.Clear();

                    // Tải dữ liệu mới vào DataGridView
                    dataLoad();
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
            GetValuesTextBoxes();
            string query = "INSERT INTO ThietBi Values ('" + quanLy.MaThietBi + "', N'" + quanLy.TenThietBi + "', '" + quanLy.MaPhongHoc + "', N'" + quanLy.TinhTrang + "', '" + quanLy.NgayCapNhatNV + "', N'" + quanLy.ThongBao + "', '" + quanLy.NgayCapNhatGV + "')";
            try
            {
                modify.Command(query);
                MessageBox.Show("Thêm thành công!");
                // Xóa tất cả các hàng dữ liệu hiện có trong DataGridView
                dataGridView1.Rows.Clear();

                // Lấy giá trị được chọn từ text
                string maPhongHoc = txt_maphong.Text;

                // Xóa tất cả các hàng dữ liệu hiện có trong DataGridView
                dataGridView1.Rows.Clear();

                // Tải dữ liệu mới vào DataGridView
                dataLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm:" + ex.Message);
            }
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            try
            {
                if(DangNhap.loaiTaiKhoan != "GiaoVien") { 
                // Lấy hàng đã chọn
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                // Kiểm tra xem ô dữ liệu có giá trị không
                if (selectedRow.Cells["MaThietBi"].Value != null)
                {
                    // Lấy giá trị của cột "MaThietBi" trong hàng đã chọn
                    string maThietBi = Convert.ToString(selectedRow.Cells["MaThietBi"].Value);

                    try
                    {
                        // Thực hiện câu lệnh xóa
                        string query = "BEGIN TRANSACTION;\r\n\r\n" +
                                       "DELETE FROM MayTinh_PhanMem\r\n" +
                                       "WHERE MaThietBi = '" + maThietBi + "';\r\n\r\n" +
                                       "DELETE FROM MayTinh\r\n" +
                                       "WHERE MaThietBi = '" + maThietBi + "';\r\n\r\n" +
                                       "DELETE FROM ThietBi\r\n" +
                                       "WHERE MaThietBi = '" + maThietBi + "';\r\n\r\n" +
                                       "COMMIT;";

                        // Kiểm tra nếu query không rỗng
                        if (!string.IsNullOrEmpty(query))
                        {
                            // Thực hiện câu lệnh xóa
                            using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                            {
                                connection.Open();
                                SqlCommand command = new SqlCommand(query, connection);
                                command.ExecuteNonQuery();
                                connection.Close();
                            }

                            // Thông báo xóa thành công
                            MessageBox.Show("Xóa thành công");
                            // Xóa tất cả các hàng dữ liệu hiện có trong DataGridView
                            dataGridView1.Rows.Clear();

                            // Lấy giá trị được chọn từ text
                            string maPhongHoc = txt_maphong.Text;

                            // Tải dữ liệu mới vào DataGridView
                            dataLoad();
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }

                else
                {
                    // Hiển thị thông báo khi không có dữ liệu được chọn
                    MessageBox.Show("Vui lòng chọn một hàng để xóa");
                }
                }
                else
                    MessageBox.Show("Giáo viên không thể xoá thiết bị");
            }
            catch (Exception ex)
            {
                MessageBox.Show("vui lòng chọn hàng ");
            }
        }
        private void dataLoad()
        {
            dataGridView1.Rows.Clear();
            string maPhongHoc = txt_maphong.Text;
            try
            {
                // Truy vấn SQL để lấy thông tin từ bảng ThietBi dựa trên ID phòng đã chọn
                string query = @"SELECT MaThietBi, TenThietBi, MaPhongHoc, TinhTrang, NgayCapNhatNhanVien, ThongBaoGiaoVien, NgayCapNhatGiaoVien
                         FROM ThietBi
                         WHERE MaPhongHoc = @MaPhongHoc ";

                // Mở kết nối
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Tạo và thực thi SqlCommand
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MaPhongHoc", maPhongHoc);

                    // Đọc dữ liệu và hiển thị trên DataGridView
                    SqlDataReader reader = command.ExecuteReader();

                    // Thêm cột vào DataGridView nếu cần
                    if (dataGridView1.Columns.Count == 0)
                    {
                        dataGridView1.Columns.Add("MaThietBi", "Mã Thiết Bị");
                        dataGridView1.Columns.Add("TenThietBi", "Tên Thiết Bị");
                        dataGridView1.Columns.Add("MaPhongHoc", "Mã Phòng Học");
                        dataGridView1.Columns.Add("TinhTrang", "Tình Trạng");
                        dataGridView1.Columns.Add("NgayCapNhatNhanVien", "Ngày Cập Nhật Nhân Viên");
                        dataGridView1.Columns.Add("ThongBaoGiaoVien", "Thông Báo Giáo Viên");
                        dataGridView1.Columns.Add("NgayCapNhatGiaoVien", "Ngày Cập Nhật Giáo Viên");
                    }

                    while (reader.Read())
                    {
                        string maThietBi = reader["MaThietBi"].ToString();
                        string tenThietBi = reader["TenThietBi"].ToString();
                        string tinhTrang = reader["TinhTrang"].ToString();
                        string ngayCapNhatNhanVien = reader["NgayCapNhatNhanVien"].ToString();
                        string thongBaoGiaoVien = reader["ThongBaoGiaoVien"].ToString();
                        string ngayCapNhatGiaoVien = reader["NgayCapNhatGiaoVien"].ToString();

                        int rowIndex = dataGridView1.Rows.Add(maThietBi, tenThietBi, maPhongHoc, tinhTrang, ngayCapNhatNhanVien, thongBaoGiaoVien, ngayCapNhatGiaoVien);

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
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string maPhongDuocChon = cb_idphong.SelectedItem.ToString();
            txt_maphong.Text = maPhongDuocChon; // Tự động điền mã phòng học vào txt_maphong
            dataLoad();
        }
        private void ChiTietThietBi_Form_Activated(object sender, EventArgs e)
        {
            LoadComboBoxData();
        }

        private void ChiTietThietBi_Form_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                LoadComboBoxData();
            }
        }

        private void btn_add_MouseHover(object sender, EventArgs e)
        {
            btn_add.BackColor = Color.White;
        }

        private void btn_add_MouseLeave(object sender, EventArgs e)
        {
            btn_add.BackColor = Color.Aqua;
        }

        private void btn_edit_MouseHover(object sender, EventArgs e)
        {
            btn_edit.BackColor = Color.White;
        }

        private void btn_edit_MouseLeave(object sender, EventArgs e)
        {
            btn_edit.BackColor = Color.Green;
        }

        private void btn_delete_MouseHover(object sender, EventArgs e)
        {
            btn_delete.BackColor = Color.White;
        }

        private void btn_delete_MouseLeave(object sender, EventArgs e)
        {
            btn_delete.BackColor = Color.Red;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
