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
    public partial class Subs : Form
    {
        public Subs()
        {
            InitializeComponent();
            SqlConnection sq = new SqlConnection("Data Source=DESKTOP-863JJKV;Initial Catalog=Project;Integrated Security=True");
            SqlCommand command = new SqlCommand();

            sq.Open();
            command.CommandText = "select s.Sub_ID [ID],m.First_Name+' '+m.Last_Name [Name],p.Package_Name [Package Name], s.Date from Subscriptions s inner join Members m on m.ID=s.Member_ID inner join Packages p on p.ID = s.Package_ID";
            command.Connection = sq;

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
            sub_view.DataSource = ds;
            sub_view.DataMember = ds.Tables[0].ToString();
            
        }

        private void trainer_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
