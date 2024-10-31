using System.Web;
using System.Web.Mvc;

namespace Project2_PTQ_2210900059
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
