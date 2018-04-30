using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.UserSkins;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.Reflection;
using System.ComponentModel;

namespace ModuloPresupuesto
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);

            //BonusSkins.Register();
            //SkinManager.EnableFormSkins();
            //UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");
            //Application.Run(new Frm_Login());


            Assembly asm = typeof(DevExpress.UserSkins.TemaAsj1).Assembly;
            DevExpress.Skins.SkinManager.Default.RegisterAssembly(asm);
            // Splash screens and wait forms created with the help of the SplashScreenManager component run in a separate thread.  
            // Information on custom skins registered in the main thread is not available in the splash screen thread  
            // until you call the SplashScreenManager.RegisterUserSkins method.  
            // To provide information on custom skins to the splash screen thread, uncomment the following line. 
            //SplashScreenManager.RegisterUserSkins(asm);  
            Application.Run(new Frm_Login());

        }

        public class SkinRegistration : Component
        {
            public SkinRegistration()
            {
                DevExpress.Skins.SkinManager.Default.RegisterAssembly(typeof(DevExpress.UserSkins.TemaAsj1).Assembly);
            }

        }
    }
}