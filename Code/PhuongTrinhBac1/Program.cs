using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongTrinhBac1
{
    class Program
    {
        static void Main(string[] args)
        {
            // ctr + k,d
            // ctr + k + d
            double a, b, x;
            //nhap a,b
            Console.WriteLine("Nhap So A:");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("Nhap So b:");
            b = double.Parse(Console.ReadLine());
            if (a == 0) {
                if (b == 0)
                {
                    Console.WriteLine("PT VS Nghiem");
                }
                else
                {
                    Console.WriteLine("PT Vo nghiem");
                }
            }
            else
            {
                x = -b / a;
                Console.WriteLine("PT {1}x + {2} = 0   X = {0}",x,a,b);
            }

        }
    }
}
