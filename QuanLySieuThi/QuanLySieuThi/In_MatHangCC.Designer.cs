namespace QuanLySieuThi
{
    partial class In_MatHangCC
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
            this.In_MatHangCCBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ThucTapCSDL2DataSet2 = new QuanLySieuThi.ThucTapCSDL2DataSet2();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.In_MatHangCCTableAdapter = new QuanLySieuThi.ThucTapCSDL2DataSet2TableAdapters.In_MatHangCCTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.In_MatHangCCBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThucTapCSDL2DataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // In_MatHangCCBindingSource
            // 
            this.In_MatHangCCBindingSource.DataMember = "In_MatHangCC";
            this.In_MatHangCCBindingSource.DataSource = this.ThucTapCSDL2DataSet2;
            // 
            // ThucTapCSDL2DataSet2
            // 
            this.ThucTapCSDL2DataSet2.DataSetName = "ThucTapCSDL2DataSet2";
            this.ThucTapCSDL2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.In_MatHangCCBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLySieuThi.ReportNCC.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(13, 13);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(1085, 576);
            this.reportViewer1.TabIndex = 0;
            // 
            // In_MatHangCCTableAdapter
            // 
            this.In_MatHangCCTableAdapter.ClearBeforeFill = true;
            // 
            // In_MatHangCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 601);
            this.Controls.Add(this.reportViewer1);
            this.Name = "In_MatHangCC";
            this.Text = "Mặt hàng cung cấp";
            this.Load += new System.EventHandler(this.In_MatHangCC_Load);
            ((System.ComponentModel.ISupportInitialize)(this.In_MatHangCCBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ThucTapCSDL2DataSet2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource In_MatHangCCBindingSource;
        private ThucTapCSDL2DataSet2 ThucTapCSDL2DataSet2;
        private ThucTapCSDL2DataSet2TableAdapters.In_MatHangCCTableAdapter In_MatHangCCTableAdapter;
    }
}