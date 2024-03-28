using Form_DangNhap_Dangky_QMK;
using ManHinhChinh.Baocao;
using ManHinhChinh.QuanLyThietBivaPhanMem;
using ManHinhChinh.TaiKhoan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp7;
using WinFormsApp1;

namespace ManHinhChinh
{
    public partial class TrangAdmin : Form
    {
        public TrangAdmin()
        {
            InitializeComponent();
        }

        private void TrangAdmin_Load(object sender, EventArgs e)
        {

        }

        private void button_Doimatkhau_Click(object sender, EventArgs e)
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
                if (frm.Name != "TrangAdmin")
                {
                    frm.Hide();
                }
            }
            // Hiển thị form DoiMatKhau
            doiMatKhau.Show();
        }

        private void button1TraCuu_Click(object sender, EventArgs e)
        {
            ChiTietThietBi_Form chiTietThietBi = new ChiTietThietBi_Form();
            // Xác định vị trí xuất hiện trên form TrangChu
            chiTietThietBi.StartPosition = FormStartPosition.Manual;
            chiTietThietBi.Left = this.Left + 263;
            chiTietThietBi.Top = this.Top + 105;
            // Ẩn tất cả các form khác trừ form TrangChu
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name != "TrangAdmin")
                {
                    frm.Hide();
                }
            }
            chiTietThietBi.Show();
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
                if (frm.Name != "TrangAdmin")
                {
                    frm.Hide();
                }
            }
            chiTietPhanMem.Show();
        }

        private void button3ADMIN_Click(object sender, EventArgs e)
        {
            if (DangNhap.loaiTaiKhoan != "QuanLy") { MessageBox.Show("Chỉ Admin mới được quyền truy cập"); }
            else
            {
                TongHopYeuCau tongHopYeuCau = new TongHopYeuCau();
                // Xác định vị trí xuất hiện trên form TrangChu
                tongHopYeuCau.StartPosition = FormStartPosition.Manual;
                tongHopYeuCau.Left = this.Left + 263;
                tongHopYeuCau.Top = this.Top + 105;
                // Ẩn tất cả các form khác trừ form TrangChu
                foreach (Form frm in Application.OpenForms)
                {
                    if (frm.Name != "TrangAdmin")
                    {
                        frm.Hide();
                    }
                }
                tongHopYeuCau.Show();
            };
        }

        private void button_QLTKADMIN_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            QuanLyTaiKhoan quanLyTaiKhoan = new QuanLyTaiKhoan();
            // Xác định vị trí xuất hiện trên form TrangChu
            quanLyTaiKhoan.StartPosition = FormStartPosition.Manual;
            quanLyTaiKhoan.Left = this.Left + 263;
            quanLyTaiKhoan.Top = this.Top + 105;
            // Ẩn tất cả các form khác trừ form TrangChu
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name != "TrangAdmin")
                {
                    frm.Hide();
                }
            }
            quanLyTaiKhoan.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Khởi tạo form
            QuyenTruyCap quyenTruyCap = new QuyenTruyCap();

            // Xác định vị trí xuất hiện trên form TrangChu
            quyenTruyCap.StartPosition = FormStartPosition.Manual;
            quyenTruyCap.Left = this.Left + 263;
            quyenTruyCap.Top = this.Top + 105;
            // Ẩn tất cả các form khác trừ form TrangChu
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name != "TrangAdmin")
                {
                    frm.Hide();
                }
            }
            // Hiển thị form thongTinCaNhan
            quyenTruyCap.Show();
        }

        private void button_Dangxuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Khởi tạo form 
            DangNhap dangNhap = new DangNhap();

            // Hiển thị form 
            dangNhap.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Khởi tạo form
            Baocaothietbi baocao = new Baocaothietbi();
            // Xác định vị trí xuất hiện trên form TrangChu
            baocao.StartPosition = FormStartPosition.Manual;
            baocao.Left = this.Left + 263;
            baocao.Top = this.Top + 105;
            // Ẩn tất cả các form khác trừ form TrangChu
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name != "TrangAdmin")
                {
                    frm.Hide();
                }
            }
            // Hiển thị form thongTinCaNhan
            baocao.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
