using System;
using System.Collections.Generic;
using System.Linq;
//using System.Runtime.Remoting.Messaging;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace DcsContext.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult Error()
        {
            return View();
        }
		public IActionResult Voronoi()
		{
			return View();
		}
		public IActionResult ForceDirectedGraph()
	    {
		    return View();
	    }
	    public IActionResult SigmaGraph()
	    {
		    return View();
	    }
    }
}