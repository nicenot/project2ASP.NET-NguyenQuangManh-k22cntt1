using System.Web;
using System.Web.Mvc;

namespace NguyenQuangManh_2210900039_k22cnt1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
