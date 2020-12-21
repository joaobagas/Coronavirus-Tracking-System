using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Coronavirus_Tracking_System.Data
{
    /// <summary>
    /// This class is used to create and allow an HTTP client to be called when needed.
    /// </summary>
    public static class ApiHelper
    {
        public static HttpClient ApiClient { get; set; }

        /// <summary>
        /// This method initialises the HTTP client if it has not been initialised before and returns it.
        /// </summary>
        public static void InitializeClient()
        {
            ApiClient = new HttpClient();
            ApiClient.BaseAddress = new Uri("https://api.covid19api.com");
            ApiClient.DefaultRequestHeaders.Accept.Clear();
            ApiClient.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("aplication/json"));
        }
    }
}