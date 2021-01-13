using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SuDungLinQ
{
    public partial class FromSuaSanPham : Form
    {
        private int maHangHoa;
        MyEstoreDataContext _dataBase = new MyEstoreDataContext();
        public FromSuaSanPham()
        {
            InitializeComponent();
        }

        public FromSuaSanPham(int maHangHoa)
        {
            this.maHangHoa = maHangHoa;
            InitializeComponent();
        }

        private void FromSuaSanPham_Load(object sender, EventArgs e)
        {
            LoadNCC();
            LoadLoai();
            SetInputForm(this.maHangHoa);
        }

        private void SetInputForm(int maHangHoa)
        {
            HangHoa hhSua = _dataBase
                .HangHoas.FirstOrDefault
                (item => item.MaHH == maHangHoa);

            txtTenHH.Text = hhSua.TenHH;
            txtDonGia.Text = hhSua.DonGia.ToString();
            dtpNgaySanXuat.Value = hhSua.NgaySX;
            txtGiamGia.Text = hhSua.GiamGia.ToString();
            txtMoTa.Text = hhSua.MoTa;
            txtMoTaDonVi.Text = hhSua.MoTaDonVi;
            cbbLoai.SelectedValue = hhSua.MaLoai;
            cbbNCC.SelectedValue = hhSua.MaNCC;

            if (File.Exists(hhSua.Hinh))
                pictureBox1.Image = new Bitmap(hhSua.Hinh);


        }

        private void LoadLoai()
        {
            cbbLoai.DataSource = _dataBase.Loais.ToList();
            cbbLoai.DisplayMember = "TenLoai";
            cbbLoai.ValueMember = "MaLoai";
        }

        private void LoadNCC()
        {
            cbbNCC.DataSource =
                _dataBase.NhaCungCaps.ToList();
            cbbNCC.DisplayMember = "TenCongTy";
            cbbNCC.ValueMember = "MaNCC";
        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            var isOk = openFileDialog1.ShowDialog();
            if (isOk == DialogResult.OK) {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
              HangHoa hhSua = GetInputForm();
                HangHoa hhDataBase = _dataBase.HangHoas
                    .FirstOrDefault(item => item.MaHH == hhSua.MaHH);
                hhDataBase.TenHH = hhSua.TenHH;
                hhDataBase.DonGia = hhSua.DonGia;
                hhDataBase.MoTaDonVi = hhSua.MoTaDonVi;
                hhDataBase.MoTa = hhSua.MoTa;
                hhDataBase.GiamGia = hhSua.GiamGia;
                hhDataBase.Hinh = hhSua.Hinh;
                hhDataBase.MaLoai = hhSua.MaLoai;
                hhDataBase.MaNCC = hhSua.MaNCC;
                _dataBase.SubmitChanges();
                DialogResult = DialogResult.OK;
            try
            {


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private HangHoa GetInputForm()
        {
            if (txtTenHH.Text == "")
            {
                throw new Exception("Tên Hàng Hóa Không Để Trống");
            }
            if (txtDonGia.Text == "")
            {
                throw new Exception("Đơn Giá Không Để Trống");
            }
            string hinhAnh = "";
            if (openFileDialog1.FileName != null)
            {
                string fileName
                    = string.Format("{0}/{1}", Application.StartupPath
                    , txtTenHH.Text + ".jpg");
                Bitmap hinhBitMap = new Bitmap(pictureBox1.Image);
                pictureBox1.Image.Dispose();
                File.Delete(fileName);
                hinhBitMap.Save(fileName);
                hinhAnh = fileName;
            }

            double donGia;
            double.TryParse(txtDonGia.Text, out donGia);
            double giamGia;
            double.TryParse(txtDonGia.Text, out giamGia);
            Loai loaiHH = (Loai)cbbLoai.SelectedItem;
            NhaCungCap nccHH = (NhaCungCap)cbbNCC.SelectedItem;
            DateTime ngaySX = dtpNgaySanXuat.Value;
            return new HangHoa()
            {
                MaHH = this.maHangHoa,
                TenHH = txtTenHH.Text,
                DonGia = donGia,
                GiamGia = giamGia,
                NgaySX = ngaySX,
                MoTaDonVi = txtMoTaDonVi.Text,
                MoTa = txtMoTa.Text,
                MaLoai = loaiHH.MaLoai,
                MaNCC = nccHH.MaNCC,
                Hinh = hinhAnh,
                SoLanXem = 0,
            };
        }
    }
}
