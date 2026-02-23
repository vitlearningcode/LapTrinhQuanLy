using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer;
using DataTransferObject;
namespace BusinessLogicLayer
{
    public class ChucVu_BUS
    {
        public static List <ChucVu_DTO> LayChucVu()
        {
            return ChucVu_DAO.LayChucVu();
        }
    }
}
