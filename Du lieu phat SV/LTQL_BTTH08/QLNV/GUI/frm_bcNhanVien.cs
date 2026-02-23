using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using BUS;
using DTO;

namespace GUI
{
    public partial class frm_bcNhanVien : Form
    {
        
        public frm_bcNhanVien()
        {
            InitializeComponent();
        }

        private void frm_bcNhanVien_Load(object sender, EventArgs e)
        {            
            //report viewer
            NhanVien_DTOBindingSource.DataSource = NhanVien_BUS.LayDSNhanVien(); 
            this.reportViewer1.RefreshReport();

            //combobox chức vụ
            List<ChucVu_DTO> lst = ChucVu_BUS.LayChucVu();
            cboChucVu.DataSource = lst;
            ChucVu_DTO d = new ChucVu_DTO();
            d.SMaCV  = "TC";
            d.STenCV = "Tất cả";
            lst.Insert(0, d);
            cboChucVu.ValueMember = "SMaCV";
            cboChucVu.DisplayMember = "STenCV";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ReportParameter[] parameter = new ReportParameter[2];
            ////khai báo một mảng tham số ở đây mình có 2 tham số
            //parameter[0] = new ReportParameter("thang");
            //parameter[0].Values.Add(txtthang.text);
            //parameter[1] = new ReportParameter("nam");
            //parameter[1].Values.Add(txtnam.text);
            //reportViewer1.LocalReport.SetParameters(parameter);
           
            
            string machucvu = cboChucVu.SelectedValue.ToString();
            
            //ReportParameter ts = new ReportParameter("macv", machucvu);
            //reportViewer1.LocalReport.SetParameters(ts);
            NhanVien_DTOBindingSource.DataSource = NhanVien_BUS.TimNhanVienTheoMaChucVu(machucvu);
            this.reportViewer1.RefreshReport();
        }
    }
}
