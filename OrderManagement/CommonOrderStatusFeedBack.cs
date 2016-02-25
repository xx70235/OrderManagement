using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderManagement
{
    public class CommonOrderStatusFeedBack
    {
        public string result { get; set; }
        public string GenerateCommonOrderFeedBackStr(string orderId)
        {
            string paramXml = "<?xml version='1.0' encoding='UTF-8'?><root><condition>";
            paramXml += "<orderid>" + orderId + "</orderid>";
            paramXml += "</condition></root>";

            return paramXml;

        }

        public string GetFeedBack(string queryParam)
        {
            try
            {
                CPOrderStateFeedbackService.CPOrderStateFeedbackClient cposfc = new CPOrderStateFeedbackService.CPOrderStateFeedbackClient();
                result = cposfc.commonProductStateFeedback(queryParam);
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
