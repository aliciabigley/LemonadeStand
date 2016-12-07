using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
   public class Wallet
    {
       double moneyInWallet = 10.0;
        bool bankrupt;
        double completeTransaction;
        double costOfProduct;

       //double amountInWallet;


        //public void setPullMoneyOut()
        //{
        //    moneyInWallet = 10.00; //if changed, change in "welcome" too.
        //}
        public double GetPullMoneyOut()
        {
            return moneyInWallet;
        }

        public void checkIfBankrupt(double CostOfProduct) //bug here
        {
            if (moneyInWallet <= CostOfProduct)
            {
                bankrupt = true;
                Console.WriteLine("Sorry! You don't have enough money in your wallet.");
            }
        }
        public void buyProduct(double costOfProduct)
        {
            completeTransaction = (moneyInWallet) - (costOfProduct);
            Console.WriteLine("Transaction Approved!! ");
        }
    }
}

