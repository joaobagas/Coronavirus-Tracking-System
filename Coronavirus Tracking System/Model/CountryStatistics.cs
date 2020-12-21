using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coronavirus_Tracking_System.Model
{
    public class CountryStatistics : Statistics
    {
        public string Country { get; set; }
        public string CountryCode { get; set; }
        public string Slug { get; set; }
        public DateTime Date { get; set; }

        public CountryStatistics(string Country, string CountryCode, string Slug,
            int NewConfirmed, int TotalConfirmed, int NewDeaths, int TotalDeaths, int NewRecovered, int TotalRecovered, DateTime Date)
        {
            this.Country = Country; 
            this.CountryCode = CountryCode;
            this.Slug = Slug;
            this.Date = Date;

            this.NewConfirmed = NewConfirmed;
            this.TotalConfirmed = TotalConfirmed;
            this.NewDeaths = NewDeaths;
            this.TotalDeaths = TotalDeaths;
            this.NewRecovered = NewRecovered;
            this.TotalRecovered = TotalRecovered;
        }
    }
}
