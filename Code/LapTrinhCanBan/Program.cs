using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LapTrinhCanBan
{
    class Program
    {
        static void Main(string[] args)
        {
            // xuất ra màn hình
            Console.WriteLine("Xin Chào");
            Console.WriteLine("Nhap Ten");
            // nhap từ bàn phím
            string hoTen = Console.ReadLine();
            Console.WriteLine("Xin chao: " + hoTen);
            int a = 1;
            int b = 3;
            int c = b;
            b = a;
            a = c;

         Console.WriteLine("A ={0} B = {1} ", a, b);

            Console.WriteLine("Tong Cua a + b = " + (a + b));
            Console.ReadKey();
        }
    }
}
