using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderManagement.Model
{
    public class TaskQueue : Data
    {
        bool isLocalOrder = false;
        ThematicOrder thematicOrder;
        List<CommonOrder> commonOrderList;
        List<AssistData> assistDataList;
        public TaskQueue(ThematicOrder to, List<CommonOrder> commonOrderList, List<AssistData> assistDataList)
        {
            this.thematicOrder = to;
            this.commonOrderList = commonOrderList;
            this.assistDataList = assistDataList;
            if (to.Orderid == null)
            {
                isLocalOrder = true;
            }
            else
            {

            }
        }

        public TaskQueue()
        { 
        }
    }
}
