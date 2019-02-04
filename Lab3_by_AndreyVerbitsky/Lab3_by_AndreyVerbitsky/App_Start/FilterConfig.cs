using System.Web;
using System.Web.Mvc;

namespace Lab3_by_AndreyVerbitsky
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
