using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.DTO
{
    public class LoaiSP
    {

        public LoaiSP(int malsp, string tenlsp)
        {
            this.Malsp = malsp;
            this.Tenlsp = tenlsp;
        }

        public LoaiSP(DataRow row)
        {
            this.Malsp = (int)row["MaLoaiSP"];
            this.Tenlsp = row["TenLoaiSP"].ToString();
        }

        private int malsp;

        public int Malsp { get => malsp; set => malsp = value; }

        private string tenlsp;
        public string Tenlsp { get => tenlsp; set => tenlsp = value; }
    }
}
