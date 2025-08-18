using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    internal class SinhVien
    {
        private string hoTen;
        private string ngaySinh;
        private float diemLapTrinh, diemCSDL, diemWebDes;
       

        public SinhVien() {}
        public SinhVien(string hoTen, string ngaySinh, float diemLapTrinh, float diemCSDL, float diemWebDes)
        {
            this.hoTen = hoTen;
            this.ngaySinh = ngaySinh;
            this.diemLapTrinh = diemLapTrinh;
            this.diemCSDL = diemCSDL;
            this.diemWebDes = diemWebDes;
        }
        //input methods
        public void input()
        {
            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhap ngay sinh: ");
            ngaySinh = Console.ReadLine();
            Console.Write("Nhap diem lap trinh: ");
            diemLapTrinh = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem CSDL: ");
            diemCSDL = float.Parse(Console.ReadLine());
            Console.Write("Nhap diem web design: ");
            diemWebDes = float.Parse(Console.ReadLine());
        }
        public void output()
        {
            Console.WriteLine(hoTen + "\t" + ngaySinh + "\t" + diemLapTrinh + "\t" + diemCSDL + "\t" + diemWebDes);

        }
        private float diemTrungBinh()
        {
            return (diemLapTrinh + diemCSDL + diemWebDes) / 3;
        }

        private bool checkTren5()
        {
            if(diemLapTrinh >= 5 && diemCSDL >= 5 && diemWebDes >= 5)
            {
                return true;
            }
            return false;
        }

        //check lam do an tot nghiep
        public bool checkChuyenDe() {
            bool check = false;
            if(checkTren5() == true && diemTrungBinh() < 8)
            {
                check = true;
            }
            return check;
        }

        //check khoa luan
        public bool checkKhoaLuan()
        {
     
            bool check = false;
            if(checkTren5() == true && diemTrungBinh() < 8)
            {
              
                    check = true;
                
            }

            return check;
        }
    }
}
