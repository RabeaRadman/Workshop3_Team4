using Workshop3_Team4.Models; 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace Workshop3_Team4
{
    public partial class SuppliersDisplayFrm : Form
    {
        TravelExpertsContext context;                                                  // Employ context

        Supplier currentSupplier;                                                     // Define currentSupplier
 
        ProductsSupplier currentProdSuplr;                                            // Define currentProdSuplr
       
        public SuppliersDisplayFrm()
        {
            InitializeComponent();
        }

        private void SupplierDisplayFrm_Load(object sender, EventArgs e)
        {
            context = new TravelExpertsContext();                                            // Create an instance of the DB context
            supplierDGrid.AutoGenerateColumns = false;
            supplierDGrid.DataSource = context.Suppliers.ToList();                            // A query that send all Suppliers to data grid view
           
            List<Product> products = context.Products.ToList();                               // A query to send Products to a list
             
            addProdCombBx.Items.Clear();                                                     // start with empty Items collection

            foreach (var p in products)                                                        // Looping to populate Products Combo Box
            {
                addProdCombBx.Items.Add(p.ProdName);

            }

            DataGridViewColumn column0 = supplierDGrid.Columns[0];                              // Set Suppliers data grid view width
            column0.Width = 105;

            DataGridViewColumn column1 = supplierDGrid.Columns[1];
            column1.Width = 380;
                                                                                               // format the column header
            supplierDGrid.EnableHeadersVisualStyles = false;
            supplierDGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);               
            supplierDGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue;
            supplierDGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                                                                                                   // format the odd numbered rows
            supplierDGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure;

        }

        private void supplierDGrid_SelectionChanged(object sender, EventArgs e)        // Method to show porducts in ProductsSupplier data grid, which are linked to suppliers as selection changes
        {
            if (supplierDGrid.SelectedCells.Count > 0)
            {
                int index = supplierDGrid.SelectedCells[0].RowIndex;
                int supplierId = (int)supplierDGrid.Rows[index].Cells[0].Value;                          // Get supplierID frorm index of selected item

 
                currentSupplier = context.Suppliers.Find(supplierId);                                     // Get currentSupplier

                List<ProductsSupplier> productsuppliers = currentSupplier.ProductsSuppliers.ToList();      

                var prodsupplist = from ps in productsuppliers                                                // Join to get desired values for ProductSupplier data grid                                               
                                   join prod in context.Products
                                   on ps.ProductId equals prod.ProductId
                                   // select new {ps.SupplierId, prod.ProdName, prod.ProductId, ps.ProductSupplierId };
                                   select new { ps.ProductSupplierId, ps.Supplier.SupName, prod.ProdName, };


                PSDGrid.DataSource = prodsupplist.ToList();                                                        // List of data appears on productsSupplier data grid

                PSDGrid.Columns[0].HeaderText = "ProdSuplrID";                                 // Set ProductsSupplier data grid header and column width 

                DataGridViewColumn column0 = PSDGrid.Columns[0];
                column0.Width = 110;

                PSDGrid.Columns[1].HeaderText = "Supplier Name";
                DataGridViewColumn column1 = PSDGrid.Columns[1];
                column1.Width = 285;

                PSDGrid.Columns[2].HeaderText = "Product Name";
                DataGridViewColumn column2 = PSDGrid.Columns[2];
                column2.Width = 100;

                //DataGridViewColumn column3 = PSDGrid.Columns[3];
                //column3.Width = 150;

                                                                                                                  // format the column header
                PSDGrid.EnableHeadersVisualStyles = false;
                PSDGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 9, FontStyle.Bold);
                PSDGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.DarkBlue;
                PSDGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

                                                                                                                   // format the odd numbered rows
                PSDGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.Azure;

            }
        }

        private void DisplaySuppliers()                                               // Method to display suppliers when called
        {
           
           supplierDGrid.DataSource = context.Suppliers.ToList();

            //supplierDGrid.ClearSelection();
        
        }

        private void addProdBtn_Click(object sender, EventArgs e)                       // Method runs when Add Product Button Clicked    
        {
            try
            {

                var selectProd = addProdCombBx.SelectedItem;

                int index = supplierDGrid.SelectedCells[0].RowIndex;

                int supplierId = (int)supplierDGrid.Rows[index].Cells[0].Value;

                ProductsSupplier newproductsSupplier = new ProductsSupplier();                // Define  a new ProductsSupplier

                List<Product> products = context.Products.ToList();

                foreach (var p in products)                                            // Loop to give ID of the selected product from dropdown list to the new ProductsSupplier                              
                {
                    if (p.ProdName.ToString() == selectProd.ToString())
                    {
                        newproductsSupplier.ProductId = p.ProductId;
                    }
                }

                List<ProductsSupplier> productsuppliers = currentSupplier.ProductsSuppliers.ToList();               // Form a list of poductsuppliers

                foreach (var ps in productsuppliers)
                {
                    if (ps.Product.ProdName == selectProd.ToString())
                    {
                        throw new Exception("The product must be unique");                                   // Throw error if selected product is not unique
                    }
                }

                newproductsSupplier.SupplierId = supplierId;
                context.ProductsSuppliers.Add(newproductsSupplier);                     // Add new ProcutsSupplier
                context.SaveChanges();                                                  // Save in context

                DisplaySuppliers();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Exception");
            }
        }
  
        private void addsuplier_Click(object sender, EventArgs e)                   // Method run when Add Supplier Button Clicked
        {
            var addSplrFm = new AddSupplierFm()                                      // Initialize Add Supplier Form
            {
                AddProduct = true
            };
       
            DialogResult result = addSplrFm.ShowDialog();                   // ShowDialog for Add Supplier Form
            if (result == DialogResult.OK)
            {

           try
                {
                   currentSupplier = addSplrFm.Supplier;                 
                   context.Suppliers.Add(currentSupplier);                    // Add a supplier and save in context
                   context.SaveChanges();
                   DisplaySuppliers();
                }

                catch (DbUpdateConcurrencyException ex)                    // Try-catch and error handling
                {
                    HandleConcurrencyError(ex);
                }
                catch (DbUpdateException ex)
                {
                    HandleDatabaseError(ex);
                }
                catch (Exception ex)
                {
                    HandleGeneralError(ex);
                }
            }
        }

        private void supplierEditBtn_Click(object sender, EventArgs e)              // Method when Supplier Edit Button Clicked  
        {
            var addSplrFm = new AddSupplierFm()                            // Initialize Add Supplier form 
            {
                AddProduct = false,
                Supplier = currentSupplier
            };
            DialogResult result = addSplrFm.ShowDialog();
            if (result == DialogResult.OK)
            {
                try
                {
                    currentSupplier = addSplrFm.Supplier;
                    context.SaveChanges();                           // Save editing on the seleted supplier and save changes to context. 
                    DisplaySuppliers();                              // Call display Suppliers method
                }

                catch (DbUpdateConcurrencyException ex)             // Try-catch error handling
                {
                    HandleConcurrencyError(ex);
                }
                catch (DbUpdateException ex)
                {
                    HandleDatabaseError(ex);
                }
                catch (Exception ex)
                {
                    HandleGeneralError(ex);
                }
            }
        }

        private void supplierDelBtn_Click(object sender, EventArgs e)                   // Method when Delete Supplier clicked
        {
            DialogResult result =
               MessageBox.Show($"Delete {currentSupplier.SupName.Trim()}?",             // Confirm to delete pops up before proceeding to delete
               "Confirm Delete", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try                                                                // Try-catch error handling
                { 
                    context.Suppliers.Remove(currentSupplier);                    // Remove selected supplier and save changes to context
                    context.SaveChanges(true);
                    DisplaySuppliers();
                }

                catch (DbUpdateConcurrencyException ex)
                {
                    HandleConcurrencyError(ex);
                }
                catch (DbUpdateException ex)
                {
                    HandleDatabaseError(ex);
                }
                catch (Exception ex)
                {
                    HandleGeneralError(ex);
                }
            }
        }

        private void deleteProdBtn_Click(object sender, EventArgs e)                     // Method when Delete Product Button clicked
        {
            int index = PSDGrid.SelectedCells[0].RowIndex;
            int prodsupplierId = (int)PSDGrid.Rows[index].Cells[0].Value;

            currentProdSuplr = context.ProductsSuppliers.Find(prodsupplierId);                      // Determine current ProductsSupplier through ProductSupplier data grid index

            DialogResult result =
                MessageBox.Show($"Delete {currentProdSuplr.Product.ProdName.Trim()}?",        // Message pops up require confirmation before proceed to delete
                "Confirm Delete", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                context.ProductsSuppliers.Remove(currentProdSuplr);
                context.SaveChanges(true);
                DisplaySuppliers();
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)                                 // Method to Exit
        {
            this.Close();
        }

        private void HandleConcurrencyError(DbUpdateConcurrencyException ex)          // Error handling
        {
            ex.Entries.Single().Reload();

            var state = context.Entry(currentSupplier).State;
            if (state == EntityState.Detached)
            {
                MessageBox.Show("Another user has deleted that supplier.",
                    "Concurrency Error");
            }
            else
            {
                string message = "Another user has updated that product.\n" +
                    "The current database values will be displayed.";
                MessageBox.Show(message, "Concurrency Error");
            }
            this.DisplaySuppliers();
        }

        private void HandleDatabaseError(DbUpdateException ex)
        {
            string errorMessage = "";
            var sqlException = (SqlException)ex.InnerException;
            foreach (SqlError error in sqlException.Errors)
            {
                errorMessage += "ERROR CODE:  " + error.Number + " " +
                                error.Message + "\n";
            }
            MessageBox.Show(errorMessage);
        }

        private void HandleGeneralError(Exception ex)
        {
            MessageBox.Show(ex.Message, ex.GetType().ToString());
        }
    }
}
                                                                                                           //End
