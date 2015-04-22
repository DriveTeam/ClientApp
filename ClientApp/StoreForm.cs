﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientApp
{
    public partial class StoreForm : Form
    {
        public StoreForm()
        {
            InitializeComponent();
        }
        private MainForm mainForm = null;
        public StoreForm(Form callingForm)
        {
            mainForm = callingForm as MainForm;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainForm.Show();
            this.Hide();
        }
    }
}