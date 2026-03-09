using BusinessLogicLayer;
using DataTransferObject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frm_dmQuaTrinhLuong : Form
    {
        public frm_dmQuaTrinhLuong()
        {
            InitializeComponent();
        }

        private void radDenHienTai_CheckedChanged(object sender, EventArgs e)
        {
            dtpDenNgay.Enabled = radDenNgay.Checked;
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            DateTime tuNgay = dtpTuNgay.Value;
            DateTime denNgay;

            if (radDenHienTai.Checked) denNgay = DateTime.Now;
            else denNgay = dtpDenNgay.Value;

            List<QuaTrinhLuong_DTO> lstQTL = QuaTrinhLuong_BUS.TimQuaTrinhLuong(tuNgay, denNgay);
            
            HienThiDuLieu(lstQTL);
        }

        public void HienThiDuLieu(List<QuaTrinhLuong_DTO> lstQTL)
        {
             
        
            if (lstQTL == null || lstQTL.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu");
                dgvQuaTrinhLuong.DataSource = null;
            }
            else
            {
                dgvQuaTrinhLuong.DataSource = lstQTL;

                dgvQuaTrinhLuong.Columns["SManv"].HeaderText = "Mã nhân viên";
                dgvQuaTrinhLuong.Columns["DtNgayBD"].HeaderText = "Ngày BĐ";
                dgvQuaTrinhLuong.Columns["HSLuong"].HeaderText = "Hệ số lương";
                dgvQuaTrinhLuong.Columns["SGhichu"].HeaderText = "Ghi chú";
            }

        }
        

        private void frm_dmQuaTrinhLuong_Load(object sender, EventArgs e)
        {
            List<QuaTrinhLuong_DTO> lstQTL = QuaTrinhLuong_BUS.LayQuaTrinhLuong();
            HienThiDuLieu(lstQTL);
        }
    }
}
