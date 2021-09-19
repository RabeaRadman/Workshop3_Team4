
namespace Workshop3_Team4
{
    partial class PackagesDisplay
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblPkg = new System.Windows.Forms.Label();
            this.LstPackPrdSpp = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LblProdSuppName = new System.Windows.Forms.Label();
            this.pkgDGrid = new System.Windows.Forms.DataGridView();
            this.PackageId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkgName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkgStartDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkgEndDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkgDesc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkgBasePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PkgAgencyCommission = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pkgDGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPkg
            // 
            this.lblPkg.AutoSize = true;
            this.lblPkg.Location = new System.Drawing.Point(1, 21);
            this.lblPkg.Name = "lblPkg";
            this.lblPkg.Size = new System.Drawing.Size(69, 20);
            this.lblPkg.TabIndex = 6;
            this.lblPkg.Text = "Packages";
            // 
            // LstPackPrdSpp
            // 
            this.LstPackPrdSpp.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LstPackPrdSpp.FormattingEnabled = true;
            this.LstPackPrdSpp.HorizontalScrollbar = true;
            this.LstPackPrdSpp.ItemHeight = 23;
            this.LstPackPrdSpp.Location = new System.Drawing.Point(81, 562);
            this.LstPackPrdSpp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LstPackPrdSpp.Name = "LstPackPrdSpp";
            this.LstPackPrdSpp.Size = new System.Drawing.Size(1235, 188);
            this.LstPackPrdSpp.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(63, 474);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 51);
            this.label2.TabIndex = 45;
            this.label2.Text = "Products:";
            // 
            // LblProdSuppName
            // 
            this.LblProdSuppName.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblProdSuppName.Location = new System.Drawing.Point(81, 522);
            this.LblProdSuppName.Name = "LblProdSuppName";
            this.LblProdSuppName.Size = new System.Drawing.Size(746, 36);
            this.LblProdSuppName.TabIndex = 47;
            // 
            // pkgDGrid
            // 
            this.pkgDGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.pkgDGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PackageId,
            this.PkgName,
            this.PkgStartDate,
            this.PkgEndDate,
            this.PkgDesc,
            this.PkgBasePrice,
            this.PkgAgencyCommission});
            this.pkgDGrid.Location = new System.Drawing.Point(24, 52);
            this.pkgDGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pkgDGrid.Name = "pkgDGrid";
            this.pkgDGrid.RowHeadersWidth = 51;
            this.pkgDGrid.RowTemplate.Height = 25;
            this.pkgDGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.pkgDGrid.Size = new System.Drawing.Size(1292, 383);
            this.pkgDGrid.TabIndex = 48;
            this.pkgDGrid.SelectionChanged += new System.EventHandler(this.pkgDGrid_SelectionChanged);
            // 
            // PackageId
            // 
            this.PackageId.DataPropertyName = "PackageId";
            this.PackageId.HeaderText = "Package ID";
            this.PackageId.MinimumWidth = 6;
            this.PackageId.Name = "PackageId";
            this.PackageId.Width = 125;
            // 
            // PkgName
            // 
            this.PkgName.DataPropertyName = "PkgName";
            this.PkgName.HeaderText = "Package Name";
            this.PkgName.MinimumWidth = 6;
            this.PkgName.Name = "PkgName";
            this.PkgName.Width = 250;
            // 
            // PkgStartDate
            // 
            this.PkgStartDate.DataPropertyName = "PkgStartDate";
            this.PkgStartDate.HeaderText = "Package Start Date";
            this.PkgStartDate.MinimumWidth = 6;
            this.PkgStartDate.Name = "PkgStartDate";
            this.PkgStartDate.Width = 125;
            // 
            // PkgEndDate
            // 
            this.PkgEndDate.DataPropertyName = "PkgEndDate";
            this.PkgEndDate.HeaderText = "Package End Date";
            this.PkgEndDate.MinimumWidth = 6;
            this.PkgEndDate.Name = "PkgEndDate";
            this.PkgEndDate.Width = 125;
            // 
            // PkgDesc
            // 
            this.PkgDesc.DataPropertyName = "PkgDesc";
            this.PkgDesc.HeaderText = "Package Description";
            this.PkgDesc.MinimumWidth = 6;
            this.PkgDesc.Name = "PkgDesc";
            this.PkgDesc.Width = 300;
            // 
            // PkgBasePrice
            // 
            this.PkgBasePrice.DataPropertyName = "PkgBasePrice";
            this.PkgBasePrice.HeaderText = "Package Base Price";
            this.PkgBasePrice.MinimumWidth = 6;
            this.PkgBasePrice.Name = "PkgBasePrice";
            this.PkgBasePrice.Width = 125;
            // 
            // PkgAgencyCommission
            // 
            this.PkgAgencyCommission.DataPropertyName = "PkgAgencyCommission";
            this.PkgAgencyCommission.HeaderText = "Package Agency Commision";
            this.PkgAgencyCommission.MinimumWidth = 6;
            this.PkgAgencyCommission.Name = "PkgAgencyCommission";
            this.PkgAgencyCommission.Width = 125;
            // 
            // PackagesDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 887);
            this.Controls.Add(this.pkgDGrid);
            this.Controls.Add(this.LblProdSuppName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPkg);
            this.Controls.Add(this.LstPackPrdSpp);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "PackagesDisplay";
            this.Text = "Display";
            this.Load += new System.EventHandler(this.PackagesDisplay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pkgDGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPkg;
        private System.Windows.Forms.ListBox LstPackPrdSpp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblProdSuppName;
        private System.Windows.Forms.DataGridView pkgDGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn PackageId;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkgName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkgStartDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkgEndDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkgDesc;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkgBasePrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn PkgAgencyCommission;
    }
}

