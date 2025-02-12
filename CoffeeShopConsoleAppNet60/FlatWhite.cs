using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class FlatWhite : Coffee, IMlMilk
    {
        public FlatWhite(int discount):base(discount) 
        {
            this.Name = "Flat White";
        }

        public int mlMilk()
        {
            return 150;
        }

        public override int Price()
        {
            return 5000000-Discount;
        }

        public override string Strength()
        {
            return "Medium";
        }
    }
}
