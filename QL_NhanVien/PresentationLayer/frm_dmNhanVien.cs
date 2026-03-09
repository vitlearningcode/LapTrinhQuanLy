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
            this.reset();
            // dodorr dữ liệu vào cbo
            List<ChucVu_DTO> lstChucVu = ChucVu_BUS.LayChucVu();
            cboChucVu.DataSource = lstChucVu;

            //displaymember là thuộc tính ủa cbo, nóẽ hiển thị ên chức vụ thay vì mã chức dụ
            cboChucVu.DisplayMember = "STenCV";

            //valuemember là thuộc tính của cbo, nó sẽ ấy giá trị mã chức vụ để uu vào db
            cboChucVu.ValueMember = "SMaCV";

            HienThiDSNhanVien();

            // dodorooo dữ liệu vào dgv
            List<NhanVien_DTO> lstNhanVien = NhanVien_BUS.LayNhanVien();
            dgvNhanVien.DataSource = lstNhanVien;

        }

        //  1 là Thêm, 2 là Sủaa
        int flag = 0;

        public void reset()
        {
            flag = 0; // Hủy thao tác thêm/sửa
            txtMaNV.Clear();
            txtHoLot.Clear();
            txtTen.Clear();

            this.txtMaNV.Enabled = false;
            this.txtHoLot.Enabled = false;
            this.txtTen.Enabled = false;
            this.cboChucVu.Enabled = false;
            this.radNam.Enabled = false;
            this.radNu.Enabled = false;
            this.dtpNgaySinh.Enabled = false;
        }

        public void onEdit()
        {
            this.txtMaNV.Enabled = true;
            this.txtHoLot.Enabled = true;
            this.txtTen.Enabled = true;
            this.cboChucVu.Enabled = true;
            this.radNam.Enabled = true;
            this.radNu.Enabled = true;
            this.dtpNgaySinh.Enabled = true;
        }

        private void HienThiDSNhanVien()
        {
            List<NhanVien_DTO> lstNhanVien = NhanVien_BUS.LayNhanVien();
            dgvNhanVien.DataSource = lstNhanVien;

            // Đổi tên cột hiển thị
            dgvNhanVien.Columns["SMaNV"].HeaderText = "Mã nhân viên";
            dgvNhanVien.Columns["SHoLot"].HeaderText = "Họ lót";
            dgvNhanVien.Columns["STenNV"].HeaderText = "Tên nhân viên";
            dgvNhanVien.Columns["SPhai"].HeaderText = "Giới tính";
            dgvNhanVien.Columns["DtNgaySinh"].HeaderText = "Ngày sinh";
            dgvNhanVien.Columns["SMaCV"].HeaderText = "Mã chức vụ";
            dgvNhanVien.Columns["STenCV"].HeaderText = "Tên chức vụ";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.onEdit();
            flag = 1;
            txtMaNV.Clear();
            txtHoLot.Clear();
            txtTen.Clear();
            dtpNgaySinh.Value = DateTime.Now;
            radNam.Checked = true;
            txtMaNV.Focus();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            this.onEdit();
            flag = 2;
            this.txtMaNV.Enabled = false;
            txtHoLot.Focus();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {

            NhanVien_DTO nv = new NhanVien_DTO();
            nv.SMaNV = txtMaNV.Text;
            nv.SHoLot = txtHoLot.Text;
            nv.STenNV = txtTen.Text;
            nv.SPhai = radNam.Checked ? "Nam" : "Nữ";
            nv.DtNgaySinh = dtpNgaySinh.Value;
            nv.SMaCV = cboChucVu.SelectedValue.ToString();

            string mess = "";
            if (flag == 1)
            {

                NhanVien_BUS.ThemNhanVien(nv, out mess);

                MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                HienThiDSNhanVien();
            }
            else if (flag == 2)
            {
                if (NhanVien_BUS.SuaNhanVien(nv, out mess))
                {
                    MessageBox.Show(mess, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDSNhanVien();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                txtMaNV.Enabled = true;
            }
            flag = 0;
            this.reset();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn xóa nhân viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string maNV = txtMaNV.Text;
                if (NhanVien_BUS.XoaNhanVien(maNV))
                {
                    MessageBox.Show("Xóa thành công!", "Thông báo");
                    HienThiDSNhanVien();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại!", "Lỗi");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            flag = 0; // Hủy thao tác thêm/sửa
            this.reset();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvNhanVien.Rows.Count)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];

                txtMaNV.Text = row.Cells["SMaNV"].Value.ToString();
                txtHoLot.Text = row.Cells["SHoLot"].Value.ToString();
                txtTen.Text = row.Cells["STenNV"].Value.ToString();

                string phai = row.Cells["SPhai"].Value.ToString();
                if (phai == "Nam")  radNam.Checked = true;                                         
                else                radNu.Checked = true ;                            

                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["DtNgaySinh"].Value);
                cboChucVu.SelectedValue = row.Cells["SMaCV"].Value.ToString();
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            string ho = txtTimho.Text.Trim();
            string ten = txtTimten.Text.Trim();
            List<NhanVien_DTO> lstnv = NhanVien_BUS.TimKiemNhanVienHoten(ho,ten);
            if (lstnv == null)
            {
                MessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dgvNhanVien.DataSource = lstnv;
        }
    }
}
