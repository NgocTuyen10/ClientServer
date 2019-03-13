namespace QuanLySieuThi
{
    partial class In_PhieuXuat
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
            this.In_PhieuXuatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ThucTapCSDL2DataSet4 = new QuanLySieuThi.ThucTapCSDL2DataSet4();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.In_PhieuXuatTableAdapter = new QuanLySieuThi.ThucTapCSDL2DataSet4TableAdapters.In_PhieuXuatTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.In_PhieuXuatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThucTapCSDL2DataSet4)).BeginInit();
            this.SuspendLayout();
            // 
            // In_PhieuXuatBindingSource
            // 
            this.In_PhieuXuatBindingSource.DataMember = "In_PhieuXuat";
            this.In_PhieuXuatBindingSource.DataSource = this.ThucTapCSDL2DataSet4;
            // 
            // ThucTapCSDL2DataSet4
            // 
            this.ThucTapCSDL2DataSet4.DataSetName = "ThucTapCSDL2DataSet4";
            this.ThucTapCSDL2DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.In_PhieuXuatBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLySieuThi.Report_XH.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 13);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(888, 579);
            this.reportViewer1.TabIndex = 0;
            // 
            // In_PhieuXuatTableAdapter
            // 
            this.In_PhieuXuatTableAdapter.ClearBeforeFill = true;
            // 
            // In_PhieuXuat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 604);
            this.Controls.Add(this.reportViewer1);
            this.Name = "In_PhieuXuat";
            this.Text = "Phiếu xuất hàng";
            this.Load += new System.EventHandler(this.In_PhieuXuat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.In_PhieuXuatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThucTapCSDL2DataSet4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource In_PhieuXuatBindingSource;
        private ThucTapCSDL2DataSet4 ThucTapCSDL2DataSet4;
        private ThucTapCSDL2DataSet4TableAdapters.In_PhieuXuatTableAdapter In_PhieuXuatTableAdapter;
    }
}