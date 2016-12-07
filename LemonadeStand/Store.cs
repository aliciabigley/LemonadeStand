using System;
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

        //double lemonNeeded;
        public void Restock(Player player)
        {
            Console.WriteLine("Do you need anything from the store?\n\n");
            Console.WriteLine("[Y] Yes or [N] No");
            string checkToSeeStore = Console.ReadLine().ToLower();
            if (checkToSeeStore == "n")
            {
                player.recipe.ChooseNumberOfPitchers();
            }

            else if (checkToSeeStore == "y")

                Console.WriteLine("What's on your list? [L] for Lemons, [S] for Sugar, [I] for Ice, or [C] for Cups?\n\n");
            string need = Console.ReadLine().ToLower();
            switch (need)
            {
                case "l":
                    GetLemons(player);
                    break;
                case "s":
                    GetSugar(player);
                    break;
                case "i":
                    GetIce(player);
                    break;
                case "c":
                    GetCups(player);
                    break;
                default:
                    Console.WriteLine("Sorry! Try [L] for Lemons, [S] for Sugar, [I] for Ice, or [C] for Cups?");
                    Restock(player);
                    break;

            }
        }
        //lemons
        public int NumberOfLemonsNeeded()
        {
            Console.WriteLine("Lemons are 10 cents each.\n\n");
            Console.WriteLine("How many lemons would you like?\n\n");
            int lemonsNeeded = int.Parse(Console.ReadLine());
            return lemonsNeeded;
        }
        
        public double NumberOfLemonsPurchased(int NumberOfLemonsToBuy)
        {
            Lemon lemon = new Lemon();
            checkOutLemons = lemon.getLemonCost() * NumberOfLemonsToBuy; 
            return checkOutLemons;
        }
        public void PayForLemons(Player player)
        {
            player.wallet.checkIfBankrupt(checkOutLemons);
            player.wallet.buyProduct(checkOutLemons);
        }

        //Calling Lemons
        public void GetLemons(Player player)
        {
            int numberOfLemons = NumberOfLemonsNeeded();
            NumberOfLemonsPurchased(numberOfLemons);
            PayForLemons(player);
            player.inventory.AddLemons(numberOfLemons);
            Restock(player);
        }

        public int NumberOfSugarNeeded()
        {
            Console.WriteLine("Each cup of sugar is .50 cents each.\n\n");
            Console.WriteLine("How many cups of sugar would you like?\n\n");
            int sugarNeeded = int.Parse(Console.ReadLine());
            return sugarNeeded;
        }

        public double NumberOfSugarPurchased(int NumberOfSugarNeeded)
        {
            Sugar sugar = new Sugar();
            checkOutSugar = sugar.getSugarCost() * NumberOfSugarNeeded;
            return checkOutSugar;
        }
        public void PayForSugar(Player player)
        {
            player.wallet.checkIfBankrupt(checkOutSugar);
            player.wallet.buyProduct(checkOutSugar);
        }
        //Calling Sugar
        public void GetSugar(Player player)
        {
            int numberOfSugar = NumberOfSugarNeeded();
            NumberOfSugarPurchased(numberOfSugar);
            PayForSugar(player);
            player.inventory.AddSugar(numberOfSugar);
            player.inventory.ShowAllProductInventory();
            Restock(player);
        }
        //ice
        public int NumberOfIceCubesNeeded()
        {
            Console.WriteLine("Ice Cubes are .05 cents each.\n\n");
            Console.WriteLine("How many ice cubes would you like?\n\n");
            int iceNeeded = int.Parse(Console.ReadLine());
            return iceNeeded;
        }


        public double NumberOfIceCubesPurchased(int NumberOfIceCubesNeeded)
        {
            Ice ice = new Ice();
            checkOutIceCubes = ice.getIceCost() * NumberOfIceCubesNeeded; 
            return checkOutIceCubes;
        }
        public void PayForIce(Player player)
        {
            player.wallet.checkIfBankrupt(checkOutIceCubes);
            player.wallet.buyProduct(checkOutIceCubes);
        }
        //Calling Ice
        public void GetIce (Player player)
        {
            int numberOfIce = NumberOfIceCubesNeeded();
            NumberOfIceCubesPurchased(numberOfIce);
            PayForIce(player);
            player.inventory.AddIce(numberOfIce);
            player.inventory.ShowAllProductInventory();
            Restock(player);
        }

        //Cups
        public int NumberOfCupsNeeded()
        {
            Console.WriteLine("Each cup is .05 cents each.\n\n");
            Console.WriteLine("How many cups would you like?\n\n");
            int cupsNeeded = int.Parse(Console.ReadLine());
            return cupsNeeded;
        }
        public double NumberOfCupsPurchased(int NumberOfCupsNeeded)
        {
            Cup cup = new Cup();
            checkOutCups = cup.getCupCost() * NumberOfCupsNeeded;
            return checkOutCups;
        }
        public void PayForCups(Player player)
        {
            player.wallet.checkIfBankrupt(checkOutCups);
            player.wallet.buyProduct(checkOutCups);
        }
        //calling Cups
        public void GetCups(Player player)
        {
            int numberOfCups = NumberOfCupsNeeded();
            NumberOfCupsPurchased(numberOfCups);
            PayForCups(player);
            player.inventory.AddCups(numberOfCups);
            player.inventory.ShowAllProductInventory();
            Restock(player);
        }

    }
}

