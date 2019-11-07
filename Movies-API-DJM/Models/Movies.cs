using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movies_API_DJM.Models
{
    public class Movies
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public string Plot { get; set; }
        public string Rated { get; set; }

        public Movies()
        {

        }

        public Movies(JToken token)
        {
            this.Title = token["Title"].ToString();
            this.Year = int.Parse(token["Year"].ToString());
            this.Plot = token["Plot"].ToString();
            this.Rated = token["Rated"].ToString();
        }
    }
}
