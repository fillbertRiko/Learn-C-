using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    class HinhChuNhat
    {
        private double chieuDai, chieuRong;

        public void Nhap()
        {
            Console.WriteLine("Nhap vao do dai 2 canh hinh chu nhat");
            Console.WriteLine("Nhap vao chieu dai: ");
            chieuDai = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao chieu rong: ");
            chieuRong = double.Parse(Console.ReadLine());
        }

        public double TinhDienTich()
        {
            return chieuRong * chieuDai;
        }

        public double TinhChuVi()
        {

            return (chieuDai + chieuRong) * 2;
        }

        public void Show()
        {
            Console.WriteLine("Dien tich hinh chu nhat la: " + TinhDienTich());
            Console.WriteLine("Chu vi hinh chu nhat la: " + TinhChuVi());
        }
    }
}
