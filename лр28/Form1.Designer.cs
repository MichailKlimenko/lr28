
namespace лр28
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.reportViewer2 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ConsultationDBDataSet = new лр28.ConsultationDBDataSet();
            this.ConsultationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ConsultationsTableAdapter = new лр28.ConsultationDBDataSetTableAdapters.ConsultationsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultationDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultationsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // reportViewer2
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.ConsultationsBindingSource;
            this.reportViewer2.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer2.LocalReport.ReportEmbeddedResource = "лр28.Report1.rdlc";
            this.reportViewer2.Location = new System.Drawing.Point(12, 12);
            this.reportViewer2.Name = "reportViewer2";
            this.reportViewer2.ServerReport.BearerToken = null;
            this.reportViewer2.Size = new System.Drawing.Size(550, 321);
            this.reportViewer2.TabIndex = 0;
            // 
            // ConsultationDBDataSet
            // 
            this.ConsultationDBDataSet.DataSetName = "ConsultationDBDataSet";
            this.ConsultationDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ConsultationsBindingSource
            // 
            this.ConsultationsBindingSource.DataMember = "Consultations";
            this.ConsultationsBindingSource.DataSource = this.ConsultationDBDataSet;
            // 
            // ConsultationsTableAdapter
            // 
            this.ConsultationsTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 345);
            this.Controls.Add(this.reportViewer2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ConsultationDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultationsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer2;
        private System.Windows.Forms.BindingSource ConsultationsBindingSource;
        private ConsultationDBDataSet ConsultationDBDataSet;
        private ConsultationDBDataSetTableAdapters.ConsultationsTableAdapter ConsultationsTableAdapter;
    }
}

