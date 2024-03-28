using LiveCharts;
using LiveCharts.Wpf;
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

namespace ManHinhChinh.Baocao
{
    public partial class Baocaothietbi : Form
    {
        public Baocaothietbi()
        {
            InitializeComponent();
        }

        private void Baocaothietbi_Load(object sender, EventArgs e)
        {
            string query = "SELECT " +
                    "LEFT(MaPhongHoc, 2) AS MaPhongHoc, " +
                    "SUM(CASE WHEN TinhTrang = N'Hoạt động' THEN 1 ELSE 0 END) AS SoLuongHoatDong, " +
                    "SUM(CASE WHEN TinhTrang = N'Bảo trì' THEN 1 ELSE 0 END) AS SoLuongBaoTri, " +
                    "SUM(CASE WHEN TinhTrang = N'Sửa chữa' THEN 1 ELSE 0 END) AS SoLuongSuaChua, " +
                    "SUM(CASE WHEN TinhTrang = N'Warning' THEN 1 ELSE 0 END) AS SoLuongWarning " +
                    "FROM ThietBi " +
                    "WHERE MaPhongHoc LIKE 'B1%' OR MaPhongHoc LIKE 'B2%' OR MaPhongHoc LIKE 'N1%' " +
                    "GROUP BY LEFT(MaPhongHoc, 2);";

            using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                System.Data.DataTable dataTable = new System.Data.DataTable();
                adapter.Fill(dataTable);

                // Hiển thị dữ liệu trong DataGridView
                dataGridView_baocao.DataSource = dataTable;

                // Đặt tiêu đề cho các cột
                if (dataGridView_baocao.Columns.Count >= 5) // Kiểm tra số lượng cột trước khi đặt tiêu đề
                {
                    dataGridView_baocao.Columns[0].HeaderText = "Toà Nhà";
                    dataGridView_baocao.Columns[1].HeaderText = "Số Lượng Hoạt Động";
                    dataGridView_baocao.Columns[2].HeaderText = "Số Lượng Bảo Trì";
                    dataGridView_baocao.Columns[3].HeaderText = "Số Lượng Sửa Chữa";
                    dataGridView_baocao.Columns[4].HeaderText = "Số Lượng Warning";
                }
            }

            // Báo cáo yêu cầu thiết bi
            string yeuCauQuery = "SELECT " +
                    "LEFT(MaPhongHoc, 2) AS MaPhongHoc, " +
                    "SUM(CASE WHEN TinhTrang = N'Từ chối' THEN 1 ELSE 0 END) AS TuChoi, " +
                    "SUM(CASE WHEN TinhTrang = N'Hoàn thành' THEN 1 ELSE 0 END) AS HoanThanh, " +
                    "SUM(CASE WHEN TinhTrang = N'Đã duyệt' THEN 1 ELSE 0 END) AS DaDuyet " +
                    "FROM YeuCauThietBi " +
                    "WHERE MaPhongHoc LIKE 'B1%' OR MaPhongHoc LIKE 'B2%' OR MaPhongHoc LIKE 'N1%' " +
                    "GROUP BY LEFT(MaPhongHoc, 2);";

            using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
            {
                SqlCommand command = new SqlCommand(yeuCauQuery, connection);
                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                System.Data.DataTable dataTable = new System.Data.DataTable();
                adapter.Fill(dataTable);

                // Hiển thị dữ liệu trong DataGridView
                dataGridView_baocaoyeucau.DataSource = dataTable;

                // Đặt tiêu đề cho các cột
                if (dataGridView_baocaoyeucau.Columns.Count >= 4) // Kiểm tra số lượng cột trước khi đặt tiêu đề
                {
                    dataGridView_baocaoyeucau.Columns[0].HeaderText = "Toà Nhà";
                    dataGridView_baocaoyeucau.Columns[1].HeaderText = "Từ chối";
                    dataGridView_baocaoyeucau.Columns[2].HeaderText = "Hoàn thành";
                    dataGridView_baocaoyeucau.Columns[3].HeaderText = "Đã duyệt";
                }
            }
        }

