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
    public partial class Admin_login : Form
    {
        // To return to the first form
        private Home home;
        public Admin_login(Home h)
        {
            home = h;
            InitializeComponent();
        }

        private void admin_logout_Click(object sender, EventArgs e)
        {
            this.Close();
            home.Show();
        }

        private void view_packages_Click(object sender, EventArgs e)
        {
            Packages pack = new Packages();
            pack.Show();
        }

        private void view_TD_Click(object sender, EventArgs e)
        {
            Trainer_details t = new Trainer_details();
            t.Show();

        }

        private void view_MD_Click(object sender, EventArgs e)
        {
            Member_details m = new Member_details();
            m.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Subs sub = new Subs();
            sub.Show();
        }
    }
}
