using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab2_by_AndreyVerbitsky.Controllers
{
    public class ProductController : Controller
    {
        //
        // Get: /Product/
        public string Index()
        {
            return "Product/index is displayed.";
        }

        //
        // Get:  /Product/Browse
        public string Browse()
        {
            return "Browse displayed";
        }

        //
        // Get: Product/Details/105
        public string Details(int id)
        {
            string message = "Details displayed for Id = " + id;

            return message;
        }

        //
        //Get /Product/Location?zip==44124
        public string Location(String zip)
        {
            string message = HttpUtility.HtmlEncode("Location displayed for zip = " + zip);

            return message;
        }

    }
}