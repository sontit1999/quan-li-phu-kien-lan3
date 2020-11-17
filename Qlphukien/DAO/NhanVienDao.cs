﻿using Qlphukien.model;
using Qlphukien.utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Qlphukien.DAO
{
    // DAO là Data Access Object nghĩa là truy xuất dữ liệu đối tượng
    class NhanVienDao 
    {
        SqlConnection con;
        public NhanVienDao()
        {
            con = UtilsConnect.getConnection();
        }
        // hàm lấy tất cả nhân viên
        public List<NhanVien> getAllNhanVien() // ds nhân viên
        {
            List<NhanVien> list = new List<NhanVien>();
            NhanVien nv = null;
            con.Open();
            string sql = "select * from NhanVien";
            SqlCommand cmd = new SqlCommand(sql, con);
         
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {   
                nv = new NhanVien(dr["MaNhanVien"].ToString(), dr["HoTenNhanVien"].ToString(), dr["GioiTinh"].ToString(), dr["NgaySinh"].ToString(), dr["DiaChi"].ToString(), dr["SoDienThoai"].ToString(), dr["MatKhau"].ToString(), dr["PhanQuyen"].ToString());
                list.Add(nv);
            }
            con.Close();
            return list;
        }
        // hàm kiểm tra đăng nhập mã nv và mật khẩu
        public NhanVien getNhanVien(string username,string password)
        {
            NhanVien nv = null;
            con.Open();
            string sql = "select * from NhanVien where MaNhanVien = @manv and MatKhau = @pass";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("manv", username);
            cmd.Parameters.AddWithValue("pass", password);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                nv = new NhanVien(dr["MaNhanVien"].ToString(), dr["HoTenNhanVien"].ToString(), dr["GioiTinh"].ToString(), dr["NgaySinh"].ToString(), dr["DiaChi"].ToString(), dr["SoDienThoai"].ToString(), dr["MatKhau"].ToString(), dr["PhanQuyen"].ToString());
                break;
            }
            con.Close();
            return nv;
        }
        // hàm check nhân viên đã có hay chưa
        public NhanVien CheckNhanVien(string ManvCantim)
        {
            NhanVien nv = null;
            con.Open();
            string sql = "select * from NhanVien where MaNhanVien = @manv";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("manv", ManvCantim);
    
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                nv = new NhanVien(dr["MaNhanVien"].ToString(), dr["HoTenNhanVien"].ToString(), dr["GioiTinh"].ToString(), dr["NgaySinh"].ToString(), dr["DiaChi"].ToString(), dr["SoDienThoai"].ToString(), dr["MatKhau"].ToString(), dr["PhanQuyen"].ToString());
                break;
            }
            con.Close();
            return nv;
        }
        // hàm lấy tên nhân viên from manv
        public string GetNameNhanVien(string ManvCantim)
        {
            NhanVien nv = null;
            con.Open();
            string sql = "select * from NhanVien where MaNhanVien = @manv";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("manv", ManvCantim);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                nv = new NhanVien(dr["MaNhanVien"].ToString(), dr["HoTenNhanVien"].ToString(), dr["GioiTinh"].ToString(), dr["NgaySinh"].ToString(), dr["DiaChi"].ToString(), dr["SoDienThoai"].ToString(), dr["MatKhau"].ToString(), dr["PhanQuyen"].ToString());
                break;
            }
            con.Close();
            return nv.TenNv;
        }
        // hàm get name nhân viên from manv
        public string GetNameNhanVienxxx(string ManvCantim)
        {
            NhanVien nv = null;
            con.Close();
            con.Open();
            string sql = "select * from NhanVien where MaNhanVien = @manv";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("manv", ManvCantim);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                nv = new NhanVien(dr["MaNhanVien"].ToString(), dr["HoTenNhanVien"].ToString(), dr["GioiTinh"].ToString(), dr["NgaySinh"].ToString(), dr["DiaChi"].ToString(), dr["SoDienThoai"].ToString(), dr["MatKhau"].ToString(), dr["PhanQuyen"].ToString());
                break;
            }
            con.Close();
            return nv.TenNv;
        }
        // hàm check số điện thoại dùng hay chưa
        public NhanVien CheckPhoneExist(string phoneNumber)
        {
            NhanVien nv = null;
            con.Open();
            string sql = "select * from NhanVien where SoDienThoai = @sdt";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("sdt", phoneNumber);

            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                nv = new NhanVien(dr["MaNhanVien"].ToString(), dr["HoTenNhanVien"].ToString(), dr["GioiTinh"].ToString(), dr["NgaySinh"].ToString(), dr["DiaChi"].ToString(), dr["SoDienThoai"].ToString(), dr["MatKhau"].ToString(), dr["PhanQuyen"].ToString());
                break;
            }
            con.Close();
            return nv;
        }
        // hàm thêm nhân viên vào cơ sở dữ liệu
        public bool AddNhanVien(NhanVien nv)
        {
            con.Open();
           
            string sql = "insert into NhanVien values(@manv,@tennv,@gt,@ns,@dc,@sdt,@mk,@role)";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("manv", nv.MaNv);
            cmd.Parameters.AddWithValue("tennv", nv.TenNv);
            cmd.Parameters.AddWithValue("gt", nv.Gioitinh);
            cmd.Parameters.AddWithValue("ns", nv.NgaySinh);
            cmd.Parameters.AddWithValue("dc", nv.DiaChi);
            cmd.Parameters.AddWithValue("sdt", nv.SoDienthoai);
            cmd.Parameters.AddWithValue("mk", nv.MatKhau);
            cmd.Parameters.AddWithValue("role", nv.Role);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }
        // hàm sửa thông tin nhân viên
        public bool UpdateNhanVien(NhanVien nv)
        {
            con.Open();
           
            string sql = "update NhanVien set HoTenNhanVien = @tennv ,GioiTinh = @gt, NgaySinh = @ns,DiaChi = @dc,SoDienThoai = @sdt,MatKhau=@mk,PhanQuyen = @role where MaNhanVien = @manv";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("manv", nv.MaNv);
            cmd.Parameters.AddWithValue("tennv", nv.TenNv);
            cmd.Parameters.AddWithValue("gt", nv.Gioitinh);
            cmd.Parameters.AddWithValue("ns", nv.NgaySinh);
            cmd.Parameters.AddWithValue("dc", nv.DiaChi);
            cmd.Parameters.AddWithValue("sdt", nv.SoDienthoai);
            cmd.Parameters.AddWithValue("mk", nv.MatKhau);
            cmd.Parameters.AddWithValue("role", nv.Role);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }
        // hàm xóa nhân viên
        public bool DeleteNhanVien(string manv)
        {
            con.Open();
          
            string sql = "delete from NhanVien where MaNhanVien = @manv";
            SqlCommand cmd = new SqlCommand(sql, con);
            cmd.Parameters.AddWithValue("manv", manv);
            cmd.ExecuteNonQuery();
            con.Close();
            return true;
        }
        // hàm tìm kiếm nhân viên theo mã hoặc theo tên
        public List<NhanVien> SearchNhanVien(NhanVien nvcantim)
        {
            List<NhanVien> list = new List<NhanVien>();
            con.Open();
            string sql = "select * from NhanVien where  HoTenNhanVien LIKE N'%" + nvcantim.TenNv +"%'";
            SqlCommand cmd = new SqlCommand(sql, con);
         
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                NhanVien nv = new NhanVien(dr["MaNhanVien"].ToString(), dr["HoTenNhanVien"].ToString(), dr["GioiTinh"].ToString(), dr["NgaySinh"].ToString(), dr["DiaChi"].ToString(), dr["SoDienThoai"].ToString(), dr["MatKhau"].ToString(), dr["PhanQuyen"].ToString());
                list.Add(nv);
            }
            con.Close();
            return list;
        }
    }
}
