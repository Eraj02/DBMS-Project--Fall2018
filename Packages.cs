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
    public partial class Packages : Form
    {
        private Member_login member;
        public Packages(Member_login me)
        {
            member = me;
            InitializeComponent();

            SqlConnection sq = new SqlConnection("Data Source=DESKTOP-863JJKV;Initial Catalog=Project;Integrated Security=True");
            SqlCommand command = new SqlCommand();
            
            sq.Open();
            command.CommandText = "select p.ID,p.Package_Type,p.Package_Name,p.Package_Detail,p.Price from Packages p inner join Branches b on b.ID=p.Branch_ID where b.ID = 1";
            command.Connection = sq;

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
            package_view.DataSource = ds;
            package_view.DataMember = ds.Tables[0].ToString();
            

        }
        public Packages()
        {
            InitializeComponent();

            view_packages.Text = "All Packages";
            Back.Enabled = false;
            // Press cancel to leave, back works for members.
            SqlConnection sq = new SqlConnection("Data Source=DESKTOP-863JJKV;Initial Catalog=Project;Integrated Security=True");
            SqlCommand command = new SqlCommand();

            sq.Open();
            command.CommandText = "select p.ID,p.Package_Type,p.Package_Name,p.Package_Detail,p.Price from Packages p inner join Branches b on b.ID=p.Branch_ID";
            command.Connection = sq;

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
            package_view.DataSource = ds;
            package_view.DataMember = ds.Tables[0].ToString();

        }

        private void package_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            member.Show();
        }
    }
}
