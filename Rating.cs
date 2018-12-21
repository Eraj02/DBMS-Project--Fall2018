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
    public partial class Rating : Form
    {
        int member_id = 0;
        int b_id = 0;
        private Member_login member;
        public Rating(int m,int b,Member_login me)
        {
            member = me;
            member_id = m;
            b_id = b;
            InitializeComponent();

            SqlConnection sq = new SqlConnection("Data Source=DESKTOP-863JJKV;Initial Catalog=Project;Integrated Security=True");
            SqlCommand command = new SqlCommand();

            sq.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "your_trainers";
            command.Connection = sq;
            command.Parameters.AddWithValue("@branch_id", b_id);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
            trainer_view.DataSource = ds;
            trainer_view.DataMember = ds.Tables[0].ToString();
        }

        private void Rating_Load(object sender, EventArgs e)
        {

        }

        private void rated_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You've successfully rated!");
            this.Close();
            member.Show();
        }
    }
}
