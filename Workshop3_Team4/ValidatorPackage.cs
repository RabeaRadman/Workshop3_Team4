using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Workshop3_Team4
{
    /// <summary>
    /// Validates the following:
    /// Agency Commission cannot be greater than the Base Price
    /// Package End Date must be later than Package Start Date
    /// Package Name and Package Description cannot be null
    /// 
    /// </summary>
    /// <returns>invalid if above condition is met otherwise data input is valid</returns>
    class ValidatorPackage
    {
        private static decimal tmpbaseprice = 0.0m;           //temporary placeholder for Version
        private static decimal tmpagencycomm = 0.0m;           //temporary placeholder for Version

        public static bool IsPresent(TextBox tb, Label lb)
        {
            bool result = true; // Text is not empty
            lb.Visible = false;
            if (tb.Text == "")
            {
                lb.Text = tb.Tag + " must be provided";
                lb.Visible = true;
                result = false; // Text is empty
            }

            return result;
        }

        public static bool IsMore50(TextBox tb, Label lb)
        {
            bool result = true; // Text  is less than 50 characters
            lb.Visible = false;
            if (tb.TextLength > 50)
            {
                lb.Text = tb.Tag + " cannot be more than 50 characters";
                lb.Visible = true;
                result = false; // Text is more than 50 characters
            }

            return result;
        }

        public static bool IsEndDateLater(DateTimePicker ds, DateTimePicker de, Label lb)
        {
           
            bool result = true; // Text  is less than 50 characters
            lb.Visible = false;           
                
            if (ds.Value >= de.Value)
            {
                lb.Text = ds.Tag + " cannot be same date as or after " + de.Tag;
                lb.Visible = true;
                result = false; // Text is more than 50 characters
            }

            return result;
        }
        public static bool IsNotAlpha(TextBox tb, Label lb)
        {
            bool result = true;
            lb.Visible = false;
            try
            {
                tmpbaseprice = Convert.ToDecimal(tb.Text);
                             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                    ex.GetType().ToString(), "Exception");

                lb.Text = tb.Tag + " must be numeric";
                lb.Visible = true;
                result = false;                      // This is Alpha. Must be numeric
            }
            return result;
        }

        public static bool IsPositive(TextBox tb, Label lb)
        {
            bool result = true;
            lb.Visible = false;
            try
            {
                tmpbaseprice = Convert.ToDecimal(tb.Text);
                if (tmpbaseprice < 1)
                {
                    lb.Text = tb.Tag + " has to be greater than 0";
                    lb.Visible = true;
                    result = false;                      // This is negative, has to be positve
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                   ex.GetType().ToString(), "Exception");
              
            }
            return result;
        }

        public static bool IsDecimal(TextBox tb, Label lb)
        {
            Regex reg = new Regex(@"\d{1,18}\.\d{0,2}$");
            bool result = reg.IsMatch(tb.Text.Trim());
            lb.Visible = false;
            if (!result)
            {
                lb.Text = tb.Tag + " can only have upto 2 decimal places";
                lb.Visible = true;
                result = false;
            }

            return result;
        }

        public static bool IsLessThanAgency(TextBox tb, TextBox tba, Label lb)
        {
            string texttb = "0.0";
            string texttba = "0.0";
            bool result = true;
            lb.Visible = false;
            
            if (tb.Text != "")
                texttb = tb.Text;
            if (tba.Text != "")
                texttba = tba.Text;

            try
            {
                tmpbaseprice = Convert.ToDecimal(texttb);
                tmpagencycomm = Convert.ToDecimal(texttba);

                if (tmpbaseprice < tmpagencycomm)
                {
                    lb.Text = tb.Tag + " has to be greater than " + tba.Tag;
                    lb.Visible = true;
                    result = false;                      // This is negative, has to be numeric
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                   ex.GetType().ToString(), "Exception");

            }
            return result;
        }

        public static bool IsPresentProdSupp(ComboBox cp, Label lb)
        {
            bool result = true; // Text is not empty
            lb.Visible = false;
            if (cp.Text == "")
            {
                lb.Text = cp.Tag + " must be provided";
                lb.Visible = true;
                result = false; // Text is empty
            }

            return result;
        }
    }
}
