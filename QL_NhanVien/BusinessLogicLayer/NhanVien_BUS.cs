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

        public static bool ThemNhanVien(NhanVien_DTO nv, out string mess)
        {
            if (nv.SMaNV.Length != 6)
            {
                mess = "Lưu ý MaNV phai 6 kí tự bạn ê!";
                return false;
            }
            else
                    if (KiemTraMaNV(nv.SMaNV))
            {
                mess = "Mã nhân viên đã tồn tại. Vui lòng chọn mã khác!";
                return false;
            }
            else

                    if (nv.SMaNV.Trim() == "" || nv.SHoLot.Trim() == "" || nv.STenNV.Trim() == "")
            {
                mess = "VUi lòng nhập đậy đủ ữ liệu bạn ê!";
                return false;
            }
            else
            {
                mess = "them thanh cong";
                return NhanVien_DAO.ThemNhanVien(nv);
            }
               
        }

        public static bool KiemTraMaNV(string maNV)
        {
            return NhanVien_DAO.KiemTraMaNV(maNV);
        }

        public static bool SuaNhanVien(NhanVien_DTO nv, out string mess)
        {
            if ( nv.SHoLot.Trim() == "" || nv.STenNV.Trim() == "")
            {
                mess = "VUi lòng nhập đậy đủ ữ liệu bạn ê!";
                return false;
            }
            else
            {
                mess = "sửa thanh cong";
                return NhanVien_DAO.SuaNhanVien(nv);
            }           
        }

        public static bool XoaNhanVien(string maNV)
        {
            return NhanVien_DAO.XoaNhanVien(maNV);
        }

        public static List<NhanVien_DTO> TimKiemNhanVien(string ten)
        {
            return NhanVien_DAO.TimKiemNhanVien(ten);
        }

        public static List<NhanVien_DTO> TimKiemNhanVienHoten(string ho, string ten)
        {
            return NhanVien_DAO.TimKiemNhanVienHoten(ho, ten);
        }
    }
}
