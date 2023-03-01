using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAPbouiCOM.Framework;
using Forxap.Framework.Extensions;
using Forxap.CarteraCliente.UI.Win.Asistentes;
using Vistony.CarteraCliente.UI.Constans;
using Forxap.Framework.UI;
using Vistony.Cartera.BO;
using Newtonsoft.Json;
using RestSharp;
using Vistony.Cartera.DAL;
using Vistony.CarteraCliente.UI.Constans;

namespace Forxap.CarteraCliente.UI.Win.Asistentes
{
    [FormAttribute(AddonWinForms.wzdCargaMasiva, "Asistentes/wzdCargaMasiva.b1f")]
    class wzdCargaMasiva : BaseWizard 
    {
        private SAPbouiCOM.StaticText StaticText0;

        public wzdCargaMasiva()
        {
        }

        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
            this.btnCancel = ((SAPbouiCOM.Button)(this.GetItem("2").Specific));
            this.btnPrior = ((SAPbouiCOM.Button)(this.GetItem("6").Specific));
            this.btnPrior.PressedAfter += new SAPbouiCOM._IButtonEvents_PressedAfterEventHandler(this.btnPrior_PressedAfter);
            this.btnNext = ((SAPbouiCOM.Button)(this.GetItem("7").Specific));
            this.btnNext.PressedAfter += new SAPbouiCOM._IButtonEvents_PressedAfterEventHandler(this.btnNext_PressedAfter);
            this.StaticText0 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_3").Specific));
            this.lblTitle = ((SAPbouiCOM.StaticText)(this.GetItem("Item_4").Specific));
            this.StaticText1 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_0").Specific));
            this.ComboBox0 = ((SAPbouiCOM.ComboBox)(this.GetItem("Item_1").Specific));
            this.StaticText2 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_2").Specific));
            this.Button0 = ((SAPbouiCOM.Button)(this.GetItem("Item_6").Specific));
            this.StaticText3 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_9").Specific));
            this.Grid2 = ((SAPbouiCOM.Grid)(this.GetItem("Item_16").Specific));
            this.lblPageNumber = ((SAPbouiCOM.StaticText)(this.GetItem("Item_18").Specific));
            this.Button2 = ((SAPbouiCOM.Button)(this.GetItem("Item_19").Specific));
            this.Grid3 = ((SAPbouiCOM.Grid)(this.GetItem("Item_22").Specific));
            this.ComboBox1 = ((SAPbouiCOM.ComboBox)(this.GetItem("Item_5").Specific));
            this.Grid0 = ((SAPbouiCOM.Grid)(this.GetItem("Item_7").Specific));
            this.OnCustomInitialize();

        }

        /// <summary>
        /// Initialize form event. Called by framework before form creation.
        /// </summary>
        public override void OnInitializeFormEvents()
        {

        }

        public static void MenuEvent(ref SAPbouiCOM.MenuEvent pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
        }

        private void OnCustomInitialize()
        {
            oForm = SAPbouiCOM.Framework.Application.SBO_Application.Forms.Item(this.UIAPIRawForm.UniqueID);
            oForm.ScreenCenter(); // centro la pantalla
            PaneLevel = 2;
            PaneMax = 3;
            SetPageNumber();
        }




        private void PriorPane()
        {
            if (PaneLevel >= 2)
            {
                oForm.PaneLevel -= 1;
            }

            if (PaneLevel == 1)
            {
                btnPrior.Item.Enabled = false;
            }
            else
            {
                btnPrior.Item.Enabled = true;
                btnNext.Caption = AddonMessageInfo.Message122;
            }

            SetPageNumber();
        }

        private void NextPane()
        {
            if ((PaneLevel -1 ) < PaneMax)
            {
                //oForm.GetCheckBox("UD_CHKEST").Checked = true;
                //cbxEstado.Selected = "P";


                oForm.PaneLevel += 1;
                DateTime date = DateTime.Now.AddDays(-5);
 
            }
            SetPageNumber();
            

            if ((PaneLevel -1 ) == PaneMax)
            {
                btnNext.Caption = AddonMessageInfo.Message123;
               

            }
            else
            {
                btnPrior.Item.Enabled = true;
                btnNext.Caption = AddonMessageInfo.Message122;
            }
        }


 
        private void SetPageNumber()
        {
         
            lblPageNumber.Caption = string.Format("Paso  {0} de {1} ", (PaneLevel - 1), (PaneMax));
        }

        private void btnPrior_PressedAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            PriorPane();
        }
        private void oGrid_ValidateBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
          
        }
        
        private void btnNext_PressedAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            if (btnNext.Caption == AddonMessageInfo.Message122)
                NextPane();
            else
                btnCancel.Item.Click(SAPbouiCOM.BoCellClickType.ct_Regular);
        }

        private SAPbouiCOM.StaticText StaticText1;
        private SAPbouiCOM.ComboBox ComboBox0;
        private SAPbouiCOM.StaticText StaticText2;
        private SAPbouiCOM.Button Button0;
        private SAPbouiCOM.StaticText StaticText3;
        private SAPbouiCOM.Grid Grid2;
        private SAPbouiCOM.StaticText StaticText5;
        private SAPbouiCOM.Button Button2;
        private SAPbouiCOM.Grid Grid3;
        private SAPbouiCOM.ComboBox ComboBox1;
        private SAPbouiCOM.Grid Grid0;
    }
}
