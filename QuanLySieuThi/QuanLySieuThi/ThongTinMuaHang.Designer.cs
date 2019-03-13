namespace QuanLySieuThi
{
    partial class ThongTinMuaHang
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
            this.ThucTapCSDL2DataSet1 = new QuanLySieuThi.ThucTapCSDL2DataSet1();
            this.In_ThongTinMuaHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.In_ThongTinMuaHangTableAdapter = new QuanLySieuThi.ThucTapCSDL2DataSet1TableAdapters.In_ThongTinMuaHangTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ThucTapCSDL2DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.In_ThongTinMuaHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.In_ThongTinMuaHangBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLySieuThi.Report_KH.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(12, 12);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1140, 482);
            this.reportViewer1.TabIndex = 0;
            // 
            // ThucTapCSDL2DataSet1
            // 
            this.ThucTapCSDL2DataSet1.DataSetName = "ThucTapCSDL2DataSet1";
            this.ThucTapCSDL2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // In_ThongTinMuaHangBindingSource
            // 
            this.In_ThongTinMuaHangBindingSource.DataMember = "In_ThongTinMuaHang";
            this.In_ThongTinMuaHangBindingSource.DataSource = this.ThucTapCSDL2DataSet1;
            // 
            // In_ThongTinMuaHangTableAdapter
            // 
            this.In_ThongTinMuaHangTableAdapter.ClearBeforeFill = true;
            // 
            // ThongTinMuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 506);
            this.Controls.Add(this.reportViewer1);
            this.Name = "ThongTinMuaHang";
            this.Text = "ThongTinMuaHang";
            this.Load += new System.EventHandler(this.ThongTinMuaHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ThucTapCSDL2DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.In_ThongTinMuaHangBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource In_ThongTinMuaHangBindingSource;
        private ThucTapCSDL2DataSet1 ThucTapCSDL2DataSet1;
        private ThucTapCSDL2DataSet1TableAdapters.In_ThongTinMuaHangTableAdapter In_ThongTinMuaHangTableAdapter;
    }
}