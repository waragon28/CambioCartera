using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SAPbouiCOM.Framework;
using Vistony.CarteraCliente.BO;
using Forxap.Framework.Extensions;
using Forxap.CarteraCliente.UI.Win.Asistentes;

namespace Vistony.CarteraCliente.Win.Asistentes
{
    [FormAttribute("Vistony.CarteraCliente.Win.Asistentes.PersonalizarMensaje", "Asistentes/PersonalizarMensaje.b1f")]
    class PersonalizarMensaje : UserFormBase
    {
        public PersonalizarMensaje()
        {
        }
        string mensaje = "";
        string strOwnerForm = "";
        public SAPbouiCOM.Form OwnerForm;
        public PersonalizarMensaje(string ownerForm, string mensaje)
        {
            this.mensaje = mensaje;
            this.strOwnerForm = ownerForm;
            EditText1.Value = mensaje;
        }
        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
            this.EditText1 = ((SAPbouiCOM.EditText)(this.GetItem("Item_1").Specific));
            this.StaticText0 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_2").Specific));
            this.Button0 = ((SAPbouiCOM.Button)(this.GetItem("Item_0").Specific));
            this.Button0.ClickAfter += new SAPbouiCOM._IButtonEvents_ClickAfterEventHandler(this.Button0_ClickAfter);
            this.OnCustomInitialize();

        }

        /// <summary>
        /// Initialize form event. Called by framework before form creation.
        /// </summary>
        public override void OnInitializeFormEvents()
        {
            this.LoadAfter += new LoadAfterHandler(this.Form_LoadAfter);

        }

        private void OnCustomInitialize()
        {
            oForm = SAPbouiCOM.Framework.Application.SBO_Application.Forms.Item(this.UIAPIRawForm.UniqueID);
            oForm.ScreenCenter();
            oForm.Mode = SAPbouiCOM.BoFormMode.fm_OK_MODE;
        }

        private SAPbouiCOM.EditText EditText1;
        private SAPbouiCOM.StaticText StaticText0;
        private SAPbouiCOM.Form oForm;
        private void Form_LoadAfter(SAPbouiCOM.SBOItemEventArg pVal)
        {
           // throw new System.NotImplementedException();

        }

        private SAPbouiCOM.Button Button0;

        private void Button0_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            OwnerForm = SAPbouiCOM.Framework.Application.SBO_Application.Forms.Item(strOwnerForm);
            OwnerForm.GetEditText("Item_21").Value = EditText1.Value;
            this.oForm.Close();
        }
    }
}
