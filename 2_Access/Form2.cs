using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _2_Access
{
    public partial class Form2 : Form
    {
        OleDbConnection conn;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                //1. kết nối dữ liệu
                string sConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\qlnv.accdb";

                //sql test chơi
                // Lưu ý: "Initial Catalog" là tên Database bạn đã tạo trong SQL Server (ví dụ QLNV)
                //string sConn = @"Data Source=.\SQLEXPRESS;Initial Catalog=QLNV;Integrated Security=True";

                //Đối tượng Access(Cũ), Đối tượng SQL Server(Mới)
                //OleDbConnection,SqlConnection
                //OleDbCommand, SqlCommand
                //OleDbDataReader,SqlDataReader
                //OleDbDataAdapter, SqlDataAdapter


                conn = new OleDbConnection(sConn);
                conn.Open();

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

        private void LoadComboBoxChucVu()
        {
            OleDbCommand cmd = new OleDbCommand("SELECT * FROM chucvu", conn);
            OleDbDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            cboChucVu.DataSource = dt;
            cboChucVu.DisplayMember = "tencv"; // Hiện tên
            cboChucVu.ValueMember = "macv";    // Lấy mã
        }

        private void LoadDanhSachNhanVien()
        {
            string sql = "select * from nhanvien";
            OleDbCommand cmd = new OleDbCommand(sql, conn);
            OleDbDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(dr);

            dgvNhanVien.DataSource = dt;
        }

        private void dgvNhanVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanVien.Rows[e.RowIndex];

                txtMaNV.Text = row.Cells["manv"].Value.ToString();
                txtHoLot.Text = row.Cells["holot"].Value.ToString();
                txtTen.Text = row.Cells["ten"].Value.ToString();

                dtpNgaySinh.Value = Convert.ToDateTime(row.Cells["ngaysinh"].Value);

                string phai = row.Cells["phai"].Value.ToString();
                if (phai == "Nam") radNam.Checked = true;
                else radNam.Checked = false;

                cboChucVu.SelectedValue = row.Cells["macv"].Value.ToString();

                
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = "insert into nhanvien(manv, holot, ten, phai, ngaysinh, macv) values (@ma, @ho, @ten, @phai, @ngay, @macv)";
                OleDbCommand cmd =  new OleDbCommand(sql, conn);

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
            try
            {
                //update
                string sql = "update nhanvien set holot=@ho, ten=@ten, phai=@phai, ngaysinh=@ngay, macv=@macv where manv=@manv";
                OleDbCommand cmd = new OleDbCommand(sql, conn);
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
            if (MessageBox.Show("cảnh báo?", "cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
                try
                {
                    string sql = "delete from nhanvien where manv=@ma";
                    OleDbCommand cmd = new OleDbCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@ma", txtMaNV.Text);
                    cmd.ExecuteNonQuery();
                    LoadDanhSachNhanVien();

                    txtMaNV.Clear();
                    txtHoLot.Clear();
                    txtTen.Clear();
                }
                catch (Exception)
                {

                    throw;
                }
        }
    }
}
