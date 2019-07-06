using System;

namespace Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            //Day d1 = new Day(18);
            //Day d2 = new Day(16);
            //Day d3 = new Day(19);
            //Day d4 = new Day(22);
            //Day d5 = new Day(21);
            //Day d6 = new Day(22);
            //Day d7 = new Day(15);
            //Day d8 = new Day(22);
            //Day d9 = new Day(14);
            //Day d10 = new Day(13);

            try
            {
                Console.WriteLine("Enter the number of days: ");
                int numberOfDays = int.Parse(Console.ReadLine());

                double dayTemperature;

                for (int i = 0; i < numberOfDays; i++)
                {
                    Console.WriteLine("Enter the temperature for this day:");
                    dayTemperature = double.Parse(Console.ReadLine());

                    Day day = new Day(dayTemperature);
                    Console.WriteLine("Day added.");
                }

                DayManager.AverageTemperatureInfo();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something went wrong. Try again.");
                Main(args);
            }
        }
    }
}
