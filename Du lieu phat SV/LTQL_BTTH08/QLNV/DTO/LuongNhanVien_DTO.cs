using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LuongNhanVien_DTO
    {
        private string sMaNV;

        public string SMaNV
        {
            get { return sMaNV; }
            set { sMaNV = value; }
        }
        private DateTime dtNgayBD;

        public DateTime DtNgayBD
        {
            get { return dtNgayBD; }
            set { dtNgayBD = value; }
        }
        private float fHSLuong;

        public float FHSLuong
        {
            get { return fHSLuong; }
            set { fHSLuong = value; }
        }
        private bool bGhiChu;

        public bool BGhiChu
        {
            get { return bGhiChu; }
            set { bGhiChu = value; }
        }
        private ChucVu_DTO cvChucVu;

        public ChucVu_DTO CvChucVu
        {
            get { return cvChucVu; }
            set { cvChucVu = value; }
        }
        private NhanVien_DTO nvNhanVien;

        public NhanVien_DTO NvNhanVien
        {
            get { return nvNhanVien; }
            set { nvNhanVien = value; }
        }
    }
}
