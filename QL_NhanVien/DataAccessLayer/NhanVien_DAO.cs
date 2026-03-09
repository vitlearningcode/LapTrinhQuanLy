using System;
using System.Collections.Generic;
using System.Text;
using DataTransferObject;
using System.Data.SqlClient;
using System.Data;
namespace DataAccessLayer
{
    public class NhanVien_DAO
    {
        static SqlConnection con;

        public static List<NhanVien_DTO> LayNhanVien()
        {
            string sTruyVan = @"SELECT nv.manv, nv.holot, nv.tennv, nv.phai, nv.ngaysinh, nv.macv, cv.tencv 
                                FROM nhanvien nv, chucvu cv 
                                WHERE nv.macv = cv.macv";
             
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);

            if (dt.Rows.Count == 0) 
                return null;

            List<NhanVien_DTO> lstNhanVien = new List<NhanVien_DTO>();
            for ( int i = 0; i< dt.Rows.Count; i++)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.SMaNV = dt.Rows[i]["manv"].ToString();
                nv.SHoLot = dt.Rows[i]["holot"].ToString();
                nv.STenNV = dt.Rows[i]["tennv"].ToString();
                nv.SPhai = dt.Rows[i]["phai"].ToString();
                nv.DtNgaySinh = DateTime.Parse(dt.Rows[i]["ngaysinh"].ToString());
                nv.SMaCV = dt.Rows[i]["macv"].ToString();
                nv.STenCV = dt.Rows[i]["tencv"].ToString();
                lstNhanVien.Add(nv);
            }
            return lstNhanVien;
        }

        public static bool ThemNhanVien(NhanVien_DTO nv)
        {
            string sTruyVan = string.Format("insert into nhanvien(manv, holot, tennv, phai, ngaysinh, macv) VALUES('{0}', N'{1}', N'{2}', N'{3}', '{4}', '{5}')",
                                                                                                                nv.SMaNV, nv.SHoLot, nv.STenNV, nv.SPhai, nv.DtNgaySinh.ToString("yyyy-MM-dd"), nv.SMaCV);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static bool KiemTraMaNV(string maNV)
        {
            string sTruyVan = string.Format("select manv from nhanvien where manv='{0}'", maNV);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return dt.Rows.Count > 0; // Nếu có dữ liệu trả về thì cái mã này đã có ný gòi
        }

        public static bool SuaNhanVien(NhanVien_DTO nv)
        {
            string sTruyVan = string.Format("update nhanvien SET holot=N'{0}', tennv=N'{1}', phai=N'{2}', ngaysinh='{3}', macv='{4}' WHERE manv='{5}'",
                                                                    nv.SHoLot, nv.STenNV, nv.SPhai, nv.DtNgaySinh.ToString("yyyy-MM-dd"), nv.SMaCV, nv.SMaNV);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }



        public static bool XoaNhanVien(string maNV)
        {
            string sTruyVan = string.Format("delete from nhanvien WHERE manv='{0}'", maNV);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sTruyVan, con);
            DataProvider.DongKetNoi(con);
            return kq;
        }

        public static List<NhanVien_DTO> TimKiemNhanVien(string ten)
        {
            string sTruyVan = string.Format(@"select * from nhanvien where tennv like '%{0}%'", ten);

            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);

            if (dt.Rows.Count == 0) return null;

            List<NhanVien_DTO> lstNhanVien = new List<NhanVien_DTO>();
            for (int i  = 0; i <dt.Rows.Count; i++)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.SMaNV= dt.Rows[i]["manv"].ToString();
                nv.SHoLot = dt.Rows[i]["holot"].ToString();
                nv.STenNV = dt.Rows[i]["tennv"].ToString();
                                nv.SPhai = dt.Rows[i]["phai"].ToString();
                nv.DtNgaySinh = DateTime.Parse(dt.Rows[i]["ngaysinh"].ToString());
                nv.SMaCV = dt.Rows[i]["macv"].ToString();
                lstNhanVien.Add(nv);
            }

            DataProvider.DongKetNoi(con);
            return lstNhanVien;

        }
        public static List<NhanVien_DTO> TimKiemNhanVienHoten(string ho, string ten)
        {
            string sTruyVan = string.Format(@"select nv.manv, nv.holot, nv.tennv, nv.phai, nv.ngaysinh, nv.macv, cv.tencv 
                                      FROM nhanvien nv, chucvu cv 
                                      where nv.macv = cv.macv 
                                      and nv.holot LIKE N'%{0}%' 
                                      and nv.tennv LIKE N'%{1}%'", ho, ten);

            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);

            if (dt.Rows.Count == 0) return null;

            List<NhanVien_DTO> lstNhanVien = new List<NhanVien_DTO>();
            for (int i  = 0; i <dt.Rows.Count; i++)
            {
                NhanVien_DTO nv = new NhanVien_DTO();
                nv.SMaNV= dt.Rows[i]["manv"].ToString();
                nv.SHoLot = dt.Rows[i]["holot"].ToString();
                nv.STenNV = dt.Rows[i]["tennv"].ToString();
                nv.SPhai = dt.Rows[i]["phai"].ToString();
                nv.DtNgaySinh = DateTime.Parse(dt.Rows[i]["ngaysinh"].ToString());
                nv.SMaCV = dt.Rows[i]["macv"].ToString();
                lstNhanVien.Add(nv);
            }

            DataProvider.DongKetNoi(con);
            return lstNhanVien;

        }
    }
}
