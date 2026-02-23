using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class QuaTrinhLuong_BUS
    {
        //Lấy tất cả quá trình lương
        public static List<QuaTrinhLuong_DTO> LayQuaTrinhLuong()
        {
            return QuaTrinhLuong_DAO.LayQuaTrinhLuong();
        }
        //Lấy quá trình lương của một nhân viên
        public static List<QuaTrinhLuong_DTO> LayQuaTrinhLuongNhanVien(string ma)
        {
            return QuaTrinhLuong_DAO.LayQuaTrinhLuongNhanVien(ma);
        }
        //Lấy quá trình lương trong khoảng thời gian
        public static List<QuaTrinhLuong_DTO> LayQuaTrinhLuongTheoNgay(DateTime ngaybatdau, DateTime ngayketthuc)
        {
            return QuaTrinhLuong_DAO.LayQuaTrinhLuongTheoNgay(ngaybatdau, ngayketthuc);
        }
    }
}
