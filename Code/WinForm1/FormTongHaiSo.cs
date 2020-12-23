using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm1
{
    public partial class FormTongHaiSo : Form
    {
        public FormTongHaiSo()
        {
            InitializeComponent();
        }
 

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormTongHaiSo_FormClosing(object sender, FormClosingEventArgs e)
        {
        // kiem tra nguoi dung chon nut nào
          DialogResult btnChon =  MessageBox.Show("Bạn có muốn thoát không?","thông báo"
                ,MessageBoxButtons.OKCancel,MessageBoxIcon.Warning
                );
            if (btnChon != DialogResult.OK) {
                e.Cancel = true;
            }

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            try
            {
                int a, b;
                if (int.TryParse(txtSoA.Text, out a) == false) {
                    txtSoA.Focus();
                    txtSoA.SelectAll();
                    throw new Exception("Số a nhập không hợp lệ");
                }
                if (int.TryParse(txtSoB.Text, out b) == false) {
                    txtSoB.Focus();
                    txtSoB.SelectAll();
                    throw new Exception("Số b nhập không hợp lệ");
                }
                txtKetQua.Text = (a + b).ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void lblKetQua_Click(object sender, EventArgs e)
        {

        }
    }
}
