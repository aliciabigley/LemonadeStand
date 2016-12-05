﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Store
    {
        //member variables
        private double lemons;
        private double ice;
        private double sugar;
        private double cups;
        private double money;



        //Constructor
        public Store(double investment)
        {
            this.money = investment;
        }

        //Methods
        public void Restock()
        {
            Console.WriteLine("\n\nDo you need anything from the store?\n\n");
            Console.WriteLine("[Yes] or [No]");
            string checkToSeeStore = Console.ReadLine().ToLower();
            if (checkToSeeStore == "no")
            {
                //play game
            }

            else if (checkToSeeStore == "yes")
            {
                Console.WriteLine("What's on your list? [Lemons] [Sugar] [Ice] or [Cups]?\n\n");
                string need = Console.ReadLine().ToLower();
                //case?
                if (need == "lemons")
                {
                    Console.WriteLine("Lemons are 10 cents each.\n\n");
                    Console.WriteLine("How many lemons would you like?\n\n");
                    double lemonPurchase = double.Parse(Console.ReadLine());
                    this.lemons += lemonPurchase;
                    this.money -= lemonPurchase * 0.10;
                    Restock();

                }
                else if (need == "ice")
                {
                    Console.WriteLine("Ice Cubes are 5 cents each.\n\n");
                    Console.WriteLine("How many ice cubes would you like?\n\n");
                    double icePurchase = double.Parse(Console.ReadLine());
                    this.ice += icePurchase;
                    this.money -= icePurchase * 0.05;
                    Restock();
                }
                else if (need == "sugar")
                {
                    Console.WriteLine("Each cup of sugar is .50 cents each.\n\n");
                    Console.WriteLine("How many cups of sugar would you like?\n\n");
                    double sugarPurchase = double.Parse(Console.ReadLine());
                    this.sugar += sugarPurchase;
                    this.money -= sugarPurchase * 0.50;
                    Restock();
                }
                else if (need == "cups")
                {
                    Console.WriteLine("Cups are 5 cents each.");
                    Console.WriteLine("How many cups would you like?");
                    double cupsPurchase = double.Parse(Console.ReadLine());
                    this.cups += cupsPurchase;
                    this.money -= cupsPurchase * 0.05;
                    Restock();
                }
                else
                {
                    Console.WriteLine("Sorry! That's not an option. Please try [Lemons] [Sugar] [Ice] or [Cups].");
                    Restock();
                }
            }
            else
                Console.WriteLine("Sorry! That's not an option. Please try [Lemons] [Sugar] [Ice] or [Cups].");
            Restock();
        }
    }
}