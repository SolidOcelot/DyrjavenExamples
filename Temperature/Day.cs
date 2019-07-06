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
