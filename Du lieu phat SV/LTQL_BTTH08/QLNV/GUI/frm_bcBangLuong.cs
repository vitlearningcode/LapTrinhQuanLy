using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;

namespace GUI
{
    public partial class frm_bcBangLuong : Form
    {
        //BangLuong_BUS bl = new BangLuong_BUS();
        public frm_bcBangLuong()
        {
            InitializeComponent();
        }

        private void frm_bcBangLuong_Load(object sender, EventArgs e)
        {
            BangLuong_DTOBindingSource.DataSource = BangLuong_BUS.LayBangLuongHienHanh();
            this.reportViewer1.RefreshReport();
        }
    }
}
