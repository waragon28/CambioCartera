using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vistony.CarteraCliente.BO;

namespace Vistony.CarteraCliente.DAL
{
    public class EnvioSMS
    {
        public VIST_RUTATRABAJO ObtenerCabecera(SAPbouiCOM.Grid dt, string U_VIS_SlpCode, string U_VIS_SlpName)
        {
            List<VIST_RUTATRABAJO> CabeceraRentabilidad = new List<VIST_RUTATRABAJO>();
            VIST_RUTATRABAJO VIST_RUTATRABAJO_Document = new VIST_RUTATRABAJO();
            Guid code = Guid.NewGuid();
            VIST_RUTATRABAJO_Document.Code = code.ToString();
            VIST_RUTATRABAJO_Document.U_VIS_SlpCode = U_VIS_SlpCode;
            VIST_RUTATRABAJO_Document.U_VIS_SlpName = U_VIS_SlpName;
           // VIST_RUTATRABAJO_Document.VIST_RUTATRABAJO_DTCollection = ObtenerDetalle(dt, code.ToString());
            return VIST_RUTATRABAJO_Document;
        }


    }
}
