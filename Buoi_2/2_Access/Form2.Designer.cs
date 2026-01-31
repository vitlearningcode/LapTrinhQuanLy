namespace _2_Access
{
    partial class Form2
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
            label6 = new Label();
            radNam = new RadioButton();
            radNu = new RadioButton();
            cboChucVu = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(97, 41);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // btnThem
            // 
            btnThem.Location = new Point(1612, 55);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(188, 58);
            btnThem.TabIndex = 1;
            btnThem.Text = "button1";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(1024, 248);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(500, 47);
            dtpNgaySinh.TabIndex = 2;
            // 
            // dgvNhanVien
            // 
            dgvNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanVien.Dock = DockStyle.Bottom;
            dgvNhanVien.Location = new Point(0, 617);
            dgvNhanVien.Name = "dgvNhanVien";
            dgvNhanVien.RowHeadersWidth = 102;
            dgvNhanVien.Size = new Size(1888, 375);
            dgvNhanVien.TabIndex = 3;
            dgvNhanVien.CellClick += dgvNhanVien_CellClick;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(1612, 155);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(188, 58);
            btnSua.TabIndex = 1;
            btnSua.Text = "button1";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(1612, 257);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(188, 58);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "button1";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 86);
            label2.Name = "label2";
            label2.Size = new Size(97, 41);
            label2.TabIndex = 0;
            label2.Text = "label1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 164);
            label3.Name = "label3";
            label3.Size = new Size(97, 41);
            label3.TabIndex = 0;
            label3.Text = "label1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(863, 55);
            label4.Name = "label4";
            label4.Size = new Size(97, 41);
            label4.TabIndex = 0;
            label4.Text = "label1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(863, 253);
            label5.Name = "label5";
            label5.Size = new Size(97, 41);
            label5.TabIndex = 0;
            label5.Text = "label1";
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(180, 19);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(250, 47);
            txtMaNV.TabIndex = 4;
            // 
            // txtHoLot
            // 
            txtHoLot.Location = new Point(180, 86);
            txtHoLot.Name = "txtHoLot";
            txtHoLot.Size = new Size(250, 47);
            txtHoLot.TabIndex = 4;
            // 
            // txtTen
            // 
            txtTen.Location = new Point(1050, 141);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(250, 47);
            txtTen.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(863, 141);
            label6.Name = "label6";
            label6.Size = new Size(97, 41);
            label6.TabIndex = 0;
            label6.Text = "label1";
            // 
            // radNam
            // 
            radNam.AutoSize = true;
            radNam.Location = new Point(132, 168);
            radNam.Name = "radNam";
            radNam.Size = new Size(228, 45);
            radNam.TabIndex = 5;
            radNam.TabStop = true;
            radNam.Text = "radioButton1";
            radNam.UseVisualStyleBackColor = true;
            // 
            // radNu
            // 
            radNu.AutoSize = true;
            radNu.Location = new Point(388, 168);
            radNu.Name = "radNu";
            radNu.Size = new Size(228, 45);
            radNu.TabIndex = 5;
            radNu.TabStop = true;
            radNu.Text = "radioButton1";
            radNu.UseVisualStyleBackColor = true;
            // 
            // cboChucVu
            // 
            cboChucVu.FormattingEnabled = true;
            cboChucVu.Location = new Point(1024, 55);
            cboChucVu.Name = "cboChucVu";
            cboChucVu.Size = new Size(302, 49);
            cboChucVu.TabIndex = 6;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1888, 992);
            Controls.Add(cboChucVu);
            Controls.Add(radNu);
            Controls.Add(radNam);
            Controls.Add(txtTen);
            Controls.Add(txtHoLot);
            Controls.Add(txtMaNV);
            Controls.Add(dgvNhanVien);
            Controls.Add(dtpNgaySinh);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNhanVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label label6;
        private RadioButton radNam;
        private RadioButton radNu;
        private ComboBox cboChucVu;
    }
}