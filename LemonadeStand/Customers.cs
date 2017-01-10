using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
   public class Customers
    {
        double percent= 100; 
        double tempProbability;
        double conditionProbability;
        double costProbability;
       
        public void ChanceToBuyTemp(Weather weather)
        {
            if (weather.temperature <= 70)
            {
                tempProbability=percent * .15;
            }
            else if (weather.temperature >= 80)
            {
                tempProbability = percent * .50;
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

        public void WillBuy()
        {
            List<double> actualChanceToBuy = new List<double>();
            actualChanceToBuy.Add(tempProbability);
            actualChanceToBuy.Add(conditionProbability);
            actualChanceToBuy.Add(costProbability);
            actualChanceToBuy.Average();
        }
        //List<Customers> customers = new List<Customers>();
        //Random random;
        //public double willingToPay;
        //public int cupsToBeBought;
        //List<double> costCustomersWillPay = new List<double> { .25, 1.00, .75, .90, 1.25 };
        //List<int> cupsCustomersWillBuy = new List<int> { 1, 2, 1, 3, 1 };
        // double[] costCustomersWillPay = new double[] { .25, 1.00, .75, .90, 1.25 };
        //public int[] cupsCustomersWillBuy = new int[] { 1, 2, 1, 3, 1 };



    }
}
