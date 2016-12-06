using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
   public class Wallet
    {
       double moneyInWallet;
        bool bankrupt;
        double completeTransaction;
        double costOfProduct;

       //double amountInWallet;


        public void setPullMoneyOut()
        {
            moneyInWallet = 10.00;
        }
        public double GetPullMoneyOut()
        {
            return moneyInWallet;
        }

        public void checkIfBankrupt(double CostOfProduct)
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
        }

        //public double displayAmountInWallet(Player player)
        //{
        //    amountInWallet = startUpMoney - player.checkOut();//playerClass; 
 
        //}
        //public void displayAmountInWallet(Player player)
        //{
        //    amountInWallet = startUpMoney - player.displayLemonsPurchased();//playerClass; 

        //}
        //public void displayAmountInWallet(Player player)
        //{
        //    amountInWallet = startUpMoney - player.displaySugarPurchased();//playerClass; 

        //}
        //public void displayAmountInWallet(Player player)
        //{
        //    amountInWallet = startUpMoney - player.displayIceCubesPurchased();//playerClass; 

        //}
        //public void displayAmountInWallet(Player player)
        //{
        //    amountInWallet = startUpMoney - player.displayCupsPurchased();//playerClass; 

        //}
    }
}
