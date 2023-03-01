using System;
using System.Collections.Generic;
using SAPbouiCOM.Framework;
using Forxap.Framework.Utils;

using Vistony.CarteraCliente.UI.Constans; 

namespace Vistony.CarteraCliente.Win
{
    class Program
    {
      //  public static SAPbouiCOM.Form oForm = null;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
           

            try
            {
                Application oApp = null;
                

                if (args.Length < 1)
                {
                    oApp = new Application();
                }
                else
                {
                    
                    oApp = new Application(args[0]);
                }
                ApplicationEvent ApplicationEvents = new ApplicationEvent();
                MainMenuEvent MainMenuEvents = new MainMenuEvent();
                FormMenuEvent FormMenuEvents = new FormMenuEvent();

                /// Eventos que se ejecutan en toda la aplicación
                Application.SBO_Application.AppEvent += new SAPbouiCOM._IApplicationEvents_AppEventEventHandler(ApplicationEvents.SB1_Application_AppEvent);
                /// Eventos del menu de la pantalla principal de SAP
                Application.SBO_Application.MenuEvent += new SAPbouiCOM._IApplicationEvents_MenuEventEventHandler(MainMenuEvents.SB1_Application_MainMenuEvent);
                /// Eventos del menu dentro de un formulario especifico
                Application.SBO_Application.MenuEvent += new SAPbouiCOM._IApplicationEvents_MenuEventEventHandler(FormMenuEvents.SB1_Application_FormMenuEvent);

              //  Application.SBO_Application.Company.

                if (Sb1Connection.ConnectToSAP())
                {
                    oApp.Run();

                }

            }
            catch (Exception ex)
            {

                //si no esta cargado SAP
                if (Errors.GetLastErrorFromHRException(ex).Code == -7202)
                    System.Windows.Forms.MessageBox.Show(Vistony.CarteraCliente.UI.Constans.AddonMessageInfo.SAPNotRunning);
                else// si es otro tipo de error
                    System.Windows.Forms.MessageBox.Show(ex.ToString());
            }
        }




    }// fin de la clase

}// menu del namespace
