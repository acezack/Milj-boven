using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Miljöboven.Controller;
using Miljöboven.View;

namespace Miljöboven.View
{
    public partial class InloggningsForm : Form
    {

        public InloggningsForm()
        {
            InitializeComponent();
            userList = new UserList<User>();
        }

        View.ChefForm chefForm;
        View.HandläggareForm handläggareForm;
        View.MiljösamordnareForm miljösamordnareForm;
        View.AdminForm adminForm;
        UserList userList;

        private void btnLoggaIn_Click(object sender, EventArgs e)
        {
            for (int index = 0; index < UserList.GetCount; index++)
			{
                if (tbxAnvändarnamn.Text == UserList[index].UserName && tbxLösenord.Text == formMain.userList[index].Password)
                {
                    chefForm.Show();
                    this.Close();
                }
			}
        }

        private void InloggningsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
