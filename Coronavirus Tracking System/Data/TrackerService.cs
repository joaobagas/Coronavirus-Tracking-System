using Coronavirus_Tracking_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Coronavirus_Tracking_System.Data
{
    public static class TrackerService
    {
        public static async Task<StatisticsList> getInformation()
        {
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync("/summary"))
            {
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsAsync<StatisticsList>();
                }
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
