﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Lemon
    {
        private double lemonCost;
        private string lemonName;
        public void setLemonCost()
        {
            lemonCost = 0.10;
        }
        public double getCupCost()
        {
            return lemonCost;
        }
        public void setLemonName()
        {
            lemonName = "Lemon";
        }
        public string getLemonName()
        {
            return lemonName;
        }
    }
}