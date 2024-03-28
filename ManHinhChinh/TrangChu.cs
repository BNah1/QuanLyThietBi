using Form_DangNhap_Dangky_QMK;
using ManHinhChinh.Baocao;
using ManHinhChinh.QuanLyThietBivaPhanMem;
using ManHinhChinh.XuLy;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using WindowsFormsApp11;
using WinFormsApp1;

namespace ManHinhChinh
{
    public partial class TrangChu : Form
    {

        public TrangChu()
        {
            InitializeComponent();
            label1.Text = DangNhap.TenDangNhap;
        }

        private void TrangChu_Load(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
            {
                connection.Open();

                string selectQuery = "SELECT ThietBi.*, QuyenTruyCapNV.TenTaiKhoan FROM ThietBi " +
                                     "JOIN PhongHoc ON ThietBi.MaPhongHoc = PhongHoc.MaPhongHoc " +
                                     "JOIN Tang ON PhongHoc.MaTang = Tang.MaTang " +
                                     "JOIN ToaNha ON Tang.MaToaNha = ToaNha.MaToaNha " +
                                     "JOIN QuyenTruyCapNV ON ToaNha.MaToaNha = QuyenTruyCapNV.MaToaNha " +
                                     "WHERE QuyenTruyCapNV.TenTaiKhoan = @TenTaiKhoan";
                SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
                selectCommand.Parameters.AddWithValue("@TenTaiKhoan", DangNhap.TenDangNhap);

                SqlDataReader reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    string tinhTrang = reader["TinhTrang"].ToString();

                    // Kiểm tra điều kiện TinhTrang khác 'Hoạt động'
                    if (tinhTrang != "Hoạt động")
                    {
                        // Đặt Visible của PictureBox thành true
                        pictureBox4.Visible = true;
                    }
                }

                reader.Close();
                connection.Close();
            }
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private bool buttonsVisible = false;
        private void ThietBi_Click(object sender, EventArgs e)
        {
            if (!buttonsVisible)
            {
                button1TraCuu.Visible = true;
                button1YeuCau.Visible = true;
                buttonsVisible = true;
            }
            else
            {
                button1TraCuu.Visible = false;
                button1YeuCau.Visible = false;
                buttonsVisible = false;
            }
        }
        private void ThietBi_LostFocus(object sender, EventArgs e)
        {
            // Kiểm tra nếu focus không còn trên button1, ẩn button1TraCuu và button1YeuCau
            if (!button1TraCuu.Focused && !button1YeuCau.Focused)
            {
                button1TraCuu.Visible = false;
                button1YeuCau.Visible = false;
            }
        }

        private void PhanMem_Click(object sender, EventArgs e)
        {
            if (!buttonsVisible)
            {
                button2TraCuu.Visible = true;
                button2YeuCau.Visible = true;
                buttonsVisible = true;
            }
            else
            {
                button2TraCuu.Visible = false;
                button2YeuCau.Visible = false;
                buttonsVisible = false;
            }
        }
        private void PhanMem_LostFocus(object sender, EventArgs e)
        {
            // Kiểm tra nếu focus không còn trên button1, ẩn button1TraCuu và button1YeuCau
            if (!button2TraCuu.Focused && !button2YeuCau.Focused)
            {
                button2TraCuu.Visible = false;
                button2YeuCau.Visible = false;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {

        }
        private void button6_LostFocus(object sender, EventArgs e)
        {

        }
        private void button3ADMIN_Click(object sender, EventArgs e)
        {

        }

        private void đổiMậtKhẩuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            // Khởi tạo form
            ThongTinCaNhan thongTinCaNhan = new ThongTinCaNhan();

            // Xác định vị trí xuất hiện trên form TrangChu
            thongTinCaNhan.StartPosition = FormStartPosition.Manual;
            thongTinCaNhan.Left = this.Left + 263;
            thongTinCaNhan.Top = this.Top + 105;
            // Ẩn tất cả các form khác trừ form TrangChu
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name != "TrangChu")
                {
                    frm.Hide();
                }
            }
            // Hiển thị form thongTinCaNhan
            thongTinCaNhan.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            // Khởi tạo form DoiMatKhau
            DoiMatKhau doiMatKhau = new DoiMatKhau();

