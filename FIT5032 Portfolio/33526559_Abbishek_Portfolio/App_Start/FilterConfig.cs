using System.Web;
using System.Web.Mvc;

namespace _33526559_Abbishek_Portfolio
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
