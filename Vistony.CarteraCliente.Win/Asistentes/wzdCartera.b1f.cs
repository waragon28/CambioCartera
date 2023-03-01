using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using SAPbouiCOM.Framework;
using Forxap.CarteraCliente.UI.Win.Asistentes;
/*using Forxap.Framework.Extensions;
using Forxap.Framework.UI;*/
using Vistony.Cartera.DAL;
using Vistony.Cartera.BO;
using Vistony.CarteraCliente.UI.Constans;
using Forxap.Framework.Extensions;
using Forxap.Framework.UI;
using Vistony.CarteraCliente.BO;
using RestSharp;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Vistony.CarteraCliente.Win.Asistentes
{
    [FormAttribute(AddonWinForms.wzdCambioCartera, "Asistentes/wzdCartera.b1f")]
    class wzdCartera : BaseWizard
    {

        private SAPbouiCOM.StaticText StaticText0;
        private SAPbouiCOM.StaticText StaticText1;
        private SAPbouiCOM.Button btnCancel;
        private SAPbouiCOM.Button btnNext;
        private SAPbouiCOM.Button btnPrior;
        private SAPbouiCOM.StaticText lblPageNumber;
        private SAPbouiCOM.Grid oGrid;
        private SAPbouiCOM.Grid Grid1;
        private SAPbouiCOM.EditText EditText0;
        private SAPbouiCOM.StaticText StaticText3;
        private SAPbouiCOM.StaticText StaticText4;
        private SAPbouiCOM.EditText EditText1;
        private SAPbouiCOM.EditText EditText2;
        private SAPbouiCOM.EditText EditText3;
        private SAPbouiCOM.Button Button3;
        private SAPbouiCOM.Grid Grid0;
        private SAPbouiCOM.StaticText StaticText2;
        private SAPbouiCOM.StaticText StaticText5;
        private SAPbouiCOM.StaticText lblLoading;
        public string MensajePersonalizado { get; set; }
        public int mensaje ;
        public wzdCartera()
        {

        }

        public wzdCartera( string mensaje)
        {
           this.MensajePersonalizado = mensaje;
        }
        /// <summary>
        /// Initialize components. Called by framework after form created.
        /// </summary>
        public override void OnInitializeComponent()
        {
            this.StaticText0 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_0").Specific));
            this.StaticText1 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_1").Specific));
            this.btnCancel = ((SAPbouiCOM.Button)(this.GetItem("2").Specific));
            this.btnPrior = ((SAPbouiCOM.Button)(this.GetItem("6").Specific));
            this.btnPrior.PressedAfter += new SAPbouiCOM._IButtonEvents_PressedAfterEventHandler(this.btnPrior_PressedAfter);
            this.btnNext = ((SAPbouiCOM.Button)(this.GetItem("7").Specific));
            this.btnNext.PressedAfter += new SAPbouiCOM._IButtonEvents_PressedAfterEventHandler(this.btnNext_PressedAfter);
            this.lblPageNumber = ((SAPbouiCOM.StaticText)(this.GetItem("Item_5").Specific));
            this.EditText0 = ((SAPbouiCOM.EditText)(this.GetItem("Item_6").Specific));
            this.EditText0.ChooseFromListAfter += new SAPbouiCOM._IEditTextEvents_ChooseFromListAfterEventHandler(this.EditText0_ChooseFromListAfter);
            this.StaticText3 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_7").Specific));
            this.StaticText4 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_8").Specific));
            this.EditText1 = ((SAPbouiCOM.EditText)(this.GetItem("Item_9").Specific));
            this.EditText2 = ((SAPbouiCOM.EditText)(this.GetItem("Item_10").Specific));
            this.EditText2.ChooseFromListBefore += new SAPbouiCOM._IEditTextEvents_ChooseFromListBeforeEventHandler(this.EditText2_ChooseFromListBefore);
            this.EditText2.ChooseFromListAfter += new SAPbouiCOM._IEditTextEvents_ChooseFromListAfterEventHandler(this.EditText2_ChooseFromListAfter);
            this.EditText3 = ((SAPbouiCOM.EditText)(this.GetItem("Item_11").Specific));
            this.EditText3.ClickAfter += new SAPbouiCOM._IEditTextEvents_ClickAfterEventHandler(this.EditText3_ClickAfter);
            this.Button3 = ((SAPbouiCOM.Button)(this.GetItem("Item_12").Specific));
            this.Button3.PressedAfter += new SAPbouiCOM._IButtonEvents_PressedAfterEventHandler(this.Button3_PressedAfter);
            this.oGrid = ((SAPbouiCOM.Grid)(this.GetItem("Item_13").Specific));
            this.oGrid.DoubleClickAfter += new SAPbouiCOM._IGridEvents_DoubleClickAfterEventHandler(this.oGrid_DoubleClickAfter);
            this.Grid1 = ((SAPbouiCOM.Grid)(this.GetItem("Item_14").Specific));
            this.Grid0 = ((SAPbouiCOM.Grid)(this.GetItem("Item_2").Specific));
            this.StaticText2 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_3").Specific));
            this.StaticText5 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_4").Specific));
            this.lblLoading = ((SAPbouiCOM.StaticText)(this.GetItem("Item_15").Specific));
            this.StaticText6 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_16").Specific));
            this.CheckBox0 = ((SAPbouiCOM.CheckBox)(this.GetItem("Item_17").Specific));
            this.CheckBox0.ClickAfter += new SAPbouiCOM._ICheckBoxEvents_ClickAfterEventHandler(this.CheckBox0_ClickAfter);
            this.CheckBox1 = ((SAPbouiCOM.CheckBox)(this.GetItem("Item_18").Specific));
            this.CheckBox2 = ((SAPbouiCOM.CheckBox)(this.GetItem("Item_19").Specific));
            this.Button1 = ((SAPbouiCOM.Button)(this.GetItem("Item_20").Specific));
            this.Button1.ClickAfter += new SAPbouiCOM._IButtonEvents_ClickAfterEventHandler(this.Button1_ClickAfter);
            this.EditText4 = ((SAPbouiCOM.EditText)(this.GetItem("Item_21").Specific));
            this.Grid2 = ((SAPbouiCOM.Grid)(this.GetItem("Item_22").Specific));
            this.StaticText7 = ((SAPbouiCOM.StaticText)(this.GetItem("Item_23").Specific));
            this.EditText5 = ((SAPbouiCOM.EditText)(this.GetItem("Item_24").Specific));
            this.EditText5.KeyDownAfter += new SAPbouiCOM._IEditTextEvents_KeyDownAfterEventHandler(this.EditText5_KeyDownAfter);
            this.EditText6 = ((SAPbouiCOM.EditText)(this.GetItem("Item_25").Specific));
            this.EditText6.KeyDownAfter += new SAPbouiCOM._IEditTextEvents_KeyDownAfterEventHandler(this.EditText6_KeyDownAfter);
            this.OnCustomInitialize();

        }
        public static void MenuEvent(ref SAPbouiCOM.MenuEvent pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
        }
        /// <summary>
        /// Initialize form event. Called by framework before form creation.
        /// </summary>
        /// 
        public override void OnInitializeFormEvents()
        {
            this.LoadAfter += new SAPbouiCOM.Framework.FormBase.LoadAfterHandler(this.Form_LoadAfter);
            this.ActivateAfter += new ActivateAfterHandler(this.Form_ActivateAfter);

        }
        public VIST_RUTATRABAJO ObtenerCabecera(SAPbouiCOM.Grid dt, string U_VIS_SlpCode, string U_VIS_SlpName)
        {
            List<VIST_RUTATRABAJO> CabeceraRentabilidad = new List<VIST_RUTATRABAJO>();
            VIST_RUTATRABAJO VIST_RUTATRABAJO_Document = new VIST_RUTATRABAJO();
            Guid code = Guid.NewGuid();
            VIST_RUTATRABAJO_Document.Code = code.ToString();
            VIST_RUTATRABAJO_Document.U_VIS_SlpCode = U_VIS_SlpCode;
            VIST_RUTATRABAJO_Document.U_VIS_SlpName = U_VIS_SlpName;
            VIST_RUTATRABAJO_Document.VIST_RUTATRABAJO_DTCollection = ObtenerDetalle(dt, code.ToString());
            return VIST_RUTATRABAJO_Document;
        }
        public List<VIST_RUTATRABAJO_DTCollection> ObtenerDetalle(SAPbouiCOM.Grid dt, string code)
        {

            List<VIST_RUTATRABAJO_DTCollection> VIST_RUTATRABAJO_DTCollectionDocumentDetalls = new List<VIST_RUTATRABAJO_DTCollection>();

            for (int oRows = 0; oRows < dt.Rows.Count; oRows++)
            {
                VIST_RUTATRABAJO_DTCollection VIST_RUTATRABAJO_DTCollectionDocumentDetallsDocumentDetalls = new VIST_RUTATRABAJO_DTCollection();
                    VIST_RUTATRABAJO_DTCollectionDocumentDetallsDocumentDetalls.Code = code;
                    VIST_RUTATRABAJO_DTCollectionDocumentDetallsDocumentDetalls.U_VIS_ZonaCode = dt.DataTable.GetString("U_VIS_ZonaCode", oRows).ToString();
                    VIST_RUTATRABAJO_DTCollectionDocumentDetallsDocumentDetalls.U_VIS_Zone = dt.DataTable.GetString("U_VIS_Zone", oRows).ToString();
                VIST_RUTATRABAJO_DTCollectionDocumentDetallsDocumentDetalls.U_VIS_Frequency = dt.DataTable.GetString("U_VIS_Frequency", oRows).ToString().Trim();
                    VIST_RUTATRABAJO_DTCollectionDocumentDetallsDocumentDetalls.U_VIS_NextDate = dt.DataTable.GetString("U_VIS_NextDate", oRows).ToString();
                    VIST_RUTATRABAJO_DTCollectionDocumentDetallsDocumentDetalls.U_VIS_StartDate = dt.DataTable.GetString("U_VIS_StartDate", oRows).ToString();
                    VIST_RUTATRABAJO_DTCollectionDocumentDetallsDocumentDetalls.U_VIS_Day = dt.DataTable.GetString("U_VIS_Day", oRows).ToString();
                VIST_RUTATRABAJO_DTCollectionDocumentDetallsDocumentDetalls.U_VIS_QtyCust = dt.DataTable.GetString("U_VIS_QtyCust", oRows).ToString();
                    VIST_RUTATRABAJO_DTCollectionDocumentDetalls.Add(VIST_RUTATRABAJO_DTCollectionDocumentDetallsDocumentDetalls);
            }
            return VIST_RUTATRABAJO_DTCollectionDocumentDetalls;

        }

        public void CargarRutaTrabajo(SAPbouiCOM.Grid Grid0, SAPbouiCOM.Form oForm, string Codvendedor,string DT)
        {

            SAPbouiCOM.DataTable oDatatable;
            try
            {
               
                string strHANA = "";
                strHANA = string.Format("SELECT T1.\"U_VIS_ZonaCode\", T1.\"U_VIS_Zone\", T1.\"U_VIS_Frequency\","+
                    "TO_NVARCHAR(T1.\"U_VIS_NextDate\",'YYYYMMDD') as \"U_VIS_NextDate\", TO_NVARCHAR(T1.\"U_VIS_StartDate\",'YYYYMMDD') as \"U_VIS_StartDate\"," +
                    "T1.\"U_VIS_Day\",T1.\"U_VIS_QtyCust\" FROM \"@VIST_RUTATRABAJO\" T0 " +
                    "inner join \"@VIST_RUTATRABAJO_DT\"  T1 "+
                    "ON T0.\"Code\" = T1.\"Code\" WHERE T0.\"U_VIS_SlpCode\" = '{0}' ", Codvendedor);
                Grid0.DataTable.ExecuteQuery(strHANA);
                oDatatable = oForm.DataSources.DataTables.Item(DT);
            }
            catch (Exception EX)
            {
                //Sb1Messages.ShowError(string.Format("Error carga de ruta chofer " + EX.ToString()));
            }
        }

        private void OnCustomInitialize()
        {
            oForm = SAPbouiCOM.Framework.Application.SBO_Application.Forms.Item(this.UIAPIRawForm.UniqueID);
            
            oForm.ScreenCenter();
            oGrid.AutoResizeColumns();
            btnPrior.Item.Enabled = false;
            PaneLevel = 1;
            PaneMax = 2;
            lblPageNumber.Item.ToPane = PaneMax + 1;
            lblPageNumber.SetBold();
            SetPageNumber();
            EditText4.Value = "VISTONY: Estimado/a cliente {0},.." + "\n"+"le informamos que a partir del " + DateTime.Now.ToString("dd/MM/yyyy")+" "+
                              "el ejecutivo de ventas asignado sera : ..{1}...." + " \n"+"le agradecemos por su preferencia.";
        }
        private void SetPageNumber()
        {

            lblPageNumber.Caption = string.Format("Paso  {0} de {1} ", (PaneLevel - 1), (PaneMax));
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
            oForm.Freeze(true);
            if ((PaneLevel - 1) < PaneMax)
            {
                oForm.PaneLevel += 1;
                btnNext.Item.Enabled = true;
            }
            SetPageNumber();

            if (PaneLevel - 1 == 2)
            {
                StaticText6.Item.Visible = true;
                StaticText6.Item.Height = 20;
                StaticText6.Item.FontSize = 14;
                StaticText6.Item.TextStyle = 1;

                lblLoading.Item.Height = 20;
                lblLoading.Item.FontSize = 14;
                lblLoading.Item.TextStyle = 1;
                StaticText2.Item.Visible = false;
                Grid0.Item.Visible = false;
                Grid1.Item.Visible = false;
                StaticText5.Item.Visible = false;
                StaticText6.Caption = AddonMessageInfo.Message207;
                
                PaneLevel = 2;
                oForm.Freeze(false);
                if (CheckBox2.Checked)
                {
                    PaneLevel = 3;
                    mensaje = 1;
                    update();
                }

                else
                {
                     mensaje = Sb1Messages.ShowMessageBox(AddonMessageInfo.Message211);
                    if (mensaje == 1)
                    {
                        PaneLevel = 3;
                        update();
                    }
                    else
                    {
                        PaneLevel = 3;
                        update();
                    }
                   
                }
              

            }
            if (PaneLevel - 1 == PaneMax)
            {
                btnNext.Caption = AddonMessageInfo.Message123;
            }
            else
            {
                btnPrior.Item.Enabled = true;
               // CheckBox2.Checked = true;
                btnNext.Caption = AddonMessageInfo.Message122;
                //CheckBox2.ValOn = "Y";
            }
            oForm.Freeze(false);
        }
        private void btnPrior_PressedAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            PriorPane();
        }
        private void btnNext_PressedAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
           // CheckBox2.Checked = true;

            if (btnNext.Caption == AddonMessageInfo.Message122)
                NextPane();
            else
                btnCancel.Item.Click(SAPbouiCOM.BoCellClickType.ct_Regular);
        }
        private void EditText0_ChooseFromListAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            SAPbouiCOM.SBOChooseFromListEventArg chooseFromListEvent = ((SAPbouiCOM.SBOChooseFromListEventArg)(pVal));
            try
            {
                if (chooseFromListEvent.SelectedObjects != null)
                {
                    if (chooseFromListEvent.SelectedObjects.Rows.Count > 0)
                    {
                        EditText0.Value = chooseFromListEvent.SelectedObjects.GetValue("SlpCode", 0).ToString();
                        EditText1.Value = chooseFromListEvent.SelectedObjects.GetValue("SlpName", 0).ToString();

                        SAPbouiCOM.ChooseFromList cfl = oForm.ChooseFromLists.Item("CFL_OHEM");
                        cfl.SetConditions(null);
                        SAPbouiCOM.Conditions cons = cfl.GetConditions();
                        SAPbouiCOM.Condition con;
                        con = cons.Add();
                        con.Alias = "Active";
                        con.Operation = SAPbouiCOM.BoConditionOperation.co_EQUAL;
                        con.CondVal = "Y";
                        con.Relationship = SAPbouiCOM.BoConditionRelationship.cr_AND;
                        con = cons.Add();
                        /*con.Alias = "dept";
                        con.Operation = SAPbouiCOM.BoConditionOperation.co_EQUAL;
                        con.CondVal = "24";
                        con.Relationship = SAPbouiCOM.BoConditionRelationship.cr_AND;
                        con = cons.Add();*/
                        con.Alias = "salesPrson";
                        con.Operation = SAPbouiCOM.BoConditionOperation.co_NOT_EQUAL;
                        con.CondVal = "-1";

                        cfl.SetConditions(cons);
                    }
                }
            }
            catch (Exception ex)
            {
                //Sb1Messages.ShowWarning(ex.Message);
            }

        }
        private bool validateEditText(SAPbouiCOM.EditText edt)
        {
            if (string.IsNullOrEmpty(edt.Value) || edt.Value == "-1" || string.IsNullOrWhiteSpace(edt.Value))
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void EditText2_ChooseFromListAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            SAPbouiCOM.SBOChooseFromListEventArg chooseFromListEvent = ((SAPbouiCOM.SBOChooseFromListEventArg)(pVal));           

            try
            {
                if (chooseFromListEvent.SelectedObjects != null)
                {
                    if (chooseFromListEvent.SelectedObjects.Rows.Count > 0)
                    {
                        EditText2.Value = chooseFromListEvent.SelectedObjects.GetValue("salesPrson", 0).ToString();
                        string firstName = chooseFromListEvent.SelectedObjects.GetValue("firstName", 0).ToString();
                        string lasttName = chooseFromListEvent.SelectedObjects.GetValue("lastName", 0).ToString();
                        EditText3.Value = lasttName + " " + firstName;
                    }
                }
            }
            catch (Exception ex)
            {
                //Sb1Messages.ShowWarning(ex.Message);
            }
        }
        private void Button3_PressedAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            try
            {
                if (validateEditText(EditText0))
                {
                    oForm.Freeze(true);
                    SAPbouiCOM.EditTextColumn oEditCol;

                    string slp = string.Empty;
                    string strSQL = string.Empty;
                    string columna = string.Empty;


                    slp = EditText0.Value;

                    strSQL = string.Format("CALL P_VIS_VEN_UPD_SOCNEG_VEND ('{0}')", slp);

                    oGrid.DataTable.ExecuteQuery(strSQL);

                    oGrid.Columns.Item(0).Type = SAPbouiCOM.BoGridColumnType.gct_CheckBox;
                    oGrid.Columns.Item(0).TitleObject.Caption = "";

                    oEditCol = ((SAPbouiCOM.EditTextColumn)(oGrid.Columns.Item(1)));
                    oEditCol.LinkedObjectType = "2";// muestra la ventana de Socio de Negocio
                    oGrid.Columns.Item(1).TitleObject.Caption = "Código SN";

                    oEditCol = ((SAPbouiCOM.EditTextColumn)(oGrid.Columns.Item(3)));
                    oGrid.Columns.Item(5).TitleObject.Caption = "Nombre SN";

                    oEditCol.RightJustified = true;
                    columna = oEditCol.UniqueID;

                    oEditCol = ((SAPbouiCOM.EditTextColumn)(oGrid.Columns.Item(3)));
                    columna = oEditCol.UniqueID;

                    oGrid.ReadOnlyColumns();
                    oGrid.AutoResizeColumns();
                    //oGrid.AssignLineNro();

                    oGrid.Columns.Item(0).Editable = true;
                    CargarRutaTrabajo(Grid2, oForm, EditText0.Value, "DT_4");
                    oForm.Freeze(false);
                }
                else
                {
                    Sb1Messages.ShowError(string.Format(AddonMessageInfo.Message200, StaticText3.Caption));
                }
                
            }
            catch (Exception ex)
            {
                Sb1Messages.ShowError(ex.Message);
            }
            

        }
        private void mythread()
        {

            // Display the name of the
            // current working thread
            Console.WriteLine("In progress thread is: {0}", Thread.CurrentThread.Name);

           UpdateAddress();

            Console.WriteLine("Completed thread is: {0}",Thread.CurrentThread.Name);
        }
        public void update()
        {
            // Creating and initializing thread
            Thread mythr = new Thread(mythread);

            // Name of the thread is Geek thread
            mythr.Name = "Geek thread";
            mythr.Start();

            // IsBackground is the property
            // of Thread which allows thread
            // to run in the background
            mythr.IsBackground = true;

            Console.WriteLine("Main Thread Ends!!");

            ///////////////////////////////
        }
        private void getChk(SAPbouiCOM.CheckBox chk_CR, SAPbouiCOM.CheckBox chk_DV)
        {
            CustomerDAL b = new CustomerDAL();
            string StrQuery = string.Format("SELECT \"empID\" FROM OHEM WHERE \"salesPrson\"='{0}'", EditText2.Value);

            if (chk_CR.Checked)
            {
                /*SAPbobsCOM.Recordset recordSet = (SAPbobsCOM.Recordset)Sb1Globals.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
                recordSet.DoQuery(StrQuery);
                string query = string.Format("SELECT \"Code\" FROM \"@VIST_RUTATRABAJO\" WHERE \"U_VIS_SlpCode\"='{0}'", EditText2.Value);*/
            }
            if (chk_DV.Checked)
            {
                SAPbobsCOM.Recordset recordSet = (SAPbobsCOM.Recordset)Sb1Globals.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
                string strJson = string.Format("{\"Active\":\"tNO\"}");
                recordSet.DoQuery(StrQuery);
                string rpta = b.UpdateEmpeyolee(recordSet.Fields.Item("empID").Value.ToString(), strJson);
                Sb1Messages.ShowMessage(rpta);
            }
        }

        List<EnvioSMS_Detalle> ListtransferDocumentDetalls2 = new List<EnvioSMS_Detalle>();
        public EnvioSMS_Cabecera ObtenerCabecera()
        {
            EnvioSMS_Cabecera transferDocument = new EnvioSMS_Cabecera();

            transferDocument.Data =ListtransferDocumentDetalls2;
            return transferDocument;
        }
        public void EnviarSMS()
        {

            try
            {
                EnvioSMS_Cabecera ObtenerCabecera2 = new EnvioSMS_Cabecera();

                ObtenerCabecera2 = ObtenerCabecera();

                RestClient client = new RestClient("http://192.168.254.20:88/vs1.0/sms");
                RestRequest request = new RestRequest(Method.POST);
                string JsonObtenerCabezera = JsonConvert.SerializeObject(ObtenerCabecera2);
                string dataReq = JsonObtenerCabezera;
                IRestResponse result = client.Execute(request.AddJsonBody(dataReq));

                if (result.StatusDescription == "OK")
                {

                }
                else
                {
                    Sb1Messages.ShowError(result.Content);
                }
            }
            catch (Exception e)
            {

                Sb1Messages.ShowError(e.ToString());
            }



        }

        private void UpdateAddress()
        {
            PaneLevel = 3;
            List<BPResponse> lbpr = new List<BPResponse>();
            List<BPResponseError> lbpre = new List<BPResponseError>();
            CustomerDAL b = new CustomerDAL();
            EnvioSMS_Detalle transferDocumentDetalls2 = new EnvioSMS_Detalle();
            string text = "";
            try
            {
              //  Sb1Messages.ShowWarning("Procesando Datos");
                int rowCount = GetRowCountSelected2(oGrid);
                SAPbouiCOM.DataTable dt = oForm.GetDataTable("DT_1");
                SAPbouiCOM.DataTable dtError = oForm.GetDataTable("DT_2");

                SAPbouiCOM.EditTextColumn oEditCol;
                int i = 1;
                int countc = 0;
                int counte = 0;
                string CodCli = "";
                for (int row = 0; row <= oGrid.Rows.Count -1; row++)
                {
                    if (oGrid.DataTable.GetString("Col1", row) == "Y")
                    {
                        string prueba = string.Format(EditText4.Value, oGrid.DataTable.GetString("Nombre SN", row), EditText3.Value);
                        
                        string BPCode = oGrid.DataTable.GetString("CardCode", row);
                        text = BPCode;
                        string AddressName = oGrid.DataTable.GetString("Cod. Dirección", row);
                        string AddressType = oGrid.DataTable.GetString("Tipo Dirección", row);
                        string RowNum = oGrid.DataTable.GetString("Num. Línea", row);
                        int rown = RowNum == "" ? 0 : Convert.ToInt16(RowNum);
                        string U_VIS_SlpCode = EditText2.Value;
                        ClienteVendedor c = new ClienteVendedor();
                        List<BPAddresses> lbp = new List<BPAddresses>();
                        BPAddresses bp = new BPAddresses();
                        bp.AddressName = AddressName;
                        bp.AddressType = AddressType;
                        bp.RowNum = rown;
                        bp.BPCode = BPCode;
                        bp.U_VIS_SlpCode = U_VIS_SlpCode;

                        lbp.Add(bp);
                        c.BPAddresses = lbp;
                        //string progress = string.Format("Actualizando línea {0} del Socio de Negocio {1}.",RowNum, BPCode);
                        if (i + 1 < rowCount)
                        {
                            StaticText6.Item.Visible = false;
                            lblLoading.Item.Visible = true;
                            btnNext.Item.Enabled = false;
                            btnPrior.Item.Enabled = false;
                            lblLoading.Caption = string.Format(AddonMessageInfo.Message210 , i, rowCount);
                        }
                        else
                        {
                            StaticText2.Item.Visible = true;
                            StaticText5.Item.Visible = true;
                            btnPrior.Item.Enabled = true;
                            lblLoading.Item.Visible = false;
                            Grid0.Item.Visible = true;
                            Grid1.Item.Visible = true;
                            btnNext.Item.Enabled = true;
                        }

                        //string progress = string.Format("Actualizando {0} de {1} registros.",i, a);
                        //Sb1Messages.ShowWarning(progress);
                        string rpta = b.UpdateCustomers(c, BPCode);
                        //string rpta = "Actualizado correctamente";
                        if (rpta == AddonMessageInfo.Message208)
                        {
                            dt.Rows.Add();
                            dt.SetValue("Código SN", countc, BPCode);
                            dt.SetValue("Dirección", countc, AddressName);
                            dt.SetValue("Tipo", countc, AddressType);
                            dt.SetValue("Línea", countc, rown);
                            dt.SetValue("Respuesta", countc, rpta);
                            countc++;
                            //Sb1Messages.ShowSuccess(row +" / "+ oGrid.Rows.Count);
                            oEditCol = ((SAPbouiCOM.EditTextColumn)(Grid1.Columns.Item(0)));
                            oEditCol.LinkedObjectType = "2";
                            //Grid1.AssignLineNro();
                            Grid1.ReadOnlyColumns();
                            Grid1.AutoResizeColumns();

                            /*Envio de mensje Masivo*/
                            string a = Convert.ToString(oGrid.DataTable.GetValue("Telefono", row));
                            if (oGrid.DataTable.GetString("Telefono", row) != "" && CodCli != Convert.ToString(oGrid.DataTable.GetValue("Telefono", row)))
                            {
                                transferDocumentDetalls2.Mensaje = prueba.Replace("..", "\n");
                                transferDocumentDetalls2.NumeroTelf = "51" +Convert.ToString(oGrid.DataTable.GetValue("Telefono", row));
                                CodCli = Convert.ToString(oGrid.DataTable.GetValue("Telefono", row));
                                ListtransferDocumentDetalls2.Add(transferDocumentDetalls2);
                            }

                        }
                        else
                        {
                            dtError.Rows.Add();
                            dtError.SetValue("Código SN", counte, BPCode);
                            dtError.SetValue("Dirección", counte, AddressName);
                            dtError.SetValue("Tipo", counte, AddressType);
                            dtError.SetValue("Línea", counte, rown);
                            dtError.SetValue("Respuesta", counte, rpta);
                            counte++;


                            oEditCol = ((SAPbouiCOM.EditTextColumn)(Grid0.Columns.Item(0)));
                            oEditCol.LinkedObjectType = "2";
                            //Grid0.AssignLineNro();
                            Grid0.ReadOnlyColumns();
                            Grid0.AutoResizeColumns();
                        }                        
                        i++;
                        //Thread.Sleep(3000);
                    }
                }
                if (CheckBox0.Checked)
                {

                    VIST_RUTATRABAJO ObtenerCabeceraClas = ObtenerCabecera(Grid2, EditText2.Value, EditText3.Value);

                    string JsonObtenerCabezera = JsonConvert.SerializeObject(ObtenerCabeceraClas);

                    IRestResponse responsde;
                    Forxap.Framework.ServiceLayer.Methods Methods = new Forxap.Framework.ServiceLayer.Methods();
                    dynamic entrada = JsonObtenerCabezera;
                    responsde = Methods.POST("VIST_RUTATRABAJO", entrada.ToString());

                    dynamic m = JsonConvert.DeserializeObject(responsde.Content.ToString());
                    if (responsde.StatusCode.ToString() == "Created")
                    {
                        Sb1Messages.ShowSuccess("Se genero Correctamente la Rentabilidad : " + m["Code"].ToString());
                      //  var Message = Sb1Messages.ShowMessageBox("Se genero Correctamente la Rentabilidad \n ¿ Desea continuar ?");
                      //  if (Message == 2)
                      //  {
                          //  oForm.Close();
                      //  }
                       // else
                       // {
                        //}

                    }
                    else
                    {
                        Sb1Messages.ShowError(m["error"]["message"]["value"].ToString());
                    }
                }
                if (mensaje == 1)
                {
                   EnviarSMS();
                }
                else
                {

                }

              
                Sb1Messages.ShowMessage( AddonMessageInfo.Message209);
                /*ConvertToDataTable(lbpr);
                ConvertToDataTableError(lbpre);*/

                



                oForm.Freeze(false);
            }
            catch (Exception ex)
            {
                Sb1Messages.ShowError(text);
            }
        }
        private SAPbouiCOM.DataTable ConvertToDataTable(List<BPResponse> list)
        {
            SAPbouiCOM.DataTable dt = oForm.GetDataTable("DT_1");
            SAPbouiCOM.EditTextColumn oEditCol;
            oForm.Freeze(true);
            for (int i = 0; i <= list.Count() -1; i++)
            {
                dt.Rows.Add();
                dt.SetValue("Código SN", i, list[i].CardCode);
                dt.SetValue("Dirección", i, list[i].AddressName);
                dt.SetValue("Tipo", i, list[i].AddresType);
                dt.SetValue("Línea", i, list[i].RowNum);
                dt.SetValue("Respuesta", i, list[i].Respuesta);
            }
            oEditCol = ((SAPbouiCOM.EditTextColumn)(Grid1.Columns.Item(0)));
            oEditCol.LinkedObjectType = "2";
            Grid1.AssignLineNro();
            Grid1.ReadOnlyColumns();
            Grid1.AutoResizeColumns();
            oEditCol = ((SAPbouiCOM.EditTextColumn)(Grid0.Columns.Item(0)));
            oEditCol.LinkedObjectType = "2";
            Grid0.AssignLineNro();
            Grid0.ReadOnlyColumns();
            Grid0.AutoResizeColumns();
            return dt;
        }
        private SAPbouiCOM.DataTable ConvertToDataTableError(List<BPResponseError> list)
        {
            SAPbouiCOM.DataTable dt = oForm.GetDataTable("DT_2");
            SAPbouiCOM.EditTextColumn oEditCol;
            oForm.Freeze(true);
            for (int i = 0; i <= list.Count() - 1; i++)
            {
                dt.Rows.Add();
                dt.SetValue("Código SN", i, list[i].CardCode);
                dt.SetValue("Dirección", i, list[i].AddressName);
                dt.SetValue("Tipo", i, list[i].AddresType);
                dt.SetValue("Línea", i, list[i].RowNum);
                dt.SetValue("Respuesta", i, list[i].Respuesta);
            }
            oEditCol = ((SAPbouiCOM.EditTextColumn)(Grid0.Columns.Item(0)));
            oEditCol.LinkedObjectType = "2";
            Grid0.AssignLineNro();
            Grid0.ReadOnlyColumns();
            Grid0.AutoResizeColumns();
            oForm.Freeze(false);
            return dt;
        }

        /// <summary>
        /// Retorna el nro de registros seleccionados y que seran procesados
        /// </summary>
        /// <param name="oGrid"></param>
        /// <returns></returns>
        private int GetRowCountSelected2(SAPbouiCOM.Grid oGrid)
        {
            int ret = 0;
            SAPbouiCOM.DataTable data = oGrid.DataTable;

            if (oGrid == null)
                throw new ArgumentNullException("oGrid");

            try
            {
                oForm.Freeze(true);

                //data.CopyFrom(oGrid.DataTable);

                for (int i = 0; i < oGrid.DataTable.Rows.Count; i++)
                {
                    string value = string.Empty;

                    value = data.Columns.Item("Col1").Cells.Item(i).Value.ToString();
                    if ((value == "Y"))
                    {
                        ret += 1;
                    }


                }

                oForm.Freeze(false);

            }
            catch (Exception ex)
            {
                Sb1Messages.ShowError(ex.ToString());

            }
            return ret;
        }

        private SAPbouiCOM.StaticText StaticText6;

        private void EditText2_ChooseFromListBefore(object sboObject, SAPbouiCOM.SBOItemEventArg pVal, out bool BubbleEvent)
        {
            BubbleEvent = true;
            
        }

        private SAPbouiCOM.CheckBox CheckBox0;
        private SAPbouiCOM.CheckBox CheckBox1;
        private SAPbouiCOM.CheckBox CheckBox2;

        private void Form_LoadAfter(SAPbouiCOM.SBOItemEventArg pVal)
        {
           // throw new System.NotImplementedException();

        }

        private SAPbouiCOM.Button Button1;

        private void Button1_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
           
            PersonalizarMensaje personalizamensaje = new PersonalizarMensaje(this.UIAPIRawForm.UniqueID, EditText4.Value);
            personalizamensaje.Show();
        }

        private void Form_ActivateAfter(SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();
        }

        private SAPbouiCOM.EditText EditText4;

        private void EditText3_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private SAPbouiCOM.Grid Grid2;

        private void CheckBox0_ClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            //throw new System.NotImplementedException();

        }

        private SAPbouiCOM.StaticText StaticText7;
        private SAPbouiCOM.EditText EditText5;
        string Valor = "CardCode";
        public int filaseleccionada;
        SAPbobsCOM.Recordset recordset;
        private void oGrid_DoubleClickAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            Valor = pVal.ColUID;

        }

        private void EditText5_KeyDownAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
           
        }
        private void FindText(SAPbouiCOM.SBOItemEventArg pVal)
        {
            string textFind = string.Empty;
            string columnFind = string.Empty;
            recordset = (SAPbobsCOM.Recordset)Sb1Globals.oCompany.GetBusinessObject(SAPbobsCOM.BoObjectTypes.BoRecordset);
            string RegistroEncontrado;
            try
            {
                textFind = EditText6.Value.Trim();

                string QUERY = string.Format("SELECT count(*) as \"Contar Registro\" FROM OCRD WHERE \"CardCode\"='{0}' ", textFind);
                recordset.DoQuery(QUERY);
                RegistroEncontrado = recordset.Fields.Item("Contar Registro").Value.ToString();
                if (RegistroEncontrado!="0")
                {
                    if (textFind.Length >= 8)
                    {
                        if (pVal.CharPressed != 13)
                        {
                            for (int row = 0; row <= oGrid.Rows.Count - 1; row++)
                            {
                                columnFind = Valor;

                                string docnum = oGrid.DataTable.GetString("CardCode", row);

                                if (docnum == textFind)
                                {
                                    oGrid.Rows.SelectedRows.Clear();
                                    oGrid.Rows.SelectedRows.Add(row);
                                    filaseleccionada = row;
                                    return;
                                }
                            }

                        }
                    }
                }


            }
            catch
            {
            }
        }

        private SAPbouiCOM.EditText EditText6;

        private void EditText6_KeyDownAfter(object sboObject, SAPbouiCOM.SBOItemEventArg pVal)
        {
            FindText(pVal);
        }
    }
}
