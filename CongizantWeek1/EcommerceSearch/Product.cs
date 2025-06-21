using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace week1.EcommerceSearch
{
    public class Product
    {
        private int id;
        private string name;
        private string description;
        private decimal price;

        public Product(int id, string name, string description, decimal price)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.price = price;
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}