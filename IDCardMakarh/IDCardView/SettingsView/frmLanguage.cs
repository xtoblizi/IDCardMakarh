using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IDCardView.Settings
{
    public partial class frmLanguage : Form
    {
        public frmLanguage()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if ((cmbSelectLanguage.SelectedItem.ToString() != "English"))
            {
                MessageBox.Show("Please select english, other updates would include this option. Thanks", "Option Info", MessageBoxButtons.OKCancel);

            }

            else
            {
                frmSplashScreen newSplashscreen = new frmSplashScreen();
                newSplashscreen.Show();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("Do you wish to exit this application", "Exit Confirmation", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                Application.Exit();
            }
            // confirm= messag
            
        }
    }
}
