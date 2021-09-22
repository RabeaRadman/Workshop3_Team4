//using Workshop3_Team4.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using Workshop3_Team4.Models;

namespace Workshop3_Team4
{
    public partial class PackagesDisplay : Form
    {
        TravelExpertsContext context;
        Package currentPackage;
        //ProductsSupplier currentProductSupplier;
        private String frmdet = "{0, -10}{1, -10}{2, -30}{3, -30}";     // customer data is formatted in columns


        public PackagesDisplay()
        {
            InitializeComponent();
        }

        private void PackagesDisplay_Load(object sender, EventArgs e)
        {
            context = new TravelExpertsContext();
            pkgDGrid.AutoGenerateColumns = false;
            pkgDGrid.DataSource = context.Packages.ToList();
        }

        //private void pkgDGrid_SelectionChanged(object sender, EventArgs e)
        //private void LstPackPrdSpp_SelectedIndexChanged(object sender, EventArgs e)
        private void pkgDGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (pkgDGrid.SelectedCells.Count > 0)
            {
                currentPackage = (Package)pkgDGrid.SelectedRows[0].DataBoundItem;

                DisplayPackagesPS();
                int index = pkgDGrid.SelectedCells[0].RowIndex;
                int packageId = (int)pkgDGrid.Rows[index].Cells[0].Value;

                //currentPackage = context.Packages.Find(packageId);
                //dgvProducts.DataSource = currentPackage.PackagesProductsSuppliers.ToList();
                // format the first column

                pkgDGrid.Columns[0].Width = 110;
                pkgDGrid.Columns[1].Width = 200;
                pkgDGrid.Columns[2].Width = 110;
                pkgDGrid.Columns[3].Width = 110;
                pkgDGrid.Columns[4].Width = 360;
                pkgDGrid.Columns[5].Width = 110;
                pkgDGrid.Columns[5].Width = 160;

                // format the column header
                pkgDGrid.EnableHeadersVisualStyles = false;
                pkgDGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
                pkgDGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSkyBlue;
                pkgDGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

                // format the odd numbered rows
                pkgDGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
                //format columns base price (5) & agency commission (6) to display currency
                pkgDGrid.Columns[5].DefaultCellStyle.Format = "c";
                pkgDGrid.Columns[6].DefaultCellStyle.Format = "c";

            }
        }

        public void DisplayPackagesPS()
        {

            List<PackagesProductsSupplier> packprodsupp = currentPackage.PackagesProductsSuppliers.ToList();

            var prodsupplist = from ps in packprodsupp
                               join prodsupp in context.ProductsSuppliers
                               on ps.ProductSupplierId equals prodsupp.ProductSupplierId
                               select new { ps.PackageId, ps.ProductSupplierId, prodsupp.ProductId, prodsupp.SupplierId };

            var packprodlist = from pps in prodsupplist
                               join prod in context.Products
                               on pps.ProductId equals prod.ProductId
                               join supp in context.Suppliers
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



        //private void subPSDGrid_SelectionChanged(object sender, EventArgs e)
        //{

        //    if (subPSDGrid.SelectedCells.Count > 0)
        //    {
        //        int index1 = packagesDGrid.SelectedCells[0].RowIndex;
        //        int index2 = subPSDGrid.SelectedCells[0].RowIndex;
        //        int packageId = (int)packagesDGrid.Rows[index1].Cells[0].Value;
        //        int productsupplierId = (int)subPSDGrid.Rows[index2].Cells[0].Value;


        //        currentPackage = context.Packages.Find(packageId);
        //        currentProductSupplier = context.ProductsSuppliers.Find(productsupplierId);
        //        PPSDGrid.DataSource = currentProductSupplier.PackagesProductsSuppliers.ToList();

        //    }
        //}
    }
}