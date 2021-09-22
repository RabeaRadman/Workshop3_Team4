using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workshop3_Team4.Models;
using Microsoft.EntityFrameworkCore;


///summary
///
/// Opens the Packages Product Supplier list 
/// so that it can be added to the package 
///summary

namespace Workshop3_Team4
{
    public partial class FrmProdSuppDisp : Form
    {
        TravelExpertsContext Context;
        private String strdet = "{0, -10}{1, -20}{2, -35}{3, -35}";     // Product Supplier data is formatted in columns
        
        
        public FrmProdSuppDisp()
        {
            InitializeComponent();           
        }

        private void FrmProdSuppDisp_Load(object sender, EventArgs e)
        {
            Context = new TravelExpertsContext();

            LblProdSuppSelect.Text = "";
            DisplayProductSupplier();
        }

        private void DisplayProductSupplier()
        {
            string prodsuppitem;
            int count=0;
            
            string headers = String.Format(strdet, "Record#", "ProductSupplierId",
                                                   "ProdName", "SupName");
            LblHdrProdSupp.Text = headers;

            LstPackProdSupp.Items.Clear();
            List<ProductsSupplier> allprod = Context.ProductsSuppliers.Include(p => p.Product).Include(s => s.Supplier).ToList();
            foreach (ProductsSupplier product in allprod)
            {
                count++;
                prodsuppitem = String.Format(strdet, count.ToString(), product.ProductSupplierId, 
                                                     product.Product.ProdName, product.Supplier.SupName);
                LstPackProdSupp.Items.Add(prodsuppitem);
            }
        }

        private void BtnProdSuppClose_Click(object sender, EventArgs e)
        {
            if (LstPackProdSupp.SelectedItems.Count == 0)
            {
                MessageBox.Show("Please select a Product to add", "Add Product", 0);
            }
            else
                this.Close();
        }

        private void LstPackProdSupp_SelectedIndexChanged(object sender, EventArgs e)
        {
            LblProdSuppSelect.Text = LstPackProdSupp.SelectedItem.ToString().Substring(5);
        }
    }
}
