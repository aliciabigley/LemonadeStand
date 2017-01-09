using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LemonadeStand; //make sure you always have using!
namespace LemonadeTest
{
    [TestClass]
    public class LemonadeStandTest
    {
        [TestMethod]
        public void MultiplyLemonsWithCost()
        {
            //arrange
            Store store = new Store();
            Lemon lemon = new Lemon();
            int lemonsToBuy = 10;
            double lemonCost = lemon.GetCost();
            double priceOfPurchasedLemons = lemonsToBuy * lemonCost;
            double result;
            //act
            result = store.NumberOfLemonsPurchased(lemonsToBuy);
            //assert
            Assert.AreEqual(priceOfPurchasedLemons, result);

        }
        [TestMethod]
        public void MultiplySugarWithCost()
        {
            //arrange
            Store store = new Store();
            Sugar sugar = new Sugar();
            int sugarToBuy = 20;
            double sugarCost = sugar.GetCost();
            double priceOfPurchasedSugar = sugarToBuy * sugarCost;
            double result;
            //act
            result = store.NumberOfSugarPurchased(sugarToBuy);
            //assert
            Assert.AreEqual(priceOfPurchasedSugar, result);
        }
        [TestMethod]
        public void multiplyIceWithCost()
        {
            //arrange
            Store store = new Store();
            Ice ice = new Ice();
            int iceToBuy = 50;
            double iceCost = ice.GetCost();
            double priceOfpurchacedIce = iceToBuy * iceCost;
            double result;
            //act
            result = store.NumberOfIceCubesPurchased(iceToBuy);
            //assert
            Assert.AreEqual(result, priceOfpurchacedIce);
        }
        [TestMethod]
        public void MultiplyCupWithCost()
        {
            //arrange
            Store store = new Store();
            Cup cups = new Cup();
            int cupsToBuy = 20;
            double cupCost = cups.GetCost();
            double priceOfPurchasedcups = cupsToBuy * cupCost;
            double result;
            //act
            result = store.NumberOfCupsPurchased(cupsToBuy);
            //assert
            Assert.AreEqual(result, priceOfPurchasedcups);
        }
        [TestMethod]
        public void InventoryLemonsNeededForPitcher()
        {
            //arrange
            Player player = new Player();
            Recipe recipe = new Recipe();
            recipe.numberOfPitchers = 3;
            int numberOfLemonsInEachPitcher = 6;
            int totalAmountOfLemonsNeeded = recipe.numberOfPitchers * numberOfLemonsInEachPitcher;
            int result;
            //act
            result = recipe.TakeLemonsOut(player);
            //assert
            Assert.AreEqual(result, totalAmountOfLemonsNeeded);
        }
        [TestMethod]
        public void InventoryLemonsNeededForPitcherZero()
        {
            //arrange
            Player player = new Player();
            Recipe recipe = new Recipe();
            recipe.numberOfPitchers = 0;
            int numberOfLemonsInEachPitcher = 6;
            int totalAmountOfLemonsNeeded = recipe.numberOfPitchers * numberOfLemonsInEachPitcher;
            int result;
            //act
            result = recipe.TakeLemonsOut(player);
            //assert
            Assert.AreEqual(result, totalAmountOfLemonsNeeded);
        }
        [TestMethod]
        public void InventoryOfSugarNeededForPitcher()
        {
            //arrange
            Player player = new Player();
            Recipe recipe = new Recipe();
            recipe.numberOfPitchers = 7;
            int numberOfLemonsInEachPitcher = 7;
            int totalAmountOfSugarNeeded = recipe.numberOfPitchers * numberOfLemonsInEachPitcher;
            int result;
            //act
            result = recipe.TakeSugarOut(player);
            //assert
            Assert.AreEqual(result, totalAmountOfSugarNeeded);
        }
        [TestMethod]
        public void InventoryOfSIceNeededForPitcher()
        {
            //arrange
            Player player = new Player();
            Recipe recipe = new Recipe();
            recipe.numberOfPitchers = 10;
            int numberOfIceInEachPitcher = 25;
            int totalAmountOfIceNeeded = recipe.numberOfPitchers * numberOfIceInEachPitcher;
            int result;
            //act
            result = recipe.TakeIceOut(player);
            //assert
            Assert.AreEqual(result, totalAmountOfIceNeeded);
        }
        [TestMethod]
        public void InventoryOfSIceNeededForPitcherNegative()
        {
            //arrange
            Player player = new Player();
            Recipe recipe = new Recipe();
            recipe.numberOfPitchers = -3;
            int numberOfIceInEachPitcher = 25;
            int totalAmountOfIceNeeded = recipe.numberOfPitchers * numberOfIceInEachPitcher;
            int result;
            //act
            result = recipe.TakeIceOut(player);
            //assert
            Assert.AreEqual(result, totalAmountOfIceNeeded);
        }
        [TestMethod]
        public void InventoryOfCupsNeededForPitcher()
        {
            //arrange
            Player player = new Player();
            Recipe recipe = new Recipe();
            recipe.numberOfPitchers = 1;
            int numberOfCupsInEachPitcher = 10;
            int totalAmountOfCupsNeeded = recipe.numberOfPitchers * numberOfCupsInEachPitcher;
            int result;
            //act
            result = recipe.TakeCupOut(player);
            //assert
            Assert.AreEqual(result, totalAmountOfCupsNeeded);
        }
        [TestMethod]
        public void CheckRandomizerConditionsWeekly()
        {
            //arrange
            Weather weather = new Weather(new Random());
            //act
            weather.ConditionWeeklyWeather();
            //assert
            Assert.IsTrue(weather.condition == "sunny" || weather.condition == "cloudy" || weather.condition == "partly cloudy" || weather.condition == "foggy" || weather.condition == "rainy");
        }
        [TestMethod]
        public void CheckRandonizerTempsWeekly()
        {
            //arrange
            Weather weather = new Weather(new Random());
            //act
            weather.TempWeeklyWeather();
            //assert
            Assert.IsTrue(weather.temperature == 60 || weather.temperature == 70 || weather.temperature == 80 || weather.temperature == 90 || weather.temperature == 100);
        }


    }
}
//arrange
//act
//assert