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

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IsValidated())
            {


                try {
                    bool usernamecorrect, passwordcorrect;

                    GetUserLogin(out usernamecorrect,  out passwordcorrect);
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



        //    //cut krna ha sara

        //    private bool authenticated(string text1, string text2)
        //    {

        //        bool varr = false;
        //        try
        //        {

        //            if (IsValidate()) { 



        //                cmd.Parameters.Add("@username", SqlDbType.NVarChar, 50).Value = usernametextBox.Text;
        //                cmd.Parameters.AddWithValue("@password", passwordtextBox.Text);

        //                conn.Open();
        //            varr =(bool) cmd.ExecuteScalar();
        //                conn.Close();
        //            }
        //    }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error in coding of login form" + ex.Message);
        //        }
        //        return varr;

        //}



        //    private bool IsValidate()
        //    {


        //        return true;
        //    }



        //    private void NewMethod()
        //    {
        //        usernametextBox.BackColor = Color.Red;
        //        passwordtextBox.BackColor = Color.Red;
        //        usernametextBox.ForeColor = Color.White;
        //        passwordtextBox.ForeColor = Color.White;
        //        usernametextBox.Focus();
        //    }

    }
}