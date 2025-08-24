using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CawnHoHCN
{
    class HCN
    {
        double cd, cr;

        public double Cd { get => cd; set => cd = value; }
        public double Cr { get => cr; set => cr = value; }

        public void input()
        {
            Cd = double.Parse(Console.ReadLine());
            Cr = double.Parse(Console.ReadLine());
        }

        public void output()
        {
            Console.WriteLine("cd " + Cd.ToString("0.00") + " cr " + Cr.ToString("0.00"));
        }
        public double area()
        {
            return Cd * Cr;
        }



    }

    class CanHo
    {
        int maPhong;
        HCN kichThuoc;

        public HCN KichThuoc { get => kichThuoc; set => kichThuoc = value; }

        public void input()
        {
            maPhong = int.Parse(Console.ReadLine());
            KichThuoc = new HCN();
            KichThuoc.input();
        }
        public void output()
        {
            Console.WriteLine("\nMa phong: " + maPhong.ToString());
            KichThuoc.output();
            Console.WriteLine("Dien tich: " + KichThuoc.area().ToString());
        }
    }

    class CHNew : CanHo
    {
        string huongBC;

        public CHNew(): base()
        {
            HuongBC = "Huong Nam";
        }

        public string HuongBC { get => huongBC; set => huongBC = value; }

        public void inputNew()
        {
            base.input();
            Console.WriteLine("Nhap huong ban cong: ");
            HuongBC = Console.ReadLine();
        }
        public void outputNew()
        {
            base.output();
            Console.WriteLine("Huong ban cong: " + HuongBC);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            CanHo[] h = new CanHo[200];
            n = int.Parse(Console.ReadLine());
            for(int i = 1; i <= n; i++)
            {
                h[i] = new CawnHoHCN.CanHo();
                h[i].input();
            }
            for(int i = 1; i <= n; i++)
            {
                h[i].output();
            }

            double max;
            CanHo chMax = h[1];
            max = h[1].KichThuoc.area();
            for(int i = 2; i <= n; i++)
            {
                if(h[i].KichThuoc.area() > max)
                {
                    max = h[i].KichThuoc.area();
                    chMax = h[i];
                }
            }
            Console.WriteLine("\nCan ho co dien tich lon nhat: ");
            chMax.output();
            Console.ReadKey();

            CHNew[] hn = new CHNew[200];
            for(int i = 1; i <= n; i++)
            {
                hn[i] = new CHNew();
                hn[i].inputNew();
            }
            string huongTk;
            bool found = false;
            huongTk = Console.ReadLine();
            for(int i = 1; i <= n; i++)
            {
                if (huongTk == hn[i].HuongBC)
                {
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Het can huong ", huongTk);
            }
            else
            {
                Console.WriteLine("\nKQ tim kiem:\n");
                for(int i = 1; i <= n; i++)
                {
                    if(string.Compare(huongTk, hn[i].HuongBC) == 0)
                    {
                        hn[i].outputNew();
                    }
                }
            }
        }
    }
}
