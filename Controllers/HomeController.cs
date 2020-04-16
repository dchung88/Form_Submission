using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Form_Submission.Models;

namespace Form_Submission.Controllers
{
    public class HomeController : Controller
    {

        [Route("/")]
        [HttpGet]
        public IActionResult Index()
        {
            return View("Index");
        }

        [Route("success")]
        [HttpPost]
        public IActionResult Create(User user)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Success");
            }
            else
            {
                return View("Index");
            }
        }

        [Route("success")]
        [HttpGet]
        public IActionResult Success()
        {
            return View("Success");
        }

    }
}
