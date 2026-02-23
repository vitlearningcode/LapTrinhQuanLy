using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace DataAccessLayer
{
    internal class DataProvider
    {
        public static SqlConnection MoKetNoi()
        {
            string s = @"Data Source=lib-sv319;Initial Catalog=QLNV;Integrated Security=True;TrustServerCertificate=True";
            SqlConnection ketnoi = new SqlConnection(s);
            ketnoi.Open();
            return ketnoi;
        }

        //trả về bảng dữ liệu
        public static DataTable TruyVanLayDuLieu(string sTruyVan, SqlConnection KetNoi)
        {
            SqlDataAdapter da = new SqlDataAdapter(sTruyVan, KetNoi);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        //truy vấn không trả về dữ liệu
        public static bool TruyVanKhongLayDuLieu(string sTruyVan, SqlConnection KetNoi)
        {
            try
            {
                SqlCommand cmd = new SqlCommand(sTruyVan, KetNoi);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }


        }
    }
}
