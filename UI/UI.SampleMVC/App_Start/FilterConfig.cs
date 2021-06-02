using System.Web;
using System.Web.Mvc;
using UI.SampleMVC.Filters;

namespace UI.SampleMVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            filters.Add(new ModelErrorTransferFilter());

        }
    }
}
