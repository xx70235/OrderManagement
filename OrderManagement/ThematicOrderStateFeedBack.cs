using OrderManagement.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderManagement
{
    public class ThematicOrderStateFeedBack
    {
        public string result { get; set; }
        public string FeedBackThematicOrder(ThematicOrder to, string status)
        {
            try{
            string paramXml = "<?xml version='1.0' encoding='UTF-8'?><root><condition>";
            paramXml += "<orderid>" + to.Orderid + "</orderid>";
            paramXml += "<username>" + "生态环境系统" + "</username>";
            paramXml += "<content>" + status + "</content>";
            //paramXml += "<content>" + "数据准备中" + "</content>";
            paramXml += "<time>" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + "</time>";
            paramXml += "</condition></root>";

            TPStateFeedbackService.TPStateFeedbackClient tpsfb = new TPStateFeedbackService.TPStateFeedbackClient();
            result = tpsfb.thematicProductStateFeedback(paramXml);
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
