using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataTransferObject;
using DataAccessLayer;

namespace PresentationLayer
{
    public partial class frm_dmChucVu : Form
    {
        public frm_dmChucVu()
        {
            InitializeComponent();
        }

        private void frm_dmChucVu_Load(object sender, EventArgs e)
        {
            List <ChucVu_DTO> lstChucVu = ChucVu_BUS.LayChucVu();
            dgDSChucVu.DataSource = lstChucVu;   
        }
    }
}
