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
		#endregion

	}
}
