using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class frm_nvQuaTrinhLuong : Form
    {
        public frm_nvQuaTrinhLuong()
        {
            InitializeComponent();
        }

        private void frm_nvQuaTrinhLuong_Load(object sender, EventArgs e)
        {
            HienThiQuaTrinhLuongLenDataGrid();
            KhoiTaoVungTimKiem();
            
        }
        
        private void HienThiQuaTrinhLuongLenDataGrid() {
            List<QuaTrinhLuong_DTO> lstQTLuong = QuaTrinhLuong_BUS.LayQuaTrinhLuong();
            dgQTLuong.DataSource = lstQTLuong;
        }
        private void KhoiTaoVungTimKiem() {
            radChonNgay.Checked = false;
            dtpDenNgay.Enabled = false;
        }

        private void dgQTLuong_Click(object sender, EventArgs e)
        {

        }
                
        private void txtTim_Click(object sender, EventArgs e)
        {
            DateTime ngaybd = DateTime.Parse(dtpTuNgay.Text);            
            DateTime ngaykt=DateTime.Now;
            if(radChonNgay.Checked==true)
                ngaykt=DateTime.ParseExact(dtpDenNgay.Text ,"dd/MM/yyyy",null);
            
            List<QuaTrinhLuong_DTO> lstQT = QuaTrinhLuong_BUS.LayQuaTrinhLuongTheoNgay(ngaybd, ngaykt);
            dgQTLuong.DataSource = lstQT;
        }

        private void radChonNgay_Click(object sender, EventArgs e)
        {
            dtpDenNgay.Enabled = true;
        }

        private void radNgayHienTai_Click(object sender, EventArgs e)
        {
            KhoiTaoVungTimKiem();
        }

        
    }
}
