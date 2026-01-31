using System.Data;
using System.Data.OleDb;

namespace _1_Access
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OleDbConnection conn = new OleDbConnection();
            conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + @"\qlnv.accdb";

            conn.Open();

            DataSet ds  = new DataSet();

            OleDbDataAdapter da = new OleDbDataAdapter("select * from chucvu", conn);
            da.Fill(ds, "tblNhanVien");

            cboChucVu.DataSource = ds.Tables[0];
            // 1. Chỉ định cột hiển thị ra màn hình (theo hình 3 là cột 'tencv')
            cboChucVu.DisplayMember = "tencv";

            // 2. Chỉ định cột giá trị ẩn bên trong (để sau này lưu xuống database)
            cboChucVu.ValueMember = "macv";

            conn.Close();
        }
    }
}
