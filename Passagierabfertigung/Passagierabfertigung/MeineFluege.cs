﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passagierabfertigung
{
    public partial class MeineFluege : Form
    {
        public MeineFluege()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}