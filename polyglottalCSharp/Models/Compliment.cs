using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace polyglottalCSharp.Models
{
    public class Compliment
    {


        public string ComplimentProp { get; set; }

        public List<string> GetCompliment(string gender)
        {

            //var complimentData = new Compliment();
            //complimentData.getComplimentFromAPI();

            var list = new List<string>();
            if (gender == "male")
            {
                list = new List<string>() {
                    "You are so handsome!",
                    "You are so smart!"
                };
            }
            else
            {
                list = new List<string>() {
                    "You are so cute!",
                    "You are so smart!"
                };
            }
            return list;
        }

        public async Task GetComplimentFromAPI() {
            string baseUrl = "https://complimentr.com/api";

            //Create a new instance of HttpClient
            using (HttpClient client = new HttpClient())
            using (HttpResponseMessage res = await client.GetAsync(baseUrl))
            using (HttpContent content = res.Content)
            {
                ComplimentProp = await content.ReadAsStringAsync();
            }

        }
    }
}
