using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp4
{
    public class Product
    {
        public string Name;
        public double Price;

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

    }
    public class Program
    {
        public static IEnumerable<string> GetNames(IEnumerable<Product> products)
        {
            //return products.Select(p => p.Name);

            return from p in products
                   select p.Name;


            //foreach (var product in products)
            //{
            //    yield return product.Name;
            //}
        }

        public static void Main()
        {
            var products = new[]
            {
                new Product("Apple", 10),
                new Product("Banana", 15),
                new Product("Cherry", 20)
            };

            var names = GetNames(products);
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
