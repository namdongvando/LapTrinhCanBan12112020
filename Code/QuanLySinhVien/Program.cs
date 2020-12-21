using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    class Program
    {
        static void Main(string[] args)
        {

            Menu();

            ThongTinSinhVien();
            ThemThongTinSinhVien();
            XoaSinhVien();
            SuaThongTinSinhVien();

            XuatDanhSachSinhVien();

        }

        private static void Menu()
        {
            Console.WriteLine("=======Pham men Quan Ly Sinh Vien ========");
            Console.WriteLine("1.them sinh vien");
            Console.WriteLine("2.Sua sinh vien");
            Console.WriteLine("3.Xoa sinh vien");
            Console.WriteLine("4.Danh Sach sinh vien");
            Console.WriteLine("Chon: ");
            string chon = Console.ReadLine();
            switch (chon)
            {
                case "1":
                    ThemThongTinSinhVien();
                    break;
                case "2":
                    SuaThongTinSinhVien();
                    break;
                case "3":
                    XoaSinhVien();
                    break;
                case "4":
                    XuatDanhSachSinhVien();
                    break;
                case "exit":
                    return;
                default:
                    break;

            }
            Menu();
        }

        private static void ThemThongTinSinhVien()
        {
            Console.WriteLine("========= Them Sinh vien =========");
            Console.WriteLine("Nhap MaSV:");
            string maSV = Console.ReadLine();
            Console.WriteLine("Nhap TenSV:");
            string tenSV = Console.ReadLine();
            Console.WriteLine("Nhap Dia Chi:");
            string diaCHi = Console.ReadLine();
            Console.WriteLine("Nhap Ngay Sinh:");
            DateTime ngaySinh = DateTime.Parse(Console.ReadLine());
            Console.WriteLine("Nhap SDT:");
            string sDT = Console.ReadLine();
            SinhVien sv = new SinhVien()
            {
                MaSV = maSV,
                TenSV = tenSV,
                DiaChi = diaCHi,
                SDT = sDT,
                NgaySinh = ngaySinh
            };
            sv.ThemDanhSach();

        }

        private static void SuaThongTinSinhVien()
        {
            SinhVien ti = new SinhVien()
            {
                MaSV = "002",
                TenSV = "Tran Thi Ti",
                DiaChi = "HCM",
                NgaySinh = new DateTime(2000, 2, 1),
                SDT = "0123456788"
            };
            SinhVien.SuaSinhVien(ti);
        }

        private static void XuatDanhSachSinhVien()
        {
            foreach (SinhVien sv in SinhVien.GetDSSinhVien())
            {
                Console.WriteLine(sv.ThongTin());
            }
        }

        private static void XoaSinhVien()
        {
            string maSV = "001";
            SinhVien.XoaSinhVien(maSV);
        }

        private static void ThongTinSinhVien()
        {
            SinhVien teo = new SinhVien();
            teo.MaSV = "001";
            teo.TenSV = "Teo nguyen";
            teo.NgaySinh = new DateTime(2000,1,1);
            teo.DiaChi = "HCM";
            teo.SDT = "0123456789";
            //Console.WriteLine(teo.MaSV);
            //Console.WriteLine(teo.TenSV);
            //Console.WriteLine(teo.DiaChi);
            //Console.WriteLine(teo.SDT);
            //Console.WriteLine(teo.NgaySinh.ToString());
            //Console.WriteLine(teo.ThongTin());
            SinhVien ti = new SinhVien()
            {
                MaSV = "002",
                TenSV = "Tran van Ti",
                DiaChi = "HCM",
                NgaySinh = new DateTime(2000, 2, 1),
                SDT="0123456788"
            };
            SinhVien.GetDSSinhVien();
            teo.ThemDanhSach();
             teo.ThemDanhSach(ti);
            SinhVien tun = new SinhVien()
            {
                MaSV = "003",
                TenSV = "Tran van Tun",
                DiaChi = "HCM",
                NgaySinh = new DateTime(2000, 2, 1),
                SDT = "0123456788"
            };
            SinhVien.ThemDanhSachSV(tun);

            foreach (SinhVien sv in SinhVien.GetDSSinhVien())
            {
                Console.WriteLine(sv.ThongTin());
                
            }

        }
    }
}
