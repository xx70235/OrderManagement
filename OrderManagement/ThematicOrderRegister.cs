using OrderManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderManagement
{
    public class ThematicOrderRegister
    {
        string result;
        public string RegistThematicOrder(ThematicOrder to)
        {

            string paramXml = "<?xml version='1.0' encoding='UTF-8'?><root><condition>";
            paramXml += "<producttype>" + to.ProductType + "</producttype>";
            paramXml += "<productname>" + to.ProductName + "</productname>";
            paramXml += "<englishname>" + to.EnglishName + "</englishname>";
            paramXml += "<industry>" + to.Industry + "</industry>";
            paramXml += "<coverscope>" + to.CoverScope + "</coverscope>";
            paramXml += "<startdate>" + to.StartDate + "</startdate>";
            paramXml += "<enddate>" + to.EndDate + "</enddate>";
            paramXml += "</condition></root>";

            TPOrderRegisterService.TPOrderRegisterClient tor = new TPOrderRegisterService.TPOrderRegisterClient();
            result = tor.thematicProductOrderRegister(paramXml);
            return result;
        }


    }
}
