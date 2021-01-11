using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuDungLinQ
{
    public partial class FormHangHoa : Form
    {
        MyEstoreDataContext _dataBase = new MyEstoreDataContext();
        public FormHangHoa()
        {
            InitializeComponent();
        }

        private void FormHangHoa_Load(object sender, EventArgs e)
        {
            LoadDanhSachLoai();
            LoadDanhSachHangHoa();

        }

        private void LoadDanhSachLoai()
        {
            List<Loai> dsLoai = _dataBase.Loais.ToList();
            Loai loaiChon = new Loai()
            {
                MaLoai = 0,
                TenLoai = "Chọn Loại Hàng Hóa"
            };
            dsLoai.Insert(0,loaiChon);

            cbbLoai.DataSource = dsLoai;
            cbbLoai.DisplayMember = "TenLoai";
            cbbLoai.ValueMember = "MaLoai";
        }

        private void LoadDanhSachHangHoa()
        {
            dgvDanhSachHangHoa.DataSource =
                _dataBase.HangHoas.Where(item => item.MaHH != null).Select(
                   hh => new
                   {
                       MaHH = hh.MaHH,
                       TenHH = hh.TenHH,
                       MoTaDonVi = hh.MoTaDonVi,
                       MaNCC = hh.MaNCC,
                       TenCongTy = hh.NhaCungCap.TenCongTy,
                       DonGia = hh.DonGia,
                       Hinh = hh.Hinh,
                       SoLanXem = hh.SoLanXem,
                       MaLoai = hh.MaLoai,
                       TenLoai = hh.Loai.TenLoai,
                       NgaySX = hh.NgaySX,
                       MoTa = hh.MoTa,
                   }
                    ).ToList();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            dgvDanhSachHangHoa.DataSource =
               _dataBase.HangHoas.Where(item => item.TenHH.Contains(txtTimKiem.Text)
               || item.NhaCungCap.TenCongTy.Contains(txtTimKiem.Text)
               || item.MoTa.Contains(txtTimKiem.Text)
               || item.MoTaDonVi.Contains(txtTimKiem.Text)
               
               ).Select(
                  hh => new {
                      MaHH = hh.MaHH,
                      TenHH = hh.TenHH,
                      MoTaDonVi = hh.MoTaDonVi,
                      MaNCC = hh.MaNCC,
                      TenCongTy = hh.NhaCungCap.TenCongTy,
                      DonGia = hh.DonGia,
                      Hinh = hh.Hinh,
                      SoLanXem = hh.SoLanXem,
                      MaLoai = hh.MaLoai,
                      TenLoai = hh.Loai.TenLoai,
                      NgaySX = hh.NgaySX,
                      MoTa = hh.MoTa,
                  }
                   ).ToList();
        }

        private void cbbLoai_SelectedIndexChanged(object sender, EventArgs e)
        {
            Loai loaiChon = (Loai) cbbLoai.SelectedItem;
            dgvDanhSachHangHoa.DataSource =
                _dataBase.HangHoas.Where(
                    item => item.MaLoai == loaiChon.MaLoai
                    ).Select(
                   hh => new
                   {
                       MaHH = hh.MaHH,
                       TenHH = hh.TenHH,
                       MoTaDonVi = hh.MoTaDonVi,
                       MaNCC = hh.MaNCC,
                       TenCongTy = hh.NhaCungCap.TenCongTy,
                       DonGia = hh.DonGia,
                       Hinh = hh.Hinh,
                       SoLanXem = hh.SoLanXem,
                       MaLoai = hh.MaLoai,
                       TenLoai = hh.Loai.TenLoai,
                       NgaySX = hh.NgaySX,
                       MoTa = hh.MoTa,
                   }
                    ).ToList();


        }
    }
}
