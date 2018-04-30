using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace Sistema_Agricola
{
    
    static class Program
    {
        public static Frm_Principal oFormPrincipal;
        public static string mensajesincronizacion;
        public static string estadosincronizacion = "N";
        public static string llenargrillapersonal = "N";

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            oFormPrincipal = new Frm_Principal();
       
            Application.Run(oFormPrincipal);
        }
    }
}
