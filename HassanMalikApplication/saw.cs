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
    public partial class saw : Form
    {
        public saw()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        DataTable dt = new DataTable(); //idr dy global krdia isko

        private void saw_Load(object sender, EventArgs e)//formload event ynii form pr dbl click kia ha
        {
            dt= sawdataGrid(); // DataTable dt = new DataTable(); 
                               //sawdataGridView1.DataSource = sawdataGrid();
            sawdataGridView1.DataSource = dt;
        }

        private DataTable sawdataGrid() //iski data type change ki ha objecy ki jga datatable
        {
             dt = new DataTable(); // DataTable dt = new DataTable(); 

            string connection = ConfigurationManager.ConnectionStrings["testdb"].ConnectionString;
            SqlConnection connect = new SqlConnection(connection);

            SqlDataAdapter adapter = new SqlDataAdapter("saw", connect);
            adapter.Fill(dt);

            return dt;
        }

        /// <summary>
        /// search k lye ye code ha
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

           // MethodBandiaSbkyLye("Name", nametextBox);
            DataView dv = dt.DefaultView;

            dv.RowFilter = "Name Like '%" + nametextBox.Text+"%'";
        }

        private void emailtextBox_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "Email Like '%" + emailtextBox.Text + "%'";
        }

        private void addresstextBox_TextChanged(object sender, EventArgs e)
        {
            DataView dv = dt.DefaultView;
            dv.RowFilter = "Country Like '%" + ctextBox.Text + "%'";
        }



        //ak method bnaty ha r kch b hoskty ha
        public void MethodBandiaSbkyLye(string data, TextBox txt) //text box k lye textbox agr cmbobox k lye control
        {

            DataView dv = dt.DefaultView;

            dv.RowFilter = data + "Like '%" + txt.Text + "%'";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            nametextBox.Clear();
            emailtextBox.Clear();
            ctextBox.Clear();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
        }

        private void sawdataGridView1_DoubleClick(object sender, EventArgs e)
        {
            int rowUpdate = sawdataGridView1.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            int studentID = Convert.ToInt16(sawdataGridView1.Rows[rowUpdate].Cells["Id"].Value);//convert krny ka treeka b dekh ly

            //insert obj = new insert();
            //obj.studentP = studentID;   // ye nye chez ha obj k sath property jo insert k class level veriable 
            //// lty wkt bnae ti wo yha use hoe ha
            ////insert form ma jo update wali property bnae ti wo asy use krygy 
            //obj.Isupdate = true;
            //obj.ShowDialog();

            ShowStudentInfo(studentID, true);//isko insert new student ma b add kry
        }

        private void ShowStudentInfo(int studentIDv,bool isupdate)
        {

            insert obj = new insert();
            obj.studentP = studentIDv;   // ye nye chez ha obj k sath property jo insert k class level veriable 
            // lty wkt bnae ti wo yha use hoe ha
            //insert form ma jo update wali property bnae ti wo asy use krygy 
            obj.Isupdate = isupdate;
            obj.ShowDialog();

        }

        private void insertNewStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
      
        }

        private void logOutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();

            login lg = new login();
            lg.ShowDialog();
            //fr ye likhna ha nichy ta k ye access kr sky
            //Program.lg.ShowDialog();

        }

        private void oPERATIONsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowStudentInfo(0, false);

        }
    }
}
