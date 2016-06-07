using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbLibrary.Models;
using System.Data.Entity;

namespace DbLibrary.Services
{
    public class dbServices
    {
        public static List<TestUserModel> getAll()
        {
            using (var context = new TestContext())
            {
                var list = context.Users.ToList();
                return (list);
            }
           
        }
        public static TestUserModel Find(int? id)
        {
            using (var context = new TestContext())
            {
                var find = context.Users.Find(id);
                return(find);
            }
           
        }
        public static void Add(TestUserModel testModel)
        {
            using (var context = new TestContext())
            {
                context.Users.Add(testModel);
                context.SaveChanges();
            }
        }
        public static void Save()
        {
            using (var context = new TestContext())
            {
                context.SaveChanges();
            }
        }
        public static void Edit(TestUserModel testModel, int id)
        {
            using (var context = new TestContext())
            {
                testModel.UserID = id;
                context.Entry(testModel).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
        public static void Remove(TestUserModel testModel)
        {
            using (var context = new TestContext())
            {
                context.Users.Attach(testModel);
                context.Users.Remove(testModel);
                context.SaveChanges();

            }
        }
        public static void Dispose()
        {
            using (var context = new TestContext())
            {
                context.Dispose();
            }
        }
    }
        
        
}

