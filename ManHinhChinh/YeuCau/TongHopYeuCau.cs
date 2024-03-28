using ManHinhChinh.XuLy;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace WindowsFormsApp7
{
    public partial class TongHopYeuCau : Form
    {
        string connectionString = Connection.stringConnection;
        SqlConnection sqlConn;
        DataTable dataTable;

        public TongHopYeuCau()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            dateTimePicker1.Enabled = false;
            dateTimePicker2.Enabled = false;

        }
        private void InitializeDataGridView()
        {
            dataTable = new DataTable();

            dataTable.Columns.Add("Mã yêu cầu", typeof(string));
            dataTable.Columns.Add("Tên thiết bị", typeof(string));
            dataTable.Columns.Add("Mã phòng học", typeof(string));
            dataTable.Columns.Add("Tình trạng", typeof(string));
            dataTable.Columns.Add("Ngày tạo yêu cầu", typeof(DateTime));
            dataTable.Columns.Add("Window", typeof(string));
            dataTable.Columns.Add("CPU", typeof(string));
            dataTable.Columns.Add("RAM", typeof(string));
            dataTable.Columns.Add("Ổ cứng", typeof(string));
            dataTable.Columns.Add("Phần mềm", typeof(string));
            dataTable.Columns.Add("Tên tài khoản", typeof(string));

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM YeuCauThietBi";
                SqlCommand command = new SqlCommand(query, connection);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {

                    dataTable.Rows.Add(reader["MaYeuCau"], reader["TenThietBi"], reader["MaPhongHoc"], reader["TinhTrang"], reader["NgayCapYeuCau"], reader["Window"], reader["PhanCung1"], reader["PhanCung2"], reader["PhanCung3"], reader["TenPhanMem"], reader["TenTaiKhoan"]);

                }
                connection.Close();
            }

            dgv1.DataSource = dataTable;
        }


        // chức năng duyệt của QUản lý
        private void btnDuyet_Click(object sender, EventArgs e)
        {
            if (dgv1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv1.SelectedRows[0];
                string tinhtrang = selectedRow.Cells["Tình trạng"].Value.ToString();


                if (tinhtrang == "Chờ xử lý" || tinhtrang == "Từ chối")
                {
                    try
                    {


                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();


                            string updateQuery = "UPDATE YeuCauThietBi SET TinhTrang = N'Đã duyệt' WHERE MaYeuCau = @MaYeuCau";
                            SqlCommand command = new SqlCommand(updateQuery, connection);


                            string maYeuCau = selectedRow.Cells["Mã yêu cầu"].Value.ToString();
                            command.Parameters.AddWithValue("@MaYeuCau", maYeuCau);


                            command.ExecuteNonQuery();


                            string maThietBi = selectedRow.Cells["Mã yêu cầu"].Value.ToString();
                            string tenThietBi = selectedRow.Cells["Tên thiết bị"].Value.ToString();
                            string maPhongHoc = selectedRow.Cells["Mã phòng học"].Value.ToString();
                            DateTime ngayTaoYeuCau = Convert.ToDateTime(selectedRow.Cells["Ngày tạo yêu cầu"].Value);


                            string insertQuery = "INSERT INTO ThietBi (MaThietBi, TenThietBi, MaPhongHoc, TinhTrang, NgayCapNhatNhanVien) VALUES (@MaThietBi, @TenThietBi, @MaPhongHoc, @TinhTrang,@ngayTaoYeuCau)";
                            SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                            insertCommand.Parameters.AddWithValue("@MaThietBi", maThietBi);
                            insertCommand.Parameters.AddWithValue("@TenThietBi", tenThietBi);
                            insertCommand.Parameters.AddWithValue("@MaPhongHoc", maPhongHoc);
                            insertCommand.Parameters.AddWithValue("@TinhTrang", "Chờ lắp đặt");
                            insertCommand.Parameters.AddWithValue("@ngayTaoYeuCau", ngayTaoYeuCau);
                            insertCommand.ExecuteNonQuery();
                        }
                        MessageBox.Show("Cập nhật trạng thái thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        selectedRow.Cells["Tình trạng"].Value = "Đã duyệt";




                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (tinhtrang == "Hoàn thành" || tinhtrang == "Đã hủy yêu cầu")
                {
                    MessageBox.Show("Yêu cầu đã hoàn thành hoặc đã bị hủy.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Yêu cầu này đã duyệt", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {

                MessageBox.Show("Vui lòng chọn một dòng để thay đổi trạng thái.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        // chức năng từ chối của QUản lý
        private void btnTuChoi_Click(object sender, EventArgs e)
        {
            if (dgv1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dgv1.SelectedRows[0];
                string tinhtrang = selectedRow.Cells["Tình trạng"].Value.ToString();
                if (tinhtrang == "Đã duyệt")
                {
                    try
                    {
                        using (SqlConnection connection = new SqlConnection(connectionString))
                        {
                            connection.Open();


                            string updateQuery = "UPDATE YeuCauThietBi SET TinhTrang = N'Từ chối' WHERE MaYeuCau = @MaYeuCau";
                            SqlCommand command = new SqlCommand(updateQuery, connection);


                            string maYeuCau = selectedRow.Cells["Mã yêu cầu"].Value.ToString();
                            command.Parameters.AddWithValue("@MaYeuCau", maYeuCau);


                            command.ExecuteNonQuery();


                            string maThietBi = selectedRow.Cells["Mã yêu cầu"].Value.ToString();


                            string deleteQuery = "DELETE FROM ThietBi WHERE MaThietBi=@MaThietBi ";
                            SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                            deleteCommand.Parameters.AddWithValue("@MaThietBi", maThietBi);

                            deleteCommand.ExecuteNonQuery();
                        }
                        MessageBox.Show("Cập nhật trạng thái thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        selectedRow.Cells["Tình trạng"].Value = "Từ chối";



                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (tinhtrang == "Hoàn thành" || tinhtrang == "Đã hủy yêu cầu" || tinhtrang == "Chờ xử lý")
                {
                    MessageBox.Show("Không thể từ chối yêu cầu đã hoàn thành hoặc đã bị hủy hoặc đang chờ xử lý.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            else
            {

                MessageBox.Show("Vui lòng chọn một dòng để thay đổi trạng thái.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        //chúc năng bỏ lọc
        private void btnBoLoc_Click(object sender, EventArgs e)
        {
            chkDaduyet.Checked = false;
            chkHoanThanh.Checked = false;
            chkHuy.Checked = false;
            chkTuChoi.Checked = false;
            chkChoxuly.Checked = false;
            chkThoigian.Checked = false;
            InitializeDataGridView();
        }
        //chức năng lọc
        private void btnLoc_Click(object sender, EventArgs e)
        {

            string query;

            query = "SELECT * FROM YeuCauThietBi";

            if (chkHuy.Checked || chkTuChoi.Checked || chkChoxuly.Checked || chkHoanThanh.Checked || chkDaduyet.Checked)
            {
                query += " WHERE (";
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
                if (chkThoigian.Checked)
                {
                    query += " AND NgayCapYeuCau BETWEEN @NgayBatDau AND @NgayKetThuc";
                }
            }
            if (chkThoigian.Checked)
            {
                query += " WHERE NgayCapYeuCau BETWEEN @NgayBatDau AND @NgayKetThuc";
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

                    SqlDataReader reader = command.ExecuteReader();
                    dataTable.Clear();
                    while (reader.Read())
                    {
                        dataTable.Rows.Add(reader["MaYeuCau"], reader["TenThietBi"], reader["MaPhongHoc"], reader["TinhTrang"], reader["NgayCapYeuCau"], reader["Window"], reader["PhanCung1"], reader["PhanCung2"], reader["PhanCung3"], reader["TenPhanMem"], reader["TenTaiKhoan"]);
                    }
                }
                dgv1.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void chkThoigian_CheckedChanged(object sender, EventArgs e)
        {
            if (chkThoigian.Checked)
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;

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

        private void btnDuyet_MouseHover(object sender, EventArgs e)
        {
            Button btnDuyet = (Button)sender;
            btnDuyet.BackColor = Color.White;
        }

        private void btnDuyet_MouseLeave(object sender, EventArgs e)
        {
            Button btnDuyet = (Button)sender;
            btnDuyet.BackColor = Color.LimeGreen;
        }

        private void btnTuChoi_MouseHover(object sender, EventArgs e)
        {
            Button btnTuChoi = (Button)sender;
            btnTuChoi.BackColor = Color.White;
        }

        private void btnTuChoi_MouseLeave(object sender, EventArgs e)
        {
            Button btnTuChoi = (Button)sender;
            btnTuChoi.BackColor = Color.OrangeRed;
        }

        private void btnThoat_MouseHover(object sender, EventArgs e)
        {
            Button btnThoat = (Button)sender;
            btnThoat.BackColor = Color.White;
        }

        private void btnThoat_MouseLeave(object sender, EventArgs e)
        {
            Button btnThoat = (Button)sender;
            btnThoat.BackColor = Color.Red;
        }
    }
}

