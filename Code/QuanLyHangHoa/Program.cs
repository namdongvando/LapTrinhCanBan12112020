using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHangHoa
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        private static void Menu()
        {
            Console.WriteLine("====Quan ly hang hoa =====");
            Console.WriteLine("1. Them hang hoa");
            Console.WriteLine("2. Sưa hang hoa");
            Console.WriteLine("3. Xoa hang hoa");
            Console.WriteLine("4. Danh Sach hang hoa");
            Console.WriteLine("exit. thoat");
            string chon = Console.ReadLine();

            switch (chon)
            {
                case "1":
                    ThemHangHoa();
                    break;
                case "2":
                    SuaHangHoa();
                    break;
                case "3":
                    XoaHangHoa();
                    break;
                case "4":
                    DanhSachHangHoa();
                    break;
                case "exit":
                    return;
                default:
                    break;
            }
            Menu();

        }

        private static void DanhSachHangHoa()
        {
            List<HangHoa> Lhh = HangHoa.GetDSHangHoa();
            foreach (HangHoa hh in Lhh)
            {
                Console.WriteLine(hh.ThongTin());
            }

        }

        private static void XoaHangHoa()
        {
            Console.WriteLine("Xoa Hang Hoa");
            Console.WriteLine("Nhap ma hang  hoa muon xoa:");
            string maHH = Console.ReadLine();
            HangHoa.XoaHH(maHH);


        }

        private static void SuaHangHoa()
        {
            Console.WriteLine("Sua Hang Hoa");
            Console.WriteLine("Nhap MaHH:");
            string maHH = Console.ReadLine().Trim();
            Console.WriteLine("Nhap Ten:");
            string tenHH = Console.ReadLine().Trim();
            Console.WriteLine("Nhap Gia:");
            decimal gia;
            decimal.TryParse(Console.ReadLine(), out gia);
            Console.WriteLine("Nhap So Luong:");
            int soluong;
            int.TryParse(Console.ReadLine(), out soluong);
            // có cac thuoc tinh cua hang hoa
            HangHoa hh = new HangHoa()
            {
                MaHH = maHH,
                TenHH = tenHH,
                Gia = gia,
                SoLuong = soluong
            };
            HangHoa.SuaHH(hh);
        }

        private static void ThemHangHoa()
        {
            Console.WriteLine("Them Hang Hoa");
            Console.WriteLine("Nhap MaHH:");
            string maHH = Console.ReadLine().Trim();
            Console.WriteLine("Nhap Ten:");
            string tenHH = Console.ReadLine().Trim();
            Console.WriteLine("Nhap Gia:");
            decimal gia;
            decimal.TryParse(Console.ReadLine(), out gia);
            Console.WriteLine("Nhap So Luong:");
            int soluong;
            int.TryParse(Console.ReadLine(), out soluong);
            // có cac thuoc tinh cua hang hoa
            HangHoa hh = new HangHoa()
            {
                MaHH = maHH,
                TenHH = tenHH,
                Gia = gia,
                SoLuong = soluong
            };
            HangHoa.ThemHH(hh);

        }
    }
}
