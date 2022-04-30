using System.Web;
using System.Web.Mvc;

namespace MVC5_3_LAYERS_PROJECT
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
