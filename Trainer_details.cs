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
    public partial class Trainer_details : Form
    {
        public Trainer_details()
        {
            InitializeComponent();
            SqlConnection sq = new SqlConnection("Data Source=DESKTOP-863JJKV;Initial Catalog=Project;Integrated Security=True");
            SqlCommand command = new SqlCommand();

            sq.Open();
            command.CommandText = "select * from Trainers";
            command.Connection = sq;

            DataSet ds = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter(command);
            da.Fill(ds);
            trainer_view.DataSource = ds;
            trainer_view.DataMember = ds.Tables[0].ToString();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void trainer_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void view_packages_Click(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {

        }
    }
}
