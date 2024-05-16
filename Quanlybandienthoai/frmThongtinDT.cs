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
    public partial class frmThongtinDT : Form
    {
        public frmThongtinDT()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        ConnectCSDL co = new ConnectCSDL();
        public void LoadData()
        {
            co.KetNoi();
            dgvmaytinh.DataSource = co.GetData("select * from tblThongtindienthoai");
            co.NgatKetNoi();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            this.txtgiaban.Clear();
            this.txtMDT.Clear();

            this.txtTDT.Clear();
            this.txtSoluong.Clear();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string sqlthem = "insert into tblThongtindienthoai values ('" + txtMDT.Text + "','" + txtTDT.Text
               + "','" + cboMNCC.Text + "','" + txtSoluong.Text + "','" + txtgiaban.Text + "')";

            co.ThucThi(sqlthem);
            LoadData();
            frmThongtinDT_Load(sender, e);
        }

        private void frmThongtinDT_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadData();

            cboMNCC.DataSource = co.GetData("select * from tblNhaCungCap");
            cboMNCC.ValueMember = "MaNCC";
            cboMNCC.DisplayMember = "MaNCC";
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sqlsua = "update tblThongtindienthoai set MaDT='" + txtMDT.Text + "',TenDT='" + txtTDT.Text
              + "',Soluong='" + txtSoluong.Text + "',Giaban='" + txtgiaban.Text + "',MaNCC='" + cboMNCC.SelectedValue +
              "' where MaDT ='" + txtMDT.Text + "'";
            co.ThucThi(sqlsua);
            LoadData();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn xóa không?", "Trả lời",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                string sqlxoa = "delete from tblThongtindienthoai where MaDT = '" + txtMDT.Text + "'";
                co.ThucThi(sqlxoa);
            }
            frmThongtinDT_Load(sender, e);
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

        private void dgvmaytinh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;
            txtMDT.Text = dgvmaytinh.Rows[i].Cells[0].Value.ToString().Trim();
            txtTDT.Text = dgvmaytinh.Rows[i].Cells[1].Value.ToString().Trim();
            cboMNCC.Text = dgvmaytinh.Rows[i].Cells[2].Value.ToString().Trim();
            txtSoluong.Text = dgvmaytinh.Rows[i].Cells[3].Value.ToString().Trim();
            txtgiaban.Text = dgvmaytinh.Rows[i].Cells[4].Value.ToString().Trim();
        }
    }
}
