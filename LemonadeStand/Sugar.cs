﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Sugar
    {
        double sugarCost;
        string sugarName;
        public void setSugarCost()
        {
            sugarCost = 0.50;
        }
        public double getSugarCost()
        {
            return sugarCost;
        }
        public void setSugarName()
        {
            sugarName = "Sugar";
        }
        public string getSugarName()
        {
            return sugarName;
        }
    }
}