using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    internal class DanhSachSV
    {
        int n;
        SinhVien[] sv;

        public void nhapDanhSach()
        {
            Console.Write("Nhap so luong sinh vien: ");
            n = int.Parse(Console.ReadLine());
            sv = new SinhVien[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Nhap thong tin sinh vien thu " + (i + 1) + ":");
                sv[i] = new SinhVien();
                sv[i].input();
            }
        }

        public int countChuyenDe()
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (sv[i].checkChuyenDe())
                {
                    count++;
                }
            }
            return count;
        }

        public int countKhoaLuan()
        {
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (sv[i].checkKhoaLuan())
                {
                    count++;
                }
            }
            return count;
        }
    }
}
