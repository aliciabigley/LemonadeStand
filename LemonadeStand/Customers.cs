using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customers
    {
        List<Customers> customers = new List<Customers>();

        Random random;
        public double willingToPay;
        public int cupsToBeBought;
        List<double> costCustomersWillPay = new List<double> { .25, 1.00, .75, .90, 1.25 };
        List<int> cupsCustomersWillBuy = new List<int> { 1, 2, 1, 3, 1 };
       // double[] costCustomersWillPay = new double[] { .25, 1.00, .75, .90, 1.25 };
        //public int[] cupsCustomersWillBuy = new int[] { 1, 2, 1, 3, 1 };

        public Customers(Random random)
        {
            this.random = random;
        }

        public void PayingCustomers()
        {
            int customersWillingToPay = random.Next(0, costCustomersWillPay.Count);
            willingToPay = costCustomersWillPay[customersWillingToPay];

        }
        public void CustomersWillingnessToBuy()
        {
            int howManyCupsWillBeBought = random.Next(0, cupsCustomersWillBuy.Count);
            cupsToBeBought = cupsCustomersWillBuy[howManyCupsWillBeBought];
        }

        public void CustomerType()
        {
             
            for (int i = 0; i < 50 ; i++) //Should 50 be here or should I put in number on pitchers x 10?
            {
                Customers customer = new Customers(random);
                customer.Insert(willingToPay); 
                customer.Add(cupsToBeBought);
            }
            //Console.WriteLine("You currently have {0} lemons.\n\n", lemons.Count);
        }


    }
}
