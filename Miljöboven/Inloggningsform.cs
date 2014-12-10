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
    public partial class Inloggningsform : Form
    {
        public Inloggningsform()
        {
            InitializeComponent();
        }

        Chefform chefform;
        Handläggareform handläggareform;
        Miljösamordnareform miljösamordnareform;

        private void btnLoggaIn_Click(object sender, EventArgs e)
        {
            if (false) //Om man är en "chef"
            {
                chefform = new Chefform(this);
                chefform.Show();
                this.Hide();
            }
            else if (true) //Om man är en "handläggare"
            {
                handläggareform = new Handläggareform(this);
                handläggareform.Show();
                this.Hide();
            }
            else if (true) //Om man är en "miljösamordnare"
            {
                miljösamordnareform = new Miljösamordnareform(this);
                miljösamordnareform.Show();
                this.Hide();
            }
        }

        private void Inloggningsform_Load(object sender, EventArgs e)
        {

        }
    }
}
