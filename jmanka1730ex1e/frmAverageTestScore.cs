﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace jmanka1730ex1e
{
    public partial class AverageTestScore : Form
    {
        public AverageTestScore()
        {
            InitializeComponent();
        }

        private void AverageTestScore_Load(object sender, EventArgs e)
        {
           
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtAverage.Text = (
                ((Convert.ToDecimal(txtTest1.Text) + Convert.ToDecimal(txtTest2.Text) + Convert.ToDecimal(txtTest3.Text)) / 3)
                .ToString("0.00"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtTest1.Text = "0";
            txtTest2.Text = "0";
            txtTest3.Text = "0";
            txtAverage.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
