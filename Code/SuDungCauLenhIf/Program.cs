using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDungCauLenhIf
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nguyen a");
            string nhap = Console.ReadLine();
            int a;
            a = int.Parse(nhap);


            if (a % 2 == 0)
            {
                Console.WriteLine("{0} la so chan", a);
            }
            else {
                Console.WriteLine("{0} la so le", a);
            }

        }
    }
}
