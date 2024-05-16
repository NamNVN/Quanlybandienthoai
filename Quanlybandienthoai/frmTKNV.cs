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
    public partial class frmTKNV : Form
    {
        public frmTKNV()
        {
            InitializeComponent();
        }

        ConnectCSDL co = new ConnectCSDL();

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            co.KetNoi();
            dgvtknhanvien.DataSource = co.GetData("select * from tblNhanVien where MaNV = '" + txtmanv.Text.Trim() + "'");
            co.KetNoi();
            dgvtknhanvien.DataSource = co.GetData("select * from tblNhanVien where TenNV = '" + txttennv.Text.Trim() + "'");
            co.KetNoi();
            dgvtknhanvien.DataSource = co.GetData("select * from tblNhanVien where DiaChi = '" + txttkdiachi.Text.Trim() + "'");

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn thoát không?", "Trả lời",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            frm.Show();
            this.Hide();
        }

        private void txttennv_TextChanged(object sender, EventArgs e)
        {
            co.KetNoi();
            dgvtknhanvien.DataSource = co.GetData("select * from tblNhanvien where TenNV like '" + txttennv.Text.Trim() + "%'");

        }

        private void txtmanv_TextChanged(object sender, EventArgs e)
        {
            co.KetNoi();
            dgvtknhanvien.DataSource = co.GetData("select * from tblNhanvien where MaNV = '" + txtmanv.Text.Trim() + "'");

        }

        private void txttennv_MouseClick(object sender, MouseEventArgs e)
        {
            txttennv.Clear();
        }

        private void txtmanv_MouseClick(object sender, MouseEventArgs e)
        {
            txtmanv.Clear();
        }
    }
}
