using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    internal class Espresso : Coffee
    {
        public Espresso(int discount, Blend blend) : base(discount, blend)
        {
            this.Name = "Espresso";
        }

        public override int Price()
        {
            return 30-Discount;
        }

        public override string Strength()
        {
            return "Strong";
        }
    }
}
