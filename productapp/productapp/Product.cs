using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace productapp
{
    internal class Product
    {
        public int productId {  get; set; }
        public string productName { get; set; }
        public double productPrice {  get; set; }
        public double productDiscount{  get; set; }

        public double finalPrice;

        public Product(int productId,string produstName,double productPrice ,double productDiscount) {
        
            this.productId = productId;
            this.productName = produstName;
            this.productPrice = productPrice;
            this.productDiscount=productDiscount;
        }
        public double GetFinalAmount() {


            finalPrice = productPrice -  (productPrice * productDiscount / 100);
            
            return finalPrice;
        }

        public void DisplayProductDetails()
        {
            GetFinalAmount();
            Console.WriteLine($" ProductId: { productId} , ProductName: {productName} , ProductPrice: {productPrice}, ProductDiscount: {productDiscount}% , FinalPrice: {finalPrice}");
        }
    }
}
