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


namespace Demo
{
    public partial class SanPham : Form
    {
        public SanPham()
        {
            InitializeComponent();
        }
        private void GetListDSP()
        {
            String query = "SELECT MaLoaiSP AS 'Mã loại SP', TenLoaiSP AS 'Tên loại SP' FROM LoaiSanPham where isDelete = 0";
            DataTable data = KetNoi.Instance.ExecuteQuery(query);
            dgvDSP.DataSource = data;
            cbMaLoaiSP.DataSource = data;
            cbMaLoaiSP.DisplayMember = "Mã loại SP";
            cbMaLoaiSP.ValueMember = "Mã loại SP";
            cbMaLoaiSP.SelectedIndex = -1;
        }
        private void getcbMaDSP()
        {
            String query = "SELECT MaLoaiSP, TenLoaiSP FROM LoaiSanPham where isDelete = 0";
            DataTable data = KetNoi.Instance.ExecuteQuery(query);
            cbMaLoaiSP.DataSource = data;
            cbMaLoaiSP.DisplayMember = "MaLoaiSP";
            cbMaLoaiSP.ValueMember = "MaLoaiSP";
            cbMaLoaiSP.SelectedIndex = -1;
        }
        private void GetListSP()
        {
            String query = @"
          SELECT
      MaLoaiSP AS 'Mã Loại sản phẩm',
        MaSP AS 'Mã sản phẩm',
        TenSP AS 'Tên sản phẩm',
        Gia AS 'Giá bán',
        SoLuong AS 'Số lượng còn'
          FROM SanPham
          where isDelete = 0 ";  
          DataTable data = KetNoi.Instance.ExecuteQuery(query);
            dgvSanPham.DataSource = data;
        }
        private void ReloadDSP()
        {
            txtMaLSP.Text = "";
            txtTenLSP.Text = "";
            txtTimDSP.Text = "";
            txtMaLSP.Enabled = true;
            btnThemDSP.Enabled = true;
            btnSuaDSP.Enabled = false;
            btnXoaDSP.Enabled = false;
            GetListDSP();

        }
        private void SanPham_Load(object sender, EventArgs e)
        {
            GetListDSP();
            GetListSP();
            ReloadDSP();
            ReloadSanPham();
        }