            // Xác định vị trí xuất hiện trên form TrangChu
            doiMatKhau.StartPosition = FormStartPosition.Manual;
            doiMatKhau.Left = this.Left + 263;
            doiMatKhau.Top = this.Top + 105;
            // Ẩn tất cả các form khác trừ form TrangChu
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name != "TrangChu")
                {
                    frm.Hide();
                }
            }
            // Hiển thị form DoiMatKhau
            doiMatKhau.Show();
        }

        private void tableLayoutPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button_Dangxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Khởi tạo form 
            DangNhap dangNhap = new DangNhap();

            // Hiển thị form 
            dangNhap.Show();
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            ChiTietThietBi_Form chiTietThietBi = new ChiTietThietBi_Form();
            // Xác định vị trí xuất hiện trên form TrangChu
            chiTietThietBi.StartPosition = FormStartPosition.Manual;
            chiTietThietBi.Left = this.Left + 263;
            chiTietThietBi.Top = this.Top + 105;
            // Ẩn tất cả các form khác trừ form TrangChu
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name != "TrangChu")
                {
                    frm.Hide();
                }
            }
            chiTietThietBi.Show();
        }



        private void QlyYeuCau_Click_1(object sender, EventArgs e)
        {
            if (!buttonsVisible)
            {
                button3TongHop.Visible = true;

                button3ADMIN.Visible = true;
                buttonsVisible = true;
            }
            else
            {
                button3TongHop.Visible = false;

                button3ADMIN.Visible = false;
                buttonsVisible = false;
            }
        }
        private void QlyYeuCau_LostFocus(object sender, EventArgs e)
        {
            // Kiểm tra nếu focus không còn 
            if (!button3TongHop.Focused && !button3ADMIN.Focused)
            {
                button3TongHop.Visible = false;

                button3ADMIN.Visible = false;
            }
        }

        private void button_HoTro_Click(object sender, EventArgs e)
        {
            HoTroNhanh hoTroNhanh = new HoTroNhanh();
            // Xác định vị trí xuất hiện trên form TrangChu
            hoTroNhanh.StartPosition = FormStartPosition.Manual;
            hoTroNhanh.Left = this.Left + 263;
            hoTroNhanh.Top = this.Top + 105;
            // Ẩn tất cả các form khác trừ form TrangChu
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name != "TrangChu")
                {
                    frm.Hide();
                }
            }
            hoTroNhanh.Show();
        }

        private void button3TongHop_Click(object sender, EventArgs e)
        {
            LichSuThongBao lichSuYeuCau = new LichSuThongBao();
            // Xác định vị trí xuất hiện trên form TrangChu
            lichSuYeuCau.StartPosition = FormStartPosition.Manual;
            lichSuYeuCau.Left = this.Left + 263;
            lichSuYeuCau.Top = this.Top + 105;
            // Ẩn tất cả các form khác trừ form TrangChu
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name != "TrangChu")
                {
                    frm.Hide();
                }
            }
            lichSuYeuCau.Show();
        }

        private void button2TraCuu_Click(object sender, EventArgs e)
        {
            QuanLyPhanMem chiTietPhanMem = new QuanLyPhanMem();
            // Xác định vị trí xuất hiện trên form TrangChu
            chiTietPhanMem.StartPosition = FormStartPosition.Manual;
            chiTietPhanMem.Left = this.Left + 263;
            chiTietPhanMem.Top = this.Top + 105;
            // Ẩn tất cả các form khác trừ form TrangChu
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name != "TrangChu")
                {
                    frm.Hide();
                }
            }
            chiTietPhanMem.Show();
        }

        private void button3ADMIN_Click_1(object sender, EventArgs e)
        {
            YeuCauThietBi chiTietPhanMem = new YeuCauThietBi();
            // Xác định vị trí xuất hiện trên form TrangChu
            chiTietPhanMem.StartPosition = FormStartPosition.Manual;
            chiTietPhanMem.Left = this.Left + 263;
            chiTietPhanMem.Top = this.Top + 105;
            // Ẩn tất cả các form khác trừ form TrangChu
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name != "TrangChu")
                {
                    frm.Hide();
                }
            }
            chiTietPhanMem.Show();
        }

        private void button_QLTKADMIN_Click(object sender, EventArgs e)
        {
            if (DangNhap.loaiTaiKhoan != "QuanLy") { MessageBox.Show("Chỉ Admin mới được quyền truy cập"); }
            else MessageBox.Show("!!!!!!!!!!!!!!!!!!!!");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1YeuCau_Click(object sender, EventArgs e)
        {
            YeuCauThietBi yeuCauThietBi = new YeuCauThietBi();
            // Xác định vị trí xuất hiện trên form TrangChu
            yeuCauThietBi.StartPosition = FormStartPosition.Manual;
            yeuCauThietBi.Left = this.Left + 263;
            yeuCauThietBi.Top = this.Top + 105;
            // Ẩn tất cả các form khác trừ form TrangChu
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name != "TrangChu")
                {
                    frm.Hide();
                }
            }
            yeuCauThietBi.Show();
        }

        private void btn_baocao_Click(object sender, EventArgs e)
        {
            if (DangNhap.loaiTaiKhoan == "NhanVien")
            {
                Baocaothietbi baocaothietbi = new Baocaothietbi();
                baocaothietbi.StartPosition = FormStartPosition.Manual;
                baocaothietbi.Left = this.Left + 263;
                baocaothietbi.Top = this.Top + 105;
                // Ẩn tất cả các form khác trừ form TrangChu
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name != "TrangChu")
                    {
                        frm.Hide();
                    }
                }
                baocaothietbi.Show();
            }
            else
                MessageBox.Show("Không được quyền truy cập");
        }

        private void pictureBox4_Click_1(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
            {
                connection.Open();

                string selectQuery = "SELECT PhongHoc.MaPhongHoc, COUNT(*) AS ThietBiCanSuaChua " +
                                     "FROM ThietBi " +
                                     "JOIN PhongHoc ON ThietBi.MaPhongHoc = PhongHoc.MaPhongHoc " +
                                     "JOIN Tang ON PhongHoc.MaTang = Tang.MaTang " +
                                     "JOIN ToaNha ON Tang.MaToaNha = ToaNha.MaToaNha " +
                                     "JOIN QuyenTruyCapNV ON ToaNha.MaToaNha = QuyenTruyCapNV.MaToaNha " +
                                     "WHERE QuyenTruyCapNV.TenTaiKhoan = @TenTaiKhoan " +
                                     "      AND ThietBi.TinhTrang <> N'Hoạt Động' " +
                                     "GROUP BY PhongHoc.MaPhongHoc";

                SqlCommand selectCommand = new SqlCommand(selectQuery, connection);
                selectCommand.Parameters.AddWithValue("@TenTaiKhoan", DangNhap.TenDangNhap);

                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand);
                DataTable dataTable = new DataTable();
                dataAdapter.Fill(dataTable);

                dataGridView1.DataSource = dataTable;

                connection.Close();
            }
            dataGridView1.Visible = !dataGridView1.Visible;

        }
    }
}
