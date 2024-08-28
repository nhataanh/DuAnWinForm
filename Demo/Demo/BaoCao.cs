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
    public partial class BaoCao : Form
    {
        public BaoCao()
        {
            InitializeComponent();
            dtpNgayBD.Value = DateTime.Now;
            dtpNgayKT.Value = DateTime.Now;
            dtpNgayBD.CustomFormat = "dd/MM/yyyy";
            dtpNgayKT.CustomFormat = "dd/MM/yyyy";
        }

        private void TKHang()
        {
            String SHH = @"Select 
MaSP as 'Mã sản phẩm',
TenSP as 'Tên sản phẩm',
MaLoaiSP as 'Loại sản phẩm',
SoLuong as 'Số lượng tồn'
from SanPham where SoLuong <= 3 and isDelete != 1
";
            DataTable dataSHH = KetNoi.Instance.ExecuteQuery(SHH);
            dgvHangSapHet.DataSource = dataSHH;
            String CH = @"Select 
MaSP as 'Mã sản phẩm',
TenSP as 'Tên sản phẩm',
MaLoaiSP as 'Loại sản phẩm',
SoLuong as 'Số lượng tồn'
from SanPham where SoLuong > 3 and isDelete != 1
";
            DataTable dataCH = KetNoi.Instance.ExecuteQuery(CH);
            dgvConHang.DataSource = dataCH;
        }

        private void TKBanHang()
        {
            String BanChay = String.Format(@"
SELECT CTHoaDon.MaSp as 'Mã sản phẩm', 
TenSP as 'Tên sản phẩm' ,
SUM(CTHoaDon.SoLuong) AS 'Số lượng bán ra', 
SUM(ThanhTien) AS 'Doanh thu'
FROM CTHoaDon
JOIN HoaDon ON CTHoaDon.MaHD = HoaDon.MaHD
JOIN SanPham ON SanPham.MaSP = CTHoaDon.MaSp
WHERE HoaDon.NgayMH BETWEEN N'{0}' AND N'{1}'
GROUP BY CTHoaDon.MaSp, TenSP
ORDER BY 'Doanh thu' DESC", dtpNgayBD.Value.ToString(),
dtpNgayKT.Value.ToString());
            DataTable dataBanChay = KetNoi.Instance.ExecuteQuery(BanChay);
            dgvBanChay.DataSource = dataBanChay;

            String DoanhThu = String.Format(@"SELECT SUM(TongTien) AS DoanhThu
FROM HoaDon
WHERE HoaDon.NgayMH BETWEEN N'{0}' AND N'{1}'
", dtpNgayBD.Value.ToString(),
dtpNgayKT.Value.ToString());
            DataTable dataDoanhThu = KetNoi.Instance.ExecuteQuery(DoanhThu);
            txtDoanhThu.Text = dataDoanhThu.Rows[0]["DoanhThu"].ToString();

            String SoHD = String.Format(@"SELECT COUNT(*) as sohd
FROM HoaDon
WHERE HoaDon.NgayMH BETWEEN N'{0}' AND N'{1}'
", dtpNgayBD.Value.ToString(),
dtpNgayKT.Value.ToString());
            DataTable dataSHD = KetNoi.Instance.ExecuteQuery(SoHD);
            txtSoHD.Text = dataSHD.Rows[0]["sohd"].ToString();

        }



        private void DanhMuc_Load(object sender, EventArgs e)
        {
            TKHang();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            TKBanHang();
        }
    }
}
