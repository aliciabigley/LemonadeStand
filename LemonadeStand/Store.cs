﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        double checkOutLemons;
        double checkOutIceCubes;
        double checkOutSugar;
        double checkOutCups;
        public void Restock(Player player)
        {
            Console.WriteLine("Do you need anything from the store?\n\n");
            Console.WriteLine("[Yes] or [No]");
            string checkToSeeStore = Console.ReadLine().ToLower();
            if (checkToSeeStore == "no")
            {
                //play game
            }

            else if (checkToSeeStore == "yes")

                Console.WriteLine("What's on your list? [L] for Lemons, [S] for Sugar, [I] for Ice, or [C] for Cups?\n\n");
            string need = Console.ReadLine().ToLower();
            switch (need)
            {
                case "l":
                    getLemons();
                    break;
                case "i":
                    player.setNumberOfIceCubes();
                    break;
                case "s":
                    player.setNumberOfSugar();
                    break;
                case "c":
                    player.setNumberOfCups();
                    break;
                default:
                    Console.WriteLine("Sorry! Try [L] for Lemons, [S] for Sugar, [I] for Ice, or [C] for Cups?");
                    Restock(player);
                    break;

            }
        }
        //lemons
         public double numberOfLemonsNeeded()
        {
            Console.WriteLine("Lemons are 10 cents each.\n\n");
            Console.WriteLine("How many lemons would you like?\n\n");
            double lemonsNeeded = double.Parse(Console.ReadLine());
            return lemonsNeeded;

        }
        public double numberOfLemonsPurchased()
        {
            Lemon lemon = new Lemon();
            checkOutLemons = lemon.getLemonCost() * numberOfLemonsNeeded();
            return checkOutLemons;
        }
        public void payForLemons(Player player)
        {
            player.wallet.checkIfBankrupt(checkOutLemons);
            player.wallet.buyProduct(checkOutLemons);
        }
        public void getLemons()
        {
            numberOfLemonsNeeded();
            numberOfLemonsPurchased();
            payForLemons(Player player);
        }
    }
    //public string continueShoping (Player player)
    //{
    //    Console.WriteLine("You currently have {0} in your wallet. Would you like to buy more stuff?\n\n", (Player.wallet.GetPullMoneyOut()));
    //    Console.WriteLine("[Y] Yes or [N] No?");
    //    Console.ReadLine().ToLower();
    //}


    //    public void getProducts()

    //{
    //    if (need == "lemons")
    //    {
    //        Console.WriteLine("Lemons are 10 cents each.\n\n");
    //        Console.WriteLine("How many lemons would you like?\n\n");
    //        double lemonPurchase = double.Parse(Console.ReadLine());
    //        this.lemons += lemonPurchase;
    //        this.money -= lemonPurchase * 0.10;
    //        Restock();

    //    }
    //    else if (need == "ice")
    //    {
    //        Console.WriteLine("Ice Cubes are 5 cents each.\n\n");
    //        Console.WriteLine("How many ice cubes would you like?\n\n");
    //        double icePurchase = double.Parse(Console.ReadLine());
    //        this.ice += icePurchase;
    //        this.money -= icePurchase * 0.05;
    //        Restock();
    //    }
    //    else if (need == "sugar")
    //    {
    //        Console.WriteLine("Each cup of sugar is .50 cents each.\n\n");
    //        Console.WriteLine("How many cups of sugar would you like?\n\n");
    //        double sugarPurchase = double.Parse(Console.ReadLine());
    //        this.sugar += sugarPurchase;
    //        this.money -= sugarPurchase * 0.50;
    //        Restock();
    //    }
    //    else if (need == "cups")
    //    {
    //        Console.WriteLine("Cups are 5 cents each.");
    //        Console.WriteLine("How many cups would you like?");
    //        double cupsPurchase = double.Parse(Console.ReadLine());
    //        this.cups += cupsPurchase;
    //        this.money -= cupsPurchase * 0.05;
    //        Restock();
    //    }
    //    else
    //    {
    //        Console.WriteLine("Sorry! That's not an option. Please try [Lemons] [Sugar] [Ice] or [Cups].");
    //        Restock();
    //    }
}

