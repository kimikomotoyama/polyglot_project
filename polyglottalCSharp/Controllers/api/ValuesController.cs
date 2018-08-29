//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;

//// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

//namespace polyglottalCSharp.Controllers.api
//{
//    [Route("api/[controller]")]
//    public class ValuesController : Controller
//    {
//        // GET: api/values
//        [HttpGet]
//        public IEnumerable<string> Get([FromBody]string value1, [FromBody]string value2)
//        {
//            Console.WriteLine($"value1: {value1}, value2: {value2}");
//            return new string[] { value1, value2 };
//        }

//        // GET api/values/5
//        [HttpGet("{id}")]
//        public string Get(int id)
//        {
//            return "value";
//        }

//        // POST api/values
//        [HttpPost]
//        public string Post([FromBody]string name, [FromQuery]string gender)
//        {
//            Console.WriteLine("Post!");
//            Console.WriteLine($"name: {name}");
//            return name;
//        }

//        // PUT api/values/5
//        [HttpPut("{id}")]
//        public void Put(int id, [FromBody]string value)
//        {
//        }

//        // DELETE api/values/5
//        [HttpDelete("{id}")]
//        public void Delete(int id)
//        {
//        }
//    }
//}
