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
                SetInputForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void SetInputForm()
        {
            throw new NotImplementedException();
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
    }
}
