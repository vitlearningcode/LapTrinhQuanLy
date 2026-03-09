using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataTransferObject;

namespace DataAccessLayer
{
    public class QuaTrinhLuong_DAO
    {
        static SqlConnection con;

        //tìm quá trình lương theo khoảng thời gian
        public static List<QuaTrinhLuong_DTO> TimQuaTrinhLuong(DateTime tuNgay, DateTime denNgay)
        {
            //định dạng theo sqllll
            string sTuNgay = tuNgay.ToString("yyyy-MM-dd");
            string sDenNgay = denNgay.ToString("yyyy-MM-dd");

            string sTruyVan = string.Format(@"select * from QuaTrinhLuong 
                                                    where DtNgayBD >= '{0}' 
                                                      and DtNgayBD <= '{1}'", sTuNgay, sDenNgay);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);

            if (dt.Rows.Count == 0)
            {
                DataProvider.DongKetNoi(con);
                return null;
            }

            List<QuaTrinhLuong_DTO> lstQTL = new List<QuaTrinhLuong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                QuaTrinhLuong_DTO qt = new QuaTrinhLuong_DTO();
                qt.SManv = dt.Rows[i]["manv"].ToString();
                qt.DtNgayBD = DateTime.Parse(dt.Rows[i]["DtNgayBD"].ToString());
                qt.HSLuong = float.Parse(dt.Rows[i]["HSLuong"].ToString());
                qt.SGhichu = dt.Rows[i]["Ghichu"].ToString();
                lstQTL.Add(qt);

            }

            DataProvider.DongKetNoi(con);
            return lstQTL;
        }

        //tìm quá trình lương theo mã nhân viên
        public static List<QuaTrinhLuong_DTO> TimQuaTrinhLuong(string maNV)
        {
            string sTruyVan = string.Format(@"select * from QuaTrinhLuong 
                                                    where manv = '{0}'", maNV);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.DongKetNoi(con);
                return null;
            }
            List<QuaTrinhLuong_DTO> lstQTL = new List<QuaTrinhLuong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                QuaTrinhLuong_DTO qt = new QuaTrinhLuong_DTO();
                qt.SManv = dt.Rows[i]["manv"].ToString();
                qt.DtNgayBD = DateTime.Parse(dt.Rows[i]["DtNgayBD"].ToString());
                qt.HSLuong = float.Parse(dt.Rows[i]["HSLuong"].ToString());
                qt.SGhichu = dt.Rows[i]["Ghichu"].ToString();
                lstQTL.Add(qt);
            }
            DataProvider.DongKetNoi(con);
            return lstQTL;
        }

        //lấy tất cả quá trình lương
        public static List<QuaTrinhLuong_DTO> LayQuaTrinhLuong()
        {
            string sTruyVan = @"select * from QuaTrinhLuong";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                DataProvider.DongKetNoi(con);
                return null;
            }
            List<QuaTrinhLuong_DTO> lstQTL = new List<QuaTrinhLuong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                QuaTrinhLuong_DTO qt = new QuaTrinhLuong_DTO();
                qt.SManv = dt.Rows[i]["manv"].ToString();
                qt.DtNgayBD = DateTime.Parse(dt.Rows[i]["DtNgayBD"].ToString());
                qt.HSLuong = float.Parse(dt.Rows[i]["HSLuong"].ToString());
                qt.SGhichu = dt.Rows[i]["Ghichu"].ToString();
                lstQTL.Add(qt);
            }
            DataProvider.DongKetNoi(con);
            return lstQTL;
        }
    }
}
