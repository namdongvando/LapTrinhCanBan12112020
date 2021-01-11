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
    public partial class FormNhaCungCap : Form
    {
        MyEstoreDataContext _dataBase = new MyEstoreDataContext();

        public FormNhaCungCap()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string maNCC = dgvDanhSachNCC.Rows[e.RowIndex].Cells["MaNCC"].Value.ToString();
            // lấy thông tin nhà cung cấp dc click
            NhaCungCap nccTim = _dataBase.NhaCungCaps.FirstOrDefault(
                item => item.MaNCC == maNCC);
            SetInputForm(nccTim);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void FormNhaCungCap_Load(object sender, EventArgs e)
        {
            LoaDanhSachNCC();

        }

        private void LoaDanhSachNCC()
        {
            dgvDanhSachNCC.DataSource = _dataBase.NhaCungCaps.ToList();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            button1_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dgvDanhSachNCC.DataSource = 
                _dataBase.NhaCungCaps.
                Where(
                    item => item.TenCongTy.Contains(textBox9.Text)
                    || item.Email.Contains(textBox9.Text)
                    || item.DiaChi.Contains(textBox9.Text)
                    || item.DienThoai.Contains(textBox9.Text)
                    );
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                NhaCungCap nccThem = GetInputForm();
                _dataBase.NhaCungCaps.InsertOnSubmit(nccThem);
                _dataBase.SubmitChanges();
                LoaDanhSachNCC();
                SetInputForm(new NhaCungCap());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SetInputForm(NhaCungCap nhaCungCap)
        {
            txtMaNCC.Text = nhaCungCap.MaNCC;
            txtTenNCC.Text = nhaCungCap.TenCongTy;
            txtDiaChi.Text = nhaCungCap.DiaChi;
            txtEmail.Text = nhaCungCap.Email;
            txtDienThoai.Text = nhaCungCap.DienThoai;
            txtMoTa.Text = nhaCungCap.MoTa;
            txtNLL.Text = nhaCungCap.NguoiLienLac;
            txtLogo.Text = nhaCungCap.Logo;
        }

        private NhaCungCap GetInputForm()
        {
            if (txtMaNCC.Text == "")
                throw new Exception("Mã nhà cung cấp không để trống");
            if (txtTenNCC.Text == "")
                throw new Exception("Tên Công Ty không để trống");
            if (txtEmail.Text == "")
                throw new Exception("Email không để trống");
            if (txtLogo.Text == "")
                throw new Exception("Logo không để trống");

            return new NhaCungCap()
            {
                MaNCC = txtMaNCC.Text,
                TenCongTy = txtMaNCC.Text,
                DiaChi = txtMaNCC.Text,
                Email = txtMaNCC.Text,
                DienThoai = txtMaNCC.Text,
                NguoiLienLac = txtMaNCC.Text,
                Logo = txtMaNCC.Text,
                MoTa = txtMaNCC.Text
            };

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                NhaCungCap nccSua = GetInputForm();
               NhaCungCap itemSua = _dataBase.NhaCungCaps.FirstOrDefault(i => i.MaNCC == nccSua.MaNCC);
                itemSua.TenCongTy = nccSua.TenCongTy;
                itemSua.Email = nccSua.Email;
                itemSua.DienThoai = nccSua.DienThoai;
                itemSua.MoTa = nccSua.MoTa;
                itemSua.Logo = nccSua.Logo;
                itemSua.NguoiLienLac = nccSua.NguoiLienLac;
                _dataBase.SubmitChanges();
                LoaDanhSachNCC();
                SetInputForm(new NhaCungCap());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var isYes = MessageBox.Show("Ban có muốn xóa nhà cung cấp này không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (isYes != DialogResult.Yes)
                return;
            NhaCungCap timNcc = _dataBase.NhaCungCaps
                .FirstOrDefault(i=>i.MaNCC==txtMaNCC.Text);
            _dataBase.NhaCungCaps.DeleteOnSubmit(timNcc);
            _dataBase.SubmitChanges();
            LoaDanhSachNCC();
            SetInputForm(new NhaCungCap());

        }
    }
}
