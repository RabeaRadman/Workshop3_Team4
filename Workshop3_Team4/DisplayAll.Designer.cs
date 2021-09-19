
namespace Workshop3_Team4
{
    partial class DisplayAllFrm
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
            this.lblPkg = new System.Windows.Forms.Label();
            this.pkgDGrid = new System.Windows.Forms.DataGridView();
            this.PackageId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkgStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkgEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkgDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkgBasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkgAgencyCommission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prodDGrid = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblProd = new System.Windows.Forms.Label();
            this.supDGrid = new System.Windows.Forms.DataGridView();
            this.SupplierId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SupName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblPPS = new System.Windows.Forms.Label();
            this.PPSDGrid = new System.Windows.Forms.DataGridView();
            this.Package = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductSupplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblProdSup = new System.Windows.Forms.Label();
            this.PSDGrid = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PackagesProductsSuppliers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Supplier = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookingDetails = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSup = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pkgDGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodDGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.supDGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PPSDGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PSDGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPkg
            // 
            this.lblPkg.AutoSize = true;
            this.lblPkg.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPkg.Location = new System.Drawing.Point(15, 8);
            this.lblPkg.Name = "lblPkg";
            this.lblPkg.Size = new System.Drawing.Size(73, 20);
            this.lblPkg.TabIndex = 0;
            this.lblPkg.Text = "Packages";
            // 
            // pkgDGrid
            // 
            this.pkgDGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.pkgDGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pkgDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pkgDGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PackageId,
            this.PkgName,
            this.PkgStartDate,
            this.PkgEndDate,
            this.PkgDesc,
            this.PkgBasePrice,
            this.PkgAgencyCommission});
            this.pkgDGrid.Location = new System.Drawing.Point(15, 31);
            this.pkgDGrid.Name = "pkgDGrid";
            this.pkgDGrid.RowTemplate.Height = 25;
            this.pkgDGrid.Size = new System.Drawing.Size(1022, 209);
            this.pkgDGrid.TabIndex = 1;
            this.pkgDGrid.SelectionChanged += new System.EventHandler(this.pkgDGrid_SelectionChanged);
            // 
            // PackageId
            // 
            this.PackageId.DataPropertyName = "PackageId";
            this.PackageId.HeaderText = "Package ID";
            this.PackageId.Name = "PackageId";
            // 
            // PkgName
            // 
            this.PkgName.DataPropertyName = "PkgName";
            this.PkgName.HeaderText = "Package Name";
            this.PkgName.Name = "PkgName";
            // 
            // PkgStartDate
            // 
            this.PkgStartDate.DataPropertyName = "PkgStartDate";
            this.PkgStartDate.HeaderText = "Package Start Date";
            this.PkgStartDate.Name = "PkgStartDate";
            // 
            // PkgEndDate
            // 
            this.PkgEndDate.DataPropertyName = "PkgEndDate";
            this.PkgEndDate.HeaderText = "Package End Date";
            this.PkgEndDate.Name = "PkgEndDate";
            // 
            // PkgDesc
            // 
            this.PkgDesc.DataPropertyName = "PkgDesc";
            this.PkgDesc.HeaderText = "Package Description";
            this.PkgDesc.Name = "PkgDesc";
            // 
            // PkgBasePrice
            // 
            this.PkgBasePrice.DataPropertyName = "PkgBasePrice";
            this.PkgBasePrice.HeaderText = "package Base Price";
            this.PkgBasePrice.Name = "PkgBasePrice";
            // 
            // PkgAgencyCommission
            // 
            this.PkgAgencyCommission.DataPropertyName = "PkgAgencyCommission";
            this.PkgAgencyCommission.HeaderText = "Agency Commission";
            this.PkgAgencyCommission.Name = "PkgAgencyCommission";
            // 
            // prodDGrid
            // 
            this.prodDGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.prodDGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.prodDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prodDGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ProdName});
            this.prodDGrid.Location = new System.Drawing.Point(12, 705);
            this.prodDGrid.Name = "prodDGrid";
            this.prodDGrid.RowTemplate.Height = 25;
            this.prodDGrid.Size = new System.Drawing.Size(1025, 189);
            this.prodDGrid.TabIndex = 3;
            this.prodDGrid.SelectionChanged += new System.EventHandler(this.prodDGrid_SelectionChanged);
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "ProductId";
            this.ProductId.HeaderText = "Product ID";
            this.ProductId.Name = "ProductId";
            // 
            // ProdName
            // 
            this.ProdName.DataPropertyName = "ProdName";
            this.ProdName.HeaderText = "Product Name";
            this.ProdName.Name = "ProdName";
            // 
            // lblProd
            // 
            this.lblProd.AutoSize = true;
            this.lblProd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProd.Location = new System.Drawing.Point(12, 682);
            this.lblProd.Name = "lblProd";
            this.lblProd.Size = new System.Drawing.Size(71, 20);
            this.lblProd.TabIndex = 4;
            this.lblProd.Text = "Products";
            // 
            // supDGrid
            // 
            this.supDGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.supDGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.supDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.supDGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SupplierId,
            this.SupName});
            this.supDGrid.Location = new System.Drawing.Point(12, 934);
            this.supDGrid.Name = "supDGrid";
            this.supDGrid.RowTemplate.Height = 25;
            this.supDGrid.Size = new System.Drawing.Size(1025, 196);
            this.supDGrid.TabIndex = 5;
            this.supDGrid.SelectionChanged += new System.EventHandler(this.supDGrid_SelectionChanged);
            // 
            // SupplierId
            // 
            this.SupplierId.DataPropertyName = "SupplierId";
            this.SupplierId.HeaderText = "Supplier ID";
            this.SupplierId.Name = "SupplierId";
            // 
            // SupName
            // 
            this.SupName.DataPropertyName = "SupName";
            this.SupName.HeaderText = "Supplier Name";
            this.SupName.Name = "SupName";
            // 
            // lblPPS
            // 
            this.lblPPS.AutoSize = true;
            this.lblPPS.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPPS.Location = new System.Drawing.Point(12, 252);
            this.lblPPS.Name = "lblPPS";
            this.lblPPS.Size = new System.Drawing.Size(211, 20);
            this.lblPPS.TabIndex = 6;
            this.lblPPS.Text = "Packages-Products-Suppliers";
            // 
            // PPSDGrid
            // 
            this.PPSDGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.PPSDGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PPSDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PPSDGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Package,
            this.ProductSupplier});
            this.PPSDGrid.Location = new System.Drawing.Point(15, 275);
            this.PPSDGrid.Name = "PPSDGrid";
            this.PPSDGrid.RowTemplate.Height = 25;
            this.PPSDGrid.Size = new System.Drawing.Size(1022, 159);
            this.PPSDGrid.TabIndex = 7;
            // 
            // Package
            // 
            this.Package.DataPropertyName = "Package";
            this.Package.HeaderText = "Package";
            this.Package.Name = "Package";
            this.Package.Visible = false;
            // 
            // ProductSupplier
            // 
            this.ProductSupplier.DataPropertyName = "ProductSupplier";
            this.ProductSupplier.HeaderText = "ProductSupplier";
            this.ProductSupplier.Name = "ProductSupplier";
            this.ProductSupplier.Visible = false;
            // 
            // lblProdSup
            // 
            this.lblProdSup.AutoSize = true;
            this.lblProdSup.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblProdSup.Location = new System.Drawing.Point(12, 454);
            this.lblProdSup.Name = "lblProdSup";
            this.lblProdSup.Size = new System.Drawing.Size(141, 20);
            this.lblProdSup.TabIndex = 8;
            this.lblProdSup.Text = "Products-Suppliers";
            // 
            // PSDGrid
            // 
            this.PSDGrid.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.PSDGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PSDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PSDGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.PackagesProductsSuppliers,
            this.Supplier,
            this.BookingDetails});
            this.PSDGrid.Location = new System.Drawing.Point(13, 477);
            this.PSDGrid.Name = "PSDGrid";
            this.PSDGrid.RowTemplate.Height = 25;
            this.PSDGrid.Size = new System.Drawing.Size(1024, 190);
            this.PSDGrid.TabIndex = 9;
            // 
            // Product
            // 
            this.Product.DataPropertyName = "Product";
            this.Product.HeaderText = "Product";
            this.Product.Name = "Product";
            this.Product.Visible = false;
            // 
            // PackagesProductsSuppliers
            // 
            this.PackagesProductsSuppliers.DataPropertyName = "PackagesProductsSuppliers";
            this.PackagesProductsSuppliers.HeaderText = "PackagesProductsSuppliers";
            this.PackagesProductsSuppliers.Name = "PackagesProductsSuppliers";
            this.PackagesProductsSuppliers.Visible = false;
            // 
            // Supplier
            // 
            this.Supplier.DataPropertyName = "Supplier";
            this.Supplier.HeaderText = "Supplier";
            this.Supplier.Name = "Supplier";
            this.Supplier.Visible = false;
            // 
            // BookingDetails
            // 
            this.BookingDetails.DataPropertyName = "BookingDetails";
            this.BookingDetails.HeaderText = "BookingDetails";
            this.BookingDetails.Name = "BookingDetails";
            this.BookingDetails.Visible = false;
            // 
            // lblSup
            // 
            this.lblSup.AutoSize = true;
            this.lblSup.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSup.Location = new System.Drawing.Point(12, 911);
            this.lblSup.Name = "lblSup";
            this.lblSup.Size = new System.Drawing.Size(73, 20);
            this.lblSup.TabIndex = 10;
            this.lblSup.Text = "Suppliers";
            // 
            // DisplayAllFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoScrollMargin = new System.Drawing.Size(0, 300);
            this.ClientSize = new System.Drawing.Size(1162, 1004);
            this.Controls.Add(this.lblSup);
            this.Controls.Add(this.lblProdSup);
            this.Controls.Add(this.PPSDGrid);
            this.Controls.Add(this.lblPPS);
            this.Controls.Add(this.lblProd);
            this.Controls.Add(this.lblPkg);
            this.Controls.Add(this.supDGrid);
            this.Controls.Add(this.PSDGrid);
            this.Controls.Add(this.pkgDGrid);
            this.Controls.Add(this.prodDGrid);
            this.Name = "DisplayAllFrm";
            this.Text = "Travel Experts Database";
            this.Load += new System.EventHandler(this.DisplayAllFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pkgDGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.prodDGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.supDGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PPSDGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PSDGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPkg;
        private System.Windows.Forms.DataGridView pkgDGrid;
        private System.Windows.Forms.DataGridView prodDGrid;
        private System.Windows.Forms.Label lblProd;
        private System.Windows.Forms.DataGridView supDGrid;
        private System.Windows.Forms.Label lblPPS;
        private System.Windows.Forms.DataGridView PPSDGrid;
        private System.Windows.Forms.Label lblProdSup;
        private System.Windows.Forms.DataGridView PSDGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackageId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkgStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkgEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkgDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkgBasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkgAgencyCommission;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupplierId;
        private System.Windows.Forms.DataGridViewTextBoxColumn SupName;
        private System.Windows.Forms.Label lblSup;
        private System.Windows.Forms.DataGridViewTextBoxColumn Package;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductSupplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackagesProductsSuppliers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Supplier;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookingDetails;
    }
}