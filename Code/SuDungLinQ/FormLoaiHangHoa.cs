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
    public partial class FormLoaiHangHoa : Form
    {
        MyEstoreDataContext _dataBase = new MyEstoreDataContext();
        public FormLoaiHangHoa()
        {
            InitializeComponent();
        }

        private void FormLoaiHangHoa_Load(object sender, EventArgs e)
        {
            dgvDanhSachLoai.DataSource = _dataBase.Loais.ToList();


        }

        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            try
            {
                Loai loaiThem = GetInputForm();
                _dataBase.Loais.InsertOnSubmit(loaiThem);
                _dataBase.SubmitChanges();
                dgvDanhSachLoai.DataSource = _dataBase.Loais.ToList();
                SetInputForm(new Loai());
            
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void SetInputForm(Loai loai)
        {
            txtMaLoai.Text = loai.MaLoai.ToString();
            txtTenLoai.Text = loai.TenLoai;
            txtMoTa.Text = loai.MoTa;
            txtHinhAnh.Text = loai.Hinh;
        }

        private Loai GetInputForm()
        {
            int maLoai = 0;
            int.TryParse(txtMaLoai.Text, out maLoai);
            if (txtTenLoai.Text == "")
                throw new Exception("Tên Loại Không Để Trống");
            return new Loai()
            {
                MaLoai = maLoai,
                TenLoai = txtTenLoai.Text,
                MoTa = txtMoTa.Text,
                Hinh = txtHinhAnh.Text
            };
        }

        private void dgvDanhSachLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // lấy ma loại của dòngclick
            int maLoai = int.Parse(dgvDanhSachLoai.Rows[e.RowIndex].Cells["MaLoai"].Value.ToString());
            // tim loai theo
            Loai loaiSua = _dataBase.Loais.FirstOrDefault(item => item.MaLoai == maLoai);
            // set input form
            SetInputForm(loaiSua);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Loai loaiSua = GetInputForm();
                Loai loaiTim = _dataBase.Loais.FirstOrDefault(
                    item => item.MaLoai== loaiSua.MaLoai
                    );
                loaiTim.TenLoai = loaiSua.TenLoai;
                loaiTim.Hinh = loaiSua.Hinh;
                loaiTim.MoTa= loaiSua.MoTa;
                _dataBase.SubmitChanges();
                dgvDanhSachLoai.DataSource = _dataBase.Loais.ToList();
                SetInputForm(new Loai());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var isYes = MessageBox.Show(
                "Bạn có muốn xóa Loại Này Không?"
                , "Thông Báo"
                ,MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                );
            
            if(isYes != DialogResult.Yes)
            {
                // không dồng ý
                return;
            }
            // đồng ý
            Loai loaiXoa = _dataBase.Loais
                .FirstOrDefault(
                    item => item.MaLoai.ToString() == txtMaLoai.Text);

            _dataBase.Loais.DeleteOnSubmit(loaiXoa);
            _dataBase.SubmitChanges();
            //cap nhat danh sách
            dgvDanhSachLoai.DataSource =
                _dataBase.Loais.ToList();
            SetInputForm(new Loai());
        }

        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {
            btnTimKiem_Click(sender, e);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dgvDanhSachLoai.DataSource = 
                _dataBase.Loais.Where(
                    item => item.TenLoai.Contains(txtTuKhoa.Text)
                ).ToList();
        }
    }
}
