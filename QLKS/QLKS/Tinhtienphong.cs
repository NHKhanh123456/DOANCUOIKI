using BLL;
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
using System.IO;
using DataAccess;



namespace QLKS
{
    public partial class Tinhtienphong : Form
    {
        public Tinhtienphong()
        {
            InitializeComponent();
            LoadRoomCodesIntoComboBox();
        }
        Phong ph = new Phong();

        private void Tinhtienphong_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyKSDataSet2.PHONG' table. You can move, or remove it, as needed.
            this.pHONGTableAdapter1.Fill(this.quanLyKSDataSet2.PHONG);
            // TODO: This line of code loads data into the 'quanLyKSDataSet1.PHONG' table. You can move, or remove it, as needed.
            this.pHONGTableAdapter.Fill(this.quanLyKSDataSet1.PHONG);
            DataTable dt = new DataTable();
            dt = ph.ShowPhong();
            dtr1.DataSource = dt;


        }



        private void cbmaphong_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void LoadRoomCodesIntoComboBox()
        {
            // Chuỗi kết nối tới SQL Server (thay đổi cho phù hợp với cơ sở dữ liệu của bạn)
            string connectionString = "Data Source=DESKTOP-9USMO8F\\SQLEXPRESS;Initial Catalog=QuanLyKS;Integrated Security=True;TrustServerCertificate=True";

            // Câu truy vấn SQL để lấy danh sách mã phòng
            string query = "SELECT Maphong FROM dbo.PHONG";

            try
            {
                // Tạo kết nối tới SQL Server
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Mở kết nối
                    connection.Open();

                    // Tạo SqlCommand với câu truy vấn và kết nối
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thực thi truy vấn và đọc kết quả
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Xóa các mục hiện có trong ComboBox
                            cbmaphong.Items.Clear();

                            // Đọc từng dòng kết quả và thêm mã phòng vào ComboBox
                            while (reader.Read())
                            {
                                string maPhong = reader["Maphong"].ToString();
                                cbmaphong.Items.Add(maPhong);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi kết nối hoặc truy vấn
                MessageBox.Show("Lỗi khi tải mã phòng: " + ex.Message);
            }
        }



        private void txthoten_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btntkmaphong_Click(object sender, EventArgs e)
        {

            // ShowUnitPrice(selectedRoomCode);

            string selectedRoomCode = cbmaphong.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedRoomCode))
            {
                MessageBox.Show("Vui lòng chọn mã phòng!");
                return;
            }

            string connectionString = "Data Source=DESKTOP-9USMO8F\\SQLEXPRESS;Initial Catalog=QuanLyKS;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string query = @"
                SELECT MaKH, Hoten, Sdt, CCCD, Sophong, Ngaynhan, Maphong, Ngaytra
                FROM dbo.KHACHHANG
                WHERE Maphong = @Maphong";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Maphong", selectedRoomCode);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        dtr1.DataSource = dt;

                        // Tính số ngày ở
                        DateTime ngayNhan = Convert.ToDateTime(dt.Rows[0]["Ngaynhan"]);
                        DateTime ngayTra = Convert.ToDateTime(dt.Rows[0]["Ngaytra"]);
                        int soNgay = (ngayTra - ngayNhan).Days;
                        tbsongay.Text = soNgay.ToString();

                        



                        // Lấy giá tiền từ bảng PHONG
                        string roomPriceQuery = "SELECT Dongia FROM dbo.PHONG WHERE Maphong = @Maphong";
                        using (SqlCommand priceCmd = new SqlCommand(roomPriceQuery, conn))
                        {
                            priceCmd.Parameters.AddWithValue("@Maphong", selectedRoomCode);
                            object roomPriceObj = priceCmd.ExecuteScalar();

                            if (roomPriceObj != null)
                            {
                                decimal roomPrice = Convert.ToDecimal(roomPriceObj);
                                decimal thanhTien = soNgay * roomPrice;
                                tbthanhtien.Text = $"{thanhTien} VND";
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy giá phòng.");
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy khách hàng nào với mã phòng này.");
                    }
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            // Đường dẫn tới hóa đơn
            string filePath = @"D:\3PLAYERS\invoice.txt";

            StringBuilder sb = new StringBuilder();

            // Add header
            sb.AppendLine("*****HÓA ĐƠN*****");
            sb.AppendLine("------------------------------");

            // Determine the maximum width of each column
            int[] columnWidths = new int[dtr1.Columns.Count];
            for (int i = 0; i < dtr1.Columns.Count; i++)
            {
                columnWidths[i] = dtr1.Columns[i].HeaderText.Length;
            }

            foreach (DataGridViewRow row in dtr1.Rows)
            {
                if (!row.IsNewRow) // Skip new row placeholder
                {
                    for (int i = 0; i < dtr1.Columns.Count; i++)
                    {
                        // Update the maximum column width based on cell content
                        int cellWidth = row.Cells[i].Value?.ToString().Length ?? 0;
                        if (cellWidth > columnWidths[i])
                        {
                            columnWidths[i] = cellWidth;
                        }
                    }
                }
            }

            // Add column headers with padding
            sb.AppendLine(string.Join(" | ", dtr1.Columns.Cast<DataGridViewColumn>()
                                        .Select((c, i) => c.HeaderText.PadRight(columnWidths[i]))));

            sb.AppendLine(new string('-', columnWidths.Sum() + 3 * (dtr1.Columns.Count - 1)));

            // Add row data with padding
            foreach (DataGridViewRow row in dtr1.Rows)
            {
                if (!row.IsNewRow) // Skip new row placeholder
                {
                    sb.AppendLine(string.Join(" | ", row.Cells.Cast<DataGridViewCell>()
                                            .Select((c, i) => (c.Value?.ToString() ?? "").PadRight(columnWidths[i]))));
                }
            }

            // Add total amount from the TextBox
            sb.AppendLine("------------------------------");
            sb.AppendLine("Tổng tiền: " + tbthanhtien.Text.PadRight(columnWidths.Max()));

            // Write the content to a text file
            try
            {
                File.WriteAllText(filePath, sb.ToString());
                // Notify the user that the file has been created
                MessageBox.Show("Hóa đơn đã được xuất ra file: " + filePath);
            }
            catch (Exception ex)
            {
                // Handle exceptions, e.g., file access issues
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbsongay_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
        private void Showdongia(string roomCode)
        {
            string query = "SELECT Dongia FROM dbo.PHONG WHERE Maphong = @Maphong";

            using (SqlConnection connection = new SqlConnection(@"Data Source = DESKTOP - 9USMO8F\SQLEXPRESS; Initial Catalog = QuanLyKS; Integrated Security = True; TrustServerCertificate = True"))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Maphong", roomCode);

                try
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result != null)
                    {
                        decimal donGia = Convert.ToDecimal(result);
                        tbDongia.Text = donGia.ToString("C"); 
                    }
                    else
                    {
                        tbDongia.Text = "Không tìm thấy";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
                }
            }
        }
    }
}