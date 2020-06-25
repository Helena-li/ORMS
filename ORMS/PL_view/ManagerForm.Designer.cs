namespace ORMS.PL_view
{
    partial class ManagerForm
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
            this.buttonOrdermanage = new System.Windows.Forms.Button();
            this.buttonMenu = new System.Windows.Forms.Button();
            this.buttonEandP = new System.Windows.Forms.Button();
            this.buttonInventory = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSaleReport = new System.Windows.Forms.Button();
            this.buttonInventoryReport = new System.Windows.Forms.Button();
            this.buttonMenuReport = new System.Windows.Forms.Button();
            this.buttonSupplier = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonPayrollReport = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonOrdermanage
            // 
            this.buttonOrdermanage.Location = new System.Drawing.Point(19, 32);
            this.buttonOrdermanage.Name = "buttonOrdermanage";
            this.buttonOrdermanage.Size = new System.Drawing.Size(153, 23);
            this.buttonOrdermanage.TabIndex = 0;
            this.buttonOrdermanage.Text = "Order management";
            this.buttonOrdermanage.UseVisualStyleBackColor = true;
            this.buttonOrdermanage.Click += new System.EventHandler(this.ButtonOrdermanage_Click);
            // 
            // buttonMenu
            // 
            this.buttonMenu.Location = new System.Drawing.Point(19, 70);
            this.buttonMenu.Name = "buttonMenu";
            this.buttonMenu.Size = new System.Drawing.Size(153, 23);
            this.buttonMenu.TabIndex = 1;
            this.buttonMenu.Text = "Menu management";
            this.buttonMenu.UseVisualStyleBackColor = true;
            this.buttonMenu.Click += new System.EventHandler(this.ButtonMenu_Click);
            // 
            // buttonEandP
            // 
            this.buttonEandP.Location = new System.Drawing.Point(19, 57);
            this.buttonEandP.Name = "buttonEandP";
            this.buttonEandP.Size = new System.Drawing.Size(153, 48);
            this.buttonEandP.TabIndex = 2;
            this.buttonEandP.Text = "Employee and Payroll management";
            this.buttonEandP.UseVisualStyleBackColor = true;
            this.buttonEandP.Click += new System.EventHandler(this.ButtonEandP_Click);
            // 
            // buttonInventory
            // 
            this.buttonInventory.Location = new System.Drawing.Point(49, 32);
            this.buttonInventory.Name = "buttonInventory";
            this.buttonInventory.Size = new System.Drawing.Size(149, 23);
            this.buttonInventory.TabIndex = 3;
            this.buttonInventory.Text = "Inventory management";
            this.buttonInventory.UseVisualStyleBackColor = true;
            this.buttonInventory.Click += new System.EventHandler(this.ButtonInventory_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.buttonPayrollReport);
            this.groupBox2.Controls.Add(this.buttonSaleReport);
            this.groupBox2.Controls.Add(this.buttonInventoryReport);
            this.groupBox2.Controls.Add(this.buttonMenuReport);
            this.groupBox2.Location = new System.Drawing.Point(220, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(226, 175);
            this.groupBox2.TabIndex = 29;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reports";
            // 
            // buttonSaleReport
            // 
            this.buttonSaleReport.Location = new System.Drawing.Point(49, 99);
            this.buttonSaleReport.Name = "buttonSaleReport";
            this.buttonSaleReport.Size = new System.Drawing.Size(149, 23);
            this.buttonSaleReport.TabIndex = 11;
            this.buttonSaleReport.Text = "Sale report";
            this.buttonSaleReport.UseVisualStyleBackColor = true;
            this.buttonSaleReport.Click += new System.EventHandler(this.ButtonSaleReport_Click);
            // 
            // buttonInventoryReport
            // 
            this.buttonInventoryReport.Location = new System.Drawing.Point(49, 61);
            this.buttonInventoryReport.Name = "buttonInventoryReport";
            this.buttonInventoryReport.Size = new System.Drawing.Size(149, 23);
            this.buttonInventoryReport.TabIndex = 10;
            this.buttonInventoryReport.Text = "Inventory report";
            this.buttonInventoryReport.UseVisualStyleBackColor = true;
            this.buttonInventoryReport.Click += new System.EventHandler(this.ButtonInventoryReport_Click);
            // 
            // buttonMenuReport
            // 
            this.buttonMenuReport.Location = new System.Drawing.Point(49, 19);
            this.buttonMenuReport.Name = "buttonMenuReport";
            this.buttonMenuReport.Size = new System.Drawing.Size(149, 23);
            this.buttonMenuReport.TabIndex = 9;
            this.buttonMenuReport.Text = "Menu report";
            this.buttonMenuReport.UseVisualStyleBackColor = true;
            this.buttonMenuReport.Click += new System.EventHandler(this.ButtonMenuReport_Click);
            // 
            // buttonSupplier
            // 
            this.buttonSupplier.Location = new System.Drawing.Point(49, 70);
            this.buttonSupplier.Name = "buttonSupplier";
            this.buttonSupplier.Size = new System.Drawing.Size(149, 23);
            this.buttonSupplier.TabIndex = 30;
            this.buttonSupplier.Text = "Supplier Management";
            this.buttonSupplier.UseVisualStyleBackColor = true;
            this.buttonSupplier.Click += new System.EventHandler(this.ButtonSupplier_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.buttonOrdermanage);
            this.groupBox1.Controls.Add(this.buttonMenu);
            this.groupBox1.Location = new System.Drawing.Point(12, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 118);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Menu and Order management";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox3.Controls.Add(this.buttonInventory);
            this.groupBox3.Controls.Add(this.buttonSupplier);
            this.groupBox3.Location = new System.Drawing.Point(220, 37);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(226, 118);
            this.groupBox3.TabIndex = 32;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Inventory management";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox4.Controls.Add(this.buttonEandP);
            this.groupBox4.Location = new System.Drawing.Point(12, 161);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 175);
            this.groupBox4.TabIndex = 33;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Human Resource Management";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.systemToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(462, 24);
            this.menuStrip1.TabIndex = 34;
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
            // buttonPayrollReport
            // 
            this.buttonPayrollReport.Location = new System.Drawing.Point(49, 140);
            this.buttonPayrollReport.Name = "buttonPayrollReport";
            this.buttonPayrollReport.Size = new System.Drawing.Size(149, 23);
            this.buttonPayrollReport.TabIndex = 12;
            this.buttonPayrollReport.Text = "Payroll report";
            this.buttonPayrollReport.UseVisualStyleBackColor = true;
            this.buttonPayrollReport.Click += new System.EventHandler(this.ButtonPayrollReport_Click);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 354);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "ManagerForm";
            this.Text = "ManagerForm";
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOrdermanage;
        private System.Windows.Forms.Button buttonMenu;
        private System.Windows.Forms.Button buttonEandP;
        private System.Windows.Forms.Button buttonInventory;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonSaleReport;
        private System.Windows.Forms.Button buttonInventoryReport;
        private System.Windows.Forms.Button buttonMenuReport;
        private System.Windows.Forms.Button buttonSupplier;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem systemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button buttonPayrollReport;
    }
}