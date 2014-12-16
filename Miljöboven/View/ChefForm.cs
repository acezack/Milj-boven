using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Miljöboven
{
    public partial class ChefForm : Form
    {
        Inloggningsform inloggningsform;
        public ChefForm(Inloggningsform inloggningsform)
        {
            InitializeComponent();
            this.inloggningsform = inloggningsform;
        }

        private void Chefform_Load(object sender, EventArgs e)
        {

        }

        private void Chefform_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
