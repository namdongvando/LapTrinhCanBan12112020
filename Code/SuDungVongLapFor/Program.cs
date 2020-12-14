using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDungVongLapFor
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Tinh Giai Thua
            // nhap n tu ban phim
            //int n,gt;
            //int.TryParse(Console.ReadLine(), out n);
            //gt = 1;
            //for (int i = 1; i <=n ; i++)
            //{
            //    gt = gt * i;
            //}
            //Console.WriteLine("{0}! = {1}", n, gt);

            //for (int i = 0; i < 100; i++)
            //{
            //    Console.WriteLine(i);
            //    Console.WriteLine("xin chao");
            //}
            #endregion

            #region tin Tong tu 1 toi n
            // nhap n tu ban phim
            //int n, tong = 0;
            //int.TryParse(Console.ReadLine(), out n);

            //for (int i = 1 ; i <= n; i++)
            //{
            //    tong += i;
            //    // tong +=i <=> tong = tong +i;
            //}
            //Console.WriteLine("Tong la {0}", tong);

            #endregion

            #region xuat 1-n
            //int n;
            //Console.WriteLine("Nhap N");
            //int.TryParse(Console.ReadLine(), out n);
            //for (int i = 1; i <= n; i++)
            //{
            //    Console.WriteLine(i);
            //    // so chan
            //    if (i % 2 == 0)
            //        Console.WriteLine("{0} la so chan ", i);
            //    else
            //        Console.WriteLine("{0} la so le", i);
            //}


            #endregion

            #region bang cu chuong

            //for (int i = 2; i <= 9; i++)
            //{
            //    Console.WriteLine("==========");
            //    for (int j = 1; j <= 9; j++)
            //    {
            //        Console.WriteLine("{0} X {2} = {1}"
            //            , i, i * j,j);
            //    }
            //    Console.WriteLine("==========");


            //}

            #endregion
            #region dung len while
            //int n = 9;
            //int tong = 0;
            //int i = 1;
            //while (i<=n)
            //{
            //    tong += i;
            //    i++;
            //}
            //Console.WriteLine("Tong {0}", tong);
            #endregion
            #region Xac nguyen to
            int n = 9;
            int i = 2;
            while (true)
            {
                if(n%i == 0)
                {
                    if (i == n)
                    {
                        Console.WriteLine("{0} la so nguyen to");
                    }
                    else
                    {
                        Console.WriteLine("{0} khong la so nguyen to");
                    }
                    break;
                }
                i++;
            }


            #endregion

        }
    }
}
