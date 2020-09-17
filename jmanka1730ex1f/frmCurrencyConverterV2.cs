using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jmanka1730ex1f
{
    public partial class frmCurrencyConverterV2 : Form
    {
        public frmCurrencyConverterV2()
        {
            InitializeComponent();
        }

        private void frmCurrencyConverterV2_Load(object sender, EventArgs e)
        {
            btnBarbados.BackgroundImage = picBarbados.Image;
            btnHongKong.BackgroundImage = picHongKongDim.Image;
            btnJamaica.BackgroundImage = picJamaicaDim.Image;
            btnKenya.BackgroundImage = picKenyaDim.Image;
            txtCurrency.Text = "0.00";
            txtRate.Text = ".5";
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            lblCurrency.Text = btnBarbados.Text + ":";
            this.ActiveControl = txtCurrency;
        }

        private void btnBarbados_Click(object sender, EventArgs e)
        {
            btnBarbados.BackgroundImage = picBarbados.Image;
            btnHongKong.BackgroundImage = picHongKongDim.Image;
            btnJamaica.BackgroundImage = picJamaicaDim.Image;
            btnKenya.BackgroundImage = picKenyaDim.Image;
            txtRate.Text = ".5";
            lblCurrency.Text = btnBarbados.Text + ":";
            this.ActiveControl = txtCurrency;
        }

        private void btnHongKong_Click(object sender, EventArgs e)
        {
            btnHongKong.BackgroundImage = picHongKong.Image;
            btnBarbados.BackgroundImage = picBarbadosDim.Image;
            btnJamaica.BackgroundImage = picJamaicaDim.Image;
            btnKenya.BackgroundImage = picKenyaDim.Image;
            txtRate.Text = "0.129030";
            lblCurrency.Text = btnHongKong.Text + ":";
            this.ActiveControl = txtCurrency;
        }

        private void btnJamaica_Click(object sender, EventArgs e)
        {
            btnJamaica.BackgroundImage = picJamaica.Image;
            btnHongKong.BackgroundImage = picHongKongDim.Image;
            btnBarbados.BackgroundImage = picBarbadosDim.Image;
            btnKenya.BackgroundImage = picKenyaDim.Image;
            txtRate.Text = "0.00669261";
            lblCurrency.Text = btnJamaica.Text + ":";
            this.ActiveControl = txtCurrency;
        }

        private void btnKenya_Click(object sender, EventArgs e)
        {
            btnKenya.BackgroundImage = picKenya.Image;
            btnJamaica.BackgroundImage = picJamaicaDim.Image;
            btnHongKong.BackgroundImage = picHongKongDim.Image;
            btnBarbados.BackgroundImage = picBarbadosDim.Image;
            txtRate.Text = "0.00922934";
            lblCurrency.Text = btnKenya.Text + ":";
            this.ActiveControl = txtCurrency;
        }

        private void calcUSD(object sender, EventArgs e)
        {
            txtUSDollars.Text = (
               Convert.ToDecimal(txtCurrency.Text) * Convert.ToDecimal(txtRate.Text)
               ).ToString("0.00");

        }

        private void txtCurrency_Enter(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void txtRate_Enter(object sender, EventArgs e)
        {
            txtRate.SelectAll();
        }

        private void txtUSDollars_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnBarbados.BackgroundImage = picBarbados.Image;
            btnHongKong.BackgroundImage = picHongKongDim.Image;
            btnJamaica.BackgroundImage = picJamaicaDim.Image;
            btnKenya.BackgroundImage = picKenyaDim.Image;
            txtCurrency.Text = "0.00";
            txtRate.Text = ".5";
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            lblCurrency.Text = btnBarbados.Text + ":";
            lblEquation.Text = "";
            this.ActiveControl = txtCurrency;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (
               Convert.ToDecimal(txtTotalUSD.Text) + Convert.ToDecimal(txtUSDollars.Text)
               ).ToString("0.00");
            lblEquation.Text = lblEquation.Text + " + " + txtUSDollars.Text;
            this.ActiveControl = txtCurrency;
        }

        private void txtTotalUSD_TextChanged(object sender, EventArgs e)
        {

        }
    }

}


