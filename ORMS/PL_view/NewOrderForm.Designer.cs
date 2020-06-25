namespace ORMS.PL_view
{
    partial class NewOrderForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonStartOrder = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.textBoxOrderItemID = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.textBoxDish = new System.Windows.Forms.TextBox();
            this.MenuListGridView = new System.Windows.Forms.DataGridView();
            this.textBoxMenuID = new System.Windows.Forms.TextBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonSaveTable = new System.Windows.Forms.Button();
            this.buttonSetTable = new System.Windows.Forms.Button();
            this.TableStatusTextBox = new System.Windows.Forms.TextBox();
            this.tableIDTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.OderListGridView = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuListGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OderListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.buttonStartOrder);
            this.groupBox1.Location = new System.Drawing.Point(230, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(191, 128);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Functions";
            // 
            // buttonStartOrder
            // 
            this.buttonStartOrder.Location = new System.Drawing.Point(12, 40);
            this.buttonStartOrder.Name = "buttonStartOrder";
            this.buttonStartOrder.Size = new System.Drawing.Size(173, 23);
            this.buttonStartOrder.TabIndex = 27;
            this.buttonStartOrder.Text = "Start order";
            this.buttonStartOrder.UseVisualStyleBackColor = true;
            this.buttonStartOrder.Click += new System.EventHandler(this.ButtonStartOrder_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(299, 16);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 26;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(299, 56);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 23);
            this.updateButton.TabIndex = 25;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(218, 56);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 24;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonADD_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.deleteButton);
            this.groupBox3.Controls.Add(this.textBoxOrderItemID);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.updateButton);
            this.groupBox3.Controls.Add(this.textBoxQuantity);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.buttonReset);
            this.groupBox3.Controls.Add(this.textBoxDish);
            this.groupBox3.Controls.Add(this.buttonAdd);
            this.groupBox3.Controls.Add(this.MenuListGridView);
            this.groupBox3.Controls.Add(this.textBoxMenuID);
            this.groupBox3.Controls.Add(this.buttonSearch);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(12, 172);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(409, 424);
            this.groupBox3.TabIndex = 27;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Memu list";
            // 
            // textBoxOrderItemID
            // 
            this.textBoxOrderItemID.Location = new System.Drawing.Point(99, 16);
            this.textBoxOrderItemID.Name = "textBoxOrderItemID";
            this.textBoxOrderItemID.Size = new System.Drawing.Size(100, 20);
            this.textBoxOrderItemID.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Order item ID";
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(99, 107);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantity.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Quantity";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(218, 93);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 10;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // textBoxDish
            // 
            this.textBoxDish.Location = new System.Drawing.Point(100, 78);
            this.textBoxDish.Name = "textBoxDish";
            this.textBoxDish.Size = new System.Drawing.Size(100, 20);
            this.textBoxDish.TabIndex = 14;
            // 
            // MenuListGridView
            // 
            this.MenuListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MenuListGridView.Location = new System.Drawing.Point(6, 139);
            this.MenuListGridView.Name = "MenuListGridView";
            this.MenuListGridView.Size = new System.Drawing.Size(397, 267);
            this.MenuListGridView.TabIndex = 9;
            this.MenuListGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.MenuListGridView_RowHeaderMouseClick);
            // 
            // textBoxMenuID
            // 
            this.textBoxMenuID.Location = new System.Drawing.Point(99, 47);
            this.textBoxMenuID.Name = "textBoxMenuID";
            this.textBoxMenuID.Size = new System.Drawing.Size(100, 20);
            this.textBoxMenuID.TabIndex = 13;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(218, 16);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 9;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ButtonSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Dish Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Menu ID";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.buttonSaveTable);
            this.groupBox2.Controls.Add(this.buttonSetTable);
            this.groupBox2.Controls.Add(this.TableStatusTextBox);
            this.groupBox2.Controls.Add(this.tableIDTextBox);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 128);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Table Information";
            // 
            // buttonSaveTable
            // 
            this.buttonSaveTable.Location = new System.Drawing.Point(119, 99);
            this.buttonSaveTable.Name = "buttonSaveTable";
            this.buttonSaveTable.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveTable.TabIndex = 29;
            this.buttonSaveTable.Text = "Save table";
            this.buttonSaveTable.UseVisualStyleBackColor = true;
            this.buttonSaveTable.Click += new System.EventHandler(this.ButtonSaveTable_Click);
            // 
            // buttonSetTable
            // 
            this.buttonSetTable.Location = new System.Drawing.Point(25, 99);
            this.buttonSetTable.Name = "buttonSetTable";
            this.buttonSetTable.Size = new System.Drawing.Size(75, 23);
            this.buttonSetTable.TabIndex = 28;
            this.buttonSetTable.Text = "Set table";
            this.buttonSetTable.UseVisualStyleBackColor = true;
            this.buttonSetTable.Click += new System.EventHandler(this.ButtonSetTable_Click);
            // 
            // TableStatusTextBox
            // 
            this.TableStatusTextBox.Location = new System.Drawing.Point(94, 60);
            this.TableStatusTextBox.Name = "TableStatusTextBox";
            this.TableStatusTextBox.Size = new System.Drawing.Size(100, 20);
            this.TableStatusTextBox.TabIndex = 8;
            // 
            // tableIDTextBox
            // 
            this.tableIDTextBox.Location = new System.Drawing.Point(94, 27);
            this.tableIDTextBox.Name = "tableIDTextBox";
            this.tableIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.tableIDTextBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 63);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Table Status";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Table ID";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.OderListGridView);
            this.groupBox4.Location = new System.Drawing.Point(421, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(492, 566);
            this.groupBox4.TabIndex = 29;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Order list";
            // 
            // OderListGridView
            // 
            this.OderListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OderListGridView.Location = new System.Drawing.Point(6, 19);
            this.OderListGridView.Name = "OderListGridView";
            this.OderListGridView.Size = new System.Drawing.Size(474, 545);
            this.OderListGridView.TabIndex = 9;
            this.OderListGridView.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OderListGridView_RowHeaderMouseClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label7.Location = new System.Drawing.Point(13, 147);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "The uper functions only for new order.";
            // 
            // label8
            // 
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(9, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 40);
            this.label8.TabIndex = 28;
            this.label8.Text = "Please click the button befor a new order!";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NewOrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 608);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "NewOrderForm";
            this.Text = "NewOrderForm";
            this.Load += new System.EventHandler(this.NewOrderForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MenuListGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OderListGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.TextBox textBoxDish;
        private System.Windows.Forms.DataGridView MenuListGridView;
        private System.Windows.Forms.TextBox textBoxMenuID;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TableStatusTextBox;
        private System.Windows.Forms.TextBox tableIDTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonStartOrder;
        private System.Windows.Forms.Button buttonSetTable;
        private System.Windows.Forms.Button buttonSaveTable;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView OderListGridView;
        private System.Windows.Forms.TextBox textBoxOrderItemID;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}