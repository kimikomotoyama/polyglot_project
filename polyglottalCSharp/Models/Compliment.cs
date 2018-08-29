using System;
using System.Collections.Generic;

namespace polyglottalCSharp.Models
{
    public class Compliment
    {
        public List<string> GetCompliment(string gender)
        {

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
    }
}
