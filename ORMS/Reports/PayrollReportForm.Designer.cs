namespace ORMS.Reports
{
    partial class PayrollReportForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Report = new System.Windows.Forms.GroupBox();
            this.reportViewerPayroll = new Microsoft.Reporting.WinForms.ReportViewer();
            this.oRMSDataSet3 = new ORMS.ORMSDataSet3();
            this.payrollBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.payrollTableAdapter = new ORMS.ORMSDataSet3TableAdapters.PayrollTableAdapter();
            this.groupBox2.SuspendLayout();
            this.Report.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.oRMSDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.dateTimePicker1);
            this.groupBox2.Controls.Add(this.buttonSearch);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(500, 65);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Payroll";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(73, 20);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(284, 18);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 9;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Date";
            // 
            // Report
            // 
            this.Report.Controls.Add(this.reportViewerPayroll);
            this.Report.Location = new System.Drawing.Point(13, 84);
            this.Report.Name = "Report";
            this.Report.Size = new System.Drawing.Size(499, 354);
            this.Report.TabIndex = 29;
            this.Report.TabStop = false;
            this.Report.Text = "Report";
            // 
            // reportViewerPayroll
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.payrollBindingSource;
            this.reportViewerPayroll.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerPayroll.LocalReport.ReportEmbeddedResource = "ORMS.Reports.PayrollReport.rdlc";
            this.reportViewerPayroll.Location = new System.Drawing.Point(7, 20);
            this.reportViewerPayroll.Name = "reportViewerPayroll";
            this.reportViewerPayroll.ServerReport.BearerToken = null;
            this.reportViewerPayroll.Size = new System.Drawing.Size(486, 319);
            this.reportViewerPayroll.TabIndex = 0;
            // 
            // oRMSDataSet3
            // 
            this.oRMSDataSet3.DataSetName = "ORMSDataSet3";
            this.oRMSDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // payrollBindingSource
            // 
            this.payrollBindingSource.DataMember = "Payroll";
            this.payrollBindingSource.DataSource = this.oRMSDataSet3;
            // 
            // payrollTableAdapter
            // 
            this.payrollTableAdapter.ClearBeforeFill = true;
            // 
            // PayrollReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 450);
            this.Controls.Add(this.Report);
            this.Controls.Add(this.groupBox2);
            this.Name = "PayrollReportForm";
            this.Text = "PayrollReportForm";
            this.Load += new System.EventHandler(this.PayrollReportForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.Report.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.oRMSDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.payrollBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox Report;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerPayroll;
        private ORMSDataSet3 oRMSDataSet3;
        private System.Windows.Forms.BindingSource payrollBindingSource;
        private ORMSDataSet3TableAdapters.PayrollTableAdapter payrollTableAdapter;
    }
}