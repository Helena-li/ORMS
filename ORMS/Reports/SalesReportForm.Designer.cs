namespace ORMS.Reports
{
    partial class SalesReportForm
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
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oRMSDataSet2 = new ORMS.ORMSDataSet2();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reportViewerSales = new Microsoft.Reporting.WinForms.ReportViewer();
            this.invoiceTableAdapter = new ORMS.ORMSDataSet2TableAdapters.InvoiceTableAdapter();
            this.invoiceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRMSDataSet2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "Invoice";
            this.invoiceBindingSource.DataSource = this.oRMSDataSet2;
            // 
            // oRMSDataSet2
            // 
            this.oRMSDataSet2.DataSetName = "ORMSDataSet2";
            this.oRMSDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sales";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reportViewerSales);
            this.groupBox1.Location = new System.Drawing.Point(12, 84);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 354);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Report";
            // 
            // reportViewerSales
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.invoiceBindingSource2;
            this.reportViewerSales.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewerSales.LocalReport.ReportEmbeddedResource = "ORMS.Reports.SalesReport.rdlc";
            this.reportViewerSales.Location = new System.Drawing.Point(7, 20);
            this.reportViewerSales.Name = "reportViewerSales";
            this.reportViewerSales.ServerReport.BearerToken = null;
            this.reportViewerSales.Size = new System.Drawing.Size(487, 314);
            this.reportViewerSales.TabIndex = 0;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceBindingSource1
            // 
            this.invoiceBindingSource1.DataMember = "Invoice";
            this.invoiceBindingSource1.DataSource = this.oRMSDataSet2;
            // 
            // invoiceBindingSource2
            // 
            this.invoiceBindingSource2.DataMember = "Invoice";
            this.invoiceBindingSource2.DataSource = this.oRMSDataSet2;
            // 
            // SalesReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 446);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "SalesReportForm";
            this.Text = "SalesReportForm";
            this.Load += new System.EventHandler(this.SalesReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oRMSDataSet2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewerSales;
        private ORMSDataSet2 oRMSDataSet2;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private ORMSDataSet2TableAdapters.InvoiceTableAdapter invoiceTableAdapter;
        private System.Windows.Forms.BindingSource invoiceBindingSource1;
        private System.Windows.Forms.BindingSource invoiceBindingSource2;
    }
}