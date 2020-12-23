using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHangHoa
{
    class HangHoa
    {
        public string MaHH { get; set; }
        public string TenHH { get; set; }
        public decimal Gia { get; set; }
        public int SoLuong { get; set; }
        private static List<HangHoa> DSHangHoa;
        /// <summary>
        /// lay danh sach hang hoa
        /// </summary>
        /// <returns></returns>
        public static List<HangHoa> GetDSHangHoa() {
            if (DSHangHoa == null)
                DSHangHoa = new List<HangHoa>();
            return DSHangHoa;
        }
        /// <summary>
        /// them hang hoa
        /// </summary>
        /// <param name="hh"></param>
        public static void ThemHH(HangHoa hh) {
            List<HangHoa> lhh = GetDSHangHoa();
            lhh.Add(hh);
            DSHangHoa = lhh;
        }

        public string ThongTin()
        {
            return string.Format("{0},{1},{2},{3}",
                MaHH, TenHH, Gia, SoLuong
                );
        }

        public static void XoaHH(string maHH)
        {
            List<HangHoa> Lhh = GetDSHangHoa();
            Lhh.RemoveAll(hh => hh.MaHH == maHH);
            DSHangHoa = Lhh;
        }

        public static void SuaHH(HangHoa hh)
        {
            XoaHH(hh.MaHH);
            ThemHH(hh);
        }
    }
}
