namespace Qlphukien
{
    partial class QLLoaiSanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QLLoaiSanPham));
            this.label1 = new System.Windows.Forms.Label();
            this.dgvLoaiSP = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapnhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtMotaLoaiSP = new System.Windows.Forms.TextBox();
            this.txtTenLoaisp = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMaLoaisp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSP)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Danh sách loại sản phẩm";
            // 
            // dgvLoaiSP
            // 
            this.dgvLoaiSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLoaiSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvLoaiSP.Location = new System.Drawing.Point(16, 78);
            this.dgvLoaiSP.Name = "dgvLoaiSP";
            this.dgvLoaiSP.Size = new System.Drawing.Size(495, 344);
            this.dgvLoaiSP.TabIndex = 2;
            this.dgvLoaiSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLoaiSP_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã loại sản phẩm";
            this.Column1.Name = "Column1";
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên loại sản phẩm";
            this.Column2.Name = "Column2";
            this.Column2.Width = 160;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Mô tả";
            this.Column3.Name = "Column3";
            this.Column3.Width = 200;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(424, 14);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(74, 43);
            this.btnRefresh.TabIndex = 27;
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnTimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimkiem.Image")));
            this.btnTimkiem.Location = new System.Drawing.Point(787, 12);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(116, 45);
            this.btnTimkiem.TabIndex = 31;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(825, 266);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(78, 38);
            this.btnXoa.TabIndex = 30;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapnhat
            // 
            this.btnCapnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnCapnhat.Image = ((System.Drawing.Image)(resources.GetObject("btnCapnhat.Image")));
            this.btnCapnhat.Location = new System.Drawing.Point(648, 266);
            this.btnCapnhat.Name = "btnCapnhat";
            this.btnCapnhat.Size = new System.Drawing.Size(122, 38);
            this.btnCapnhat.TabIndex = 29;
            this.btnCapnhat.Text = "Cập nhật";
            this.btnCapnhat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCapnhat.UseVisualStyleBackColor = true;
            this.btnCapnhat.Click += new System.EventHandler(this.btnCapnhat_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(521, 266);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(88, 38);
            this.btnThem.TabIndex = 28;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnThoat.Image = global::Quanlyphukien.Properties.Resources.exxit;
            this.btnThoat.Location = new System.Drawing.Point(775, 366);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(128, 65);
            this.btnThoat.TabIndex = 32;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtMotaLoaiSP
            // 
            this.txtMotaLoaiSP.Location = new System.Drawing.Point(681, 188);
            this.txtMotaLoaiSP.Multiline = true;
            this.txtMotaLoaiSP.Name = "txtMotaLoaiSP";
            this.txtMotaLoaiSP.Size = new System.Drawing.Size(223, 52);
            this.txtMotaLoaiSP.TabIndex = 38;
            // 
            // txtTenLoaisp
            // 
            this.txtTenLoaisp.Location = new System.Drawing.Point(681, 135);
            this.txtTenLoaisp.Multiline = true;
            this.txtTenLoaisp.Name = "txtTenLoaisp";
            this.txtTenLoaisp.Size = new System.Drawing.Size(223, 27);
            this.txtTenLoaisp.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(581, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Mô tả";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(541, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 20);
            this.label3.TabIndex = 35;
            this.label3.Text = "Tên loại sản phẩm";
            // 
            // txtMaLoaisp
            // 
            this.txtMaLoaisp.Location = new System.Drawing.Point(681, 85);
            this.txtMaLoaisp.Multiline = true;
            this.txtMaLoaisp.Name = "txtMaLoaisp";
            this.txtMaLoaisp.Size = new System.Drawing.Size(223, 28);
            this.txtMaLoaisp.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(541, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 20);
            this.label2.TabIndex = 33;
            this.label2.Text = "Mã loại sản phẩm";
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Location = new System.Drawing.Point(521, 14);
            this.txtTuKhoa.Multiline = true;
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(260, 44);
            this.txtTuKhoa.TabIndex = 39;
            // 
            // QLLoaiSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(920, 457);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.txtMotaLoaiSP);
            this.Controls.Add(this.txtTenLoaisp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtMaLoaisp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnCapnhat);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.dgvLoaiSP);
            this.Controls.Add(this.label1);
            this.Name = "QLLoaiSanPham";
            this.Text = "Quản Lý Loại Sản Phẩm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QLloaiSP_FormClosed);
            this.Load += new System.EventHandler(this.QLloaiSP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLoaiSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvLoaiSP;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapnhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtMotaLoaiSP;
        private System.Windows.Forms.TextBox txtTenLoaisp;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMaLoaisp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}