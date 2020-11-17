using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qlphukien.utils
{
    class UtilsConnect // class kết nối
    {
        static SqlConnection con;
        static string connectString = @"Data Source=DESKTOP-CMEJ8G1\SQLEXPRESS;Initial Catalog=QuanLyPhuKien;Integrated Security=True";

        // kiểm tra kết nối
        public UtilsConnect()
        {
            con = new SqlConnection(connectString);
            if (con != null)
            {
                MessageBox.Show("Thành công !");
            }
            else
            {
                MessageBox.Show("fail!");
            }
        }

        // Mở kết nối
        public static void openConnect()
        {
            con.Open();
        }

        // Đóng kết nối 
        public static void closeConnect()
        {
            con.Close();
        }

        // Hàm lấy kết nối
        public static SqlConnection getConnection() 
        {
            if (con == null)
            {
                con = new SqlConnection(connectString);
            }
            return con;
        }
    }
}
