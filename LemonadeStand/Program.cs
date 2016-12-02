using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Weather weather = new Weather();
            weather.WeeklyWeather();
            //Game game = new Game();
            //game.RunGame();
            Console.ReadKey();

        }
    }
}
