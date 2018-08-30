using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using polyglottalCSharp.Models;
using System.Text.Encodings.Web;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace polyglottalCSharp.Controllers
{
    public class HomeController : Controller
    {

        [Route("")]
        // Example GET query: http://localhost:xxxx/HelloWorld/Welcome?name=Rick&numtimes=4&gender=female
        public async Task<IActionResult> Index(string name, string gender = "male")
        {
            var complimentObj = new Compliment();

            ViewData["Message"] = "Hello " + name;
            ViewData["Gender"] = gender.ToLower();
            ViewData["Compliments"] = complimentObj.GetCompliment(gender.ToLower());
            await complimentObj.GetComplimentFromAPI();
    
            var compliment = JsonConvert.DeserializeObject<JObject>(complimentObj.ComplimentProp);
            Console.WriteLine($"compliment: {compliment["compliment"]}");
            ViewData["ComplimentFromAPI"] = compliment["compliment"];

            return View();
        }

        [Route("/About")]
        public IActionResult About()
        {
            ViewData["Message"] = "Application description";

            return View();
        }

        [Route("/Contact")]
        public IActionResult Contact()
        {
            ViewData["Message"] = "Contact";

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
