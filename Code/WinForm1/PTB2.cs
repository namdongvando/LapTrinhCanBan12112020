using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm1
{
    class PTB2
    {
        public double SoA { get; set; }
        public double SoB { get; set; }
        public double SoC { get; set; }
        public double KqX1 { get; set; }
        public double KqX2 { get; set; }

        public void TinhKetQua()
        {
            if (SoA == 0)
                throw new Exception("Không phải PT Bac 2");
                

            double d = Math.Pow(SoB, 2) - 4 * SoA * SoC;
            if(d<0)
                throw new Exception("PTVN");
            KqX1 = (-SoB + Math.Sqrt(d)) / (2 * SoA);
            KqX2 = (-SoB - Math.Sqrt(d)) / (2 * SoA);
        }
    }
}
