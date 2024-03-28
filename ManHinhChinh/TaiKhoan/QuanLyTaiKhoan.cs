using Form_DangNhap_Dangky_QMK;
using ManHinhChinh.XuLy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ManHinhChinh.TaiKhoan
{
    public partial class QuanLyTaiKhoan : Form
    {
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
            this.Load += QuanLyTaiKhoan_Load;
        }
        private void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            // Khởi tạo DataTable
            DataTable dataTable = new DataTable("TaiKhoan");

            // Thêm các cột vào DataTable
            dataTable.Columns.Add("ID", typeof(string));
            dataTable.Columns.Add("Ten", typeof(string));
            dataTable.Columns.Add("SDT", typeof(string));
            dataTable.Columns.Add("Email", typeof(string));
            dataTable.Columns.Add("TenTaiKhoan", typeof(string));
            dataTable.Columns.Add("MatKhau", typeof(string));
            dataTable.Columns.Add("LoaiTaiKhoan", typeof(string));

            // Thực hiện truy vấn SQL
            string query = @"
        SELECT NV.ID AS ID, NV.Ten AS Ten, NV.SDT AS SDT, NV.Email AS Email, TK.TenTaiKhoan AS TenTaiKhoan, TK.MatKhau AS MatKhau, TK.LoaiTaiKhoan AS LoaiTaiKhoan 
        FROM NhanVien NV 
        INNER JOIN TaiKhoan TK ON NV.TenTaiKhoan = TK.TenTaiKhoan 
        UNION ALL 
        SELECT GV.ID AS ID, GV.Ten AS Ten, GV.SDT AS SDT, GV.Email AS Email, TK.TenTaiKhoan AS TenTaiKhoan, TK.MatKhau AS MatKhau, TK.LoaiTaiKhoan AS LoaiTaiKhoan 
        FROM GiaoVien GV 
        INNER JOIN TaiKhoan TK ON GV.TenTaiKhoan = TK.TenTaiKhoan";

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
        private void lblTen_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView_ctpm_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem người dùng đã chọn một dòng hợp lệ chưa
            if (e.RowIndex >= 0 && e.RowIndex < dataGridView1.Rows.Count - 1)
            {
                // Lấy dòng được chọn từ DataGridView
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Hiển thị thông tin từ dòng được chọn lên các TextBox tương ứng
                txtTTK.Text = row.Cells["TenTaiKhoan"].Value.ToString();
                txtMK.Text = row.Cells["MatKhau"].Value.ToString();
                txtLoaiTK.Text = row.Cells["LoaiTaiKhoan"].Value.ToString();
                txtID.Text = row.Cells["ID"].Value.ToString();
                txtTen.Text = row.Cells["Ten"].Value.ToString();
                txtSdt.Text = row.Cells["SDT"].Value.ToString();
                txtMail.Text = row.Cells["Email"].Value.ToString();
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các TextBox
            string tenTaiKhoan = txtTTK.Text;
            string matKhau = txtMK.Text;
            string loaiTK = txtLoaiTK.Text;
            string id = txtID.Text;
            string ten = txtTen.Text;
            string sdt = txtSdt.Text;
            string mail = txtMail.Text;

            // Kiểm tra xem ID đã tồn tại trong cơ sở dữ liệu chưa
            if (IsIDExists(id))
            {
                MessageBox.Show("ID đã tồn tại trong cơ sở dữ liệu. Vui lòng nhập lại ID khác.");
                return;
            }

            // Thực hiện truy vấn SQL để thêm dữ liệu vào bảng TaiKhoan
            string queryTaiKhoan = "INSERT INTO TaiKhoan (TenTaiKhoan, MatKhau, LoaiTaiKhoan) VALUES (@TenTaiKhoan, @MatKhau, @LoaiTaiKhoan)";
            using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
            {
                SqlCommand commandTaiKhoan = new SqlCommand(queryTaiKhoan, connection);
                commandTaiKhoan.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
                commandTaiKhoan.Parameters.AddWithValue("@MatKhau", matKhau);
                commandTaiKhoan.Parameters.AddWithValue("@LoaiTaiKhoan", loaiTK);

                connection.Open();
                commandTaiKhoan.ExecuteNonQuery();

                // Thêm dữ liệu vào bảng tương ứng (NhanVien hoặc GiaoVien) dựa vào loaiTK
                if (loaiTK == "NhanVien")
                {
                    string queryNhanVien = "INSERT INTO NhanVien (ID, Ten, SDT, Email, TenTaiKhoan) VALUES (@ID, @Ten, @SDT, @Email, @TenTaiKhoan)";
                    SqlCommand commandNhanVien = new SqlCommand(queryNhanVien, connection);
                    commandNhanVien.Parameters.AddWithValue("@ID", id);
                    commandNhanVien.Parameters.AddWithValue("@Ten", ten);
                    commandNhanVien.Parameters.AddWithValue("@SDT", sdt);
                    commandNhanVien.Parameters.AddWithValue("@Email", mail);
                    commandNhanVien.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
                    commandNhanVien.ExecuteNonQuery();
                }
                else if (loaiTK == "GiaoVien")
                {
                    string queryGiaoVien = "INSERT INTO GiaoVien (ID, Ten, SDT, Email, TenTaiKhoan) VALUES (@ID, @Ten, @SDT, @Email, @TenTaiKhoan)";
                    SqlCommand commandGiaoVien = new SqlCommand(queryGiaoVien, connection);
                    commandGiaoVien.Parameters.AddWithValue("@ID", id);
                    commandGiaoVien.Parameters.AddWithValue("@Ten", ten);
                    commandGiaoVien.Parameters.AddWithValue("@SDT", sdt);
                    commandGiaoVien.Parameters.AddWithValue("@Email", mail);
                    commandGiaoVien.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
                    commandGiaoVien.ExecuteNonQuery();
                }
                connection.Close();
                MessageBox.Show("Thêm dữ liệu thành công!");
                // Refresh lại DataGridView
                QuanLyTaiKhoan_Load(sender, e);
            }
        }

        private bool IsIDExists(string id)
        {
            // Kiểm tra xem ID đã tồn tại trong cơ sở dữ liệu chưa
            string query = "SELECT COUNT(*) FROM NhanVien WHERE ID = @ID UNION ALL SELECT COUNT(*) FROM GiaoVien WHERE ID = @ID";
            using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ID", id);

                connection.Open();
                int count = (int)command.ExecuteScalar();
                connection.Close();

                return count > 0;
            }
        }

        private void button_Xoa_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các TextBox
            string tenTaiKhoan = txtTTK.Text;
            string matKhau = txtMK.Text;
            string loaiTK = txtLoaiTK.Text;
            string id = txtID.Text;
            string ten = txtTen.Text;
            string sdt = txtSdt.Text;
            string mail = txtMail.Text;

            // Kiểm tra xem người dùng đã chọn một dòng hợp lệ từ DataGridView chưa
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một dòng từ DataGridView để xóa dữ liệu.");
                return;
            }

            // Lấy thông tin từ dòng được chọn từ DataGridView
            DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
            string selectedTenTaiKhoan = selectedRow.Cells["TenTaiKhoan"].Value.ToString();

            // Kiểm tra xác nhận xóa dữ liệu
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa dữ liệu có Tên tài khoản: " + selectedTenTaiKhoan + " không?", "Xác nhận xóa", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                // Thực hiện truy vấn SQL để xóa dữ liệu từ bảng NhanVien hoặc GiaoVien dựa vào loaiTK
                string deleteNhanVienQuery = @"
                                       DELETE FROM QuyenTruyCapNV 
                                       WHERE TenTaiKhoan = @TenTaiKhoan;
                                       DELETE FROM NhanVien 
                                       WHERE TenTaiKhoan = @TenTaiKhoan;
                                       DELETE FROM TaiKhoan 
                                       WHERE TenTaiKhoan = @TenTaiKhoan;";



                string deleteGiaoVienQuery = @"
                                       DELETE FROM QuyenTruyCapGV 
                                       WHERE TenTaiKhoan = @TenTaiKhoan
                                       DELETE FROM GiaoVien 
                                       WHERE TenTaiKhoan = @TenTaiKhoan;
                                       DELETE FROM TaiKhoan 
                                       WHERE TenTaiKhoan = @TenTaiKhoan;";

                // Thực thi truy vấn SQL để xóa dữ liệu
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    connection.Open();

                    SqlCommand deleteCommand;
                    if (loaiTK == "NhanVien")
                    {
                        deleteCommand = new SqlCommand(deleteNhanVienQuery, connection);
                    }
                    else if (loaiTK == "GiaoVien")
                    {
                        deleteCommand = new SqlCommand(deleteGiaoVienQuery, connection);
                    }
                    else
                    {
                        MessageBox.Show("Loại tài khoản không hợp lệ.");
                        connection.Close();
                        return;
                    }

                    deleteCommand.Parameters.AddWithValue("@TenTaiKhoan", selectedTenTaiKhoan);
                    int rowsAffected = deleteCommand.ExecuteNonQuery();

                    connection.Close();

                    // Kiểm tra và hiển thị kết quả
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Xóa dữ liệu thành công!");
                        // Refresh lại DataGridView
                        QuanLyTaiKhoan_Load(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Xóa dữ liệu không thành công!");
                    }
                }
            }
        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            // Lấy thông tin từ các TextBox
            string tenTaiKhoan = txtTTK.Text;
            string matKhau = txtMK.Text;
            string loaiTK = txtLoaiTK.Text;
            string id = txtID.Text;
            string ten = txtTen.Text;
            string sdt = txtSdt.Text;
            string mail = txtMail.Text;

            // Thực hiện truy vấn SQL để cập nhật dữ liệu trong bảng TaiKhoan
            string updateTaiKhoanQuery = "UPDATE TaiKhoan SET MatKhau = @MatKhau, LoaiTaiKhoan = @LoaiTaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan";
            using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
            {
                SqlCommand commandTaiKhoan = new SqlCommand(updateTaiKhoanQuery, connection);
                commandTaiKhoan.Parameters.AddWithValue("@MatKhau", matKhau);
                commandTaiKhoan.Parameters.AddWithValue("@LoaiTaiKhoan", loaiTK);
                commandTaiKhoan.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);

                connection.Open();
                commandTaiKhoan.ExecuteNonQuery();

                // Thực hiện truy vấn SQL để cập nhật dữ liệu trong bảng tương ứng (NhanVien hoặc GiaoVien) dựa vào loaiTK
                if (loaiTK == "NhanVien")
                {
                    string updateNhanVienQuery = "UPDATE NhanVien SET Ten = @Ten, SDT = @SDT, Email = @Email WHERE ID = @ID";
                    SqlCommand commandNhanVien = new SqlCommand(updateNhanVienQuery, connection);
                    commandNhanVien.Parameters.AddWithValue("@Ten", ten);
                    commandNhanVien.Parameters.AddWithValue("@SDT", sdt);
                    commandNhanVien.Parameters.AddWithValue("@Email", mail);
                    commandNhanVien.Parameters.AddWithValue("@ID", id);
                    commandNhanVien.ExecuteNonQuery();
                }
                else if (loaiTK == "GiaoVien")
                {
                    string updateGiaoVienQuery = "UPDATE GiaoVien SET Ten = @Ten, SDT = @SDT, Email = @Email WHERE ID = @ID";
                    SqlCommand commandGiaoVien = new SqlCommand(updateGiaoVienQuery, connection);
                    commandGiaoVien.Parameters.AddWithValue("@Ten", ten);
                    commandGiaoVien.Parameters.AddWithValue("@SDT", sdt);
                    commandGiaoVien.Parameters.AddWithValue("@Email", mail);
                    commandGiaoVien.Parameters.AddWithValue("@ID", id);
                    commandGiaoVien.ExecuteNonQuery();
                }
                connection.Close();
                MessageBox.Show("Cập nhật dữ liệu thành công!");
                // Refresh lại DataGridView
                QuanLyTaiKhoan_Load(sender, e);
            }
        }

        private void QuanLyTaiKhoan_Load_1(object sender, EventArgs e)
        {

        }

        private void button_Them_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button_Them = (System.Windows.Forms.Button)sender;
            button_Them.BackColor = System.Drawing.Color.White;

        }

        private void button_Them_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button_Them = (System.Windows.Forms.Button)sender;
            button_Them.BackColor = System.Drawing.Color.Cyan;
        }

        private void button_Sua_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button_Sua = (System.Windows.Forms.Button)sender;
            button_Sua.BackColor = System.Drawing.Color.White;
        }

        private void button_Sua_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button_Sua = (System.Windows.Forms.Button)sender;
            button_Sua.BackColor = System.Drawing.Color.Green;
        }

        private void button_Xoa_MouseHover(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button_Xoa = (System.Windows.Forms.Button)sender;
            button_Xoa.BackColor = System.Drawing.Color.White;
        }

        private void button_Xoa_MouseLeave(object sender, EventArgs e)
        {
            System.Windows.Forms.Button button_Xoa = (System.Windows.Forms.Button)sender;
            button_Xoa.BackColor = System.Drawing.Color.Red;
        }
    }
}
