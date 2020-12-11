using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongTrinhBac2
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b, c ,d ,x1,x2;
            Console.WriteLine("nhap A");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("nhap B");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("nhap C");
            c = double.Parse(Console.ReadLine());
                        //d = b * b - 4 * a * c;
            d = Math.Pow(b, 2) - 4 * a * c;
            if (d < 0)
            {
                Console.WriteLine("Phuong Trình Vo Nghiem");
            }
            else {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                Console.WriteLine("x1= {0}  x2= {1}",x1,x2);
                
            }

        }
    }
}
