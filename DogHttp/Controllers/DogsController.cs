using Microsoft.AspNetCore.Mvc;

namespace DogHttp.Controllers
{
	public class DogsController : Controller
	{
		public IActionResult Index(int code)
		{
			string baseString = $"https://http.dog/{code}.jpg";
			return View((object)baseString);
		}
	}
}
