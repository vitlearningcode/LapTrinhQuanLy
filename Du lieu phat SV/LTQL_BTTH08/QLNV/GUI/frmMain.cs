using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using BUS;
using DTO;

namespace GUI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        public bool bDangNhap;
        public static NguoiDung_DTO NguoiDung;
        frm_dmChucVu fCV;
        frm_dmNhanVien fNV;
        frm_nvQuaTrinhLuong fQTL;
        frm_bcNhanVien fbcNV;
        frm_bcBangLuong fbcBL;
        frm_htDangNhap fDN;
        frm_htDoiMatKhau fDMK;
        

        private void i_dmChucVu_Click(object sender, EventArgs e)
        {
            if (fCV == null || fNV.IsDisposed)
            {
                fCV = new frm_dmChucVu();
                fCV.MdiParent = this;
                fCV.Show();
            }
        }

        private void i_dmNhanVien_Click(object sender, EventArgs e)
        {
            if (fNV == null || fNV.IsDisposed)
            {
                fNV = new frm_dmNhanVien();
                fNV.MdiParent = this;
                fNV.Show();
            }
        }

        private void i_nvQuaTrinhLuong_Click(object sender, EventArgs e)
        {
            if (fQTL == null || fQTL.IsDisposed)
            {
                fQTL = new frm_nvQuaTrinhLuong();
                fQTL.MdiParent = this;
                fQTL.Show();
            }
        }

        private void i_bcNhanVien_Click(object sender, EventArgs e)
        {
            if (fbcNV == null || fbcNV.IsDisposed)
            {
                fbcNV = new frm_bcNhanVien();
                fbcNV.MdiParent = this;
                fbcNV.Show();
            }
        }

        private void i_bcBangLuong_Click(object sender, EventArgs e)
        {
            if (fbcBL == null || fbcBL.IsDisposed)
            {
                fbcBL = new  frm_bcBangLuong();
                fbcBL.MdiParent = this;
                fbcBL.Show();
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            
            HienThiMenu(); 
            
        }
        private void HienThiMenu() {
            i_htDangNhap.Enabled = !bDangNhap;
            i_htDangXuat.Enabled = bDangNhap;
            
            if (bDangNhap == true)
            {
                // Hiển thị trạng thái đăng nhập
                sttTTNguoiDung.Text = "Người dùng: " + NguoiDung.STen ;
                sttTTThoiGian.Text = "Thời điểm đăng nhập: " + DateTime.Now ;
                // Hiển thị menu theo quyền, ví dụ: 
                //  1. quantri: sử dụng tất cả menu
                //  2. nhanvien: không sử dụng các menu: Danh mục, Nghiệp vụ       
                int iQuyen;
                if (NguoiDung == null)
                {
                    iQuyen = 0;
                }
                else
                {
                    iQuyen = int.Parse(NguoiDung.IQuyen.ToString());
                }
                switch (iQuyen)
                {
                    case 1:
                        i_dmChucVu.Enabled = true;
                        i_dmNhanVien.Enabled = true;
                        i_nvBangLuong.Enabled = true;
                        i_nvQuaTrinhLuong.Enabled = true;
                        i_bcBangLuong.Enabled = true;
                        i_bcNhanVien.Enabled = true;
                        i_htDoiMatKhau.Enabled = true;
                        
                        break;
                    case 2:
                        i_dmChucVu.Enabled = false;
                        i_dmNhanVien.Enabled = true;
                        i_nvBangLuong.Enabled = false;
                        i_nvQuaTrinhLuong.Enabled = false;
                        i_bcBangLuong.Enabled = true;
                        i_bcNhanVien.Enabled = true;
                        i_htDoiMatKhau.Enabled = true;
                       
                        break;
                    default:

                        break;
                }
            }
            else
            {
                sttTTNguoiDung.Text = "Chưa đăng nhập";
                sttTTThoiGian.Text = "";
                
                i_dmChucVu.Enabled = false;
                i_dmNhanVien.Enabled = false;
                i_nvBangLuong.Enabled = false;
                i_nvQuaTrinhLuong.Enabled = false;
                i_bcBangLuong.Enabled = false;
                i_bcNhanVien.Enabled = false;
                i_htDoiMatKhau.Enabled = false;
            
            }
            
        }

        private void i_htDangNhap_Click(object sender, EventArgs e)
        {        
            fDN = new frm_htDangNhap();
            if (fDN.ShowDialog() == DialogResult.OK)
            {
                string sTen = fDN.txtTen.Text;
                string sMatKhau = fDN.txtMatKhau.Text;

                NguoiDung = new NguoiDung_DTO();
                NguoiDung = NguoiDung_BUS.LayNguoiDung(sTen, sMatKhau);
                if (NguoiDung != null)
                {
                    bDangNhap = true;
                }
               
            }
            else
            {
                bDangNhap = false;
            }
            HienThiMenu();
        }
        
        private void i_htDangXuat_Click(object sender, EventArgs e)
        {
            // Đóng tất cả form đang mở
            foreach (Form f in this.MdiChildren) {
                if (!f.IsDisposed)
                    f.Close();
            }
            // Đăng xuất & thiết lập lại menu
            bDangNhap = false;
            HienThiMenu();
        }

        private void i_htDoiMatKhau_Click(object sender, EventArgs e)
        {
            if (fDMK == null || fDMK.IsDisposed)
            {
                fDMK = new frm_htDoiMatKhau();
                fDMK.MdiParent = this;
                fDMK.Show();
            }
        }

 
    }
}
