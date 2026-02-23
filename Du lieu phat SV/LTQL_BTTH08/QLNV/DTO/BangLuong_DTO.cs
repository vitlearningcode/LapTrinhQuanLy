using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BangLuong_DTO
    {
        private string sMaNV;

        public string SMaNV
        {
            get { return sMaNV; }
            set { sMaNV = value; }
        }
        private string sHoTen;

        public string SHoTen
        {
            get { return sHoTen; }
            set { sHoTen = value; }
        }
        private string sPhai;

        public string SPhai
        {
            get { return sPhai; }
            set { sPhai = value; }
        }
        private DateTime dtNgaySinh;

        public DateTime DtNgaySinh
        {
            get { return dtNgaySinh; }
            set { dtNgaySinh = value; }
        }
        private string sChucVu;

        public string SChucVu
        {
            get { return sChucVu; }
            set { sChucVu = value; }
        }
        private float fHSPhuCap;

        public float FHSPhuCap
        {
            get { return fHSPhuCap; }
            set { fHSPhuCap = value; }
        }

       
        private float fHSLuong;

        public float FHSLuong
        {
            get { return fHSLuong; }
            set { fHSLuong = value; }
        }
    }
}
