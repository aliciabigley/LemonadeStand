using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Weather
    {
        int temperature;
        string condition;
        Random random;
        //string dailyWeather;
        int[] TemperatureOfWeather = new int[] { 60, 70, 80, 90, 100 };
        string[] ConditionOfWeather = new string[] {"and sunny", "and cloudy", "and partly cloudy", "and rainy", "and foggy"};
        public Weather(Random random)
        {
            this.random = random;
        }
        public void TempWeeklyWeather()
        {
            //Random random = new Random();
            int DailyTemperature = random.Next(0, TemperatureOfWeather.Length);
            temperature = TemperatureOfWeather[DailyTemperature];
        }
        public void ConditionWeeklyWeather()
        {
            //Random random = new Random();
            int WeatherCondition = random.Next(0, ConditionOfWeather.Length);
            condition = (ConditionOfWeather[WeatherCondition]);
        }
        public void DailyWeather()
        {
            Console.WriteLine("Today's weather is: {0} {1}",temperature ,condition);
        }
        public void WeeklyWeather()
        {
            List<string> daysOfWeek = new List<string> { "Monday's", "Tuesday's", "Wednesday's", "Thursday's", "Friday's", "Saturday's", "Sunday's" };

            foreach (string day in daysOfWeek)
            {
                TempWeeklyWeather();
                ConditionWeeklyWeather();
                Console.WriteLine(day + " weather is: {0} {1}", temperature, condition);
            }
            
        }
    }
}
