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
    public partial class NewUser : Form
    {
        public NewUser()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                try
                {
                    SaveData();

                    MessageBox.Show("New User is Added in the System", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                    saw sw = new saw();
                    sw.ShowDialog();
                }
                catch(ApplicationException ex)
                {
                    MessageBox.Show("error agya ha coding ma"+ex.Message);
                }

            }
        }


        private void SaveData()
        {
            string conncetionstring = ConfigurationManager.ConnectionStrings["testdb"].ConnectionString;
            SqlConnection conn = new SqlConnection(conncetionstring);
            SqlCommand cmd = new SqlCommand("insert into login values(@username,@password)", conn);

            conn.Open();

            cmd.Parameters.AddWithValue("@username", usernametextBox.Text.Trim());
            cmd.Parameters.AddWithValue("@password", passwordtextBox.Text.Trim());

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private bool IsValid()
        {
            if (usernametextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Username is Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernametextBox.Clear();
                usernametextBox.Focus();
                return false;

            }
            else
            {
                if (IsUserExist())
                {

                    MessageBox.Show( usernametextBox.Text+" name is already exists", "Error !!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    usernametextBox.Focus();
                    return false;
                }



            }


            if (passwordtextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Password is Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordtextBox.Focus();
                passwordtextBox.Clear();
                return false;
            }
            if(reenterpasswordtextBox.Text.Trim()== string.Empty)
            {
                MessageBox.Show("Reenter Password is Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                reenterpasswordtextBox.Focus();
                reenterpasswordtextBox.Clear();
                return false;
            }
            if(passwordtextBox.Text.Trim() != reenterpasswordtextBox.Text.Trim())
            {
                MessageBox.Show("Password Doesn't Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }


            return true;
        }

        private bool IsUserExist()
        {
            DataTable dt = new DataTable();

            string connectionstring = ConfigurationManager.ConnectionStrings["testdb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand("select * from login where Username = @username", conn);
            //cmd.CommandType = CommandType.StoredProcedure;

            conn.Open();
            cmd.Parameters.AddWithValue("@username", usernametextBox.Text.Trim());

            SqlDataReader r = cmd.ExecuteReader();

            dt.Load(r);

            if(dt.Rows.Count > 0)
            {
                return true;
            }

            return false;
        }




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            showpassword();
        }

        private void showpassword()
        {
            if (checkBox1.Checked)
            {
                passwordtextBox.PasswordChar = default(char);
                reenterpasswordtextBox.PasswordChar = default(char);
            }
            else
            {
                passwordtextBox.PasswordChar =Convert.ToChar( "*");
                reenterpasswordtextBox.PasswordChar = Convert.ToChar("*");
            }
        }
    }
}
