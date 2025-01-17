﻿using System;
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
    public partial class frmNhanvien : Form
    {
        public frmNhanvien()
        {
            InitializeComponent();
        }

        ConnectCSDL co = new ConnectCSDL();
        public void LoadData()
        {
            co.KetNoi();
            dgvnhanvien.DataSource = co.GetData("select * from tblNhanVien");
            co.NgatKetNoi();
        }

        private void frmNhanvien_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            this.txtmanv.Clear();
            this.txttennv.Clear();
            this.txtgioitinh.Clear();
            this.txtdiachi.Clear();
            this.txtsdt.Clear();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string sqlthem = "insert into tblNhanVien values ('" + txtmanv.Text + "','" + txttennv.Text + "','" + txtgioitinh.Text + "','" + txtdiachi.Text + "','" + txtsdt.Text + "')";
            co.ThucThi(sqlthem);
            frmNhanvien_Load(sender, e);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sqlsua = "update tblNhanVien set MaNV='" + txtmanv.Text
            + "',TenNV='" + txttennv.Text + "',GioiTinh = '" + txtgioitinh.Text + "',DiaChi='" + txtdiachi.Text + "',sdt='" + txtsdt.Text + "'where MaNV='" + txtmanv.Text + "'";
            co.ThucThi(sqlsua);
            LoadData();
            frmNhanvien_Load(sender, e);
        }

        private void dgvnhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;

            txtmanv.Text = dgvnhanvien.Rows[i].Cells[0].Value.ToString().Trim();
            txttennv.Text = dgvnhanvien.Rows[i].Cells[1].Value.ToString().Trim();
            txtgioitinh.Text = dgvnhanvien.Rows[i].Cells[2].Value.ToString().Trim();
            txtdiachi.Text = dgvnhanvien.Rows[i].Cells[3].Value.ToString().Trim();
            txtsdt.Text = dgvnhanvien.Rows[i].Cells[4].Value.ToString().Trim();
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn xóa không?", "Trả lời",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                string sqlxoa = "delete from tblNhanVien where MaNV = '" + txtmanv.Text + "'";
                co.ThucThi(sqlxoa);
            }
            frmNhanvien_Load(sender, e);
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
