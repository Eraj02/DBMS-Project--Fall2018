using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Gym_MS
{
    public partial class Member_credentials : Form
    {
        // Making a private object in order to return to the prev form
        private Home home;
        public int member_ID;
        public int branch_ID;

        public Member_credentials(Home h)
        {
            home = h;
            InitializeComponent();
        }

        private void mem_Login_Click(object sender, EventArgs e)
        {
            // Open database to look for correct ID and password.
            // The branch and ID is Saved for all other forms.
            if ((member_Id.TextLength > 0) && (member_pw.TextLength >0))
            {
                string email, pw;

                SqlConnection sq = new SqlConnection();
                sq.ConnectionString = "Data Source=DESKTOP-863JJKV;Initial Catalog=Project;Integrated Security=True";
                SqlCommand cmd = new SqlCommand("select * from [Members] where email=@username and Password=@password ", sq);
                cmd.Parameters.AddWithValue("@username", member_Id.Text);
                cmd.Parameters.AddWithValue("@password", member_pw.Text);
                sq.Open();
                SqlDataReader sq_reader=cmd.ExecuteReader();
                
                bool match = false;

                
                while ((sq_reader.Read()))
                {
                    
                    email = sq_reader["email"].ToString();
                    pw = sq_reader["Password"].ToString();

                    if ((member_Id.Text.Trim() == email.Trim()) && (member_pw.Text.Trim() == pw.Trim()))
                    {

                        match = true;
                        member_ID = Convert.ToInt32(sq_reader["ID"]);
                        branch_ID = Convert.ToInt32(sq_reader["Branch_ID"]);
                        MessageBox.Show("Successful log-in!");
                        // Passing both these objects for Branch and ID
                        Member_login member = new Member_login(home, this);
                        member.Show();
                        this.Close();
                    }
                }
                // If none found.
                if (!match)
                {
                    MessageBox.Show("Incorrect credentials, Try again!");
                    home.Show();
                    this.Close();
                    sq_reader.Close();
                    sq.Close();
                }
               
            }
            

        }

        private void mem_login_back_Click(object sender, EventArgs e)
        {
            home.Show();
            this.Close();
        }

        private void sign_up_Click(object sender, EventArgs e)
        {
            Sign_up new_ = new Sign_up(home);
            new_.Show();
            this.Hide();
        }
    }
}
