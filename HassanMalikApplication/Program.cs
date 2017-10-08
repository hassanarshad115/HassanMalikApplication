using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HassanMalikApplication
{
   

    static class Program
    {

        //public static login lg; agr singout ko br br kry to ye khol dy r login waly ma changig hoge r nichy

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new captcha());

            //lg = new login(); ye r nichy wali line on krdyn agr memory ko save krna ha to 
            //104 T
            //Application.Run(lg);
        }
    }
}
