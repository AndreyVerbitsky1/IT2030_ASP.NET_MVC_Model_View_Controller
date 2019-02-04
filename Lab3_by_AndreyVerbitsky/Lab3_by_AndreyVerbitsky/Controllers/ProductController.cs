using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab3_by_AndreyVerbitsky.Controllers
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
        public string Details()
        {
            return "Details displayed for Id=105";
        }

        //
        //Get /Product/Location?zip==44124
        public string Location()
        {
            return "Location is displayed for zip=44124";
        }

    }
}