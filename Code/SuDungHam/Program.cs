using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDungHam
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = NhapSoNguyen("Nhap So Nguyen a");
            int b = NhapSoNguyen("Nhap So Nguyen b");
            int c = NhapSoNguyen("Nhap So Nguyen c");
            //int max = TimSoLonNhat(a, b, c);
        }

        private static int NhapSoNguyen(string thongBao)
        {
            Console.WriteLine(thongBao);
            // coi nhu nhap sai
            bool kt = false;
            int a =0;
            while(kt == false)
            {
                kt = int.TryParse(Console.ReadLine(), out a);
                if (kt == false)
                    Console.WriteLine("Nhap Lai: ");
            }
            return a;
        }

        private static void PhuongTrinhBac1(double a, double b)
        {

            if (a == 0)
                if (b == 0)
                    Console.WriteLine("PT VSN");
                else
                    Console.WriteLine("PT VN");

            Console.WriteLine("PT X = {0}", -b / a);
        }

        private static void XinChao(string hoTen)
        {
            Console.WriteLine("Xin chao! {0}", hoTen);
        }

        private static void XinChao()
        {
            Console.WriteLine("Xin chao");
        }
    }
}
