namespace GUI
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.i_HeThong = new System.Windows.Forms.ToolStripMenuItem();
            this.i_htDangNhap = new System.Windows.Forms.ToolStripMenuItem();
            this.i_htDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.i_htDoiMatKhau = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.i_DanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.i_dmChucVu = new System.Windows.Forms.ToolStripMenuItem();
            this.i_dmNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.i_NghiepVu = new System.Windows.Forms.ToolStripMenuItem();
            this.i_nvBangLuong = new System.Windows.Forms.ToolStripMenuItem();
            this.i_nvQuaTrinhLuong = new System.Windows.Forms.ToolStripMenuItem();
            this.i_BaoCao = new System.Windows.Forms.ToolStripMenuItem();
            this.i_bcNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.i_bcBangLuong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sttTTNguoiDung = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sttTTThoiGian = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuMain.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // i_HeThong
            // 
            this.i_HeThong.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.i_htDangNhap,
            this.i_htDangXuat,
            this.toolStripSeparator1,
            this.i_htDoiMatKhau,
            this.toolStripSeparator2});
            this.i_HeThong.Name = "i_HeThong";
            this.i_HeThong.Size = new System.Drawing.Size(69, 20);
            this.i_HeThong.Text = "Hệ thống";
            // 
            // i_htDangNhap
            // 
            this.i_htDangNhap.Name = "i_htDangNhap";
            this.i_htDangNhap.Size = new System.Drawing.Size(152, 22);
            this.i_htDangNhap.Text = "Đăng nhập";
            this.i_htDangNhap.Click += new System.EventHandler(this.i_htDangNhap_Click);
            // 
            // i_htDangXuat
            // 
            this.i_htDangXuat.Name = "i_htDangXuat";
            this.i_htDangXuat.Size = new System.Drawing.Size(152, 22);
            this.i_htDangXuat.Text = "Đăng xuất";
            this.i_htDangXuat.Click += new System.EventHandler(this.i_htDangXuat_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // i_htDoiMatKhau
            // 
            this.i_htDoiMatKhau.Name = "i_htDoiMatKhau";
            this.i_htDoiMatKhau.Size = new System.Drawing.Size(152, 22);
            this.i_htDoiMatKhau.Text = "Đổi mật khẩu";
            this.i_htDoiMatKhau.Click += new System.EventHandler(this.i_htDoiMatKhau_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // i_DanhMuc
            // 
            this.i_DanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.i_dmChucVu,
            this.i_dmNhanVien});
            this.i_DanhMuc.Name = "i_DanhMuc";
            this.i_DanhMuc.Size = new System.Drawing.Size(74, 20);
            this.i_DanhMuc.Text = "Danh mục";
            // 
            // i_dmChucVu
            // 
            this.i_dmChucVu.Name = "i_dmChucVu";
            this.i_dmChucVu.Size = new System.Drawing.Size(152, 22);
            this.i_dmChucVu.Text = "Chức vụ";
            this.i_dmChucVu.Click += new System.EventHandler(this.i_dmChucVu_Click);
            // 
            // i_dmNhanVien
            // 
            this.i_dmNhanVien.Name = "i_dmNhanVien";
            this.i_dmNhanVien.Size = new System.Drawing.Size(152, 22);
            this.i_dmNhanVien.Text = "Nhân viên";
            this.i_dmNhanVien.Click += new System.EventHandler(this.i_dmNhanVien_Click);
            // 
            // i_NghiepVu
            // 
            this.i_NghiepVu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.i_nvBangLuong,
            this.i_nvQuaTrinhLuong});
            this.i_NghiepVu.Name = "i_NghiepVu";
            this.i_NghiepVu.Size = new System.Drawing.Size(74, 20);
            this.i_NghiepVu.Text = "Nghiệp vụ";
            // 
            // i_nvBangLuong
            // 
            this.i_nvBangLuong.Name = "i_nvBangLuong";
            this.i_nvBangLuong.Size = new System.Drawing.Size(188, 22);
            this.i_nvBangLuong.Text = "Bảng lương";
            // 
            // i_nvQuaTrinhLuong
            // 
            this.i_nvQuaTrinhLuong.Name = "i_nvQuaTrinhLuong";
            this.i_nvQuaTrinhLuong.Size = new System.Drawing.Size(188, 22);
            this.i_nvQuaTrinhLuong.Text = "Quá trình nâng lương";
            this.i_nvQuaTrinhLuong.Click += new System.EventHandler(this.i_nvQuaTrinhLuong_Click);
            // 
            // i_BaoCao
            // 
            this.i_BaoCao.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.i_bcNhanVien,
            this.i_bcBangLuong});
            this.i_BaoCao.Name = "i_BaoCao";
            this.i_BaoCao.Size = new System.Drawing.Size(61, 20);
            this.i_BaoCao.Text = "Báo cáo";
            // 
            // i_bcNhanVien
            // 
            this.i_bcNhanVien.Name = "i_bcNhanVien";
            this.i_bcNhanVien.Size = new System.Drawing.Size(135, 22);
            this.i_bcNhanVien.Text = "Nhân viên";
            this.i_bcNhanVien.Click += new System.EventHandler(this.i_bcNhanVien_Click);
            // 
            // i_bcBangLuong
            // 
            this.i_bcBangLuong.Name = "i_bcBangLuong";
            this.i_bcBangLuong.Size = new System.Drawing.Size(135, 22);
            this.i_bcBangLuong.Text = "Bảng lương";
            this.i_bcBangLuong.Click += new System.EventHandler(this.i_bcBangLuong_Click);
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.i_HeThong,
            this.i_DanhMuc,
            this.i_NghiepVu,
            this.i_BaoCao});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(938, 24);
            this.menuMain.TabIndex = 1;
            this.menuMain.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sttTTNguoiDung,
            this.toolStripStatusLabel1,
            this.sttTTThoiGian});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(938, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sttTTNguoiDung
            // 
            this.sttTTNguoiDung.Name = "sttTTNguoiDung";
            this.sttTTNguoiDung.Size = new System.Drawing.Size(120, 17);
            this.sttTTNguoiDung.Text = "Trạng thái đăng nhập";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(10, 17);
            this.toolStripStatusLabel1.Text = "|";
            // 
            // sttTTThoiGian
            // 
            this.sttTTThoiGian.Name = "sttTTThoiGian";
            this.sttTTThoiGian.Size = new System.Drawing.Size(117, 17);
            this.sttTTThoiGian.Text = "Thời gian đăng nhập";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 561);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chương trình quản lý nhân viên";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem i_HeThong;
        private System.Windows.Forms.ToolStripMenuItem i_DanhMuc;
        private System.Windows.Forms.ToolStripMenuItem i_dmChucVu;
        private System.Windows.Forms.ToolStripMenuItem i_dmNhanVien;
        private System.Windows.Forms.ToolStripMenuItem i_NghiepVu;
        private System.Windows.Forms.ToolStripMenuItem i_nvBangLuong;
        private System.Windows.Forms.ToolStripMenuItem i_nvQuaTrinhLuong;
        private System.Windows.Forms.ToolStripMenuItem i_BaoCao;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem i_bcNhanVien;
        private System.Windows.Forms.ToolStripMenuItem i_bcBangLuong;
        private System.Windows.Forms.ToolStripMenuItem i_htDangNhap;
        private System.Windows.Forms.ToolStripMenuItem i_htDangXuat;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sttTTNguoiDung;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel sttTTThoiGian;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem i_htDoiMatKhau;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;

    }
}

