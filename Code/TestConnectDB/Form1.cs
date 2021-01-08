using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestConnectDB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDanhSachLoai();

        }

        private void LoadDanhSachLoai()
        {
            Loai loai = new Loai();
            dgvDanhSachLoai.DataSource = loai.GetDanhSachLoai().ToList();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            Loai loai = new Loai();
            dgvDanhSachLoai.DataSource 
                = loai.TimKiemLoai(txtTuKhoa.Text).ToList();
        }

        private void btnChonFile_Click(object sender, EventArgs e)
        {
            var isOK =  openFileDialog1.ShowDialog();
            if (isOK == DialogResult.OK)
            {
                txtHinhAnh.Text = openFileDialog1.FileName;
                pictureBox1.Image = 
                    new Bitmap(openFileDialog1.FileName);
            }
        }

        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            try
            {
                Loai loai = GetInputForm();
                loai.ThemLoai();
                LoadDanhSachLoai();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            


        }

        private Loai GetInputForm()
        {
            int maLoai = 0;
            // không nhapo thì thôi
            if (txtMaLoai.Text != "") {
                // nhap ma thì phải nhap dung
                if (int.TryParse(txtMaLoai.Text, out maLoai) == false)
                    throw new Exception("Mã Loại Không Hợp Lệ");
            }
            if(txtTenLoai.Text =="")
                throw new Exception("Tên Loại Không Hợp Lệ");

            return new Loai()
            {
                MaLoai = maLoai,
                TenLoai = txtTenLoai.Text,
                MoTa = txtMoTa.Text,
                Hinh = txtHinhAnh.Text,
            };
        }

        private void dgvDanhSachLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int maLoai = int.Parse(dgvDanhSachLoai.Rows[e.RowIndex].Cells["MaLoai"].Value.ToString());
            Loai loai = new Loai();
            Loai loaiTim = loai.GetLoaiById(maLoai);
            Form formSua = new FormSuaLoai(maLoai);
            var isOK = formSua.ShowDialog();
            if (isOK == DialogResult.OK) {
                LoadDanhSachLoai();
            }
            //  SetInputForm(loaiTim);
        }

        private void SetInputForm(Loai loaiTim)
        {
            txtMaLoai.Text = loaiTim.MaLoai.ToString();
            txtTenLoai.Text = loaiTim.TenLoai.ToString();
            txtMoTa.Text = loaiTim.MoTa.ToString();
            txtHinhAnh.Text = loaiTim.Hinh.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Loai loai = GetInputForm();
                loai.SuaLoai();
                loai.SuaLoai();
                loai.SuaLoai();
                loai.SuaLoai();
                loai.SuaLoai();
                LoadDanhSachLoai();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form formThem = new FormThemLoai();
            var isOK = formThem.ShowDialog();
            if (isOK == DialogResult.OK) {
                LoadDanhSachLoai();
            }
        }
    }
}
