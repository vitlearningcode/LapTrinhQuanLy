namespace PresentationLayer
{
    partial class frm_dmChucVu
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
            textBox1 = new TextBox();
            dgDSChucVu = new DataGridView();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgDSChucVu).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(170, 41);
            label1.TabIndex = 0;
            label1.Text = "Mã chức vụ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(193, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 47);
            textBox1.TabIndex = 1;
            // 
            // dgDSChucVu
            // 
            dgDSChucVu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDSChucVu.Dock = DockStyle.Bottom;
            dgDSChucVu.Location = new Point(0, 256);
            dgDSChucVu.Name = "dgDSChucVu";
            dgDSChucVu.RowHeadersWidth = 102;
            dgDSChucVu.Size = new Size(913, 300);
            dgDSChucVu.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(0, 59);
            label2.Name = "label2";
            label2.Size = new Size(174, 41);
            label2.TabIndex = 0;
            label2.Text = "Tên chức vụ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(0, 113);
            label3.Name = "label3";
            label3.Size = new Size(209, 41);
            label3.TabIndex = 0;
            label3.Text = "Hệ số phụ cấp";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(209, 65);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 47);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(226, 113);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 47);
            textBox3.TabIndex = 1;
            // 
            // frm_dmChucVu
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(913, 556);
            Controls.Add(dgDSChucVu);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frm_dmChucVu";
            Text = "Danh sách chức vụ";
            Load += frm_dmChucVu_Load;
            ((System.ComponentModel.ISupportInitialize)dgDSChucVu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private DataGridView dgDSChucVu;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox3;
    }
}