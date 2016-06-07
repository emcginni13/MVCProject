using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbLibrary.Models
{
    public class TestUserModel
    {
        [Key]
        public int UserID { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
    }
    public class TestContext : DbContext
    {
        public TestContext()
            : base("ConnectionString")
        {
        }
        
        public DbSet<TestUserModel> Users { get; set; }
        
    }
}
