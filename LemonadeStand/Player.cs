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
        
    }
    public int getLemons()
    {
        Console.WriteLine("Lemons are 10 cents each.\n\n");
        Console.WriteLine("How many lemons would you like?\n\n");
        double lemonPurchase = double.Parse(Console.ReadLine());
        this.lemons += lemonPurchase;
        this.pullMoneyOut -= lemonPurchase * 0.10;
    }
}
