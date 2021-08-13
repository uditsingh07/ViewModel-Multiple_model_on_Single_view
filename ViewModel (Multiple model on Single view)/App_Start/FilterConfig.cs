using System.Web;
using System.Web.Mvc;

namespace ViewModel__Multiple_model_on_Single_view_
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
