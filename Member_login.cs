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
    public partial class Member_login : Form
    {
        // To return to previous forms
        private Home home;
        // To have the member ID and Branch ID here as an object
        private Member_credentials member;
        public Member_login(Home h, Member_credentials m)
        {
            home = h;
            member = m;
            InitializeComponent();
        }

        private void logout_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Close();
            
        }

        private void view_packages_Click(object sender, EventArgs e)
        {
            Packages pack = new Packages(this);
            pack.Show();
            this.Hide();
        }

        private void view_schedule_Click(object sender, EventArgs e)
        {
            Schedule class_ = new Schedule(this, member.branch_ID);
            class_.Show();
            this.Hide();
        }

        private void rate_Click(object sender, EventArgs e)
        {
            Rating rate = new Rating(member.member_ID,member.branch_ID,this);
            rate.Show();
            this.Hide();
        }
    }
}
