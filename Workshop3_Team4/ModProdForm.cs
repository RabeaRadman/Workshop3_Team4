
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


//Modify Products form - allows for modification of product names.
namespace Workshop3_Team4
{
    public partial class ModProdForm : Form
    {
        TravelExpertsContext context;    // The DB context

        public ModProdForm()
        {
            InitializeComponent();
        }
        //Modify Form OK Button Routine
        private void btnModProdOK_Click(object sender, EventArgs e)
        {
            using (context = new TravelExpertsContext())
            {
                Product Pro = new Product();    //Create new product object.
                Pro.ProductId = Convert.ToInt32(txtProdID.Text); //convert text box value to integer and assign to object.
                Pro.ProdName = txtProdName.Text;    //assign text box value to object.
                context.Products.Update(Pro);   //Update database table.
                context.SaveChanges();  //save changes in database.
                this.Close();   //closes modify product form.
                ProductsForm pf = new ProductsForm();       //create new Products form object.
                pf.Show();  //makes products form visible. 
            };
        }

        private void btnModProdCancel_Click(object sender, EventArgs e)
        {
            Visible = false;    //hides modify products form.
            ProductsForm pf = new ProductsForm();   //create new Products form object.
            pf.Show();  //makes products form visible. 
        }

        private void ModProdForm_Load(object sender, EventArgs e)
        {


        }
    }
}
