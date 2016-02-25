using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderManagement.Model
{
    public class CommonOrder:Data
    {

        public string Orderid { get; set; }
        public string OrderDate { get; set; }
        public string Status { get; set; }

        public string UpdateDate { get; set; }
    }
}
