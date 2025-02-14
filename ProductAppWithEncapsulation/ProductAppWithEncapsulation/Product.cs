using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAppWithEncapsulation
{
    internal class Product
    {
        private int productId;
        private string productName;
        private double productPrice;
        private double productDiscount;

        public int ProductId
        {
            get { return productId; }
            set
            {
                if (value > 0)
                    productId = value;
                else
                    productId = 1; // Default
            }

        }
        public string ProductName
        {
            get { return productName; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    productName = value;
                else
                    productName = "Unknown";
            }
        }
        public double ProductPrice
        {
            get { return productPrice; }
            set
            {
                if (value >= 0)
                    productPrice = value;
                else
                    productPrice = 0; 
            }
        }
        public double ProductDiscount
        {
            get { return productDiscount; }
            set
            {
                if (value >= 0 && value <= 100)
                    productDiscount = value;
                else
                    productDiscount = 0; 
            }
        }
        public double FinalPrice
        {
            get { return ProductPrice - (ProductPrice * ProductDiscount / 100); }
        }
        public Product(int productId, string productName, double productPrice, double productDiscount)
        {
            ProductId = productId;
            ProductName = productName;
            ProductPrice = productPrice;
            ProductDiscount = productDiscount;
        }

        
        public void DisplayProductDetails()
        {
            Console.WriteLine($"ProductId: {ProductId}, ProductName: {ProductName}, ProductPrice: {ProductPrice}, ProductDiscount: {ProductDiscount}%, FinalPrice: {FinalPrice}");
        }
    }
}