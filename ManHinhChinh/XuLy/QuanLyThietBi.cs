namespace ManHinhChinh.XuLy
{
    internal class QuanLyThietBi
    {
        private string maThietBi;
        private string tenThietBi;
        private string maPhongHoc;
        private string tinhTrang;
        private string ngayCapNhatNV;
        private string thongBao;
        private string ngayCapNhatGV;

        public QuanLyThietBi()
        {
        }

        public QuanLyThietBi(string maThietBi, string tenThietBi, string maPhongHoc, string tinhTrang, string ngayCapNhatNV, string thongBao, string ngayCapNhatGV)
        {
            MaThietBi = maThietBi;
            TenThietBi = tenThietBi;
            MaPhongHoc = maPhongHoc;
            TinhTrang = tinhTrang;
            NgayCapNhatNV = ngayCapNhatNV;
            ThongBao = thongBao;
            NgayCapNhatGV = ngayCapNhatGV;
        }

        public string MaThietBi { get => maThietBi; set => maThietBi = value; }
        public string TenThietBi { get => tenThietBi; set => tenThietBi = value; }
        public string MaPhongHoc { get => maPhongHoc; set => maPhongHoc = value; }
        public string TinhTrang { get => tinhTrang; set => tinhTrang = value; }
        public string NgayCapNhatNV { get => ngayCapNhatNV; set => ngayCapNhatNV = value; }
        public string ThongBao { get => thongBao; set => thongBao = value; }
        public string NgayCapNhatGV { get => ngayCapNhatGV; set => ngayCapNhatGV = value; }
    }
}
