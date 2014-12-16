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

        ChefForm chefForm;
        HandläggareForm handläggareForm;
        MiljösamordnareForm miljösamordnareForm;

        private void btnLoggaIn_Click(object sender, EventArgs e)
        {
            if (true) //Om man är en "chef"
            {
                chefForm = new ChefForm(this);
                chefForm.Show();
                this.Hide();
            }
            else if (true) //Om man är en "handläggare"
            {
                handläggareForm = new HandläggareForm(this);
                handläggareForm.Show();
                this.Hide();
            }
            else if (true) //Om man är en "miljösamordnare"
            {
                miljösamordnareForm = new MiljösamordnareForm(this);
                miljösamordnareForm.Show();
                this.Hide();
            }
        }

        private void Inloggningsform_Load(object sender, EventArgs e)
        {

        }
    }
}
