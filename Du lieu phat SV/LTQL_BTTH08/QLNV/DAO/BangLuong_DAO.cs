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
    public class BangLuong_DAO
    {
        static SqlConnection con;

        // Lấy thông tin nhân viên với hệ số lương đang hưởng (ghichu=1)
        public static List<BangLuong_DTO> LayBangLuongHienHanh()
        {
            string sTruyVan = "select n.manv, n.holot+' '+n.tennv as hoten, n.phai, n.ngaysinh, c.tencv, c.hsphucap, q.hsluong from nhanvien n, chucvu c, quatrinhluong q where n.macv=c.macv and n.manv=q.manv and q.ghichu=1";
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<BangLuong_DTO> lstBangLuong = new List<DTO.BangLuong_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                BangLuong_DTO bl = new BangLuong_DTO();
                bl.SMaNV = dt.Rows[i]["manv"].ToString();
                bl.SHoTen = dt.Rows[i]["hoten"].ToString();
                bl.SPhai = dt.Rows[i]["phai"].ToString();
                bl.DtNgaySinh = DateTime.Parse(dt.Rows[i]["ngaysinh"].ToString());
                bl.SChucVu = dt.Rows[i]["tencv"].ToString();
                bl.FHSPhuCap = float.Parse(dt.Rows[i]["hsphucap"].ToString());
                bl.FHSLuong = float.Parse(dt.Rows[i]["hsluong"].ToString());
                lstBangLuong.Add(bl);
            }
            DataProvider.DongKetNoi(con);
            return lstBangLuong;
        }
    }
}
