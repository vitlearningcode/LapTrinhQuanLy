using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DTO;
using BUS;

namespace GUI
{
    public partial class frm_dmNhanVien : Form
    {
        public frm_dmNhanVien()
        {
            InitializeComponent();
        }

        private void frm_dmNhanVien_Load(object sender, EventArgs e)
        {
            // Combobox chức vụ
            HienThiChucVuLenCombobox();

            // Datagrid nhân viên
            HienThiDSNhanVienLenDatagrid();
        }

        private void HienThiChucVuLenCombobox() {
            List<ChucVu_DTO> lstChucVu = ChucVu_BUS.LayChucVu();
            cboChucVu.DataSource = lstChucVu;
            cboChucVu.DisplayMember = "STenCV";
            cboChucVu.ValueMember = "SMaCV";
        }

        private void HienThiDSNhanVienLenDatagrid() {
            
            //dg_col_SMaCV.DataSource = ChucVu_BUS.LayChucVu();
            //dg_col_SMaCV.DisplayMember = "STenCV";
            //dg_col_SMaCV.ValueMember = "SMaCV";

 
            List<NhanVien_DTO> lstNhanVien = NhanVien_BUS.LayDSNhanVien();
            dgDSNhanVien.DataSource = lstNhanVien;
            //// thứ tự các cột
            //dgDSNhanVien.Columns[0].DataPropertyName = "SMaNV";
            //dgDSNhanVien.Columns[1].DataPropertyName = "SHoLot";
            //dgDSNhanVien.Columns[2].DataPropertyName = "STen";
            //dgDSNhanVien.Columns[3].DataPropertyName = "tencv";
            //dgDSNhanVien.Columns[4].DataPropertyName = "SPhai";
            //dgDSNhanVien.Columns[5].DataPropertyName = "DtNgaySinh";
          

            dgDSNhanVien.Columns["SMaNV"].HeaderText = "Mã số";
            dgDSNhanVien.Columns["SHoLot"].HeaderText = "Họ và lót";
            dgDSNhanVien.Columns["STen"].HeaderText = "Tên";
            dgDSNhanVien.Columns["SPhai"].HeaderText = "Phái";
            dgDSNhanVien.Columns["DtNgaySinh"].HeaderText = "Ngày sinh";
            dgDSNhanVien.Columns["SMaCV"].HeaderText = "Mã CV";
            dgDSNhanVien.Columns["SMaNV"].Width = 60;
            dgDSNhanVien.Columns["SHoLot"].Width = 120;
            dgDSNhanVien.Columns["STen"].Width = 50;
            dgDSNhanVien.Columns["SPhai"].Width = 50;
            dgDSNhanVien.Columns["DtNgaySinh"].Width = 60;
            dgDSNhanVien.Columns["SMaCV"].Width = 30;
            
            // mới bổ sung thêm
            // Hiển thị tên chức vụ tương ứng
            string tenchucvu;
            DataGridViewColumn clTenCV = new DataGridViewColumn();
            DataGridViewCell cell = new DataGridViewTextBoxCell();
            clTenCV.CellTemplate = cell;
            clTenCV.Name = "tencv";
            clTenCV.HeaderText = "Chức vụ";
            clTenCV.Width = 150;
            dgDSNhanVien.Columns.Add(clTenCV);
            for (int i = 0; i < dgDSNhanVien.RowCount; i++)
            {
                tenchucvu= ChucVu_BUS.LayTenChucVuTheoMa(dgDSNhanVien.Rows[i].Cells["SMaCV"].Value.ToString());
                dgDSNhanVien.Rows[i].Cells["tencv"].Value = tenchucvu; 
            }
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {            
            // Kiểm tra dữ liệu có bị bỏ trống 
            if(txtMaNV.Text=="" || txtHoLot.Text=="" || txtTen.Text==""){
            MessageBox.Show("Vui lòng nhập đầy đủ dữ liệu!");
                return;
            }
            // Kiểm tra mã nhân viên có độ dài chuỗi hợp lệ hay không
            if (txtMaNV.Text.Length > 5)
            {
                MessageBox.Show("Mã nhân viên tối đa 5 ký tự!");
                return;
            }
            // Kiểm tra mã nhân viên có bị trùng không
            if (NhanVien_BUS.TimNhanVienTheoMa(txtMaNV.Text) != null)
            {
                MessageBox.Show("Mã nhân viên đã tồn tại!");
                return;
            }

            NhanVien_DTO nv = new NhanVien_DTO();
            nv.SMaNV = txtMaNV.Text;
            nv.SHoLot = txtHoLot.Text;
            nv.STen = txtTen.Text;
            if (radNam.Checked == true) {
                nv.SPhai = "Nam";
            } else {
                nv.SPhai = "Nữ";
            }
            nv.DtNgaySinh = DateTime.Parse(dtpNgaySinh.Text);
            nv.SMaCV = cboChucVu.SelectedValue.ToString();

            if (NhanVien_BUS.ThemNhanVien(nv) == false){
                MessageBox.Show("Không thêm được.");
                return;
            }
            
            HienThiDSNhanVienLenDatagrid();
            MessageBox.Show("Đã thêm nhân viên.");                 
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            // kiểm tra mã có tồn tại
            if (txtMaNV.Text == "" || NhanVien_BUS.TimNhanVienTheoMa(txtMaNV.Text)==null)
            {
                MessageBox.Show("Vui lòng chọn mã nhân viên!");
                return;
            }
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.SMaNV = txtMaNV.Text;
            nv.SHoLot = txtHoLot.Text;
            nv.STen = txtTen.Text;
            if (radNam.Checked == true)
            {
                nv.SPhai = "Nam";
            }
            else
            {
                nv.SPhai = "Nữ";
            }
            nv.DtNgaySinh = DateTime.Parse(dtpNgaySinh.Text);
            nv.SMaCV = cboChucVu.SelectedValue.ToString();

            if (NhanVien_BUS.SuaNhanVien(nv) == true)
            {
                HienThiDSNhanVienLenDatagrid();
                MessageBox.Show("Đã cập nhật thông tin nhân viên.");
            }
            else
            {
                MessageBox.Show("Không cập nhật được.");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // kiểm tra mã có tồn tại
            if (txtMaNV.Text == "" || NhanVien_BUS.TimNhanVienTheoMa(txtMaNV.Text) == null)
            {
                MessageBox.Show("Vui lòng chọn mã nhân viên!");
                return;
            }
            NhanVien_DTO nv = new NhanVien_DTO();
            nv.SMaNV = txtMaNV.Text;
            nv.SHoLot = txtHoLot.Text;
            nv.STen = txtTen.Text;
            if (radNam.Checked == true)
            {
                nv.SPhai = "Nam";
            }
            else
            {
                nv.SPhai = "Nữ";
            }
            nv.DtNgaySinh = DateTime.Parse(dtpNgaySinh.Text);
            nv.SMaCV = cboChucVu.SelectedValue.ToString();

            if (NhanVien_BUS.XoaNhanVien(nv) == true)
            {
                HienThiDSNhanVienLenDatagrid();
                MessageBox.Show("Đã xóa nhân viên.");
            }
            else
            {
                MessageBox.Show("Không xóa được.");
            }
        }

        private void dgDSNhanVien_Click(object sender, EventArgs e)
        {
            DataGridViewRow r = new DataGridViewRow();
            r = dgDSNhanVien.SelectedRows[0];
            txtMaNV.Text = r.Cells["SMaNV"].Value.ToString();
            txtHoLot.Text = r.Cells["SHoLot"].Value.ToString();
            txtTen.Text = r.Cells["STen"].Value.ToString();
            if (r.Cells["SPhai"].Value.ToString() == "Nam")
            {
                radNam.Checked = true;
            }
            else {
                radNu.Checked = true;
            }
            dtpNgaySinh.Text = r.Cells["DtNgaySinh"].Value.ToString();
            cboChucVu.SelectedValue = r.Cells["SMaCV"].Value;
        }

 

        private void btnTim_Click(object sender, EventArgs e)
        {
            string ho = txtTimHo.Text;
            string ten = txtTimTen.Text;
            List<NhanVien_DTO> lstnv = NhanVien_BUS.TimNhanVienTheoHoTen(ho, ten);
            if (lstnv == null) {
                MessageBox.Show("Không tìm thấy!");
                return;
            }
            dgDSNhanVien.DataSource = lstnv;
        }

        private void txtTimTen_Click(object sender, EventArgs e)
        {
            txtTimTen.Text = "";
        }

        private void txtTimHo_Click(object sender, EventArgs e)
        {
            txtTimHo.Text = "";
        }

 


    }
}

