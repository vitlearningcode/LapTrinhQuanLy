using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using DataTransferObject;

namespace DataAccessLayer
{
    public class ChucVu_DAO
    {
        static SqlConnection con;
        public static List<ChucVu_DTO> LayChucVu()
        {
            string sTruyVan = "SELECT * FROM CHUCVU";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }

            List<ChucVu_DTO> lstChucVu = new List<ChucVu_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                ChucVu_DTO cv = new ChucVu_DTO();
                cv.SMaCV = dt.Rows[i]["MaChucVu"].ToString();
                cv.STenCV = dt.Rows[i]["TenChucVu"].ToString();
                cv.FHSPhuCap = float.Parse(dt.Rows[i]["HSPhuCap"].ToString());
                lstChucVu.Add(cv);
            }
            return lstChucVu;

        }
    }
}
