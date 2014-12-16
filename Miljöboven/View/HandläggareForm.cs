using System;
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
    public partial class HandläggareForm : Form
    {
        View.InloggningsForm inloggningsForm;
        public HandläggareForm(View.InloggningsForm inloggningsForm)
        {
            InitializeComponent();
            this.inloggningsForm = inloggningsForm;
        }

        private void HandläggareForm_Load(object sender, EventArgs e)
        {

        }

        private void HandläggareForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            inloggningsForm.Show();
        }
    }
}
