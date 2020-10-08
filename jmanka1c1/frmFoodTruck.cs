using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jmanka1c1
{
    public partial class frmFoodTruck : Form
    {
        public frmFoodTruck()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            
            //txtHotDogsSubtotal.Text = (
            //         4.0m * Convert.ToDecimal(txtHotdogs.Text)
            //    ).ToString("0.00");
            int Hotdogs = Convert.ToInt32(txtHotdogs.Text);
            decimal HotdogPrice = 4.0m;
            decimal HotdogSubtotal = Hotdogs * HotdogPrice;
            txtHotDogsSubtotal.Text = HotdogSubtotal.ToString("0.00");
            
            //txtHamburgersSubtotal.Text = (
            //        5.0m * Convert.ToDecimal(txtHamburgers.Text)
            //    ).ToString("0.00");
            int Hamburgers = Convert.ToInt32(txtHamburgers.Text);
            decimal HamburgerPrice = 5.0m;
            decimal HamburgerSubtotal = Hamburgers * HamburgerPrice;
            txtHamburgersSubtotal.Text = HamburgerSubtotal.ToString("0.00");

            //txtPretaxTotal.Text = (
            //        Convert.ToDecimal(txtHotDogsSubtotal.Text) + Convert.ToDecimal(txtHamburgersSubtotal.Text)
            //    ).ToString("0.00");
            decimal preTaxTotal = HotdogSubtotal + HamburgerSubtotal;
            txtPretaxTotal.Text = preTaxTotal.ToString("0.00");

            //txtTax.Text = (
            //        .06875m * Convert.ToDecimal(txtPretaxTotal.Text)
            //   ).ToString("0.00");
            decimal Tax = .06875m * preTaxTotal;
            txtTax.Text = Tax.ToString("0.00");

            //txtTotal.Text = (
            //    Convert.ToDecimal(txtPretaxTotal.Text) + Convert.ToDecimal(txtTax.Text)
            //     ).ToString("0.00");
            decimal total = preTaxTotal + Tax;
            txtTotal.Text = total.ToString("0.00");

            btnClear.Focus();
        }

        private void frmFoodTruck_Load(object sender, EventArgs e)
        {

        }

        private void txtPretaxTotal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHotdogs.Text = "0";
            txtHamburgers.Text = "0";
            txtHotDogsSubtotal.Text = "";
            txtHamburgersSubtotal.Text = "";
            txtPretaxTotal.Text = "";
            txtTax.Text = "";
            txtTotal.Text = "";

            txtHotdogs.Focus();
        }
    }
}
