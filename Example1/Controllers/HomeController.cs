using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;

namespace Example1.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index ()
		{
			ViewData ["Message"] = "Now we're cooking!";
			return View ();
		}
	}
}