        private void dgvDSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMaLSP.Text = dgvDSP.Rows[index].Cells["Mã loại SP"].Value.ToString();
                txtTenLSP.Text = dgvDSP.Rows[index].Cells["Tên loại SP"].Value.ToString();
                txtMaLSP.Enabled = false;
                btnThemDSP.Enabled = false;
                btnXoaDSP.Enabled = true;
                btnSuaDSP.Enabled = true;
            }
        }

        private void btnThemDSP_Click(object sender, EventArgs e)
        {
            if (txtMaLSP.Text == "" || txtTenLSP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return;
            }
            String query = String.Format(
              "Insert into LoaiSanPham (MaLoaiSP,TenLoaiSP) Values (N'{0}',N'{1}')",

              txtMaLSP.Text,
              txtTenLSP.Text
            );
            try
            {
                int temp = KetNoi.Instance.ExecuteNonQuery(query);
                MessageBox.Show("THÊM DÒNG SẢN PHẨM THÀNH CÔNG");
                ReloadDSP();

            }
            catch (SqlException ex)
            {
                MessageBox.Show("THÊM DÒNG SẢN PHẨM THẤT BẠI" + ex.Message);
            }
        }

        private void btnSuaDSP_Click(object sender, EventArgs e)
        {
            if (txtMaLSP.Text == "" || txtTenLSP.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin");
                return;
            }
            try
            {
                String query = String.Format(
        @"Update LoaiSanPham Set TenLoaiSP = N'{1}'
                    Where MaLoaiSP = N '{0}'
                    ",
                    txtMaLSP.Text,
              txtTenLSP.Text
            );
                if (KetNoi.Instance.ExecuteNonQuery(query) != 0)
                {
                    MessageBox.Show("SỬA THÔNG TIN DÒNG SẢN PHẨM THÀNH CÔNG");
                    // btnReload.PerformClick();
                    ReloadDSP();
                }
            }
            catch (Exception ex)
            {
                    MessageBox.Show("SỬA THÔNG TIN DÒNG SẢN PHẨM THẤT BẠI" + ex.Message);
            }
            
        }

        private void btnXoaDSP_Click(object sender, EventArgs e)
        {
            try
            {
                String query = String.Format(
             "Update LoaiSanPham set isDelete = 1 Where MaLoaiSP = N'{0}'",
             txtMaLSP.Text
           );
                if (KetNoi.Instance.ExecuteNonQuery(query) != 0)
                {
                    query = String.Format(
                      "Update SanPham set isDelete = 1 Where MaLoaiSP = N'{0}'",
                      txtMaLSP.Text);
                    if (KetNoi.Instance.ExecuteNonQuery(query) != 0)
                    {
                        MessageBox.Show("XÓA DÒNG SẢN PHẨM THÀNH CÔNG");
                        ReloadDSP();
                        ReloadSanPham();
                        getcbMaDSP();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("XÓA DÒNG SẢN PHẨM THẤT BẠI");
            }
             
        }

        private void btnTimDSP_Click(object sender, EventArgs e)
        {
            String query = String.Format(
              "Select * from LoaiSanPham where MaLoaiSP like  N'%{0}%' or TenLoaiSP like N'%{0}%'",
              txtTimDSP.Text
            );
            DataTable data = KetNoi.Instance.ExecuteQuery(query);
            dgvDSP.DataSource = data;
        }

        private void btnRefreshDSP_Click(object sender, EventArgs e)
        {
            ReloadDSP();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                cbMaLoaiSP.SelectedValue = dgvSanPham.Rows[index].Cells["Mã Loại sản phẩm"].Value.ToString();
                txtMaSP.Text = dgvSanPham.Rows[index].Cells["Mã sản phẩm"].Value.ToString();
                txtTenSP.Text = dgvSanPham.Rows[index].Cells["Tên sản phẩm"].Value.ToString();
                txtSL.Text = dgvSanPham.Rows[index].Cells["Số lượng còn"].Value.ToString();
                nmGia.Value = decimal.Parse(dgvSanPham.Rows[index].Cells["Giá bán"].Value.ToString());
                btnThem.Enabled = false;
                txtMaSP.Enabled = false;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnTimSP.Enabled = false;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            String query = String.Format(
              "Insert into SanPham (MaSP,TenSP,MaLoaiSP,Gia,SoLuong) Values (N'{0}',N'{1}',N'{2}',N'{3}',N'{4}')",

              txtMaSP.Text,
              txtTenSP.Text,
              cbMaLoaiSP.SelectedValue,
              nmGia.Value.ToString(),
              txtSL.Text

            );
            if (KetNoi.Instance.ExecuteNonQuery(query) != 0)
            {
                MessageBox.Show("THÊM SẢN PHẨM THÀNH CÔNG");
                // btnReload.PerformClick();

                ReloadSanPham();
            }
            else MessageBox.Show("THÊM SẢN PHẨM THẤT BẠI");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            String query = String.Format(
        @"Update SanPham 
     
              Set MaLoaiSP = N'{2}',
              TenSP = N'{1}',
              Gia = N'{3}',
              SoLuong = N'{4}'
              Where MaSP = N'{0}'

              ",
      
              txtMaSP.Text,
              txtTenSP.Text,
              cbMaLoaiSP.SelectedValue,
              nmGia.Value.ToString(),
              txtSL.Text

            );
            if (KetNoi.Instance.ExecuteNonQuery(query) != 0)
            {
                MessageBox.Show("SỬA THÔNG TIN SẢN PHẨM THÀNH CÔNG");
                // btnReload.PerformClick();
                ReloadSanPham();
            }
            else MessageBox.Show("SỬA THÔNG TIN SẢN PHẨM THẤT BẠI");
        }
        private void ReloadSanPham()
        {
            GetListSP();
            getcbMaDSP();
            cbMaLoaiSP.SelectedIndex = -1;
            txtMaSP.Text = "";
            txtTenSP.Text = "";
            txtSL.Text = "";
            nmGia.Value = 0;
            txtMaSP.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnTimSP.Enabled = true;
        }
        private void btnReload_Click(object sender, EventArgs e)
        {
            ReloadSanPham();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {

            String query = String.Format(
              // "Delete from SanPham Where MaSP = N'{0}'",
              "Update SanPham set isDelete = 1 where MaSP = N'{0}'",
              txtMaSP.Text
            );
            if (KetNoi.Instance.ExecuteNonQuery(query) != 0)
            {
                MessageBox.Show("XÓA SẢN PHẨM THÀNH CÔNG");
                ReloadSanPham();
            }
            else MessageBox.Show("XÓA SẢN PHẨM THẤT BẠI");
        }

        private void btnTimSP_Click(object sender, EventArgs e)
        {
            String query = String.Format(
        @"  SELECT 
      
              MaLoaiSP AS 'Mã Loại sản phẩm',
              MaSP AS 'Mã sản phẩm',
              TenSP AS 'Tên sản phẩm',
              Gia AS 'Giá bán',
              SoLuong AS 'Số lượng còn'
      
              from SanPham where MaSP like N'%{0}%'
      
              or TenSP like N'%{0}%'
      
              and isDelete = 0 ",
      
              txtTimSP.Text
            );
            DataTable data = KetNoi.Instance.ExecuteQuery(query);
            dgvSanPham.DataSource = data;
        }


    }
}