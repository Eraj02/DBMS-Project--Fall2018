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
    public partial class Sign_up : Form
    {
        private Home home;
        int id =0;
        string password="";
        int branch_id=0;
        int membership_id=0;
        string first_name="";
        string last_name="";
        string email="";
        string phone_no="";
        string dob="";
        char gender;
        string city = "Karachi";
        int block=0;

        public Sign_up(Home h)
        {
            home = h;
            InitializeComponent();

            SqlConnection sq = new SqlConnection("Data Source=DESKTOP-863JJKV;Initial Catalog=Project;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            SqlDataReader sq_reader;

            sq.Open();
            command.CommandText = "select Gym_name from Gyms";
            command.Connection = sq;
            sq_reader = command.ExecuteReader();
            while (sq_reader.Read())
            {
                gym_combo.Items.Add(sq_reader["Gym_name"].ToString());

            }

            sq_reader.Close();
            sq.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            gender = 'M';
        }

        private void label4_Click(object sender, EventArgs e)
        {
            // Getting the last PK to insert next data
            SqlConnection sq = new SqlConnection("Data Source=DESKTOP-863JJKV;Initial Catalog=Project;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            SqlDataReader sq_reader;

            sq.Open();
            command.CommandText = "select top 1 ID from Members order by ID desc";
            command.Connection = sq;
            sq_reader = command.ExecuteReader();

            if (sq_reader.Read())
            {
                id = Convert.ToInt32(sq_reader["ID"]);
                id = id + 1;
            }
            sq_reader.Close();


            if ((id != 0) && (password != "") && (branch_id != 0) && (membership_id!=0) && (first_name!="")
                && (last_name!="") && (email!="") && (phone_no!="") && (dob!="") && (block!=0))
            {
                command.CommandText = "insert into members(ID,Password, Branch_ID, Membership_ID, First_Name, Last_Name, email, Phone_no, DOB, Gender, City, Block) values(@id,@pw,@bid,@mid,@fn,@ln,@eml,@phne,@bday,@gender,@cit,@Block)";
                command.Connection = sq;
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@pw", password);
                command.Parameters.AddWithValue("@bid", branch_id);
                command.Parameters.AddWithValue("@mid", membership_id);
                command.Parameters.AddWithValue("@fn", first_name);
                command.Parameters.AddWithValue("@ln", last_name);
                command.Parameters.AddWithValue("@eml", email);
                command.Parameters.AddWithValue("@phne", phone_no);
                command.Parameters.AddWithValue("@bday", dob);
                command.Parameters.AddWithValue("@gender", gender);
                command.Parameters.AddWithValue("@cit", city);
                command.Parameters.AddWithValue("@Block", block);

                command.ExecuteNonQuery();
                sq.Close();

                MessageBox.Show("Succesful Sign-up!");
                this.Close();
                home.Show();
            }
            else
            {
                MessageBox.Show("There is an error, check values again!");
            }
        }

        private void admin_login_back_Click(object sender, EventArgs e)
        {
            this.Close();
            home.Show();
        }

        private void branch_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            branch_id = Convert.ToInt32(branch_combo.Text);
        }

        private void gym_combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection sq = new SqlConnection("Data Source=DESKTOP-863JJKV;Initial Catalog=Project;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            SqlDataReader sq_reader;

            sq.Open();
            command.CommandText = "select Branches.ID from Branches inner join Gyms on Gyms.ID = Branches.Gym_ID where Gym_name =@gym_name";
            command.Connection = sq;
            command.Parameters.AddWithValue("@gym_name", gym_combo.Text);
            sq_reader = command.ExecuteReader();
            branch_combo.Items.Clear();

            while (sq_reader.Read())
            {
                branch_combo.Items.Add(sq_reader["ID"].ToString());
            }
            command.Parameters.Clear();
            sq_reader.Close();
            sq.Close();
        }

        private void fn_TextChanged(object sender, EventArgs e)
        {
            first_name = fn.Text;
          
        }

        private void ln_TextChanged(object sender, EventArgs e)
        {
            last_name = ln.Text;
            
        }

        private void pw_TextChanged(object sender, EventArgs e)
        {
            password = pw.Text;
            
        }

        private void F_CheckedChanged(object sender, EventArgs e)
        {
            gender = 'F';
        }

        private void DOB_ValueChanged(object sender, EventArgs e)
        {
            dob=DOB.Value.ToString();
        }

        private void ph_TextChanged(object sender, EventArgs e)
        {
            phone_no = ph.Text;
        }

        private void block_entered_TextChanged(object sender, EventArgs e)
        { 
            block =Convert.ToInt32(block_entered.Text);

        }

        private void choice_1_CheckedChanged(object sender, EventArgs e)
        {
            membership_id = 1;
        }

        private void choice_2_CheckedChanged(object sender, EventArgs e)
        {
            membership_id = 2;
        }

        private void choice_3_CheckedChanged(object sender, EventArgs e)
        {
            membership_id = 3;
        }

        private void el_TextChanged(object sender, EventArgs e)
        {
            email = el.Text;
        }
    }
}
