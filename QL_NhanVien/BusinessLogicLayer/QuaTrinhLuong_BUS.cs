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
        public static List<QuaTrinhLuong_DTO> TimQuaTrinhLuong(DateTime tuNgay, DateTime denNgay)
        {
            return QuaTrinhLuong_DAO.TimQuaTrinhLuong(tuNgay, denNgay);
        }
    }
}
