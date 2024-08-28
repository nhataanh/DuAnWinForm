using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class clDangNhap
    {
        private static clDangNhap instance;

        public static clDangNhap Instance 
        { 
            get { if (instance == null) instance = new clDangNhap(); return instance; }
            private set { instance = value; }
        }

        private clDangNhap() { }
        public bool Login(string TaiKhoan, string MatKhau)
        {
            string query = "PR_Login @TaiKhoan ,  @MatKhau";
            DataTable result = KetNoi.Instance.ExecuteQuery(query, new object[] { TaiKhoan, MatKhau });
            return result.Rows.Count > 0;
        }
    }
}
