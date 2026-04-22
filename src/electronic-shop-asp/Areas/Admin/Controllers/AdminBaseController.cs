using Microsoft.AspNetCore.Mvc;

namespace electronic_shop_asp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminBaseController : Controller
    {
        protected bool IsAdmin()
        {
            return HttpContext.Session.GetString("UserRole") == "Admin"
                || HttpContext.Session.GetString("Role") == "Admin";
        }

        protected IActionResult RedirectIfNotAdmin()
        {
            if (!IsAdmin())
            {
                return RedirectToAction("Index", "Home", new { area = "" });
            }

            return null!;
        }
    }
}