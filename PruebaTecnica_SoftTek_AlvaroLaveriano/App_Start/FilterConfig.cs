using System.Web;
using System.Web.Mvc;

namespace PruebaTecnica_SoftTek_AlvaroLaveriano
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
