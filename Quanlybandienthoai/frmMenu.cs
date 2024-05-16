using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quanlybandienthoai
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void thôngTinMáyTínhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmThongtinDT frmThongtinDT = new frmThongtinDT();
            frmThongtinDT.Show();
            this.Hide();
        }

        private void thôngTinKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmKhachhang frmKhachhang = new frmKhachhang();
            frmKhachhang.Show();
            this.Hide();

        }

        private void thôngTinNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNhanvien frmNhanvien = new frmNhanvien();
            frmNhanvien.Show();
            this.Hide();
        }

        private void thôngTinHóaĐơnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void thôngTinNhàCungCấpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmnhacungcap frmnhacungcap = new frmnhacungcap();
            frmnhacungcap.Show();
            this.Hide();
        }

        private void hóaĐơnNhậpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmhoadonnhap frmhoadonnhap = new frmhoadonnhap();
            frmhoadonnhap.Show();
            this.Hide();

        }

        private void thôngTinKháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTimkiemKH frmTimkiemKH = new frmTimkiemKH();
            frmTimkiemKH.Show();
            this.Hide();
        }

        private void thôngTinĐiệnThoạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmtimkiemDT frmtimkiemDT = new frmtimkiemDT();
            frmtimkiemDT.Show();
            this.Hide();

                 
        }

        private void hóaĐơnBánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHoadonban frmHoadonban = new frmHoadonban();
            frmHoadonban.Show();
            this.Hide();

        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thốngKêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmthongke frmthongke = new frmthongke();
            frmthongke.Show();
            this.Hide();
        }

        private void thôngTinNhânViênToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTKNV frmTKNV = new frmTKNV();
            frmTKNV.Show();
            this.Hide();
        }

        private void quayLạiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDN frmDN = new frmDN();
            frmDN.Show();
            this.Hide();
        }
    }
}
