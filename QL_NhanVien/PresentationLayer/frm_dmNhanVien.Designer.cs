namespace PresentationLayer
{
    partial class frm_dmNhanVien
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
            label1 = new Label();
            btnThem = new Button();
            dtpNgaySinh = new DateTimePicker();
            dgvNhanVien = new DataGridView();
            btnSua = new Button();
            btnXoa = new Button();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtMaNV = new TextBox();
            txtHoLot = new TextBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            txtTen = new TextBox();
            radNam = new RadioButton();
            radNu = new RadioButton();
            cboChucVu = new ComboBox();
            btnLuu = new Button();
            btnHuy = new Button();
            btnThoat = new Button();
            label6 = new Label();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 46);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(99, 41);
            label1.TabIndex = 0;
            label1.Text = "Mã số";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(1375, 52);
            btnThem.Margin = new Padding(2, 3, 2, 3);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(187, 57);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(750, 227);
            dtpNgaySinh.Margin = new Padding(2, 3, 2, 3);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(565, 47);
            dtpNgaySinh.TabIndex = 2;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.Location = new Point(2, 341);
            dgvNhanVien.Margin = new Padding(2, 3, 2, 3);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 102;
            dgvNhanVien.Size = new Size(1864, 804);
            dgvNhanVien.TabIndex = 3;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(1375, 139);
            btnSua.Margin = new Padding(2, 3, 2, 3);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(187, 57);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(1375, 227);
            btnXoa.Margin = new Padding(2, 3, 2, 3);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(187, 57);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 139);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(108, 41);
            label2.TabIndex = 0;
            label2.Text = "Họ tên";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 249);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(56, 41);
            label3.TabIndex = 0;
            label3.Text = "Pái";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(583, 46);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(125, 41);
            label4.TabIndex = 0;
            label4.Text = "Chức vụ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(583, 249);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(150, 41);
            label5.TabIndex = 0;
            label5.Text = "Ngày sinh";
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(197, 46);
            txtMaNV.Margin = new Padding(2, 3, 2, 3);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(249, 47);
            txtMaNV.TabIndex = 4;
            // 
            // txtHoLot
            // 
            txtHoLot.Location = new Point(197, 134);
            txtHoLot.Margin = new Padding(2, 3, 2, 3);
            txtHoLot.Name = "txtHoLot";
            txtHoLot.Size = new Size(504, 47);
            txtHoLot.TabIndex = 4;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(750, 139);
            txtTen.Margin = new Padding(2, 3, 2, 3);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(565, 47);
            txtTen.TabIndex = 4;
            // 
            // radNam
            // 
            radNam.AutoSize = true;
            radNam.Location = new Point(197, 238);
            radNam.Margin = new Padding(2, 3, 2, 3);
            radNam.Name = "radNam";
            radNam.Size = new Size(118, 45);
            radNam.TabIndex = 5;
            radNam.TabStop = true;
            radNam.Text = "Nam";
            radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            radNu.AutoSize = true;
            radNu.Location = new Point(384, 238);
            radNu.Margin = new Padding(2, 3, 2, 3);
            radNu.Name = "radNu";
            radNu.Size = new Size(95, 45);
            radNu.TabIndex = 5;
            radNu.TabStop = true;
            radNu.Text = "Nữ";
            radNu.UseVisualStyleBackColor = true;
            // 
            // cboChucVu
            // 
            cboChucVu.FormattingEnabled = true;
            cboChucVu.Location = new Point(750, 55);
            cboChucVu.Margin = new Padding(2, 3, 2, 3);
            cboChucVu.Name = "cboChucVu";
            cboChucVu.Size = new Size(565, 49);
            cboChucVu.TabIndex = 6;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(1591, 49);
            btnLuu.Margin = new Padding(7, 8, 7, 8);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(182, 63);
            btnLuu.TabIndex = 7;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(1591, 145);
            btnHuy.Margin = new Padding(7, 8, 7, 8);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(182, 63);
            btnHuy.TabIndex = 7;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(1591, 227);
            btnThoat.Margin = new Padding(7, 8, 7, 8);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(182, 63);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            label6.Dock = DockStyle.Top;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(0, 0);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(1868, 87);
            label6.TabIndex = 0;
            label6.Text = "QUẢN LÝ NHÂN VIÊN";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            panel1.Controls.Add(groupBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(7, 8);
            panel1.Margin = new Padding(7, 8, 7, 8);
            panel1.Name = "panel1";
            panel1.Size = new Size(1854, 322);
            panel1.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboChucVu);
            groupBox1.Controls.Add(dtpNgaySinh);
            groupBox1.Controls.Add(btnThoat);
            groupBox1.Controls.Add(txtMaNV);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnXoa);
            groupBox1.Controls.Add(btnHuy);
            groupBox1.Controls.Add(txtHoLot);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(btnSua);
            groupBox1.Controls.Add(btnLuu);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(btnThem);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(radNam);
            groupBox1.Controls.Add(radNu);
            groupBox1.Controls.Add(label5);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(7, 8, 7, 8);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(7, 8, 7, 8);
            groupBox1.Size = new Size(1854, 322);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(dgvNhanVien, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 87);
            tableLayoutPanel1.Margin = new Padding(7, 8, 7, 8);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 29.52381F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 70.47619F));
            tableLayoutPanel1.Size = new Size(1868, 1148);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // frm_dmNhanVien
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1868, 1235);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label6);
            Margin = new Padding(2, 3, 2, 3);
            Name = "frm_dmNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            Load += frm_dmNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnThem;
        private DateTimePicker dtpNgaySinh;
        private DataGridView dgvNhanVien;
        private Button btnSua;
        private Button btnXoa;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtMaNV;
        private TextBox txtHoLot;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txtTen;
        private RadioButton radNam;
        private RadioButton radNu;
        private ComboBox cboChucVu;
        private Button btnLuu;
        private Button btnHuy;
        private Button btnThoat;
        private Label label6;
        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
    }
}