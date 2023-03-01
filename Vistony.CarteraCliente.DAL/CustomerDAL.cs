using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forxap.Framework;
using Newtonsoft.Json;
using Vistony.Cartera.BO;
using Forxap.Framework.UI;

namespace Vistony.Cartera.DAL
{
    public class CustomerDAL
    {
        public string UpdateCustomers(ClienteVendedor json, string CardCode)
        {
            try
            {
                dynamic response;
                Forxap.Framework.ServiceLayer.Methods methods = new Forxap.Framework.ServiceLayer.Methods();
                dynamic jsonData = JsonConvert.SerializeObject(json);
                response = methods.PATCH("BusinessPartners", CardCode, jsonData);
                dynamic m = JsonConvert.DeserializeObject(response.Content.ToString());
                //string rpta = m.ToString();
                if (response.StatusCode.ToString() == "NoContent")
                {
                    return "Actualizado correctamente";
                }
                else
                {
                    return m["error"]["message"]["value"].ToString();
                }
            }
            catch (Exception ex)
            {
                Sb1Messages.ShowError(ex.Message);
                return ex.Message;
            }
            
        }
        public string UpdateEmpeyolee(string empID, string json)
        {
            try
            {
                dynamic response;
                Forxap.Framework.ServiceLayer.Methods methods = new Forxap.Framework.ServiceLayer.Methods();
                response = methods.PATCH("EmployeesInfo", empID, json);
                dynamic m = JsonConvert.DeserializeObject(response.Content.ToString());
                //string rpta = m.ToString();
                if (response.StatusCode.ToString() == "NoContent")
                {
                    return "Actualizado correctamente";
                }
                else
                {
                    return m["error"]["message"]["value"].ToString();
                }
            }
            catch (Exception ex)
            {
                Sb1Messages.ShowError(ex.Message);
                return ex.Message;
            }
        }
    }
}
