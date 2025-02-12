using CoffeeShopConsoleAppNet60;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Coffee> coffeeMenu = new List<Coffee>() { new BlackCoffee(3), new Cortado(4), new Latte(5)};

        List<IMlMilk> coffeeWithMilk = new List<IMlMilk>() { new Cortado(3), new Latte(2), new Cortado(5)};

        Console.WriteLine($"The Coffee Menu:");
        foreach (Coffee coffee in coffeeMenu)
        {
            Console.WriteLine($"{coffee.Name} -- {coffee.Price()}");
        }

    }
}