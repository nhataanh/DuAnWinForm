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
    public partial class TrangChu : Form
    {
        public TrangChu()
        {
            InitializeComponent();
            lbName.Text = DangNhap.TenTK;
            if (DangNhap.ChucVu == "0")
                btnAdmin.Visible = false;
        }
        private Form currentFormChild;
        private void OpenChildForm(Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_Body.Controls.Add(childForm);
            panel_Body.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Admin());
            lbTrangChu.Text = "ADMIN";
        }


        private void imgHomePage_Click(object sender, EventArgs e)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
                lbTrangChu.Text = "TRANG CHỦ";
            }
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBill_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormBill());
            lbTrangChu.Text = "BILL";
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            OpenChildForm(new SanPham());
            lbTrangChu.Text = "DANH SÁCH SẢN PHẨM";
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QLKH());
            lbTrangChu.Text = "DANH SÁCH KHÁCH HÀNG";
        }

        private void btNDanhMuc_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BaoCao());
            lbTrangChu.Text = "THỐNG KÊ";
        }

    }
}
