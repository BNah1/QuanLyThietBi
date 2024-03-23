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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp8
{
    public partial class YeuCauThietBi : Form
    {
        string connectionString = Connection.stringConnection;
        SqlConnection sqlConn;

        DataTable dataTable;
        int stt;
        public YeuCauThietBi()
        {
            InitializeComponent();
        }

        private void LoadRoomIDs()
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
                    cbPhong.Items.Clear();

                    while (reader.Read())
                    {
                        cbPhong.Items.Add(reader["MaPhongHoc"].ToString());
                    }

                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LoadPhanmem()
        {
            try
            {
                using (SqlConnection sqlConn = new SqlConnection(connectionString))
                {
                    sqlConn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT TenPhanMem FROM PhanMem", sqlConn);
                    SqlDataReader reader = cmd.ExecuteReader();


                    cbPhanmem.Items.Clear();


                    while (reader.Read())
                    {
                        cbPhanmem.Items.Add(reader["TenPhanMem"].ToString());
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void InitializeDataGridView()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("STT", typeof(int));
            dataTable.Columns.Add("Mã phòng", typeof(string));
            dataTable.Columns.Add("Phòng", typeof(string));
            dataTable.Columns.Add("Tên thiết bị", typeof(string));
            dataTable.Columns.Add("Phần mềm", typeof(string));
            dataTable.Columns.Add("CPU", typeof(string));
            dataTable.Columns.Add("RAM", typeof(string));
            dataTable.Columns.Add("Ổ cứng", typeof(string));


            dataGridView1.DataSource = dataTable;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            try
            {
                sqlConn = new SqlConnection(connectionString);
                sqlConn.Open();
                LoadRoomIDs();
                LoadPhanmem();
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (sqlConn != null && sqlConn.State == ConnectionState.Open)
                {

                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbPhong.Text) || string.IsNullOrWhiteSpace(cbThietBi.Text)
         || string.IsNullOrWhiteSpace(cbPhanmem.Text) || string.IsNullOrWhiteSpace(cbCPU.Text)
         || string.IsNullOrWhiteSpace(cbRam.Text) || string.IsNullOrWhiteSpace(cbOCung.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string phong = cbPhong.Text;
            string tenthietbi = cbThietBi.Text;
            string phanmem = cbPhanmem.Text;
            string CPU = cbCPU.Text;
            string RAM = cbRam.Text;
            string OCung = cbOCung.Text;
            string maPhongHoc;
            using (SqlConnection sqlConn = new SqlConnection(connectionString))
            {
                sqlConn.Open();
                string query = "SELECT MaPhongHoc FROM PhongHoc WHERE TenPhongHoc = @TenPhongHoc";
                SqlCommand cmd = new SqlCommand(query, sqlConn);
                cmd.Parameters.AddWithValue("@TenPhongHoc", phong);
                maPhongHoc = cmd.ExecuteScalar()?.ToString();
            }

            DataRow newRow = dataTable.NewRow();
            newRow["STT"] = dataTable.Rows.Count + 1;
            newRow["Mã phòng"] = maPhongHoc;
            newRow["Phòng"] = phong;
            newRow["Tên thiết bị"] = tenthietbi;
            newRow["Phần mềm"] = phanmem;
            newRow["CPU"] = CPU;
            newRow["RAM"] = RAM;
            newRow["Ổ cứng"] = OCung;



            dataTable.Rows.Add(newRow);


            cbPhong.Text = "";
            cbPhanmem.Text = "";
            cbCPU.Text = "";
            cbRam.Text = "";
            cbOCung.Text = "";
            cbThietBi.Text = "";

            cbPhanmem.Enabled = true;
            cbCPU.Enabled = true;
            cbRam.Enabled = true;
            cbOCung.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                selectedRow.Cells["Phòng"].Value = cbPhong.SelectedItem.ToString();
                selectedRow.Cells["Tên thiết bị"].Value = cbThietBi.SelectedItem.ToString();
                selectedRow.Cells["Phần mềm"].Value = cbPhanmem.SelectedItem.ToString();
                selectedRow.Cells["CPU"].Value = cbCPU.SelectedItem.ToString();
                selectedRow.Cells["RAM"].Value = cbRam.SelectedItem.ToString();
                selectedRow.Cells["Ổ cứng"].Value = cbRam.SelectedItem.ToString();

            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];


                DataRowView selectedDataRowView = selectedRow.DataBoundItem as DataRowView;

                if (selectedDataRowView != null)
                {

                    DataRow selectedDataRow = selectedDataRowView.Row;


                    DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?", "Xác nhận Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (result == DialogResult.Yes)
                    {

                        dataTable.Rows.Remove(selectedDataRow);
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.");
            }
            int counter = 1;
            foreach (DataRow row in dataTable.Rows)
            {
                row["STT"] = counter++;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView1.SelectedRows[0];


                cbPhong.Text = row.Cells["Phòng"].Value.ToString();
                cbThietBi.Text = row.Cells["Tên thiết bị"].Value.ToString();
                cbPhanmem.Text = row.Cells["Phần mềm"].Value.ToString();
                cbCPU.Text = row.Cells["CPU"].Value.ToString();
                cbRam.Text = row.Cells["RAM"].Value.ToString();
                cbOCung.Text = row.Cells["Ổ cứng"].Value.ToString();

            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (dataTable.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để lưu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Đếm số lượng bản ghi trong bảng YeuCauThietBi
                    string countQuery = "SELECT COUNT(*) FROM YeuCauThietBi";
                    SqlCommand countCmd = new SqlCommand(countQuery, connection);
                    int currentStt = (int)countCmd.ExecuteScalar() + 1; // Tăng lên 1 để sử dụng cho mã yêu cầu mới

                    foreach (DataRow row in dataTable.Rows)
                    {
                        string maYeuCau = "YC" + currentStt.ToString();
                        string maPhongHoc = row["Mã phòng"].ToString();
                        string phong = row["Phòng"].ToString();
                        string tenthietbi = row["Tên thiết bị"].ToString();
                        string phanmem = row["Phần mềm"].ToString();
                        string CPU = row["CPU"].ToString();
                        string RAM = row["RAM"].ToString();
                        string OCung = row["Ổ cứng"].ToString();
                        string tenTaiKhoan = "GV001"; // Assuming you want to associate this with a specific user for now

                        string insertQuery = "INSERT INTO YeuCauThietBi (MaYeuCau, TenThietBi, MaPhongHoc, Window, PhanCung1, PhanCung2, PhanCung3, TenPhanMem, TenTaiKhoan) VALUES (@MaYeuCau, @TenThietBi, @MaPhongHoc, @Window, @PhanCung1, @PhanCung2, @PhanCung3, @TenPhanMem, @TenTaiKhoan)";
                        SqlCommand command = new SqlCommand(insertQuery, connection);
                        command.Parameters.AddWithValue("@MaYeuCau", maYeuCau);
                        command.Parameters.AddWithValue("@TenThietBi", tenthietbi);
                        command.Parameters.AddWithValue("@MaPhongHoc", maPhongHoc);
                        command.Parameters.AddWithValue("@Window", "Windows 10"); // Assuming this value for now
                        command.Parameters.AddWithValue("@PhanCung1", CPU);
                        command.Parameters.AddWithValue("@PhanCung2", RAM);
                        command.Parameters.AddWithValue("@PhanCung3", OCung);
                        command.Parameters.AddWithValue("@TenPhanMem", phanmem);
                        command.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
                        command.ExecuteNonQuery();

                        currentStt++; // Tăng biến stt để sử dụng cho mã yêu cầu mới
                    }

                    MessageBox.Show("Dữ liệu đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    dataTable.Clear();

                    cbPhong.Text = "";
                    cbPhanmem.Text = "";
                    cbCPU.Text = "";
                    cbRam.Text = "";
                    cbOCung.Text = "";
                    cbThietBi.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát khỏi ứng dụng không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {

                this.Close();
            }
        }

        private void cbThietBi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedDevice = cbThietBi.SelectedItem.ToString();
            if (selectedDevice != "Máy tính")
            {
                // Nếu thiết bị không phải là máy tính, khóa các ComboBox khác
                cbPhanmem.Text = "NA";
                cbCPU.Text = "NA";
                cbRam.Text = "NA";
                cbOCung.Text = "NA";

                cbPhanmem.Enabled = false;
                cbCPU.Enabled = false;
                cbRam.Enabled = false;
                cbOCung.Enabled = false;
            }
            else
            {

                cbPhanmem.Enabled = true;
                cbCPU.Enabled = true;
                cbRam.Enabled = true;
                cbOCung.Enabled = true;
                cbPhanmem.Text = "";
                cbCPU.Text = "";
                cbRam.Text = "";
                cbOCung.Text = "";
            }
        }

        private void cbPhanmem_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbPhong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
