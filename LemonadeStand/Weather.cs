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
        public int[] TemperatureOfWeather = new int[] { 60, 70, 80, 90, 100 };
        public string[] ConditionOfWeather = new string[] { "sunny", "cloudy", "partly cloudy", "rainy", "foggy" };
        public Weather(Random random)
        {
            this.random = random;
        }
        public void TempWeather()
        {
            int DailyTemperature = random.Next(0, TemperatureOfWeather.Length);
            temperature = TemperatureOfWeather[DailyTemperature];
        }
        public void ConditionWeather()
        {
            int WeatherCondition = random.Next(0, ConditionOfWeather.Length);
            condition = (ConditionOfWeather[WeatherCondition]);
        }
        //public void DailyWeather()
        //{
        //    Console.WriteLine("Today's weather is: {0} {1}", temperature, condition);
        //}
        public void CreateWeather()
        {
            //Console.WriteLine("The weekly weather is:");
            List<string> weatherForcase = new List<string> {"Today","Tomorrow's " };
            foreach (string day in weatherForcase)
            {
                TempWeather();
                ConditionWeather();
                Console.WriteLine(day + " weather is: {0} {1}  \n\n", temperature, condition);
            }
           
        }
        public void DisplayWeather()
        {
            Console.WriteLine("Today's weather is: {0} {1}\n\n", temperature, condition);
           
        }
    }
}
