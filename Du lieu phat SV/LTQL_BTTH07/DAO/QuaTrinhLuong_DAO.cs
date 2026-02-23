using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTO;


namespace DAO
{
    public class QuaTrinhLuong_DAO
    {
        static SqlConnection con;

        // Lấy tất cả quá trình lương
        public static List<QuaTrinhLuong_DTO> LayQuaTrinhLuong()
        {
            string sTruyVan = "select q.*,n.* from quatrinhluong q,nhanvien n where q.manv=n.manv";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<QuaTrinhLuong_DTO> lstQTLuong = new List<QuaTrinhLuong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                QuaTrinhLuong_DTO qtl = new QuaTrinhLuong_DTO();
                qtl.SMaNV = dt.Rows[i]["manv"].ToString();
                qtl.DtNgayBD = DateTime.Parse(dt.Rows[i]["ngaybd"].ToString());
                qtl.FHSLuong = float.Parse(dt.Rows[i]["hsluong"].ToString());
                qtl.BGhiChu = bool.Parse(dt.Rows[i]["ghichu"].ToString());
                qtl.NvNhanVien = new NhanVien_DTO();
                qtl.NvNhanVien.SHoLot = dt.Rows[i]["holot"].ToString();
                qtl.NvNhanVien.STen  = dt.Rows[i]["tennv"].ToString();
                lstQTLuong.Add(qtl);
            }
            DataProvider.DongKetNoi(con);
            return lstQTLuong;
        }

        // Lấy quá trình lương của một nhân viên có mã ma
        public static List<QuaTrinhLuong_DTO> LayQuaTrinhLuongNhanVien(string ma)
        {
            string sTruyVan = string.Format(@"select * from quatrinhluong where manv=N'{0}'", ma);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<QuaTrinhLuong_DTO> lstQTLuong = new List<QuaTrinhLuong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                QuaTrinhLuong_DTO qtl = new QuaTrinhLuong_DTO();
                qtl.SMaNV = dt.Rows[i]["manv"].ToString();
                qtl.DtNgayBD = DateTime.Parse(dt.Rows[i]["ngaybd"].ToString());
                qtl.FHSLuong = float.Parse(dt.Rows[i]["hsluong"].ToString());
                qtl.BGhiChu = bool.Parse(dt.Rows[i]["ghichu"].ToString());
                lstQTLuong.Add(qtl);
            }
            DataProvider.DongKetNoi(con);
            return lstQTLuong;
        }
        // Lấy quá trình lương theo khoảng thời gian
        public static List<QuaTrinhLuong_DTO> LayQuaTrinhLuongTheoNgay(DateTime ngbd, DateTime ngkt)
        {
            string sTruyVan = string.Format(@"select * from quatrinhluong where ngaybd between '{0}' and '{1}'", ngbd, ngkt);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<QuaTrinhLuong_DTO> lstQTLuong = new List<QuaTrinhLuong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                QuaTrinhLuong_DTO qtl = new QuaTrinhLuong_DTO();
                qtl.SMaNV = dt.Rows[i]["manv"].ToString();
                qtl.DtNgayBD = DateTime.Parse(dt.Rows[i]["ngaybd"].ToString());
                qtl.FHSLuong = float.Parse(dt.Rows[i]["hsluong"].ToString());
                qtl.BGhiChu = bool.Parse(dt.Rows[i]["ghichu"].ToString());
                lstQTLuong.Add(qtl);
            }
            DataProvider.DongKetNoi(con);
            return lstQTLuong;
        }
    }
}
