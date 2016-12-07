using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Inventory
    {
        List<Lemon> lemons = new List<Lemon>();
        List<Sugar> sugar = new List<Sugar>();
        List<Ice> ice = new List<Ice>();
        List<Cup> cups = new List<Cup>();
        //public void getInventoryStatus(Player store)
        //{
        //    Console.WriteLine("You have the following in inventory:\n\n");
        //    Console.WriteLine("Lemons {0}\n\n",lemons);
        //    Console.WriteLine("Cups of Sugar {0}\n\n",sugar);
        //    Console.WriteLine("Ice Cubes {0}",ice);
        //    Console.WriteLine("Cups {0}",cups);
        //}
        public void AddLemons(int NumberOfLemonsNeeded)
        {
            for (int i = 0; i < NumberOfLemonsNeeded; i++)
            {
                Lemon lemon = new Lemon();
                lemons.Add(lemon);
            }
            Console.WriteLine("You currently have {0} lemons", lemons.Count);
        }
    }
}
