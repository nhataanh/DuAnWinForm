
namespace Demo
{
    partial class FormBill
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
            this.grbTTHD = new System.Windows.Forms.GroupBox();
            this.cbMaNV = new System.Windows.Forms.ComboBox();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThemHD = new System.Windows.Forms.Button();
            this.grbTTSP = new System.Windows.Forms.GroupBox();
            this.btnRefreshSP = new System.Windows.Forms.Button();
            this.btnSuaMH = new System.Windows.Forms.Button();
            this.btnThemMH = new System.Windows.Forms.Button();
            this.cbMaMH = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtThanhTien = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtTenSp = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTongTT = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbTTKH = new System.Windows.Forms.GroupBox();
            this.cbMaKH = new System.Windows.Forms.ComboBox();
            this.txtDT = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDC = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTenKH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.grbCTHD = new System.Windows.Forms.GroupBox();
            this.lbTongTT = new System.Windows.Forms.Label();
            this.dgvCTHoaDon = new System.Windows.Forms.DataGridView();
            this.btnReload = new System.Windows.Forms.Button();
            this.grbSearch = new System.Windows.Forms.GroupBox();
            this.cbListHD = new System.Windows.Forms.ComboBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnXuatHD = new System.Windows.Forms.Button();
            this.grbTTHD.SuspendLayout();
            this.grbTTSP.SuspendLayout();
            this.grbTTKH.SuspendLayout();
            this.grbCTHD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHoaDon)).BeginInit();
            this.grbSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTTHD
            // 
            this.grbTTHD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grbTTHD.Controls.Add(this.cbMaNV);
            this.grbTTHD.Controls.Add(this.dtpNgayLap);
            this.grbTTHD.Controls.Add(this.txtTenNV);
            this.grbTTHD.Controls.Add(this.label5);
            this.grbTTHD.Controls.Add(this.label4);
            this.grbTTHD.Controls.Add(this.label3);
            this.grbTTHD.Controls.Add(this.txtMaHD);
            this.grbTTHD.Controls.Add(this.label2);
            this.grbTTHD.Location = new System.Drawing.Point(15, 142);
            this.grbTTHD.Name = "grbTTHD";
            this.grbTTHD.Size = new System.Drawing.Size(574, 193);
            this.grbTTHD.TabIndex = 0;
            this.grbTTHD.TabStop = false;
            this.grbTTHD.Text = "Thông tin hóa đơn";
            // 
            // cbMaNV
            // 
            this.cbMaNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbMaNV.FormattingEnabled = true;
            this.cbMaNV.Location = new System.Drawing.Point(400, 44);
            this.cbMaNV.Name = "cbMaNV";
            this.cbMaNV.Size = new System.Drawing.Size(158, 25);
            this.cbMaNV.TabIndex = 3;
            this.cbMaNV.SelectedIndexChanged += new System.EventHandler(this.cbMaNV_SelectedIndexChanged);
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLap.Location = new System.Drawing.Point(99, 115);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(181, 25);
            this.dtpNgayLap.TabIndex = 2;
            // 
            // txtTenNV
            // 
            this.txtTenNV.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenNV.Enabled = false;
            this.txtTenNV.Location = new System.Drawing.Point(400, 118);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(155, 25);
            this.txtTenNV.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(301, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tên nhân viên";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(306, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mã nhân viên";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ngày lập";
            // 
            // txtMaHD
            // 
            this.txtMaHD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMaHD.Enabled = false;
            this.txtMaHD.Location = new System.Drawing.Point(99, 43);
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(181, 25);
            this.txtMaHD.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã hóa đơn";
            // 
            // btnThemHD
            // 
            this.btnThemHD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThemHD.Location = new System.Drawing.Point(984, 63);
            this.btnThemHD.Name = "btnThemHD";
            this.btnThemHD.Size = new System.Drawing.Size(137, 23);
            this.btnThemHD.TabIndex = 4;
            this.btnThemHD.Text = "Thêm hóa đơn";
            this.btnThemHD.UseVisualStyleBackColor = true;
            this.btnThemHD.Click += new System.EventHandler(this.btnThemHD_Click);
            // 
            // grbTTSP
            // 
            this.grbTTSP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grbTTSP.Controls.Add(this.btnRefreshSP);
            this.grbTTSP.Controls.Add(this.btnSuaMH);
            this.grbTTSP.Controls.Add(this.btnThemMH);
            this.grbTTSP.Controls.Add(this.cbMaMH);
            this.grbTTSP.Controls.Add(this.label14);
            this.grbTTSP.Controls.Add(this.label13);
            this.grbTTSP.Controls.Add(this.label12);
            this.grbTTSP.Controls.Add(this.txtThanhTien);
            this.grbTTSP.Controls.Add(this.txtDonGia);
            this.grbTTSP.Controls.Add(this.label11);
            this.grbTTSP.Controls.Add(this.txtSL);
            this.grbTTSP.Controls.Add(this.txtTenSp);
            this.grbTTSP.Controls.Add(this.label10);
            this.grbTTSP.Location = new System.Drawing.Point(15, 343);
            this.grbTTSP.Name = "grbTTSP";
            this.grbTTSP.Size = new System.Drawing.Size(417, 335);
            this.grbTTSP.TabIndex = 0;
            this.grbTTSP.TabStop = false;
            this.grbTTSP.Text = "Thông tin sản phẩm";
            // 
            // btnRefreshSP
            // 
            this.btnRefreshSP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnRefreshSP.Location = new System.Drawing.Point(314, 298);
            this.btnRefreshSP.Name = "btnRefreshSP";
            this.btnRefreshSP.Size = new System.Drawing.Size(70, 23);
            this.btnRefreshSP.TabIndex = 4;
            this.btnRefreshSP.Text = "Chọn lại";
            this.btnRefreshSP.UseVisualStyleBackColor = true;
            this.btnRefreshSP.Click += new System.EventHandler(this.btnRefreshSP_Click);
            // 
            // btnSuaMH
            // 
            this.btnSuaMH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSuaMH.Location = new System.Drawing.Point(167, 298);
            this.btnSuaMH.Name = "btnSuaMH";
            this.btnSuaMH.Size = new System.Drawing.Size(120, 23);
            this.btnSuaMH.TabIndex = 4;
            this.btnSuaMH.Text = "Sửa mặt hàng";
            this.btnSuaMH.UseVisualStyleBackColor = true;
            this.btnSuaMH.Click += new System.EventHandler(this.btnSuaMH_Click);
            // 
            // btnThemMH
            // 
            this.btnThemMH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThemMH.Location = new System.Drawing.Point(20, 298);
            this.btnThemMH.Name = "btnThemMH";
            this.btnThemMH.Size = new System.Drawing.Size(120, 23);
            this.btnThemMH.TabIndex = 4;
            this.btnThemMH.Text = "Thêm mặt hàng";
            this.btnThemMH.UseVisualStyleBackColor = true;
            this.btnThemMH.Click += new System.EventHandler(this.btnThemMH_Click);
            // 
            // cbMaMH
            // 
            this.cbMaMH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbMaMH.FormattingEnabled = true;
            this.cbMaMH.Location = new System.Drawing.Point(176, 32);
            this.cbMaMH.Name = "cbMaMH";
            this.cbMaMH.Size = new System.Drawing.Size(149, 25);
            this.cbMaMH.TabIndex = 3;
            this.cbMaMH.SelectedIndexChanged += new System.EventHandler(this.cbMaMH_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(51, 255);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(70, 17);
            this.label14.TabIndex = 0;
            this.label14.Text = "Thành tiền";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(51, 206);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 17);
            this.label13.TabIndex = 0;
            this.label13.Text = "Đơn giá";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(51, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 17);
            this.label12.TabIndex = 0;
            this.label12.Text = "Số lượng";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Location = new System.Drawing.Point(176, 252);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(153, 25);
            this.txtThanhTien.TabIndex = 1;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Location = new System.Drawing.Point(176, 198);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(152, 25);
            this.txtDonGia.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(51, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 17);
            this.label11.TabIndex = 0;
            this.label11.Text = "Tên sản phẩm";
            // 
            // txtSL
            // 
            this.txtSL.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSL.Location = new System.Drawing.Point(176, 140);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(149, 25);
            this.txtSL.TabIndex = 1;
            this.txtSL.TextChanged += new System.EventHandler(this.txtSL_TextChanged);
            this.txtSL.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSL_KeyPress);
            // 
            // txtTenSp
            // 
            this.txtTenSp.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenSp.Enabled = false;
            this.txtTenSp.Location = new System.Drawing.Point(176, 85);
            this.txtTenSp.Name = "txtTenSp";
            this.txtTenSp.Size = new System.Drawing.Size(149, 25);
            this.txtTenSp.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 17);
            this.label10.TabIndex = 0;
            this.label10.Text = "Mã sản phẩm";
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnHuy.Location = new System.Drawing.Point(792, 103);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(137, 23);
            this.btnHuy.TabIndex = 4;
            this.btnHuy.Text = "Hủy Hóa Đơn";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label15
            // 
            this.label15.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(33, 293);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 17);
            this.label15.TabIndex = 0;
            this.label15.Text = "Tổng thanh toán";
            // 
            // txtTongTT
            // 
            this.txtTongTT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTongTT.Enabled = false;
            this.txtTongTT.Location = new System.Drawing.Point(155, 285);
            this.txtTongTT.Name = "txtTongTT";
            this.txtTongTT.Size = new System.Drawing.Size(118, 25);
            this.txtTongTT.TabIndex = 1;
            this.txtTongTT.TextChanged += new System.EventHandler(this.txtTongTT_TextChanged);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(408, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "HÓA ĐƠN BÁN HÀNG";
            // 
            // grbTTKH
            // 
            this.grbTTKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grbTTKH.Controls.Add(this.cbMaKH);
            this.grbTTKH.Controls.Add(this.txtDT);
            this.grbTTKH.Controls.Add(this.label6);
            this.grbTTKH.Controls.Add(this.txtDC);
            this.grbTTKH.Controls.Add(this.label7);
            this.grbTTKH.Controls.Add(this.txtTenKH);
            this.grbTTKH.Controls.Add(this.label8);
            this.grbTTKH.Controls.Add(this.label9);
            this.grbTTKH.Location = new System.Drawing.Point(604, 142);
            this.grbTTKH.Name = "grbTTKH";
            this.grbTTKH.Size = new System.Drawing.Size(540, 193);
            this.grbTTKH.TabIndex = 0;
            this.grbTTKH.TabStop = false;
            this.grbTTKH.Text = "Thông tin khách hàng";
            // 
            // cbMaKH
            // 
            this.cbMaKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbMaKH.FormattingEnabled = true;
            this.cbMaKH.Location = new System.Drawing.Point(126, 43);
            this.cbMaKH.Name = "cbMaKH";
            this.cbMaKH.Size = new System.Drawing.Size(141, 25);
            this.cbMaKH.TabIndex = 3;
            this.cbMaKH.SelectedIndexChanged += new System.EventHandler(this.cbMaKH_SelectedIndexChanged);
            // 
            // txtDT
            // 
            this.txtDT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDT.Enabled = false;
            this.txtDT.Location = new System.Drawing.Point(400, 115);
            this.txtDT.Name = "txtDT";
            this.txtDT.Size = new System.Drawing.Size(126, 25);
            this.txtDT.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(294, 121);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Điện thoại";
            // 
            // txtDC
            // 
            this.txtDC.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDC.Enabled = false;
            this.txtDC.Location = new System.Drawing.Point(126, 113);
            this.txtDC.Name = "txtDC";
            this.txtDC.Size = new System.Drawing.Size(141, 25);
            this.txtDC.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 121);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 17);
            this.label7.TabIndex = 0;
            this.label7.Text = "Địa chỉ";
            // 
            // txtTenKH
            // 
            this.txtTenKH.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTenKH.Enabled = false;
            this.txtTenKH.Location = new System.Drawing.Point(400, 44);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.Size = new System.Drawing.Size(126, 25);
            this.txtTenKH.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(292, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 0;
            this.label8.Text = "Tên khách hàng";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(21, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 17);
            this.label9.TabIndex = 0;
            this.label9.Text = "Mã khách hàng";
            // 
            // grbCTHD
            // 
            this.grbCTHD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grbCTHD.Controls.Add(this.lbTongTT);
            this.grbCTHD.Controls.Add(this.label15);
            this.grbCTHD.Controls.Add(this.dgvCTHoaDon);
            this.grbCTHD.Controls.Add(this.txtTongTT);
            this.grbCTHD.Location = new System.Drawing.Point(438, 343);
            this.grbCTHD.Name = "grbCTHD";
            this.grbCTHD.Size = new System.Drawing.Size(706, 335);
            this.grbCTHD.TabIndex = 2;
            this.grbCTHD.TabStop = false;
            this.grbCTHD.Text = "Thông tin chi tiết hóa đơn";
            // 
            // lbTongTT
            // 
            this.lbTongTT.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbTongTT.AutoSize = true;
            this.lbTongTT.Location = new System.Drawing.Point(329, 293);
            this.lbTongTT.Name = "lbTongTT";
            this.lbTongTT.Size = new System.Drawing.Size(49, 17);
            this.lbTongTT.TabIndex = 5;
            this.lbTongTT.Text = "label17";
            // 
            // dgvCTHoaDon
            // 
            this.dgvCTHoaDon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dgvCTHoaDon.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvCTHoaDon.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvCTHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHoaDon.Location = new System.Drawing.Point(14, 35);
            this.dgvCTHoaDon.Name = "dgvCTHoaDon";
            this.dgvCTHoaDon.ReadOnly = true;
            this.dgvCTHoaDon.RowHeadersWidth = 51;
            this.dgvCTHoaDon.RowTemplate.Height = 24;
            this.dgvCTHoaDon.Size = new System.Drawing.Size(678, 219);
            this.dgvCTHoaDon.TabIndex = 0;
            this.dgvCTHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTHoaDon_CellClick);
            this.dgvCTHoaDon.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCTHoaDon_CellDoubleClick);
            // 
            // btnReload
            // 
            this.btnReload.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnReload.Location = new System.Drawing.Point(792, 63);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(137, 23);
            this.btnReload.TabIndex = 4;
            this.btnReload.Text = "Làm mới trang";
            this.btnReload.UseVisualStyleBackColor = true;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // grbSearch
            // 
            this.grbSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grbSearch.Controls.Add(this.cbListHD);
            this.grbSearch.Controls.Add(this.btnSearch);
            this.grbSearch.Location = new System.Drawing.Point(15, 63);
            this.grbSearch.Name = "grbSearch";
            this.grbSearch.Size = new System.Drawing.Size(574, 73);
            this.grbSearch.TabIndex = 5;
            this.grbSearch.TabStop = false;
            this.grbSearch.Text = "Tìm kiếm hóa đơn";
            // 
            // cbListHD
            // 
            this.cbListHD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbListHD.FormattingEnabled = true;
            this.cbListHD.Location = new System.Drawing.Point(59, 29);
            this.cbListHD.Name = "cbListHD";
            this.cbListHD.Size = new System.Drawing.Size(286, 25);
            this.cbListHD.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSearch.Location = new System.Drawing.Point(400, 29);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(104, 23);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Tìm hóa đơn";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnXuatHD
            // 
            this.btnXuatHD.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXuatHD.Location = new System.Drawing.Point(984, 103);
            this.btnXuatHD.Name = "btnXuatHD";
            this.btnXuatHD.Size = new System.Drawing.Size(137, 23);
            this.btnXuatHD.TabIndex = 6;
            this.btnXuatHD.Text = "Xuất Hóa đơn";
            this.btnXuatHD.UseVisualStyleBackColor = true;
            this.btnXuatHD.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1154, 688);
            this.Controls.Add(this.btnXuatHD);
            this.Controls.Add(this.grbSearch);
            this.Controls.Add(this.btnThemHD);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.grbCTHD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.grbTTSP);
            this.Controls.Add(this.grbTTKH);
            this.Controls.Add(this.grbTTHD);
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormBill";
            this.Text = "BILL";
            this.Load += new System.EventHandler(this.FormBill_Load);
            this.grbTTHD.ResumeLayout(false);
            this.grbTTHD.PerformLayout();
            this.grbTTSP.ResumeLayout(false);
            this.grbTTSP.PerformLayout();
            this.grbTTKH.ResumeLayout(false);
            this.grbTTKH.PerformLayout();
            this.grbCTHD.ResumeLayout(false);
            this.grbCTHD.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHoaDon)).EndInit();
            this.grbSearch.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTTHD;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grbTTSP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbTTKH;
        private System.Windows.Forms.TextBox txtDT;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDC;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTenKH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbMaNV;
        private System.Windows.Forms.DateTimePicker dtpNgayLap;
        private System.Windows.Forms.ComboBox cbMaKH;
        private System.Windows.Forms.ComboBox cbMaMH;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnThemHD;
        private System.Windows.Forms.Button btnThemMH;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTongTT;
        private System.Windows.Forms.TextBox txtThanhTien;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtTenSp;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.GroupBox grbCTHD;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnSuaMH;
        private System.Windows.Forms.Button btnRefreshSP;
        private System.Windows.Forms.Label lbTongTT;
        private System.Windows.Forms.GroupBox grbSearch;
        private System.Windows.Forms.ComboBox cbListHD;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvCTHoaDon;
        private System.Windows.Forms.Button btnXuatHD;
    }
}