using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frm_bcNhanVien : Form
    {
        public frm_bcNhanVien()
        {
            InitializeComponent();
        }

        private void frm_bcNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'QLNVDataSet.nhanvien' table. You can move, or remove it, as needed.
            this.nhanvienTableAdapter.Fill(this.QLNVDataSet.nhanvien);

            this.reportViewer1.RefreshReport();
        }
    }
}
