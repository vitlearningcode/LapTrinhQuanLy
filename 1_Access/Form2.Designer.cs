namespace _1_Access
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
            dgDSNhanVien = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgDSNhanVien).BeginInit();
            SuspendLayout();
            // 
            // dgDSNhanVien
            // 
            dgDSNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgDSNhanVien.Location = new Point(0, 0);
            dgDSNhanVien.Name = "dgDSNhanVien";
            dgDSNhanVien.RowHeadersWidth = 102;
            dgDSNhanVien.Size = new Size(600, 375);
            dgDSNhanVien.TabIndex = 0;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgDSNhanVien);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)dgDSNhanVien).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgDSNhanVien;
    }
}