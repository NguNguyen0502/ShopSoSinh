using System.Web;
using System.Web.Mvc;
using ShopBeSoSinh.Controllers;

namespace ShopBeSoSinh
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //filters.Add(new SecurityActionFilterAttribute());
        }
    }
}