        private void dataGridView_baocao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có phải là dòng tiêu đề không
            if (e.RowIndex >= 0)
            {
                // Lấy dữ liệu từ hàng được chọn
                DataGridViewRow selectedRow = dataGridView_baocao.Rows[e.RowIndex];

                // Lấy mã phòng học từ cột "Mã Phòng Học"
                string maPhongHoc = selectedRow.Cells[0].Value.ToString();

                // Tạo truy vấn SQL để lấy số liệu theo mã phòng học
                string query = "SELECT " +
                               "SUM(CASE WHEN TinhTrang = N'Hoạt động' THEN 1 ELSE 0 END) AS SoLuongHoatDong, " +
                               "SUM(CASE WHEN TinhTrang = N'Bảo trì' THEN 1 ELSE 0 END) AS SoLuongBaoTri, " +
                               "SUM(CASE WHEN TinhTrang = N'Warning' THEN 1 ELSE 0 END) AS SoLuongWarning, " +
                               "SUM(CASE WHEN TinhTrang = N'Sửa chữa' THEN 1 ELSE 0 END) AS SoLuongSuaChua " +
                               "FROM ThietBi " +
                               $"WHERE MaPhongHoc LIKE '{maPhongHoc}%'";

                // Thực hiện truy vấn và lấy dữ liệu từ cơ sở dữ liệu
                using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                {
                    SqlCommand command = new SqlCommand(query, connection);
                    connection.Open();
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.Read()) // Đảm bảo có dữ liệu trả về từ truy vấn
                    {
                        int soLuongHoatDong = Convert.ToInt32(reader["SoLuongHoatDong"]);
                        int soLuongBaoTri = Convert.ToInt32(reader["SoLuongBaoTri"]);
                        int soLuongSuaChua = Convert.ToInt32(reader["SoLuongSuaChua"]);
                        int soLuongWarning = Convert.ToInt32(reader["SoLuongWarning"]);

                        // Tạo tiêu đề động
                        string title = $"Báo cáo thiết bị ở Toà {maPhongHoc}";

                        // Cập nhật dữ liệu cho biểu đồ tròn
                        pieChart.Series = new SeriesCollection
                        {
                            new PieSeries
                            {
                                Title = "Hoạt Động",
                                Values = new ChartValues<int> { soLuongHoatDong },
                                PushOut = 15,
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = "Bảo Trì",
                                Values = new ChartValues<int> { soLuongBaoTri },
                                PushOut = 15,
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = "Sửa Chữa",
                                Values = new ChartValues<int> { soLuongSuaChua },
                                PushOut = 15,
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = "Warning",
                                Values = new ChartValues<int> { soLuongWarning },
                                PushOut = 15,
                                DataLabels = true
                            }
                        };
                        lbl_tenbieudo.Text = title;
                    }
                    else
                    {
                        MessageBox.Show("Không có dữ liệu cho mã phòng học này.");
                    }
                }
            }
        }

        private void dataGridView_baocaoyeucau_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                // Kiểm tra xem có phải là dòng tiêu đề không
                if (e.RowIndex >= 0)
                {
                    // Lấy dữ liệu từ hàng được chọn
                    DataGridViewRow selectedRow = dataGridView_baocao.Rows[e.RowIndex];



                    // Lấy mã phòng học từ cột "Mã Phòng Học"
                    string maPhongHoc = selectedRow.Cells[0].Value.ToString();

                    // Tạo truy vấn SQL để lấy số liệu theo mã phòng học
                    string query = "SELECT " +
                                   "SUM(CASE WHEN TinhTrang = N'Từ chối' THEN 1 ELSE 0 END) AS TuChoi, " +
                                   "SUM(CASE WHEN TinhTrang = N'Hoàn thành' THEN 1 ELSE 0 END) AS HoanThanh, " +
                                   "SUM(CASE WHEN TinhTrang = N'Đã duyệt' THEN 1 ELSE 0 END) AS DaDuyet " +
                                   "FROM YeuCauThietBi " +
                                   $"WHERE MaPhongHoc LIKE '{maPhongHoc}%'";

                    // Thực hiện truy vấn và lấy dữ liệu từ cơ sở dữ liệu
                    using (SqlConnection connection = new SqlConnection(Connection.stringConnection))
                    {
                        SqlCommand command = new SqlCommand(query, connection);
                        connection.Open();
                        SqlDataReader reader = command.ExecuteReader();

                        if (reader.Read()) // Đảm bảo có dữ liệu trả về từ truy vấn
                        {
                            int soLuongHoatDong = Convert.ToInt32(reader["TuChoi"]);
                            int soLuongBaoTri = Convert.ToInt32(reader["HoanThanh"]);
                            int soLuongSuaChua = Convert.ToInt32(reader["DaDuyet"]);

                            // Tạo tiêu đề động
                            string title = $"Báo cáo yêu cầu thiết bị ở phòng {maPhongHoc}";

                            // Cập nhật dữ liệu cho biểu đồ tròn
                            pieChart_yeucau.Series = new SeriesCollection
                        {
                            new PieSeries
                            {
                                Title = "Đang chờ xử lý",
                                Values = new ChartValues<int> { soLuongHoatDong },
                                PushOut = 15,
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = "Đã xử lý",
                                Values = new ChartValues<int> { soLuongBaoTri },
                                PushOut = 15,
                                DataLabels = true
                            },
                            new PieSeries
                            {
                                Title = "Đã hủy yêu cầu",
                                Values = new ChartValues<int> { soLuongSuaChua },
                                PushOut = 15,
                                DataLabels = true
                            }
                        };
                            lbl_tenbieudo.Text = title;
                        }
                        else
                        {
                            MessageBox.Show("Không có dữ liệu cho mã phòng học này.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
