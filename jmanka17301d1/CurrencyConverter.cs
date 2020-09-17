using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jmanka17301d1
{
    public partial class CurrencyConverter : Form
    {
        public CurrencyConverter()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BarbadosTextChanged(object sender, EventArgs e)
        {
            txtUSDBarbados.Text = (
                 Convert.ToDecimal(txtAmountBarbados.Text) * Convert.ToDecimal(txtRateBarbados.Text)
                 ).ToString("0.00");
        }

        private void HongKongTextChanged(object sender, EventArgs e)
        {
            txtUSDHongKong.Text = (
                  Convert.ToDecimal(txtAmountHongKong.Text) * Convert.ToDecimal(txtRateHongKong.Text)
                  ).ToString("0.00");
        }

        private void txtUSDHongKong_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void JamaicaTextChanged(object sender, EventArgs e)
        {
            txtUSDJamaica.Text = (
                 Convert.ToDecimal(txtAmountJamaica.Text) * Convert.ToDecimal(txtRateJamaica.Text)
                 ).ToString("0.00");
        }

        private void txtUSDJamaica_TextChanged(object sender, EventArgs e)
        {

        }

        private void KenyaTextChanged(object sender, EventArgs e)
        {
            txtUSDKenya.Text = (
                 Convert.ToDecimal(txtAmountKenya.Text) * Convert.ToDecimal(txtRateKenya.Text)
                 ).ToString("0.00");
        }

        private void usdTextChanged(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (
                Convert.ToDecimal (txtUSDBarbados.Text) + Convert.ToDecimal (txtUSDHongKong.Text) + Convert.ToDecimal (txtUSDJamaica.Text) + Convert.ToDecimal (txtUSDKenya.Text)
                ).ToString("0.00");
        }

        private void txtTotalUSD_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAmountBarbados.Text = "0.00";
            txtRateBarbados.Text = "0.5";
            txtAmountHongKong.Text = "0.00";
            txtRateHongKong.Text = "0.129030";
            txtAmountJamaica.Text = "0.00";
            txtRateJamaica.Text = "0.00669261";
            txtAmountKenya.Text = "0.00";
            txtRateKenya.Text = "0.00922934";

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CurrencyConverter_Load(object sender, EventArgs e)
        {

        }
    }
    }
    
    

            
