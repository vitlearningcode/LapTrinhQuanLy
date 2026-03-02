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

        // Hàm kiểm tra form con đã mở chưa
        private bool CheckExistForm(string name)
        {
            bool check = false;
            foreach (Form frm in this.MdiChildren)
            {
                // Nếu form đang tìm đã được mở
                if (frm.Name == name)
                {
                    check = true;
                    frm.Activate(); // Đưa form này nổi lên trên cùng
                    break;
                }
            }
            return check;
        }

        private void chứcVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((!CheckExistForm("frm_dmChucVu")))
            {
                frm_dmChucVu frmCV = new frm_dmChucVu();

                // Thiết lập frmCV là con của frmMain(chaaa) =)))
                frmCV.MdiParent = this;

                frmCV.Show();
            }


        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CheckExistForm("frm_dmNhanVien"))
            {
                frm_dmNhanVien frmNV = new frm_dmNhanVien();
                frmNV.MdiParent = this;
                frmNV.Show();
            }

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void quáTrìnhNângLươngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
