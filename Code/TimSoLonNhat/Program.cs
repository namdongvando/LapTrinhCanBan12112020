using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimSoLonNhat
{
    class Program
    {
        static void Main(string[] args)
        {
            Double a, b, c, max,min;

            Console.WriteLine("nhap A");
            a = double.Parse(Console.ReadLine());
            Console.WriteLine("nhap B");
            b = double.Parse(Console.ReadLine());
            Console.WriteLine("nhap C");
            c = double.Parse(Console.ReadLine());

            max = a;
            //if (max < b)
            //    max = b;
            //if (max < c)
            //    max = c;
            if(max<b)
            {
                max = b;
            }
            if (max < c)
            {
                max = c;
            }
            Console.WriteLine(
                "Gia Tri lon nhat la: {0}", max);
            min = a;
            if (min > b)
            {
                min = b;
            }
            if (min > c)
            {
                min = c;
            }
            Console.WriteLine(
                "Gia Tri nho nhat la: {0}", min);

        }
    }
}
