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
    public partial class MiljösamordnareForm : Form
    {
        Inloggningsform inloggningsform;
        public MiljösamordnareForm(Inloggningsform inloggningsform)
        {
            InitializeComponent();
            this.inloggningsform = inloggningsform;
        }

        private void Miljösamordnareform_Load(object sender, EventArgs e)
        {

        }
    }
}
