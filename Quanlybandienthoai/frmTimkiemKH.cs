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
    public partial class frmTimkiemKH : Form
    {
        public frmTimkiemKH()
        {
            InitializeComponent();
        }

        ConnectCSDL co = new ConnectCSDL();

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            co.KetNoi();
            dgvtkkhachhang.DataSource = co.GetData("select * from tblKhachHang where MaKH = '" + txtmakh.Text.Trim() + "'");
            co.KetNoi();
            dgvtkkhachhang.DataSource = co.GetData("select * from tblKhachHang where TenKH = '" + txttenkh.Text.Trim() + "'");
            co.KetNoi();
            dgvtkkhachhang.DataSource = co.GetData("select * from tblKhachHang where Diachi = '" + txtdiachi.Text.Trim() + "'");

        }

        private void txttenkh_TextChanged(object sender, EventArgs e)
        {
            co.KetNoi();
            dgvtkkhachhang.DataSource = co.GetData("select * from tblKhachHang where TenKH like '" + txttenkh.Text.Trim() + "%'");

        }

        private void txttenkh_MouseClick(object sender, MouseEventArgs e)
        {
            txttenkh.Clear();
        }

        private void txtmakh_MouseClick(object sender, MouseEventArgs e)
        {
            txtmakh.Clear();
        }

        private void txtmakh_TextChanged(object sender, EventArgs e)
        {
            co.KetNoi();
            dgvtkkhachhang.DataSource = co.GetData("select * from tblKhachHang where MaKH = '" + txtmakh.Text.Trim() + "'");

        }

        private void btnquaylai_Click(object sender, EventArgs e)
        {
            frmMenu frm = new frmMenu();
            frm.Show();
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
