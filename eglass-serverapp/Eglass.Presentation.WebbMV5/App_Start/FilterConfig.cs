using System.Web;
using System.Web.Mvc;

namespace Eglass.Presentation.WebbMV5
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
