using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Latte : Coffee
    {
        public Latte() 
        {
            this.Name = "Latte";
        }

        public override int Price()
        {
            return 40;    
        }

        public override string Strength()
        {
            return "Weak";
        }
    }
}
