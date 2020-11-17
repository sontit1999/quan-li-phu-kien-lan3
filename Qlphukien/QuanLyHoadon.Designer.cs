namespace Qlphukien
{
    partial class QuanLyHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuanLyHoaDon));
            this.txtTuKhoa = new System.Windows.Forms.TextBox();
            this.txtSoluong = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnRefreshHD = new System.Windows.Forms.Button();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDSSP = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_ThemSPMoi = new System.Windows.Forms.Button();
            this.cbSanPham = new System.Windows.Forms.ComboBox();
            this.btn_AddSPtoHoaDon = new System.Windows.Forms.Button();
            this.btn_XoaSP = new System.Windows.Forms.Button();
            this.btn_CapNhap = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTuKhoa
            // 
            this.txtTuKhoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtTuKhoa.Location = new System.Drawing.Point(592, 11);
            this.txtTuKhoa.Multiline = true;
            this.txtTuKhoa.Name = "txtTuKhoa";
            this.txtTuKhoa.Size = new System.Drawing.Size(245, 38);
            this.txtTuKhoa.TabIndex = 54;
            // 
            // txtSoluong
            // 
            this.txtSoluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.txtSoluong.Location = new System.Drawing.Point(712, 110);
            this.txtSoluong.Multiline = true;
            this.txtSoluong.Name = "txtSoluong";
            this.txtSoluong.Size = new System.Drawing.Size(140, 24);
            this.txtSoluong.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(596, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 51;
            this.label4.Text = "Số lượng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(589, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 20);
            this.label3.TabIndex = 50;
            this.label3.Text = "Tên  sản phẩm";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnThoat.Image = ((System.Drawing.Image)(resources.GetObject("btnThoat.Image")));
            this.btnThoat.Location = new System.Drawing.Point(841, 416);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(128, 67);
            this.btnThoat.TabIndex = 47;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnTimkiem.Image = ((System.Drawing.Image)(resources.GetObject("btnTimkiem.Image")));
            this.btnTimkiem.Location = new System.Drawing.Point(858, 11);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(119, 37);
            this.btnTimkiem.TabIndex = 46;
            this.btnTimkiem.Text = "Tìm kiếm";
            this.btnTimkiem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(659, 416);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(128, 67);
            this.btnThem.TabIndex = 43;
            this.btnThem.Text = "Thêm HD";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnRefreshHD
            // 
            this.btnRefreshHD.Image = ((System.Drawing.Image)(resources.GetObject("btnRefreshHD.Image")));
            this.btnRefreshHD.Location = new System.Drawing.Point(505, 11);
            this.btnRefreshHD.Name = "btnRefreshHD";
            this.btnRefreshHD.Size = new System.Drawing.Size(64, 38);
            this.btnRefreshHD.TabIndex = 42;
            this.btnRefreshHD.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnRefreshHD.UseVisualStyleBackColor = true;
            this.btnRefreshHD.Click += new System.EventHandler(this.btnRefreshHD_Click);
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvHoaDon.Location = new System.Drawing.Point(41, 65);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.Size = new System.Drawing.Size(528, 187);
            this.dgvHoaDon.TabIndex = 41;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            this.dgvHoaDon.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSSP_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Mã hóa đơn";
            this.Column1.Name = "Column1";
            this.Column1.Width = 120;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Tên nhân viên";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ngày lập";
            this.Column3.Name = "Column3";
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Tổng tiền";
            this.Column4.Name = "Column4";
            this.Column4.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(37, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 29);
            this.label1.TabIndex = 40;
            this.label1.Text = "Danh sách hóa đơn";
            // 
            // dgvDSSP
            // 
            this.dgvDSSP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSSP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8});
            this.dgvDSSP.Location = new System.Drawing.Point(41, 299);
            this.dgvDSSP.Name = "dgvDSSP";
            this.dgvDSSP.Size = new System.Drawing.Size(527, 173);
            this.dgvDSSP.TabIndex = 56;
            this.dgvDSSP.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSSP_CellClick);
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Tên sản phẩm";
            this.Column6.Name = "Column6";
            this.Column6.Width = 150;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Số lượng";
            this.Column7.Name = "Column7";
            this.Column7.Width = 120;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Tiền phải trả";
            this.Column8.Name = "Column8";
            this.Column8.Width = 120;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(37, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(253, 29);
            this.label5.TabIndex = 55;
            this.label5.Text = "Danh sách sản phẩm";
            // 
            // btn_ThemSPMoi
            // 
            this.btn_ThemSPMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_ThemSPMoi.Location = new System.Drawing.Point(866, 70);
            this.btn_ThemSPMoi.Name = "btn_ThemSPMoi";
            this.btn_ThemSPMoi.Size = new System.Drawing.Size(111, 23);
            this.btn_ThemSPMoi.TabIndex = 62;
            this.btn_ThemSPMoi.Text = "Thêm SP mới";
            this.btn_ThemSPMoi.UseVisualStyleBackColor = true;
            this.btn_ThemSPMoi.Click += new System.EventHandler(this.btn_ThemSPMoi_Click);
            // 
            // cbSanPham
            // 
            this.cbSanPham.FormattingEnabled = true;
            this.cbSanPham.Location = new System.Drawing.Point(712, 73);
            this.cbSanPham.Name = "cbSanPham";
            this.cbSanPham.Size = new System.Drawing.Size(140, 21);
            this.cbSanPham.TabIndex = 63;
            this.cbSanPham.SelectedIndexChanged += new System.EventHandler(this.cbSanPham_SelectedIndexChanged);
            // 
            // btn_AddSPtoHoaDon
            // 
            this.btn_AddSPtoHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_AddSPtoHoaDon.Location = new System.Drawing.Point(634, 165);
            this.btn_AddSPtoHoaDon.Name = "btn_AddSPtoHoaDon";
            this.btn_AddSPtoHoaDon.Size = new System.Drawing.Size(80, 28);
            this.btn_AddSPtoHoaDon.TabIndex = 64;
            this.btn_AddSPtoHoaDon.Text = "Thêm SP";
            this.btn_AddSPtoHoaDon.UseVisualStyleBackColor = true;
            this.btn_AddSPtoHoaDon.Click += new System.EventHandler(this.btn_AddSPtoHoaDon_Click);
            // 
            // btn_XoaSP
            // 
            this.btn_XoaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_XoaSP.Location = new System.Drawing.Point(878, 165);
            this.btn_XoaSP.Name = "btn_XoaSP";
            this.btn_XoaSP.Size = new System.Drawing.Size(80, 28);
            this.btn_XoaSP.TabIndex = 65;
            this.btn_XoaSP.Text = "Xóa SP";
            this.btn_XoaSP.UseVisualStyleBackColor = true;
            this.btn_XoaSP.Click += new System.EventHandler(this.btn_XoaSP_Click);
            // 
            // btn_CapNhap
            // 
            this.btn_CapNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.btn_CapNhap.Location = new System.Drawing.Point(750, 165);
            this.btn_CapNhap.Name = "btn_CapNhap";
            this.btn_CapNhap.Size = new System.Drawing.Size(101, 28);
            this.btn_CapNhap.TabIndex = 66;
            this.btn_CapNhap.Text = "Cập nhật SP";
            this.btn_CapNhap.UseVisualStyleBackColor = true;
            this.btn_CapNhap.Click += new System.EventHandler(this.btn_CapNhat_Click);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(505, 258);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(64, 34);
            this.button4.TabIndex = 67;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // QuanLyHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 531);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btn_CapNhap);
            this.Controls.Add(this.btn_XoaSP);
            this.Controls.Add(this.btn_AddSPtoHoaDon);
            this.Controls.Add(this.cbSanPham);
            this.Controls.Add(this.btn_ThemSPMoi);
            this.Controls.Add(this.dgvDSSP);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTuKhoa);
            this.Controls.Add(this.txtSoluong);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnRefreshHD);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyHoaDon";
            this.Text = "Quản Lý Hóa Đơn";
            this.Load += new System.EventHandler(this.QuanLyHoadon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTuKhoa;
        private System.Windows.Forms.TextBox txtSoluong;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnRefreshHD;
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDSSP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_ThemSPMoi;
        private System.Windows.Forms.ComboBox cbSanPham;
        private System.Windows.Forms.Button btn_AddSPtoHoaDon;
        private System.Windows.Forms.Button btn_XoaSP;
        private System.Windows.Forms.Button btn_CapNhap;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
    }
}