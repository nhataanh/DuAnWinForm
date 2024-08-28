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
    public partial class QLKH : Form
    {
        public QLKH()
        {
            InitializeComponent();
        }
        //object lengthdata;
        private void GetListKH()
        {
            String query = "SELECT MaKH AS 'Mã khách hàng', TenKH AS 'Tên khách hàng', DiaChi AS 'Địa chỉ',  SDT AS 'Điện thoại' FROM KhachHang";
            DataTable data = KetNoi.Instance.ExecuteQuery(query);
            txtMaKH.Text = "KH" + data.Rows.Count.ToString();
            dgvKhachHang.DataSource = data;

        }
        private void GetListHD()
        {
            String query = String.Format(
                "SELECT * FROM HoaDon where MaKH = N'{0}'",
                txtMaKH.Text
                );
            DataTable data = KetNoi.Instance.ExecuteQuery(query);
           // txtMaKH.Text = "KH" + data.Rows.Count.ToString();
            dgvHDKH.DataSource = data;

        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            GetListKH();
        }

        private void dgvKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMaKH.Text = dgvKhachHang.Rows[index].Cells["Mã khách hàng"].Value.ToString();
                txtTenKH.Text = dgvKhachHang.Rows[index].Cells["Tên khách hàng"].Value.ToString();
                txtDiaChi.Text = dgvKhachHang.Rows[index].Cells["Địa chỉ"].Value.ToString();
                txtDT.Text = dgvKhachHang.Rows[index].Cells["Điện thoại"].Value.ToString();
                btnSua.Enabled = true;
                btnThem.Enabled = false;
                btnXoa.Enabled = true;
                txtMaKH.Enabled = false;
                GetListHD();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
           String query = String.Format(
           "Insert into KhachHang Values (N'{0}',N'{1}',N'{2}',N'{3}')",
           txtMaKH.Text,
           txtDT.Text,
            txtTenKH.Text,
            txtDiaChi.Text
            
           ); ;
            if (KetNoi.Instance.ExecuteNonQuery(query) != 0)
            {
                MessageBox.Show("THÊM KHÁCH HÀNG THÀNH CÔNG");
               btnReload.PerformClick();

            }
            else MessageBox.Show("THÊM KHÁCH HÀNG THẤT BẠI");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            String query = String.Format(
             "Update KhachHang Set TenKH = N'{1}',SDT = {2}, DiaChi = N'{3}' Where MaKH = N'{0}' ",
               txtMaKH.Text,
               txtTenKH.Text,
               txtDT.Text,
               txtDiaChi.Text
             );
            if (KetNoi.Instance.ExecuteNonQuery(query) != 0)
            {
                MessageBox.Show("SỬA THÔNG TIN KHÁCH HÀNG THÀNH CÔNG");
                btnReload.PerformClick();

            }
            else MessageBox.Show("SỬA THÔNG TIN KHÁCH HÀNG THẤT BẠI");
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            GetListKH();
            btnSua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = false;
            txtDiaChi.Text = "";
            txtDT.Text = "";
            txtTenKH.Text = "";
            dgvHDKH.DataSource = null;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            String query = String.Format(
            "Delete from KhachHang Where MaKH = N'{0}'",
            txtMaKH.Text
            );
            if (KetNoi.Instance.ExecuteNonQuery(query) != 0)
            {
                MessageBox.Show("XÓA KHÁCH HÀNG THÀNH CÔNG");
                btnReload.PerformClick();

            }
            else MessageBox.Show("XÓA KHÁCH HÀNG THẤT BẠI");
        }

        private void btnTimKH_Click(object sender, EventArgs e)
        {
            String query = String.Format(
                @"SELECT MaKH AS 'Mã khách hàng', 
TenKH AS 'Tên khách hàng', 
DiaChi AS 'Địa chỉ',  
SDT AS 'Điện thoại' 
FROM KhachHang 
where MaKH like N'%{0}%' or TenKH like N'%{0}%' or SDT like N'%{0}%'",
                txtTim.Text

                );
            DataTable data = KetNoi.Instance.ExecuteQuery(query);
            dgvKhachHang.DataSource = data;
        }

    }
}
