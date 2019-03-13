namespace QuanLySieuThi
{
    partial class InHoaDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InHoaDon));
            this.In_HoaDon2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ThucTapCSDL2DataSet = new QuanLySieuThi.ThucTapCSDL2DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.In_HoaDon2TableAdapter = new QuanLySieuThi.ThucTapCSDL2DataSetTableAdapters.In_HoaDon2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.In_HoaDon2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThucTapCSDL2DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // In_HoaDon2BindingSource
            // 
            this.In_HoaDon2BindingSource.DataMember = "In_HoaDon2";
            this.In_HoaDon2BindingSource.DataSource = this.ThucTapCSDL2DataSet;
            // 
            // ThucTapCSDL2DataSet
            // 
            this.ThucTapCSDL2DataSet.DataSetName = "ThucTapCSDL2DataSet";
            this.ThucTapCSDL2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.In_HoaDon2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLySieuThi.ReportHD.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 13);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1036, 774);
            this.reportViewer1.TabIndex = 0;
            this.reportViewer1.Load += new System.EventHandler(this.reportViewer1_Load);
            // 
            // In_HoaDon2TableAdapter
            // 
            this.In_HoaDon2TableAdapter.ClearBeforeFill = true;
            // 
            // InHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 825);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "InHoaDon";
            this.Text = "Phiếu hóa đơn";
            this.Load += new System.EventHandler(this.InHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.In_HoaDon2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThucTapCSDL2DataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource In_HoaDon2BindingSource;
        private ThucTapCSDL2DataSet ThucTapCSDL2DataSet;
        private ThucTapCSDL2DataSetTableAdapters.In_HoaDon2TableAdapter In_HoaDon2TableAdapter;
    }
}