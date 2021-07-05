using System.Web;
using System.Web.Mvc;

namespace _1811190667_NguyenQuocCuong_BigSchool01
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
