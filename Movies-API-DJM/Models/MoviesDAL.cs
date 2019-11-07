using Newtonsoft.Json.Linq;
using System.IO;
using System.Net;

namespace Movies_API_DJM.Models
{
    public class MoviesDAL
    {
        public string BaseURL = "http://www.omdbapi.com/";
        public string TitleSearch = "?s=";
        public string key = "&apikey=7f72b12d";

        public string CallMoviesAPI(string searchText)
        {
            HttpWebRequest request = WebRequest.CreateHttp($"{BaseURL}{TitleSearch}{searchText}{key}");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader rd = new StreamReader(response.GetResponseStream());

            string APIText = rd.ReadToEnd();

            return APIText;
        }

        public JToken ParseJsonString(string text)
        {
            JToken output = JToken.Parse(text);
            return output;
        }
    }
}
