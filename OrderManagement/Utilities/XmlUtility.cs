using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using OrderManagement.Model;
namespace OrderManagement.Utilities
{
    public class XmlUtility
    {

        public List<ThematicOrder> retriveThematicOrder(string xmlstring)
        {
            if(xmlstring==null)
            {
                return null;
            }
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.LoadXml(xmlstring);
            XmlNodeList xmlNodeList = xmldoc.SelectNodes("/root/responseparam/order");
            List<ThematicOrder> thematicOrderList = new List<ThematicOrder>();
            foreach (XmlNode xxNode in xmlNodeList)
            {
                ThematicOrder to = new ThematicOrder();
                to.Orderid = xxNode.SelectSingleNode("orderid").InnerText;
                to.ProductType = xxNode.SelectSingleNode("producttype").InnerText;
                to.ProductName = xxNode.SelectSingleNode("productname").InnerText;
                to.Industry = xxNode.SelectSingleNode("industry").InnerText;
                to.EnglishName = xxNode.SelectSingleNode("englishname").InnerText;
                to.StartDate = xxNode.SelectSingleNode("startdate").InnerText;
                to.EndDate = xxNode.SelectSingleNode("enddate").InnerText;
                to.OrderDate = xxNode.SelectSingleNode("orderdate").InnerText;
                to.CoverScope = xxNode.SelectSingleNode("coverscope").InnerText;
                to.Status = OrderStatus.等待数据;
                thematicOrderList.Add(to);
            }
            return thematicOrderList;
        }

        public string GetOrderIdForLocalOrder(string xmlstring)
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.LoadXml(xmlstring);
            XmlNodeList xmlNodeList = xmldoc.SelectNodes("/root/responseparam/orderid");

            string id="";
            foreach (XmlNode xxNode in xmlNodeList)
            {
                id = xxNode.InnerText;            
            }
            return id;
        }



        public string GetOrderIdForCommonOrder(string xmlstring)
        {
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.LoadXml(xmlstring);
            XmlNodeList xmlNodeList = xmldoc.SelectNodes("/root/responseparam/orderid");

            string id = "";
            foreach (XmlNode xxNode in xmlNodeList)
            {
                id = xxNode.InnerText;
            }
            return id;
        }

        public static string GetStatusForCommonOrder(string xmlstring)
        {
            string status = "";
            try
            {
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.LoadXml(xmlstring);
                XmlNodeList xmlNodeList = xmldoc.SelectNodes("/root/responseparam/states/state/content");

                
                foreach (XmlNode xxNode in xmlNodeList)
                {
                    status = xxNode.InnerText;
                }
            }
            catch(ArgumentNullException e)
            {
                return null;
            }
            return status;
        }

        
       
        
    }
}
