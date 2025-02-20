using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopConsoleAppNet60
{
    public class Order
    {
        private static int _idCounter = 1;
        public int Id { get; private set; }
        public string BaristaName { get; set; }
        public string CustomerName {  get; set; }
        public int TableNumber { get; set; } = -1;
        public bool TakeAway { get; private set; }
        public List<Coffee> CoffesOnOrder { get; set; }

        public Order(string baristaName, string customerName, List<Coffee> coffees)
        {
            Id = _idCounter++;
            BaristaName = baristaName;
            CustomerName = customerName;
            TakeAway = true;

            CoffesOnOrder = coffees;
        }
        
        public Order(string baristaName, string customerName, int tableNumber, List<Coffee> coffees) : this(baristaName, customerName, coffees) 
        {
            TableNumber = tableNumber;
            TakeAway = false;
        }

        public int TotalPrice()
        {
            int output = CoffesOnOrder.Sum(c => c.Price());
            return output;
        }

        public int OrderItemCount()
        {
            return CoffesOnOrder.Count;
        }

        public int TotalDiscount()
        {
            int output = CoffesOnOrder.Sum(c => c.Discount);
            return output;
        }

        public override string ToString()
        {
            StringBuilder orderDetails = new StringBuilder();
            orderDetails.Append($"\n{DateTime.Now.ToString("dd/MM/yyyy-HH:mm")}\n");
            orderDetails.AppendLine($"Order details for order ID: {this.Id}\n");
            orderDetails.AppendLine($"Customer name: {this.CustomerName}");
            orderDetails.AppendLine($"Order items:");

            foreach (var c in CoffesOnOrder)
            { 
                orderDetails.AppendLine($"{c.Name} -- {c.Price()}kr"); 
            }

            orderDetails.AppendLine($"Number of items: {this.OrderItemCount()}");
            orderDetails.AppendLine($"Total price = {this.TotalPrice()}kr (discount = {this.TotalDiscount()})");
            orderDetails.AppendLine($"We hope you enjoy your coffee, you have been served by {this.BaristaName}");

            return orderDetails.ToString();
        }
    }
}
