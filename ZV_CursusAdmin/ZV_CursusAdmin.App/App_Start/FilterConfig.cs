using System.Web;
using System.Web.Mvc;

namespace ZV_CursusAdmin.App
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
