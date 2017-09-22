using HassanMalikApplication.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HassanMalikApplication
{
    public partial class insert : Form
    {
        //private string int32;

        public insert()
        {
            InitializeComponent();
        }
        //reload k lye ak class level veriable ki zrorat ha islye stdid lta ho
        //fr usko get set k zrye property bnata ho
        private int student = 0; //oop k concept ma class level veraibles should be always  private

        public int studentP //ye name r veriable names alg alg hony chaia 
        {
            get { return student; }
            set { student = value; }

        }

        /// <summary>
        /// ak r veriable r property lygy saw form k lye k pta chly agr update hoa ho to
        /// isko default false kia ha
        /// isko use saw form k ander krygy
        /// property r veriable ma difference hota ha smal r big I dekhy 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// 

        private bool isUpdate = false; //ye veriable lia hoa ha

        public bool Isupdate //ye property ha
        {
            get { return Isupdate; }

            set { isUpdate = value; }
        }





        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (this.isUpdate)
            {


                UpdateKlyeMethod();


            }
            else
            {
                SavekAnderWalaMethod();
            }
        }

        private void UpdateKlyeMethod()
        {
            try
            {
                if (maleradioButton.Checked == false && femaleradioButton.Checked == false)
                {
                    MessageBox.Show("Please Select Gender and Interest Correctly !!", "Error !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string conn = ConfigurationManager.ConnectionStrings["testdb"].ConnectionString;
                    SqlConnection con = new SqlConnection(conn);
                    SqlCommand cmd = new SqlCommand("updat", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@id", this.studentP);
                    cmd.Parameters.AddWithValue("@name", nametextBox.Text);
                    //cmd.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = nametextBox.Text;
                    cmd.Parameters.Add("@age", SqlDbType.NVarChar, 55).Value = agetextBox.Text;
                    cmd.Parameters.Add("@feedback", SqlDbType.NVarChar, 50).Value = feedbacktextBox.Text;
                    cmd.Parameters.AddWithValue("@class", classtextBox.Text);
                    cmd.Parameters.AddWithValue("@email", emailtextBox.Text);

                    //checked hoga text ni ayga . kbad iski type bit hoge
                    cmd.Parameters.AddWithValue("@csharp", csharpcheckBox.Checked);
                    cmd.Parameters.AddWithValue("@java", javacheckBox.Checked);
                    cmd.Parameters.AddWithValue("@php", phpcheckBox.Checked);

                    cmd.Parameters.AddWithValue("@city", citytextBox1.Text);
                    //country ka alg table bnaygy fr sp ma b country ko lygy enter waly r h jo asl table ha usmy
                    //b country name sy ak colom lygy q k dekhany k lye ye sp r h ko use kryga r
                    //pic yni fetch ye c waly table sy he kryga
                    cmd.Parameters.AddWithValue("@country", countrycomboBox.Text);

                    cmd.Parameters.AddWithValue("@dob", dobdateTimePicker.Value.Date);

                    cmd.Parameters.AddWithValue("@gender", getGender());

                    //image k lye
                    cmd.Parameters.AddWithValue("@photo", SavePhoto());


                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Update Data Successfully", "ENTER DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.Hide();
                    saw s = new saw();
                    s.ShowDialog();

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error in updation Code \n" + ex.Message);
            }
        }




        private void SavekAnderWalaMethod()
        {
            //insert k lye
            try
            {


                if (nametextBox.Text == "" || agetextBox.Text == "" ||  classtextBox.Text == "" || emailtextBox.Text == "" || countrycomboBox.Text == "" || citytextBox1.Text == "")
                {
                    MessageBox.Show("Please Fill all Blank Box !!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {

                    string conn = ConfigurationManager.ConnectionStrings["testdb"].ConnectionString;
                    SqlConnection con = new SqlConnection(conn);
                    SqlCommand cmd = new SqlCommand("enter", con);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@name", SqlDbType.NVarChar, 50).Value = nametextBox.Text;
                    cmd.Parameters.Add("@age", SqlDbType.NVarChar, 55).Value = agetextBox.Text;
                    cmd.Parameters.Add("@feedback", SqlDbType.NVarChar, 50).Value = feedbacktextBox.Text;
                    cmd.Parameters.AddWithValue("@class", classtextBox.Text);
                    cmd.Parameters.AddWithValue("@email", emailtextBox.Text);//string waly .text hoty ha\
                    cmd.Parameters.AddWithValue("@country", countrycomboBox.Text);
                    cmd.Parameters.AddWithValue("@city", citytextBox1.Text);


                    //checked hoga text ni ayga . kbad iski type bit hoge
                    cmd.Parameters.AddWithValue("@csharp", csharpcheckBox.Checked);//ye .checked hota ha
                    cmd.Parameters.AddWithValue("@java", javacheckBox.Checked);
                    cmd.Parameters.AddWithValue("@php", phpcheckBox.Checked);

                    //country ka alg table bnaygy fr sp ma b country ko lygy enter waly r h jo asl table ha usmy
                    //b country name sy ak colom lygy q k dekhany k lye ye sp r h ko use kryga r
                    //pic yni fetch ye c waly table sy he kryga

                    cmd.Parameters.AddWithValue("@dob", dobdateTimePicker.Value.Date);//.value.date k sath likhna ha
                    if (maleradioButton.Checked == false && femaleradioButton.Checked == false)
                    {
                        MessageBox.Show("Please Select Gender !!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@gender", getGender());//method nichy define kia hoa ha              

                        //image k lye
                        cmd.Parameters.AddWithValue("@photo", SavePhoto());

                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Save Data Successfully", "ENTER DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //jsy he insert ya update data krygy usky bad message show hoga fr ye saw form ki trf chla jayga
                        this.Hide();
                        saw s = new saw();
                        s.ShowDialog();

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error in insertion Code \n" + ex.Message);
            }
        }




        private byte[] SavePhoto()
        {
            MemoryStream ms = new MemoryStream();//memory stream array ki trah ha
            //image save krny k lye
            studentpictureBox.Image.Save(ms, studentpictureBox.Image.RawFormat);//ks format m save krni ha
            return ms.GetBuffer(); // lazmi
        }



        //isupdate k andr olta hoga ye kam
        //phly byte array ko memorystream ma change kia ta ab
        //memorystream ko byte array ma change krygy
        //private Image GetPoto(byte[] photo)//v ki jga photo likhdia
        //{
        //    MemoryStream ms = new MemoryStream(photo);

        //    return Image.FromStream(ms);
        //}





        private int getGender()
        {
            if (maleradioButton.Checked)
            {
                return 1;
            }
            if (femaleradioButton.Checked)
            {
                return 2;
            }
            return 0;
        }




        private void insert_Load(object sender, EventArgs e)
        {
            countrycomboBox.DataSource = GetcountryData();
            countrycomboBox.DisplayMember = "Country Name";
            countrycomboBox.SelectedIndex = -1;



            //gridview ma kse line pr click kry to wo insert form ma ajay
            if (this.isUpdate)
            {

                DataTable dtStudentInfo = StdInfoMethod(this.studentP);//property/veriable ko this k sath dala ha jo uper bnae ti

                DataRow row = dtStudentInfo.Rows[0];

                nametextBox.Text = row["Name"].ToString();
                emailtextBox.Text = row["Email"].ToString();
                classtextBox.Text = row["Class"].ToString();
                agetextBox.Text = row["Age"].ToString();
                feedbacktextBox.Text = row["Feedback"].ToString();
                citytextBox1.Text = row["City"].ToString();

                countrycomboBox.Text = row["Country"].ToString();

                ////important
                //csharpcheckBox.Checked = (row["Csharp"] is DBNull) ? false : Convert.ToBoolean(row["Csharp"]);
                //csharpcheckBox.Checked = (row["Java"] is DBNull) ? false : Convert.ToBoolean(row["Java"]);
                //csharpcheckBox.Checked =(row["Php"] is DBNull) ? false : Convert.ToBoolean(row ["Php"]);

                //combobox.selectedValue=row["CountryId"]; agr kse ki id k zrye dekhna hota ho asy hota

                //  maleradioButton.Checked = (row["Gender"] is DBNull) ? false : (Convert.ToInt16(row["Gender"]) == 1) ? true : false;
                //femaleradioButton.Checked = (row["Gender"] is DBNull) ? false : (Convert.ToInt16(row["Gender"]) == 2) ? true : false;

                dobdateTimePicker.Value = Convert.ToDateTime(row["Date Of Birth"]).Date;

                //image k lye
                studentpictureBox.Image = (row["Photo"] is DBNull) ? Resources.no_image : GetPoto((byte[])row["Photo"]);
                //isko again byte array ma change krygy ms sy ak functionn bnaya ha

            }

        }

        //phly byte array ko memorystream ma change kia ta ab
        //memorystream ko byte array ma change krygy
        private Image GetPoto(byte[] photo)//v ki jga photo likhdia
        {
            MemoryStream ms = new MemoryStream(photo);

            return Image.FromStream(ms);
        }




        private DataTable StdInfoMethod(int studentP)
        {
            DataTable obj = new DataTable();


            string conn = ConfigurationManager.ConnectionStrings["testdb"].ConnectionString;
            SqlConnection con = new SqlConnection(conn);

            SqlCommand cmd = new SqlCommand("dekhna", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@stdID", studentP);

            con.Open();
            SqlDataReader r = cmd.ExecuteReader();
            obj.Load(r);

            con.Close();

            //SqlDataAdapter ad = new SqlDataAdapter("dekhna", con);
            //ad.Fill(obj);
            return obj;
        }









        private DataTable GetcountryData()
        {
            DataTable country = new DataTable();
            string conn = ConfigurationManager.ConnectionStrings["testdb"].ConnectionString;
            SqlConnection con = new SqlConnection(conn);

            SqlDataAdapter ada = new SqlDataAdapter("select * from c", con);
            ada.Fill(country);

            return country;

        }

        private void viewbutton2_Click(object sender, EventArgs e)
        {
            saw s = new saw();
            s.ShowDialog();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://allice9554.000webhostapp.com/");
        }

        private void phpcheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// picture k lye ha ye 
        /// jo pic nzr ay
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void studentpictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Select The Photo";
            //ofd.Filter = "JPEG File (*.jpg)|*.JPG|  PNG File (*.png)|*.png|QIF File(*.qmf)|*.qmf";
            ofd.Filter = "Image File(*.jpg;*.png;*.qmf;*.gif)|*.jpg;*.png;*.qmf;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK) //
            {//agr pic p click kry to jo dialogbox nzr ayga usmysy jo pic ko select krygy wo pic insert k 
                //form ma nzr ayge
                studentpictureBox.Image = new Bitmap(ofd.FileName);
            }
        }





        private void button2_Click(object sender, EventArgs e)
        {
            DeleteKlye();
        }


        public void DeleteKlye()
        {
            if (nametextBox.Text == string.Empty)
            {
                MessageBox.Show("First Select A Row Then Try Again !!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                string conn = ConfigurationManager.ConnectionStrings["testdb"].ConnectionString;
                SqlConnection con = new SqlConnection(conn);
                SqlCommand cmd = new SqlCommand("delet", con);
                cmd.CommandType = CommandType.StoredProcedure;


                cmd.Parameters.AddWithValue("@id", this.studentP);



                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Delete Data Successfully", "DELETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                saw s = new saw();
                s.ShowDialog();


            }
        }
    }
}
