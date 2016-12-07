using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Cup

    {
        private double cupCost = .05;
        private string cupName;
        //public void setCupCost()
        //{
        //    cupCost = 0.05;
        //}
        public double getCupCost()
        {
            return cupCost;
        }
        public void setCupName()
        {
            cupName = "Cups";
        }
        public string getCupName()
        {
            return cupName;
        }

    }
}
