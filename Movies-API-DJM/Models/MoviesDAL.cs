using Newtonsoft.Json.Linq;
using System.IO;
using System.Net;

namespace Movies_API_DJM.Models
{
    public class MoviesDAL
    {
        public static string BaseURL = "http://www.omdbapi.com/";
        public static string TitleSearch = "?t=";
        public static string Search = "?s=";
        public static string key = "&apikey=7f72b12d";

        public static Movies FindTitleAPI(string searchText)
        {
            HttpWebRequest request = WebRequest.CreateHttp($"{BaseURL}{TitleSearch}{searchText}{key}");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader rd = new StreamReader(response.GetResponseStream());

            string APIText = rd.ReadToEnd();

            JToken token = JToken.Parse(APIText);

            Movies MyMovie = new Movies(token);

            return MyMovie;
        }

        public static MovieSearch SearchMoviesAPI(string searchText)
        {
            HttpWebRequest request = WebRequest.CreateHttp($"{BaseURL}{Search}{searchText}{key}");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader rd = new StreamReader(response.GetResponseStream());

            string APIText = rd.ReadToEnd();

            JToken token = JToken.Parse(APIText);

            MovieSearch MyMovie = new MovieSearch(token);

            return MyMovie;
        }
        public static JToken ParseJsonString(string text)
        {
            JToken output = JToken.Parse(text);
            return output;
        }
    }
}

