using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Movies_API_DJM.Models
{
    public class MovieSearch
    {
        public List<string> Title { get; set; } = new List<string>();

        public MovieSearch()
        {

        }

        public MovieSearch(JToken token)
        {
            foreach (var item in token["Search"])
            {
                Title.Add(item["Title"].ToString());
            }
        }
    }
}
