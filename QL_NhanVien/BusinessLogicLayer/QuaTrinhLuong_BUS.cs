using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using DataTransferObject;
namespace BusinessLogicLayer
{
    public class QuaTrinhLuong_BUS
    {
        //tìm quá trình lương theo khoảng thời gian
        public static List<QuaTrinhLuong_DTO> TimQuaTrinhLuong(DateTime tuNgay, DateTime denNgay)
        {
            return QuaTrinhLuong_DAO.TimQuaTrinhLuong(tuNgay, denNgay);
        }

        //tìm quá trình lương theo mã nhân viên
        public static List<QuaTrinhLuong_DTO> TimQuaTrinhLuong(string maNV)
        {
            return QuaTrinhLuong_DAO.TimQuaTrinhLuong(maNV);
        }

        //lấy tất cả quá trình lương
        public static List<QuaTrinhLuong_DTO> LayQuaTrinhLuong()
        {
            return QuaTrinhLuong_DAO.TimQuaTrinhLuong(DateTime.MinValue, DateTime.MaxValue);
        }
    }
}
