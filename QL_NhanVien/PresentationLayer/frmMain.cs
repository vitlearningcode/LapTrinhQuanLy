using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_dmChucVu frmCV = new frm_dmChucVu();

            // Thiết lập frmCV là con của frmMain(chaaa) =)))
            frmCV.MdiParent = this;

            frmCV.Show();

        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_dmNhanVien frmNV = new frm_dmNhanVien();
            frmNV.MdiParent = this;
            frmNV.Show();
        }
    }
}
