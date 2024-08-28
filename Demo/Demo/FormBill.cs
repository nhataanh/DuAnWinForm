using Demo.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListViewItem;
using Excel = Microsoft.Office.Interop.Excel;


namespace Demo
{
    public partial class FormBill : Form
    {
        private DataTable CTHD = new DataTable();
        int SelectedRow = -1;
        public FormBill()
        {
            InitializeComponent();
            dtpNgayLap.CustomFormat = "dd/MM/yyyy";
            lbTongTT.Text = "Bằng chữ: ";
        }


        private void GetMaHD()
        {
            // String query = "Select * from HoaDon";
            // DataTable data = KetNoi.Instance.ExecuteQuery(query);
            //txtMaHD.Text = "HD" +data.Rows.Count.ToString();
            string[] partsDay;
            partsDay = DateTime.Now.ToShortDateString().Split('/');
            string d = String.Format("{0}{1}{2}", partsDay[0], partsDay[1], partsDay[2]);
            string currentTime = DateTime.Now.ToString("HH:mm:ss");
            string[] partsTime;  
            partsTime = DateTime.Now.ToString("HH:mm:ss").Split(':');
            string t;
            t = String.Format("_{0}{1}{2}", partsTime[0], partsTime[1], partsTime[2]);
            txtMaHD.Text = "HĐ" + d + t;
        }
        private void GetListSP()
        {
            String query = "Select * from SanPham where isDelete = 0";
            DataTable data = KetNoi.Instance.ExecuteQuery(query);
            cbMaMH.DataSource = data;
            cbMaMH.DisplayMember = "MaSP";
            cbMaMH.ValueMember = "MaSP";
            cbMaMH.SelectedIndex = -1;
            //
        }
        private void GetListHD()
        {
            String query = "Select * from HoaDon";
            DataTable data = KetNoi.Instance.ExecuteQuery(query);
            cbListHD.DataSource = data;
            cbListHD.DisplayMember = "MaHD";
            cbListHD.ValueMember = "MaHD";
            cbListHD.SelectedIndex = -1;
            //
        }
        private void GetListNV()
        {
            String query = "Select * from NhanVien where isDelete = 0";
            DataTable data = KetNoi.Instance.ExecuteQuery(query);
           cbMaNV.DataSource = data;
            cbMaNV.DisplayMember = "MaNV";
           cbMaNV.ValueMember = "MaNV";
            cbMaNV.SelectedIndex = -1;
            //
        }
        private void GetListKH()
        {
            String query = "Select * from KhachHang";
            DataTable data = KetNoi.Instance.ExecuteQuery(query);
            cbMaKH.DataSource = data;
            cbMaKH.DisplayMember = "MaKH";
            cbMaKH.ValueMember = "MaKH";
            cbMaKH.SelectedIndex = -1;
            //
        }
        private void GetCTHD()
        {
            /*         String query = String.Format(@"Select CTHoaDon.MaSp as 'Mã sản phẩm',
         SanPham.TenSp as 'Tên sản phẩm',
         CTHoaDon.SoLuong as 'Số lượng',
         SanPham.Gia as 'Đơn giá',
         ThanhTien as 'Thành tiền'
         from CTHoaDon,SanPham
         Where CTHoaDon.MaSp = SanPham.MaSP
         and CTHoaDon.MaHD = N'{0}'",txtMaHD.Text);
                     CTHD = KetNoi.Instance.ExecuteQuery(query);
                     dgvCTHoaDon.DataSource = CTHD;
                     float TongTien = 0;
                     for (int i=0; i< CTHD.Rows.Count;i++)
                     {
                         TongTien = TongTien + float.Parse(CTHD.Rows[i]["Thành tiền"].ToString());
                     }
                     txtTongTT.Text = TongTien.ToString();*/
            dgvCTHoaDon.DataSource = CTHD;
            float TongTien = 0;
            for (int i = 0; i < CTHD.Rows.Count; i++)
            {
                TongTien = TongTien + float.Parse(CTHD.Rows[i]["Thành tiền"].ToString());
            }
            txtTongTT.Text = TongTien.ToString();
             dgvCTHoaDon.DataSource = CTHD;
        }
        private void FormBill_Load(object sender, EventArgs e)
        {
            CTHD.Columns.Add("Mã Sản phẩm", typeof(String));
            CTHD.Columns.Add("Tên Sản phẩm", typeof(String));
            CTHD.Columns.Add("Số lượng", typeof(String));
            CTHD.Columns.Add("Đơn giá", typeof(String));
            CTHD.Columns.Add("Thành tiền", typeof(String));
            //CTHD.Rows.Add("DIT");
            GetCTHD();
            GetListSP();
            GetMaHD();
         GetListNV();
            GetListKH();
            
            GetListHD();
            grbTTSP.Enabled = false;
            grbCTHD.Enabled = false;
            grbTTHD.Enabled = true;
            grbTTKH.Enabled = true;
            btnHuy.Enabled = false;
            btnXuatHD.Enabled = false;

        }

