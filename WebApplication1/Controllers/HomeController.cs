using Newtonsoft.Json;
using System.Collections.Generic;
using System.Web.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Index()
        {
            Session["Login_Error"] = false;
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginModel model)
        {
            UserModel thisUser = new UserModel();
            string url = "http://qa-api.unmc.ad/vloanapi/Session";
            string user = JsonConvert.SerializeObject(model);
            RequestModel r = new RequestModel();
            try
            {
                string newline = r.HttpRequest(url, "application/json", user, "POST");
                thisUser = JsonConvert.DeserializeObject<UserModel>(newline);
                Session["Current_User"] = thisUser;
                return View("UserPage", thisUser);
                
            }
            catch
            {
                Session["Login_Error"] = true;
                return View("Index");
            }        
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Location()
        {
            RequestModel r = new RequestModel();
            string newline;
            string apiUrl;
            var stateList1 = new List<StateModel>();
            apiUrl = "http://qa-api.unmc.ad/vloanapi/states/";
            newline = r.HttpRequest(apiUrl,null,null,null);
            StateViewModel stateList = JsonConvert.DeserializeObject<StateViewModel>(newline);
            foreach (var item in stateList.data)
            {
                if (item.is_licensed == true)
                {
                    stateList1.Add(item);
                }
            } 
            return View(stateList1);
        }

        [HttpPost]
        public JsonResult getCounties(string id, RequestModel r)
        {
            if (id!="")
            {
                string apiUrl = "http://qa-api.unmc.ad/vloanapi/states/" + id + "/counties";
                string response;   
                //get index of selected state in drop down
                //clear dropdown as not to append
                response = r.HttpRequest(apiUrl,null,null,null);
                return Json(response);
            }
            return Json(null);
        }
        public ActionResult UserPage()
        {
            if(Session["Current_User"] != null)
            {
                return View(Session["Current_User"]);
            }
            else
            {
                return View();
            }
           
        }
        public ActionResult LogOut()
        {
            Session["Current_User"] = null;
            return View("Index");
        }
        public ActionResult _LoginPartial()
        {
            if (Session["Current_User"] != null)
            {
                UserModel user = (UserModel)Session["Current_User"];
                return PartialView("_LoginPartial",user);


            }
            else
            {
                return PartialView();
            }
        }
        public ActionResult Error()
        {
            if ((bool)Session["Login_Error"] == true)
            {
                 return PartialView(1);
            }
            else
            {
                return PartialView(0);
            }
           
        }
    }
}