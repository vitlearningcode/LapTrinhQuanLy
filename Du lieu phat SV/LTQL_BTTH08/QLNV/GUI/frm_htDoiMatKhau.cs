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
    public partial class frm_htDoiMatKhau : Form
    {
        public frm_htDoiMatKhau()
        {
            InitializeComponent();
        }

        private void frm_htDoiMatKhau_Load(object sender, EventArgs e)
        {
            txtTen.Text = frmMain.NguoiDung.STen;
            txtTen.Enabled = false;
            txtMatKhau.UseSystemPasswordChar = true;
            txtMatKhauMoi.UseSystemPasswordChar = true;
        }

        private void btnDoi_Click(object sender, EventArgs e)
        {
            // xác nhận mật khẩu cũ
            if (NguoiDung_BUS.LayNguoiDung(txtTen.Text, txtMatKhau.Text) == null)
            {
                MessageBox.Show("Tên hoặc mật khẩu không đúng.");
                return;
            }
            NguoiDung_DTO nd=new NguoiDung_DTO();
            nd.STen = txtTen.Text;
            nd.SMatKhau = txtMatKhau.Text;
            // ghi nhận mật khẩu mới
            if (NguoiDung_BUS.DoiMatKhau(nd, txtMatKhauMoi.Text) == false) 
            {
                MessageBox.Show("Không cập nhật được");
                return;
            }
            MessageBox.Show("Đã thay đổi mật khẩu.");
       
            
        }

        private void chkHienThi_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHienThi.Checked == true)
            {
                txtMatKhau.UseSystemPasswordChar = false;
                txtMatKhauMoi.UseSystemPasswordChar = false;
            }
            else
            {
                txtMatKhau.UseSystemPasswordChar = true;
                txtMatKhauMoi.UseSystemPasswordChar = true;
            }
        }
    }
}
