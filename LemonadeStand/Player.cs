using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        double checkOutLemons;
        double checkOutIceCubes;
        double checkOutSugar;
        double checkOutCups;
        public Wallet wallet = new Wallet();
        Inventory inventory = new Inventory();
        public double setNumberOfIceCubes()
        {
            Console.WriteLine("Ice Cubes are .05 cents each.\n\n");
            Console.WriteLine("How many ice cubes would you like?\n\n");
            double iceNeeded = double.Parse(Console.ReadLine());
            return iceNeeded;
        }

        public double displayIceCubesPurchased()
        {
            Ice ice = new Ice();
            checkOutIceCubes = ice.getIceCost() * setNumberOfIceCubes();
            return checkOutIceCubes;
        }
        public double setNumberOfSugar()
        {
            Console.WriteLine("Each cup of sugar is .50 cents each.\n\n");
            Console.WriteLine("How many cups of sugar would you like?\n\n");
            double sugarNeeded = double.Parse(Console.ReadLine());
            return sugarNeeded;
        }
        public double displaySugarPurchased()
        {
            Sugar sugar = new Sugar();
            checkOutSugar = sugar.getSugarCost() * setNumberOfSugar();
            return checkOutSugar;
        }

        public double setNumberOfCups()
        {
            Console.WriteLine("Each cup is .05 cents each.\n\n");
            Console.WriteLine("How many cups would you like?\n\n");
            double cupsNeeded = double.Parse(Console.ReadLine());
            return cupsNeeded;
        }
        public double displayCupsPurchased()
        {
            Cup cup = new Cup();
            checkOutCups = cup.getCupCost() * setNumberOfCups();
            return checkOutCups;
        }

        //public void setCheckOut()
        //{
        //    displayLemonsPurchased();
        //    displaySugarPurchased();
        //    displayIceCubesPurchased();
        //    displayCupsPurchased();
        //}
        //public double getCheckOut()
        //{
        //    return displayLemonsPurchased();
       
        //}







        //this.cups += cupsPurchase;
        //this.money -= cupsPurchase * 0.05;
        //Restock();
        //lemon.getLemonCost += lemonPurchase
        ////this.lemons += lemonPurchase;
        //    ////this.pullMoneyOut -= lemonPurchase * 0.10;
        //    if (wallet.startUpMoney - (lemon.getLemonCost() * lemonPurchase) >= 0)
        //    {
        //        Console.WriteLine("Sorry, you don't have enough money in your wallet.");
        //    }
        //    else (lemon.getLemonCost() * lemonPurchase() - wallet.displayAmountInWallet = )
        //    {

        //        Console.WriteLine("Awesome! You just bought {0} lemons.\n\n", lemonPurchase);
        //    }
        //}

    }

}

