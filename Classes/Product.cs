using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Assignment3_Form.Classes.Product;

namespace Assignment3_Form.Classes
{
    internal class Product
    {
        string name;
        double price;
        public enum categoryType
        {
            Produce,
            Electronics,
            Bread
        }
        

        public string Name { get { return name; } set { name = value; } }
        public double Price { get { return price; } set { price = value; } }

        categoryType category;

        public categoryType CategoryType { get { return category; } set { category = value; } }

        public Product(string name, double price, categoryType category)
        {
            this.name = name;
            this.price = price;
            this.category = category;
        }

        public override string ToString()
        {
            string productString = ($"{name} - {price}");
            return productString;
        }
        



    }
}

