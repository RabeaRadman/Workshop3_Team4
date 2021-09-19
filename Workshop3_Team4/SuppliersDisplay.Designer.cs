
namespace Workshop3_Team4
{
    partial class SuppliersDisplayFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuppliersDisplayFrm));
            this.PSDGrid = new System.Windows.Forms.DataGridView();
            this.lblPS = new System.Windows.Forms.Label();
            this.supplierDGrid = new System.Windows.Forms.DataGridView();
            this.SupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSupplier = new System.Windows.Forms.Label();
            this.addProdCombBx = new System.Windows.Forms.ComboBox();
            this.addProdBtn = new System.Windows.Forms.Button();
            this.prodLbl = new System.Windows.Forms.Label();
            this.addsuplier = new System.Windows.Forms.Button();
            this.supplierEditBtn = new System.Windows.Forms.Button();
            this.supplierDelBtn = new System.Windows.Forms.Button();
            this.deleteProdBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PSDGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PSDGrid
            // 
            this.PSDGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PSDGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.PSDGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PSDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PSDGrid.Location = new System.Drawing.Point(25, 525);
            this.PSDGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PSDGrid.Name = "PSDGrid";
            this.PSDGrid.RowHeadersWidth = 51;
            this.PSDGrid.RowTemplate.Height = 25;
            this.PSDGrid.Size = new System.Drawing.Size(563, 289);
            this.PSDGrid.TabIndex = 7;
            // 
            // lblPS
            // 
            this.lblPS.AutoSize = true;
            this.lblPS.Location = new System.Drawing.Point(25, 501);
            this.lblPS.Name = "lblPS";
            this.lblPS.Size = new System.Drawing.Size(119, 20);
            this.lblPS.TabIndex = 6;
            this.lblPS.Text = "Product Supplier";
            // 
            // supplierDGrid
            // 
            this.supplierDGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.supplierDGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.supplierDGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.supplierDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supplierDGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplierId,
            this.SupName});
            this.supplierDGrid.Location = new System.Drawing.Point(25, 88);
            this.supplierDGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.supplierDGrid.Name = "supplierDGrid";
            this.supplierDGrid.RowHeadersWidth = 51;
            this.supplierDGrid.RowTemplate.Height = 25;
            this.supplierDGrid.Size = new System.Drawing.Size(563, 397);
            this.supplierDGrid.TabIndex = 5;
            this.supplierDGrid.SelectionChanged += new System.EventHandler(this.supplierDGrid_SelectionChanged);
            // 
            // SupplierId
            // 
            this.SupplierId.DataPropertyName = "SupplierId";
            this.SupplierId.HeaderText = "Supplier ID";
            this.SupplierId.MinimumWidth = 6;
            this.SupplierId.Name = "SupplierId";
            this.SupplierId.Width = 125;
            // 
            // SupName
            // 
            this.SupName.DataPropertyName = "SupName";
            this.SupName.HeaderText = "Supplier Name";
            this.SupName.MinimumWidth = 6;
            this.SupName.Name = "SupName";
            this.SupName.Width = 137;
            // 
            // lblSupplier
            // 
            this.lblSupplier.AutoSize = true;
            this.lblSupplier.Location = new System.Drawing.Point(25, 64);
            this.lblSupplier.Name = "lblSupplier";
            this.lblSupplier.Size = new System.Drawing.Size(70, 20);
            this.lblSupplier.TabIndex = 4;
            this.lblSupplier.Text = "Suppliers";
            // 
            // addProdCombBx
            // 
            this.addProdCombBx.AccessibleDescription = "";
            this.addProdCombBx.AccessibleName = "";
            this.addProdCombBx.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.addProdCombBx.FormattingEnabled = true;
            this.addProdCombBx.Location = new System.Drawing.Point(621, 525);
            this.addProdCombBx.Name = "addProdCombBx";
            this.addProdCombBx.Size = new System.Drawing.Size(185, 28);
            this.addProdCombBx.TabIndex = 8;
            this.addProdCombBx.Tag = "Selecting Product";
            // 
            // addProdBtn
            // 
            this.addProdBtn.Location = new System.Drawing.Point(621, 604);
            this.addProdBtn.Name = "addProdBtn";
            this.addProdBtn.Size = new System.Drawing.Size(184, 43);
            this.addProdBtn.TabIndex = 9;
            this.addProdBtn.Text = "Add Product Supplier";
            this.addProdBtn.UseVisualStyleBackColor = true;
            this.addProdBtn.Click += new System.EventHandler(this.addProdBtn_Click);
            // 
            // prodLbl
            // 
            this.prodLbl.AutoSize = true;
            this.prodLbl.Location = new System.Drawing.Point(621, 501);
            this.prodLbl.Name = "prodLbl";
            this.prodLbl.Size = new System.Drawing.Size(66, 20);
            this.prodLbl.TabIndex = 10;
            this.prodLbl.Text = "Products";
            // 
            // addsuplier
            // 
            this.addsuplier.Location = new System.Drawing.Point(621, 88);
            this.addsuplier.Name = "addsuplier";
            this.addsuplier.Size = new System.Drawing.Size(160, 43);
            this.addsuplier.TabIndex = 12;
            this.addsuplier.Text = "Add Supplier";
            this.addsuplier.UseVisualStyleBackColor = true;
            this.addsuplier.Click += new System.EventHandler(this.addsuplier_Click);
            // 
            // supplierEditBtn
            // 
            this.supplierEditBtn.Location = new System.Drawing.Point(621, 165);
            this.supplierEditBtn.Name = "supplierEditBtn";
            this.supplierEditBtn.Size = new System.Drawing.Size(160, 43);
            this.supplierEditBtn.TabIndex = 12;
            this.supplierEditBtn.Text = "Edit Supplier";
            this.supplierEditBtn.UseVisualStyleBackColor = true;
            this.supplierEditBtn.Click += new System.EventHandler(this.supplierEditBtn_Click);
            // 
            // supplierDelBtn
            // 
            this.supplierDelBtn.Location = new System.Drawing.Point(621, 243);
            this.supplierDelBtn.Name = "supplierDelBtn";
            this.supplierDelBtn.Size = new System.Drawing.Size(160, 43);
            this.supplierDelBtn.TabIndex = 12;
            this.supplierDelBtn.Text = "Delete Supplier";
            this.supplierDelBtn.UseVisualStyleBackColor = true;
            this.supplierDelBtn.Click += new System.EventHandler(this.supplierDelBtn_Click);
            // 
            // deleteProdBtn
            // 
            this.deleteProdBtn.Location = new System.Drawing.Point(621, 676);
            this.deleteProdBtn.Name = "deleteProdBtn";
            this.deleteProdBtn.Size = new System.Drawing.Size(184, 43);
            this.deleteProdBtn.TabIndex = 18;
            this.deleteProdBtn.Text = "Delete Product Supplier";
            this.deleteProdBtn.UseVisualStyleBackColor = true;
            this.deleteProdBtn.Click += new System.EventHandler(this.deleteProdBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(621, 748);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(184, 43);
            this.exitBtn.TabIndex = 18;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(238, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 56);
            this.label1.TabIndex = 19;
            this.label1.Text = "Travel Experts";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SuppliersDisplayFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(838, 828);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.deleteProdBtn);
            this.Controls.Add(this.supplierDelBtn);
            this.Controls.Add(this.supplierEditBtn);
            this.Controls.Add(this.addsuplier);
            this.Controls.Add(this.prodLbl);
            this.Controls.Add(this.addProdBtn);
            this.Controls.Add(this.addProdCombBx);
            this.Controls.Add(this.PSDGrid);
            this.Controls.Add(this.lblPS);
            this.Controls.Add(this.supplierDGrid);
            this.Controls.Add(this.lblSupplier);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SuppliersDisplayFrm";
            this.Text = "Supplier Display";
            this.Load += new System.EventHandler(this.SupplierDisplayFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PSDGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supplierDGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PSDGrid;
        private System.Windows.Forms.Label lblPS;
        private System.Windows.Forms.DataGridView supplierDGrid;
        private System.Windows.Forms.Label lblSupplier;
        private System.Windows.Forms.ComboBox addProdCombBx;
        private System.Windows.Forms.Button addProdBtn;
        private System.Windows.Forms.Label prodLbl;
        private System.Windows.Forms.Button addsuplier;
        private System.Windows.Forms.Button supplierEditBtn;
        private System.Windows.Forms.Button supplierDelBtn;
        private System.Windows.Forms.Button deleteProdBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupName;
    }
}