using System;
using System.Collections.Generic;
using lost.Models;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using lost.Factory;
using Microsoft.AspNetCore.Http;
using System.Web;

namespace lost.Controllers
{
    public class HomeController : Controller
    {
        private readonly TrailFactory trailFactory;
        
        public HomeController()
        {
            //Instantiate a TrailFactory object that is immutable (READONLY)
            //This establishes the initial DB connection for us.
            trailFactory = new TrailFactory();
        }
        // GET: /Home/
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            ViewData["msg"] = "Lost in the Woods";
            //We can call upon the methods of the userFactory directly now.
            //IEnumerable<Trail> AllTrails = _trailFactory.ShowAll();
            //foreach(var i in AllTrails) 
            //{
                //System.Console.WriteLine(i.id);
            //}
            ViewBag.Trails = trailFactory.FindAll();
            return View();
        }

        [HttpGet]
        [Route("newtrail")]
        public IActionResult NewTrail()//refactored from default "About"
        {
            System.Console.WriteLine("hit the new trail route");
            ViewData["Message"] = "Got a new trail, submit the information here!";

            return View();
        }

        [HttpPost]
        [Route("create")]
        public IActionResult Create(Trail newTrail)
        {
            if(ModelState.IsValid) 
            {
                trailFactory.Add(newTrail);
                return RedirectToAction("Index");
            }
            else 
            {
                return View("NewTrail", newTrail);
            }
        }

        [HttpGet]
        [Route("trails/{id}")]
        public IActionResult Show()//refactored from original Contact
        {
            ViewData["Message"] = "Description of this trail";
            ViewBag.dog = trailFactory.FindByID(id);
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
