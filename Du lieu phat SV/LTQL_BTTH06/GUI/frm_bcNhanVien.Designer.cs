namespace GUI
{
    partial class frm_bcNhanVien
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.NhanVien_DTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.QLNVDataSet = new GUI.QLNVDataSet();
            this.nhanvienBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nhanvienTableAdapter = new GUI.QLNVDataSetTableAdapters.nhanvienTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.NhanVien_DTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLNVDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.nhanvienBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "GUI.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 30);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(635, 254);
            this.reportViewer1.TabIndex = 0;
            // 
            // NhanVien_DTOBindingSource
            // 
            this.NhanVien_DTOBindingSource.DataSource = typeof(DTO.NhanVien_DTO);
            // 
            // QLNVDataSet
            // 
            this.QLNVDataSet.DataSetName = "QLNVDataSet";
            this.QLNVDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanvienBindingSource
            // 
            this.nhanvienBindingSource.DataMember = "nhanvien";
            this.nhanvienBindingSource.DataSource = this.QLNVDataSet;
            // 
            // nhanvienTableAdapter
            // 
            this.nhanvienTableAdapter.ClearBeforeFill = true;
            // 
            // frm_bcNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 322);
            this.Controls.Add(this.reportViewer1);
            this.Name = "frm_bcNhanVien";
            this.Text = "frm_bcNhanVien";
            this.Load += new System.EventHandler(this.frm_bcNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NhanVien_DTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QLNVDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nhanvienBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource NhanVien_DTOBindingSource;
        private System.Windows.Forms.BindingSource nhanvienBindingSource;
        private QLNVDataSet QLNVDataSet;
        private QLNVDataSetTableAdapters.nhanvienTableAdapter nhanvienTableAdapter;
    }
}