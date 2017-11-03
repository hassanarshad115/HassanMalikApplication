using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HassanMalikApplication
{
    public partial class captcha : Syncfusion.Windows.Forms.MetroForm
    {
        public captcha()
        {
            InitializeComponent();

            //constructor ma load krwana ha method ko 
            loadcaptchaimage();
        }
       //ak veriable lygy int type ka jo ka randomly br br change ho
        int number = 0;

        private void refreshbutton2_Click(object sender, EventArgs e)
        {            //jb b refresh kry to ye change hota jay
            loadcaptchaimage();
            textBox1.Clear();
            textBox1.Focus();
        }

        //captha ka code ider likhygy
        private void loadcaptchaimage()
        {
            Random r = new Random(); //random ka ak obj lygy
            // jo number ta usko initialize krygy random k obj.next sy k kha sy kha tk chly
            number = r.Next(100, 1000);

            // bitmap ka ak obj lna ha jsmy picturebox ki wdth r height k lye
            var image = new Bitmap(this.pictureBox1.Width, this.pictureBox1.Height);

            //font ka ak obj lna ha jsmy ks type ki language ho
            //uska size ktna ho ksa ho bold k ni r ksmy ho display ya pixel wgra
            var font = new Font("TimesNewRoman", 40, FontStyle.Bold, GraphicsUnit.Pixel);

            // iska obj ni bnta isko asy likhna ha
           var graphic = Graphics.FromImage(image);

            //graphic veriable k sath ye asy likhna ha ismy font obj b lna hota ha
            graphic.DrawString(number.ToString(), font, Brushes.Red, new Point(40, 10));//40 left sy right lany k lye r 10 nichy lany k lye
            pictureBox1.Image = image; // fr last ma picturebox k sath image r braber image krdygy
        }

        private void verifybutton1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Trim() == number.ToString())
            {
                MessageBox.Show("Successfully Verify Code", "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Captcha is not Match ", "Error !!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox1.Focus();
                loadcaptchaimage();
            }
        }

        private void captcha_Load(object sender, EventArgs e)
        {
            textBox1.Focus();
        }
    }
}
