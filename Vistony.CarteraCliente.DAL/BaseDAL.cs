﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forxap.Cartera.DAL
{
    public class BaseDAL
    {

       public static SAPbobsCOM.Company oCompany;
       private static SAPbouiCOM.Application oApplication;
       

       public static bool SetDataAccesLayer(SAPbouiCOM.Application application, SAPbobsCOM.Company company)
       {
           bool ret = false;
           try
           {
               oApplication = application;
               oCompany = company;
               ret = true;
           }
           catch (Exception exception)        /// <summary>
           {

               throw;
           }
           ;

           return ret;
       }

    }
}
