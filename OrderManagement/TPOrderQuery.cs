using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderManagement
{
    public class TPOrderQuery
    {
        public string result { get; set; }


        public string GenerateQueryParam(string dataCategory, string startDate, string endDate)
        {
            string paramXml = "<?xml version='1.0' encoding='UTF-8'?><root><condition>";
            paramXml += "<industry>" + dataCategory + "</industry>";
            paramXml += "<startdate>" + startDate + "</startdate>";
            paramXml += "<enddate>" + endDate + "</enddate>";
            //paramXml += "<industry>" + "林业" + "</industry>";
            //paramXml += "<startdate>" + "2015-03-10" + "</startdate>";
            //paramXml += "<enddate>" + "2015-03-30" + "</enddate>";
            paramXml += "<flag>1</flag>";
            paramXml += "<pageno>1</pageno>";
            paramXml += "<pagesize>20</pagesize></condition></root>";

            return paramXml;
        }

        public string ExcuteQuery(string queryParam)
        {
            try
            {
                TPOrderQueryService.TPOrderQueryClient tpqc = new TPOrderQueryService.TPOrderQueryClient();
                result = tpqc.thematicProductOrderQuery(queryParam);
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
