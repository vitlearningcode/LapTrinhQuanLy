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
            flag = 2;
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

            if (flag == 1)
            {
                if (txtMaNV.Text.Length > 6)
                {
                    MessageBox.Show("Lưu ý MaNV < 6 kí tự bạn ê!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                if (NhanVien_BUS.KiemTraMaNV(txtMaNV.Text))
                {
                    MessageBox.Show("Mã nhân viên đã tồn tại. Vui lòng chọn mã khác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else

                    if (txtMaNV.Text.Trim() == "" || txtHoLot.Text.Trim() == "" || txtTen.Text.Trim() == "")
                {
                    MessageBox.Show("VUi lòng nhập đậy đủ ữ liệu bạn ê!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                if (NhanVien_BUS.ThemNhanVien(nv))
                {
                    MessageBox.Show("Thêm nhân viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDSNhanVien();
                }
                else
                {
                    MessageBox.Show("Thêm thất bại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (flag == 2)
            {
                if (NhanVien_BUS.SuaNhanVien(nv))
                {
                    MessageBox.Show("Cập nhật thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    HienThiDSNhanVien();
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            flag = 0;
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
            txtMaNV.Clear();
            txtHoLot.Clear();
            txtTen.Clear();
            txtMaNV.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra xem có click đúng vào dòng dữ liệu không (tránh click nhầm vào dòng tiêu đề bị lỗi)
            if (e.RowIndex >= 0 && e.RowIndex < dgvNhanVien.Rows.Count)
            {
                // Lấy ra dòng hiện tại đang được click
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];

                // 1. Đổ dữ liệu ra các TextBox
                // Tên cột lấy đúng theo tên Properties trong NhanVien_DTO
                txtMaNV.Text = row.Cells["SMaNV"].Value.ToString();
                txtHoLot.Text = row.Cells["SHoLot"].Value.ToString();
                txtTen.Text = row.Cells["STenNV"].Value.ToString();

                // 2. Đổ dữ liệu ra RadioButton Giới tính
                string phai = row.Cells["SPhai"].Value.ToString();
                if (phai == "Nam")
                {
                    radNam.Checked = true;
                }
                else
                {
                    radNu.Checked = true;
                }

                // 3. Đổ dữ liệu ra DateTimePicker Ngày sinh
                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["DtNgaySinh"].Value);

                // 4. Đổ dữ liệu ra ComboBox Chức vụ
                // SelectedValue sẽ khớp với ValueMember (SMaCV) mà bạn đã gán lúc Load form
                cboChucVu.SelectedValue = row.Cells["SMaCV"].Value.ToString();
            }
        }



        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
           // //string ten = txtTimten.Text.Trim();
           //// List <NhanVien_DTO> lstnv = NhanVien_BUS.TimKiemNhanVien(ten);
           // if ( lstnv == null)
           // {
           //     MessageBox.Show("Không tìm thấy", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
           // }

           // dgvNhanVien.DataSource = lstnv;
        }
    }
}
