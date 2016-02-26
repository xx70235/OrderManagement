using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderManagement.Model
{
    public class ThematicTaskStatus
    {
        public string ThematicId { get; set; }
        public OrderStatus TaskStatus { get; set; }
        public string StatusDes { get; set; }
        public bool IsLastStatus { get; set; }
        public DateTime LastUpdateTime { get; set; }
        public string NodeName { get; set; }
        public string NodeIp { get; set; }
    }
}
