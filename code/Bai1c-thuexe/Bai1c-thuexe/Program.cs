using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1c_thuexe
{
    interface IXe
    {
        double TinhTien();
        void Output();
    }
    class ThueXe
    {
        string ten;
        int gioThue;

        protected ThueXe(string ten, int gioThue)
        {
            this.Ten = ten;
            this.GioThue = gioThue;
        }

        public string Ten { get => ten; set => ten = value; }
        public int GioThue { get => gioThue; set => gioThue = value; }

    }

    // Change the constructors of XeDuLich and XeTai from 'protected' to 'public'
    class XeDuLich : ThueXe, IXe
    {
        public XeDuLich(string ten, int gioThue) : base(ten, gioThue)
        {
        }

        public double TinhTien()
        {
            if (GioThue <= 1) return 250_000;
            return 250_000 + (GioThue - 1) * 70_000;
        }

        public void Output()
        {
            Console.WriteLine($"Ten xe: {Ten}, Gio thue: {GioThue}, Tien thue: {TinhTien()}");
        }
    }
    class XeTai : ThueXe, IXe
    {
        public XeTai(string ten, int gioThue) : base(ten, gioThue)
        {
        }
        public double TinhTien()
        {
            if (GioThue <= 1) return 220_000;
            return 220_000 + (GioThue - 1) * 85_000;
        }
        public void Output()
        {
            Console.WriteLine($"Ten xe: {Ten}, Gio thue: {GioThue}, Tien thue: {TinhTien()}");
        }
    }

    class QuanLy
    {
        private List<IXe> dsXe = new List<IXe>();

        public void ThemXe(IXe xe)
        {
            dsXe.Add(xe);
        }
        public void XuatDS()
        {
            foreach (var xe in dsXe)
            {
                xe.Output();
            }
        }


    }



    internal class Program
    {
        static void Main(string[] args)
        {
            QuanLy quanLy = new QuanLy();
            quanLy.ThemXe(new XeDuLich("Nguyen Van A", 5));
            quanLy.ThemXe(new XeTai("Nguyen Van B", 3));
            quanLy.ThemXe(new XeDuLich("Le Van C", 1));
            quanLy.XuatDS();
            Console.ReadKey();

        }
    }
}
