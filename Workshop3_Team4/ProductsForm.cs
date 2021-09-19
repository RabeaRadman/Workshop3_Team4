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

//Products form - allows for viewing and deletion of products in the products table.

namespace Workshop3_Team4
{
    public partial class ProductsForm : Form
    {
        TravelExpertsContext context;    // The DB context


        public ProductsForm()
        {
            InitializeComponent();
        }

        private void btnProdExit_Click(object sender, EventArgs e)
        {
            Visible = false;    //hide Products form.
        }

        //Products Form delete button.
        private void btnProdDel_Click(object sender, EventArgs e)
        {
            this.Hide(); //hide main form
            if (listBoxProds.SelectedIndex != -1)   //if listbox has a selection.
            {
                String[] productId = listBoxProds.SelectedItem.ToString().Split("\t\t");      //parse list box item and pass strings to array.
                Product product = (Product)context.Products.Find(Convert.ToInt32(productId[0]));      //convert first array index  item to integer and find product to delete in table.
                string message = "Are you sure you want to delete " + productId[1].ToString() + "?";    // message box confirming delete.
             
                DialogResult button = MessageBox.Show(message, "Confirm Delete", MessageBoxButtons.YesNo);

                if (button == DialogResult.Yes)     //if user confirms delete.
                {
                    try     //error handling for database errors (foreign key).
                    {
                        listBoxProds.Items.RemoveAt(listBoxProds.SelectedIndex);
                        context.Products.Remove(product);
                        context.SaveChanges();
                    }
                    catch (Exception exception)
                    {
                        MessageBox.Show(exception.InnerException.ToString());
                    }
                    finally
                    {

                        this.Show();
                    }
                }
                else
                {
                    this.Show();
                }
            }

            else    //if list box does not have a selection.
            {
                MessageBox.Show("Please select item from listbox");         //ask user to make a selection. 
                this.Show();
            }

        }
        //Products form add/edit button routine
        private void btnProdAdd_Click(object sender, EventArgs e)
        {
            this.Hide(); //hide main form
            if (listBoxProds.SelectedIndex != -1)       //if there is an item selected in list box, create new modify form object.
            {
                ModProdForm openForm = new ModProdForm(); 
                String[] dat = listBoxProds.SelectedItem.ToString().Split("\t\t");  //create string array & insert selected item in list box as substring split on tabs. 
                openForm.txtProdID.Text = dat[0];     //put first array element into second form product code text box.
                openForm.txtProdID.Enabled = false;  //disable product code text box on second form - validation.
                openForm.txtProdName.Text = dat[1];         //put second array element into second form product code text box.
                openForm.Show(); //show modify form
            }
            else        //if there is no item selected in the list box, open new add product form.
            {
                AddProdForm openForm = new AddProdForm(); //create new add form object
                openForm.Show(); //show add form
            }
        }
        //Products form load routine
        private void FormProducts_Load(object sender, EventArgs e)
        {
            this.Refresh();     //refresh Products form
            context = new TravelExpertsContext(); //instantiate DB context.
            List<Product> allprod = context.Products.ToList();  //create new list and add Products table contents.
            foreach (Product product in allprod)
            {
                listBoxProds.Items.Add("\t" + product.ProductId + "\t\t" + product.ProdName);   //concatenate list elements and add to list box.

            }
           
            
        }

    }
}
