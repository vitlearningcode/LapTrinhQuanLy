using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DataAccessLayer;
using DataTransferObject;
using BusinessLogicLayer;
namespace PresentationLayer
{
    public partial class frm_dmNhanVien : Form
    {
        public frm_dmNhanVien()
        {
            InitializeComponent();
        }

        private void frm_dmNhanVien_Load(object sender, EventArgs e)
        {
            // dodorr dữ liệu vào cbo
            List<ChucVu_DTO> lstChucVu = ChucVu_BUS.LayChucVu();
                        cboChucVu.DataSource = lstChucVu;

            //displaymember là thuộc tính của cbo, nó sẽ hiển thị ên chức vụ thay vì mã chức dụ
            cboChucVu.DisplayMember = "STenCV";

            //valuemember là thuộc tính của cbo, nó sẽ lấy giá trị mã chức vụ để uu vào db
            cboChucVu.ValueMember = "SMaCV";

            // dodorooo dữ liệu vào dgv
            List<NhanVien_DTO> lstNhanVien = NhanVien_BUS.LayNhanVien();
            dgvNhanVien.DataSource = lstNhanVien;

        }
    }
}
