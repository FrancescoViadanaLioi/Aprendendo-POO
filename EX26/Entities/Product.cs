using System;
using System.Globalization;

namespace EX26.Entities
{
    internal class Product : IComparable
    {
        public string Name { get; private set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public int CompareTo(object obj)
        {
            if (!(obj is Product))
            {
                throw new ArgumentException($"Comparing error: Argument is not a product.");
            }
            if (obj == null)
            {
                throw new ArgumentNullException("Null error: The object cannot be null.");
            }
            Product p = obj as Product;
            return Price.CompareTo(p.Price);
        }

        public override string ToString()
        {
            return $"Name: {this.Name}; Price: ${this.Price.ToString(CultureInfo.InvariantCulture)}";
        }
    }
}
