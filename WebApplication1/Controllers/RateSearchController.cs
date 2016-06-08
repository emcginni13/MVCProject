using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1;
using RateSearch.Models;
using Newtonsoft.Json;

namespace WebApplication1.Controllers
{
    public class RateSearchController : Controller
    {
        // GET: RateSearch
        public ActionResult Index()
        {
            RateSearchModel result = new RateSearchModel();
            string url = "http://qa-api.unmc.ad/vloanapi/rate-search";
            var body = "{\"loan_purpose_type_id\":1,\"down_payment_percent\":20,\"is_military\":false,\"is_first_home_purchase\":true,\"credit_score_type_id\":2,\"occupancy_type_id\":1,\"occupancy_length_type_id\":1,\"property_type_id\":1,\"property_state_id\":36,\"property_county_id\":932,\"property_estimated_value\":200000}";
            RequestModel r = new RequestModel();
            string response = r.HttpRequest(url, "application/json", body, "POST");
            result = JsonConvert.DeserializeObject<RateSearchModel>(response);
            return View(result);
        }
    }
}