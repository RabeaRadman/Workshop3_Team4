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

//Add product form - allows for addition of new products.

namespace Workshop3_Team4
{
    public partial class AddProdForm : Form
    {
        TravelExpertsContext context;    // The DB context

        public AddProdForm()
        {
            InitializeComponent();
        }
        //Add Product Form OK Button Routine
        private void btnAddProdOK_Click(object sender, EventArgs e)
        {
            ProductsForm form1 = new ProductsForm();    //create new products form object.
        
            using (context = new TravelExpertsContext())
            {
                Product Pro = new Product();        //Create new product object.
                Pro.ProdName = txtProdName.Text;    //assign text box value to object name.
                context.Products.Add(Pro);      //add new object to Products table.
                context.SaveChanges();      //save changes in database.
            };

            this.Close(); //closes add form.
            //makes new Products form object visible
            form1.Show();
        }

        private void btnAddProdCancel_Click(object sender, EventArgs e)
        {
            Visible = false;    //hide add form.
            ProductsForm pf = new ProductsForm();   //create new products form object.
            pf.Show();  //makes products form visible. 
        }


        private void AddProdForm_Load(object sender, EventArgs e)
        {


        }
    }
}
