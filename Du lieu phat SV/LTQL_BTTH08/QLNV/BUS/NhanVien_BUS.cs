using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class NhanVien_BUS
    {
        //Lấy DS nhân viên
        public static List<NhanVien_DTO> LayDSNhanVien() {
            return NhanVien_DAO.LayDSNhanVien();
        }

        //Lấy DS nhân viên theo họ và tên
        public static List<NhanVien_DTO> TimNhanVienTheoHoTen(string ho, string ten)
        {
            return NhanVien_DAO.TimNhanVienTheoHoTen(ho, ten);
        }

        //Lấy DS nhân viên theo tên
        public static List<NhanVien_DTO> TimNhanVienTheoTen(string ten)
        {
            return NhanVien_DAO.TimNhanVienTheoTen(ten);
        }

        //Lấy một nhân viên theo mã
        public static NhanVien_DTO TimNhanVienTheoMa(string ma) {
            return NhanVien_DAO.TimNhanVienTheoMa(ma);            
        }

        //Lấy một nhân viên theo mã chức vụ
        public static List<NhanVien_DTO> TimNhanVienTheoMaChucVu(string ma)
        {
            return NhanVien_DAO.LayDSNhanVienTheoMaChucVu(ma);
        }

        //Thêm 1 nhân viên
        public static bool ThemNhanVien(NhanVien_DTO nv) {
            return NhanVien_DAO.ThemNhanVien(nv);
        }

        //Sửa 1 nhân viên
        public static bool SuaNhanVien(NhanVien_DTO nv)
        {
            return NhanVien_DAO.SuaNhanVien(nv);
        }

        //Xóa 1 nhân viên
        public static bool XoaNhanVien(NhanVien_DTO nv)
        {
            return NhanVien_DAO.XoaNhanVien(nv);
        }
    }    
}
