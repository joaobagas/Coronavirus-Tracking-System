using Coronavirus_Tracking_System.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coronavirus_Tracking_System.Data
{
    public static class StatisticsLoader
    {
        public static StatisticsList StatisticsList { get; set; }

        public static async Task LoadStatisticsList()
        {
            StatisticsList = await TrackerService.getInformation();
        }
    }
}
