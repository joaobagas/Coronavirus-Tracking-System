using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coronavirus_Tracking_System.Model
{
    public class StatisticsList
    {
        public Statistics Global { get; set; }
        public List<CountryStatistics> Countries { get; set; }
        public DateTime Date { get; set; }

        public StatisticsList() {}

        public StatisticsList(Statistics Global, List<CountryStatistics> Countries, DateTime Date) 
        {
            this.Global = Global;
            this.Countries = Countries;
            this.Date = Date;
        }
    }
}
