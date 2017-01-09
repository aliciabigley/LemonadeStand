using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        public int temperature;
        public string condition;
        Random random;
        //string dailyWeather;
        int[] TemperatureOfWeather = new int[] { 60, 70, 80, 90, 100 };
        public string[] ConditionOfWeather = new string[] { "sunny", "cloudy", "partly cloudy", "rainy", "foggy" };
        public Weather(Random random)
        {
            this.random = random;
        }
        public void TempWeeklyWeather()
        {
            int DailyTemperature = random.Next(0, TemperatureOfWeather.Length);
            temperature = TemperatureOfWeather[DailyTemperature];
        }
        public void ConditionWeeklyWeather()
        {
            int WeatherCondition = random.Next(0, ConditionOfWeather.Length);
            condition = (ConditionOfWeather[WeatherCondition]);
        }
        public void DailyWeather()
        {
            Console.WriteLine("Today's weather is: {0} {1}", temperature, condition);
        }
        public void WeeklyWeather()
        {
            Console.WriteLine("The weekly weather is:");
            List<string> daysOfWeek = new List<string> { "Monday's", "Tuesday's", "Wednesday's", "Thursday's", "Friday's", "Saturday's", "Sunday's" };
            foreach (string day in daysOfWeek)
            {
                TempWeeklyWeather();
                ConditionWeeklyWeather();
                Console.WriteLine(day + " weather is: {0} and {1}\n\n", temperature, condition);
                
            }
            return;
            Console.WriteLine("Remember the weather has a lot to do with amount of lemonade you sell.\n\n");
        }
    }
}
