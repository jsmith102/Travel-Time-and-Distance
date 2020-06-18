using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace Travel_Time_and_Distance.Business.Locations.Service
{
    public class ApiClientHelper
    {
        public void InitializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.BaseAddress = new Uri("test for starters");  //leave blank
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));



            //Task<HttpResponse<ServiceDistanceModel>> response = Unirest.Get("https://distanceto.p.rapidapi.com/get?car=false&foot=false&route=%255B%257B%2522t%2522%253A%2522Birmingham%2522%257D%252C%257B%2522t%2522%253A%2522London%2522%257D%255D")
            //.Header("X-RapidAPI-Host", "distanceto.p.rapidapi.com")
            //.Header("X-RapidAPI-Key", "7fa532fb6bmsh4c99b4a0bf900f0p17aa8bjsna574213c087e")
            //.();


            //var client = new RestClient("https://distanceto.p.rapidapi.com/get?car=false&foot=false");
            //var request = new RestRequest(Method.GET);
            //request.AddHeader("x-rapidapi-host", "distanceto.p.rapidapi.com");
            //request.AddHeader("x-rapidapi-key", "7fa532fb6bmsh4c99b4a0bf900f0p17aa8bjsna574213c087e");
            //IRestResponse response = client.Execute(request);

        }

        public HttpClient ApiClient { get; set; }
    }
}
