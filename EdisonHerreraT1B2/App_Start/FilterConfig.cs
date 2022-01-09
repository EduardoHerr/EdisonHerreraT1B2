using System.Web;
using System.Web.Mvc;

namespace EdisonHerreraT1B2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
