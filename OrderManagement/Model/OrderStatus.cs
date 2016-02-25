using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderManagement.Model
{
    public
        enum OrderStatus
    {
        已拒绝,
        等待数据,
        等待生产队列,
        生产中,
        生产完成,
        未处理
    }
}
