using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vistony.Cartera.BO
{
   public class ClienteVendedor
    {
        public List<BPAddresses> BPAddresses { get; set; }
    }

   public class BPAddresses
    {
        public string AddressName  { get; set; }
        public string AddressType { get; set; }
        public string BPCode { get; set; }
        public int RowNum { get; set; }
        public string U_VIS_SlpCode { get; set; }


    }
    public class BPResponse
    {
        public string CardCode { get; set; }
        public string AddresType { get; set; }
        public int RowNum { get; set; }
        public string AddressName  { get; set; }
        public string Respuesta { get; set; }
    }
    public class BPResponseError
    {
        public string CardCode { get; set; }
        public string AddresType { get; set; }
        public int RowNum { get; set; }
        public string AddressName { get; set; }
        public string Respuesta { get; set; }
    }
}
