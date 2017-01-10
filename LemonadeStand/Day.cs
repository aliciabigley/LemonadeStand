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
        Random random;
        //List<Customers> customers = new List<Customers>();
        int userInput;
        public double willingToPay;
        int cupsToBeBought;
        List<Customers> customers = new List<Customers>();
        List<double> costCustomersWillPay = new List<double> { .25, 1.00, .75, .90, 1.25 };
        List<int> cupsCustomersWillBuy = new List<int> { 1, 2, 1, 3, 1 };
        public Day(Random random)
        {
            weather = new Weather(random);
            this.random = random;
        }
        public int ChooseGameLenght()
        {
            Console.WriteLine("How many days would you like to run your stand? [7] [14]");
            int userInput = int.Parse(Console.ReadLine());
            this.userInput = userInput;
            return this.userInput; 
        }
        public void DeterminGameLenght() //move to game class
        {
            
            if (userInput == 7)
            {
                for (int i = 0; i < 7; i++)
                {
                    for (int j = 1; j < 1; j++)
                    {
                        //run play day here
                    }
                }
            }
            if (userInput == 14)
            {
                for (int i = 0; i < 14; i++)
                {
                    for (int j = 1; j < 1; j++)
                    {
                        //run play day here
                    }
                }
            }
        }
        //public void Displayweather()
        //{
        //    Console.WriteLine(weather.WeeklyWeather());
        //}
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
            
            for (int i = 0; i < 50; i++)
            {
                Customers customer = new Customers();  //creates multiple customers
                CustomersWillingnessToBuy(); // number of cups to be purchase if price is met 
                PayingCustomers(); //at which price will the customer buy a cup
                weather.TempWeather(); //if weather is ___ temp, customer buys 
                
                //customers.Add(weather.temperature);
                //customers.Add(willingToPay);        
                //customers.Add(cupsToBeBought)
                customers.Add(customer);
            }
             
            //return customers;
        }
       

    }
}
