using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Workshop3_Team4.Models;


///summary
///
/// Opens the Packages Maintenance Form
/// which allows Agents to Add/Edit/Delete a package
/// Can add product to the package
/// 
///summary
namespace Workshop3_Team4
{
    public partial class FrmPackages : Form
    {

        TravelExpertsContext Context;
        Package currpackage;                 
        FrmProdSuppDisp prodsuppdispFrm = new FrmProdSuppDisp();          //Open Product Supplier form
        ProductsSupplier currprodsup;
        PackagesProductsSupplier currpackprodpsupp;
        public string txtselect="";
        private String frmdet = "{0, -10}{1, -10}{2, -30}{3, -30}";     // customer data is formatted in columns
        

        public FrmPackages()
        {
            InitializeComponent();
        }

        private void FrmPackages_Load(object sender, EventArgs e)
        {
            Context = new TravelExpertsContext();            
            TxtWelcome.Visible = true;
            
        }

        //This happens when click on Add on the menu
        private void ToolmnuAdd_Click(object sender, EventArgs e)
        {
            InitializeTextboxes();
            EnableInputs();

            PnlDelete.Visible = false;
            PnlAddModify.Visible = true;
            LblTitle.Text = "Add Packages";
            TxtWelcome.Visible = false;
            CmbEdit.Visible = false;
            LblPackProdCode.Visible = true;
             
        }



        private void ToolmnuClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //This saves when Addign and Editing the Packages table. It also validates all the inputs
        // and the function is found in ValidatorPackage.cs
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (ValidatorPackage.IsPresent(TxtPackName, LblPackNameValidate) &&
                ValidatorPackage.IsMore50(TxtPackName, LblPackNameValidate) &&
                ValidatorPackage.IsPresent(TxtPackDesc, LblPackDescValidate) &&
                ValidatorPackage.IsMore50(TxtPackDesc, LblPackDescValidate) &&
                ValidatorPackage.IsEndDateLater(DatePickStartDate, DatePickEndDate, LblPackStartValidate) &&
                ValidatorPackage.IsNotAlpha(TxtPackBasePrice, LblPackBaseValidate) &&
                ValidatorPackage.IsPositive(TxtPackBasePrice, LblPackBaseValidate) &&
                //ValidatorPackage.IsDecimal(TxtPackBasePrice, LblPackBaseValidate) &&
                ValidatorPackage.IsLessThanAgency(TxtPackBasePrice, TxtPackAgency, LblPackBaseValidate) &&
                ValidatorPackage.IsNotAlpha(TxtPackAgency, LblPackACValidate) &&
                ValidatorPackage.IsPositive(TxtPackAgency, LblPackACValidate))
               //ValidatorPackage.IsDecimal(TxtPackAgency, LblPackACValidate)
          
            if (LblTitle.Text == "Add Packages")
                AddPackage();
            else
                ModifyPackage();
        }

         //This updates the packages table      
        private void ModifyPackage()
        {
         
            currpackage.PkgName = TxtPackName.Text;
            currpackage.PkgStartDate = DatePickStartDate.Value;
            currpackage.PkgEndDate = DatePickEndDate.Value;
            currpackage.PkgDesc = TxtPackDesc.Text;
            currpackage.PkgBasePrice = Convert.ToDecimal(TxtPackBasePrice.Text);
            currpackage.PkgAgencyCommission = Convert.ToDecimal(TxtPackAgency.Text);
            Context.SaveChanges();
            LblPackageID.Text = "Package ID: " + currpackage.PackageId + " has been modified";

        }

        //Adds a new package in the Packages table
        // Allows to select a Product for the newly created packages
        private void AddPackage()
        {

            Package newpackage = new Package()
            {
                PkgName = TxtPackName.Text,
                PkgStartDate = DatePickStartDate.Value.Date,
                PkgEndDate = DatePickEndDate.Value.Date,
                PkgDesc = TxtPackDesc.Text,
                PkgBasePrice = decimal.Parse(TxtPackBasePrice.Text),
                PkgAgencyCommission = decimal.Parse(TxtPackAgency.Text)
            };

            Context.Packages.Add(newpackage);
            Context.SaveChanges();

            currpackage = newpackage;

            LblPackageID.Text = "Package ID: " + currpackage.PackageId + " is created";

            GetProductList();

        }

