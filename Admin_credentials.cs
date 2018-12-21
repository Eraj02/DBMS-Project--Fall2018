using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gym_MS
{
    public partial class Admin_credentials : Form
    {
        // Making a private object in order to return to the prev form
        private Home home;
        public Admin_credentials(Home h)
        {
            home = h;
            InitializeComponent();
        }

        private void admin_Login_Click(object sender, EventArgs e)
        {
            if ((admin_Id.Text == "admin") && (admin_pw.Text =="mygym"))
            {
                Admin_login a = new Admin_login(home);
                a.Show();
                this.Hide();
                home.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Credential, please recheck!");
            }

        }

        private void admin_login_back_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
