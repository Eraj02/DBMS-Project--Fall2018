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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Go_Click(object sender, EventArgs e)
        {
            if (member.Checked)
            {
                Member_credentials m = new Member_credentials(this);
                m.Show();
                this.Hide();
            }
            else if (admin.Checked)
            {
                Admin_credentials a = new Admin_credentials(this);
                a.Show();
                this.Hide();
            }
        }
    }
}
