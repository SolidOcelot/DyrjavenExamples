using System;
using System.Collections.Generic;

namespace Temperature
{
    static class DayManager
    {
        public static List<Day> Days = new List<Day>();

        private static double GetAverageTemperatureValue()
        {
            double maxTemperature = 0;
            foreach (Day day in Days)
            {
                maxTemperature += day.Temperature;
            }
            return maxTemperature / Days.Count;
        }

        public static void AverageTemperatureInfo()
        {
            int countOfDaysWithMaxTemperature = 0;

            foreach (Day day in Days)
            {
                if (day.Temperature > GetAverageTemperatureValue())
                {
                    countOfDaysWithMaxTemperature++;
                }
            }

            Console.WriteLine($"The average temperature is {GetAverageTemperatureValue()}. " +
                $"There have been {countOfDaysWithMaxTemperature} days hotter than that.");
        }
    }
}