        private void EnableInputs()
        {
            TxtPackName.Enabled = true;
            DatePickStartDate.Enabled = true;
            DatePickEndDate.Enabled = true;
            TxtPackDesc.Enabled = true;
            TxtPackBasePrice.Enabled = true;
            TxtPackAgency.Enabled = true;

            BtnSave.Visible = true;
            BtnProdSuppSave.Visible = false;
            BtnProdSuppGet.Visible = false;
            LblProdCodeValidate.Text = "";
            LblPackProdCode.Text = "";

        }

          //This happens when Edit is clicked on  the menu
        private void ToolmnuEdit_Click(object sender, EventArgs e)
        { 
            
            CmbEdit.Visible = true;
            LblTitle.Text = "Modify Packages";
            TxtWelcome.Visible = false;
            PnlAddModify.Visible = true;
            PnlDelete.Visible = false;
            
            CmbEdit.DataSource = Context.Packages.ToList();

            EnableInputs();
                        
        }

         //dropdown for all packages to edit what is selected
        private void CmbEdit_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblPackageID.Text = "";
            currpackage = (Package)CmbEdit.SelectedItem;
            TxtPackName.Text = currpackage.PkgName;
            DatePickStartDate.Text = currpackage.PkgStartDate.ToString();
            DatePickEndDate.Text = currpackage.PkgEndDate.ToString();
            TxtPackDesc.Text = currpackage.PkgDesc;
            TxtPackBasePrice.Text = currpackage.PkgBasePrice.ToString("n2");
            TxtPackAgency.Text = currpackage.PkgAgencyCommission?.ToString("n2");

        }

        private void ToolmnuRemove_Click(object sender, EventArgs e)
        {
            LblTitle.Text = "Remove Packages";
            PnlDelete.Visible = true;           
            PnlAddModify.Visible = false;
            TxtWelcome.Visible = false;
            LblPackProdCode.Visible = false;

            pac.AutoGenerateColumns = false;  
            pac.DataSource = Context.Packages.ToList();

            //format the base price and agency commision columns to display currency format
            pac.Columns[5].DefaultCellStyle.Format = "c";
            pac.Columns[6].DefaultCellStyle.Format = "c";

        }

        private void InitializeTextboxes()
        {
            TxtPackName.Text = "";
            TxtPackDesc.Text = "";
            TxtPackBasePrice.Text = "";
            TxtPackAgency.Text = "";
            DatePickEndDate.Value = DateTime.Now;
            DatePickStartDate.Value = DateTime.Now;
            LblPackageID.Text = "";

        }

        private void TxtPackName_Click(object sender, EventArgs e)
        {

            if (LblTitle.Text == "Add Packages")
                InitializeTextboxes();
        }


        private void ToolmnuDisplay_Click(object sender, EventArgs e)
        {
            PackagesDisplay packdispFrm = new PackagesDisplay();          //Open Packge Display form 
            packdispFrm.ShowDialog();
        }

        private void BtnPackProdCode_Click(object sender, EventArgs e)
        {            
            prodsuppdispFrm.ShowDialog();
        }
        
          // The selected Product for the saved packaged is being saved to the
          // Packages Product Suppler table
        private void BtnProdSuppSave_Click(object sender, EventArgs e)
        {            
            
            int indx = Int32.Parse(prodsuppdispFrm.LblProdSuppSelect.Text.Substring(0, 10).Trim());
            currprodsup = Context.ProductsSuppliers.Find(indx);
         
            PackagesProductsSupplier newpackprodsupp = new PackagesProductsSupplier()
                {
                    PackageId = currpackage.PackageId,
                    ProductSupplierId = currprodsup.ProductSupplierId
                };

            Context.PackagesProductsSuppliers.Add(newpackprodsupp);

            Context.SaveChanges();

            LblProdCodeValidate.Text = $"Product Supplier id# {indx.ToString()} is added for this package";

        }

        //Displays the Packages Product Supplier table to be added for the package
        private void GetProductList()
        {
            prodsuppdispFrm.ShowDialog();

            if (prodsuppdispFrm.LblProdSuppSelect.Text != "")
                txtselect = "Selected Product: ";
            else
                txtselect = "No product selected. Please select a product.";

            LblPackProdCode.Text = txtselect + prodsuppdispFrm.LblProdSuppSelect.Text;
                  
            TxtPackName.Enabled = false;
            DatePickStartDate.Enabled = false;
            DatePickEndDate.Enabled = false;
            TxtPackDesc.Enabled = false;
            TxtPackBasePrice.Enabled = false;
            TxtPackAgency.Enabled = false;

            BtnProdSuppSave.Visible = true;
            BtnProdSuppGet.Visible = true;
            BtnSave.Visible = false;
        }

        private void BtnProdSuppGet_Click(object sender, EventArgs e)
        {            
            GetProductList();            
            LblProdCodeValidate.Text = "";
        }

        private void GridRemove_SelectionChanged(object sender, EventArgs e) 
        {
            if (pac.SelectedRows.Count > 0)
            {
                currpackage = (Package)pac.SelectedRows[0].DataBoundItem;

                DisplayPackagesPS();

            }

        }

        // Displays the Packages Product Supplier table where the Product Name and Supplier
        // Name are being displayed
        public void DisplayPackagesPS()
        {

            List<PackagesProductsSupplier> packprodsupp = currpackage.PackagesProductsSuppliers.ToList();

            var prodsupplist = from ps in packprodsupp
                               join prodsupp in Context.ProductsSuppliers
                               on ps.ProductSupplierId equals prodsupp.ProductSupplierId
                               select new { ps.PackageId, ps.ProductSupplierId, prodsupp.ProductId, prodsupp.SupplierId };

            var packprodlist = from pps in prodsupplist
                               join prod in Context.Products
                               on pps.ProductId equals prod.ProductId
                               join supp in Context.Suppliers
                               on pps.SupplierId equals supp.SupplierId
                               select new 
                               { 
                                    pps.PackageId,
                                    pps.ProductSupplierId,
                                    prod.ProdName,
                                    supp.SupName 
                                };


            LblProdSuppName.Text = String.Format(frmdet, "PkgID", "PkgPSID", "Product Name",
                                                          "Supplier Name");

            LstPackPrdSpp.Items.Clear();            
            foreach (var pckps in packprodlist)
                LstPackPrdSpp.Items.Add(String.Format(frmdet, pckps.PackageId.ToString(),
                                                              pckps.ProductSupplierId.ToString(),
                                                              pckps.ProdName, pckps.SupName));
        }

        //Deletes the Packages Product Supplier first then deletes the selected Package
        private void BtnPackDelete_Click(object sender, EventArgs e) 
        {
            if (LstPackPrdSpp.Items.Count != 0)
            {
                string delmsg = "This will delete all related Products\n and Suppliers for this package";
                DialogResult msgresult = MessageBox.Show(delmsg, "Are you sure you want to delete?",
                                         MessageBoxButtons.YesNo);
                if (msgresult == DialogResult.Yes)
                {
                    for (int lstcnt = 0; lstcnt < LstPackPrdSpp.Items.Count; lstcnt++)
                    {
                        var indp = Convert.ToInt32(LstPackPrdSpp.Items[lstcnt].ToString().Substring(0, 10));
                        var indps = Convert.ToInt32(LstPackPrdSpp.Items[lstcnt].ToString().Substring(5, 10));
                        currpackprodpsupp = Context.PackagesProductsSuppliers.Find(indp, indps);

                        Context.PackagesProductsSuppliers.Remove(currpackprodpsupp);

                        if (lstcnt == LstPackPrdSpp.Items.Count - 1)
                        { 
                            LstPackPrdSpp.Items.Clear();
                            Context.Packages.Remove(currpackage);
                            Context.SaveChanges();
                                                        
                        }
                    }       
                }
            }
            else
            { 
                Context.Packages.Remove(currpackage);
                
                Context.SaveChanges();
                LblPackRemove.Text = "Package ID: " + currpackage.PackageId + " is deleted";
            
            }

            pac.DataSource = Context.Packages.ToList();

        }

        //Deletes the selected Packages Produt Supplier 
        private void BtnPPSDelete_Click(object sender, EventArgs e)
        {
          
            if (LstPackPrdSpp.SelectedItems.Count != 0)
            {
                Context.PackagesProductsSuppliers.Remove(currpackprodpsupp);
                Context.SaveChanges();

                DisplayPackagesPS();
            }
            else
            {
                MessageBox.Show("Please select a Product to delete", "Delete", 0);
            }

        }


        private void LstPackPrdSpp_SelectedIndexChanged(object sender, EventArgs e)
        {        
               var indp = Convert.ToInt32(LstPackPrdSpp.SelectedItem.ToString().Substring(0, 10));
               var indps = Convert.ToInt32(LstPackPrdSpp.SelectedItem.ToString().Substring(5, 10));
               currpackprodpsupp = Context.PackagesProductsSuppliers.Find(indp, indps);                 //get the current selected PackagesProductSupplier
          
        }

        private void ToolmnuDisplay_Click_1(object sender, EventArgs e)
        {
            PackagesDisplay packdispFrm = new PackagesDisplay();          //Open Packge Display form 
            packdispFrm.ShowDialog();
        }
    }
}
