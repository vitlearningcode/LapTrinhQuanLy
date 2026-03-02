using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;
using DataTransferObject;

namespace BusinessLogicLayer
{
    public class NhanVien_BUS
    {
        public static List<NhanVien_DTO> LayNhanVien()
        {
            return NhanVien_DAO.LayNhanVien();
        }

        public static bool ThemNhanVien(NhanVien_DTO nv)
        {
            return NhanVien_DAO.ThemNhanVien(nv);
        }

        public static bool SuaNhanVien(NhanVien_DTO nv)
        {
            return NhanVien_DAO.SuaNhanVien(nv);
        }

        public static bool XoaNhanVien(string maNV)
        {
            return NhanVien_DAO.XoaNhanVien(maNV);
        }

    }
}
