using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauxUI
{
    public partial class CreateAccountForm : Form
    {
        public CreateAccountForm()
        {
            InitializeComponent();
        }

        private void butAddUser_Click(object sender, EventArgs e)
        {
            bool creationSuccess = false;
            string emptyString = "";
            

            if (creationSuccess == true)
            {

            }
            else { }

            if (emptyString == "")
            {
                MessageBox.Show("Can not leave this field empty!", "NOTE", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
