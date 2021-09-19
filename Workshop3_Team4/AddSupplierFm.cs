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

namespace Workshop3_Team4
{
    public partial class AddSupplierFm : Form
    {

        public Supplier Supplier { get; set; }                 // Getter-setters     
        public bool AddProduct { get; set; }

        public AddSupplierFm()
        {
            InitializeComponent();
        }
      
        private void addsplBtn_Click(object sender, EventArgs e)                    // Method when Add Supplier Button Clicked
        {
            if (IsValidData())                                                    // Condition check IsValidData method 
            {
                if (AddProduct)                                                     // Condition check if AddProduct set true
                {
                    // initialize the Product property with new Products object
                    this.Supplier = new Supplier();

                    try                                                                                                    
                    {
                        using (var context = new TravelExpertsContext())
                        {
                            List<Supplier> suppliers = context.Suppliers.ToList();                    // Form a list of Supplies from Context

                            foreach (var s in suppliers)                                                // Looping to ensure entered SupplierID is not duplicate
                            {
                                if (s.SupplierId == Convert.ToInt32(supplierIDBx.Text))
                                {
                                    throw new Exception("The SupplierID must be unique");               // Throw error if SupplierID is not unique
                                }
                            }
                        }

                        this.LoadSupplierData();

                        this.DialogResult = DialogResult.OK;
                    }

                    catch (Exception ex)                                                      // Try-catch error handling                  
                    {
                        MessageBox.Show(ex.Message, "Exception");                             
                    }

                }
                
                else                                                                       // Else condition for Edit
                {
                    this.LoadSupplierData();
                    this.DialogResult = DialogResult.OK;
                }
            }
        }

        private void AddSupplierFm_Load(object sender, EventArgs e)                      // Method when Add Supplier Button Clicked
        {
            if (AddProduct)
            {
                this.Text = "Add Product";
                supplierIDBx.ReadOnly = false;          // allow entry of new product code
            }
            else
            {
                this.Text = "Edit Product";
                supplierIDBx.ReadOnly = true;       // can't change existing product code
                this.DisplaySupplier();
            }
        }

        private void DisplaySupplier()
        {
                supplierIDBx.Text = Supplier.SupplierId.ToString();
                suplrTB.Text = Supplier.SupName;
        }

        private bool IsValidData()                                            // Method for validation
        {
            bool success = true;
            string errorMessage = "";

            errorMessage += ValidatorAddSupplier.IsPresent(suplrTB.Text, suplrTB.Tag.ToString());
            errorMessage += ValidatorAddSupplier.IsPresent(supplierIDBx.Text, supplierIDBx.Tag.ToString());

            errorMessage += ValidatorAddSupplier.IsInt32(supplierIDBx.Text, supplierIDBx.Tag.ToString());

            errorMessage += ValidatorAddSupplier.IsStringLgtNameOK(suplrTB.Text, suplrTB.Tag.ToString());
            errorMessage += ValidatorAddSupplier.IsIntLgtNameOK(supplierIDBx.Text, supplierIDBx.Tag.ToString());

            if (errorMessage != "")
            {
                success = false;
                MessageBox.Show(errorMessage, "Entry Error");
            }
            return success;
        }

        private void LoadSupplierData()                                                // Method to load data from Add Supplier Form when called
        {
            Supplier.SupplierId = Convert.ToInt32(supplierIDBx.Text);

            Supplier.SupName = suplrTB.Text;
        }
        
        private void cancelBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
                                                                  // END
