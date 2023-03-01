using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vistony.CarteraCliente.BO;

namespace Vistony.CarteraCliente.BO
{
    public class VIST_RUTATRABAJO
    {
        public string Code { get; set; }
        public string U_VIS_SlpCode { get; set; }
        public string U_VIS_SlpName { get; set; }
        public List<VIST_RUTATRABAJO_DTCollection> VIST_RUTATRABAJO_DTCollection { get; set; }
    }
}
