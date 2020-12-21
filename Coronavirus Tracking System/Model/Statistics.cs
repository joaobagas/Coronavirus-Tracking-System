using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coronavirus_Tracking_System.Model
{
    public class Statistics
    {
        public int NewConfirmed { get; set; }
        public int TotalConfirmed { get; set; }
        public int NewDeaths { get; set; }
        public int TotalDeaths { get; set; }
        public int NewRecovered { get; set; }
        public int TotalRecovered { get; set; }

        public Statistics() {}

        public Statistics(int NewConfirmed, int TotalConfirmed, int NewDeaths, int TotalDeaths, int NewRecovered, int TotalRecovered)
        {
            this.NewConfirmed = NewConfirmed;
            this.TotalConfirmed = TotalConfirmed;
            this.NewDeaths = NewDeaths;
            this.TotalDeaths = TotalDeaths;
            this.NewRecovered = NewRecovered;
            this.TotalRecovered = TotalRecovered;
        }
    }
}
