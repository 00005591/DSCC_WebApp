using System.Web;
using System.Web.Mvc;

namespace DSCC_CW1_5591_Front
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
