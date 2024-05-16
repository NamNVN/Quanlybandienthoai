
namespace Quanlybandienthoai
{
    partial class frmtimkiemDT
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
            this.btnthoat = new System.Windows.Forms.Button();
            this.txttktheoten = new System.Windows.Forms.TextBox();
            this.btnquaylai = new System.Windows.Forms.Button();
            this.btntktheoten = new System.Windows.Forms.Button();
            this.btntktheoma = new System.Windows.Forms.Button();
            this.txttktheoma = new System.Windows.Forms.TextBox();
            this.dgvtkthongtinmaytinh = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtkthongtinmaytinh)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 224);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvtkthongtinmaytinh);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 224);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 226);
            this.panel2.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.btnthoat);
            this.groupBox1.Controls.Add(this.btntktheoten);
            this.groupBox1.Controls.Add(this.txttktheoten);
            this.groupBox1.Controls.Add(this.txttktheoma);
            this.groupBox1.Controls.Add(this.btnquaylai);
            this.groupBox1.Controls.Add(this.btntktheoma);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tìm kiếm thông tin điện thoại";
            // 
            // btnthoat
            // 
            this.btnthoat.BackColor = System.Drawing.SystemColors.Control;
            this.btnthoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthoat.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnthoat.Location = new System.Drawing.Point(389, 167);
            this.btnthoat.Margin = new System.Windows.Forms.Padding(4);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(136, 32);
            this.btnthoat.TabIndex = 50;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = false;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // txttktheoten
            // 
            this.txttktheoten.BackColor = System.Drawing.Color.White;
            this.txttktheoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttktheoten.Location = new System.Drawing.Point(135, 55);
            this.txttktheoten.Margin = new System.Windows.Forms.Padding(4);
            this.txttktheoten.Name = "txttktheoten";
            this.txttktheoten.Size = new System.Drawing.Size(128, 26);
            this.txttktheoten.TabIndex = 47;
            this.txttktheoten.Text = "Nhập vào tên";
            this.txttktheoten.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txttktheoten_MouseClick);
            this.txttktheoten.TextChanged += new System.EventHandler(this.txttktheoten_TextChanged);
            // 
            // btnquaylai
            // 
            this.btnquaylai.BackColor = System.Drawing.SystemColors.Control;
            this.btnquaylai.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnquaylai.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnquaylai.Location = new System.Drawing.Point(191, 167);
            this.btnquaylai.Margin = new System.Windows.Forms.Padding(4);
            this.btnquaylai.Name = "btnquaylai";
            this.btnquaylai.Size = new System.Drawing.Size(136, 32);
            this.btnquaylai.TabIndex = 49;
            this.btnquaylai.Text = "Quay lại";
            this.btnquaylai.UseVisualStyleBackColor = false;
            this.btnquaylai.Click += new System.EventHandler(this.btnquaylai_Click);
            // 
            // btntktheoten
            // 
            this.btntktheoten.BackColor = System.Drawing.SystemColors.Control;
            this.btntktheoten.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntktheoten.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btntktheoten.Location = new System.Drawing.Point(312, 49);
            this.btntktheoten.Margin = new System.Windows.Forms.Padding(4);
            this.btntktheoten.Name = "btntktheoten";
            this.btntktheoten.Size = new System.Drawing.Size(136, 32);
            this.btntktheoten.TabIndex = 45;
            this.btntktheoten.Text = "TK theo tên";
            this.btntktheoten.UseVisualStyleBackColor = false;
            // 
            // btntktheoma
            // 
            this.btntktheoma.BackColor = System.Drawing.SystemColors.Control;
            this.btntktheoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntktheoma.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btntktheoma.Location = new System.Drawing.Point(312, 109);
            this.btntktheoma.Margin = new System.Windows.Forms.Padding(4);
            this.btntktheoma.Name = "btntktheoma";
            this.btntktheoma.Size = new System.Drawing.Size(136, 32);
            this.btntktheoma.TabIndex = 46;
            this.btntktheoma.Text = "TK theo mã";
            this.btntktheoma.UseVisualStyleBackColor = false;
            this.btntktheoma.Click += new System.EventHandler(this.btntktheoma_Click);
            // 
            // txttktheoma
            // 
            this.txttktheoma.BackColor = System.Drawing.Color.White;
            this.txttktheoma.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttktheoma.Location = new System.Drawing.Point(135, 115);
            this.txttktheoma.Margin = new System.Windows.Forms.Padding(4);
            this.txttktheoma.Name = "txttktheoma";
            this.txttktheoma.Size = new System.Drawing.Size(128, 26);
            this.txttktheoma.TabIndex = 48;
            this.txttktheoma.Text = "Nhập vào mã";
            this.txttktheoma.MouseClick += new System.Windows.Forms.MouseEventHandler(this.txttktheoma_MouseClick);
            this.txttktheoma.TextChanged += new System.EventHandler(this.txttktheoma_TextChanged);
            // 
            // dgvtkthongtinmaytinh
            // 
            this.dgvtkthongtinmaytinh.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvtkthongtinmaytinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtkthongtinmaytinh.Location = new System.Drawing.Point(12, 7);
            this.dgvtkthongtinmaytinh.Margin = new System.Windows.Forms.Padding(4);
            this.dgvtkthongtinmaytinh.Name = "dgvtkthongtinmaytinh";
            this.dgvtkthongtinmaytinh.RowHeadersWidth = 51;
            this.dgvtkthongtinmaytinh.Size = new System.Drawing.Size(775, 206);
            this.dgvtkthongtinmaytinh.TabIndex = 23;
            // 
            // frmtimkiemDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmtimkiemDT";
            this.Text = "Tìm kiếm điện thoại";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtkthongtinmaytinh)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btntktheoten;
        private System.Windows.Forms.TextBox txttktheoten;
        private System.Windows.Forms.TextBox txttktheoma;
        private System.Windows.Forms.Button btnquaylai;
        private System.Windows.Forms.Button btntktheoma;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgvtkthongtinmaytinh;
    }
}