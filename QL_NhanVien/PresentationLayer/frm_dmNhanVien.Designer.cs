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
            dgvNhanVien = new DataGridView();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            tableLayoutPanel1 = new TableLayoutPanel();
            splitContainer1 = new SplitContainer();
            groupBox2 = new GroupBox();
            btnTim = new Button();
            txtTimho = new TextBox();
            txtTimten = new TextBox();
            groupBox1 = new GroupBox();
            cboChucVu = new ComboBox();
            dtpNgaySinh = new DateTimePicker();
            txtMaNV = new TextBox();
            label1 = new Label();
            txtHoLot = new TextBox();
            label2 = new Label();
            txtTen = new TextBox();
            label3 = new Label();
            label4 = new Label();
            radNam = new RadioButton();
            radNu = new RadioButton();
            label5 = new Label();
            btnThem = new Button();
            btnXoa = new Button();
            btnThoat = new Button();
            btnHuy = new Button();
            btnSua = new Button();
            btnLuu = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Dock = DockStyle.Fill;
            dgvNhanVien.Location = new Point(1, 188);
            dgvNhanVien.Margin = new Padding(1);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 102;
            dgvNhanVien.Size = new Size(767, 199);
            dgvNhanVien.TabIndex = 3;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(dgvNhanVien, 0, 1);
            tableLayoutPanel1.Controls.Add(splitContainer1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 48.1958771F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 51.8041229F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(769, 388);
            tableLayoutPanel1.TabIndex = 9;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox2);
            splitContainer1.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnThem);
            splitContainer1.Panel2.Controls.Add(btnXoa);
            splitContainer1.Panel2.Controls.Add(btnThoat);
            splitContainer1.Panel2.Controls.Add(btnHuy);
            splitContainer1.Panel2.Controls.Add(btnSua);
            splitContainer1.Panel2.Controls.Add(btnLuu);
            splitContainer1.Size = new Size(763, 181);
            splitContainer1.SplitterDistance = 566;
            splitContainer1.TabIndex = 9;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnTim);
            groupBox2.Controls.Add(txtTimho);
            groupBox2.Controls.Add(txtTimten);
            groupBox2.Dock = DockStyle.Bottom;
            groupBox2.Location = new Point(0, 110);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(566, 71);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "Tìm nhân viên";
            // 
            // btnTim
            // 
            btnTim.Location = new Point(469, 27);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(75, 23);
            btnTim.TabIndex = 1;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // txtTimho
            // 
            txtTimho.Location = new Point(25, 27);
            txtTimho.Name = "txtTimho";
            txtTimho.PlaceholderText = "Nhập vào họ nhân viên cần tìm";
            txtTimho.Size = new Size(205, 23);
            txtTimho.TabIndex = 0;
            // 
            // txtTimten
            // 
            txtTimten.Location = new Point(253, 27);
            txtTimten.Name = "txtTimten";
            txtTimten.PlaceholderText = "Nhập vào tên nhân viên cần tìm";
            txtTimten.Size = new Size(205, 23);
            txtTimten.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.AutoSize = true;
            groupBox1.Controls.Add(cboChucVu);
            groupBox1.Controls.Add(dtpNgaySinh);
            groupBox1.Controls.Add(txtMaNV);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(txtHoLot);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtTen);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(radNam);
            groupBox1.Controls.Add(radNu);
            groupBox1.Controls.Add(label5);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(566, 126);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // cboChucVu
            // 
            cboChucVu.FormattingEnabled = true;
            cboChucVu.Location = new Point(309, 20);
            cboChucVu.Margin = new Padding(1);
            cboChucVu.Name = "cboChucVu";
            cboChucVu.Size = new Size(235, 23);
            cboChucVu.TabIndex = 6;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(309, 83);
            dtpNgaySinh.Margin = new Padding(1);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(235, 23);
            dtpNgaySinh.TabIndex = 2;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(81, 17);
            txtMaNV.Margin = new Padding(1);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(105, 23);
            txtMaNV.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 17);
            label1.Margin = new Padding(1, 0, 1, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Mã số";
            // 
            // txtHoLot
            // 
            txtHoLot.Location = new Point(81, 49);
            txtHoLot.Margin = new Padding(1);
            txtHoLot.Name = "txtHoLot";
            txtHoLot.Size = new Size(210, 23);
            txtHoLot.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 51);
            label2.Margin = new Padding(1, 0, 1, 0);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 0;
            label2.Text = "Họ tên";
            // 
            // txtTen
            // 
            txtTen.Location = new Point(309, 51);
            txtTen.Margin = new Padding(1);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(235, 23);
            txtTen.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 91);
            label3.Margin = new Padding(1, 0, 1, 0);
            label3.Name = "label3";
            label3.Size = new Size(23, 15);
            label3.TabIndex = 0;
            label3.Text = "Pái";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(240, 17);
            label4.Margin = new Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 0;
            label4.Text = "Chức vụ";
            // 
            // radNam
            // 
            radNam.AutoSize = true;
            radNam.Location = new Point(81, 87);
            radNam.Margin = new Padding(1);
            radNam.Name = "radNam";
            radNam.Size = new Size(51, 19);
            radNam.TabIndex = 5;
            radNam.TabStop = true;
            radNam.Text = "Nam";
            radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            radNu.AutoSize = true;
            radNu.Location = new Point(158, 87);
            radNu.Margin = new Padding(1);
            radNu.Name = "radNu";
            radNu.Size = new Size(41, 19);
            radNu.TabIndex = 5;
            radNu.TabStop = true;
            radNu.Text = "Nữ";
            radNu.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(240, 91);
            label5.Margin = new Padding(1, 0, 1, 0);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 0;
            label5.Text = "Ngày sinh";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(13, 20);
            btnThem.Margin = new Padding(1);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(77, 21);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(13, 53);
            btnXoa.Margin = new Padding(1);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(77, 21);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThoat
            // 
            btnThoat.Location = new Point(109, 83);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(75, 23);
            btnThoat.TabIndex = 7;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnHuy
            // 
            btnHuy.Location = new Point(109, 51);
            btnHuy.Name = "btnHuy";
            btnHuy.Size = new Size(75, 23);
            btnHuy.TabIndex = 7;
            btnHuy.Text = "Hủy";
            btnHuy.UseVisualStyleBackColor = true;
            btnHuy.Click += btnHuy_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(109, 20);
            btnSua.Margin = new Padding(1);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(77, 21);
            btnSua.TabIndex = 1;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnLuu
            // 
            btnLuu.Location = new Point(13, 86);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(77, 21);
            btnLuu.TabIndex = 7;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = true;
            btnLuu.Click += btnLuu_Click;
            // 
            // frm_dmNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(769, 388);
            Controls.Add(tableLayoutPanel1);
            Margin = new Padding(1);
            Name = "frm_dmNhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form2";
            WindowState = FormWindowState.Maximized;
            Load += frm_dmNhanVien_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dgvNhanVien;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TableLayoutPanel tableLayoutPanel1;
        private SplitContainer splitContainer1;
        private GroupBox groupBox1;
        private ComboBox cboChucVu;
        private DateTimePicker dtpNgaySinh;
        private TextBox txtMaNV;
        private Label label1;
        private TextBox txtHoLot;
        private Label label2;
        private TextBox txtTen;
        private Label label3;
        private Label label4;
        private RadioButton radNam;
        private RadioButton radNu;
        private Label label5;
        private Button btnThem;
        private Button btnXoa;
        private Button btnThoat;
        private Button btnHuy;
        private Button btnSua;
        private Button btnLuu;
        private GroupBox groupBox2;
        private Button btnTim;
        private TextBox txtTimten;
        private TextBox txtTimho;
    }
}