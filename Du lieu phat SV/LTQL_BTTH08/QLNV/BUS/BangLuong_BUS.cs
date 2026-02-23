using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;

namespace BUS
{
    public class BangLuong_BUS
    {
        public static List<BangLuong_DTO> LayBangLuongHienHanh() {
            return BangLuong_DAO.LayBangLuongHienHanh();
        }
    }
}
