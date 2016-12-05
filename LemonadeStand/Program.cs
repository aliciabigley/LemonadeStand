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
            //Weather weather = new Weather();
            Game game = new LemonadeStand.Game();


            game.weather.WeeklyWeather();
            game.weather.DailyWeather();
            game.store.Restock();


            //Game game = new Game();
            //game.RunGame();
            Console.ReadKey();

        }
    }
}
