using System;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb; // Đừng quên thư viện này

namespace _2_Access
{
    public partial class Form1 : Form
    {
        // Khai báo biến kết nối dùng chung cho cả Form
        OleDbConnection conn;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Khởi tạo kết nối
                string sConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\qlnv.accdb";
                conn = new OleDbConnection(sConn);

                // 2. Mở kết nối (Mô hình kết nối bắt buộc phải Open trước)
                conn.Open();

                // 3. Gọi hàm tải dữ liệu
                DanhSach_Load();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }

        // Hàm load dữ liệu riêng (để sau này Thêm/Sửa/Xóa xong gọi lại cho tiện)
        private void DanhSach_Load()
        {
            // Tạo câu lệnh SQL
            string sql = "SELECT * FROM chucvu";

            // Tạo đối tượng thực thi lệnh
            OleDbCommand cmd = new OleDbCommand(sql, conn);

            // Tạo đối tượng đọc dữ liệu
            OleDbDataReader dr = cmd.ExecuteReader();

            // Đổ dữ liệu vào DataTable
            DataTable dt = new DataTable();
            dt.Load(dr);

            // Hiển thị lên lưới
            dgvNv.DataSource = dt;
        }

        // Yêu cầu 2: Click vào lưới thì hiện thông tin lên các ô nhập
        private void dgvChucVu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem có click đúng dòng dữ liệu không
            {
                DataGridViewRow row = dgvNv.Rows[e.RowIndex];

                txt_manv.Text = row.Cells["macv"].Value.ToString();
                txt_ten.Text = row.Cells["tencv"].Value.ToString();
                txt_heSo.Text = row.Cells["hsphucap"].Value.ToString();
            }
        }

        // Khi đóng Form thì nên đóng kết nối
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Chuẩn bị câu lệnh SQL (Dùng @ tham số để an toàn hơn)
                string sql = "INSERT INTO chucvu(macv, tencv, hsphucap) VALUES(@ma, @ten, @hs)";

                OleDbCommand cmd = new OleDbCommand(sql, conn);

                // 2. Truyền giá trị từ TextBox vào tham số (Thứ tự phải ĐÚNG như trong câu SQL)
                cmd.Parameters.AddWithValue("@ma", txt_manv.Text);
                cmd.Parameters.AddWithValue("@ten", txt_ten.Text);
                // Lưu ý: Hệ số phụ cấp là số, nên cần ép kiểu
                cmd.Parameters.AddWithValue("@hs", Convert.ToDouble(txt_heSo.Text));

                // 3. Thực thi lệnh
                cmd.ExecuteNonQuery();

                // 4. Tải lại danh sách
                DanhSach_Load();
                MessageBox.Show("Thêm thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi thêm dữ liệu: " + ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Câu lệnh Update
                string sql = "UPDATE chucvu SET tencv = @ten, hsphucap = @hs WHERE macv = @ma";

                OleDbCommand cmd = new OleDbCommand(sql, conn);

                // 2. Truyền tham số (QUAN TRỌNG: Thứ tự phải khớp với dấu chấm hỏi hoặc vị trí trong SQL)
                // Trong SQL trên: tencv trước -> hsphucap -> rồi mới đến macv
                cmd.Parameters.AddWithValue("@ten", txt_ten.Text);
                cmd.Parameters.AddWithValue("@hs", Convert.ToDouble(txt_heSo.Text));
                cmd.Parameters.AddWithValue("@ma", txt_manv.Text); // Mã nằm ở điều kiện Where cuối cùng

                // 3. Thực thi
                cmd.ExecuteNonQuery();

                // 4. Tải lại
                DanhSach_Load();
                MessageBox.Show("Cập nhật thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi sửa dữ liệu: " + ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Nên hỏi người dùng trước khi xóa
            DialogResult traloi = MessageBox.Show("Bạn có chắc muốn xóa chức vụ này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (traloi == DialogResult.Yes)
            {
                try
                {
                    string sql = "DELETE FROM chucvu WHERE macv = @ma";

                    OleDbCommand cmd = new OleDbCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ma", txt_manv.Text);

                    cmd.ExecuteNonQuery();

                    DanhSach_Load();
                    MessageBox.Show("Xóa thành công!");

                    // Xóa xong thì làm trắng các ô nhập liệu cho đẹp
                    txt_manv.Clear();
                    txt_ten.Clear();
                    txt_heSo.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi xóa dữ liệu: " + ex.Message);
                }
            }
        }
    }
}