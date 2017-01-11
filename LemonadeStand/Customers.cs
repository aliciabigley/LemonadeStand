using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
   public class Customers
    {
        Random random;
        double percent= 100;
        public int numberOfCupsToBuy;
        double chanceToBuy;
        double temperatureProbability;
        double conditionProbability;
        double costProbability;
        public double willPayMax;
        public bool buy;

        public Customers(double WillPayMax, int NumberOfCupsToBuy)
        {
            willPayMax = WillPayMax;
            numberOfCupsToBuy = NumberOfCupsToBuy;
            
        }
        public void ChanceToBuyTemperature(Weather weather)
        {
            if (weather.temperature <= 70)
            {
                temperatureProbability=percent * .15;
            }
            else if (weather.temperature >= 80)
            {
                temperatureProbability = percent * .50;
            }
        }
        public void ChanceToBuyCondtion(Weather weather)
        {
            if (weather.condition == "sunny")
            {
                conditionProbability = percent * .85;
            }
            else if (weather.condition == "cloudy" || weather.condition == "partly cloudy")
            {
                conditionProbability = percent * .45;
            }
            else if (weather.condition == "rainy" || weather.condition == "foggy")
            {
                conditionProbability = percent * .15;
            }
        }
        public void ChanceToBuyCost(Day day)
        {
            if (day.willingToPay == .25)
            {
                costProbability = percent * .100;
            }
            else if (day.willingToPay == .75)
            {
                costProbability = percent * .87;
            }
            else if (day.willingToPay == .90 || day.willingToPay == 1.00)
            {
                costProbability = percent * .70;
            }
            else if (day.willingToPay == 1.25)
            {
                costProbability = percent * .50;
            }
        }

        public double WillBuy()
        {
            List<double> actualChanceToBuy = new List<double>();
            actualChanceToBuy.Add(temperatureProbability);
            actualChanceToBuy.Add(conditionProbability);
            actualChanceToBuy.Add(costProbability);
            double chanceTobuy = actualChanceToBuy.Average();//round
            this.chanceToBuy = chanceTobuy;
            return this.chanceToBuy;
        }

        public bool CustomerBuysLemonade(int randomValue)
        {
            int value = randomValue;
            if (chanceToBuy >= value)
            {
                buy = false;
            }
            else
            {
                buy = true;
            }
            return this.buy;
        }
        public void DeterminesCustomerBuys(Weather weather, Day day, int randomValue) // should I run this prior to RunGame?
        {
            ChanceToBuyTemperature(weather);
            ChanceToBuyCondtion(weather);
            ChanceToBuyCost(day);
            CustomerBuysLemonade(randomValue);
        }
    }
}
