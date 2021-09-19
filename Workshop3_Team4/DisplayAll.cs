using Workshop3_Team4.Models;
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

// Display all tables to gether and demonstrate the database diagram format
namespace Workshop3_Team4
{
    public partial class DisplayAllFrm : Form
    {
        TravelExpertsContext context;
        Package currentPackage;
        Product currentProduct;
        Supplier currentSupplier;


        public DisplayAllFrm()
        {
            InitializeComponent();
        }

        private void DisplayAllFrm_Load(object sender, EventArgs e)
        {
            context = new TravelExpertsContext();

            pkgDGrid.AutoGenerateColumns = false;
            pkgDGrid.DataSource = context.Packages.ToList();

            PPSDGrid.AutoGenerateColumns = false;
            PPSDGrid.DataSource = context.PackagesProductsSuppliers.ToList();

            prodDGrid.AutoGenerateColumns = false;
            prodDGrid.DataSource = context.Products.ToList();

            supDGrid.AutoGenerateColumns = false;
            supDGrid.DataSource = context.Suppliers.ToList();

            PSDGrid.AutoGenerateColumns = false;
            PSDGrid.DataSource = context.ProductsSuppliers.ToList();

        }
//display packages in grid file format
        private void pkgDGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (pkgDGrid.SelectedCells.Count > 0)
            {
                int index = pkgDGrid.SelectedCells[0].RowIndex;
                int packageId = (int)pkgDGrid.Rows[index].Cells[0].Value;
                
// show the correlation between packages and  products-packages-suplier table
                currentPackage = context.Packages.Find(packageId);
                PPSDGrid.DataSource = currentPackage.PackagesProductsSuppliers.ToList();

                // format the first column

                pkgDGrid.Columns[0].Width = 110;
                pkgDGrid.Columns[1].Width = 200;
                pkgDGrid.Columns[2].Width = 110;
                pkgDGrid.Columns[3].Width = 110;
                pkgDGrid.Columns[4].Width = 360;
                pkgDGrid.Columns[5].Width = 110;
                pkgDGrid.Columns[5].Width = 110;

                // format the column header
                pkgDGrid.EnableHeadersVisualStyles = false;
                pkgDGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
                pkgDGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSkyBlue;
                pkgDGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

                // format the odd numbered rows
                pkgDGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;


                // format the column header
                PPSDGrid.EnableHeadersVisualStyles = false;
                PPSDGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
                PPSDGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSkyBlue;
                PPSDGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;


                PPSDGrid.Columns[0].Width = 110;
                PPSDGrid.Columns[1].Width = 140;
                PPSDGrid.Columns[2].Width = 110;
                PPSDGrid.Columns[3].Width = 110;


                // format the odd numbered rows
                PPSDGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
            }
        }
// display production table in grid foramt
        private void prodDGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (prodDGrid.SelectedCells.Count > 0)
            {
                int index = prodDGrid.SelectedCells[0].RowIndex;
                int productId = (int)prodDGrid.Rows[index].Cells[0].Value;

                currentProduct = context.Products.Find(productId);
                PSDGrid.DataSource = currentProduct.ProductsSuppliers.ToList();
            }
            // format the column header
            PSDGrid.EnableHeadersVisualStyles = false;
            PSDGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            PSDGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSkyBlue;
            PSDGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            PSDGrid.Columns[0].Width = 140;
            PSDGrid.Columns[1].Width = 110;
            PSDGrid.Columns[2].Width = 110;
            PSDGrid.Columns[3].Width = 110;

            // format the odd numbered rows
            PSDGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

            // format the column header
            prodDGrid.EnableHeadersVisualStyles = false;
            prodDGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            prodDGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSkyBlue;
            prodDGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            prodDGrid.Columns[0].Width = 110;
            prodDGrid.Columns[1].Width = 140;


            // format the odd numbered rows
            prodDGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
        }
            // display supplier table in grid format
        private void supDGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (supDGrid.SelectedCells.Count > 0)
            {
                int index = supDGrid.SelectedCells[0].RowIndex;
                int supplierId = (int)supDGrid.Rows[index].Cells[0].Value;
            // show the correlation between product and product-supplier table
                currentSupplier = context.Suppliers.Find(supplierId);
                PSDGrid.DataSource = currentSupplier.ProductsSuppliers.ToList();

            }
            // format the column header
            supDGrid.EnableHeadersVisualStyles = false;
            supDGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
            supDGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.LightSkyBlue;
            supDGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            supDGrid.Columns[0].Width = 110;
            supDGrid.Columns[1].Width = 280;


            // format the odd numbered rows
            supDGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;

        }

    }
}
