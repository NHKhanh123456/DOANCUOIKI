using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class HoaDon : Form
    {


        public HoaDon()
        {
            InitializeComponent();

            // Tạo DataGridView nếu chưa có
            dtr2 = new DataGridView
            {
                Dock = DockStyle.Fill,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            };

            // Thêm các cột vào dtr2
            dtr2.Columns.Add("MaKH", "Mã KH");
            dtr2.Columns.Add("Hoten", "Họ tên");
            dtr2.Columns.Add("Sdt", "SĐT");
            dtr2.Columns.Add("CCCD", "CCCD");
            dtr2.Columns.Add("Sophong", "Số phòng");
            dtr2.Columns.Add("Ngaynhan", "Ngày nhận");
            dtr2.Columns.Add("Maphong", "Mã phòng");
            dtr2.Columns.Add("Ngaytra", "Ngày trả");
            dtr2.Columns.Add("TotalCost", "Total Cost"); // Thêm cột TotalCost

            this.Controls.Add(dtr2); // Thêm dtr2 vào form nếu chưa có
        }

        public void SetData(DataGridView dataGridView1, string totalCost)
        {
           // dtr2.Rows.Clear(); // Xóa tất cả các hàng hiện có

            // Kiểm tra cột TotalCost
            int totalCostColumnIndex = dtr2.Columns["TotalCost"].Index;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.IsNewRow) continue; // Bỏ qua hàng mới không có dữ liệu

                DataGridViewRow newRow = (DataGridViewRow)row.Clone();
                for (int i = 0; i < row.Cells.Count; i++)
                {
                    newRow.Cells[i].Value = row.Cells[i].Value;
                }

                // Đảm bảo rằng cột TotalCost tồn tại và thêm giá trị vào cột đó
                if (totalCostColumnIndex >= 0 && totalCostColumnIndex < newRow.Cells.Count)
                {
                    newRow.Cells[totalCostColumnIndex].Value = totalCost;
                }
                else
                {
                    // Handle the error: index is out of range
                    MessageBox.Show("Column index is out of range.");
                }
                dtr2.Rows.Add(newRow);
            }
        }
    }
}