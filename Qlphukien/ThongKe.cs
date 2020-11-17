using Qlphukien.DAO;
using Qlphukien.model;
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
    public partial class ThongKe : Form
    {
        SanPhamDao spDao = new SanPhamDao();
        NhanVienDao nvDao = new NhanVienDao();
        // list chứa dssp dc thống kê
        List<SPTK> list;
        public ThongKe()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            // thời gian cố định bát đầu và kết thúc
            dateTimePickerFrom.CustomFormat = "dd/MM/yyyy";
            dateTimePickerto.CustomFormat = "dd/MM/yyyy";

            // lấy tg hiển thị cố định
            dateTimePickerFrom.Value = new DateTime(2018, 10, 01);
            dateTimePickerto.Value = DateTime.Now;
        }

        // tra cứu
        private void btnSearch_Click(object sender, EventArgs e)
        {
            // tất cả sp đã nhập từ .. đến ...
            list =  spDao.getAllSPNhap(dateTimePickerFrom.Value.ToString(),dateTimePickerto.Value.ToString());

            MessageBox.Show(dateTimePickerFrom.Value.ToString() + ":" + dateTimePickerto.Value.ToString());
            // hiển thị ds
            displayListTodgv(dgvsanpham, list);
            // tổng tiền
            lbl_totalmoney.Text = caculateTongtien()+" VNĐ";
        }

         // Pthuc tinh tong tien
        private int caculateTongtien()
        {
            int tongtien = 0;
            foreach(SPTK item in list)
            {
                tongtien += item.tongtien;
            }
            return tongtien;
        }

        // hiển thị ds sp trong dgv
        private void displayListTodgv(DataGridView dgv, List<SPTK> list)
        {
            dgv.Rows.Clear();

            dgv.ColumnCount = 6;

            int i = 0;
            foreach (SPTK item in list)
            {

                dgv.Rows.Add();
                dgv.Rows[i].Cells[0].Value = item.Tensp;
                dgv.Rows[i].Cells[1].Value = item.slnhap;
                dgv.Rows[i].Cells[2].Value = item.dongianhap + " đ";
                dgv.Rows[i].Cells[3].Value = item.tongtien + " đ";
                dgv.Rows[i].Cells[4].Value = nvDao.GetNameNhanVien(item.tennvnhap);
                dgv.Rows[i].Cells[5].Value = item.ngaynhap.Split(' ')[0];           
                i++;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
