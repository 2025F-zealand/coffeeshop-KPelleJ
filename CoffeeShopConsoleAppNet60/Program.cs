using CoffeeShopConsoleAppNet60;
using System.ComponentModel;

internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            List<Coffee> coffeeMenu = new List<Coffee>() { new BlackCoffee(3, Blend.Reshad), new Cortado(4, Blend.Bacca), new Latte(5, Blend.Reshad) };
            List<IMlMilk> coffeeWithMilk = new List<IMlMilk>() { new Cortado(3, Blend.Kieni), new Latte(2, Blend.Potente), new Cortado(5, Blend.Reshad) };

            Order order1 = new Order("Jenny","Ronny",5,coffeeMenu);

            Console.WriteLine($"The Coffee Menu:");
            foreach (Coffee coffee in coffeeMenu)
            {
                Console.WriteLine($"{coffee.Name} -- {coffee.Price()} -- Strength: {coffee.Strength()}");
            }

            Console.WriteLine(order1.ToString());

            Console.WriteLine("\nBlends:");
            foreach (var item in Enum.GetValues(typeof(Blend)))
            {
                Console.WriteLine(item);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }

        Console.ReadKey();
    }
}