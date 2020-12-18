using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuDungHamTT
{
    struct SinhVien
    {
        public string MaSinhVien { get; set; }
        public string TenSinhVien { get; set; }
        public string SDT { get; set; }
        public DateTime NgaySinh { get; set; }
        public string DiaChi { get; set; }
        public string CMND { get; set; }
    }
    struct PhuongTrinhBac1
    {
        public double soa { get; set; }
        public double sob { get; set; }

        public double GiaiPhuongTrinh() {
            if (soa == 0)
                if (sob == 0)
                    throw new Exception("PT VSN");
                else
                    throw new Exception("PT VN");

            return -sob / soa;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                PhuongTrinhBac1 PT1 = new PhuongTrinhBac1();
                PT1.soa = 0;
                PT1.sob = 2;
                double kq = PT1.GiaiPhuongTrinh();
                Console.WriteLine(kq);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            //SinhVien teo = new SinhVien()
            //{
            //    MaSinhVien = "001",
            //    TenSinhVien = "Teo Nguyen",
            //    CMND = "0123456789",
            //    DiaChi = "HCM",
            //    NgaySinh = new DateTime(2000, 1, 1),
            //    SDT = "09000001"
            //};
            //Console.WriteLine(teo.TenSinhVien);
            // menu cua phan men
            // Menu();

        }

        private static void Menu()
        {
            Console.WriteLine("Menu Chon 1....n");
            Console.WriteLine("1. Xac dinh chan le");
            Console.WriteLine("2. Tim so lon nhat");
            Console.WriteLine("3. Tim so nho nhat");
            Console.WriteLine("4. Phuong trinh bac 1");
            Console.WriteLine("5. Phuong trinh bac 2");
            Console.WriteLine("6. UCLN");
            Console.WriteLine("7. Tinh n!");
            Console.WriteLine("exit. thoat");
            Console.WriteLine("Chon: ");
            string chon = Console.ReadLine();
            switch (chon)
            {
                case "1":
                    XacDinhChanLe();
                    break;
                case "2":
                    TimSoLonNhat();
                    break;
                case "3":
                    TimSoNhoNhat();
                    break;
                case "4":
                    PhuongTrinhBac1();
                    break;
                case "5":
                    PhuongTrinhBac2();
                    break;
                case "6":
                    UCLN();
                    break;
                case "7":
                    TinhGiaiThua();
                    break;
                case "exit":
                    return;
                default:
                    break;
            }

            Menu();

        }

        private static void TinhGiaiThua()
        {
            int a = NhapSoNguyen("nhap so nguyen duong a");
            if (a <= 0)
            {
                Console.WriteLine("khong tinh dc");
                return;
            }
            int gt = 1;
            for (int i = 1; i <= a; i++)
            {
                gt *= i;
            }
            Console.WriteLine("{0}! = {1}", a, gt);
        }

        private static void UCLN()
        {
            // nhap a, b
            int a = NhapSoNguyen("nhap so nguyen duong a");
            int b = NhapSoNguyen("nhap so nguyen duong b");
            while (a * b > 0)
            {
                if (a > b)
                    a = a % b;
                else
                    b = b % a;
            }
            Console.WriteLine("UCLN la :{0}", a + b);

        }

        private static void PhuongTrinhBac2()
        {
            // ax2 + bx + c  =0
            double a = NhapSoThuc("nhap so a");
            if (a == 0)
            {
                Console.WriteLine("Không Phai PT Bac2");
                return;
            }
            double b = NhapSoThuc("nhap so b");
            double c = NhapSoThuc("nhap so c");
            double d = Math.Pow(b, 2) - 4 * a * c;
            if (d < 0)
            {
                Console.WriteLine("PTVN");
                return;
            }
            // d >= 0
            double x1 = (-b + Math.Sqrt(d)) / (2 * a);
            double x2 = (-b - Math.Sqrt(d)) / (2 * a);
            Console.WriteLine("X1={0} X2={1}", x1, x2);
        }

        private static void PhuongTrinhBac1()
        {
            // ax + b =0
            double a = NhapSoThuc("nhap so a");
            double b = NhapSoThuc("nhap so b");
            if (a == 0)
                if (b == 0)
                    Console.WriteLine("PTVSN");
                else
                    Console.WriteLine("PTVN");
            else
                Console.WriteLine("nghiem PT la {0}", (-b / a));

        }

        private static double NhapSoThuc(string thongBao)
        {
            Console.WriteLine(thongBao);
            double nhap = 0;
            // mac dinh người dung nhap sai
            bool kiemTra = false;
            while (kiemTra == false)
            {
                kiemTra = double.TryParse(Console.ReadLine(), out nhap);
                if (kiemTra == false)
                    Console.WriteLine("nhap lại");

            }
            return nhap;
        }

        private static void TimSoNhoNhat()
        {
            int a = NhapSoNguyen("Nhap So nguyen a");
            int b = NhapSoNguyen("Nhap So nguyen b");
            int c = NhapSoNguyen("Nhap So nguyen c");
            //tim max
            int min = a;
            if (min > b)
                min = b;
            if (min > c)
                min = c;
            Console.WriteLine("gia tri nho nhat la {0}", min);
        }

        private static void TimSoLonNhat()
        {
            int a = NhapSoNguyen("Nhap So nguyen a");
            int b = NhapSoNguyen("Nhap So nguyen b");
            int c = NhapSoNguyen("Nhap So nguyen c");
            //tim max
            int max = a;
            if (max < b)
                max = b;
            if (max < c)
                max = c;
            Console.WriteLine("gia tri lon nhat la {0}", max);


        }

        private static int NhapSoNguyen(string thongBao)
        {
            Console.WriteLine(thongBao);
            int nhap = 0;
            // mac dinh người dung nhap sai
            bool kiemTra = false;
            while (kiemTra == false)
            {
                kiemTra = int.TryParse(Console.ReadLine(), out nhap);
                if (kiemTra == false)
                    Console.WriteLine("nhap lại");

            }
            return nhap;
        }

        private static void XacDinhChanLe()
        {
            Console.WriteLine("Nhap So nguyen n");
            int n;
            int.TryParse(Console.ReadLine(), out n);
            if (n % 2 == 0)
                Console.WriteLine("{0} la so chan", n);
            else
                Console.WriteLine("{0} la so le", n);


        }
    }
}
