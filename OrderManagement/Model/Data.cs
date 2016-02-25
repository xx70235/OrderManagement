using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderManagement.Model
{
    public class Data
    {


        public string ProductName { get; set; }
        public string ProductType { get; set; }
        public string CoverScope { get; set; }
        public string EnglishName { get; set; }
        public string StartDate { get; set; }
        public String EndDate { get; set; }
        public bool IsInDataBase { get; set; }
    }
}
