using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        List<Lemon> lemons = new List<Lemon>();
        List<Sugar> sugar = new List<Sugar>();
        List<Ice> ice = new List<Ice>();
        List<Cup> cups = new List<Cup>();
        public void lemonList(Player store, double amount)
        {
            for(double i = 0; i < amount; i++)
            {
                Lemon lemon = new Lemon();
                lemons.Add(lemon);
            }
        }
        //public void getSugarCount()
        //{
        //    List<int> sugar = new List<int>();
        //}
        //public void getIceCount()
        //{
        //    List<int> ice = new List<int>();
        //}
        //public void getCupCount()
        //{
        //    List<int> cup = new List<int>();
        //}
        public void getInventoryStatus()
        {
            Console.WriteLine("You have the following in inventory:\n\n");
            Console.WriteLine("Lemons {0}\n\n",lemons);
            Console.WriteLine("Cups of Sugar {0}\n\n",sugar);
            Console.WriteLine("Ice Cubes {0}",ice);
            Console.WriteLine("Cups {0}",cups);
        

        }
    }
}
