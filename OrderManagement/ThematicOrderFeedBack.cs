using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderManagement
{
    public class ThematicOrderFeedBack
    {

        public string result { get; set; }

        public string GenerateWaitCommonDataParam(string orderId)
        {
            string paramXml = "<?xml version='1.0' encoding='UTF-8'?><root><condition>";
            paramXml += "<orderid>" + orderId + "</orderid>";
            paramXml += "<username>" + "生态环境系统" + "</username>";
            paramXml += "<content>" + "数据准备中" + "</content>";
            paramXml += "<time>" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "</time>";          
            paramXml += "</condition></root>";

            return paramXml;
        }

        public string GenerateRejectParam(string orderId)
        {
            string paramXml = "<?xml version='1.0' encoding='UTF-8'?><root><condition>";
            paramXml += "<orderid>" + orderId + "</orderid>";
            paramXml += "<username>" + "生态环境系统" + "</username>";
            paramXml += "<content>" + "已拒绝" + "</content>";
            paramXml += "<time>" + DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss") + "</time>";
            paramXml += "</condition></root>";

            return paramXml;
        }

        public string SubmitFeedBack(string queryParam)
        {
            try
            {
               // TPOrderQueryService.TPOrderQueryClient tpqc = new TPOrderQueryService.TPOrderQueryClient();
                TPStateFeedbackService.TPStateFeedbackClient tpsfbc = new TPStateFeedbackService.TPStateFeedbackClient();
                result = tpsfbc.thematicProductStateFeedback(queryParam);
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
