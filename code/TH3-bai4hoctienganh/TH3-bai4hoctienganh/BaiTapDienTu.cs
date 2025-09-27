using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH3_bai4hoctienganh
{
    public class BaiTapDienTu
    {
        private string debai;
        private string dapan;
        private List<string> dapantungcau;

        public BaiTapDienTu() { }

        public BaiTapDienTu(string debai, string dapan)
        {
            this.Debai = debai;
            this.Dapan = dapan;
        }

        public BaiTapDienTu(string debai, string dapan, List<string> dapantungcau) : this(debai, dapan)
        {
            this.Dapantungcau = dapantungcau;
        }

        public string Debai { get => debai; set => debai = value; }
        public string Dapan { get => dapan; set => dapan = value; }
        public List<string> Dapantungcau { get => dapantungcau; set => dapantungcau = value; }
    }
}
