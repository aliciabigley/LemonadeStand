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
            Console.WriteLine("You currently have {0} lemons.\n\n", lemons.Count);
        }
        //public void DoubleCheckLemonInventory(Player player, int checkToSeeLemonCount,)
        //{
        //    Console.WriteLine("You have { 0} lemons.", lemons.Count);
        //    if (int i = 6; (i * recipe.ChooseNumberOfPitchers >= AddLemons)
        //    {

        //    }

        //}

        //public void DoubleCheckLemonInventory(Player player, int numberLemons, ChooseNumberOfPitchers)
        //{
        //    for (int i = 6; (i * ChooseNumberOfPitchers >= AddLemons)
        //    {
        //        Console.WriteLine("You have enough Lemons");
        //    }
        //}
        public void RemoveLemons(int TakeLemonsOut)
        {
            for (int i = 0; i < TakeLemonsOut; i++)
            {
                lemons.RemoveAt(0);
            }
        }
        public void AddSugar(int NumberOfSugarNeeded)
        {
            for (int i = 0; i < NumberOfSugarNeeded; i++)
            {
                Sugar sugar = new Sugar();
                this.sugar.Add(sugar);
            }
            Console.WriteLine("You just bought {0} cups of Sugar.\n\n", sugar.Count);
        }
        public void RemoveSugar(int TakeSugarOut)
        {
            for (int i = 0; i < TakeSugarOut; i++)
            {
                sugar.RemoveAt(0);
            }
        }
        public void AddIce(int NumberOfIceCubesNeeded)
        {
            for (int i = 0; i < NumberOfIceCubesNeeded; i++)
            {
                Ice ice = new Ice();
               this. ice.Add(ice);
            }
            Console.WriteLine("You currently have {0} ice cubes.\n\n", ice.Count);
        }
        public void RemoveIce(int TakeIceOut)
        {
            for (int i = 0; i < TakeIceOut; i++)
            {
                ice.RemoveAt(0);
            }
        }
        public void AddCups(int NumberOfCupsNeeded)
        {
            for (int i = 0; i < NumberOfCupsNeeded; i++)
            {
                Cup cup = new Cup();
                cups.Add(cup);
            }
            Console.WriteLine("You currently have {0} cups.\n\n", cups.Count);
        }
        public void RemoveCup(int TakeCupOut) 
        {
            for (int i = 0; i < TakeCupOut; i++)
            {
                cups.RemoveAt(0);
            }
        }

        public void ShowAllProductInventory()
        {
            Console.WriteLine("You currently have {0} lemons.\n\n", lemons.Count);
            Console.WriteLine("You currently have {0} cups of sugar.\n\n", sugar.Count);
            Console.WriteLine("You currently have {0} ice cubes.\n\n", ice.Count);
            Console.WriteLine("You currently have {0} cups.\n\n", cups.Count);
           
        }
    }
}
