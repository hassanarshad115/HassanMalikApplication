using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.Media;
using WMPLib;
namespace HassanMalikApplication
{
    public partial class Slider :  Syncfusion.Windows.Forms.MetroForm
    {
        public Slider()
        {
            InitializeComponent();
            
        }

        private void Slider_Load(object sender, EventArgs e)
        {
            //timer1.Start();
            //pictureBox2.Visible = false;

            WMPLib.WindowsMediaPlayer obj = new WMPLib.WindowsMediaPlayer();
            obj.URL = @"C:\Users\Hassan Arshad\Downloads\Music\m.mp3";
            obj.controls.play();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox1.Visible == true) // equal ki ye ilamat lgani ha == 
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
            }
            else if (pictureBox2.Visible == true) // else k sath krna ha yad sy
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }
            else if (pictureBox3.Visible == true)
            {
                pictureBox3.Visible = false;
                pictureBox1.Visible = true;
            }
            else if(pictureBox4.Visible== true)
            {
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
            }
            else if(pictureBox5.Visible== true)
            {
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;
            }
            else if(pictureBox6.Visible == true)
            {
                pictureBox6.Visible = false;
                pictureBox1.Visible = true;
            }
        }
    }
}
