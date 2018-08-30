using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using polyglottalCSharp.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace polyglottalCSharp.Controllers.api
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // GET: api/values
        [HttpGet]
        public async Task<string> Get([FromQuery]string name, [FromQuery]string gender)
        {

            //var list = new Compliment().GetCompliment(gender.ToLower());
            //string json = JsonConvert.SerializeObject(list);
            //return json;
            var complimentObj = new Compliment();
            await complimentObj.GetComplimentFromAPI();
            return complimentObj.ComplimentProp;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public string Post([FromQuery]string name, [FromQuery]string gender)
        {
            Console.WriteLine("Post!");
            Console.WriteLine($"name: {name}");
            return name;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

