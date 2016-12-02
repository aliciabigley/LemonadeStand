using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {

        int[] TemperatureOfWeather = new int[] { 60, 70, 80, 90, 100 };
        string[] ConditionOfWeather = new string[] {"and sunny", "and cloudy", "and partly cloudy", "and rainy", "and foggy"};

        public void TempWeeklyWeather()
        {
            Random random = new Random();
            int temperature = random.Next(0, TemperatureOfWeather.Length);
            Console.WriteLine(TemperatureOfWeather[temperature]);
        }
        public void ConditionWeeklyWeather()
        {
            Random random = new Random();
            string condition = random.Next(0, condition.Length);
            Console.WriteLine(ConditionOfWeather[condition]);
        }

    }
}
