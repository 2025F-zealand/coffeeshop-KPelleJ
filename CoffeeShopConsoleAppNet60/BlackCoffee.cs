using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class BlackCoffee : Coffee
    {
        public BlackCoffee(int discount, Blend blend):base(discount, blend)
        {
            this.Name = "Black Coffee";
        }

        public override string Strength()
        {
            return "Strong";
        }
    }
}
