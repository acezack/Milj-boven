﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miljöboven.View
{
    public partial class ChefForm : Form
    {
        InloggningsForm inloggningsForm;
        public ChefForm(InloggningsForm inloggningsForm)
        {
            InitializeComponent();
            this.inloggningsForm = inloggningsForm;
        }

        private void ChefForm_Load(object sender, EventArgs e)
        {

        }

        private void ChefForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
