using ApplicationService.Implementations;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Website.ViewModel;

namespace Website.Utils
{
    public class LoadDataUtil
    {
        private static readonly Uri url = new Uri("https://localhost:44379/api/location/");
        //public static async Task<SelectList> LoadLocationDataAsync()
        //{
        //    using (var client = new HttpClient())
        //    {
        //        client.BaseAddress = url;
        //        client.DefaultRequestHeaders.Accept.Clear();
        //        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        //        // Add the Authorization header with the AccessToken.  + accessToken
        //        client.DefaultRequestHeaders.Add("Authorization", "Bearer ");

        //        // make the request
        //        HttpResponseMessage response = await client.GetAsync("");

        //        // parse the response and return the data.
        //        string jsonString = await response.Content.ReadAsStringAsync();
        //        var responseData = JsonConvert.DeserializeObject<List<LocationVM>>(jsonString);
        //        return new SelectList(responseData, "Id", "Name");
        //    }


        //}

        private static readonly Uri url2 = new Uri("https://localhost:44379/api/film/");

        public static SelectList LoadLocationData()
        {
            var client = new WebClient();
            var body = "";
            
            body = client.DownloadString(url);
            var responseData = JsonConvert.DeserializeObject<List<LocationVM>>(body);
            return new SelectList(responseData, "IdL", "Name");
          }

        public static SelectList LoadFilmData()
        {
            var client = new WebClient();
            var body = "";

            body = client.DownloadString(url2);
            var responseData = JsonConvert.DeserializeObject<List<FilmVM>>(body);
            return new SelectList(responseData, "idF", "Title");

            //using (FilmReference.FilmClient service = new FilmReference.FilmClient())
            //{

            //    return new SelectList(service.GetFilms(), "idF", "Title");
            //}
        }

    }
}