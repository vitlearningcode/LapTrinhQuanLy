namespace PresentationLayer
{
    partial class frm_dmQuaTrinhLuong
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            dtpTuNgay = new DateTimePicker();
            radDenHienTai = new RadioButton();
            radDenNgay = new RadioButton();
            btnTim = new Button();
            dtpDenNgay = new DateTimePicker();
            dgvQuaTrinhLuong = new DataGridView();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQuaTrinhLuong).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(dtpTuNgay);
            groupBox1.Controls.Add(radDenHienTai);
            groupBox1.Controls.Add(radDenNgay);
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(767, 100);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 43);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Location = new Point(137, 43);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(109, 23);
            dtpTuNgay.TabIndex = 4;
            // 
            // radDenHienTai
            // 
            radDenHienTai.AutoSize = true;
            radDenHienTai.Location = new Point(278, 47);
            radDenHienTai.Name = "radDenHienTai";
            radDenHienTai.Size = new Size(88, 19);
            radDenHienTai.TabIndex = 3;
            radDenHienTai.TabStop = true;
            radDenHienTai.Text = "Đến hiện tại";
            radDenHienTai.UseVisualStyleBackColor = true;
            radDenHienTai.CheckedChanged += radDenHienTai_CheckedChanged;
            // 
            // radDenNgay
            // 
            radDenNgay.AutoSize = true;
            radDenNgay.Location = new Point(391, 47);
            radDenNgay.Name = "radDenNgay";
            radDenNgay.Size = new Size(105, 19);
            radDenNgay.TabIndex = 3;
            radDenNgay.TabStop = true;
            radDenNgay.Text = "Hoặc đến ngày";
            radDenNgay.UseVisualStyleBackColor = true;
            radDenNgay.CheckedChanged += radDenHienTai_CheckedChanged;
            // 
            // btnTim
            // 
            btnTim.Location = new Point(664, 47);
            btnTim.Name = "btnTim";
            btnTim.Size = new Size(75, 23);
            btnTim.TabIndex = 0;
            btnTim.Text = "Tìm";
            btnTim.UseVisualStyleBackColor = true;
            btnTim.Click += btnTim_Click;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Location = new Point(504, 43);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(109, 23);
            dtpDenNgay.TabIndex = 4;
            // 
            // dgvQuaTrinhLuong
            // 
            dgvQuaTrinhLuong.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvQuaTrinhLuong.Location = new Point(43, 259);
            dgvQuaTrinhLuong.Name = "dgvQuaTrinhLuong";
            dgvQuaTrinhLuong.Size = new Size(724, 150);
            dgvQuaTrinhLuong.TabIndex = 5;
            // 
            // frm_dmQuaTrinhLuong
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnTim);
            Controls.Add(dtpDenNgay);
            Controls.Add(dgvQuaTrinhLuong);
            Controls.Add(groupBox1);
            Name = "frm_dmQuaTrinhLuong";
            Text = "frm_dmQuaTrinhLuong";
            Load += frm_dmQuaTrinhLuong_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvQuaTrinhLuong).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label label1;
        private DateTimePicker dtpTuNgay;
        private RadioButton radDenNgay;
        private Button btnTim;
        private DateTimePicker dtpDenNgay;
        private DataGridView dgvQuaTrinhLuong;
        private RadioButton radDenHienTai;
    }
}