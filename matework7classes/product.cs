using System;
using System.Collections.Generic;
using System.Text;

namespace matework7classes
{
    internal class product
    {
        public class Product
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double Price { get; set; }
            public bool Nuts { get; set; }
            public string Image { get; set; }
            public bool Vegetarian { get; set; } 
            public int Spiciness { get; set; } 
            public string Category { get; set; }

            public Product(int id, string name, double price, bool nuts,
                           string image, bool vegetarian, int spiciness, string category)
            {
                Id = id;
                Name = name;
                Price = price;
                Nuts = nuts;
                Image = image;
                Vegetarian = vegetarian;
                Spiciness = spiciness;
                Category = category;
            }

            public bool IsSpicy()
            {
                return Spiciness > 0;
            }

            public string GetSpicinessLabel()
            {
                if (Spiciness == 0) return "Not spicy";
                if (Spiciness <= 2) return "Mild";
                if (Spiciness <= 4) return "Medium";
                return "Hot";
            }

            public string GetFormattedPrice()
            {
                return $"${Price:F2}";
            }

            public void ApplyDiscount(double percent)
            {
                if (percent < 0 || percent > 100)
                {
                    Console.WriteLine("Discount must be between 0 and 100.");
                    return;
                }
                Price = Price - (Price * percent / 100);
            }

            public string GetAllergyWarning()
            {
                return Nuts ? "Contains nuts!" : "Nut-free";
            }

            public bool IsInCategory(string category)
            {
                return Category.Equals(category, StringComparison.OrdinalIgnoreCase);
            }

            public void PrintInfo()
            {
                Console.WriteLine($"#{Id} {Name} ({Category})");
                Console.WriteLine($"  Price:      {GetFormattedPrice()}");
                Console.WriteLine($"  Vegetarian: {(Vegetarian ? "Yes" : "No")}");
                Console.WriteLine($"  Spiciness:  {Spiciness} - {GetSpicinessLabel()}");
                Console.WriteLine($"  Allergy:    {GetAllergyWarning()}");
                Console.WriteLine($"  Image:      {Image}");
            }
        }
    }
}
