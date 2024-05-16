
namespace Quanlybandienthoai
{
    partial class frmthongke
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblthangnam = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnThongke = new System.Windows.Forms.Button();
            this.btnquaylai = new System.Windows.Forms.Button();
            this.rdbHDB = new System.Windows.Forms.RadioButton();
            this.rdbHDN = new System.Windows.Forms.RadioButton();
            this.dgvTimkiem = new System.Windows.Forms.DataGridView();
            this.cbomanv = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimkiem)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 214);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvTimkiem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 214);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 236);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.cbomanv);
            this.groupBox1.Controls.Add(this.lblthangnam);
            this.groupBox1.Controls.Add(this.btnthoat);
            this.groupBox1.Controls.Add(this.btnThongke);
            this.groupBox1.Controls.Add(this.btnquaylai);
            this.groupBox1.Controls.Add(this.rdbHDB);
            this.groupBox1.Controls.Add(this.rdbHDN);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 196);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thống kê";
            // 
            // lblthangnam
            // 
            this.lblthangnam.AutoSize = true;
            this.lblthangnam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblthangnam.ForeColor = System.Drawing.Color.Black;
            this.lblthangnam.Location = new System.Drawing.Point(83, 65);
            this.lblthangnam.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblthangnam.Name = "lblthangnam";
            this.lblthangnam.Size = new System.Drawing.Size(114, 24);
            this.lblthangnam.TabIndex = 46;
            this.lblthangnam.Text = "Nhập MaNV";
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.SystemColors.Control;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnthoat.Location = new System.Drawing.Point(485, 147);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(127, 42);
            this.btnthoat.TabIndex = 49;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnThongke
            // 
            this.btnThongke.BackColor = System.Drawing.SystemColors.Control;
            this.btnThongke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongke.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnThongke.Location = new System.Drawing.Point(96, 147);
            this.btnThongke.Margin = new System.Windows.Forms.Padding(4);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(121, 42);
            this.btnThongke.TabIndex = 44;
            this.btnThongke.Text = "Thống kê";
            this.btnThongke.UseVisualStyleBackColor = false;
            this.btnThongke.Click += new System.EventHandler(this.btnThongke_Click);
            // 
            // btnquaylai
            // 
            this.btnquaylai.BackColor = System.Drawing.SystemColors.Control;
            this.btnquaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquaylai.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnquaylai.Location = new System.Drawing.Point(287, 147);
            this.btnquaylai.Margin = new System.Windows.Forms.Padding(4);
            this.btnquaylai.Name = "btnquaylai";
            this.btnquaylai.Size = new System.Drawing.Size(119, 42);
            this.btnquaylai.TabIndex = 45;
            this.btnquaylai.Text = "Quay lại";
            this.btnquaylai.UseVisualStyleBackColor = false;
            this.btnquaylai.Click += new System.EventHandler(this.btnquaylai_Click_1);
            // 
            // rdbHDB
            // 
            this.rdbHDB.AutoSize = true;
            this.rdbHDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbHDB.ForeColor = System.Drawing.Color.Black;
            this.rdbHDB.Location = new System.Drawing.Point(419, 81);
            this.rdbHDB.Margin = new System.Windows.Forms.Padding(4);
            this.rdbHDB.Name = "rdbHDB";
            this.rdbHDB.Size = new System.Drawing.Size(142, 28);
            this.rdbHDB.TabIndex = 47;
            this.rdbHDB.TabStop = true;
            this.rdbHDB.Text = "Hóa đơn bán";
            this.rdbHDB.UseVisualStyleBackColor = true;
            // 
            // rdbHDN
            // 
            this.rdbHDN.AutoSize = true;
            this.rdbHDN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbHDN.ForeColor = System.Drawing.Color.Black;
            this.rdbHDN.Location = new System.Drawing.Point(419, 38);
            this.rdbHDN.Margin = new System.Windows.Forms.Padding(4);
            this.rdbHDN.Name = "rdbHDN";
            this.rdbHDN.Size = new System.Drawing.Size(153, 28);
            this.rdbHDN.TabIndex = 48;
            this.rdbHDN.TabStop = true;
            this.rdbHDN.Text = "Hóa đơn nhập";
            this.rdbHDN.UseVisualStyleBackColor = true;
            // 
            // dgvTimkiem
            // 
            this.dgvTimkiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTimkiem.Location = new System.Drawing.Point(12, 6);
            this.dgvTimkiem.Name = "dgvTimkiem";
            this.dgvTimkiem.RowHeadersWidth = 51;
            this.dgvTimkiem.RowTemplate.Height = 24;
            this.dgvTimkiem.Size = new System.Drawing.Size(776, 218);
            this.dgvTimkiem.TabIndex = 0;
            // 
            // cbomanv
            // 
            this.cbomanv.FormattingEnabled = true;
            this.cbomanv.Location = new System.Drawing.Point(214, 61);
            this.cbomanv.Name = "cbomanv";
            this.cbomanv.Size = new System.Drawing.Size(146, 33);
            this.cbomanv.TabIndex = 52;
            // 
            // frmthongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmthongke";
            this.Text = "frmthongke";
            this.Load += new System.EventHandler(this.frmthongke_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTimkiem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblthangnam;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.Button btnquaylai;
        private System.Windows.Forms.RadioButton rdbHDB;
        private System.Windows.Forms.RadioButton rdbHDN;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvTimkiem;
        private System.Windows.Forms.ComboBox cbomanv;
    }
}