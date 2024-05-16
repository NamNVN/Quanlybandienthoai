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
    public partial class frmtimkiemDT : Form
    {
        public frmtimkiemDT()
        {
            InitializeComponent();
        }

        ConnectCSDL co = new ConnectCSDL();

        private void txttktheoten_TextChanged(object sender, EventArgs e)
        {
            co.KetNoi();
            dgvtkthongtinmaytinh.DataSource = co.GetData("select * from tblThongtindienthoai where TenDT like '" + txttktheoten.Text.Trim() + "%'");

        }

        private void btntktheoma_Click(object sender, EventArgs e)
        {
            co.KetNoi();
            dgvtkthongtinmaytinh.DataSource = co.GetData("select * fromtblThongtindienthoai where MaDT = '" + txttktheoma.Text.Trim() + "'");

        }

        private void txttktheoma_TextChanged(object sender, EventArgs e)
        {
            co.KetNoi();
            dgvtkthongtinmaytinh.DataSource = co.GetData("select * from tblThongtindienthoai where MaDT = '" + txttktheoma.Text.Trim() + "'");

        }

        private void txttktheoten_MouseClick(object sender, MouseEventArgs e)
        {
            txttktheoten.Clear();
        }

        private void txttktheoma_MouseClick(object sender, MouseEventArgs e)
        {
            txttktheoten.Clear();
        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            frmMenu tc = new frmMenu();
            tc.Show();
            this.Hide();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn thoát không?", "Trả lời",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }
    }
}
