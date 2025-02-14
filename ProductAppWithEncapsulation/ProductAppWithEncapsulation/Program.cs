using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductAppWithEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product(101, "Laptop", 50000, 10);
            Product product2 = new Product(-1, "", -500, 120); // Invalid values

            
            product1.DisplayProductDetails();
            product2.DisplayProductDetails(); //default values will be given to this
        }
    }
}
