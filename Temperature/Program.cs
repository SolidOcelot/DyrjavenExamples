using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Day d1 = new Day(18);
            Day d2 = new Day(16);
            Day d3 = new Day(19);
            Day d4 = new Day(22);
            Day d5 = new Day(21);
            Day d6 = new Day(22);
            Day d7 = new Day(15);
            Day d8 = new Day(22);
            Day d9 = new Day(14);
            Day d10 = new Day(13);

            DayManager.AverageTemperatureInfo();
        }
    }
}
