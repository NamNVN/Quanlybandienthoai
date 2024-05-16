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
    public partial class frmthongke : Form
    {
        public frmthongke()
        {
            InitializeComponent();
        }

        ConnectCSDL co = new ConnectCSDL();

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

        private void btnThongke_Click(object sender, EventArgs e)
        {

            if (rdbHDB.Checked == true)
            {
                co.KetNoi();
                string sqlTK = "select * from tblHoadonban where MaNV = '" + cbomanv.Text + "'";
                dgvTimkiem.DataSource = co.GetData(sqlTK);
            }
            if (rdbHDN.Checked == true)
            {
                co.KetNoi();
                string sqlTK = "select * from tblHoadonnhap where MaNV = '" + cbomanv.Text + "'";
                dgvTimkiem.DataSource = co.GetData(sqlTK);
            }

        }



        private void btnquaylai_Click_1(object sender, EventArgs e)
        {
            frmMenu tc = new frmMenu();
            tc.Show();
            this.Hide();
        }

        private void mtbThangnam_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
           
        }

        private void mtbThangnam_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void mtbThangnam_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void frmthongke_Load(object sender, EventArgs e)
        {
            LoadData();
            cbomanv.DataSource = co.GetData("select * from tblNhanVien");
            cbomanv.ValueMember = "MaNV";
            cbomanv.DisplayMember = "MaNV";
        }

        public void LoadData()
        {
          
                co.KetNoi();
              
                co.NgatKetNoi();
            
        }
    }
}
