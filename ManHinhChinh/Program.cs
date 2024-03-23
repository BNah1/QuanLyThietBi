using Form_DangNhap_Dangky_QMK;
using ManHinhChinh.TaiKhoan;
using WindowsFormsApp7;

namespace ManHinhChinh
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new DangNhap());
        }
    }
}