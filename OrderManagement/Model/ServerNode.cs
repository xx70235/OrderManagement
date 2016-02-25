using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderManagement.Model
{
    class ServerNode
    {
        public int Id { get; set; }
        public string NodeName { get; set; }
        public string NodeIp { get; set; }
        public int Port { get; set; }
        public List<ThematicOrder> ThematicOrderList { get; set; }
        public string Status { get; set; }
        public int TaskNum { get; set; }
    }
}
