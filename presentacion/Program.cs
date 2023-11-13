using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("es-PE"); // configuracion de moneda
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            // splash
            frmSplash splash = new frmSplash();
            Application.Run(splash);
            //fin splash
            
            login inicio = new login();
            Application.Run(inicio);
        }
    }
}
