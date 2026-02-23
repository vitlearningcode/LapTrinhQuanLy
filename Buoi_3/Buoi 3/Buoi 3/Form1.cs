using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data.Sql;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data;
using static System.Formats.Asn1.AsnWriter;

namespace Buoi_3
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        string sConn = @"Data Source=MT0301\SQLEXPRESS;Initial Catalog=QLNV;Integrated Security=True;TrustServerCertificate=True";

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                //1. kết nối dữ liệu
                //string sConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\qlnv.accdb";

               

                //2. load 
                LoadDanhSachNhanVien();
                LoadComboBoxChucVu();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Errol " + ex.Message);
                throw;
            }
        }

        //quân cờ xem thêm/sửa
        bool check = false;
        public void isCheck (bool isCheck)
        {
            txtHoLot.ReadOnly = !isCheck;
            txtMaNV.ReadOnly = !isCheck;
            txtTen.ReadOnly = !isCheck;

            btnThem.Enabled = !isCheck;
            btnThem.Enabled = !isCheck;
            btnXoa.Enabled = !isCheck;

            btnLuu.Enabled = isCheck;
            btnHuy.Enabled = !isCheck;
        }


        private void LoadComboBoxChucVu()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM chucvu", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            cboChucVu.DataSource = dt;
            cboChucVu.DisplayMember = "tencv"; 
            cboChucVu.ValueMember = "macv";    
        }

        private void LoadDanhSachNhanVien()
        {
            string sql = "select * from nhanvien";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            dgvNhanVien.DataSource = dt;
            dgvNhanVien.Columns["manv"].HeaderText = "Mã số";
            dgvNhanVien.Columns["holot"].HeaderText = "Họ lót";
            dgvNhanVien.Columns["tennv"].HeaderText = "Tên";
            dgvNhanVien.Columns["phai"].HeaderText = "Phái";
            dgvNhanVien.Columns["ngaysinh"].HeaderText = "Ngày sinh";
            dgvNhanVien.Columns["macv"].HeaderText = "Mã CV";
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];

                txtMaNV.Text = row.Cells["manv"].Value.ToString();
                txtHoLot.Text = row.Cells["holot"].Value.ToString();
                txtTen.Text = row.Cells["tennv"].Value.ToString();

                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["ngaysinh"].Value);

                string phai = row.Cells["phai"].Value.ToString();
                if (phai == "Nam") radNam.Checked = true;
                else radNam.Checked = false;

                cboChucVu.SelectedValue = row.Cells["macv"].Value.ToString();


            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            check = true;
            txtHoLot.Clear();
            txtTen.Clear();
            txtMaNV.Clear();

            isCheck(true);

            try
            {
                string sql = "insert into nhanvien(manv, holot, tennv, phai, ngaysinh, macv) values (@ma, @ho, @ten, @phai, @ngay, @macv)";
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@ma", txtMaNV.Text);
                cmd.Parameters.AddWithValue("@ho", txtHoLot.Text);
                cmd.Parameters.AddWithValue("@ten", txtTen.Text);
                cmd.Parameters.AddWithValue("@phai", radNam.Checked ? "Nam" : "Nữ");
                cmd.Parameters.AddWithValue("@ngay", dtpNgaySinh.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@macv", cboChucVu.SelectedValue.ToString());
                cmd.ExecuteNonQuery();

                LoadDanhSachNhanVien();
                MessageBox.Show("them OK");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                throw;
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgvNhanVien.Rows.Count < 0) { DialogResult dialogResult = MessageBox.Show("vui lòng chọn nhân viên", "cảnh báo", (MessageBoxButtons)MessageBoxIcon.Warning); }

            check = false;
            isCheck(true);
            txtMaNV.ReadOnly = true;

            try
            {
                //update
                string sql = "update nhanvien set holot=@ho, tennv=@ten, phai=@phai, ngaysinh=@ngay, macv=@macv where manv=@ma";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@ho", txtHoLot.Text);
                cmd.Parameters.AddWithValue("@ten", txtTen.Text);
                cmd.Parameters.AddWithValue("@phai", radNam.Checked ? "Nam" : "Nữ");
                cmd.Parameters.AddWithValue("@ngay", dtpNgaySinh.Value.ToShortDateString());
                cmd.Parameters.AddWithValue("@macv", cboChucVu.SelectedValue.ToString());

                cmd.Parameters.AddWithValue("@ma", txtMaNV.Text);//dk where

                cmd.ExecuteNonQuery();
                LoadDanhSachNhanVien();
                MessageBox.Show("sua OK");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                throw;
            }


        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text)) return;

            if (MessageBox.Show("Bạn có chắc muốn xóa nhân viên này?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection connection = new SqlConnection(sConn))
                    {
                        connection.Open();
                        string sql = "DELETE FROM nhanvien WHERE manv = @ma";
                        using (SqlCommand cmd = new SqlCommand(sql, connection))
                        {
                            cmd.Parameters.AddWithValue("@ma", txtMaNV.Text);
                            cmd.ExecuteNonQuery();
                        }
                    }

                    LoadDanhSachNhanVien();

                   
                    txtMaNV.Clear();
                    txtHoLot.Clear();
                    txtTen.Clear();

                    MessageBox.Show("Đã xóa thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi không thể xóa (Có thể do ràng buộc dữ liệu): " + ex.Message);
                }
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(sConn))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = connection;

                    if (check) //  Thêm 
                    {
                        cmd.CommandText = "INSERT INTO nhanvien(manv, holot, ten, phai, ngaysinh, macv) VALUES (@ma, @ho, @ten, @phai, @ngay, @macv)";
                    }
                    else // \ Sửa
                    {
                        cmd.CommandText = "UPDATE nhanvien SET holot=@ho, ten=@ten, phai=@phai, ngaysinh=@ngay, macv=@macv WHERE manv=@ma";
                    }

                  
                    cmd.Parameters.AddWithValue("@ma", txtMaNV.Text);
                    cmd.Parameters.AddWithValue("@ho", txtHoLot.Text);
                    cmd.Parameters.AddWithValue("@ten", txtTen.Text);
                    cmd.Parameters.AddWithValue("@phai", radNam.Checked ? "Nam" : "Nữ");
                    cmd.Parameters.AddWithValue("@ngay", dtpNgaySinh.Value);
                    cmd.Parameters.AddWithValue("@macv", cboChucVu.SelectedValue.ToString());

                    cmd.ExecuteNonQuery();
                }

               
                LoadDanhSachNhanVien();
                isCheck(false); // lock lại ee
                MessageBox.Show(check ? "Thêm thành công!" : "Sửa thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
           
            txtMaNV.Clear();
            txtHoLot.Clear();
            txtTen.Clear();

         
            isCheck(false);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Xác nhận", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close(); 
                              // Hoặc dùng Application.Exit(); nếu muốn tắt toàn bộ chương trình
            }
        }
    }
}
