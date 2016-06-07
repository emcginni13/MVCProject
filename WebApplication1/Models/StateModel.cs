using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Models
{
    public class StateModel
    {
        public int id { get; set; }
        public int fips { get; set; }
        public string name { get; set; }
        public string code { get; set; }
        public bool is_licensed { get; set; }
        public IEnumerable<SelectListItem> stateSelectList { get; set; }
    }
    public class StateViewModel
    {

        public List<StateModel> data { get; set; }


    }

}