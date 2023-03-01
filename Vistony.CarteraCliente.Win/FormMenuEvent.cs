using System;
using System.Collections.Generic;
using System.Text;
using SAPbouiCOM.Framework;
using Forxap.Framework.Constants;
using Forxap.Framework.UI;
using Forxap.CarteraCliente.UI.Win.Configuracion;
using Vistony.CarteraCliente.Win.Asistentes;
using Vistony.CarteraCliente.UI.Constans;
using Vistony.CarteraCliente.Win.Asistentes;

namespace Vistony.CarteraCliente.Win
{
    public class FormMenuEvent
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pVal"></param>
        /// <param name="BubbleEvent"></param>
        public void SB1_Application_FormMenuEvent(ref SAPbouiCOM.MenuEvent pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            try
            {
                switch (Application.SBO_Application.Forms.ActiveForm.TypeEx)
                {
                    case AddonWinForms.wzdCargaMasiva:
                        {
                           // wzd Asistentes.wzdCargaMasiva.MenuEvent(ref pVal, out BubbleEvent);
                            break;
                        }
                    case AddonWinForms.wzdCambioCartera:
                        {
                            wzdCartera.MenuEvent(ref pVal, out BubbleEvent);                       
                            break;
                        }

                }
            }
            catch (Exception)
            {

               // throw;
            }
        }// fin del metodo FormMenuEvent



    }// fin de la clase

}// fin del namespace
