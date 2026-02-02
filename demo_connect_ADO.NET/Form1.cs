using System.Data;
 // Thư viện cho DataTable
using System.Data.SqlClient;
namespace demo_connect_ADO.NET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Chuỗi kết nối (Connection String)
        // Lưu ý: Phần "Data Source" cần thay đổi tùy theo tên máy của bạn
        //string strKetNoi = @"Data Source=KENG-LT\SQLEXPRESS;Initial Catalog=DemoQLSV;Integrated Security=True";

        private void btnKetNoi_Click(object sender, EventArgs e)
        {

            // Sử dụng SqlConnection để tạo kết nối
            // Dùng khối 'using' để tự động giải phóng tài nguyên khi xong
            using (SqlConnection conn = new SqlConnection(connect.strKetNoi))
            {
                {
                    try
                    {
                        // 1. Mở kết nối
                        conn.Open();

                        // 2. Tạo câu lệnh SQL
                        string query = "SELECT * FROM SinhVien";

                        // 3. Sử dụng SqlDataAdapter để lấy dữ liệu về
                        // Adapter giống như một "xe vận chuyển" dữ liệu từ SQL về C#
                        SqlDataAdapter adapter = new SqlDataAdapter(query, conn);

                        // 4. Đổ dữ liệu vào một bảng ảo (DataTable)
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        // 5. Hiển thị lên DataGridView
                        dgvSinhVien.DataSource = dt;

                        MessageBox.Show("Kết nối và lấy dữ liệu thành công!", "Thông báo");
                    }
                    catch (Exception ex)
                    {
                        // Bắt lỗi nếu kết nối thất bại (ví dụ sai tên Server)
                        MessageBox.Show("Lỗi kết nối: " + ex.Message, "Lỗi");
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
       TaiDanhSachSinhVien(); // Tải dữ liệu ngay khi mở form
        }

     
        // ===============================================
        // 1. SELECT: Lấy dữ liệu hiển thị (READ)
        // ===============================================
        void TaiDanhSachSinhVien()
        {
            // Dùng 'using' để tự động đóng kết nối sau khi xong
            using (SqlConnection conn = new SqlConnection(connect.strKetNoi))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM SinhVien";

                    // SqlDataAdapter là cầu nối để lấy dữ liệu về
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt); // Đổ dữ liệu vào bảng ảo

                    dgvSinhVien.DataSource = dt; // Hiển thị lên lưới
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi tải dữ liệu: " + ex.Message);
                }
            }
        }

        private void btnTaiDuLieu_Click(object sender, EventArgs e)
        {
            TaiDanhSachSinhVien();
        }

        // ===============================================
        // 2. INSERT: Thêm mới sinh viên (CREATE)
        // ===============================================
        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connect.strKetNoi))
            {
                try
                {
                    conn.Open();
                    // Câu lệnh SQL chèn dữ liệu
                    // Dùng @ tham số để chống lỗi SQL Injection và lỗi font chữ
                    string query = "INSERT INTO SinhVien (MaSV, HoTen, Lop, DiemTB) VALUES (@Ma, @Ten, @Lop, @Diem)";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    // Gán giá trị từ TextBox vào tham số
                    cmd.Parameters.AddWithValue("@Ma", txtMaSV.Text);
                    cmd.Parameters.AddWithValue("@Ten", txtHoTen.Text);
                    cmd.Parameters.AddWithValue("@Lop", txtLop.Text);
                    cmd.Parameters.AddWithValue("@Diem", float.Parse(txtDiemTB.Text));

                    // ExecuteNonQuery: Dùng cho Insert, Update, Delete (trả về số dòng bị ảnh hưởng)
                    int rowChanged = cmd.ExecuteNonQuery();

                    if (rowChanged > 0)
                    {
                        MessageBox.Show("Thêm thành công!");
                        TaiDanhSachSinhVien(); // Refresh lại lưới
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi thêm: " + ex.Message);
                }
            }
        }

        // ===============================================
        // 3. UPDATE: Sửa thông tin sinh viên (UPDATE)
        // ===============================================
        private void btnSua_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connect.strKetNoi))
            {
                try
                {
                    conn.Open();
                    // Sửa tên, lớp, điểm DỰA VÀO mã sinh viên
                    string query = "UPDATE SinhVien SET HoTen = @Ten, Lop = @Lop, DiemTB = @Diem WHERE MaSV = @Ma";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Ma", txtMaSV.Text); // Mã SV là điều kiện tìm kiếm để sửa
                    cmd.Parameters.AddWithValue("@Ten", txtHoTen.Text);
                    cmd.Parameters.AddWithValue("@Lop", txtLop.Text);
                    cmd.Parameters.AddWithValue("@Diem", float.Parse(txtDiemTB.Text));

                    int rowChanged = cmd.ExecuteNonQuery();
                    if (rowChanged > 0)
                    {
                        MessageBox.Show("Sửa thành công!");
                        TaiDanhSachSinhVien();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy Mã SV này để sửa!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi sửa: " + ex.Message);
                }
            }
        }

        // ===============================================
        // 4. DELETE: Xóa sinh viên (DELETE)
        // ===============================================
        private void btnXoa_Click(object sender, EventArgs e)
        {
            // Hỏi xác nhận trước khi xóa cho chắc ăn
            if (MessageBox.Show("Bạn có chắc muốn xóa?", "Cảnh báo", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connect.strKetNoi))
                {
                    try
                    {
                        conn.Open();
                        string query = "DELETE FROM SinhVien WHERE MaSV = @Ma";

                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@Ma", txtMaSV.Text);

                        int rowChanged = cmd.ExecuteNonQuery();
                        if (rowChanged > 0)
                        {
                            MessageBox.Show("Xóa thành công!");
                            TaiDanhSachSinhVien();

                            // Xóa xong thì làm trống các ô nhập liệu
                            txtMaSV.Text = ""; txtHoTen.Text = ""; txtLop.Text = ""; txtDiemTB.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("Không tìm thấy Mã SV để xóa!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi xóa: " + ex.Message);
                    }
                }
            }
        }

        // Sự kiện hỗ trợ: Khi click vào dòng trong DataGridView thì đổ ngược dữ liệu lên TextBox
        private void dgvSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem có click vào dòng tiêu đề không
            {
                DataGridViewRow row = dgvSinhVien.Rows[e.RowIndex];
                txtMaSV.Text = row.Cells["MaSV"].Value.ToString();
                txtHoTen.Text = row.Cells["HoTen"].Value.ToString();
                txtLop.Text = row.Cells["Lop"].Value.ToString();
                txtDiemTB.Text = row.Cells["DiemTB"].Value.ToString();
            }
        }
    }
}