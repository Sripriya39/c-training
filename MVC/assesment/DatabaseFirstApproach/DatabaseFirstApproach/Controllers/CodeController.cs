using DatabaseFirstApproach;
using System.Web.Mvc;

namespace DatabaseFirstApproach.Controllers
{
    public class CodeController : Controller
    {
        private NorthwindEntities db = new NorthwindEntities();

       
        public ActionResult GermanyCustomers()
        {
            var germanyCustomers = db.Customers.Where(c => c.Country == "Germany");
            return View(germanyCustomers.ToList());
        }

       
        public ActionResult CustomerDetails()
        {
            var customerDetails = db.Orders
                .Where(o => o.OrderID == 10248)
                .Select(o => o.Customer)
                .FirstOrDefault();
            return View(customerDetails);
        }
    }
}