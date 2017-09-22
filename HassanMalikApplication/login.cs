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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }
        //private int logindetailwrong = 0;//br br login wrong krny waly ka accout disable krny k lye

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValidated()) //ye if k sath valid ha ye khali block k lye ha
            {


                try {
                    bool usernamecorrect, passwordcorrect;

                    GetUserLogin(out usernamecorrect,  out passwordcorrect);//ye just method ha if k sath ni
                        {

                        if(usernamecorrect && passwordcorrect)
                        {
                            this.Hide();

                            //rememberme k lye ye sb must ha
                            if (remembermecheckBox.Checked)
                            {
                                Properties.Settings.Default.UserName = usernametextBox.Text;
                                Properties.Settings.Default.Save();
                            }

                            saw o = new saw();
                            o.ShowDialog();



                        }
                        else
                        {
                            //idr is veriable ko increment krygy k 
                            //logindetailwrong++;

                            if (!usernamecorrect)
                            {
                                MessageBox.Show("Username is Not Correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                usernametextBox.Clear();
                                passwordtextBox.Clear();
                                usernametextBox.Focus();
                            }
                            else
                            {

                                MessageBox.Show("Password is Not Correct", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                                //password ma condition lgaygy na k username ma q k br br password wrong enter krny p 
                                //account disable hona chaia
                                //so idr lgaygy condition yad rkhy
                                //if (logindetailwrong >= 3)
                                //{
                                //    MessageBox.Show("Disable This Account Please Contact with the \n Admin Hassan Malik", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                //    DisableThisAccount(); //ak method bnaya ha ta k accout disable hojay
                                //}

                                passwordtextBox.Clear();
                                usernametextBox.Focus();
                            }

                        }



                    }


                }

                catch(ApplicationException ex)
                {
                    MessageBox.Show("Error in coding of login form" + ex.Message);

                }

            }
        }


        //account ko disable krny k lye method bnaya ha
        //private void DisableThisAccount()
        //{
        //    string connectionstring = ConfigurationManager.ConnectionStrings["testdb"].ConnectionString;
        //    SqlConnection conn = new SqlConnection(connectionstring);
        //    SqlCommand cmd = new SqlCommand("AccountDisable", conn);
        //    cmd.CommandType = CommandType.StoredProcedure;

        //    conn.Open();
        //    cmd.Parameters.AddWithValue("@usernameDisableWala", usernametextBox.Text);

        //    cmd.ExecuteNonQuery();

        //}
        /// <summary>
        /// iska sp asy bnyga
        /// create procedure AccountDisable
        /// (@usernameDisableWala nvarchar(50) ) as begin set login where IsActive= 0 end 
        /// agr 108 totu pr IsActive ko krta to ye isactive pr kam krta so phly isactive wala kam kry
        /// </summary>
        /// <param name="usernamecorrect"></param>
        /// <param name="passwordcorrect"></param>





        private void GetUserLogin(out bool usernamecorrect, out bool passwordcorrect)
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["testdb"].ConnectionString;
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlCommand cmd = new SqlCommand("loginklye", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            conn.Open();

            cmd.Parameters.Add("@Isusername", SqlDbType.Bit).Direction = ParameterDirection.Output;
            cmd.Parameters.Add("@Ispassword", SqlDbType.Bit).Direction = ParameterDirection.Output;

            cmd.Parameters.AddWithValue("@username", usernametextBox.Text);
            cmd.Parameters.AddWithValue("@password", passwordtextBox.Text);

            cmd.ExecuteNonQuery();

            //agr ye na kia to GetUserLogin red hojayga error ayga
            usernamecorrect =(bool) cmd.Parameters["@Isusername"].Value;
            passwordcorrect =(bool) cmd.Parameters["@Ispassword"].Value;




        }





        //validation check kra ha ye r sath he spaces ko trim k function k sath remove kra ha
        private bool IsValidated()
        {
            if (usernametextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Username is Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                usernametextBox.Clear();
                usernametextBox.Focus();
                return false;

            }
            if (passwordtextBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("Password is Required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                passwordtextBox.Clear();
                return false;
            }



            return true;
        }

        private void login_Load(object sender, EventArgs e)
        {
            usernametextBox.Text= Properties.Settings.Default.UserName;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://allice9554.000webhostapp.com/");
        }
    }
}