using Form_DangNhap_Dangky_QMK;
using ManHinhChinh.XuLy;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Net.NetworkInformation;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace WindowsFormsApp11
{
    public partial class YeuCauThietBi : Form
    {
        string connectionString = Connection.stringConnection;

        //// string user = DangNhap.TenDangNhap;
        string user = DangNhap.TenDangNhap;
        string loaitaikhoan = DangNhap.loaiTaiKhoan;


        SqlConnection sqlConn;
        DataTable dataTable;
        DataTable dataTable1;

        int rowCount = 0;
        public YeuCauThietBi()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            InitializeDataGridView1();
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;




            try
            {
                sqlConn = new SqlConnection(connectionString);
                sqlConn.Open();
                LoadRoomIDs();
                LoadPhanmem();
                txtCountDG.Text = "";
                sqlConn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }


        // lấy dữ liệu phòng mà NV(GV) đó quản lý(làm việc)
        private void LoadRoomIDs()
        {
            if (loaitaikhoan == "GiaoVien")
            {
                try
                {
                    using (SqlConnection sqlConn = new SqlConnection(connectionString))
                    {
                        sqlConn.Open();
                        SqlCommand cmd = new SqlCommand("SELECT PhongHoc.TenPhongHoc FROM PhongHoc JOIN QuyenTruyCapGV ON PhongHoc.MaPhongHoc = QuyenTruyCapGV.MaPhongHoc JOIN GiaoVien ON QuyenTruyCapGV.TenTaiKhoan = GiaoVien.TenTaiKhoan WHERE GiaoVien.TenTaiKhoan = @User", sqlConn);
                        cmd.Parameters.AddWithValue("@User", user);
                        SqlDataReader reader = cmd.ExecuteReader();

                        cbPhong.Items.Clear();

                        while (reader.Read())
                        {
                            cbPhong.Items.Add(reader["TenPhongHoc"].ToString());
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            if (loaitaikhoan == "NhanVien")
            {
                try
                {
                    using (SqlConnection sqlConn = new SqlConnection(connectionString))
                    {
                        sqlConn.Open();
                        SqlCommand cmd = new SqlCommand("SELECT DISTINCT PhongHoc.TenPhongHoc FROM PhongHoc JOIN Tang ON PhongHoc.MaTang = Tang.MaTang JOIN ToaNha ON Tang.MaToaNha = ToaNha.MaToaNha JOIN QuyenTruyCapNV ON ToaNha.MaToaNha = QuyenTruyCapNV.MaToaNha WHERE QuyenTruyCapNV.TenTaiKhoan = @User", sqlConn);
                        cmd.Parameters.AddWithValue("@User", user);
                        SqlDataReader reader = cmd.ExecuteReader();

                        cbPhong.Items.Clear();

                        while (reader.Read())
                        {
                            cbPhong.Items.Add(reader["TenPhongHoc"].ToString());
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }


        }
        // lấy dữ liệu phần mềm
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
        // datagridview cho nhập yêu cầu thiết bị mới
        private void InitializeDataGridView()
        {
            dataTable = new DataTable();

            dataTable.Columns.Add("STT", typeof(int));
            dataTable.Columns.Add("Ngày yêu cầu", typeof(DateTime));
            dataTable.Columns.Add("Mã phòng", typeof(string));
            dataTable.Columns.Add("Phòng", typeof(string));
            dataTable.Columns.Add("Tên thiết bị", typeof(string));
            dataTable.Columns.Add("Phần mềm", typeof(string));
            dataTable.Columns.Add("Window", typeof(string));
            dataTable.Columns.Add("CPU", typeof(string));
            dataTable.Columns.Add("RAM", typeof(string));
            dataTable.Columns.Add("Ổ cứng", typeof(string));


            dataGridView1.DataSource = dataTable;

        }
        // datagridview cho xem lịch sữ yêu cầu
        private void InitializeDataGridView1()
        {
            dataTable1 = new DataTable();

            dataTable1.Columns.Add("Mã yêu cầu", typeof(string));
            dataTable1.Columns.Add("Tên thiết bị", typeof(string));
            dataTable1.Columns.Add("Mã phòng học", typeof(string));
            dataTable1.Columns.Add("Tình trạng", typeof(string));
            dataTable1.Columns.Add("Ngày tạo yêu cầu", typeof(DateTime));
            dataTable1.Columns.Add("Window", typeof(string));
            dataTable1.Columns.Add("CPU", typeof(string));
            dataTable1.Columns.Add("RAM", typeof(string));
            dataTable1.Columns.Add("Ổ cứng", typeof(string));
            dataTable1.Columns.Add("Phần mềm", typeof(string));
            dataTable1.Columns.Add("Tên tài khoản", typeof(string));

            if (loaitaikhoan == "GiaoVien")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM YeuCauThietBi WHERE TenTaiKhoan = @TenTaiKhoan";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TenTaiKhoan", user);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        dataTable1.Rows.Add(reader["MaYeuCau"], reader["TenThietBi"], reader["MaPhongHoc"], reader["TinhTrang"], reader["NgayCapYeuCau"], reader["Window"], reader["PhanCung1"], reader["PhanCung2"], reader["PhanCung3"], reader["TenPhanMem"], reader["TenTaiKhoan"]);
                    }
                    connection.Close();
                }
            }
            else if (loaitaikhoan == "NhanVien")
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM YeuCauThietBi " +
                                   "JOIN PhongHoc ON YeuCauThietBi.MaPhongHoc = PhongHoc.MaPhongHoc " +
                                   "JOIN Tang ON PhongHoc.MaTang = Tang.MaTang " +
                                   "JOIN ToaNha ON Tang.MaToaNha = ToaNha.MaToaNha " +
                                   "JOIN QuyenTruyCapNV ON ToaNha.MaToaNha = QuyenTruyCapNV.MaToaNha " +
                                   "WHERE QuyenTruyCapNV.TenTaiKhoan = @TenTaiKhoan";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TenTaiKhoan", user);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        dataTable1.Rows.Add(reader["MaYeuCau"], reader["TenThietBi"], reader["MaPhongHoc"], reader["TinhTrang"], reader["NgayCapYeuCau"], reader["Window"], reader["PhanCung1"], reader["PhanCung2"], reader["PhanCung3"], reader["TenPhanMem"], reader["TenTaiKhoan"]);
                    }
                    connection.Close();
                }
            }

            dgv2.DataSource = dataTable1;
        }

        // chức năng thêm thiết bi cần mua vào datagridview
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbPhong.Text) || string.IsNullOrWhiteSpace(cbThietBi.Text)
         || string.IsNullOrWhiteSpace(cbPhanmem.Text) || string.IsNullOrWhiteSpace(cbCPU.Text)
         || string.IsNullOrWhiteSpace(cbRam.Text) || string.IsNullOrWhiteSpace(cbOCung.Text) || string.IsNullOrWhiteSpace(cbWin.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string phong = cbPhong.Text;
            string tenThietbi = cbThietBi.Text;
            string phanMem = cbPhanmem.Text;
            string heDieuhanh = cbWin.Text;
            string CPU = cbCPU.Text;
            string RAM = cbRam.Text;
            string oCung = cbOCung.Text;
            string maPhongHoc;
            DateTime ngayYeuCau = DateTime.Now;
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
            newRow["Ngày yêu cầu"] = ngayYeuCau;
            newRow["Mã phòng"] = maPhongHoc;
            newRow["Phòng"] = phong;
            newRow["Tên thiết bị"] = tenThietbi;
            newRow["Phần mềm"] = phanMem;
            newRow["Window"] = heDieuhanh;
            newRow["CPU"] = CPU;
            newRow["RAM"] = RAM;
            newRow["Ổ cứng"] = oCung;


            dataTable.Rows.Add(newRow);
            rowCount++;
            txtCountDG.Text = rowCount.ToString();


            cbPhong.Text = "";
            cbPhanmem.Text = "";
            cbCPU.Text = "";
            cbRam.Text = "";
            cbOCung.Text = "";
            cbThietBi.Text = "";
            cbWin.Text = "";

            cbPhanmem.Enabled = true;
            cbCPU.Enabled = true;
            cbRam.Enabled = true;
            cbOCung.Enabled = true;
        }

        // chức năng sửa thiết bi cần mua trong datagridview
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                selectedRow.Cells["Phòng"].Value = cbPhong.SelectedItem.ToString();
                selectedRow.Cells["Tên thiết bị"].Value = cbThietBi.SelectedItem.ToString();
                selectedRow.Cells["Phần mềm"].Value = cbPhanmem.SelectedItem.ToString();
                selectedRow.Cells["Window"].Value = cbWin.SelectedItem.ToString();
                selectedRow.Cells["CPU"].Value = cbCPU.SelectedItem.ToString();
                selectedRow.Cells["RAM"].Value = cbRam.SelectedItem.ToString();
                selectedRow.Cells["Ổ cứng"].Value = cbOCung.SelectedItem.ToString();

            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để sửa.");
            }
        }
        // chức năng xoá thiết bi cần mua trong datagridview
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dòng này?", "Xác nhận Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {

                    dataTable.Rows.RemoveAt(selectedRow.Index);
                }
                rowCount--;
                txtCountDG.Text = rowCount.ToString();

                int counter = 1;
                foreach (DataRow row in dataTable.Rows)
                {
                    row["STT"] = counter++;
                }
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
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để xóa.");
            }

        }
        // chức năng lưu dữ liệu vào data SQL
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


                    string countQuery = "SELECT COUNT(*) FROM YeuCauThietBi";
                    SqlCommand countCmd = new SqlCommand(countQuery, connection);
                    int currentStt = (int)countCmd.ExecuteScalar() + 1;

                    foreach (DataRow row in dataTable.Rows)
                    {
                        string maYeuCau = "YC" + currentStt.ToString();
                        string tenThietbi = row["Tên thiết bị"].ToString();
                        string maPhongHoc = row["Mã phòng"].ToString();
                        string tinhTrang = "Chờ xử lý";

                        string phanMem = row["Phần mềm"].ToString();
                        string heDieuHanh = row["Window"].ToString();
                        string CPU = row["CPU"].ToString();
                        string RAM = row["RAM"].ToString();
                        string oCung = row["Ổ cứng"].ToString();
                        string tenTaiKhoan = user;
                        DateTime ngayyeucau = DateTime.Now;
                        string insertQuery = "INSERT INTO YeuCauThietBi (MaYeuCau, TenThietBi, MaPhongHoc, TinhTrang,NgayCapYeuCau,Window, PhanCung1, PhanCung2, PhanCung3, TenPhanMem, TenTaiKhoan) VALUES (@MaYeuCau, @TenThietBi, @MaPhongHoc, @TinhTrang, @NgayCapNhatNhanVien,@Window, @PhanCung1, @PhanCung2, @PhanCung3, @TenPhanMem, @TenTaiKhoan)";
                        SqlCommand command = new SqlCommand(insertQuery, connection);
                        command.Parameters.AddWithValue("@MaYeuCau", maYeuCau);
                        command.Parameters.AddWithValue("@TenThietBi", tenThietbi);
                        command.Parameters.AddWithValue("@MaPhongHoc", maPhongHoc);
                        command.Parameters.AddWithValue("@TinhTrang", tinhTrang);
                        command.Parameters.AddWithValue("@NgayCapNhatNhanVien", ngayyeucau);
                        command.Parameters.AddWithValue("@Window", heDieuHanh);
                        command.Parameters.AddWithValue("@PhanCung1", CPU);
                        command.Parameters.AddWithValue("@PhanCung2", RAM);
                        command.Parameters.AddWithValue("@PhanCung3", oCung);
                        command.Parameters.AddWithValue("@TenPhanMem", phanMem);
                        command.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);

                        command.ExecuteNonQuery();

                        currentStt++;
                        InitializeDataGridView1();
                    }

                    MessageBox.Show("Dữ liệu đã được lưu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    rowCount = 0;
                    dataTable.Clear();

                    cbPhong.Text = "";
                    cbPhanmem.Text = "";
                    cbCPU.Text = "";
                    cbRam.Text = "";
                    cbOCung.Text = "";
                    cbThietBi.Text = "";
                    txtCountDG.Text = "";
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // chức năng thoát CT
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát khỏi ứng dụng không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {

                this.Close();
            }
        }
        // chức năng xoá yêu cầu thiêt bị trước đó đã thêm
        private void btXoaYC_Click(object sender, EventArgs e)
        {

            if (dgv2.SelectedRows.Count > 0)
            {

                DataGridViewRow selectedRow = dgv2.SelectedRows[0];
                string currentStatus = selectedRow.Cells["Tình trạng"].Value.ToString();

                if (currentStatus == "Chờ xử lý")
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();
                            string updateQuery = "UPDATE YeuCauThietBi SET TinhTrang = N'Đã hủy yêu cầu' WHERE MaYeuCau = @MaYeuCau";
                            SqlCommand command = new SqlCommand(updateQuery, connection);
                            string maYeuCau = selectedRow.Cells["Mã yêu cầu"].Value.ToString();
                            command.Parameters.AddWithValue("@MaYeuCau", maYeuCau);
                            command.ExecuteNonQuery();
                        }



                        selectedRow.Cells["Tình trạng"].Value = "Đã huỷ yêu cầu";
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Không thể xóa yêu cầu đã xử lý hoặc đã hủy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            else
            {
                MessageBox.Show("Vui lòng chọn ít nhất một dòng để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        // chức năng lọc theo 1 hay nhiều điều kiện
        private void btLoc_Click(object sender, EventArgs e)
        {
            string query;
            if (loaitaikhoan == "GiaoVien")
            {
                query = "SELECT * FROM YeuCauThietBi WHERE TenTaiKhoan = @TenTaiKhoan";
            }
            else
            {
                query = "SELECT YeuCauThietBi.* " +
                        "FROM YeuCauThietBi " +
                        "JOIN PhongHoc ON YeuCauThietBi.MaPhongHoc = PhongHoc.MaPhongHoc " +
                        "JOIN Tang ON PhongHoc.MaTang = Tang.MaTang " +
                        "JOIN ToaNha ON Tang.MaToaNha = ToaNha.MaToaNha " +
                        "JOIN QuyenTruyCapNV ON ToaNha.MaToaNha = QuyenTruyCapNV.MaToaNha " +
                        "WHERE QuyenTruyCapNV.TenTaiKhoan = @TenTaiKhoan";
            }
            if (chkHuy.Checked || chkTuChoi.Checked || chkChoxuly.Checked || chkHoanThanh.Checked || chkDaduyet.Checked)
            {
                query += " AND (";
                bool dkdautien = false;
                if (chkHuy.Checked)
                {
                    query += " TinhTrang  = @TinhTrangHuyyeucau";
                    dkdautien = true;
                }
                if (chkTuChoi.Checked)
                {
                    if (dkdautien)
                    {
                        query += " OR";
                    }
                    query += " TinhTrang = @TinhTrangTuChoi";
                    dkdautien = true;
                }
                if (chkDaduyet.Checked)
                {
                    if (dkdautien)
                    {
                        query += " OR";
                    }
                    query += " TinhTrang = @TinhTrangDaduyet";
                    dkdautien = true;
                }
                if (chkChoxuly.Checked)
                {
                    if (dkdautien)
                    {
                        query += " OR";
                    }
                    query += " TinhTrang = @TinhTrangChoxuly";
                    dkdautien = true;
                }
                if (chkHoanThanh.Checked)
                {
                    if (dkdautien)
                    {
                        query += " OR";
                    }
                    query += " TinhTrang = @TinhTrangHoanthanh";
                    dkdautien = true;
                }
                query += " )";
            }
            if (chkThoigian.Checked)
            {
                query += " AND NgayCapYeuCau BETWEEN @NgayBatDau AND @NgayKetThuc";
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@NgayBatDau", dateTimePicker1.Value.Date);
                    command.Parameters.AddWithValue("@NgayKetThuc", dateTimePicker2.Value.Date);
                    command.Parameters.AddWithValue("@TinhTrangTuChoi", "Từ chối");
                    command.Parameters.AddWithValue("@TinhTrangDaduyet", "Đã duyệt");
                    command.Parameters.AddWithValue("@TinhTrangHoanthanh", "Hoàn thành");
                    command.Parameters.AddWithValue("@TinhTrangChoxuly", "Chờ xử lý");
                    command.Parameters.AddWithValue("@TinhTrangHuyyeucau", "Đã hủy yêu cầu");
                    command.Parameters.AddWithValue("@TenTaiKhoan", user);

                    SqlDataReader reader = command.ExecuteReader();
                    dataTable1.Clear();
                    while (reader.Read())
                    {
                        dataTable1.Rows.Add(reader["MaYeuCau"], reader["TenThietBi"], reader["MaPhongHoc"], reader["TinhTrang"], reader["NgayCapYeuCau"], reader["Window"], reader["PhanCung1"], reader["PhanCung2"], reader["PhanCung3"], reader["TenPhanMem"], reader["TenTaiKhoan"]);
                    }
                }
                dgv2.DataSource = dataTable1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // chức năng bỏ lọc 
        private void btCancelLoc_Click(object sender, EventArgs e)
        {
            chkDaduyet.Checked = false;
            chkHoanThanh.Checked = false;
            chkHuy.Checked = false;
            chkTuChoi.Checked = false;
            chkChoxuly.Checked = false;
            chkThoigian.Checked = false;
            InitializeDataGridView1();
        }

        private void cbThietBi_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string selectedDevice = cbThietBi.SelectedItem.ToString();
            if (selectedDevice != "Máy tính")
            {
                cbPhanmem.Items.Add("N/A");
                cbPhanmem.Text = "N/A";
                cbCPU.Text = "N/A";
                cbRam.Text = "N/A";
                cbOCung.Text = "N/A";
                cbWin.Text = "N/A";

                cbPhanmem.Enabled = false;
                cbCPU.Enabled = false;
                cbRam.Enabled = false;
                cbOCung.Enabled = false;
                cbWin.Enabled = false;
            }
            else
            {

                cbPhanmem.Enabled = true;
                cbCPU.Enabled = true;
                cbRam.Enabled = true;
                cbOCung.Enabled = true;
                cbWin.Enabled = true;
                cbPhanmem.Text = "";
                cbCPU.Text = "";
                cbRam.Text = "";
                cbOCung.Text = "";
                cbWin.Text = "";
            }
        }


        // sự kiện chọn 1 dòng trong datagridview

        private void dataGridView1_SelectionChanged_1(object sender, EventArgs e)
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
                cbWin.Text = row.Cells["Window"].Value.ToString();

            }
        }
        // sự kiện chuyển tab
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 0)
            {

                foreach (Control control in grbLoc.Controls)
                {
                    if (control is System.Windows.Forms.RadioButton radioButton)
                    {
                        radioButton.Checked = false;
                    }
                }
                InitializeDataGridView1();
            }
        }
        // sự kiện thao tác trên checkbox thời gian
        private void chkThoigian_CheckedChanged(object sender, EventArgs e)
        {
            if (chkThoigian.Checked)
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
            }
            else
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_MouseHover(object sender, EventArgs e)
        {
            Button btnThem = (Button)sender;
            btnThem.BackColor = Color.White;
        }

        private void btnThem_MouseLeave(object sender, EventArgs e)
        {
            btnThem.BackColor = Color.LimeGreen;
        }

        private void btnXoa_MouseHover(object sender, EventArgs e)
        {
            btnXoa.BackColor = Color.White;
        }

        private void btnXoa_MouseLeave(object sender, EventArgs e)
        {
            btnXoa.BackColor = Color.Red;
        }

        private void btnSua_MouseHover(object sender, EventArgs e)
        {
            btnSua.BackColor = Color.White;
        }

        private void btnSua_MouseLeave(object sender, EventArgs e)
        {
            btnSua.BackColor = Color.Turquoise;
        }

        private void btnThoat_MouseHover(object sender, EventArgs e)
        {
            btnThoat.BackColor = Color.White;
        }

        private void btnThoat_MouseLeave(object sender, EventArgs e)
        {
            btnThoat.BackColor= Color.Red;
        }
    }
}

