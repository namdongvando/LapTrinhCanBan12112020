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
    public partial class Form1 : Form
    {
        private MyEstoreDataContext _dataBase = new MyEstoreDataContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            dgvDanhSachLoai.DataSource = _dataBase.Loais.ToList();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length >= 3)
            {
                dgvDanhSachLoai.DataSource =
                    _dataBase.Loais
                    .Where(
                        item => item.TenLoai.Contains(textBox1.Text)
                        || item.MaLoai.ToString().Contains(textBox1.Text)
                        ).ToList();
            }
            else {
                dgvDanhSachLoai.DataSource = _dataBase.Loais.ToList();
            }
            
        }

        private void quảnLýLoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formShow = new FormLoaiHangHoa();
            formShow.ShowDialog();
        }

        private void quảnLýNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formShow = new FormNhaCungCap();
            formShow.ShowDialog();
        }

        private void quảnLýHànhHóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form formShow = new FormHangHoa();
            formShow.ShowDialog();
        }
    }
}
