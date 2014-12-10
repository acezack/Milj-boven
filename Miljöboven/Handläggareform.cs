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
    public partial class Handläggareform : Form
    {
        Inloggningsform inloggningsform;
        public Handläggareform(Inloggningsform inloggningsform)
        {
            InitializeComponent();
            this.inloggningsform = inloggningsform;
        }

        private void Handläggareform_Load(object sender, EventArgs e)
        {

        }

        private void Handläggareform_FormClosing(object sender, FormClosingEventArgs e)
        {
            inloggningsform.Show();
        }
    }
}
