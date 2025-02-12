using CoffeeShopConsoleAppNet60;

internal class Program
{
    private static void Main(string[] args)
    {
        List<Coffee> coffeeMenu = new List<Coffee>() { new BlackCoffee(), new Cortado(), new Latte()};

        Console.WriteLine($"The Coffee Menu:");
        foreach (Coffee coffee in coffeeMenu)
        {
            Console.WriteLine($"{coffee.Name} -- {coffee.Price()}");
        }
    }
}