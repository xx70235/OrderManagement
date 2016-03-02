using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace OrderManagement.Model
{
    public class ProductDataMap
    {
        Dictionary<string, List<string>> commonMap;//所需共性产品对照表
        Dictionary<string, List<string>> assistMap;//所需辅助数据对照表
        List<string> thematicNameList;
        public ProductDataMap()
        {
            commonMap = new Dictionary<string, List<string>>();
            assistMap = new Dictionary<string, List<string>>();
            thematicNameList = new List<string>();
            retriveProductDataMap();
        }


        private void addToCommonMap(string name, List<String> list)
        {
            commonMap.Add(name, list);
        }

        private void addToAssistMap(string name, List<String> list)
        {
            assistMap.Add(name, list);
        }

        private void addToThematicNameList(string name)
        {
            thematicNameList.Add(name);
        }

        public List<string> GetCommonInNeed(ThematicOrder to)
        {
            if (thematicNameList.Count == 0)
                return null;
            foreach(string name in thematicNameList)
            {
                if (to.ProductName.Contains(name))
                    return commonMap[name];
            }
            return null;
        }

        public List<string> GetAssistInNeed(ThematicOrder to)
        {
            if (thematicNameList.Count == 0)
                return null;
            foreach (string name in thematicNameList)
            {
                if (to.ProductName.Contains(name))
                    return assistMap[name];
            }
            return null;
        }

        private void retriveProductDataMap()
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreComments = true;//忽略文档里面的注释
            XmlReader reader = XmlReader.Create(@"productdataneed.xml", settings);
            xmlDoc.Load(reader);
            //取出所有thematic product的名字
            XmlNodeList xnl = xmlDoc.SelectNodes("/data/thematic");
            //List<String> thematicNameList = new List<String>();
            //ProductDataMap pdm = new ProductDataMap();
            foreach (XmlNode xn in xnl)
            {
                List<String> commonNameList = new List<String>();
                List<String> assistNameList = new List<String>();
                XmlElement xe = (XmlElement)xn;
                string name = xe.GetAttribute("name").ToString();
                XmlNodeList commonNodeList = xe.SelectNodes("common");
                if (commonNodeList.Count != 0)
                    foreach (XmlNode commonxn in commonNodeList)
                    {
                        XmlElement commonxe = (XmlElement)commonxn;

                        commonNameList.Add(commonxe.InnerText.ToString().Trim());
                    }
                this.addToCommonMap(name, commonNameList);

                XmlNodeList assistNodeList = xe.SelectNodes("assist");
                if (assistNodeList.Count != 0)
                    foreach (XmlNode assistxn in assistNodeList)
                    {
                        XmlElement assistxe = (XmlElement)assistxn;

                        assistNameList.Add(assistxe.InnerText.ToString().Trim());
                    }
                this.addToAssistMap(name, assistNameList);

                this.addToThematicNameList(xe.GetAttribute("name").ToString());
            }




        }

    }
}
