using AppTuristMed.Clases;
using AppTuristMed.Formularios;
using System;
using System.Windows.Forms;

namespace AppTuristMed
{
    class Program
    {
        public static string ruta = Application.StartupPath;
        public static SodaProxy proxy = new SodaProxy();
        public static Ubicacion location = Ubicacion.ObtenerUbicacion();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashScreen());
        }

        public static bool InternetAccess()
        {
            try
            {
                System.Net.IPHostEntry host = System.Net.Dns.GetHostEntry("www.google.com");
                return true;
            }
            catch (Exception e)
            {
                e.ToString();
                return false;
            }
        }
        
              
    }
}
