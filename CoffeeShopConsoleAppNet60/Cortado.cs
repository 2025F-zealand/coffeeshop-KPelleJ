﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Cortado : Coffee, IMlMilk
    {
        public Cortado(int discount, Blend blend) : base(discount, blend) 
        {
            this.Name = "Cortado";
        }

        public int MlMilk()
        {
            return 40;
        }

        public override int Price()
        {
            return 25-Discount;
        }

        public override string Strength()
        {
            return "Medium";
        }
    }
}
