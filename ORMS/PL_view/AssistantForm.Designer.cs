namespace ORMS.PL_view
{
    partial class AssistantForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSupplier = new System.Windows.Forms.Button();
            this.buttonInventory = new System.Windows.Forms.Button();
            this.buttonInventoryReport = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSalesReport = new System.Windows.Forms.Button();
            this.buttonMenuReport = new System.Windows.Forms.Button();
            this.buttonPayroll = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(255, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.systemToolStripMenuItem.Text = "System";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.buttonSupplier);
            this.groupBox1.Controls.Add(this.buttonInventory);
            this.groupBox1.Location = new System.Drawing.Point(12, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(222, 119);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inventory";
            // 
            // buttonSupplier
            // 
            this.buttonSupplier.Location = new System.Drawing.Point(49, 74);
            this.buttonSupplier.Name = "buttonSupplier";
            this.buttonSupplier.Size = new System.Drawing.Size(149, 23);
            this.buttonSupplier.TabIndex = 10;
            this.buttonSupplier.Text = "Supplier Management";
            this.buttonSupplier.UseVisualStyleBackColor = true;
            this.buttonSupplier.Click += new System.EventHandler(this.ButtonSupplier_Click);
            // 
            // buttonInventory
            // 
            this.buttonInventory.Location = new System.Drawing.Point(49, 28);
            this.buttonInventory.Name = "buttonInventory";
            this.buttonInventory.Size = new System.Drawing.Size(149, 23);
            this.buttonInventory.TabIndex = 9;
            this.buttonInventory.Text = "Inventory Management";
            this.buttonInventory.UseVisualStyleBackColor = true;
            this.buttonInventory.Click += new System.EventHandler(this.ButtonInventory_Click);
            // 
            // buttonInventoryReport
            // 
            this.buttonInventoryReport.Location = new System.Drawing.Point(49, 70);
            this.buttonInventoryReport.Name = "buttonInventoryReport";
            this.buttonInventoryReport.Size = new System.Drawing.Size(149, 23);
            this.buttonInventoryReport.TabIndex = 10;
            this.buttonInventoryReport.Text = "Inventory report";
            this.buttonInventoryReport.UseVisualStyleBackColor = true;
            this.buttonInventoryReport.Click += new System.EventHandler(this.ButtonInventoryReport_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.buttonPayroll);
            this.groupBox2.Controls.Add(this.buttonSalesReport);
            this.groupBox2.Controls.Add(this.buttonInventoryReport);
            this.groupBox2.Controls.Add(this.buttonMenuReport);
            this.groupBox2.Location = new System.Drawing.Point(12, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 187);
            this.groupBox2.TabIndex = 28;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reports";
            // 
            // buttonSalesReport
            // 
            this.buttonSalesReport.Location = new System.Drawing.Point(49, 111);
            this.buttonSalesReport.Name = "buttonSalesReport";
            this.buttonSalesReport.Size = new System.Drawing.Size(149, 23);
            this.buttonSalesReport.TabIndex = 11;
            this.buttonSalesReport.Text = "Sale report";
            this.buttonSalesReport.UseVisualStyleBackColor = true;
            this.buttonSalesReport.Click += new System.EventHandler(this.ButtonSalesReport_Click);
            // 
            // buttonMenuReport
            // 
            this.buttonMenuReport.Location = new System.Drawing.Point(49, 32);
            this.buttonMenuReport.Name = "buttonMenuReport";
            this.buttonMenuReport.Size = new System.Drawing.Size(149, 23);
            this.buttonMenuReport.TabIndex = 9;
            this.buttonMenuReport.Text = "Menu report";
            this.buttonMenuReport.UseVisualStyleBackColor = true;
            this.buttonMenuReport.Click += new System.EventHandler(this.ButtonMenuReport_Click);
            // 
            // buttonPayroll
            // 
            this.buttonPayroll.Location = new System.Drawing.Point(49, 149);
            this.buttonPayroll.Name = "buttonPayroll";
            this.buttonPayroll.Size = new System.Drawing.Size(149, 23);
            this.buttonPayroll.TabIndex = 12;
            this.buttonPayroll.Text = "Payroll report";
            this.buttonPayroll.UseVisualStyleBackColor = true;
            this.buttonPayroll.Click += new System.EventHandler(this.ButtonPayroll_Click);
            // 
            // AssistantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 351);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "AssistantForm";
            this.Text = "AssistantForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonInventory;
        private System.Windows.Forms.Button buttonInventoryReport;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonMenuReport;
        private System.Windows.Forms.Button buttonSalesReport;
        private System.Windows.Forms.Button buttonSupplier;
        private System.Windows.Forms.Button buttonPayroll;
    }
}