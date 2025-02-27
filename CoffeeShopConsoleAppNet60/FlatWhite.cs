﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class FlatWhite : Coffee, IMlMilk
    {
        public FlatWhite(int discount, Blend blend) : base(discount, blend) 
        {
            this.Name = "Flat White";
        }

        public int MlMilk()
        {
            return 150;
        }

        public override int Price()
        {
            return 35-Discount;
        }

        public override string Strength()
        {
            return "Medium";
        }
    }
}
