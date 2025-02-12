﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Latte : Coffee, IMlMilk
    {
        public Latte(int discount):base(discount) 
        {
            this.Name = "Latte";
        }

        public int mlMilk()
        {
            return 200;
        }

        public override int Price()
        {
            return 40-Discount;    
        }

        public override string Strength()
        {
            return "Weak";
        }
    }
}
