using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1a_thi_sinh
{
    class ThiSinh
    {
        string sbd, ht;
        double m1,m2, m3;

        public void Input()
        {
            Console.Write("Nhap so bao danh: ");
            sbd = Console.ReadLine();
            Console.Write("Nhap ho ten: ");
            ht = Console.ReadLine();
            Console.Write("Nhap diem mon 1: ");
            m1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap diem mon 2: ");
            m2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Nhap diem mon 3: ");
            m3 = Convert.ToDouble(Console.ReadLine());
        }
        public void Output()
        {
            Console.WriteLine("So bao danh: " + sbd);
            Console.WriteLine("Ho ten: " + ht);
            Console.WriteLine("Diem mon 1: " + m1);
            Console.WriteLine("Diem mon 2: " + m2);
            Console.WriteLine("Diem mon 3: " + m3);
        }
        public double TongDiem()
        {
            return m1 + m2 + m3;
        }
    }

    class TuyenSinh : ThiSinh
    {
        int khuVuc;

        public void InputTS()
        {
            Console.Write("Nhap khu vuc: ");
            khuVuc = Convert.ToInt32(Console.ReadLine());
        }
        public void OutputTS()
        {
            Console.WriteLine("Khu vuc: " + khuVuc);
        }
        public double DiemUuTien()
        {
            //if (khuVuc == 1)
            //    return TongDiem();
            if (khuVuc == 2)
                return TongDiem() + 1;
            else if (khuVuc == 3)
                return TongDiem() + 2;
            else
                return TongDiem();
        }

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.Write("Nhap so thi sinh: ");
            n = Convert.ToInt32(Console.ReadLine());
            TuyenSinh[] ts = new TuyenSinh[n+1];
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Nhap thong tin thi sinh thu " + i + ":");
                ts[i] = new TuyenSinh();
                ts[i].Input();
                ts[i].InputTS();
            }

            int diemChuan;
            Console.Write("Nhap diem chuan: ");
            diemChuan = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Danh sach thi sinh trung tuyen:");
            for (int i = 1; i <= n; i++)
            {
                if (ts[i].DiemUuTien() >= diemChuan)
                {
                    ts[i].Output();
                    ts[i].OutputTS();
                    Console.WriteLine("Tong diem: " + ts[i].TongDiem());
                    Console.WriteLine("Diem uu tien: " + ts[i].DiemUuTien());
                }
            }
        }
    }
}
