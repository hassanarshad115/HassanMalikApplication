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
    public partial class Chart : Form
    {
        public Chart()
        {
            InitializeComponent();
        }

        private void Chart_Load(object sender, EventArgs e)
        {
            //2010 sy 2017 tk ka data dekhayga r jo years show kry iski data base ma values lazmi honi chaia wrna 
            //ye jb start krygy to kch b show ni hoga q k fix krdia ha text ko 

            fromcomboBox.Text = "2010";
            tocomboBox.Text = "2017";

            loadData();

            //yearchart1.DataSource = GetData();
            ////data clear krny k lye
            //yearchart1.Series["Series1"].Points.Clear();
            ////x r y axess ma show krny k lye data ko
            //yearchart1.Series["Series1"].XValueMember = "Year";
            //yearchart1.Series["Series1"].YValueMembers = "Total";
            ////hr halat ma ye Year r Total k name whe ho jo sp ma lye ha 
        }

        private DataTable GetData()
        {//ye code database sy data otha kr yha ly kr ayga

            DataTable dt = new DataTable();

            string conncetionstring = ConfigurationManager.ConnectionStrings["testdb"].ConnectionString; ;
            SqlConnection conn = new SqlConnection(conncetionstring);

            SqlCommand cmd = new SqlCommand("spOrder", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            conn.Open();

            cmd.Parameters.AddWithValue("@from", fromcomboBox.Text);
            cmd.Parameters.AddWithValue("@to", tocomboBox.Text);



            SqlDataReader reader = cmd.ExecuteReader();
            dt.Load(reader);




            return dt;
        }

        private void gobutton_Click(object sender, EventArgs e)
        {
            loadData();
        }
        private void loadData()
        {
            //ismy phly chart.DataSource r agy isky ak method ha jsmy db sy data yha ly k ayga fr
            //ak line extra ha ye             yearchart1.Series["Series1"].Points.Clear(); wali
            //fr jb tk ye x r y axess wali lines ni likhygy tb tk data show ni hoga

            yearchart1.DataSource = GetData();
            //data clear krny k lye
            yearchart1.Series["Series1"].Points.Clear();
            //x r y axess ma show krny k lye data ko
            yearchart1.Series["Series1"].XValueMember = "Year";
            yearchart1.Series["Series1"].YValueMembers = "Total";
            //hr halat ma ye Year r Total k name whe ho jo sp ma lye ha 
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
