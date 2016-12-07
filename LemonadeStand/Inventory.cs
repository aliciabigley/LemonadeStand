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
        public void AddLemons(int NumberOfLemonsNeeded)
        {
            for (int i = 0; i < NumberOfLemonsNeeded; i++)
            {
                Lemon lemon = new Lemon();
                lemons.Add(lemon);
            }
            Console.WriteLine("You currently have {0} lemons", lemons.Count);
        }
        public void RemoveLemons(int TakeLemonsOut) //You are here.
        {

            for (int i = 0; i < TakeLemonsOut; i--);
        }
        public void AddSugar(int NumberOfSugarNeeded)
        {
            for (int i = 0; i < NumberOfSugarNeeded; i++)
            {
                Sugar sugar = new Sugar();
                this.sugar.Add(sugar);
            }
            Console.WriteLine("You currently have {0} cups of Sugar", sugar.Count);
        }
        public void AddIce(int NumberOfIceCubesNeeded)
        {
            for (int i = 0; i < NumberOfIceCubesNeeded; i++)
            {
                Ice ice = new Ice();
               this. ice.Add(ice);
            }
            Console.WriteLine("You currently have {0} ice cubes", ice.Count);
        }
        public void AddCups(int NumberOfCupsNeeded)
        {
            for (int i = 0; i < NumberOfCupsNeeded; i++)
            {
                Cup cup = new Cup();
                cups.Add(cup);
            }
            Console.WriteLine("You currently have {0} cups.", cups.Count);
        }




        
public void ShowAllProductInventory()
        {
            Console.WriteLine("You currently have {0} lemons", lemons.Count);
            Console.WriteLine("You currently have {0} cups of sugar", sugar.Count);
            Console.WriteLine("You currently have {0} ice cubes", ice.Count);
            Console.WriteLine("You currently have {0} cups.", cups.Count);
        }
    }
}
