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
    public partial class Pchange : Form
    {
        public Pchange()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                try
                {

                    string conncetionstring = ConfigurationManager.ConnectionStrings["testdb"].ConnectionString;
                    SqlConnection conn = new SqlConnection(conncetionstring);
                    SqlCommand cmd = new SqlCommand("Update login set Password=@password WHERE Username = @usernam", conn);
                    //cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@password", passwordtextBox.Text);
                    cmd.Parameters.AddWithValue("@usernam",loginClass.Usernamel);//username properties bnae ha class ma

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update Data Successfully", "Update DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show("Error in PasswordChange Code \n" + ex.Message);
                }


            }
        }

        private bool IsValid()
        {
            if (passwordtextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Password is Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordtextBox.Clear();
                passwordtextBox.Focus();
                return false;

            }
            if (confirmpasswordtextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Confirm Password is Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                confirmpasswordtextBox.Clear();
                confirmpasswordtextBox.Focus();
                return false;
            }
            if(passwordtextBox.Text.Trim() != confirmpasswordtextBox.Text.Trim())
            {
                MessageBox.Show("New Password Doesn't Match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void Pchange_Load(object sender, EventArgs e)
        {
           
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            checkboxklye();

        }
        public void checkboxklye()
        {
            if (checkBox1.Checked)
            {
                passwordtextBox.PasswordChar = default(Char);
                confirmpasswordtextBox.PasswordChar = default(Char);
            }
            if (!checkBox1.Checked)
            {
                passwordtextBox.PasswordChar =Convert.ToChar( "*");
                confirmpasswordtextBox.PasswordChar = Convert.ToChar("*");
            }

        }
    }
}
