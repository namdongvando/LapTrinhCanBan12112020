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
    public partial class FormHinhTron : Form
    {
        public FormHinhTron()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtBanKinh_TextChanged(sender, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void txtBanKinh_TextChanged(object sender, EventArgs e)
        {
            lblBanKinh.Text = "r = " + txtBanKinh.Text;
            try
            {
                HinhTron ht = GetInputForm();
                txtDienTich.Text = ht.DienTich().ToString();    
                txtChuVi.Text = ht.ChuVi().ToString();
                lblChuVi.Text = "Chu vi = " + ht.ChuVi().ToString();
                lblDienTich.Text = "Dien tich = " + ht.DienTich().ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private HinhTron GetInputForm()
        {
            double r;
            if (double.TryParse(txtBanKinh.Text, out r)==false){
                txtBanKinh.Focus();
                txtBanKinh.SelectAll();
                throw new Exception("Ban kinh không hợp lệ");
            }
            return new HinhTron()
            {
                BanKinh = r
            };
        }
    }
}
