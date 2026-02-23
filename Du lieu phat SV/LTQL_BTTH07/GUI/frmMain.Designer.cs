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
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danhMụcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.i_dmChucVu = new System.Windows.Forms.ToolStripMenuItem();
            this.i_dmNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.nghiệpVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bảngLươngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.i_nvQuaTrinhLuong = new System.Windows.Forms.ToolStripMenuItem();
            this.báoCáoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.i_bcNhanVien = new System.Windows.Forms.ToolStripMenuItem();
            this.i_bcBangLuong = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMain = new System.Windows.Forms.MenuStrip();
            this.menuMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ thống";
            // 
            // danhMụcToolStripMenuItem
            // 
            this.danhMụcToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.i_dmChucVu,
            this.i_dmNhanVien});
            this.danhMụcToolStripMenuItem.Name = "danhMụcToolStripMenuItem";
            this.danhMụcToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.danhMụcToolStripMenuItem.Text = "Danh mục";
            // 
            // i_dmChucVu
            // 
            this.i_dmChucVu.Name = "i_dmChucVu";
            this.i_dmChucVu.Size = new System.Drawing.Size(128, 22);
            this.i_dmChucVu.Text = "Chức vụ";
            this.i_dmChucVu.Click += new System.EventHandler(this.i_dmChucVu_Click);
            // 
            // i_dmNhanVien
            // 
            this.i_dmNhanVien.Name = "i_dmNhanVien";
            this.i_dmNhanVien.Size = new System.Drawing.Size(128, 22);
            this.i_dmNhanVien.Text = "Nhân viên";
            this.i_dmNhanVien.Click += new System.EventHandler(this.i_dmNhanVien_Click);
            // 
            // nghiệpVụToolStripMenuItem
            // 
            this.nghiệpVụToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bảngLươngToolStripMenuItem,
            this.i_nvQuaTrinhLuong});
            this.nghiệpVụToolStripMenuItem.Name = "nghiệpVụToolStripMenuItem";
            this.nghiệpVụToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.nghiệpVụToolStripMenuItem.Text = "Nghiệp vụ";
            // 
            // bảngLươngToolStripMenuItem
            // 
            this.bảngLươngToolStripMenuItem.Name = "bảngLươngToolStripMenuItem";
            this.bảngLươngToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.bảngLươngToolStripMenuItem.Text = "Bảng lương";
            // 
            // i_nvQuaTrinhLuong
            // 
            this.i_nvQuaTrinhLuong.Name = "i_nvQuaTrinhLuong";
            this.i_nvQuaTrinhLuong.Size = new System.Drawing.Size(188, 22);
            this.i_nvQuaTrinhLuong.Text = "Quá trình nâng lương";
            this.i_nvQuaTrinhLuong.Click += new System.EventHandler(this.i_nvQuaTrinhLuong_Click);
            // 
            // báoCáoToolStripMenuItem
            // 
            this.báoCáoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.i_bcNhanVien,
            this.i_bcBangLuong});
            this.báoCáoToolStripMenuItem.Name = "báoCáoToolStripMenuItem";
            this.báoCáoToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.báoCáoToolStripMenuItem.Text = "Báo cáo";
            // 
            // i_bcNhanVien
            // 
            this.i_bcNhanVien.Name = "i_bcNhanVien";
            this.i_bcNhanVien.Size = new System.Drawing.Size(152, 22);
            this.i_bcNhanVien.Text = "Nhân viên";
            this.i_bcNhanVien.Click += new System.EventHandler(this.i_bcNhanVien_Click);
            // 
            // i_bcBangLuong
            // 
            this.i_bcBangLuong.Name = "i_bcBangLuong";
            this.i_bcBangLuong.Size = new System.Drawing.Size(152, 22);
            this.i_bcBangLuong.Text = "Bảng lương";
            this.i_bcBangLuong.Click += new System.EventHandler(this.i_bcBangLuong_Click);
            // 
            // menuMain
            // 
            this.menuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.danhMụcToolStripMenuItem,
            this.nghiệpVụToolStripMenuItem,
            this.báoCáoToolStripMenuItem});
            this.menuMain.Location = new System.Drawing.Point(0, 0);
            this.menuMain.Name = "menuMain";
            this.menuMain.Size = new System.Drawing.Size(938, 24);
            this.menuMain.TabIndex = 1;
            this.menuMain.Text = "menuStrip1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 561);
            this.Controls.Add(this.menuMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuMain;
            this.Name = "frmMain";
            this.Text = "Chương trình quản lý nhân viên";
            this.menuMain.ResumeLayout(false);
            this.menuMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danhMụcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem i_dmChucVu;
        private System.Windows.Forms.ToolStripMenuItem i_dmNhanVien;
        private System.Windows.Forms.ToolStripMenuItem nghiệpVụToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bảngLươngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem i_nvQuaTrinhLuong;
        private System.Windows.Forms.ToolStripMenuItem báoCáoToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuMain;
        private System.Windows.Forms.ToolStripMenuItem i_bcNhanVien;
        private System.Windows.Forms.ToolStripMenuItem i_bcBangLuong;

    }
}

