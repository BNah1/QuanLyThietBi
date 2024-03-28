namespace ManHinhChinh.Baocao
{
    partial class Baocaothietbi
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Baocaothietbi));
            lbl_baocao = new Label();
            dataGridView_baocao = new DataGridView();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            pictureBox2 = new PictureBox();
            lbl_tenbieudo = new Label();
            pieChart = new LiveCharts.WinForms.PieChart();
            tabPage2 = new TabPage();
            dataGridView_baocaoyeucau = new DataGridView();
            pieChart_yeucau = new LiveCharts.WinForms.PieChart();
            lbl_baocaoyeucau = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView_baocao).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_baocaoyeucau).BeginInit();
            SuspendLayout();
            // 
            // lbl_baocao
            // 
            lbl_baocao.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_baocao.Location = new Point(232, 27);
            lbl_baocao.Name = "lbl_baocao";
            lbl_baocao.Size = new Size(439, 51);
            lbl_baocao.TabIndex = 1;
            lbl_baocao.Text = "Báo cáo tình trạng thiết bị";
            lbl_baocao.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dataGridView_baocao
            // 
            dataGridView_baocao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_baocao.Location = new Point(9, 108);
            dataGridView_baocao.Margin = new Padding(3, 4, 3, 4);
            dataGridView_baocao.Name = "dataGridView_baocao";
            dataGridView_baocao.RowHeadersWidth = 51;
            dataGridView_baocao.Size = new Size(573, 215);
            dataGridView_baocao.TabIndex = 2;
            dataGridView_baocao.CellClick += dataGridView_baocao_CellClick;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(914, 600);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(pictureBox2);
            tabPage1.Controls.Add(lbl_tenbieudo);
            tabPage1.Controls.Add(pieChart);
            tabPage1.Controls.Add(lbl_baocao);
            tabPage1.Controls.Add(dataGridView_baocao);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Margin = new Padding(3, 4, 3, 4);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 4, 3, 4);
            tabPage1.Size = new Size(906, 567);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Báo cáo thiết bị";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(208, 21);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(86, 79);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 46;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // lbl_tenbieudo
            // 
            lbl_tenbieudo.AutoSize = true;
            lbl_tenbieudo.Location = new Point(631, 371);
            lbl_tenbieudo.Name = "lbl_tenbieudo";
            lbl_tenbieudo.Size = new Size(0, 20);
            lbl_tenbieudo.TabIndex = 4;
            // 
            // pieChart
            // 
            pieChart.Location = new Point(579, 108);
            pieChart.Margin = new Padding(3, 4, 3, 4);
            pieChart.Name = "pieChart";
            pieChart.Size = new Size(288, 243);
            pieChart.TabIndex = 3;
            pieChart.Text = "pieChart1";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dataGridView_baocaoyeucau);
            tabPage2.Controls.Add(pieChart_yeucau);
            tabPage2.Controls.Add(lbl_baocaoyeucau);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Margin = new Padding(3, 4, 3, 4);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 4, 3, 4);
            tabPage2.Size = new Size(906, 567);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Báo cáo yêu cầu";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView_baocaoyeucau
            // 
            dataGridView_baocaoyeucau.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_baocaoyeucau.Location = new Point(26, 124);
            dataGridView_baocaoyeucau.Margin = new Padding(3, 4, 3, 4);
            dataGridView_baocaoyeucau.Name = "dataGridView_baocaoyeucau";
            dataGridView_baocaoyeucau.RowHeadersWidth = 51;
            dataGridView_baocaoyeucau.Size = new Size(466, 209);
            dataGridView_baocaoyeucau.TabIndex = 2;
            dataGridView_baocaoyeucau.CellClick += dataGridView_baocaoyeucau_CellClick;
            // 
            // pieChart_yeucau
            // 
            pieChart_yeucau.Location = new Point(583, 124);
            pieChart_yeucau.Margin = new Padding(3, 4, 3, 4);
            pieChart_yeucau.Name = "pieChart_yeucau";
            pieChart_yeucau.Size = new Size(281, 209);
            pieChart_yeucau.TabIndex = 1;
            pieChart_yeucau.Text = "pieChart1";
            // 
            // lbl_baocaoyeucau
            // 
            lbl_baocaoyeucau.AutoSize = true;
            lbl_baocaoyeucau.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_baocaoyeucau.Location = new Point(317, 21);
            lbl_baocaoyeucau.Name = "lbl_baocaoyeucau";
            lbl_baocaoyeucau.Size = new Size(287, 32);
            lbl_baocaoyeucau.TabIndex = 0;
            lbl_baocaoyeucau.Text = "Báo cáo yêu cầu thiết bị";
            // 
            // Baocaothietbi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 548);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Baocaothietbi";
            Text = "Báo cáo";
            Load += Baocaothietbi_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView_baocao).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_baocaoyeucau).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label lbl_baocao;
        private DataGridView dataGridView_baocao;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private LiveCharts.WinForms.PieChart pieChart;
        private Label lbl_tenbieudo;
        private DataGridView dataGridView_baocaoyeucau;
        private LiveCharts.WinForms.PieChart pieChart_yeucau;
        private Label lbl_baocaoyeucau;
        private PictureBox pictureBox2;
    }
}