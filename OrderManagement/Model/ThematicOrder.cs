using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderManagement.Model
{
    public  class ThematicOrder:Data
    {
        public string Orderid { get; set; }
        public string Industry { get; set; }
        public string OrderDate { get; set; }
        public OrderStatus Status { get; set; }
        public bool IsLocalOrder { get; set; }

        public bool IsCommonDataNeedSubmit { get; set; }
        
    }
}
