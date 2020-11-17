using Qlphukien.DAO;
using Qlphukien.model;
using Qlphukien.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qlphukien
{
    public partial class QuanLyHoaDon : Form
    {
        List<SanPham> list = new List<SanPham>();

        HoaDonDao hdDao = new HoaDonDao();
        ChiTietHoaDonDAO ChiTietHoaDonDAO = new ChiTietHoaDonDAO();
        SanPhamDao spDao = new SanPhamDao();
        NhanVienDao nvDao = new NhanVienDao();

        string mahdSelected = null;
        //
        int indexSanPhamSelected = -5;
        public QuanLyHoaDon()
        {
            InitializeComponent();   
        }

        private void QuanLyHoadon_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            // hiển thị ds hđ gồm dgv và tất cả hđ
            displayHD(dgvHoaDon, hdDao.getAllHD());

            // hiển thị trên combobox tên SanPham
            cbSanPham.DataSource = spDao.getAllSP();
            // DisplayMember là hiển thị 
            cbSanPham.DisplayMember = "TenSP";
            // ValueMember là lưu lại
            cbSanPham.ValueMember = "MaSP";
        }

        // làm mới ds hđ
        private void btnRefreshHD_Click(object sender, EventArgs e)
        {
            displayHD(dgvHoaDon, hdDao.getAllHD());
        }

        // hiển thị hđ gồm dgv và list
        private void displayHD(DataGridView dgv, List<HoaDon> list)
        {
            dgv.Rows.Clear();

            dgv.ColumnCount = 4; // 4 cột

            int i = 0;
            foreach (HoaDon item in list)
            {
                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = item.MaHD;
                dgv.Rows[i].Cells[1].Value = nvDao.GetNameNhanVien(item.MaNV);
                // split tác chuỗi vì trong mã hđ có số tự tăng và ngày lập hđ
                dgv.Rows[i].Cells[2].Value = item.NgayLap.Split(null)[0];
                dgv.Rows[i].Cells[3].Value = item.TongTienHD + " VND";
                i++;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
        // thêm sp mới vào ds
        private void btn_ThemSPMoi_Click(object sender, EventArgs e)
        {
            QLSanPham QLSP = new QLSanPham(this);
            QLSP.Show();
        }

        // kiem tra masp trong ds
        public int checkSPinListExist(string masp)
        {
           for(int i=0;i<list.Count;i++)
            {
                if (list[i].MaSP.Equals(masp))
                {
                    return i;
                }
            }
            return -1;
        }

        // hiển thị ds hđ
        private void disPlayListToDGV(DataGridView dgv,List<SanPham> list)
        {
            dgv.Rows.Clear();

            dgv.ColumnCount = 4;

            int i = 0;
            foreach (SanPham item in list)
            {

                dgv.Rows.Add();
    
                dgv.Rows[i].Cells[0].Value = spDao.getNameProduct(item.MaSP);
                dgv.Rows[i].Cells[1].Value = item.SoLuong;
                dgv.Rows[i].Cells[2].Value = (item.SoLuong * item.GiaNhap) + " VND"; 
                i++;
            }
        }

        // Hiển thị ds sp trong 1 hđ (dgv chi tiết hđ)
        private void disPlayListCTHDToDGV(DataGridView dgv, List<ChiTietHoaDon> list)
        {
            dgv.Rows.Clear();
            dgv.ColumnCount = 4;

            int i = 0;
            foreach (ChiTietHoaDon item in list)
            {

               dgv.Rows.Add();
               // lấy tên sp theo mã 
               dgv.Rows[i].Cells[0].Value = spDao.getNameProduct(item.MaSP);
               dgv.Rows[i].Cells[1].Value = item.SoLuongSP;
                // tong tien = so luong * gia
               dgv.Rows[i].Cells[2].Value = (item.SoLuongSP * spDao.getPriceProduct(item.MaSP)) + " VND";
               i++;
            }
        }

        // làm mới lại combobox sp
        public void reFreshComboboxSanPham()
        {
            cbSanPham.DataSource = spDao.getAllSP();
            cbSanPham.DisplayMember = "TenSP";
            cbSanPham.ValueMember = "MaSP";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void cbSanPham_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            if(list.Count == 0)
            {
                MessageBox.Show("Phải nhập ít nhất 1 sản phẩm!");
            }
            else
            {
               
               

                HoaDon hd = new HoaDon("x", SingleToneUser.nv.MaNv, DateTime.Now.ToString("yyyy-MM-dd"), getTongtien());
                hdDao.AddHoaDon(hd); // thêm
                string mahd = hdDao.getMaxMaHD().ToString();
                foreach (SanPham item in list)
                {
                    ChiTietHoaDon cthd = new ChiTietHoaDon(mahd, item.MaSP, item.SoLuong, item.SoLuong * item.GiaNhap);
                
                    spDao.UpdateSLSanPham(item.MaSP, item.SoLuong);
                    ChiTietHoaDonDAO.AddCTHoaDon(cthd);
                }

                displayHD(dgvHoaDon, hdDao.getAllHD());
                list.Clear();
                disPlayListToDGV(dgvDSSP, list); 
                MessageBox.Show("thêm hóa đơn thành công ");
            }
        }
        // pthuc tính tổng tiền
        private int getTongtien()
        {
            int tongtien = 0;
            foreach (SanPham item in list)
            {

                tongtien += item.SoLuong * item.GiaNhap;
            }
            return tongtien;
        }


        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // chua hiểu 
           int index = e.RowIndex;
           if(index > 0 && index < dgvHoaDon.RowCount-1)
            {
                string mhd = dgvHoaDon.Rows[index].Cells[0].Value.ToString();
                mahdSelected = mhd;
                disPlayListCTHDToDGV(dgvDSSP, ChiTietHoaDonDAO.getChiTietHDFromMaHD(mhd));
            }
        }

        // thêm sp vào hđ
        private void btn_AddSPtoHoaDon_Click(object sender, EventArgs e)
        {
            // kiểm tra sp đã có chua
            SanPham sp = spDao.CheckSP(cbSanPham.SelectedValue.ToString());
            if (sp != null)
            {
                // ktra mã sp
                int index = checkSPinListExist(sp.MaSP);
                if (index >= 0)
                { 
                    list[index].SoLuong = list[index].SoLuong + Convert.ToInt32(txtSoluong.Text);
                }
                else
                {
                    if (txtSoluong.Text.Equals(""))
                    {
                        MessageBox.Show("Số lượng phải dc nhập và là số !!");
                    }
                    else
                    {
                        sp.SoLuong = Convert.ToInt32(txtSoluong.Text);
                        list.Add(sp);
                    }
                    
                }


            }
            disPlayListToDGV(dgvDSSP, list);
        }

        // tìm kiếm
        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string keyword = txtTuKhoa.Text;
            if (keyword.Equals(""))
            {
                MessageBox.Show("Phải nhập nội dung vào ô tìm kiếm( tên sản phẩm hoặc mô tả )");
            }
            else
            {
                // hiển thị ds
                displayHD(dgvHoaDon, hdDao.SearchHD(keyword));
            }
        }

        private void dgvDSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexSanPhamSelected = e.RowIndex;
        }

        // Xóa sp trong hđ
        private void btn_XoaSP_Click(object sender, EventArgs e)
        {
            if(indexSanPhamSelected >= 0 && indexSanPhamSelected < list.Count)
            {
                // xóa sp trong list khi tìm dc
                list.RemoveAt(indexSanPhamSelected);
                disPlayListToDGV(dgvDSSP, list);
            }
        }

        // Cập nhật thông tin sp trong hđ
        private void btn_CapNhat_Click(object sender, EventArgs e)
        {
            if (indexSanPhamSelected >= 0 && indexSanPhamSelected < list.Count)
            {
                list[indexSanPhamSelected].SoLuong = Convert.ToInt32(txtSoluong.Text);
                disPlayListToDGV(dgvDSSP, list);
            }
        }


        // ở đâu nút nào
        private void button4_Click(object sender, EventArgs e)
        {
            disPlayListToDGV(dgvDSSP, list);
        }
    }
}
