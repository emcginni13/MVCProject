using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class UserModel
    {
            public Data data { get; set; }
        public class Data
        {
            public string id { get; set; }
            public string first_name { get; set; }
            public string middle_initial { get; set; }
            public string last_name { get; set; }
            public object suffix { get; set; }
            public string email { get; set; }
            public bool email_verified { get; set; }
            public string email_confirmation_token { get; set; }
            public string phone { get; set; }
            public string url { get; set; }
            public object[] authorizations { get; set; }
            public object[] roles { get; set; }
            public int realtor_id { get; set; }
            public int loan_officer_id { get; set; }
        }

    }
}