using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Ice
    {
        double iceCost = .05;
        string iceName;
        //public void setIceCost()
        //{
        //    iceCost = 0.05;
        //}
        public double getIceCost()
        {
            return iceCost;
        }
        public void setIceName()
        {
            iceName = "Ice";
        }
        public string getIceName()
        {
            return iceName;
        }
    }
}
