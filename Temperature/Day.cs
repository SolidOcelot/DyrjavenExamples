using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    class Day
    {
        public double Temperature { get; set; }

        public Day(double temperature)
        {
            this.Temperature = temperature;

            DayManager.Days.Add(this);
        }
    }
}
