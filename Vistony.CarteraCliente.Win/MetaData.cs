﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Vistony.CarteraCliente.UI.Constans;
using Forxap.Framework.UI;
using Forxap.Framework.Utils;


namespace Vistony.CarteraCliente.Win
{
   public  class Sb1MetaData
    {

       /// <summary>
       /// 
       /// </summary>
       public static void AddMenus()
       {
           try
           {
               Sb1Messages.ShowSuccess(string.Format(AddonMessageInfo.Message001), SAPbouiCOM.BoMessageTime.bmt_Short);
               Sb1XmlFile.LoadAddonMenu(AddonUserFiles.UserMenus);
               Sb1Messages.ShowSuccess(string.Format(AddonMessageInfo.Message002), SAPbouiCOM.BoMessageTime.bmt_Short);
           }
           catch (Exception ex)
           {
               Sb1Messages.ShowError(AddonMessageInfo.Message003, SAPbouiCOM.BoMessageTime.bmt_Medium);
           }
       }

       /// <summary>
       /// 
       /// </summary>
       public  static void AddTables()
       {
           try
           {
      
               Sb1Messages.ShowSuccess(string.Format(AddonMessageInfo.Message004), SAPbouiCOM.BoMessageTime.bmt_Short);
               Sb1XmlFile.LoadUserTables(AddonUserFiles.UserTables);
               Sb1Messages.ShowSuccess(string.Format(AddonMessageInfo.Message005), SAPbouiCOM.BoMessageTime.bmt_Short);
               
           }
           catch (Exception ex)
           {
               Sb1Messages.ShowError(AddonMessageInfo.Message006, SAPbouiCOM.BoMessageTime.bmt_Medium);
           }
       }

       /// <summary>
       /// e
       /// </summary>
       public static void AddFields()
       {
           try
           {
         
               Sb1Messages.ShowSuccess(string.Format(AddonMessageInfo.Message007), SAPbouiCOM.BoMessageTime.bmt_Short);
               Sb1XmlFile.LoadUserFields(AddonUserFiles.UserFields);
               Sb1Messages.ShowSuccess(string.Format(AddonMessageInfo.Message008), SAPbouiCOM.BoMessageTime.bmt_Short);
              
           }
           catch
           {
               Sb1Messages.ShowError(AddonMessageInfo.Message009, SAPbouiCOM.BoMessageTime.bmt_Medium);
           }
       }

       /// <summary>
       /// 
       /// </summary>
       public static void AddUdos()
       {
         
           try
           {
             
               Sb1Messages.ShowSuccess(string.Format(AddonMessageInfo.Message010), SAPbouiCOM.BoMessageTime.bmt_Short);
               Sb1XmlFile.LoadUserObject(AddonUserFiles.UserObjects);
               Sb1Messages.ShowSuccess(string.Format(AddonMessageInfo.Message011), SAPbouiCOM.BoMessageTime.bmt_Short);
      
              
           }
           catch (Exception ex)
           {
               Sb1Messages.ShowError(AddonMessageInfo.Message012, SAPbouiCOM.BoMessageTime.bmt_Medium);
           }

         
       }



       /// <summary>
       /// 
       /// </summary>
       /// <returns></returns>
       public static void AddUserScripts()
       {

           try
           {
               Sb1Messages.ShowSuccess(string.Format(AddonMessageInfo.Message016), SAPbouiCOM.BoMessageTime.bmt_Short);
               Sb1XmlFile.LoadUserScripts(AddonUserFiles.UserScripts);
               Sb1Messages.ShowSuccess(string.Format(AddonMessageInfo.Message017), SAPbouiCOM.BoMessageTime.bmt_Short);

           }
           catch (Exception ex)
           {
               Sb1Messages.ShowError(AddonMessageInfo.Message018, SAPbouiCOM.BoMessageTime.bmt_Medium);
           }


       }

       /// <summary>
       /// 
       /// </summary>
       /// <returns></returns>
       public static void AddPermissions()
       {

           try
           {
               Sb1Messages.ShowSuccess(string.Format(AddonMessageInfo.Message013), SAPbouiCOM.BoMessageTime.bmt_Short);
               Sb1XmlFile.LoadUserObject(AddonUserFiles.UserPermissions);
               Sb1Messages.ShowSuccess(string.Format(AddonMessageInfo.Message014), SAPbouiCOM.BoMessageTime.bmt_Short);

           }
           catch (Exception ex)
           {
               Sb1Messages.ShowError(AddonMessageInfo.Message015, SAPbouiCOM.BoMessageTime.bmt_Medium);
           }

           
       }
       /// <summary>
       /// ddd
       /// </summary>
        public static  void AddIcon()
        {
            try
            {
                Sb1Messages.ShowSuccess(string.Format(AddonMessageInfo.Message019), SAPbouiCOM.BoMessageTime.bmt_Short);
                Sb1XmlFile.LoadAddonIcon(AddonUserFiles.Icon, AddonMenuItem.AddonMainMenu);
                Sb1Messages.ShowSuccess(string.Format(AddonMessageInfo.Message020), SAPbouiCOM.BoMessageTime.bmt_Short);

            }
            catch (Exception ex)
            {
                Sb1Messages.ShowError(AddonMessageInfo.Message021, SAPbouiCOM.BoMessageTime.bmt_Medium);
            }

        }

   


    }// fin de la clase


}//fin del namespace


