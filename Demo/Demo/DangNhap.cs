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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }
        private void txtTaiKhoan_Enter(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "UserName")
            {
                txtTaiKhoan.Text = "";
                txtTaiKhoan.ForeColor = Color.Black;
            }
        }

        private void txtTaiKhoan_Leave(object sender, EventArgs e)
        {
            if (txtTaiKhoan.Text == "")
            {
                txtTaiKhoan.Text = "UserName";
                txtTaiKhoan.ForeColor = Color.Gray;
            }
        }

        private void txtMatKhau_Enter(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "PassWord")
            {
                txtMatKhau.Text = "";
                txtMatKhau.ForeColor = Color.Black;
            }
        }

        private void txtMatKhau_Leave(object sender, EventArgs e)
        {
            if (txtMatKhau.Text == "")
            {
                txtMatKhau.Text = "PassWord";
                txtMatKhau.ForeColor = Color.Gray;
            }
        }
        static public String TenTK;
        static public String ChucVu;
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string TaiKhoan = txtTaiKhoan.Text;
            string MatKhau = txtMatKhau.Text;
            if (Login(TaiKhoan, MatKhau))
            {
                TrangChu frm = new TrangChu();
                this.Hide();
                frm.ShowDialog();
                this.Show();
                txtMatKhau.Text = "PassWord";
                txtMatKhau.ForeColor = Color.Gray;
                txtTaiKhoan.Text = "UserName";
                txtTaiKhoan.ForeColor = Color.Gray;
            }
            else
            {
                MessageBox.Show("Nhập sai tên đăng nhập hoặc mật khẩu!");
            }
        }

        bool Login(string TaiKhoan,string MatKhau)
        {
            string query = "PR_Login @TaiKhoan ,  @MatKhau";
            DataTable result = KetNoi.Instance.ExecuteQuery(query, new object[] { TaiKhoan, MatKhau });
            if (result.Rows.Count > 0)
            {
                TenTK = result.Rows[0]["TenND"].ToString();
                ChucVu = result.Rows[0]["ChucVu"].ToString();
            }
            return result.Rows.Count > 0;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void DangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Bạn có thật sự thoát chương trình?","Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
    }
}
