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
    public partial class Schedule : Form
    {
        int branch = 0;
        private Member_login member;
        public Schedule(Member_login me, int b)
        {
            member = me;
            branch = b;
            InitializeComponent();


            SqlConnection sq = new SqlConnection("Data Source=DESKTOP-863JJKV;Initial Catalog=Project;Integrated Security=True");
            SqlCommand command = new SqlCommand();


            sq.Open();
            command.CommandType = CommandType.StoredProcedure;
            command.CommandText = "class_show";
            command.Connection = sq;
            command.Parameters.AddWithValue("@branch_id", branch);

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
            schdeule_view.DataSource = ds;
            schdeule_view.DataMember = ds.Tables[0].ToString();
        }


        private void Back_Click(object sender, EventArgs e)
        {
            this.Close();
            member.Show();
        }

        private void schdeule_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
