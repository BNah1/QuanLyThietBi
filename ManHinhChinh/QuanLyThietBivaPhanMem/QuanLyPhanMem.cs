using Form_DangNhap_Dangky_QMK;
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

namespace ManHinhChinh.QuanLyThietBivaPhanMem
{

    public partial class QuanLyPhanMem : Form
    {
        public QuanLyPhanMem()
        {
            InitializeComponent();
            LoadComboBoxData();
            LoadComboBox_pmNew();
        }
        // Lấy giá trị của DangNhap.loaiTaiKhoan
        string loaiTaiKhoan = DangNhap.loaiTaiKhoan;

        // Lấy ngày hiện tại
        DateTime ngayCapNhat = DateTime.Now;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            string maPhongDuocChon = cb_idphong.SelectedItem.ToString();
            txt_maphong.Text = maPhongDuocChon; // Tự động điền mã phòng học vào txt_maphong
            LoadData();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.RowIndex < dataGridView2.Rows.Count)
            {
                // Lấy giá trị của ô được chọn
                DataGridViewRow selectedRow = dataGridView2.Rows[e.RowIndex];
                string selectedTenPhanMem = selectedRow.Cells["TenPhanMem"].Value.ToString();
                string selectedPhienBan = selectedRow.Cells["PhienBan"].Value.ToString();
                string selectedMaPhanMem = selectedRow.Cells["MaPhanMem"].Value.ToString();

                // Điền giá trị vào các ô văn bản tương ứng
                txt_pm.Text = selectedTenPhanMem;
                txtpb.Text = selectedPhienBan;
                txtmapm.Text = selectedMaPhanMem;
            }
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
        private void LoadData()
        {
            dataGridView1.Rows.Clear();
            string maPhongHoc = txt_maphong.Text;
            try
            {
                // Truy vấn SQL để lấy thông tin từ bảng ThietBi và MayTinh dựa trên ID phòng đã chọn
                string query = @"SELECT ThietBi.MaThietBi, ThietBi.TenThietBi, ThietBi.MaPhongHoc, ThietBi.TinhTrang, ThietBi.NgayCapNhatNhanVien, ThietBi.ThongBaoGiaoVien, ThietBi.NgayCapNhatGiaoVien
             FROM ThietBi
             JOIN MayTinh ON ThietBi.MaThietBi = MayTinh.MaThietBi
             WHERE ThietBi.MaPhongHoc = @MaPhongHoc ";

                // Mở kết nối
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
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
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count)
            {
                // Get the values from the selected row
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                string maThietBi = row.Cells["MaThietBi"].Value?.ToString() ?? string.Empty;
                string tenThietBi = row.Cells["TenThietBi"].Value?.ToString() ?? string.Empty;
                string maPhongHoc = row.Cells["MaPhongHoc"].Value?.ToString() ?? string.Empty;
                string tinhTrang = row.Cells["TinhTrang"].Value?.ToString() ?? string.Empty;
                string thongBao = row.Cells["ThongBaoGiaoVien"].Value?.ToString() ?? string.Empty;
                string ngayCapNhatNV = row.Cells["NgayCapNhatNhanVien"].Value?.ToString() ?? string.Empty;
                string ngayCapNhatGV = row.Cells["NgayCapNhatGiaoVien"].Value?.ToString() ?? string.Empty;

                // Fill the corresponding controls with the values
                txt_matb.Text = maThietBi;
                txt_tentb.Text = tenThietBi;
                cb_idphong.Text = maPhongHoc;
                cb_tinhtrang.SelectedItem = tinhTrang;
                txt_thongbao.Text = thongBao;
                dateTimePicker_nv.Text = ngayCapNhatNV;
                dateTimePicker_gv.Text = ngayCapNhatGV;
                txt_matb_TextChanged(sender, e);
            }
        }
        private void LoadData2()
        {
            string MaThietBi = txt_matb.Text;

            try
            {
                // Thiết lập kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    // Truy vấn để lấy dữ liệu từ bảng MayTinh_PhanMem
                    string selectQuery = "SELECT MayTinh_PhanMem.MaThietBi, MayTinh_PhanMem.MaPhanMem, PhanMem.TenPhanMem, MayTinh_PhanMem.PhienBan " +
                     "FROM MayTinh_PhanMem " +
                     "JOIN PhanMem ON MayTinh_PhanMem.MaPhanMem = PhanMem.MaPhanMem " +
                     "WHERE MayTinh_PhanMem.MaThietBi = @MaThietBi";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(selectQuery, connection);
                    dataAdapter.SelectCommand.Parameters.AddWithValue("@MaThietBi", MaThietBi);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView2.DataSource = dataTable;

                    // Đóng kết nối
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LoadData2();
        }
        private void txt_matb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_matb.Text))
            {
                // Nếu txt_matb không có dữ liệu, không thực hiện gì
                return;
            }

            string MaThietBi = txt_matb.Text;

            try
            {
                // Thiết lập kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    // Kiểm tra xem MaThietBi có tồn tại trong cơ sở dữ liệu hay không
                    string checkExistQuery = "SELECT COUNT(*) FROM MayTinh WHERE MaThietBi = @MaThietBi";
                    using (SqlCommand command = new SqlCommand(checkExistQuery, connection))
                    {
                        command.Parameters.AddWithValue("@MaThietBi", MaThietBi);
                        int count = (int)command.ExecuteScalar();

                        if (count == 0)
                        {
                            // Nếu MaThietBi không tồn tại, hiển thị thông báo
                            MessageBox.Show("Loading....");
                        }
                        else
                        {
                            // MaThietBi tồn tại, thực hiện LoadData2()
                            LoadData2();
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

        private void QuanLyPhanMem_Load(object sender, EventArgs e)
        {

        }

        private void LoadComboBox_pmNew()
        {
            try
            {
                // Thiết lập kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    // Truy vấn để lấy danh sách các tên phần mềm từ bảng PhanMem
                    string query = "SELECT TenPhanMem FROM PhanMem";
                    SqlCommand command = new SqlCommand(query, connection);

                    // Thực thi truy vấn và đọc kết quả
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        // Xóa tất cả các mục cũ trong comboBox_pmNew trước khi thêm các mục mới
                        comboBox_pmNew.Items.Clear();

                        // Duyệt qua các dòng dữ liệu và thêm tên phần mềm vào comboBox_pmNew
                        while (reader.Read())
                        {
                            string tenPhanMem = reader.GetString(0); // Lấy tên phần mềm từ cột đầu tiên
                            comboBox_pmNew.Items.Add(tenPhanMem);
                        }
                    }

                    // Đóng kết nối
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void button_Them_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra nếu là giáo viên
                if (loaiTaiKhoan == "GiaoVien")
                {
                    string thongBao = "Muon them phan mem " + comboBox_pmNew.Text;
                    DateTime ngayCapNhat = DateTime.Now;
                    string tinhTrang = "Đang cập nhật";

                    using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                    {
                        connection.Open();

                        string updateQuery = "UPDATE ThietBi SET ThongBaoGiaoVien = @thongBao, NgayCapNhatGiaoVien = @ngayCapNhat, TinhTrang = @tinhTrang WHERE MaThietBi = @maThietBi";
                        SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                        updateCommand.Parameters.AddWithValue("@thongBao", thongBao);
                        updateCommand.Parameters.AddWithValue("@maThietBi", txt_matb.Text);
                        updateCommand.Parameters.AddWithValue("@ngayCapNhat", ngayCapNhat);
                        updateCommand.Parameters.AddWithValue("@tinhTrang", tinhTrang);

                        updateCommand.ExecuteNonQuery();

                        MessageBox.Show("Thông báo thành công");

                        connection.Close();
                    }
                }
                else
                {
                    string tinhTrang = "Hoạt động";
                    string tenPhanMem = comboBox_pmNew.Text;

                    using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                    {
                        connection.Open();

                        string checkQuery = "SELECT COUNT(*) FROM PhanMem";
                        SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                        checkCommand.Parameters.AddWithValue("@tenPhanMem", tenPhanMem);
                        int existingCount = (int)checkCommand.ExecuteScalar();

                        string currentMaPhanMem = "PM" + (existingCount + 1);

                        string insertQuery = "INSERT INTO PhanMem (MaPhanMem, TenPhanMem) VALUES (@maPhanMem, @tenPhanMem)";
                        SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                        insertCommand.Parameters.AddWithValue("@maPhanMem", currentMaPhanMem);
                        insertCommand.Parameters.AddWithValue("@tenPhanMem", tenPhanMem);
                        insertCommand.ExecuteNonQuery();

                        string insertMayTinhPhanMemQuery = @"
                        INSERT INTO MayTinh_PhanMem (MaThietBi, MaPhanMem, PhienBan)
                        VALUES (@maThietBi, @maPhanMem, @phienBan);
                    ";
                        SqlCommand insertMayTinhPhanMemCommand = new SqlCommand(insertMayTinhPhanMemQuery, connection);
                        insertMayTinhPhanMemCommand.Parameters.AddWithValue("@maThietBi", txt_matb.Text);
                        insertMayTinhPhanMemCommand.Parameters.AddWithValue("@maPhanMem", currentMaPhanMem);
                        insertMayTinhPhanMemCommand.Parameters.AddWithValue("@phienBan", txtpbNew.Text);
                        insertMayTinhPhanMemCommand.ExecuteNonQuery();

                        DateTime ngayCapNhat = DateTime.Now;
                        string updateNgayCapNhatQuery = "UPDATE ThietBi SET NgayCapNhatNhanVien = @ngayCapNhat, TinhTrang = @tinhTrang WHERE MaThietBi = @maThietBi";
                        SqlCommand updateNgayCapNhatCommand = new SqlCommand(updateNgayCapNhatQuery, connection);
                        updateNgayCapNhatCommand.Parameters.AddWithValue("@ngayCapNhat", ngayCapNhat);
                        updateNgayCapNhatCommand.Parameters.AddWithValue("@maThietBi", txt_matb.Text);
                        updateNgayCapNhatCommand.Parameters.AddWithValue("@tinhTrang", tinhTrang);
                        updateNgayCapNhatCommand.ExecuteNonQuery();
                        MessageBox.Show("Thêm thành công");
                        
                        connection.Close();
                    }
                }
                LoadData2();
                LoadData();
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
                if (loaiTaiKhoan == "GiaoVien")
                {
                    string tenPhanMem = txt_pm.Text;
                    string phienBan = txtpb.Text;
                    string thongBao = "Cập nhật " + tenPhanMem + " với phiên bản " + phienBan;
                    string maThietBi = txt_matb.Text;
                    string tinhTrang = "Đang cập nhật";
                    // Thiết lập kết nối đến cơ sở dữ liệu
                    using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                    {
                        connection.Open();

                        // Thêm thông báo vào ThongBaoGiaoVien của bảng ThietBi
                        string insertThongBaoQuery = "UPDATE ThietBi SET ThongBaoGiaoVien = @thongBao, TinhTrang = @tinhTrang  WHERE MaThietBi = @maThietBi";
                        SqlCommand insertThongBaoCommand = new SqlCommand(insertThongBaoQuery, connection);
                        insertThongBaoCommand.Parameters.AddWithValue("@thongBao", thongBao);
                        insertThongBaoCommand.Parameters.AddWithValue("@maThietBi", maThietBi);
                        insertThongBaoCommand.Parameters.AddWithValue("@tinhTrang", tinhTrang);
                        insertThongBaoCommand.ExecuteNonQuery();

                        // Cập nhật ngày hiện tại cho NgayCapNhatGiaoVien trong bảng ThietBi
                        string updateNgayCapNhatQuery = "UPDATE ThietBi SET NgayCapNhatGiaoVien = @ngayCapNhat WHERE MaThietBi = @maThietBi";

                        // Tạo và thực thi command SQL
                        SqlCommand updateNgayCapNhatCommand = new SqlCommand(updateNgayCapNhatQuery, connection);
                        updateNgayCapNhatCommand.Parameters.AddWithValue("@ngayCapNhat", ngayCapNhat);
                        updateNgayCapNhatCommand.Parameters.AddWithValue("@maThietBi", maThietBi);
                        updateNgayCapNhatCommand.ExecuteNonQuery();


                        // Đóng kết nối
                        connection.Close();

                    }
                }
                else
                {
                    string maThietBi = txt_matb.Text;
                    string maPhanMem = txtmapm.Text;
                    string phienBan = txtpb.Text;
                    string tinhTrang = "Hoạt động";
                    // Thiết lập kết nối đến cơ sở dữ liệu
                    using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                    {
                        connection.Open();

                        // Kiểm tra xem MaThietBi và MaPhanMem đã tồn tại trong bảng MayTinh_PhanMem hay chưa
                        string checkQuery = "SELECT COUNT(*) FROM MayTinh_PhanMem WHERE MaThietBi = @maThietBi AND MaPhanMem = @maPhanMem";
                        SqlCommand checkCommand = new SqlCommand(checkQuery, connection);
                        checkCommand.Parameters.AddWithValue("@maThietBi", maThietBi);
                        checkCommand.Parameters.AddWithValue("@maPhanMem", maPhanMem);
                        int existingCount = (int)checkCommand.ExecuteScalar();

                        // Cập nhật PhienBan trong bảng MayTinh_PhanMem
                        string updateQuery = "UPDATE MayTinh_PhanMem SET PhienBan = @phienBan WHERE MaThietBi = @maThietBi AND MaPhanMem = @maPhanMem";
                        SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                        updateCommand.Parameters.AddWithValue("@phienBan", phienBan);
                        updateCommand.Parameters.AddWithValue("@maThietBi", maThietBi);
                        updateCommand.Parameters.AddWithValue("@maPhanMem", maPhanMem);
                        updateCommand.ExecuteNonQuery();

                        // Cập nhật ngày hiện tại cho NgayCapNhatGiaoVien trong bảng ThietBi
                        string updateNgayCapNhatQuery = "UPDATE ThietBi SET NgayCapNhatNhanVien = @ngayCapNhat, TinhTrang = @tinhTrang  WHERE MaThietBi = @maThietBi";
                        // Tạo và thực thi command SQL
                        SqlCommand updateNgayCapNhatCommand = new SqlCommand(updateNgayCapNhatQuery, connection);
                        updateNgayCapNhatCommand.Parameters.AddWithValue("@ngayCapNhat", ngayCapNhat);
                        updateNgayCapNhatCommand.Parameters.AddWithValue("@maThietBi", txt_matb.Text);
                        updateNgayCapNhatCommand.Parameters.AddWithValue("@tinhTrang", tinhTrang);
                        updateNgayCapNhatCommand.ExecuteNonQuery();

                        // Đóng kết nối
                        connection.Close();
                    }
                }
                LoadData2();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button_Xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (loaiTaiKhoan != "GiaoVien")
                {
                    // Tạo câu truy vấn xoá dữ liệu từ bảng MayTinh_PhanMem và PhanMem
                    string deleteQuery = @"
                DELETE FROM MayTinh_PhanMem WHERE MaPhanMem = @maPhanMem;";

                    // Thiết lập kết nối đến cơ sở dữ liệu
                    using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                    {
                        connection.Open();

                        // Tạo và thực thi command SQL
                        using (SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection))
                        {
                            deleteCommand.Parameters.AddWithValue("@maPhanMem", txtmapm.Text);
                            deleteCommand.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Xoá phần mềm thành công!");
                }
                else
                {
                    MessageBox.Show("Lỗi: Loại tài khoản không hợp lệ.");
                }
                LoadData2();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void button_Them_MouseHover(object sender, EventArgs e)
        {
            Button button_Them = (Button)sender;
            button_Them.BackColor = Color.White;
        }

        private void button_Sua_MouseHover(object sender, EventArgs e)
        {
            Button button_Sua = (Button)sender;
            button_Sua.BackColor = Color.White;
        }

        private void button_Them_MouseLeave(object sender, EventArgs e)
        {
            Button button_Them = (Button)sender;
            button_Them.BackColor = Color.Green;
        }

        private void button_Xoa_MouseHover(object sender, EventArgs e)
        {
            Button button_Xoa = (Button)sender;
            button_Xoa.BackColor = Color.White;
        }

        private void button_Xoa_MouseLeave(object sender, EventArgs e)
        {
            Button button_Xoa = (Button)sender;
            button_Xoa.BackColor = Color.Red;
        }

        private void button_Sua_MouseLeave(object sender, EventArgs e)
        {
            Button button_Sua = (Button)sender;
            button_Sua .BackColor = Color.Green;
        }
    }
}
