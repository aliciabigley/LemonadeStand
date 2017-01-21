using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Recipe
    {
        public int numberOfPitchers;
        public int removeLemonsFromInventory;
        public int removeSugarFromInventory;
        public int removeIceFromInventory;
        public int removeCupFromInventory;
        int lemonsForRecipe = 6;
        int sugarForRecipe = 7;
        int iceForRecipe = 25;
        public int cupsForRecipe = 10;
        public void ChooseRecipe()
        {
            Console.WriteLine("\n\nWe have the perfect recipe passed down from your great, great, great Grandma Rosie!\n\n");
            Console.WriteLine("It contains 6 Lemons, 7 cups of sugar, 25 ice cubes making 10 cups of lemonade.\n\n");
            Console.WriteLine("Would you like to use great, great, great Grandma Rosie's recipe? [Y] or [N]");
            string userinput = Console.ReadLine().ToUpper();
            switch (userinput)
            {
                case "Y":
                    ChooseNumberOfPitchers();
                    break;
                case "N":
                    MakeCustomRecipeLemons();
                    MakeCustomRecipeSugar();
                    MakeCustomRecipeIce();
                    DisplayCustomRecipe();
                    ChooseNumberOfPitchers();
                    break;

                default:
                    Console.WriteLine("Sorry, that is not an option.");
                    break;
            }
        }
        public int ChooseNumberOfPitchers()
        {

            Console.WriteLine("Things to keep in mind:");
            Console.WriteLine("1. The weather (the hotter it is the more cups you may sell)");
            Console.WriteLine("2. You can not save unused lemonade you did not sell the previous day.\n\n");
            Console.WriteLine("How many pitchers do you want to make?");
            int numberOfPitchers = int.Parse(Console.ReadLine());
            Console.WriteLine("You now have {0} cups of lemonade!!", (numberOfPitchers * cupsForRecipe));
            this.numberOfPitchers = numberOfPitchers;
            return this.numberOfPitchers;
        }

        public int MakeCustomRecipeLemons()
        {
            Console.WriteLine("Let's create your custom recipe:");
            Console.WriteLine("How many lemons would you like to add?");
            int lemonsForRecipe = int.Parse(Console.ReadLine());
            return this.lemonsForRecipe = lemonsForRecipe;
        }
        public int MakeCustomRecipeSugar()
        {
            Console.WriteLine("How much sugar would you like to add?");
            int sugarForRecipe = int.Parse(Console.ReadLine());
            return this.sugarForRecipe = sugarForRecipe;
        }
        public int MakeCustomRecipeIce()
        {
            Console.WriteLine("How much Ice would you like to add?");
            int iceForRecipe = int.Parse(Console.ReadLine());
            return this.iceForRecipe = iceForRecipe;
        }
        public void DisplayCustomRecipe()
        {
            Console.WriteLine("Your recipe consists of {0} lemons, {1} cups of sugar, {2} cubes of ice which makes {3} cups of lemonade!", lemonsForRecipe, sugarForRecipe, iceForRecipe, cupsForRecipe);
        }
        public int TakeLemonsOut()  //fix: do not allow negative numbers.
        {
            removeLemonsFromInventory = numberOfPitchers * lemonsForRecipe;
            
            return removeLemonsFromInventory;
        }
        public int TakeSugarOut()
        {
            removeSugarFromInventory = numberOfPitchers * sugarForRecipe;
            return removeSugarFromInventory;
        }
        public int TakeIceOut()
        {
            removeIceFromInventory = numberOfPitchers * iceForRecipe;
            return removeIceFromInventory;
        }
        public int TakeCupsOut()
        {
            removeCupFromInventory = numberOfPitchers * cupsForRecipe;
            return removeCupFromInventory;
        }
        //public void PlayRecipe()
        //{
        //    ChooseRecipe();
        //    TakeLemonsOut();
        //    TakeSugarOut();
        //    TakeIceOut();
        //    TakeCupOut();
        //}
    }
}
