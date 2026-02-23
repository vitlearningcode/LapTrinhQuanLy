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
    public class NguoiDung_DAO
    {
        static SqlConnection con;
        
        // Lấy thông tin người dùng có tên đăng nhập và mật khẩu tương ứng, trả về null nếu không thấy
        public static NguoiDung_DTO LayNguoiDung(string ten, string matkhau)
        {
            string sTruyVan = string.Format(@"select * from nguoidung where ten=N'{0}' and matkhau='{1}'", ten, matkhau);
            con = DataProvider.MoKetNoi();
            DataTable dt = DataProvider.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            NguoiDung_DTO nd = new NguoiDung_DTO();
            nd.STen  = dt.Rows[0]["ten"].ToString();
            nd.SMatKhau = dt.Rows[0]["matkhau"].ToString();
            nd.IQuyen = int.Parse(dt.Rows[0]["quyen"].ToString());
          
            DataProvider.DongKetNoi(con);
            return nd;
        }

        public static bool CapNhatNguoiDung(NguoiDung_DTO nd) {
            string sql = string.Format(@"update nguoidung set matkhau='{0}' where ten='{1}'", nd.SMatKhau, nd.STen);
            con = DataProvider.MoKetNoi();
            bool kq = DataProvider.TruyVanKhongLayDuLieu(sql, con);
            return kq;
        }
    }
}
