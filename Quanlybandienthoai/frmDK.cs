using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Quanlybandienthoai
{
    public partial class frmDK : Form
    {
        public frmDK()
        {
            InitializeComponent();
        }

        private void btnDK_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=LAPTOP-FMT16EF1\SQLEXPRESS;Initial Catalog=Quanlytaikhoan;Integrated Security=True";
           
                if (txtTK.Text == "" || txtMK.Text == "")
                    MessageBox.Show("please fill");
                else if (txtMK.Text != txtNL.Text)
                    MessageBox.Show("sai pas");
                else
                {
                    using (SqlConnection sqlCon = new SqlConnection(connectionString))
                    {
                        sqlCon.Open();
                        SqlCommand sqlcmd = new SqlCommand("THEMTK", sqlCon);
                        sqlcmd.CommandType = CommandType.StoredProcedure;
                        sqlcmd.Parameters.AddWithValue("@Hoten", txtHT.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@SDT", txtSDT.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@Diachi", txtDC.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@TaiKhoan", txtTK.Text.Trim());
                        sqlcmd.Parameters.AddWithValue("@MatKhau", txtMK.Text.Trim());
                        sqlcmd.ExecuteNonQuery();
                        MessageBox.Show("Đăng kí thành công");
                    frmDN frmDN = new frmDN();
                    frmDN.Show();
                    this.Hide();
                   
                        Clear();
                    }
                }
                void Clear()
                {
                    txtHT.Text = txtSDT.Text = txtDC.Text = txtTK.Text = txtMK.Text = txtNL.Text = "";
                }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDN frmDN = new frmDN();
            frmDN.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
