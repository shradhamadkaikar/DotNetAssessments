using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.ConstructorAssesment
{
    public class Product
    {
        private int code;
        private string name;
        private double price;
        private double discountedPrice;

        public Product(int productCode, string productName, double productPrice)
        {
            this.code = productCode;
            this.name = productName;
            this.price = productPrice;

            ApplyDiscount();
        }

        private void ApplyDiscount()
        {
            if (price > 1000)
            {
                discountedPrice = price * 0.90; 
            }
            else
            {
                discountedPrice = price;
            }
        }

        public void Display()
        {
            Console.WriteLine($"Product Code: {code}");
            Console.WriteLine($"Product Name: {name}");
            Console.WriteLine($"Original Price: {price}");
            Console.WriteLine($"Discounted Price: {discountedPrice}");
        }
    }
}
