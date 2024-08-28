
namespace Demo
{
    partial class SanPham
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSL = new System.Windows.Forms.TextBox();
            this.txtTenSP = new System.Windows.Forms.TextBox();
            this.txtMaSP = new System.Windows.Forms.TextBox();
            this.nmGia = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTimSP = new System.Windows.Forms.TextBox();
            this.btnTimSP = new System.Windows.Forms.Button();
            this.btnReload = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.cbMaLoaiSP = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvSanPham = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtTenLSP = new System.Windows.Forms.TextBox();
            this.txtMaLSP = new System.Windows.Forms.TextBox();
            this.txtTimDSP = new System.Windows.Forms.TextBox();
            this.btnTimDSP = new System.Windows.Forms.Button();
            this.btnXoaDSP = new System.Windows.Forms.Button();
            this.btnRefreshDSP = new System.Windows.Forms.Button();
            this.btnSuaDSP = new System.Windows.Forms.Button();
            this.btnThemDSP = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvDSP = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmGia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSP)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.txtSL);
            this.groupBox1.Controls.Add(this.txtTenSP);
            this.groupBox1.Controls.Add(this.txtMaSP);
            this.groupBox1.Controls.Add(this.nmGia);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtTimSP);
            this.groupBox1.Controls.Add(this.btnTimSP);
            this.groupBox1.Controls.Add(this.btnReload);
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnSua);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.cbMaLoaiSP);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.dgvSanPham);
            this.groupBox1.Location = new System.Drawing.Point(67, 373);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1421, 430);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SẢN PHẨM";
            // 
            // txtSL
            // 
            this.txtSL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtSL.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSL.Location = new System.Drawing.Point(1113, 180);
            this.txtSL.Multiline = true;
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(258, 35);
            this.txtSL.TabIndex = 75;
            // 
            // txtTenSP
            // 
            this.txtTenSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenSP.Location = new System.Drawing.Point(1113, 126);
            this.txtTenSP.Multiline = true;
            this.txtTenSP.Name = "txtTenSP";
            this.txtTenSP.Size = new System.Drawing.Size(258, 35);
            this.txtTenSP.TabIndex = 75;
            // 
            // txtMaSP
            // 
            this.txtMaSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSP.Location = new System.Drawing.Point(1113, 72);
            this.txtMaSP.Multiline = true;
            this.txtMaSP.Name = "txtMaSP";
            this.txtMaSP.Size = new System.Drawing.Size(258, 35);
            this.txtMaSP.TabIndex = 75;
            // 
            // nmGia
            // 
            this.nmGia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nmGia.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nmGia.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.nmGia.Location = new System.Drawing.Point(1113, 231);
            this.nmGia.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.nmGia.Name = "nmGia";
            this.nmGia.Size = new System.Drawing.Size(258, 30);
            this.nmGia.TabIndex = 59;
            this.nmGia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(951, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 22);
            this.label4.TabIndex = 58;
            this.label4.Text = "Giá";
            // 
            // txtTimSP
            // 
            this.txtTimSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTimSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimSP.Location = new System.Drawing.Point(47, 21);
            this.txtTimSP.Multiline = true;
            this.txtTimSP.Name = "txtTimSP";
            this.txtTimSP.Size = new System.Drawing.Size(690, 35);
            this.txtTimSP.TabIndex = 57;
            // 
            // btnTimSP
            // 
            this.btnTimSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimSP.BackColor = System.Drawing.Color.Tan;
            this.btnTimSP.FlatAppearance.BorderSize = 0;
            this.btnTimSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimSP.Location = new System.Drawing.Point(756, 21);
            this.btnTimSP.Name = "btnTimSP";
            this.btnTimSP.Size = new System.Drawing.Size(129, 36);
            this.btnTimSP.TabIndex = 56;
            this.btnTimSP.Text = "Tìm Kiếm";
            this.btnTimSP.UseVisualStyleBackColor = false;
            this.btnTimSP.Click += new System.EventHandler(this.btnTimSP_Click);
            // 
            // btnReload
            // 
            this.btnReload.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnReload.BackColor = System.Drawing.Color.Tan;
            this.btnReload.FlatAppearance.BorderSize = 0;
            this.btnReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReload.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReload.Location = new System.Drawing.Point(1219, 376);
            this.btnReload.Name = "btnReload";
            this.btnReload.Size = new System.Drawing.Size(121, 36);
            this.btnReload.TabIndex = 55;
            this.btnReload.Text = "Refresh";
            this.btnReload.UseVisualStyleBackColor = false;
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoa.BackColor = System.Drawing.Color.Tan;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(986, 376);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(121, 36);
            this.btnXoa.TabIndex = 54;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSua.BackColor = System.Drawing.Color.Tan;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSua.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Location = new System.Drawing.Point(1219, 315);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(121, 36);
            this.btnSua.TabIndex = 53;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThem.BackColor = System.Drawing.Color.Tan;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(986, 315);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(121, 36);
            this.btnThem.TabIndex = 52;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // cbMaLoaiSP
            // 
            this.cbMaLoaiSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbMaLoaiSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbMaLoaiSP.FormattingEnabled = true;
            this.cbMaLoaiSP.Location = new System.Drawing.Point(1113, 25);
            this.cbMaLoaiSP.Name = "cbMaLoaiSP";
            this.cbMaLoaiSP.Size = new System.Drawing.Size(258, 30);
            this.cbMaLoaiSP.TabIndex = 51;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(951, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 22);
            this.label3.TabIndex = 50;
            this.label3.Text = "Mã loại sản phẩm";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(951, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 22);
            this.label1.TabIndex = 49;
            this.label1.Text = "Số lượng tồn";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(951, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 22);
            this.label2.TabIndex = 49;
            this.label2.Text = "Tên sản phẩm";
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(955, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 22);
            this.label7.TabIndex = 47;
            this.label7.Text = "Mã sản phẩm";
            // 
            // dgvSanPham
            // 
            this.dgvSanPham.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSanPham.Location = new System.Drawing.Point(36, 73);
            this.dgvSanPham.Name = "dgvSanPham";
            this.dgvSanPham.ReadOnly = true;
            this.dgvSanPham.RowHeadersWidth = 51;
            this.dgvSanPham.RowTemplate.Height = 24;
            this.dgvSanPham.Size = new System.Drawing.Size(859, 339);
            this.dgvSanPham.TabIndex = 45;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.txtTenLSP);
            this.groupBox2.Controls.Add(this.txtMaLSP);
            this.groupBox2.Controls.Add(this.txtTimDSP);
            this.groupBox2.Controls.Add(this.btnTimDSP);
            this.groupBox2.Controls.Add(this.btnXoaDSP);
            this.groupBox2.Controls.Add(this.btnRefreshDSP);
            this.groupBox2.Controls.Add(this.btnSuaDSP);
            this.groupBox2.Controls.Add(this.btnThemDSP);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dgvDSP);
            this.groupBox2.Location = new System.Drawing.Point(158, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1249, 354);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "DÒNG SẢN PHẨM";
            // 
            // txtTenLSP
            // 
            this.txtTenLSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTenLSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenLSP.Location = new System.Drawing.Point(240, 124);
            this.txtTenLSP.Multiline = true;
            this.txtTenLSP.Name = "txtTenLSP";
            this.txtTenLSP.Size = new System.Drawing.Size(326, 35);
            this.txtTenLSP.TabIndex = 75;
            // 
            // txtMaLSP
            // 
            this.txtMaLSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMaLSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaLSP.Location = new System.Drawing.Point(240, 70);
            this.txtMaLSP.Multiline = true;
            this.txtMaLSP.Name = "txtMaLSP";
            this.txtMaLSP.Size = new System.Drawing.Size(326, 35);
            this.txtMaLSP.TabIndex = 75;
            // 
            // txtTimDSP
            // 
            this.txtTimDSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtTimDSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimDSP.Location = new System.Drawing.Point(712, 32);
            this.txtTimDSP.Multiline = true;
            this.txtTimDSP.Name = "txtTimDSP";
            this.txtTimDSP.Size = new System.Drawing.Size(326, 35);
            this.txtTimDSP.TabIndex = 75;
            // 
            // btnTimDSP
            // 
            this.btnTimDSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTimDSP.BackColor = System.Drawing.Color.Tan;
            this.btnTimDSP.FlatAppearance.BorderSize = 0;
            this.btnTimDSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTimDSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTimDSP.Location = new System.Drawing.Point(1065, 32);
            this.btnTimDSP.Name = "btnTimDSP";
            this.btnTimDSP.Size = new System.Drawing.Size(129, 36);
            this.btnTimDSP.TabIndex = 74;
            this.btnTimDSP.Text = "Tìm Kiếm";
            this.btnTimDSP.UseVisualStyleBackColor = false;
            this.btnTimDSP.Click += new System.EventHandler(this.btnTimDSP_Click);
            // 
            // btnXoaDSP
            // 
            this.btnXoaDSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnXoaDSP.BackColor = System.Drawing.Color.Tan;
            this.btnXoaDSP.FlatAppearance.BorderSize = 0;
            this.btnXoaDSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaDSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaDSP.Location = new System.Drawing.Point(455, 204);
            this.btnXoaDSP.Name = "btnXoaDSP";
            this.btnXoaDSP.Size = new System.Drawing.Size(121, 36);
            this.btnXoaDSP.TabIndex = 72;
            this.btnXoaDSP.Text = "Xóa";
            this.btnXoaDSP.UseVisualStyleBackColor = false;
            this.btnXoaDSP.Click += new System.EventHandler(this.btnXoaDSP_Click);
            // 
            // btnRefreshDSP
            // 
            this.btnRefreshDSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRefreshDSP.BackColor = System.Drawing.Color.Tan;
            this.btnRefreshDSP.FlatAppearance.BorderSize = 0;
            this.btnRefreshDSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefreshDSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefreshDSP.Location = new System.Drawing.Point(240, 259);
            this.btnRefreshDSP.Name = "btnRefreshDSP";
            this.btnRefreshDSP.Size = new System.Drawing.Size(121, 36);
            this.btnRefreshDSP.TabIndex = 71;
            this.btnRefreshDSP.Text = "Refresh";
            this.btnRefreshDSP.UseVisualStyleBackColor = false;
            this.btnRefreshDSP.Click += new System.EventHandler(this.btnRefreshDSP_Click);
            // 
            // btnSuaDSP
            // 
            this.btnSuaDSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSuaDSP.BackColor = System.Drawing.Color.Tan;
            this.btnSuaDSP.FlatAppearance.BorderSize = 0;
            this.btnSuaDSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuaDSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSuaDSP.Location = new System.Drawing.Point(240, 204);
            this.btnSuaDSP.Name = "btnSuaDSP";
            this.btnSuaDSP.Size = new System.Drawing.Size(121, 36);
            this.btnSuaDSP.TabIndex = 71;
            this.btnSuaDSP.Text = "Sửa";
            this.btnSuaDSP.UseVisualStyleBackColor = false;
            this.btnSuaDSP.Click += new System.EventHandler(this.btnSuaDSP_Click);
            // 
            // btnThemDSP
            // 
            this.btnThemDSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnThemDSP.BackColor = System.Drawing.Color.Tan;
            this.btnThemDSP.FlatAppearance.BorderSize = 0;
            this.btnThemDSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemDSP.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemDSP.Location = new System.Drawing.Point(42, 204);
            this.btnThemDSP.Name = "btnThemDSP";
            this.btnThemDSP.Size = new System.Drawing.Size(121, 36);
            this.btnThemDSP.TabIndex = 70;
            this.btnThemDSP.Text = "Thêm";
            this.btnThemDSP.UseVisualStyleBackColor = false;
            this.btnThemDSP.Click += new System.EventHandler(this.btnThemDSP_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(75, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 22);
            this.label5.TabIndex = 69;
            this.label5.Text = "Tên loại sản phẩm";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(75, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 22);
            this.label6.TabIndex = 67;
            this.label6.Text = "Mã loại sản phẩm";
            // 
            // dgvDSP
            // 
            this.dgvDSP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dgvDSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvDSP.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvDSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSP.Location = new System.Drawing.Point(712, 99);
            this.dgvDSP.Name = "dgvDSP";
            this.dgvDSP.ReadOnly = true;
            this.dgvDSP.RowHeadersWidth = 51;
            this.dgvDSP.RowTemplate.Height = 24;
            this.dgvDSP.Size = new System.Drawing.Size(482, 228);
            this.dgvDSP.TabIndex = 65;
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(1555, 833);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "SanPham";
            this.Text = "SanPham";
            this.Load += new System.EventHandler(this.SanPham_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmGia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSanPham)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSL;
        private System.Windows.Forms.TextBox txtTenSP;
        private System.Windows.Forms.TextBox txtMaSP;
        private System.Windows.Forms.NumericUpDown nmGia;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTimSP;
        private System.Windows.Forms.Button btnTimSP;
        private System.Windows.Forms.Button btnReload;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.ComboBox cbMaLoaiSP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvSanPham;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtTenLSP;
        private System.Windows.Forms.TextBox txtMaLSP;
        private System.Windows.Forms.TextBox txtTimDSP;
        private System.Windows.Forms.Button btnTimDSP;
        private System.Windows.Forms.Button btnXoaDSP;
        private System.Windows.Forms.Button btnRefreshDSP;
        private System.Windows.Forms.Button btnSuaDSP;
        private System.Windows.Forms.Button btnThemDSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dgvDSP;
    }
}