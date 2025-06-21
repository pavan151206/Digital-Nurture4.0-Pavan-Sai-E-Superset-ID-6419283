using System;
using System.Collections.Generic;

namespace week1.EcommerceSearch
{
    public static class Program
    {
        static void Main(string[] args)  // Fixed: Capital 'M' in Main, lowercase 's' in string
        {
            List<Product> products = new List<Product>
            {
                new Product(1, "Laptop", "High performance laptop", 75000),
                new Product(2, "Smartphone", "Latest model smartphone", 55000),
                new Product(3, "Tablet", "Portable tablet with stylus", 20000)
            };
            
            Console.WriteLine("Enter search term:");
            string searchTerm = Console.ReadLine() ?? string.Empty;

            LinearSearch(products, searchTerm);
        }

        public static void LinearSearch(List<Product> products, string searchTerm)
        {
            List<Product> results = new List<Product>();
            foreach (Product product in products)
            {
                if (product.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase) ||
                    product.Description.Contains(searchTerm, StringComparison.OrdinalIgnoreCase))
                {
                    results.Add(product);
                }
            }

            if (results.Count > 0)
            {
                Console.WriteLine("Search Results:");
                foreach (Product product in results)
                {
                    Console.WriteLine($"ID: {product.Id}, Name: {product.Name}, Price: {product.Price}");
                }
            }
            else
            {
                Console.WriteLine("No products found.");
            }
        }
    }
}