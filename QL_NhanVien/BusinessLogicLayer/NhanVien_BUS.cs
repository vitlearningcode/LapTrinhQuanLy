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

    }
}
