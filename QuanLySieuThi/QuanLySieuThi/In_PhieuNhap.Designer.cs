namespace QuanLySieuThi
{
    partial class In_PhieuNhap
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
            this.In_PhieuNhapBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ThucTapCSDL2DataSet3 = new QuanLySieuThi.ThucTapCSDL2DataSet3();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.In_PhieuNhapTableAdapter = new QuanLySieuThi.ThucTapCSDL2DataSet3TableAdapters.In_PhieuNhapTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.In_PhieuNhapBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThucTapCSDL2DataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // In_PhieuNhapBindingSource
            // 
            this.In_PhieuNhapBindingSource.DataMember = "In_PhieuNhap";
            this.In_PhieuNhapBindingSource.DataSource = this.ThucTapCSDL2DataSet3;
            // 
            // ThucTapCSDL2DataSet3
            // 
            this.ThucTapCSDL2DataSet3.DataSetName = "ThucTapCSDL2DataSet3";
            this.ThucTapCSDL2DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.In_PhieuNhapBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLySieuThi.Report_NH.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 13);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(943, 599);
            this.reportViewer1.TabIndex = 0;
            // 
            // In_PhieuNhapTableAdapter
            // 
            this.In_PhieuNhapTableAdapter.ClearBeforeFill = true;
            // 
            // In_PhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 624);
            this.Controls.Add(this.reportViewer1);
            this.Name = "In_PhieuNhap";
            this.Text = "Phiếu nhập hàng";
            this.Load += new System.EventHandler(this.In_PhieuNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.In_PhieuNhapBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThucTapCSDL2DataSet3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource In_PhieuNhapBindingSource;
        private ThucTapCSDL2DataSet3 ThucTapCSDL2DataSet3;
        private ThucTapCSDL2DataSet3TableAdapters.In_PhieuNhapTableAdapter In_PhieuNhapTableAdapter;
    }
}