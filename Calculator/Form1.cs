﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btCong_Click(object sender, EventArgs e)
        {
            if (txtSoA.Text != String.Empty || txtSoB.Text != String.Empty)
            {
                double a = double.Parse(txtSoA.Text);
                double b = double.Parse(txtSoB.Text);
                double c = a + b;
                txtKetQua.Text = c.ToString(); 
            }
        }

        private void btTru_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txtSoA.Text);
            double b = double.Parse(txtSoB.Text);
            double c = a - b;
            txtKetQua.Text = c.ToString();
        }
    }
}
