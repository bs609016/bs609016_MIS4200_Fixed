using System.Web;
using System.Web.Mvc;

namespace bs609016_MIS4200_Fixed
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
