using App.Dtos;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    public class TmdbWrapper
    {
        private string _apiKey;
        private string _language;
        private readonly HttpClient _client;

        public TmdbWrapper(string apikey, string languague)
        {
            _apiKey = apikey;
            _language = languague;
            _client = new();
        }

        public async Task<GenericTmdbResponse?> getMovie(string tittle)
        {
            try
            {
                string data = new WebClient().DownloadString($"https://api.themoviedb.org/3/search/movie?api_key={_apiKey}&language={_language}&query={tittle}&include_adult=true");
                return JsonConvert.DeserializeObject<GenericTmdbResponse>(data);
            }catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }

        }

        public async Task<GenericTmdbResponse?> getTV(string tittle)
        {
            string data = new WebClient().DownloadString($"https://api.themoviedb.org/3/search/tv?api_key={_apiKey}&language={_language}&query={tittle}&include_adult=true");
            var result = JsonConvert.DeserializeObject<GenericTmdbResponse>(data);
            return result;
        }
    }
}