        private void cbMaNV_SelectedIndexChanged(object sender, EventArgs e)
        {

       if (cbMaNV.SelectedIndex != -1)
            {
                String query = String.Format("Select * from NhanVien where MaNV = N'{0}'",
                    cbMaNV.SelectedValue.ToString());
                DataTable data = KetNoi.Instance.ExecuteQuery(query);

                // Console.WriteLine("SO ROW LAY VE: " + data.Rows.Count.ToString());
                if (data.Rows.Count != 0)
                {
                    txtTenNV.Text = data.Rows[0]["TenNV"].ToString();

                }

            }
            else txtTenNV.Text = "";
            EnableThemMH();
        }

        private void cbMaKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaKH.SelectedIndex != -1)
            {
                String query = String.Format("Select * from KhachHang where MaKH = N'{0}'", cbMaKH.SelectedValue.ToString());
               DataTable data = KetNoi.Instance.ExecuteQuery(query);

                // Console.WriteLine("SO ROW LAY VE: " + data.Rows.Count.ToString());
                if (data.Rows.Count != 0) 
                {
  txtTenKH.Text = data.Rows[0]["TenKH"].ToString();
                txtDT.Text = data.Rows[0]["SDT"].ToString();
            txtDC.Text = data.Rows[0]["DiaChi"].ToString();
                }
              
            } 
            else
            {
                txtTenKH.Text = "";
                txtDT.Text = "";
                txtDC.Text = "";
            }
            EnableThemMH();
        }

        private void cbMaMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbMaMH.SelectedIndex != -1)
            {
                String query = String.Format("Select * from SanPham where MaSP = N'{0}'", cbMaMH.SelectedValue.ToString());
                DataTable data = KetNoi.Instance.ExecuteQuery(query);

                // Console.WriteLine("SO ROW LAY VE: " + data.Rows.Count.ToString());
                if (data.Rows.Count != 0)
                {
                    txtTenSp.Text = data.Rows[0]["TenSP"].ToString();
                    txtDonGia.Text = data.Rows[0]["Gia"].ToString();
                    txtSL.Text = "";
                }

            }
            else
            {
                txtTenSp.Text = "";
                txtDonGia.Text = "";
                txtSL.Text = "";
            }
        }

        private void txtSL_TextChanged(object sender, EventArgs e)
        {
            if (txtSL.Text != "" && txtSL.Text != "0")
            {
                int total = int.Parse(txtDonGia.Text) * int.Parse(txtSL.Text);
                txtThanhTien.Text = total.ToString();
            }
            else
            {
                txtThanhTien.Text = "";
            }
        }
        private void UpdateTien()
        {
           String query = String.Format(
           "Update HoaDon Set TongTien = N'{0}' Where MaHD = N'{1}' ",
            txtTongTT.Text,
            txtMaHD.Text
           );
            if (KetNoi.Instance.ExecuteNonQuery(query) != 0)
            {
                return;
            }
            else MessageBox.Show("Sua That Bai!!");
        }
        private bool CheckMHonHD()
        {
            foreach (DataRow row in CTHD.Rows)
            {
                if (row["Mã sản phẩm"].ToString() == cbMaMH.SelectedValue.ToString())
                {
                    return false;
                }
                
            }
            return true;
            /*      String check = String.Format(
                "Select * from CTHoaDon where MaHD = N'{0}' and MaSP = N'{1}'",
                txtMaHD.Text,
                cbMaMH.SelectedValue
                );
                  DataTable data = KetNoi.Instance.ExecuteQuery(check);
                  return data.Rows.Count;*/
        }
        private bool CheckHang()
        {
            String query = String.Format(
                 "Select SoLuong from SanPham where MaSP = N'{0}'",
                 cbMaMH.SelectedValue
                 );
            DataTable data = KetNoi.Instance.ExecuteQuery(query);
            if (int.Parse(txtSL.Text) > int.Parse(data.Rows[0]["SoLuong"].ToString())) return false;
            return true;
        }
        private void btnThemMH_Click(object sender, EventArgs e)
        {
            if (cbMaMH.SelectedIndex == -1)
            {
                MessageBox.Show("Hãy chọn mặt hàng!!!");
                return;
            }
            if (txtSL.Text == "" || txtSL.Text == null)
            {
                MessageBox.Show("Số lượng phải khác 0 và không được để trống!!!");
                return;
            }
            if (!CheckMHonHD())
            {
                MessageBox.Show("Sản phẩm này đã có trong hóa đơn!!!");
                return;
            }
            if (CheckHang() == false)
            {
                MessageBox.Show("Không có đủ hàng để thêm với số lượng bạn muốn!!!");
                return;
            }
            String query = String.Format("Select TenSP from SanPham Where MaSP = N'{0}'", cbMaMH.SelectedValue);
            DataTable data = KetNoi.Instance.ExecuteQuery(query);
            CTHD.Rows.Add(cbMaMH.SelectedValue, data.Rows[0]["TenSP"].ToString(),txtSL.Text,txtDonGia.Text,txtThanhTien.Text);
            GetCTHD();
            cbMaMH.SelectedIndex = -1;
            /*            String query = String.Format(
             "Insert into CTHoaDon Values (N'{0}',N'{1}',{2},N'{3}')",
             txtMaHD.Text,
             cbMaMH.Text,
             txtSL.Text,
             txtThanhTien.Text
             );
            // int temp = KetNoi.Instance.ExecuteNonQuery(query);
              if (KetNoi.Instance.ExecuteNonQuery(query) != 0)
              {
                  // MessageBox.Show("Them Thanh Cong !!");
                  GetCTHD();
                  cbMaMH.SelectedIndex = -1;
                  UpdateTien();
                  // txtSL.Text = "";
                  // txtDonGia.Text = "";
                  // txtTenSp.Text = "";
              }
              else MessageBox.Show("Them That Bai!!");*/
        }
        private void dgvCTHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedRow = e.RowIndex;
            if (SelectedRow >= 0)
            {
                cbMaMH.SelectedValue = dgvCTHoaDon.Rows[SelectedRow].Cells["Mã sản phẩm"].Value.ToString();
                txtTenSp.Text = dgvCTHoaDon.Rows[SelectedRow].Cells["Tên sản phẩm"].Value.ToString();
                txtSL.Text = dgvCTHoaDon.Rows[SelectedRow].Cells["Số lượng"].Value.ToString();
                txtDonGia.Text = dgvCTHoaDon.Rows[SelectedRow].Cells["Đơn giá"].Value.ToString();
                txtThanhTien.Text = dgvCTHoaDon.Rows[SelectedRow].Cells["Thành tiền"].Value.ToString();

               /* SelectedMaMH = dgvCTHoaDon.Rows[index].Cells["Mã sản phẩm"].Value.ToString();
                SelectedSL = dgvCTHoaDon.Rows[index].Cells["Số lượng"].Value.ToString();
                SelectedDonGia = dgvCTHoaDon.Rows[index].Cells["Đơn giá"].Value.ToString();
                SelectedThanhTien = dgvCTHoaDon.Rows[index].Cells["Thành tiền"].Value.ToString();*/
                btnThemMH.Enabled = false;
                btnSuaMH.Enabled = true;
            }
        }

        private void dgvCTHoaDon_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvCTHoaDon.Rows.RemoveAt(e.RowIndex);
            GetCTHD();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ĐÃ HỦY HÓA ĐƠN!!!");
            Reload();
        }
        private void Reload()
        {
            CTHD.Clear();
            CTHD.AcceptChanges();
            GetMaHD();
            GetCTHD();
            GetListNV();
            GetListKH();
            GetListSP();
            //txtTenNV.Text = cbMaNV.SelectedValue.ToString();
            cbMaNV.SelectedIndex = -1;
            cbMaKH.SelectedIndex = -1;
            cbMaMH.SelectedIndex = -1;
            grbTTSP.Enabled = false;
            grbCTHD.Enabled = false;
            grbTTHD.Enabled = true;
            grbTTKH.Enabled = true;
            grbSearch.Enabled = true;
            btnReload.Enabled = true;
            btnHuy.Enabled = false;
            btnXuatHD.Enabled = false;
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            Reload();
        }
        private void EnableThemMH()
        {
            if (cbMaKH.SelectedIndex != -1 && cbMaNV.SelectedIndex != -1)
            {
                grbTTSP.Enabled = true;
                btnHuy.Enabled = true;
                btnXuatHD.Enabled = true;
            }
            else grbTTSP.Enabled = false;
           

        }
        private void btnThemHD_Click(object sender, EventArgs e)
        {
            if (cbMaKH.SelectedIndex == -1 || cbMaNV.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return;
            }
            try
            {
                String query = String.Format(
         "Insert into HoaDon Values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}')",
         txtMaHD.Text,
         dtpNgayLap.Value.Date,
         cbMaKH.SelectedValue,
         txtTongTT.Text,
         cbMaNV.SelectedValue.ToString()
         );
                int temp = KetNoi.Instance.ExecuteNonQuery(query);
                foreach (DataRow row in CTHD.Rows)
                {
                    String addCTHD = String.Format("Insert into CTHoaDon Values (N'{0}',N'{1}',N'{2}',N'{3}')",
                        txtMaHD.Text,
                        row["Mã sản phẩm"].ToString(),
                        row["Số lượng"].ToString(),
                        row["Thành tiền"].ToString()

                        );
                    int add = KetNoi.Instance.ExecuteNonQuery(addCTHD);
                }
                MessageBox.Show("THÊM HÓA ĐƠN THÀNH CÔNG");
                UpdateSLSP();
                Reload();
            }
            catch(Exception ex)
            {
                MessageBox.Show("THÊM HÓA ĐƠN THẤT BẠI" + ex.Message);
            }
          
        }
        private bool CheckMHD()
        {
            String query = String.Format("Select MaHD from HoaDon where MaHD = N'{0}'", txtMaHD.Text);
            DataTable data = KetNoi.Instance.ExecuteQuery(query);
            if (data.Rows.Count == 0) return true;
            return false;
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
           try
            {
                txtMaHD.Text = cbListHD.SelectedValue.ToString();
                String query = String.Format(
                 "Select * from HoaDon where MaHD = N'{0}'",
                 txtMaHD.Text
                 );
                DataTable data = KetNoi.Instance.ExecuteQuery(query);
                cbMaNV.SelectedValue = data.Rows[0]["MaNV"].ToString();
                cbMaKH.SelectedValue = data.Rows[0]["MaKH"].ToString();
                dtpNgayLap.Value = Convert.ToDateTime(data.Rows[0]["NgayMH"]);

                query = String.Format(@"Select CTHoaDon.MaSp as 'Mã sản phẩm',
         SanPham.TenSp as 'Tên sản phẩm',
         CTHoaDon.SoLuong as 'Số lượng',
         SanPham.Gia as 'Đơn giá',
         ThanhTien as 'Thành tiền'
         from CTHoaDon,SanPham
         Where CTHoaDon.MaSp = SanPham.MaSP
         and CTHoaDon.MaHD = N'{0}'", txtMaHD.Text);
                CTHD = KetNoi.Instance.ExecuteQuery(query);
                GetCTHD();
                btnXuatHD.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tìm kiếm " + ex.Message);
            }
        }
        private void UpdateSLSP()
        {
            for (int i = 0; i < CTHD.Rows.Count; i++)
            {
                String query = String.Format(
                "Update SanPham set SoLuong = SoLuong - {1} where MaSP = N'{0}'",
                CTHD.Rows[i]["Mã sản phẩm"].ToString(),
                int.Parse(CTHD.Rows[i]["Số lượng"].ToString())
                    );
                int temp = KetNoi.Instance.ExecuteNonQuery(query);

            }
        }
  

        private void btnSuaMH_Click(object sender, EventArgs e)
        {
            if (CheckHang() == false)
            {
                MessageBox.Show("Không có đủ hàng để thêm với số lượng bạn muốn!!!");
                return;
            }
       
            CTHD.Rows[SelectedRow]["Mã sản phẩm"] = cbMaMH.SelectedValue.ToString();
            CTHD.Rows[SelectedRow]["Tên sản phẩm"] = txtTenSp.Text;
            CTHD.Rows[SelectedRow]["Số lượng"] = txtSL.Text;
            CTHD.Rows[SelectedRow]["Đơn giá"] = txtDonGia.Text;
            CTHD.Rows[SelectedRow]["Thành tiền"] = txtThanhTien.Text;
            GetCTHD();
            /*  String query = String.Format(
             @"Update CTHoaDon Set 
                      MaSp = N'{0}',
                     SoLuong = N'{1}', 
                      ThanhTien = N'{2}' 
                      Where MaHD = N'{3}' and
                      MaSp = N'{4}' and
                     SoLuong = N'{5}' and
                      ThanhTien = N'{6}'            
                      ",
                cbMaMH.SelectedValue,
               txtSL.Text,
               txtThanhTien.Text,
               txtMaHD.Text,
               SelectedMaMH,
               SelectedSL,
               SelectedThanhTien
              ) ;
              if (KetNoi.Instance.ExecuteNonQuery(query) != 0)
              {
                  MessageBox.Show("Sua Thanh Cong !!");
                  // btnReload.PerformClick();
                  GetCTHD();
                  btnThemMH.Enabled = true;
                  btnSuaMH.Enabled = false;
                  cbMaMH.SelectedIndex = -1;

              }
              else MessageBox.Show("Sua That Bai!!");*/
        }

        private void btnRefreshSP_Click(object sender, EventArgs e)
        {
            cbMaMH.SelectedIndex = -1;
            txtSL.Text = "";
            txtThanhTien.Text = "";
            btnThemMH.Enabled = true;
            btnSuaMH.Enabled = false;
        }

        private void txtTongTT_TextChanged(object sender, EventArgs e)
        {
            if (txtTongTT.Text != "0")
                lbTongTT.Text = "Bằng chữ: " + NumberToText(double.Parse(txtTongTT.Text)).ToString();
            else lbTongTT.Text = "Bằng chữ: ";
        }

        public static string NumberToText(double inputNumber, bool suffix = true)
        {
            string[] unitNumbers = new string[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
            string[] placeValues = new string[] { "", "nghìn", "triệu", "tỷ" };
            bool isNegative = false;
            string sNumber = inputNumber.ToString("#");
            double number = Convert.ToDouble(sNumber);
            if (number < 0)
            {
                number = -number;
                sNumber = number.ToString();
                isNegative = true;
            }
            int ones, tens, hundreds;
            int positionDigit = sNumber.Length;   
            string result = " ";
            if (positionDigit == 0)
                result = unitNumbers[0] + result;
            else
            {
                int placeValue = 0;
                while (positionDigit > 0)
                {
                    tens = hundreds = -1;
                    ones = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                    positionDigit--;
                    if (positionDigit > 0)
                    {
                        tens = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                        positionDigit--;
                        if (positionDigit > 0)
                        {
                            hundreds = Convert.ToInt32(sNumber.Substring(positionDigit - 1, 1));
                            positionDigit--;
                        }
                    }

                    if ((ones > 0) || (tens > 0) || (hundreds > 0) || (placeValue == 3))
                        result = placeValues[placeValue] + result;

                    placeValue++;
                    if (placeValue > 3) placeValue = 1;

                    if ((ones == 1) && (tens > 1))
                        result = "một " + result;
                    else
                    {
                        if ((ones == 5) && (tens > 0))
                            result = "lăm " + result;
                        else if (ones > 0)
                            result = unitNumbers[ones] + " " + result;
                    }
                    if (tens < 0)
                        break;
                    else
                    {
                        if ((tens == 0) && (ones > 0)) result = "lẻ " + result;
                        if (tens == 1) result = "mười " + result;
                        if (tens > 1) result = unitNumbers[tens] + " mươi " + result;
                    }
                    if (hundreds < 0) break;
                    else
                    {
                        if ((hundreds > 0) || (tens > 0) || (ones > 0))
                            result = unitNumbers[hundreds] + " trăm " + result;
                    }
                    result = " " + result;
                }
            }
            result = result.Trim();
            if (isNegative) result = "Âm " + result;
            return result + (suffix ? " đồng" : "");
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Excel.Application excelApp = new Excel.Application();
            excelApp.Visible = true; // Hiển thị ứng dụng Excel (tùy chọn)

            // Tạo một Workbook và một Worksheet mới
            Excel.Workbook workbook = excelApp.Workbooks.Add();
            Excel.Worksheet worksheet = (Excel.Worksheet)workbook.Sheets[1];

            // Lấy DataTable từ nguồn dữ liệu của bạn (ví dụ: dataGridview.DataSource)
            DataTable dataTable = CTHD;

            // Thêm tiêu đề tên công ty và tên hóa đơn
            worksheet.Cells[1, 1] = "Cửa hàng Laptop MEOBUNS";
            worksheet.Cells[2, 1] = "Số 1 phố ABC, Quận DEF, Hà Nội";
            worksheet.Cells[3, 1] = "ĐT: 0123.456.789";
            worksheet.Cells[5, 3] = "HÓA ĐƠN BÁN HÀNG";
            // Di chuyển xuống dòng 4 để bắt đầu ghi dữ liệu từ DataTable
            int startRow = 7;

            // Bắt đầu từ hàng startRow, cột 1 của Excel và ghi tiêu đề cột
            int row = startRow;
            int col = 2;
            worksheet.Cells[7, 1] = "STT";
            ((Excel.Range)worksheet.Cells[7, 1]).Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            ((Excel.Range)worksheet.Cells[7, 1]).Borders.Weight = Excel.XlBorderWeight.xlThin;

            // Căn giữa dữ liệu trong ô
            ((Excel.Range)worksheet.Cells[7, 1]).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            foreach (DataColumn column in dataTable.Columns)
            {
                worksheet.Cells[row, col] = column.ColumnName;
                ((Excel.Range)worksheet.Cells[row, col]).EntireColumn.AutoFit();
                ((Excel.Range)worksheet.Cells[row, col]).Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                ((Excel.Range)worksheet.Cells[row, col]).Borders.Weight = Excel.XlBorderWeight.xlThin;

                // Căn giữa dữ liệu trong ô
                ((Excel.Range)worksheet.Cells[row, col]).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                col++;
            }

            // Bắt đầu từ hàng startRow + 1, cột 1 của Excel và ghi dữ liệu từ DataTable
            int count = 1;
            row = startRow + 1;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                worksheet.Cells[row, 1] = count.ToString();
                ((Excel.Range)worksheet.Cells[row, 1]).Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                ((Excel.Range)worksheet.Cells[row, 1]).Borders.Weight = Excel.XlBorderWeight.xlThin;

                // Căn giữa dữ liệu trong ô
                ((Excel.Range)worksheet.Cells[row, 1]).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                col = 2;
                foreach (var item in dataRow.ItemArray)
                {
                   
                    worksheet.Cells[row, col] = item.ToString();
                    ((Excel.Range)worksheet.Cells[row, col]).Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                    ((Excel.Range)worksheet.Cells[row, col]).Borders.Weight = Excel.XlBorderWeight.xlThin;

                    // Căn giữa dữ liệu trong ô
                    ((Excel.Range)worksheet.Cells[row, col]).HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
                    col++;
                   
                }
                row++;
                count++;
            }


            row = row + 3;
            worksheet.Cells[row, 2] = "Tổng số tiền thanh toán: " + txtTongTT.Text;
            row++;
            worksheet.Cells[row, 2] = "Bằng chữ: " + lbTongTT.Text;

            row = row + 3;
            String day = dtpNgayLap.Value.Day.ToString();
            String month = dtpNgayLap.Value.Month.ToString();
            String year = dtpNgayLap.Value.Year.ToString();
            // int month = dtp1.Value.Month;
            // int year = dtp1.Value.Year;
            worksheet.Cells[row-1, 5] = "Ngày " + day + " tháng " + month + " năm " + year;
            worksheet.Cells[row, 5] = "Người lập hóa đơn";
            worksheet.Cells[row, 2] = "Khách hàng";
            row = row + 5;
            worksheet.Cells[row, 5] = txtTenNV.Text;
            worksheet.Cells[row, 2] = txtTenKH.Text;
            // Thông báo hoàn thành
            MessageBox.Show("Xuất Hóa đơn ra file Excel thành công!");

        }
    }
}

