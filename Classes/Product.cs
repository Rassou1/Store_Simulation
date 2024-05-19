using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3_Form.Classes
{
    internal class Product
    {
        string name;
        double price;
        categoryType category;

        public enum categoryType
        {
            Produce,
            Electronics,
            Bread
        }

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

