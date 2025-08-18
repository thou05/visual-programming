using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DanhSachSV it1 = new DanhSachSV();
            it1.nhapDanhSach();
            Console.WriteLine("So luong sinh vien dat chuyen de: " + it1.countChuyenDe());
            Console.WriteLine("So luong sinh vien dat khoa luan: " + it1.countKhoaLuan());
            Console.ReadLine();
        }
    }
}
