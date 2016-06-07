using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class LoginModel
    {
        public Login user { get; set; }
    }
    public class Login
    {   
            public string email { get; set; }
            public string password { get; set; } 
    }
}