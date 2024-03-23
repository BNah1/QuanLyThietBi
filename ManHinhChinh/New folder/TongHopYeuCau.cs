using ManHinhChinh.XuLy;
using System;
using System.Data;
using System.Data.SqlClient;
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

        private void InitializeDataGridView()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("Mã yêu cầu", typeof(string));
            dataTable.Columns.Add("Tên thiết bị", typeof(string));
            dataTable.Columns.Add("Mã phòng học", typeof(string));
            dataTable.Columns.Add("Tình trạng", typeof(string));
            dataTable.Columns.Add("Ngày yêu cầu", typeof(DateTime));
            dataTable.Columns.Add("Window", typeof(string));
            dataTable.Columns.Add("Phần cứng 1", typeof(string));
            dataTable.Columns.Add("Phần cứng 2", typeof(string));
            dataTable.Columns.Add("Phần cứng 3", typeof(string));
            dataTable.Columns.Add("Tên phần mềm", typeof(string));
            dataTable.Columns.Add("Tài khoản yêu cầu", typeof(string));
          
            dataGridView1.DataSource = dataTable;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeDataGridView();
            try
            {
                using (sqlConn = new SqlConnection(connectionString))
                {
                    sqlConn.Open();
                    string query = @"SELECT * FROM YeuCauThietBi ";

                    using (SqlCommand command = new SqlCommand(query, sqlConn))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable tempTable = new DataTable();
                        adapter.Fill(tempTable);

                        // Gán dữ liệu từ tempTable vào dataTable
                        foreach (DataRow row in tempTable.Rows)
                        {
                            dataTable.Rows.Add(row.ItemArray);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (sqlConn != null && sqlConn.State == ConnectionState.Open)
                {
                    sqlConn.Close();
                }
            }
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string currentStatus = selectedRow.Cells["Tình trạng"].Value.ToString();

                
                if (currentStatus == "Cho xu ly" || currentStatus == "Tu choi")
                {
                    
                    button1.Enabled = true;
                    button4.Enabled = false;
                }
                else if (currentStatus == "Duyet")
                {
                    
                    button4.Enabled = true;
                    button1.Enabled = false;
                }
               
            }
            else
            {
                
                button1.Enabled = false; 
                button4.Enabled = false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
               
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string currentStatus = selectedRow.Cells["Tình trạng"].Value.ToString();
                
                    
                    selectedRow.Cells["Tình trạng"].Value = "Duyet";
                    button1.Enabled = false; 
                    button4.Enabled = true;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để thay đổi tình trạng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (sqlConn = new SqlConnection(connectionString))
                {
                    sqlConn.Open();

                   
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                        
                        if (row.IsNewRow) continue;

                       
                        string maYeuCau = row.Cells["Mã yêu cầu"].Value?.ToString();

                       
                        string tinhTrang = row.Cells["Tình trạng"].Value?.ToString();

                       
                        if (maYeuCau != null && tinhTrang != null)
                        {
                           
                            string updateQuery = "UPDATE YeuCauThietBi SET TinhTrang = @TrangThai WHERE MaYeuCau = @MaYeuCau";

                           
                            using (SqlCommand command = new SqlCommand(updateQuery, sqlConn))
                            {
                                command.Parameters.AddWithValue("@TrangThai", tinhTrang);
                                command.Parameters.AddWithValue("@MaYeuCau", maYeuCau);
                                command.ExecuteNonQuery();
                            }
                        }
                    }

                    MessageBox.Show("Cập nhật  thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConn != null && sqlConn.State == ConnectionState.Open)
                {
                    sqlConn.Close();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string currentStatus = selectedRow.Cells["Tình trạng"].Value.ToString();


                selectedRow.Cells["Tình trạng"].Value = "Tu choi";
                button1.Enabled = true;
                button4.Enabled =false;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một dòng để thay đổi tình trạng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát khỏi ứng dụng không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);


            if (result == DialogResult.Yes)
            {

                this.Close();
            }

        }
    }
}
