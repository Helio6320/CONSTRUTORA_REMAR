using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Http;

namespace UC_08_PI_ATV_06.Controllers
{
    public class BaseControllerFuncionario : Controller
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            if(string.IsNullOrEmpty(HttpContext.Session.GetString("func")))
            {
                filterContext.HttpContext.Response.Redirect("/Home/Login");
            }
        }
    }

}