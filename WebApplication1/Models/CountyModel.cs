using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class CountyModel
    {
        public class countyByState
        {
            public int id { get; set; }
            public int fips { get; set; }
            public bool isUSDA { get; set; }
            public string pTax { get; set; }
            public string status { get; set; }
            public string name { get; set; }
        }
        public class Counties
        {
            public List<countyByState> data { get; set; }
        }
    }

}