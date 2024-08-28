using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        private String SelectedTenHT;
        private String SelectedTaiKhoan;
        private String SelectedMatKhau;
        private String SelectedChucVu;
        private void GetListTK()
        {
            String query = "SELECT TenND AS 'Tên hiển thị', TaiKhoan AS 'Tên tài khoản', MatKhau AS 'Mật khẩu', CASE WHEN ChucVu = 1 THEN 'Admin' WHEN Chucvu = 0 THEN 'Nhân viên' ELSE 'Khác' END AS 'Chức vụ' FROM NguoiDung";
            DataTable data = KetNoi.Instance.ExecuteQuery(query);
            dgvTaiKhoan.DataSource = data;
        }
        private void GetListNV()
        {
            String query = @"SELECT 
               MaNV as 'Mã nhân viên',
                TenNV as 'Tên nhân viên',
                SDT as 'Điện thoại',
                DiaChi as 'Địa chỉ'
FROM NhanVien where isDelete = 0";
            DataTable data = KetNoi.Instance.ExecuteQuery(query);
            dgvNhanVien.DataSource = data;
        }
        private void GetListSV()
        {
            List<DTO.ChucVu> items = new List<DTO.ChucVu>();
            items.Add(new DTO.ChucVu() { Value = "Nhân viên", Text = "Nhân viên" });
            items.Add(new DTO.ChucVu() { Value = "Admin", Text = "Admin"});
            cmbChucVu.DataSource = items;
            cmbChucVu.ValueMember = "Value";
            cmbChucVu.DisplayMember = "Text";
            cmbChucVu.SelectedValue = "";
        }
        private void Admin_Load(object sender, EventArgs e)
        {

            ReloadNV();
            ReloadTK();
        }

        private void dgvTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtTenHT.Text = dgvTaiKhoan.Rows[index].Cells["Tên hiển thị"].Value.ToString();
                txtTaiKhoan.Text = dgvTaiKhoan.Rows[index].Cells["Tên tài khoản"].Value.ToString();
                txtMatKhau.Text = dgvTaiKhoan.Rows[index].Cells["Mật khẩu"].Value.ToString();
                cmbChucVu.SelectedValue = dgvTaiKhoan.Rows[index].Cells["Chức vụ"].Value.ToString();
                SelectedTenHT = dgvTaiKhoan.Rows[index].Cells["Tên hiển thị"].Value.ToString();
                SelectedTaiKhoan = dgvTaiKhoan.Rows[index].Cells["Tên tài khoản"].Value.ToString();
                SelectedMatKhau = dgvTaiKhoan.Rows[index].Cells["Mật khẩu"].Value.ToString();
                btnSua.Enabled = true;
                btnThem.Enabled = false;
                btnXoa.Enabled = true;
            }
        }
        private void ReloadTK()
        {
            GetListTK();
            GetListSV();
            btnSua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            txtTenHT.Text = "";
            txtTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            cmbChucVu.SelectedValue = "";
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            ReloadTK();
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "" || txtTenHT.Text == "" || cmbChucVu.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return;
            }
            try
            {
                String chucvu;
                if (cmbChucVu.SelectedValue == "Admin") chucvu = "1";
                else chucvu = "0";
                String query = String.Format(
                  "Insert into NguoiDung Values (N'{0}',N'{1}',N'{2}',N'{3}')",
                  txtTenHT.Text,
                  txtTaiKhoan.Text,
                  txtMatKhau.Text,
                  chucvu
                  ); ;
                if (KetNoi.Instance.ExecuteNonQuery(query) != 0)
                {
                    MessageBox.Show("THÊM TÀI KHOẢN THÀNH CÔNG");
                    btnReload.PerformClick();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("THÊM TÀI KHOẢN THẤT BẠI" + ex.Message);
            }
            
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "" || txtMatKhau.Text == "" || txtTenHT.Text == "" || cmbChucVu.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return;
            }
            try
            {
                String Chucvu;
                String ChucvuSua;
                if (cmbChucVu.SelectedValue == "Admin") Chucvu = "1";
                else Chucvu = "0";
                if (SelectedChucVu == "Admin") ChucvuSua = "1";
                else ChucvuSua = "0";
                String query = String.Format(
                @"Update NguoiDung Set TenND = N'{0}',
                    TaiKhoan = N'{1}',
                   MatKhau = N'{2}', 
                    ChucVu = N'{3}' 
                    Where TenND = N'{4}' and
                    TaiKhoan = N'{5}' and
                   MatKhau = N'{6}' and
                    ChucVu = N'{7}'            
                    ",
                  txtTenHT.Text,
                  txtTaiKhoan.Text,
                  txtMatKhau.Text,
                  Chucvu,
                  SelectedTenHT,
                  SelectedTaiKhoan,
                  SelectedMatKhau,
                  ChucvuSua

                 );
                if (KetNoi.Instance.ExecuteNonQuery(query) != 0)
                {
                    MessageBox.Show("CẬP NHẬT THÔNG TIN TÀI KHOẢN THÀNH CÔNG");
                    btnReload.PerformClick();
                }
            }
            catch (Exception ex)
            {
                 MessageBox.Show("CẬP NHẬT THÔNG TIN TÀI KHOẢN THẤT BẠI" + ex.Message);
            }
            
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                String query = String.Format(
            "Delete from NguoiDung Where TaiKhoan = N'{0}'",
            txtTaiKhoan.Text
            );
                if (KetNoi.Instance.ExecuteNonQuery(query) != 0)
                {
                    MessageBox.Show("XÓA TÀI KHOẢN THÀNH CÔNG");
                    btnReload.PerformClick();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("XÓA TÀI KHOẢN THẤT BẠI" +ex.Message);
            }
             
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaNV.Text == "" || txtTenNV.Text == "" || txtDT.Text == "" || txtDiaChi.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập đủ thông tin");
                    return;
                }
                String query = String.Format(
             "Insert into NhanVien (MaNV,TenNV,SDT,DiaChi) Values (N'{0}',N'{1}',N'{2}',N'{3}')",
             txtMaNV.Text,
             txtTenNV.Text,
             txtDT.Text,
             txtDiaChi.Text
             );
                if (KetNoi.Instance.ExecuteNonQuery(query) != 0)
                {
                    MessageBox.Show("THÊM NHÂN VIÊN THÀNH CÔNG");
                    ReloadNV();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("THÊM NHÂN VIÊN THẤT BẠI" + ex.Message);
            }
           
             
        }
        private void ReloadNV()
        {
            GetListNV();
            txtMaNV.Text = "";
            txtTenNV.Text = "";
            txtDT.Text = "";
            txtDiaChi.Text = "";
            btnThemNV.Enabled = true;
            btnSuaNV.Enabled = false;
            btnXoaNV.Enabled = false;
            txtMaNV.Enabled = true;

        }
        private void btnReloadNV_Click(object sender, EventArgs e)
        {
            ReloadNV();
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            if (txtMaNV.Text == "" || txtTenNV.Text == "" || txtDT.Text == "" || txtDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return;
            }
            try
            {
                String query = String.Format(
         @"Update NhanVien Set 
                   TenNV = N'{1}',
                    SDT = N'{2}',
                    DiaChi = N'{3}'
                    Where MaNV = N'{0}'    
                    ",
          txtMaNV.Text,
          txtTenNV.Text,
          txtDT.Text,
          txtDiaChi.Text

          );
                if (KetNoi.Instance.ExecuteNonQuery(query) != 0)
                {
                    MessageBox.Show("SỬA THÔNG TIN NHÂN VIÊN THÀNH CÔNG");
                    ReloadNV();

                }
            }
          catch (Exception ex)
            {
                MessageBox.Show("SỬA THÔNG TIN NHÂN VIÊN THẤT BẠI");

            }
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMaNV.Text = dgvNhanVien.Rows[index].Cells["Mã nhân viên"].Value.ToString();
                txtTenNV.Text = dgvNhanVien.Rows[index].Cells["Tên nhân viên"].Value.ToString();
                txtDT.Text = dgvNhanVien.Rows[index].Cells["Điện thoại"].Value.ToString();
                txtDiaChi.Text = dgvNhanVien.Rows[index].Cells["Địa chỉ"].Value.ToString();
                btnThemNV.Enabled = false;
                btnSuaNV.Enabled = true;
                btnXoaNV.Enabled = true;
                txtMaNV.Enabled = false;
            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            try
            {
 String query = String.Format(
           "Update NhanVien set isDelete = 1 where MaNV = N'{0}'",
           txtMaNV.Text
           );
            if (KetNoi.Instance.ExecuteNonQuery(query) != 0)
            {
                MessageBox.Show("XÓA NHÂN VIÊN THÀNH CÔNG");
                ReloadNV();
            }
            }
           catch (Exception ex)
            {
 MessageBox.Show("XÓA NHÂN VIÊN THẤT BẠI");
            }
            
        }
    }
}

