using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Bài 1: Tính chu vi và diện tích của hình chữ nhật khi biết độ dài các cạnh được nhập vào từ bàn phím

namespace Bai1
{
    class Program
    {
        class HinhChuNhat
        {
            private double chieuDai;
            private double chieuRong;

            public void Nhap()
            {
                Console.Write("Nhap vao chieu dai va chieu rong: ");
                chieuDai = double.Parse(Console.ReadLine());
                chieuRong = double.Parse(Console.ReadLine());
            }
            public double TinhChuVi()
            {
                return (chieuDai + chieuRong) * 2;
            }
            public double TinhDienTich()
            {
                return chieuDai * chieuRong;
            }
            public void hien()
            {
                Console.WriteLine("Chu vi hinh chu nhat la: " + TinhChuVi());
                Console.WriteLine("Dien tich hinh chu nhat la: " + TinhDienTich());
            }
            
        };
        static void Main(string[] args)
        { 
            HinhChuNhat hcn = new HinhChuNhat();
            hcn.Nhap();
            hcn.TinhChuVi();
            hcn.TinhDienTich();
            hcn.hien();

        }
    }
}
