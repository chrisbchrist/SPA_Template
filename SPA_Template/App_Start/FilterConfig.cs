using System.Web;
using System.Web.Mvc;

namespace Chris.SPA.SPA_Template
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
