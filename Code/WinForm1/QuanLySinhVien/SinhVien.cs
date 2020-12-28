using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySinhVien
{
    class SinhVien
    {
        public string MaSV { get; set; }
        public string TenSV { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgaySinh { get; set; }
        public string SDT { get; set; }
        public static List<SinhVien> DSSinhVien;

        public static void XoaSinhVien(string maSV)
        {
            XoaSinhVienCach1(maSV);
            XoaSinhVienCach2(maSV);
        }

        private static void XoaSinhVienCach2(string maSV)
        {
            List<SinhVien> dsSV = GetDSSinhVien();
            dsSV.RemoveAll(sv => sv.MaSV == maSV);
            DSSinhVien = dsSV;
        }

        public static void SuaSinhVien(SinhVien svSua)
        {
            // xoa 
            XoaSinhVien(svSua.MaSV);
            ThemDanhSachSV(svSua);
        }

        private static void XoaSinhVienCach1(string maSV)
        {
            // lấy bản copy
            List<SinhVien> dsSV = GetDSSinhVien();
            int dem = -1;
            int i = 0;
            // tim vi tri sinh vien muon xoa
            foreach (SinhVien item in dsSV)
            {
                if (item.MaSV == maSV)
                {
                    dem = i;
                }
                i++;
            }
            // tim dc thì xóa
            if (dem > -1)
                dsSV.RemoveAt(dem);
            DSSinhVien = dsSV;
        }

        public string ThongTin()
        {
            return String.Format("{0},{1},{2},{3},{4}"
                , MaSV
                , TenSV
                , DiaChi
                , NgaySinh,
                SDT);
        }

        public static SinhVien TimSinhVienTheoMa(string maSV)
        {
            SinhVien svTim = 
                GetDSSinhVien()
                .FirstOrDefault(sv => sv.MaSV == maSV);
            return svTim;
        }

        /// <summary>
        /// Lay Danh Sach Sinh Vien
        /// </summary>
        /// <returns> </returns>
        public static List<SinhVien> GetDSSinhVien()
        {
            if (DSSinhVien == null)
                DSSinhVien = new List<SinhVien>();
            return DSSinhVien;

        }
        /// <summary>
        /// tu them vao danh sách
        /// </summary>
        public void ThemDanhSach()
        {
            SinhVien svThem = this;
            List<SinhVien> danhSachSV = GetDSSinhVien();
            danhSachSV.Add(svThem);
            DSSinhVien = danhSachSV;

        }

        public void ThemDanhSach(SinhVien svThem)
        {
            List<SinhVien> danhSachSV = GetDSSinhVien();
            danhSachSV.Add(svThem);
            DSSinhVien = danhSachSV;
        }

        public static void ThemDanhSachSV(SinhVien svThem)
        {
            List<SinhVien> danhSachSV = GetDSSinhVien();
            danhSachSV.Add(svThem);
            DSSinhVien = danhSachSV;
        }
    }
}
