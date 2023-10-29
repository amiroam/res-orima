#region using
using Microsoft.AspNetCore.Mvc;
namespace resume.main.Controllers
#endregion


{
    public class AdminController : Controller
    {
        #region AdminDashboard
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(string Email, string Username)
        {
            //Add Email and Username to the Data Base
            return View();
        }
        #endregion

    }
}
