using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDungTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Cau truc len try catch
            //         try
            //{
            //             double a = double.Parse(Console.ReadLine());

            //             if (a < 0)
            //                 throw new Exception("Gia Tri Nhap Phải Lớn Hơn 0");

            //         }
            //catch (Exception ex)
            //{
            //             Console.WriteLine(ex.Message);

            //         } 
            #endregion

            #region Giải phuong Trinh bac1
            //try
            //{
            //    Double a, b, x;
            //    Console.WriteLine("Nhap A");
            //    a = double.Parse(Console.ReadLine());
            //    double.TryParse(Console.ReadLine(), out a);

            //    Console.WriteLine("Nhap B");
            //    b = double.Parse(Console.ReadLine());
            //    if (a == 0)
            //    {
            //        if (b == 0)
            //        {
            //            throw new Exception("PT Vo So Nghiem");
            //        }
            //        else
            //        {
            //            throw new Exception("PT Vo Nghiem");
            //        }
            //    }
            //    // a chac chan != 0 
            //    x = -b / a;
            //    Console.WriteLine("PT Co Nghiem la:{0} ", x);

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            #endregion

            #region du dung TryParse
            double a, b, c;
            Console.WriteLine("nhap a");
            bool kt = double.TryParse(Console.ReadLine(), out a);
            if(kt == false)
            {
                Console.WriteLine("A nhap khong Dung");
            }

            Console.WriteLine("nhap b");
            double.TryParse(Console.ReadLine(), out b);
            Console.WriteLine("nhap c");
            double.TryParse(Console.ReadLine(), out c);

            Console.WriteLine("nhap {0},{1},{2}",a,b,c);
            #endregion
        }
    }
}
