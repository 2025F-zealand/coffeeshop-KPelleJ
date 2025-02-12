using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public abstract class Coffee
    {
        public string Name { get; protected set; }
        public int Discount { get; protected set; }
        private Blend Blend { get; set; }


        public Coffee(int discount, Blend blend) 
        {
            if (discount > 5 || discount < 0)
            {
                throw new ArgumentOutOfRangeException("discount","The discount must be between 0 and 5");
            }

            Blend = blend;
            Discount = discount;
        }

        public virtual int Price()
        {
            return 20-Discount; 
        }

        public abstract string Strength();
    }
}
