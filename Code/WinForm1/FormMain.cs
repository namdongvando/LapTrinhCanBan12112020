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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            
            Form dangNhap = new FormDangNhap();
            var isOK =  dangNhap.ShowDialog();
            if (isOK == DialogResult.OK)
            {
                InitializeComponent();
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            var isOK = MessageBox.Show(
                "Bạn có muốn thoát không?"
                , "Thông báo"
                , MessageBoxButtons.OKCancel
                ,MessageBoxIcon.Warning);
            if (isOK != DialogResult.OK) {
                e.Cancel = true;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pTBậc1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formPTB1 = new FormPhuongTrinhBac1();
            formPTB1.MdiParent = this;
            formPTB1.Show();
        }

        private void pTBậc2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formPTB1 = new FormPhuongTrinhBac2();
            formPTB1.MdiParent = this;
            formPTB1.Show();
        }

        private void hinhTronToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formPTB1 = new FormHinhTron();
            formPTB1.MdiParent = this;
            formPTB1.Show();
        }

        private void quanLýSinhVienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formPTB1 = new FormQuanLySinhVien();
            formPTB1.MdiParent = this;
            formPTB1.Show();
        }
    }
}
