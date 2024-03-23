using Form_DangNhap_Dangky_QMK;
using ManHinhChinh.XuLy;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class ChiTietThietBi_Form : Form
    {
        public ChiTietThietBi_Form()
        {
            InitializeComponent();
            LoadComboBoxData();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        Modify modify = new Modify();
        QuanLyThietBi quanLy;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                /*SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-MMG40OU\HUUHUY;Initial Catalog=QLTHIETBI;Integrated Security=True;");
                SqlCommand cmd = new SqlCommand("Select MaThietBi from ThietBi", connection);
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                cb_id.DataSource = dt;
                cb_id.ValueMember = "MaThietBi";*/
                //dataGridView1.DataSource = modify.Table("Select * from ThietBi");
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
            if (txt_tentb.Text != "" && txt_maphong.Text != "" && txt_tentb.Text != "")
            {
                MessageBox.Show("Mời bạn nhập thông tin");
                return false;
            }
            return true;
        }

        private void LoadComboBoxData()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
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
            string maPhongHoc = txt_maphong.Text;
            string tinhTrang = cb_tinhtrang.Text;
            DateTime ngayCapNhatNhanVien = dateTimePicker_nv.Value;
            string formatNgayNV = ngayCapNhatNhanVien.ToString("yyyy-MM-dd");
            string thongBao = txt_thongbao.Text;
            DateTime ngayCapNhatGiaoVien = dateTimePicker_gv.Value;
            string formatNgayGV = ngayCapNhatGiaoVien.ToString("yyyy-MM-dd");
            quanLy = new QuanLyThietBi(maThietBi, tenThietBi, maPhongHoc, tinhTrang, formatNgayNV, thongBao, formatNgayGV);

        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            GetValuesTextBoxes();
            string query = "INSERT INTO ThietBi Values ('" + quanLy.MaThietBi + "', N'" + quanLy.TenThietBi + "', '" + quanLy.MaPhongHoc + "', N'" + quanLy.TinhTrang + "', '" + quanLy.NgayCapNhatNV + "', N'" + quanLy.ThongBao + "', '" + quanLy.NgayCapNhatGV + "')";
            try
            {
                modify.Command(query);
                MessageBox.Show("Thêm thành công!");
                Form1_Load(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm:" + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row = dataGridView1.Rows[e.RowIndex];
            if (dataGridView1.Rows.Count > 1)
            {
                txt_matb.Text = Convert.ToString(row.Cells["MaThietBi"].Value);
                txt_tentb.Text = Convert.ToString(row.Cells["TenThietBi"].Value);
                txt_maphong.Text = Convert.ToString(row.Cells["MaPhongHoc"].Value);
                cb_tinhtrang.Text = Convert.ToString(row.Cells["TinhTrang"].Value);
                txt_thongbao.Text = Convert.ToString(row.Cells["ThongBaoGiaoVien"].Value);
                dateTimePicker_nv.Text = Convert.ToString(row.Cells["NgayCapNhatNhanVien"].Value);
                dateTimePicker_gv.Text = Convert.ToString(row.Cells["NgayCapNhatGiaoVien"].Value);
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

                    // Tải lại dữ liệu sau khi sửa
                    Form1_Load(sender, e);
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi nếu có vấn đề xảy ra
                MessageBox.Show("Lỗi sửa: " + ex.Message);
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 1)
            {
                // Check if any row is selected
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    // Get the selected row
                    DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                    // Get the value from a specific cell in the selected row
                    string choose = selectedRow.Cells["MaThietBi"].Value.ToString();

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
                            Form1_Load(sender, e);
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
            dataGridView1.Rows.Clear();

            try
            {
                // Lấy mã phòng học được chọn từ ComboBox
                string maPhongHoc = comboBox1.SelectedItem.ToString();

                // Thực hiện truy vấn SQL để lấy thông tin từ bảng ThietBi
                string query = @"SELECT MaThietBi, TenThietBi, TinhTrang, NgayCapNhatNhanVien, ThongBaoGiaoVien, NgayCapNhatGiaoVien
                         FROM ThietBi
                         WHERE MaPhongHoc = @MaPhongHoc AND TinhTrang <> 'Hoạt động'";

                // Mở kết nối
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
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

                        dataGridView1.Rows.Add(tenThietBi, tinhTrang, ngayCapNhatNhanVien, thongBaoGiaoVien, ngayCapNhatGiaoVien);
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
