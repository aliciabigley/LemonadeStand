using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Day
    {
        public Weather weather;
        public Customers customer;
        int customersThoughoutDay = 50;
        Random random;
        int userInput;
        double moneyEarned;
        public double willingToPay;
        int cupsToBeBought;
        double pricePerCup;
        public List<Customers> customers = new List<Customers>();
        List<double> costCustomersWillPay = new List<double> { .25, 1.00, .75, .90, 1.25 };
        List<int> cupsCustomersWillBuy = new List<int> { 1, 2, 1, 3, 1 };
        public Day(Random random)
        {
            weather = new Weather(random);
            this.random = random;
        }
        //public int ChooseGameLenght()
        //{
        //    //Console.WriteLine("How many days would you like to run your stand? [7] [14]");
        //    //int userInput = int.Parse(Console.ReadLine());
        //    //this.userInput = userInput;
        //    //return this.userInput; 
        //}
        public double PriceOfCup()
        {
            Console.WriteLine("Before we start the day, please set the cost for 1 cup of lemonade:");
            double pricePerCup = double.Parse(Console.ReadLine());
            this.pricePerCup = pricePerCup;
            return this.pricePerCup;
        }
        public void DeterminedGameLenght() //move to game class
        {
            if (userInput == 7)
            {
                for (int i = 0; i < 7; i++)
                {

                }
            }
           
        }
        public double PayingCustomers()
        {
            int customersWillingToPay = random.Next(0, costCustomersWillPay.Count);
            willingToPay = costCustomersWillPay[customersWillingToPay];
            return willingToPay;

        }
        public int CustomersWillingnessToBuy()
        {
            int howManyCupsWillBeBought = random.Next(0, cupsCustomersWillBuy.Count);
            cupsToBeBought = cupsCustomersWillBuy[howManyCupsWillBeBought];
            return cupsToBeBought;
        }

        public void CreateCustomers()
        {
            for (int i = 0; i < customersThoughoutDay; i++)
            {                
                int numberOfCups = CustomersWillingnessToBuy(); // number of cups to be purchase if price is met 
                double amountToPay = PayingCustomers(); //at which price will the customer buy a cup
                Customers customer = new Customers(amountToPay, numberOfCups);  //creates multiple customers
                customers.Add(customer);
            }
        }
        public double SellLemonade(Player player)
        {
            foreach (Customers customer in customers)
            {
                if (customer.buy == true)
                {
                    moneyEarned = player.wallet.moneyInWallet + pricePerCup;
                    Console.WriteLine("You earned {0}!", moneyEarned);
                    player.wallet.moneyInWallet += moneyEarned;
                }
            }
            return player.wallet.moneyInWallet;
        }
    }
}        
