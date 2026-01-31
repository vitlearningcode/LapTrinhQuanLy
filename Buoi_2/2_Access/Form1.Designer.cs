namespace _2_Access
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
            btnThem = new Button();
            dgvNv = new DataGridView();
            txt_manv = new TextBox();
            txt_ten = new TextBox();
            txt_heSo = new TextBox();
            btnSua = new Button();
            btnXoa = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvNv).BeginInit();
            SuspendLayout();
            // 
            // btnThem
            // 
            btnThem.Location = new Point(878, 45);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(188, 58);
            btnThem.TabIndex = 0;
            btnThem.Text = "button1";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // dgvNv
            // 
            dgvNv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNv.Location = new Point(337, 302);
            dgvNv.Name = "dgvNv";
            dgvNv.RowHeadersWidth = 102;
            dgvNv.Size = new Size(875, 375);
            dgvNv.TabIndex = 1;
            dgvNv.CellContentClick += dgvChucVu_CellClick;
            // 
            // txt_manv
            // 
            txt_manv.Location = new Point(550, 45);
            txt_manv.Name = "txt_manv";
            txt_manv.Size = new Size(250, 47);
            txt_manv.TabIndex = 2;
            // 
            // txt_ten
            // 
            txt_ten.Location = new Point(550, 116);
            txt_ten.Name = "txt_ten";
            txt_ten.Size = new Size(250, 47);
            txt_ten.TabIndex = 2;
            // 
            // txt_heSo
            // 
            txt_heSo.Location = new Point(550, 188);
            txt_heSo.Name = "txt_heSo";
            txt_heSo.Size = new Size(250, 47);
            txt_heSo.TabIndex = 2;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(878, 116);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(188, 58);
            btnSua.TabIndex = 0;
            btnSua.Text = "button1";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(878, 182);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(188, 58);
            btnXoa.TabIndex = 0;
            btnXoa.Text = "button1";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1389, 654);
            Controls.Add(txt_heSo);
            Controls.Add(txt_ten);
            Controls.Add(txt_manv);
            Controls.Add(dgvNv);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvNv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnThem;
        private DataGridView dgvNv;
        private TextBox txt_manv;
        private TextBox txt_ten;
        private TextBox txt_heSo;
        private Button btnSua;
        private Button btnXoa;
    }
}
