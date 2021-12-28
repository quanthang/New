using System.Web;
using System.Web.Mvc;

namespace T2009M1_HoSyQuan_Wad
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
