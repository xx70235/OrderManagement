using OrderManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderManagement
{
    public class CommonProductRequireSubmit
    {
        public CommonProductRequireSubmit()
        {
        }

        private string generateCPOrderParam(CommonOrder co)
        {
            //string xmlParam = "";
            string paramXml = "<?xml version='1.0' encoding='UTF-8'?><root>";

            paramXml += " <condition>";
            paramXml += "<producttype>" + co.ProductType + "</producttype>";
            paramXml += "<productname>" + co.ProductName + "</productname>";
            paramXml += "<englishname>" + co.EnglishName + "</englishname>";
            paramXml += "<coverscope>" + co.CoverScope + "</coverscope>";
            paramXml += "<startdate>" + co.StartDate + "</startdate>";
            paramXml += "<enddate>" + co.EndDate + "</enddate>";

            paramXml += "</condition>";


            paramXml += "</root>";
            return paramXml;
        }

        public string SubmitCPRequire(CommonOrder commonOrder)
        {
            try
            {
                CPRequireSubmitService.CPRequireSubmitClient cprequireSubmitclient = new CPRequireSubmitService.CPRequireSubmitClient();
                string xmlParam = generateCPOrderParam(commonOrder);
                string result = cprequireSubmitclient.commonProductRequireSubmit(xmlParam);
                return result;
            }
            catch (System.ServiceModel.EndpointNotFoundException e)
            {
                System.Windows.Forms.MessageBox.Show("请检查网络情况！");
                return null;
            }

        }
    }
}
