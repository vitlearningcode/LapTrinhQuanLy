using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace _1_Access
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                // 1. Tạo chuỗi kết nối
               
                // Nếu dùng bản SQL Express thì sửa thành ".\SQLEXPRESS"
                string sConn = @"Data Source=KENG-LT\SQLEXPRESS;Initial Catalog=QLNV;Integrated Security=True";

                // 2. Tạo câu truy vấn lấy dữ liệu
                string sQuery = "select * from nhanvien";

                // 3. Khởi tạo Adapter để lấy dữ liệu
                SqlDataAdapter da = new SqlDataAdapter(sQuery, sConn);

                // 4. Đổ dữ liệu vào DataSet gom xuống đây cho gọn để trên kia gồm gà vl
                DataSet ds = new DataSet();
                da.Fill(ds, "tblNhanVien");

                // 5. Hiển thị lên DataGridView
                dgDSNhanVien.DataSource = ds.Tables["tblNhanVien"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }



        }
    }
}
