using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm1
{
    class PTB1
    {
        public double SoA { get; set; }
        public double SoB { get; set; }
        public double KqX { get; set; }

        public double TinhKetQua() {
            if (SoA == 0)
                if (SoB == 0)
                    throw new Exception("PTVSN");
                else
                    throw new Exception("PTVN");
            KqX = -SoB / SoA;
            return KqX;
        }

    }
}
