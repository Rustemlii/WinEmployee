using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinEmployee
{
    public partial class LoginPassword : Form
    {
        public LoginPassword()
        {
            InitializeComponent();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtLogin.Text) && txtLogin.Text.ToLower() == "demo" && !string.IsNullOrEmpty(txtPassword.Text) &&
                txtPassword.Text.ToLower() == "123")
            {
                Admin ad = new Admin();
                ad.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Parol veya User yanlishdir", "Xeta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
