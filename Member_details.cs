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
    public partial class Member_details : Form
    {
        public Member_details()
        {
            InitializeComponent();
            SqlConnection sq = new SqlConnection("Data Source=DESKTOP-863JJKV;Initial Catalog=Project;Integrated Security=True");
            SqlCommand command = new SqlCommand();

            sq.Open();
            command.CommandText = "select * from Members";
            command.Connection = sq;

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
            member_view.DataSource = ds;
            member_view.DataMember = ds.Tables[0].ToString();
        }

        private void member_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}
