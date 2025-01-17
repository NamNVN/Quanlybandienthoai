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
    public partial class frmKhachhang : Form
    {
        public frmKhachhang()
        {
            InitializeComponent();
        }

        ConnectCSDL co = new ConnectCSDL();
        public void LoadData()
        {
            co.KetNoi();
            dgvkhachhang.DataSource = co.GetData("select * from tblKhachHang");
            co.NgatKetNoi();
        }

        private void frmKhachhang_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btnlammoi_Click(object sender, EventArgs e)
        {
            this.txtmakh.Clear();
            this.txttenkh.Clear();
            this.txtdiachi.Clear();
            this.txtsdt.Clear();
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            string sqlthem = "insert into tblKhachHang values ('" + txtmakh.Text + "','" + txttenkh.Text
            + "','" + txtgioitinh.Text + "','" + txtdiachi.Text + "','" + txtsdt.Text + "')";
            co.ThucThi(sqlthem);
            frmKhachhang_Load(sender, e);
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            string sqlsua = "update tblKhachHang set MaKH='" + txtmakh.Text + "',TenKH='" + txttenkh.Text + "',GioiTinh = '" + txtgioitinh.Text
              + "',DiaChi='" + txtdiachi.Text + "',sdt='" + txtsdt.Text + "'where MaKH='" + txtmakh.Text + "'";
            co.ThucThi(sqlsua);
            LoadData();
            frmKhachhang_Load(sender, e);
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn xóa không?", "Trả lời",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
            {
                string sqlxoa = "delete from tblKhachHang where MaKH = '" + txtmakh.Text + "'";
                co.ThucThi(sqlxoa);
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Bạn có chắc muốn thoát không?", "Trả lời",
           MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK)
                Application.Exit();
        }

        private void dgvkhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = e.RowIndex;


            txtmakh.Text = dgvkhachhang.Rows[i].Cells[0].Value.ToString().Trim();
            txttenkh.Text = dgvkhachhang.Rows[i].Cells[1].Value.ToString().Trim();
            txtgioitinh.Text = dgvkhachhang.Rows[i].Cells[2].Value.ToString().Trim();
            txtdiachi.Text = dgvkhachhang.Rows[i].Cells[3].Value.ToString().Trim();
            txtsdt.Text = dgvkhachhang.Rows[i].Cells[4].Value.ToString().Trim();
        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            frmMenu tc = new frmMenu();
            tc.Show();
            this.Hide();
        }
    }
}
