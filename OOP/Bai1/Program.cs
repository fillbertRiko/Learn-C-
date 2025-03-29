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
        
        static void Main(string[] args)
        { 
            HinhChuNhat hcn = new HinhChuNhat();
            hcn.Nhap();
            hcn.TinhChuVi();
            hcn.TinhDienTich();
            hcn.Show();

        }
    }
}
