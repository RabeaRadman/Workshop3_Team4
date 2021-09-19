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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void BtnOpenPackages_Click(object sender, EventArgs e)
        {
            FrmPackages openPackage = new FrmPackages();
            openPackage.ShowDialog();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ProductsForm openForm = new ProductsForm(); //create new Products form object
            openForm.Show(); //show Products form
        }

        private void btnSuppliers_Click(object sender, EventArgs e)
        {
            SuppliersDisplayFrm openSupplierForm = new SuppliersDisplayFrm();
            openSupplierForm.ShowDialog();
        }

        private void displayallBtn_Click(object sender, EventArgs e)
        {
            DisplayAllFrm opendisplayallForm = new DisplayAllFrm();
            opendisplayallForm.ShowDialog();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit(); //exit application.
        }

    }//class
}//namespace
