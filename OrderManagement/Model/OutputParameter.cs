using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderManagement.Model
{
    public class OutputParameter
    {
        public string Output_id { get; set; }
        public string Model_id { get; set; }
        public string OutputPara_name { get; set; }
        public string OutputPara_valueType { get; set; }
        public string OutputPara_defaultValue { get; set; }
        public string OutputPara_currentValue { get; set; }
        public string OutputPara_des { get; set; }
        public string OutputPara_model_name { get; set; }
    }
}
