namespace demo_connect_ADO.NET
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dgvSinhVien = new DataGridView();
            btnKetNoi = new Button();
            txtMaSV = new TextBox();
            txtHoTen = new TextBox();
            txtLop = new TextBox();
            txtDiemTB = new TextBox();
            btnTaiDuLieubtnTaiDuLieu = new Button();
            btnThembtnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).BeginInit();
            SuspendLayout();
            // 
            // dgvSinhVien
            // 
            dgvSinhVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSinhVien.Location = new Point(0, 0);
            dgvSinhVien.Name = "dgvSinhVien";
            dgvSinhVien.RowHeadersWidth = 102;
            dgvSinhVien.Size = new Size(1724, 464);
            dgvSinhVien.TabIndex = 0;
            // 
            // btnKetNoi
            // 
            btnKetNoi.Location = new Point(52, 510);
            btnKetNoi.Name = "btnKetNoi";
            btnKetNoi.Size = new Size(188, 58);
            btnKetNoi.TabIndex = 1;
            btnKetNoi.Text = "button1";
            btnKetNoi.UseVisualStyleBackColor = true;
            btnKetNoi.Click += btnKetNoi_Click;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(360, 516);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(188, 47);
            txtMaSV.TabIndex = 2;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(668, 516);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(188, 47);
            txtHoTen.TabIndex = 2;
            // 
            // txtLop
            // 
            txtLop.Location = new Point(976, 516);
            txtLop.Name = "txtLop";
            txtLop.Size = new Size(188, 47);
            txtLop.TabIndex = 2;
            // 
            // txtDiemTB
            // 
            txtDiemTB.Location = new Point(1284, 516);
            txtDiemTB.Name = "txtDiemTB";
            txtDiemTB.Size = new Size(188, 47);
            txtDiemTB.TabIndex = 2;
            // 
            // btnTaiDuLieubtnTaiDuLieu
            // 
            btnTaiDuLieubtnTaiDuLieu.Location = new Point(37, 651);
            btnTaiDuLieubtnTaiDuLieu.Name = "btnTaiDuLieubtnTaiDuLieu";
            btnTaiDuLieubtnTaiDuLieu.Size = new Size(188, 58);
            btnTaiDuLieubtnTaiDuLieu.TabIndex = 1;
            btnTaiDuLieubtnTaiDuLieu.Text = "tai";
            btnTaiDuLieubtnTaiDuLieu.UseVisualStyleBackColor = true;
            btnTaiDuLieubtnTaiDuLieu.Click += btnKetNoi_Click;
            // 
            // btnThembtnThem
            // 
            btnThembtnThem.Location = new Point(256, 651);
            btnThembtnThem.Name = "btnThembtnThem";
            btnThembtnThem.Size = new Size(188, 58);
            btnThembtnThem.TabIndex = 1;
            btnThembtnThem.Text = "tehm";
            btnThembtnThem.UseVisualStyleBackColor = true;
            btnThembtnThem.Click += btnKetNoi_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(475, 651);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(188, 58);
            btnSua.TabIndex = 1;
            btnSua.Text = "sua";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnKetNoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(694, 651);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(188, 58);
            btnXoa.TabIndex = 1;
            btnXoa.Text = "button1";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnKetNoi_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1888, 992);
            Controls.Add(txtDiemTB);
            Controls.Add(txtLop);
            Controls.Add(txtHoTen);
            Controls.Add(txtMaSV);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThembtnThem);
            Controls.Add(btnTaiDuLieubtnTaiDuLieu);
            Controls.Add(btnKetNoi);
            Controls.Add(dgvSinhVien);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSinhVien).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvSinhVien;
        private Button btnKetNoi;
        private TextBox txtMaSV;
        private TextBox txtHoTen;
        private TextBox txtLop;
        private TextBox txtDiemTB;
        private Button btnTaiDuLieubtnTaiDuLieu;
        private Button btnThembtnThem;
        private Button btnSua;
        private Button btnXoa;
    }
}
