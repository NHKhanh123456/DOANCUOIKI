namespace QLKS
{
    partial class Tinhtienphong
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
            this.components = new System.ComponentModel.Container();
            this.dtr1 = new System.Windows.Forms.DataGridView();
            this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hoten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCCD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sophong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaynhan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Maphong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ngaytra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btntkmaphong = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cbmaphong = new System.Windows.Forms.ComboBox();
            this.lbl = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnghd = new System.Windows.Forms.Button();
            this.tbthanhtien = new System.Windows.Forms.TextBox();
            this.tbsongay = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.quanLyKSDataSet1 = new QLKS.QuanLyKSDataSet1();
            this.pHONGBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pHONGTableAdapter = new QLKS.QuanLyKSDataSet1TableAdapters.PHONGTableAdapter();
            this.quanLyKSDataSet2 = new QLKS.QuanLyKSDataSet2();
            this.pHONGBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.pHONGTableAdapter1 = new QLKS.QuanLyKSDataSet2TableAdapters.PHONGTableAdapter();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbldongia = new System.Windows.Forms.Label();
            this.tbDongia = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtr1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKSDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKSDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dtr1
            // 
            this.dtr1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtr1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.Hoten,
            this.Sdt,
            this.CCCD,
            this.Sophong,
            this.Ngaynhan,
            this.Maphong,
            this.Ngaytra});
            this.dtr1.Location = new System.Drawing.Point(25, 30);
            this.dtr1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtr1.Name = "dtr1";
            this.dtr1.RowHeadersWidth = 51;
            this.dtr1.RowTemplate.Height = 24;
            this.dtr1.Size = new System.Drawing.Size(1034, 154);
            this.dtr1.TabIndex = 0;
            this.dtr1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // MaKH
            // 
            this.MaKH.DataPropertyName = "MaKH";
            this.MaKH.HeaderText = "Mã KH";
            this.MaKH.MinimumWidth = 6;
            this.MaKH.Name = "MaKH";
            this.MaKH.Width = 125;
            // 
            // Hoten
            // 
            this.Hoten.DataPropertyName = "Hoten";
            this.Hoten.HeaderText = "Họ tên";
            this.Hoten.MinimumWidth = 6;
            this.Hoten.Name = "Hoten";
            this.Hoten.Width = 125;
            // 
            // Sdt
            // 
            this.Sdt.DataPropertyName = "Sdt";
            this.Sdt.HeaderText = "Số ĐT";
            this.Sdt.MinimumWidth = 6;
            this.Sdt.Name = "Sdt";
            this.Sdt.Width = 125;
            // 
            // CCCD
            // 
            this.CCCD.DataPropertyName = "CCCD";
            this.CCCD.HeaderText = "CCCD";
            this.CCCD.MinimumWidth = 6;
            this.CCCD.Name = "CCCD";
            this.CCCD.Width = 125;
            // 
            // Sophong
            // 
            this.Sophong.DataPropertyName = "Sophong";
            this.Sophong.HeaderText = "Số phòng";
            this.Sophong.MinimumWidth = 6;
            this.Sophong.Name = "Sophong";
            this.Sophong.Width = 125;
            // 
            // Ngaynhan
            // 
            this.Ngaynhan.DataPropertyName = "Ngaynhan";
            this.Ngaynhan.HeaderText = "Ngày nhận";
            this.Ngaynhan.MinimumWidth = 6;
            this.Ngaynhan.Name = "Ngaynhan";
            this.Ngaynhan.Width = 125;
            // 
            // Maphong
            // 
            this.Maphong.DataPropertyName = "Maphong";
            this.Maphong.HeaderText = "Mã phòng";
            this.Maphong.MinimumWidth = 6;
            this.Maphong.Name = "Maphong";
            this.Maphong.Width = 125;
            // 
            // Ngaytra
            // 
            this.Ngaytra.DataPropertyName = "Ngaytra";
            this.Ngaytra.HeaderText = "Ngày trả";
            this.Ngaytra.MinimumWidth = 6;
            this.Ngaytra.Name = "Ngaytra";
            this.Ngaytra.Width = 125;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dtr1);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(20, 349);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox3.Size = new System.Drawing.Size(1077, 202);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Chi Tiết Khách Hàng Thanh Toán";
            // 
            // btntkmaphong
            // 
            this.btntkmaphong.Location = new System.Drawing.Point(267, 45);
            this.btntkmaphong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btntkmaphong.Name = "btntkmaphong";
            this.btntkmaphong.Size = new System.Drawing.Size(157, 27);
            this.btntkmaphong.TabIndex = 3;
            this.btntkmaphong.Text = "Tìm kiếm";
            this.btntkmaphong.UseVisualStyleBackColor = true;
            this.btntkmaphong.Click += new System.EventHandler(this.btntkmaphong_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 88);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 0;
            // 
            // btnthoat
            // 
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.Location = new System.Drawing.Point(951, 565);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(95, 36);
            this.btnthoat.TabIndex = 3;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(29, 30);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(233, 25);
            this.label7.TabIndex = 0;
            this.label7.Text = "Số ngày khách hàng ở:";
            // 
            // cbmaphong
            // 
            this.cbmaphong.FormattingEnabled = true;
            this.cbmaphong.Location = new System.Drawing.Point(147, 46);
            this.cbmaphong.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbmaphong.Name = "cbmaphong";
            this.cbmaphong.Size = new System.Drawing.Size(92, 24);
            this.cbmaphong.TabIndex = 1;
            this.cbmaphong.SelectedIndexChanged += new System.EventHandler(this.cbmaphong_SelectedIndexChanged);
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(20, 45);
            this.lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(114, 25);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Mã phòng:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbDongia);
            this.groupBox2.Controls.Add(this.lbldongia);
            this.groupBox2.Controls.Add(this.btnghd);
            this.groupBox2.Controls.Add(this.tbthanhtien);
            this.groupBox2.Controls.Add(this.tbsongay);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(530, 75);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(474, 257);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thanh Toán";
            // 
            // btnghd
            // 
            this.btnghd.Location = new System.Drawing.Point(294, 171);
            this.btnghd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnghd.Name = "btnghd";
            this.btnghd.Size = new System.Drawing.Size(117, 33);
            this.btnghd.TabIndex = 7;
            this.btnghd.Text = "Ghi Hóa Đơn";
            this.btnghd.UseVisualStyleBackColor = true;
            this.btnghd.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tbthanhtien
            // 
            this.tbthanhtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbthanhtien.Location = new System.Drawing.Point(266, 126);
            this.tbthanhtien.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbthanhtien.Name = "tbthanhtien";
            this.tbthanhtien.Size = new System.Drawing.Size(173, 26);
            this.tbthanhtien.TabIndex = 6;
            // 
            // tbsongay
            // 
            this.tbsongay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbsongay.Location = new System.Drawing.Point(266, 31);
            this.tbsongay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbsongay.Name = "tbsongay";
            this.tbsongay.Size = new System.Drawing.Size(173, 26);
            this.tbsongay.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng tiền:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "TÍNH TIỀN PHÒNG";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btntkmaphong);
            this.groupBox1.Controls.Add(this.cbmaphong);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(45, 75);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(454, 257);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm Kiếm Nhanh";
            // 
            // quanLyKSDataSet1
            // 
            this.quanLyKSDataSet1.DataSetName = "QuanLyKSDataSet1";
            this.quanLyKSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHONGBindingSource
            // 
            this.pHONGBindingSource.DataMember = "PHONG";
            this.pHONGBindingSource.DataSource = this.quanLyKSDataSet1;
            // 
            // pHONGTableAdapter
            // 
            this.pHONGTableAdapter.ClearBeforeFill = true;
            // 
            // quanLyKSDataSet2
            // 
            this.quanLyKSDataSet2.DataSetName = "QuanLyKSDataSet2";
            this.quanLyKSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pHONGBindingSource1
            // 
            this.pHONGBindingSource1.DataMember = "PHONG";
            this.pHONGBindingSource1.DataSource = this.quanLyKSDataSet2;
            // 
            // pHONGTableAdapter1
            // 
            this.pHONGTableAdapter1.ClearBeforeFill = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // lbldongia
            // 
            this.lbldongia.AutoSize = true;
            this.lbldongia.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldongia.Location = new System.Drawing.Point(29, 79);
            this.lbldongia.Name = "lbldongia";
            this.lbldongia.Size = new System.Drawing.Size(86, 25);
            this.lbldongia.TabIndex = 8;
            this.lbldongia.Text = "Đơn giá";
            // 
            // tbDongia
            // 
            this.tbDongia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDongia.Location = new System.Drawing.Point(266, 79);
            this.tbDongia.Name = "tbDongia";
            this.tbDongia.Size = new System.Drawing.Size(173, 26);
            this.tbDongia.TabIndex = 9;
            // 
            // Tinhtienphong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1111, 623);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnthoat);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Tinhtienphong";
            this.Text = "Tinhtienphong";
            this.Load += new System.EventHandler(this.Tinhtienphong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtr1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKSDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyKSDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pHONGBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtr1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btntkmaphong;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbmaphong;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private QuanLyKSDataSet1 quanLyKSDataSet1;
        private System.Windows.Forms.BindingSource pHONGBindingSource;
        private QuanLyKSDataSet1TableAdapters.PHONGTableAdapter pHONGTableAdapter;
        private QuanLyKSDataSet2 quanLyKSDataSet2;
        private System.Windows.Forms.BindingSource pHONGBindingSource1;
        private QuanLyKSDataSet2TableAdapters.PHONGTableAdapter pHONGTableAdapter1;
        private System.Windows.Forms.TextBox tbthanhtien;
        private System.Windows.Forms.TextBox tbsongay;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hoten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCCD;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sophong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaynhan;
        private System.Windows.Forms.DataGridViewTextBoxColumn Maphong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ngaytra;
        private System.Windows.Forms.Button btnghd;
        private System.Windows.Forms.Label lbldongia;
        private System.Windows.Forms.TextBox tbDongia;
    }
}