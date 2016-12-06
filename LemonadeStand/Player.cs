using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        Wallet wallet = new Wallet();
        Inventory inventory = new Inventory();
        string name;

        public void showMoney()
        {
            Console.WriteLine(wallet.startUpMoney);
        }
        public void GetLemons()
        {
            Console.WriteLine("Lemons are 10 cents each.\n\n");
            Console.WriteLine("How many lemons would you like?\n\n");
            double lemonPurchase = double.Parse(Console.ReadLine());

            //this.lemons += lemonPurchase;
            //this.pullMoneyOut -= lemonPurchase * 0.10;
        }
        public void GetIce()
        {
            Console.WriteLine("Ice Cubes are 5 cents each.\n\n");
            Console.WriteLine("How many ice cubes would you like?\n\n");
            double icePurchase = double.Parse(Console.ReadLine());
            //this.ice += icePurchase;
            //this.money -= icePurchase * 0.05;
            //Restock();
        }
        public void GetSugar()
        {
            Console.WriteLine("Each cup of sugar is .50 cents each.\n\n");
            Console.WriteLine("How many cups of sugar would you like?\n\n");
            double sugarPurchase = double.Parse(Console.ReadLine());
            //this.sugar += sugarPurchase;
            //this.money -= sugarPurchase * 0.50;
            //Restock();
        }
        public void GetCups()
        {
            Console.WriteLine("Each cup is .05 cents each.\n\n");
            Console.WriteLine("How many cups would you like?\n\n");
            //this.cups += cupsPurchase;
            //this.money -= cupsPurchase * 0.05;
            //Restock();
        }

    }
}

