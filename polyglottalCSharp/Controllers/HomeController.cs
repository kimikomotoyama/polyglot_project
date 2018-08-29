﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using polyglottalCSharp.Models;
using System.Text.Encodings.Web;

namespace polyglottalCSharp.Controllers
{
    public class HomeController : Controller
    {

        [Route("")]
        // Example GET query: http://localhost:xxxx/HelloWorld/Welcome?name=Rick&numtimes=4&gender=female
        public IActionResult Index(string name, string gender = "male")
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["Gender"] = gender.ToLower();
            ViewData["Compliments"] = new Compliment().GetCompliment(gender.ToLower());

            return View();
        }

        [Route("/About")]
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        [Route("/Contact")]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        [Route("Privacy")]
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
