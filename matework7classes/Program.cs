using static matework7classes.product;

namespace matework7classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product pizza = new Product(1, "Margherita", 12.50, false, "pizza.jpg", true, 0, "Pizza");
            Product curry = new Product(2, "Chicken Curry", 15.00, true, "curry.jpg", false, 4, "Main");

            pizza.PrintInfo();
            Console.WriteLine();
            curry.PrintInfo();

            Console.WriteLine();
            Console.WriteLine("Applying 20% discount to curry...");
            curry.ApplyDiscount(20);
            Console.WriteLine($"New price: {curry.GetFormattedPrice()}");

            Console.WriteLine($"Is curry spicy? {curry.IsSpicy()}");
            Console.WriteLine($"Is pizza in 'pizza' category? {pizza.IsInCategory("pizza")}");
        }
    }
}
