using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderManagement.Model
{
    public class Sensors
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public Sensors[] Children { get; set; }
        public String Min { get; set; }
        public String Value { get; set; }
        public String Max { get; set; }
        public String ImageURL { get; set; }

   
    }
}
