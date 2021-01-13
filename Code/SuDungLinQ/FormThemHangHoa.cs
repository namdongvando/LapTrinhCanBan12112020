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
    public partial class FormThemHangHoa : Form
    {
        MyEstoreDataContext _dataBase
            = new MyEstoreDataContext();

        public FormThemHangHoa()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void FormThemHangHoa_Load(object sender, EventArgs e)
        {
            LoadDanhSachNCC();
            LoadDanhSachLoai();
        }

        private void LoadDanhSachLoai()
        {
            // tải danh sách loai vao cBB 
            cbbLoai.DataSource = _dataBase.Loais.ToList();
            cbbLoai.DisplayMember = "TenLoai";
            cbbLoai.ValueMember = "MaLoai";
        }

        private void LoadDanhSachNCC()
        {
            // tải danh sách NCC vao cBB
            cbbNCC.DataSource = _dataBase.NhaCungCaps.ToList();
            cbbNCC.DisplayMember = "TenCongTy";
            cbbNCC.ValueMember = "MaNCC";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                HangHoa hh = GetInputForm();
                _dataBase.HangHoas.InsertOnSubmit(hh);
                _dataBase.SubmitChanges();
                DialogResult = DialogResult.OK;
           
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
            if (pictureBox1.Image != null) {
                string fileName 
                    = string.Format("{0}/{1}",Application.StartupPath
                    ,txtTenHH.Text+".jpg");

                pictureBox1.Image.Save(fileName);
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

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnChonHinh_Click(object sender, EventArgs e)
        {
            var isOK = openFileDialog1.ShowDialog();
            if(isOK == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(openFileDialog1.FileName);
            }
        }
    }
}
