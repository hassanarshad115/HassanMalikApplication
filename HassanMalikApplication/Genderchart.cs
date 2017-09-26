using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HassanMalikApplication
{
    public partial class Genderchart : Form
    {
        public Genderchart()
        {
            InitializeComponent();
        }

        private void chart1_Click(object sender, EventArgs e)
        {
        }

        private DataTable GetData()
        {
            DataTable dt = new DataTable();

            string conncetionstring = ConfigurationManager.ConnectionStrings["testdb"].ConnectionString;
            SqlConnection conn = new SqlConnection(conncetionstring);

            SqlCommand cmd = new SqlCommand("chartbygender", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();

            SqlDataReader read = cmd.ExecuteReader();
            dt.Load(read);
            //SqlDataAdapter ad = new SqlDataAdapter("chartbygender", conn);
            //ad.Fill(dt);


            return dt;
        }

        private void Genderchart_Load(object sender, EventArgs e)
        {
            chart1.DataSource = GetData();

            chart1.Series["Series1"].XValueMember = "Gender";
            chart1.Series["Series1"].YValueMembers = "Total";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();

            saw s = new saw();
            s.ShowDialog();
        }
    }
}
