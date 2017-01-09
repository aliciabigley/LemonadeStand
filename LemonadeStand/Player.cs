using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        public Wallet wallet = new Wallet();
        public Inventory inventory = new Inventory();
        public Recipe recipe = new Recipe();
        public double PriceOfCup()
        {
            Console.WriteLine("What would you like to set the price for 1 cup of lemonade?");
            double pricePerCup = double.Parse(Console.ReadLine());
            return pricePerCup;

        }
    }
    
}

