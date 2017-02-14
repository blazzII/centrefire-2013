using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CenterFireBulletWeighing
{
    public partial class frmLogin : Form
    {
        int loginCount = 0;
        
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.pnlMessage.Visible = false;
            if (this.txtLogin.Text == "x") // db embed? Security issues with .accdb access to all users
            {
                frmEditLot editLot = new frmEditLot();
                editLot.Show();
                this.Close();
            }
            else
            {
                loginCount += 1;
                if (loginCount >= 3)
                {
                    this.Close();
                }
                else
                {
                    this.pnlMessage.Visible = true;
                    this.txtLogin.Clear();
                    this.txtLogin.Focus();
                }
            }
        }
    }
}
