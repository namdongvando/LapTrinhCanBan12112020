using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDungStruct
{
    struct PTB2
    {
        public double SoA { get; set; }
        public double SoB { get; set; }
        public double SoC { get; set; }
        public double X1 { get; set; }
        public double X2 { get; set; }

        public double[] GiaiPT() {
            if (SoA == 0)
                throw new Exception("KP PTB2");
            double d = Math.Pow(SoB, 2) - 4*SoA*SoC;
            if (d < 0)
            {
                throw new Exception("Pt VN");
            }
            double[] nghiem = new double[2];
            // nghiem 1
            nghiem[0] = 
                X1 = (-SoB + Math.Sqrt(d)) / (2 * SoA);
            // nghiem 2
            nghiem[1] =
                X2 = (-SoB - Math.Sqrt(d)) / (2 * SoA);
            return nghiem;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            // SuDungMang();
            //  XapSepMang1();
            // XapSepMang2();

            PTB2 ptb2 = new PTB2();
            ptb2.SoA = 3;
            ptb2.SoB = 9;
            ptb2.SoC = 2;
            double[]  nghiem =  ptb2.GiaiPT();
            Console.WriteLine(nghiem[0]);
            Console.WriteLine(nghiem[1]);
        }

        private static void XapSepMang2()
        {
             
            int[] a = { 234, 23, 42, 34, 23, 42, 34, 23, 4, 23 };

            for (int i = 0; i < a.Length;)
            {
                if (i + 1 >= a.Length)
                    break;
                if(a[i] > a[i+1])
                {
                    // hoan vi
                    int tam = a[i];
                    a[i] = a[i + 1];
                    a[i + 1] = tam;
                    i = 0;
                }
                else
                    i++;
               
            }
            
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }


        }

        private static void XapSepMang1()
        {
            int[] a = { 34, 3, 45, 345, 34, 53, 45, 4 };
            for (int j = 0; j < a.Length; j++)
            {
                Console.WriteLine(a[j]);
                // show tat ca phan tu
                int min = j;
                // tim vi tri cua pt nho nhat
                for (int i = j; i < a.Length; i++)
                {
                    if (a[min] > a[i])
                        min = i;
                }
                // hoan vi
                int tam = a[j];
                a[j] = a[min];
                a[min] = tam;
                //Console.WriteLine(a[min]);
                //Console.WriteLine(min);
            }
            Console.WriteLine("=======");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        private static void SuDungMang()
        {
            double[] mangDiem = new double[4];
            mangDiem[0] = 3.5;
            mangDiem[1] = 6;
            mangDiem[2] = 8;
            mangDiem[3] = 9;
            Console.WriteLine(mangDiem[0]);
            Console.WriteLine(mangDiem[1]);
            Console.WriteLine(mangDiem[2]);
            Console.WriteLine(mangDiem[3]);
            for (int i = 0; i < mangDiem.Length; i++)
            {
                Console.WriteLine(mangDiem[i]);
            }

            double tim = 9;
            int vitri = -1;
            for (int i = 0; i < mangDiem.Length; i++)
            {
                if (mangDiem[i] == tim)
                    vitri = i;
            }

            Console.WriteLine("Vi tri {0}", vitri);

            Array.Sort(mangDiem);

        }
    }
}
